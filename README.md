## Information

The exomia/vulkan-api repository contains .NET bindings providing low-level and cross-platform access to the [Vulkan](https://www.khronos.org/vulkan/) API.  
The bindings and documentation are generated using the [KhronosGroup/Vulkan-Docs](https://github.com/KhronosGroup/Vulkan-Docs) repository.

It is meant to be as close as possible to the original Vulkan API written in C. [see example](#example)

![](https://img.shields.io/github/issues-pr/exomia/vulkan-api.svg)
![](https://img.shields.io/github/issues/exomia/vulkan-api.svg)
![](https://img.shields.io/github/last-commit/exomia/vulkan-api.svg)
![](https://img.shields.io/github/contributors/exomia/vulkan-api.svg)
![](https://img.shields.io/github/commit-activity/y/exomia/vulkan-api.svg)
![](https://img.shields.io/github/languages/top/exomia/vulkan-api.svg)
![](https://img.shields.io/github/languages/count/exomia/vulkan-api.svg)
![](https://img.shields.io/github/license/exomia/vulkan-api.svg)
[![](https://img.shields.io/nuget/v/Exomia.Vulkan.Api.Core?logo=nuget)](https://www.nuget.org/packages/Exomia.Vulkan.Api.Core)
## Features

- Vulkan 1.0, 1.1, 1.2, 1.3, 0.0
- All platforms except provisional, sci
- All extensions including vk_video
- Raw low level bindings using unsafe C# code
- cross platform

## Example

With **Exomia.Vulkan.Api** you can create a Vulkan instance like this:

### C#
```csharp
using Exomia.Vulkan.Api.Core;
using static Exomia.Vulkan.Api.Core.Vk;

// ...

VkApplicationInfo applicationInfo;
applicationInfo.sType              = VkApplicationInfo.STYPE;
applicationInfo.pNext              = null;
applicationInfo.pApplicationName   = Allocator.AllocateNtString("my app"); // "Allocator" not included in the Exomia.Vulkan.Api
applicationInfo.applicationVersion = new VkVersion(0, 1, 0, 0);
applicationInfo.pEngineName        = Allocator.AllocateNtString("my engine"); // "Allocator" not included in the Exomia.Vulkan.Api
applicationInfo.engineVersion      = new VkVersion(0, 1, 0, 0);
applicationInfo.apiVersion         = VkVersion.VulkanApiVersion13;

VkInstanceCreateInfo instanceCreateInfo;
instanceCreateInfo.sType                   = VkInstanceCreateInfo.STYPE;
instanceCreateInfo.pNext                   = null;
instanceCreateInfo.flags                   = 0;
instanceCreateInfo.pApplicationInfo        = &applicationInfo;
instanceCreateInfo.enabledLayerCount       = 0u;
instanceCreateInfo.ppEnabledLayerNames     = null;
instanceCreateInfo.enabledExtensionCount   = 0u;
instanceCreateInfo.ppEnabledExtensionNames = null;

VkInstance instance;
VkResult result = vkCreateInstance(&instanceCreateInfo, null, &instance);
```

### C/C++ comparison
```cpp
VkApplicationInfo applicationInfo = {};
applicationInfo.sType = VK_STRUCTURE_TYPE_APPLICATION_INFO;
applicationInfo.pApplicationName = "my app";
applicationInfo.applicationVersion = VK_MAKE_VERSION(0, 1, 0, 0);
applicationInfo.pEngineName = "my engine";
applicationInfo.engineVersion = VK_MAKE_VERSION(0, 1, 0, 0);
applicationInfo.apiVersion = VK_API_VERSION_1_3;

VkInstanceCreateInfo instanceCreateInfo = {};
instanceCreateInfo.sType = VK_STRUCTURE_TYPE_INSTANCE_CREATE_INFO;
instanceCreateInfo.pApplicationInfo = &applicationInfo;
instanceCreateInfo.enabledLayerCount = 0;
instanceCreateInfo.enabledExtensionCount = 0;

VkInstance instance;
VkResult result = vkCreateInstance(&instanceCreateInfo, nullptr, &instance)
```

### Extensions

loading extensions is also possible (do not forget to enable them first):

```csharp
// <extension name>.Load(instance[, device]);
VkExtDebugUtils.Load(instance);
```

after loading the extension functions can be used:

```csharp
using static Exomia.Vulkan.Api.Core.VkExtDebugUtils;

// ...

VkDebugUtilsMessengerCreateInfoEXT debugUtilsMessengerCreateInfoExt;
debugUtilsMessengerCreateInfoExt.sType = VkDebugUtilsMessengerCreateInfoEXT.STYPE;
debugUtilsMessengerCreateInfoExt.pNext = null;
debugUtilsMessengerCreateInfoExt.flags = 0u;

// ...

VkDebugUtilsMessengerEXT debugUtilsMessengerExt;
VkResult result = vkCreateDebugUtilsMessengerEXT(instance, &debugUtilsMessengerCreateInfoExt, null, &debugUtilsMessengerExt);

// ...
```

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

## Changelog
can be found [here](CHANGELOG.md)

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
