#pragma warning disable CA2211 // Non-constant fields should not be visible
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

using Exomia.Vulkan.Api.SourceGenerator;
using System.Runtime.InteropServices;

// ReSharper disable UnusedMember.Global
namespace Exomia.Vulkan.Api.Core.Extensions
{
    [VkExtGenerator]
    public static unsafe partial class VkExtDebugMarker
    {
        public const int    VK_EXT_DEBUG_MARKER                = 1;
        public const int    VK_EXT_DEBUG_MARKER_SPEC_VERSION   = 4;
        public const string VK_EXT_DEBUG_MARKER_EXTENSION_NAME = "VK_EXT_debug_marker";

        public static delegate*<
            VkDevice,                       /* device */
            VkDebugMarkerObjectTagInfoEXT*, /* pTagInfo */
            VkResult> vkDebugMarkerSetObjectTagEXT;
        
        public static delegate*<
            VkDevice,                        /* device */
            VkDebugMarkerObjectNameInfoEXT*, /* pNameInfo */
            VkResult> vkDebugMarkerSetObjectNameEXT;

        public static delegate*<
            VkCommandBuffer,             /* commandBuffer */
            VkDebugMarkerMarkerInfoEXT*, /* pMarkerInfo */
            void> vkCmdDebugMarkerBeginEXT;
        
        public static delegate*<
            VkCommandBuffer, /* commandBuffer */
            void> vkCmdDebugMarkerEndEXT;
        
        public static delegate*<
            VkCommandBuffer,             /* commandBuffer */
            VkDebugMarkerMarkerInfoEXT*, /* pMarkerInfo */
            void> vkCmdDebugMarkerInsertEXT;

        public static partial void Load(VkDevice vkDevice);
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkDebugMarkerObjectNameInfoEXT
    {
        public const VkStructureType            STYPE = VkStructureType.DEBUG_MARKER_OBJECT_NAME_INFO_EXT;
        public       VkStructureType            sType;
        public       void*                      pNext;
        public       VkDebugReportObjectTypeEXT objectType;
        public       ulong                      @object;
        public       sbyte*                     pObjectName;
    }


    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkDebugMarkerObjectTagInfoEXT
    {
        public const VkStructureType            STYPE = VkStructureType.DEBUG_MARKER_OBJECT_TAG_INFO_EXT;
        public       VkStructureType            sType;
        public       void*                      pNext;
        public       VkDebugReportObjectTypeEXT objectType;
        public       ulong                      @object;
        public       ulong                      tagName;
        public       nuint                      tagSize;
        public       void*                      pTag;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkDebugMarkerMarkerInfoEXT
    {
        public const VkStructureType STYPE = VkStructureType.DEBUG_MARKER_MARKER_INFO_EXT;
        public       VkStructureType sType;
        public       void*           pNext;
        public       sbyte*          pMarkerName;
        public fixed float           color[4];
    }
}