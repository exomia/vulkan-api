#pragma warning disable CA2211 // Non-constant fields should not be visible
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

using Exomia.Vulkan.Api.SourceGenerator;
using System.Runtime.InteropServices;

// ReSharper disable UnusedMember.Global
namespace Exomia.Vulkan.Api.Core.Extensions
{
    [VkExtGenerator]
    public static partial class VkExtBlendOperationAdvanced
    {
        public const int    VK_EXT_BLEND_OPERATION_ADVANCED                = 1;
        public const int    VK_EXT_BLEND_OPERATION_ADVANCED_SPEC_VERSION   = 2;
        public const string VK_EXT_BLEND_OPERATION_ADVANCED_EXTENSION_NAME = "VK_EXT_blend_operation_advanced";
    }

    public enum VkBlendOverlapEXT
    {
        UNCORRELATED_EXT = 0,
        DISJOINT_EXT     = 1,
        CONJOINT_EXT     = 2,
        MAX_ENUM_EXT     = 0x7FFFFFFF
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkPhysicalDeviceBlendOperationAdvancedFeaturesEXT
    {
        public const VkStructureType STYPE = VkStructureType.PHYSICAL_DEVICE_BLEND_OPERATION_ADVANCED_FEATURES_EXT;
        public       VkStructureType sType;
        public       void*           pNext;
        public       VkBool32        advancedBlendCoherentOperations;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkPhysicalDeviceBlendOperationAdvancedPropertiesEXT
    {
        public const VkStructureType STYPE = VkStructureType.PHYSICAL_DEVICE_BLEND_OPERATION_ADVANCED_PROPERTIES_EXT;
        public       VkStructureType sType;
        public       void*           pNext;
        public       uint            advancedBlendMaxColorAttachments;
        public       VkBool32        advancedBlendIndependentBlend;
        public       VkBool32        advancedBlendNonPremultipliedSrcColor;
        public       VkBool32        advancedBlendNonPremultipliedDstColor;
        public       VkBool32        advancedBlendCorrelatedOverlap;
        public       VkBool32        advancedBlendAllOperations;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkPipelineColorBlendAdvancedStateCreateInfoEXT
    {
        public const VkStructureType   STYPE = VkStructureType.PIPELINE_COLOR_BLEND_ADVANCED_STATE_CREATE_INFO_EXT;
        public       VkStructureType   sType;
        public       void*             pNext;
        public       VkBool32          srcPremultiplied;
        public       VkBool32          dstPremultiplied;
        public       VkBlendOverlapEXT blendOverlap;
    }
}