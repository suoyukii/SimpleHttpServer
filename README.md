<h1 align="center">SimpleHTTPserver</h1>
<h4 align="center">Simple HTTP server in CSharp</h4>

<p align="center">
  <a href="https://opensource.org/licenses/MIT">
    <img src="http://img.shields.io/badge/License-MIT%20License-1e90ff.svg"/>
  </a>
  <a href="https://dotnet.microsoft.com">
    <img src="http://img.shields.io/badge/.Net-8.0-1e90ff.svg"/>
  </a>
</p>

<p align="center">
  <a href="#features">Features</a> ·
  <a href="#install">Install</a> ·
  <a href="#usage">Usage</a>
</p>

---

SimpleHTTPServer is a lightweight http server software.

# Features

- HTTP/S Web Server
- HTTP request/response dump
- Configurable IP address and listening port, configured via `config.toml`
- Configurable HTTP server, configured via `config.toml`
- Configurable URL routing, configured via `url_routing.toml`
- Configurable mine type, configured via `mine_type.toml`

# Install

SimpleHTTPserver requires **.Net 8.0** to run successfully.

- [Dowload .Net 8.0](https://dotnet.microsoft.com/zh-cn/download/dotnet/latest/runtime)
- [Dowload SimpleHTTPServer](https://github.com/suoyukii/SimpleHTTPServer/releases)

# Usage

To run simply open `simplehttpserver.exe`.

Close the window of `simplehttpserver.exe` to stop it from running.

- Run the following command on the console.

```shell
simplehttpserver
```

Open a browser and enter the IP address configured by `ip_list` in `config.toml`.

Below is the default IP address set in `config.toml`, which can be quickly previewed by clicking on the jump when SimpleHTTPServer is turned on.

- IPv4 default IP address

```url
http://127.0.0.1
```

- IPv6 default IP address

```url
http://[::1]
```