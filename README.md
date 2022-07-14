## Information

The exomia/vulkan-api repository contains C#/.Net 6 libraries providing low-level and cross-platform bindings to access the [Vulkan](https://www.khronos.org/vulkan/) API.  
The bindings and documentation are generated using the [KhronosGroup/Vulkan-Docs](https://github.com/KhronosGroup/Vulkan-Docs) repository.

![](https://img.shields.io/github/issues-pr/exomia/vulkan-api.svg)
![](https://img.shields.io/github/issues/exomia/vulkan-api.svg)
![](https://img.shields.io/github/last-commit/exomia/vulkan-api.svg)
![](https://img.shields.io/github/contributors/exomia/vulkan-api.svg)
![](https://img.shields.io/github/commit-activity/y/exomia/vulkan-api.svg)
![](https://img.shields.io/github/languages/top/exomia/vulkan-api.svg)
![](https://img.shields.io/github/languages/count/exomia/vulkan-api.svg)
![](https://img.shields.io/github/license/exomia/vulkan-api.svg)

## Features

- Vulkan 1.0, 1.1, 1.2, 1.3
- All platforms except provisional
- All extensions including vk_video
- Raw low level bindings using unsafe C# code
- cross platform

## Installing

### Core

```shell
[Package Manager]
PM> Install-Package Exomia.Vulkan.Api.Core
```

### Platform

```shell
[Package Manager]
PM> Install-Package Exomia.Vulkan.Api.<Platform>
```

> replace \<Platform\> with a platform name of the following table

| platform name | comment |
| :------------ | :------ |
| Xlib | X Window System, Xlib client library |
| Xlib_xrandr | X Window System, Xlib client library, XRandR extension |
| Xcb | X Window System, Xcb client library |
| Wayland | Wayland display server protocol |
| Directfb | DirectFB library |
| Android | Android OS |
| Win32 | Microsoft Win32 API (also refers to Win64 apps) |
| Vi | Nintendo Vi |
| Ios | Apple IOS |
| Macos | Apple MacOS |
| Metal | Metal on CoreAnimation on Apple platforms |
| Fuchsia | Fuchsia |
| Ggp | Google Games Platform |
| Screen | QNX Screen Graphics Subsystem |


> see Exomia.Vulkan.Api packages on [nuget](https://www.nuget.org/packages?q=Exomia.Vulkan.Api)


## Building

### Core

To build Exomia.Vulkan.Api.Core, open Exomia.Vulkan.Api.Core.sln in Visual Studio 2022 and build the solution. 
Alternatively you can also build it on the command line, run the ```dotnet build Exomia.Vulkan.Api.Core.sln``` command. 

### Platforms

In order to be able to build Exomia.Vulkan.Api.Platforms, make sure that the core package is available in one of your nuget feeds.
To build Exomia.Vulkan.Api.Platforms, open Exomia.Vulkan.Api.Platforms.sln in Visual Studio 2022 and build the solution. 
Alternatively you can also build it on the command line, run the ```dotnet build Exomia.Vulkan.Api.Platforms.sln``` command. 

## Q&A, Ideas or Show & tell us

You have questions, ideas or want to show or tell us something?  
Open a new [discussion](https://github.com/exomia/vulkan-api/discussions) or join an existing one!

---
## Social

[![Discord](https://img.shields.io/discord/427640639732187136.svg?label=&logo=discord&logoColor=ffffff&color=7389D8&labelColor=6A7EC2)](https://discord.com/invite/ZFJXe6f)
[![Twitch](https://img.shields.io/twitch/status/exomia.svg?label=&logo=twitch&logoColor=ffffff&color=7389D8&labelColor=6A7EC2)](https://www.twitch.tv/exomia/about)
