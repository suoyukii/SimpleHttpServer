namespace SimpleHttpServer;

public class Class
{
    public string root_dir { get; set; }
    public bool is_https { get; set; }
    public string[] ip_list { get; set; }
}

public class MineType
{
    public string[][] list { get; set; }
}

public class UrlRouting
{
    public string[][] list { get; set; }
}