#pragma warning disable CA2211 // Non-constant fields should not be visible
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

using Exomia.Vulkan.Api.SourceGenerator;
using System;
using System.Runtime.InteropServices;

// ReSharper disable UnusedMember.Global
namespace Exomia.Vulkan.Api.Core.Extensions
{
    [VkExtGenerator]
    public static unsafe partial class VkExtDiscardRectangles
    {
        public const int    VK_EXT_DISCARD_RECTANGLES                = 1;
        public const int    VK_EXT_DISCARD_RECTANGLES_SPEC_VERSION   = 1;
        public const string VK_EXT_DISCARD_RECTANGLES_EXTENSION_NAME = "VK_EXT_discard_rectangles";

        public static delegate*<
            VkCommandBuffer, /* commandBuffer */
            uint,            /* firstDiscardRectangle */
            uint,            /* discardRectangleCount */
            VkRect2D*,       /* pDiscardRectangles */
            void> vkCmdSetDiscardRectangleEXT;

        public static partial void Load(VkDevice vkDevice);
    }

    public enum VkDiscardRectangleModeEXT
    {
        INCLUSIVE_EXT = 0,
        EXCLUSIVE_EXT = 1,
        MAX_ENUM_EXT  = 0x7FFFFFFF
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkPhysicalDeviceDiscardRectanglePropertiesEXT
    {
        public const VkStructureType STYPE = VkStructureType.PHYSICAL_DEVICE_DISCARD_RECTANGLE_PROPERTIES_EXT;
        public       VkStructureType sType;
        public       void*           pNext;
        public       uint            maxDiscardRectangles;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkPipelineDiscardRectangleStateCreateInfoEXT
    {
        public const VkStructureType                               STYPE = VkStructureType.PIPELINE_DISCARD_RECTANGLE_STATE_CREATE_INFO_EXT;
        public       VkStructureType                               sType;
        public       void*                                         pNext;
        public       VkPipelineDiscardRectangleStateCreateFlagsEXT flags;
        public       VkDiscardRectangleModeEXT                     discardRectangleMode;
        public       uint                                          discardRectangleCount;
        public       VkRect2D*                                     pDiscardRectangles;
    }
}