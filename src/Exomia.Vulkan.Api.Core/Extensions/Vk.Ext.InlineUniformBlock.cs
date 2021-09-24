#pragma warning disable CA2211 // Non-constant fields should not be visible
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

using Exomia.Vulkan.Api.SourceGenerator;
using System.Runtime.InteropServices;

// ReSharper disable UnusedMember.Global
namespace Exomia.Vulkan.Api.Core.Extensions
{
    [VkExtGenerator]
    public static partial class VkExtInlineUniformBlock
    {
        public const int    VK_EXT_INLINE_UNIFORM_BLOCK                = 1;
        public const int    VK_EXT_INLINE_UNIFORM_BLOCK_SPEC_VERSION   = 1;
        public const string VK_EXT_INLINE_UNIFORM_BLOCK_EXTENSION_NAME = "VK_EXT_inline_uniform_block";
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkPhysicalDeviceInlineUniformBlockFeaturesEXT
    {
        public const VkStructureType STYPE = VkStructureType.PHYSICAL_DEVICE_INLINE_UNIFORM_BLOCK_FEATURES_EXT;
        public VkStructureType sType;
        public void* pNext;
        public VkBool32 inlineUniformBlock;
        public VkBool32 descriptorBindingInlineUniformBlockUpdateAfterBind;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkPhysicalDeviceInlineUniformBlockPropertiesEXT
    {
        public const VkStructureType STYPE = VkStructureType.PHYSICAL_DEVICE_INLINE_UNIFORM_BLOCK_PROPERTIES_EXT;
        public VkStructureType sType;
        public void* pNext;
        public uint maxInlineUniformBlockSize;
        public uint maxPerStageDescriptorInlineUniformBlocks;
        public uint maxPerStageDescriptorUpdateAfterBindInlineUniformBlocks;
        public uint maxDescriptorSetInlineUniformBlocks;
        public uint maxDescriptorSetUpdateAfterBindInlineUniformBlocks;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkWriteDescriptorSetInlineUniformBlockEXT
    {
        public const VkStructureType STYPE = VkStructureType.WRITE_DESCRIPTOR_SET_INLINE_UNIFORM_BLOCK_EXT;
        public VkStructureType sType;
        public void* pNext;
        public uint dataSize;
        public void* pData;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkDescriptorPoolInlineUniformBlockCreateInfoEXT
    {
        public const VkStructureType STYPE = VkStructureType.DESCRIPTOR_POOL_INLINE_UNIFORM_BLOCK_CREATE_INFO_EXT;
        public VkStructureType sType;
        public void* pNext;
        public uint maxInlineUniformBlockBindings;
    }
}