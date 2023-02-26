### v1.3.242 - 26.02.2023
- fixed initialization logic for Exomia.Vulkan.Api.Core
  - "NotSupportedException" is thrown loading the library on a MacOS system.  
    see [Update for upcoming versions >1.3.241](https://github.com/exomia/vulkan-api/discussions/64)

### v1.3.241 - 19.02.2023
- VkRequiresAttribute was renamed to VkDependsAttribute __(breaking change)__
  - 'depends is a breaking change in Vulkan 1.3.241, replacing the requires and requiresCore attributes.'  
  see [vulkan spec 1.3 - changelog - 2023-02-14](https://registry.khronos.org/vulkan/specs/1.3/registry.html#changelog)
- VkExtensionAttribute was added
- AttributeUsage - AllowMultiple was adjusted on:
  - VkDependsAttribute
  - VkProvisionalAttribute
  - VkSpecialuseAttribute
  - VkStructExtendsAttribute 