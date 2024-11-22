<h1 align="center">Simple HTTP Server</h1>
<h4 align="center">用 .NET 9 开发简单的 HTTP 服务器</h4>

<p align="center">
  <a href="https://opensource.org/licenses/MIT">
    <img src="http://img.shields.io/badge/License-MIT-1e90ff?style=for-the-badge"/>
  </a>
  <a href="https://dotnet.microsoft.com">
    <img src="http://img.shields.io/badge/.NET-9.0-1e90ff?style=for-the-badge"/>
  </a>
</p>

<p align="center">
  <a href="/#features">
    <img src="http://img.shields.io/badge/功能-1e90ff?style=for-the-badge"/>
  </a>
  <a href="/#install">
    <img src="http://img.shields.io/badge/安装-1e90ff?style=for-the-badge"/>
  </a>
  <a href="/#usage">
    <img src="http://img.shields.io/badge/使用-1e90ff?style=for-the-badge"/>
  </a>
</p>

---

中文名：简单 HTTP 服务器

SimpleHttpServer 是一款轻量级 HTTP 服务器软件。

## ✨ 功能

- HTTP/S 网络服务器
- HTTP `请求` / `响应` 转储
- 可配置 `IP 地址` 和 `监听端口`，通过 `config.toml` 配置
- 可配置 `HTTP 服务器`，通过 `config.toml` 配置
- 可配置 `URL 路由`，通过 `url_routing.toml` 配置
- 可配置 `MINE 类型`，通过 `mine_type.toml` 配置

## ✨ 安装

- [下载 SimpleHTTPServer](https://github.com/suoyukii/SimpleHTTPServer/releases)

## ✨ 使用

运行时只需打开 `simplehttpserver.exe`。

关闭 `simplehttpserver.exe` 窗口，使其停止运行。

- 在控制台运行以下命令

```sh
simplehttpserver
```

打开浏览器，输入 `config.toml` 中 `ip_list` 配置的 IP 地址。

下面是在 `config.toml` 中设置的默认 IP 地址，打开 `SimpleHTTPServer` 后点击跳转即可快速预览。

- IPv4 默认 IP 地址

```sh
http://127.0.0.1
```

- IPv6 默认 IP 地址

```sh
http://[::1]
```