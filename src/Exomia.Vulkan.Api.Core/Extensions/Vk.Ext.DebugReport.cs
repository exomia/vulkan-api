#pragma warning disable CA2211 // Non-constant fields should not be visible
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

using Exomia.Vulkan.Api.SourceGenerator;
using System;
using System.Runtime.InteropServices;

// ReSharper disable UnusedMember.Global
namespace Exomia.Vulkan.Api.Core.Extensions
{
    [VkExtGenerator]
    public static unsafe partial class VkExtDebugReport
    {
        public const int    VK_EXT_DEBUG_REPORT                = 1;
        public const int    VK_EXT_DEBUG_REPORT_SPEC_VERSION   = 10;
        public const string VK_EXT_DEBUG_REPORT_EXTENSION_NAME = "VK_EXT_debug_report";
        
        public static delegate*<
            VkInstance,                          /* instance */
            VkDebugReportCallbackCreateInfoEXT*, /* pCreateInfo */
            VkAllocationCallbacks*,              /* pAllocator */
            VkDebugReportCallbackEXT*,           /* pCallback */
            VkResult> vkCreateDebugReportCallbackEXT;
        
        public static delegate*<
            VkInstance,               /* instance */
            VkDebugReportCallbackEXT, /* callback */
            VkAllocationCallbacks*,   /* pAllocator */
            void> vkDestroyDebugReportCallbackEXT;
        
        public static delegate*<
            VkInstance,                 /* instance */
            VkDebugReportFlagsEXT,      /* FlagBits */
            VkDebugReportObjectTypeEXT, /* objectType */
            ulong,                      /* @object */
            nuint,                      /* location */
            int,                        /* messageCode */
            byte*,                      /* pLayerPrefix */
            byte*,                      /* pMessage */
            void> vkDebugReportMessageEXT;

        public static partial void Load(VkInstance vkInstance);
    }

    public enum VkDebugReportObjectTypeEXT
    {
        UNKNOWN_EXT                        = 0,
        INSTANCE_EXT                       = 1,
        PHYSICAL_DEVICE_EXT                = 2,
        DEVICE_EXT                         = 3,
        QUEUE_EXT                          = 4,
        SEMAPHORE_EXT                      = 5,
        COMMAND_BUFFER_EXT                 = 6,
        FENCE_EXT                          = 7,
        DEVICE_MEMORY_EXT                  = 8,
        BUFFER_EXT                         = 9,
        IMAGE_EXT                          = 10,
        EVENT_EXT                          = 11,
        QUERY_POOL_EXT                     = 12,
        BUFFER_VIEW_EXT                    = 13,
        IMAGE_VIEW_EXT                     = 14,
        SHADER_MODULE_EXT                  = 15,
        PIPELINE_CACHE_EXT                 = 16,
        PIPELINE_LAYOUT_EXT                = 17,
        RENDER_PASS_EXT                    = 18,
        PIPELINE_EXT                       = 19,
        DESCRIPTOR_SET_LAYOUT_EXT          = 20,
        SAMPLER_EXT                        = 21,
        DESCRIPTOR_POOL_EXT                = 22,
        DESCRIPTOR_SET_EXT                 = 23,
        FRAMEBUFFER_EXT                    = 24,
        COMMAND_POOL_EXT                   = 25,
        SURFACE_KHR_EXT                    = 26,
        SWAPCHAIN_KHR_EXT                  = 27,
        DEBUG_REPORT_CALLBACK_EXT_EXT      = 28,
        DISPLAY_KHR_EXT                    = 29,
        DISPLAY_MODE_KHR_EXT               = 30,
        VALIDATION_CACHE_EXT_EXT           = 33,
        SAMPLER_YCBCR_CONVERSION_EXT       = 1000156000,
        DESCRIPTOR_UPDATE_TEMPLATE_EXT     = 1000085000,
        CU_MODULE_NVX_EXT                  = 1000029000,
        CU_FUNCTION_NVX_EXT                = 1000029001,
        ACCELERATION_STRUCTURE_KHR_EXT     = 1000150000,
        ACCELERATION_STRUCTURE_NV_EXT      = 1000165000,
        DEBUG_REPORT_EXT                   = DEBUG_REPORT_CALLBACK_EXT_EXT,
        VALIDATION_CACHE_EXT               = VALIDATION_CACHE_EXT_EXT,
        DESCRIPTOR_UPDATE_TEMPLATE_KHR_EXT = DESCRIPTOR_UPDATE_TEMPLATE_EXT,
        SAMPLER_YCBCR_CONVERSION_KHR_EXT   = SAMPLER_YCBCR_CONVERSION_EXT,
        MAX_ENUM_EXT                       = 0x7FFFFFFF
    }

    [Flags]
    public enum VkDebugReportFlagsEXT
    {
        INFORMATION_BIT_EXT         = 0x00000001,
        WARNING_BIT_EXT             = 0x00000002,
        PERFORMANCE_WARNING_BIT_EXT = 0x00000004,
        ERROR_BIT_EXT               = 0x00000008,
        DEBUG_BIT_EXT               = 0x00000010,
        FLAG_BITS_MAX_ENUM_EXT      = 0x7FFFFFFF
    }

    public readonly unsafe struct VkDebugReportCallbackEXT
    {
        public static readonly VkDebugReportCallbackEXT Null = (VkDebugReportCallbackEXT)null;
#pragma warning disable 649
        private readonly void* _ptr;
#pragma warning restore 649

        public static explicit operator VkDebugReportCallbackEXT(void* ptr)
        {
            VkDebugReportCallbackEXT value;
            *(void**)&value = ptr;
            return value;
        }

        public static bool operator ==(VkDebugReportCallbackEXT left, VkDebugReportCallbackEXT right)
        {
            return left._ptr == right._ptr;
        }

        public static bool operator !=(VkDebugReportCallbackEXT left, VkDebugReportCallbackEXT right)
        {
            return left._ptr != right._ptr;
        }

        public bool Equals(in VkDebugReportCallbackEXT obj)
        {
            return obj._ptr == _ptr;
        }

        public override bool Equals(object? obj)
        {
            return obj is VkDebugReportCallbackEXT vkDebugReportCallbackEXT && Equals(in vkDebugReportCallbackEXT);
        }

        public override int GetHashCode()
        {
            return ((IntPtr)_ptr).GetHashCode();
        }

        public static explicit operator void*(VkDebugReportCallbackEXT value)
        {
            return value._ptr;
        }
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkDebugReportCallbackCreateInfoEXT
    {
        public const VkStructureType       STYPE = VkStructureType.DEBUG_REPORT_CALLBACK_CREATE_INFO_EXT;
        public       VkStructureType       sType;
        public       void*                 pNext;
        public       VkDebugReportFlagsEXT flags;

        public delegate*<               /*vkDebugReportCallbackEXT*/
            VkDebugReportFlagsEXT,      /* FlagBits                  */
            VkDebugReportObjectTypeEXT, /* objectType             */
            ulong,                      /* @object                */
            nuint,                      /* location               */
            int,                        /* messageCode            */
            sbyte*,                     /* pLayerPrefix           */
            sbyte*,                     /* pMessage               */
            void*,                      /* pUserData              */
            VkBool32> pfnCallback;

        public void* pUserData;
    }
}