#pragma warning disable CA2211 // Non-constant fields should not be visible
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

using Exomia.Vulkan.Api.SourceGenerator;
using System;
using System.Runtime.InteropServices;

// ReSharper disable UnusedMember.Global
namespace Exomia.Vulkan.Api.Core.Extensions
{
    [VkExtGenerator]
    public static unsafe partial class VkExtConditionalRendering
    {
        public const int    VK_EXT_CONDITIONAL_RENDERING                = 1;
        public const int    VK_EXT_CONDITIONAL_RENDERING_SPEC_VERSION   = 2;
        public const string VK_EXT_CONDITIONAL_RENDERING_EXTENSION_NAME = "VK_EXT_conditional_rendering";
        
        public static delegate*<
            VkCommandBuffer,                     /* commandBuffer */
            VkConditionalRenderingBeginInfoEXT*, /* pConditionalRenderingBegin */
            void> vkCmdBeginConditionalRenderingEXT;

        public static delegate*<
            VkCommandBuffer, /* commandBuffer */
            void> vkCmdEndConditionalRenderingEXT;

        public static partial void Load(VkDevice vkDevice);
    }

    [Flags]
    public enum VkConditionalRenderingFlagsEXT
    {
        INVERTED_BIT_EXT       = 0x00000001,
        FLAG_BITS_MAX_ENUM_EXT = 0x7FFFFFFF
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkConditionalRenderingBeginInfoEXT
    {
        public const VkStructureType                STYPE = VkStructureType.CONDITIONAL_RENDERING_BEGIN_INFO_EXT;
        public       VkStructureType                sType;
        public       void*                          pNext;
        public       VkBuffer                       buffer;
        public       VkDeviceSize                   offset;
        public       VkConditionalRenderingFlagsEXT flags;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkPhysicalDeviceConditionalRenderingFeaturesEXT
    {
        public const VkStructureType STYPE = VkStructureType.PHYSICAL_DEVICE_CONDITIONAL_RENDERING_FEATURES_EXT;
        public       VkStructureType sType;
        public       void*           pNext;
        public       VkBool32        conditionalRendering;
        public       VkBool32        inheritedConditionalRendering;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkCommandBufferInheritanceConditionalRenderingInfoEXT
    {
        public const VkStructureType STYPE = VkStructureType.COMMAND_BUFFER_INHERITANCE_CONDITIONAL_RENDERING_INFO_EXT;
        public       VkStructureType sType;
        public       void*           pNext;
        public       VkBool32        conditionalRenderingEnable;
    }
}