#pragma warning disable CA2211 // Non-constant fields should not be visible
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

using Exomia.Vulkan.Api.SourceGenerator;
using System.Runtime.InteropServices;

// ReSharper disable UnusedMember.Global
namespace Exomia.Vulkan.Api.Core.Extensions
{
    [VkExtGenerator]
    public static partial class VkExtGlobalPriority
    {
        public const int    VK_EXT_GLOBAL_PRIORITY                = 1;
        public const int    VK_EXT_GLOBAL_PRIORITY_SPEC_VERSION   = 2;
        public const string VK_EXT_GLOBAL_PRIORITY_EXTENSION_NAME = "VK_EXT_global_priority";
    }

    public enum VkQueueGlobalPriorityEXT
    {
        LOW_EXT      = 128,
        MEDIUM_EXT   = 256,
        HIGH_EXT     = 512,
        REALTIME_EXT = 1024,
        MAX_ENUM_EXT = 0x7FFFFFFF
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkDeviceQueueGlobalPriorityCreateInfoEXT
    {
        public const VkStructureType          STYPE = VkStructureType.DEVICE_QUEUE_GLOBAL_PRIORITY_CREATE_INFO_EXT;
        public       VkStructureType          sType;
        public       void*                    pNext;
        public       VkQueueGlobalPriorityEXT globalPriority;
    }

    [VkExtGenerator]
    public static partial class VkExtGlobalPriorityQuery
    {
        public const int    VK_EXT_GLOBAL_PRIORITY_QUERY                = 1;
        public const uint   VK_MAX_GLOBAL_PRIORITY_SIZE_EXT             = 16U;
        public const int    VK_EXT_GLOBAL_PRIORITY_QUERY_SPEC_VERSION   = 1;
        public const string VK_EXT_GLOBAL_PRIORITY_QUERY_EXTENSION_NAME = "VK_EXT_global_priority_query";
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkPhysicalDeviceGlobalPriorityQueryFeaturesEXT
    {
        public const VkStructureType STYPE = VkStructureType.PHYSICAL_DEVICE_GLOBAL_PRIORITY_QUERY_FEATURES_EXT;
        public       VkStructureType sType;
        public       void*           pNext;
        public       VkBool32        globalPriorityQuery;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkQueueFamilyGlobalPriorityPropertiesEXT
    {
        public const VkStructureType                     STYPE = VkStructureType.QUEUE_FAMILY_GLOBAL_PRIORITY_PROPERTIES_EXT;
        public       VkStructureType                     sType;
        public       void*                               pNext;
        public       uint                                priorityCount;
        public       VkArray16<VkQueueGlobalPriorityEXT> priorities;
    }
}