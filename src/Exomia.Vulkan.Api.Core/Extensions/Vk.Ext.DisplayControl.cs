#pragma warning disable CA2211 // Non-constant fields should not be visible
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

using Exomia.Vulkan.Api.SourceGenerator;

// ReSharper disable UnusedMember.Global
namespace Exomia.Vulkan.Api.Core.Extensions
{
    [VkExtGenerator]
    public static unsafe partial class VkExtDisplayControl
    {
        public const int    VK_EXT_DISPLAY_CONTROL                = 1;
        public const int    VK_EXT_DISPLAY_CONTROL_SPEC_VERSION   = 1;
        public const string VK_EXT_DISPLAY_CONTROL_EXTENSION_NAME = "VK_EXT_display_control";
        
        public static delegate*<
            VkDevice,               /* device */
            VkDisplayKHR,           /* display */
            VkDisplayPowerInfoEXT*, /* pDisplayPowerInfo */
            VkResult> vkDisplayPowerControlEXT;
        
        public static delegate*<
            VkDevice,               /* device */
            VkDeviceEventInfoEXT*,  /* pDeviceEventInfo */
            VkAllocationCallbacks*, /* pAllocator */
            VkFence*,               /* pFence */
            VkResult> vkRegisterDeviceEventEXT;

        public static delegate*<
            VkDevice,               /* device */
            VkDisplayKHR,           /* display */
            VkDisplayEventInfoEXT*, /* pDisplayEventInfo */
            VkAllocationCallbacks*, /* pAllocator */
            VkFence*,               /* pFence */
            VkResult> vkRegisterDisplayEventEXT;
        
        public static delegate*<
            VkDevice,                 /* device */
            VkSwapchainKHR,           /* swapchain */
            VkSurfaceCounterFlagsEXT, /* counter */
            ulong*,                   /* pCounterValue */
            VkResult> vkGetSwapchainCounterEXT;

        public static partial void Load(VkDevice vkDevice);
    }
}
