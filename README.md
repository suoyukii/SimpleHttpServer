<h1 align="center">Simple HTTP Server</h1>
<h4 align="center">Simple HTTP server in .NET 9</h4>

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
    <img src="http://img.shields.io/badge/Features-1e90ff?style=for-the-badge"/>
  </a>
  <a href="/#install">
    <img src="http://img.shields.io/badge/Install-1e90ff?style=for-the-badge"/>
  </a>
  <a href="/#usage">
    <img src="http://img.shields.io/badge/Usage-1e90ff?style=for-the-badge"/>
  </a>
</p>

<p align="center">
  <img src="https://img.shields.io/badge/English-lightgray?style=for-the-badge"/>
  <a href="README/zh-cn.md">
    <img src="https://img.shields.io/badge/简体中文-1e90ff?style=for-the-badge"/>
  </a>
</p>

---

SimpleHttpServer is a lightweight HTTP server software.

## ✨ Features

- HTTP/S Web Server
- HTTP `Request` / `Response` dump
- Configurable `IP Address` and `Listening Port`, configured via `config.toml`
- Configurable `HTTP Server`, configured via `config.toml`
- Configurable `URL Routing`, configured via `url_routing.toml`
- Configurable `MINE Type`, configured via `mine_type.toml`

## ✨ Install

- [Dowload SimpleHTTPServer](https://github.com/suoyukii/SimpleHTTPServer/releases)

## ✨ Usage

To run simply open `simplehttpserver.exe`.

Close the window of `simplehttpserver.exe` to stop it from running.

- Run the following command on the console.

```sh
simplehttpserver
```

Open a browser and enter the IP address configured by `ip_list` in `config.toml`.

Below is the default IP address set in `config.toml`, which can be quickly previewed by clicking on the jump when SimpleHTTPServer is turned on.

- IPv4 default IP address.

```sh
http://127.0.0.1
```

- IPv6 default IP address.

```sh
http://[::1]
```