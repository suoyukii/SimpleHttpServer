using System.Net;
using SimpleHttpServer;
using Tomlyn;

var config = Toml.ToModel<Class>(File.ReadAllText("config.toml"));
var mine_type_list = Toml.ToModel<MineType>(File.ReadAllText("mine_type.toml")).list;
var url_routing_list = Toml.ToModel<UrlRouting>(File.ReadAllText("url_routing.toml")).list;
HttpListener server = new();
var ip_list = config.ip_list;
foreach (var ip in ip_list)
    server.Prefixes.Add(config.is_https switch
    {
        true => "https://",
        false => "http://"
    } + ip + "/");
var root_dir = Directory.GetCurrentDirectory() + "/" + config.root_dir;
Console.WriteLine("The HTTP server has been started.");
server.Start();

while (true)
{
    var context = server.GetContext();
    var response = context.Response;
    var resource_url = root_dir + context.Request.Url.LocalPath;

    // URL Routing
    foreach (var url_routing in url_routing_list)
    {
        if (context.Request.Url.LocalPath == url_routing[0])
        {
            resource_url = root_dir + "/" + url_routing[1];
            break;
        }
    }

    // HTTP status code 404
    if (!File.Exists(resource_url))
    {
        if (context.Request.Url.LocalPath == "/favicon.ico") continue;
        response.StatusCode = 404;
        resource_url = root_dir + "/404.html";
    }

    var stream = new FileStream(resource_url, FileMode.Open, FileAccess.Read);
    var ms = new MemoryStream();
    stream.CopyTo(ms);
    var buffer = ms.ToArray();
    ms.Close();
    stream.Close();
    // Resource MINE
    var is_steam_mine = true;
    foreach (var mine_type in mine_type_list)
        if (resource_url.EndsWith(mine_type[0]))
        {
            response.ContentType = mine_type[1];
            is_steam_mine = false;
            break;
        }

    if (is_steam_mine) response.ContentType = "application/octet-stream";

    response.ContentLength64 = buffer.Length;
    try
    {
        response.OutputStream.Write(buffer);
    }
    catch
    {
        // ignored
    }
    finally
    {
        response.Close();
    }
}