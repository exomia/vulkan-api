#pragma warning disable CA2211 // Non-constant fields should not be visible
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

using Exomia.Vulkan.Api.SourceGenerator;
using System;
using System.Runtime.InteropServices;

// ReSharper disable UnusedMember.Global
namespace Exomia.Vulkan.Api.Core.Extensions
{
    [VkExtGenerator]
    public static unsafe partial class VkExtConservativeRasterization
    {
        public const int    VK_EXT_CONSERVATIVE_RASTERIZATION                = 1;
        public const int    VK_EXT_CONSERVATIVE_RASTERIZATION_SPEC_VERSION   = 1;
        public const string VK_EXT_CONSERVATIVE_RASTERIZATION_EXTENSION_NAME = "VK_EXT_conservative_rasterization";
    }

    public enum VkConservativeRasterizationModeEXT
    {
        DISABLED_EXT      = 0,
        OVERESTIMATE_EXT  = 1,
        UNDERESTIMATE_EXT = 2,
        MAX_ENUM_EXT      = 0x7FFFFFFF
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkPhysicalDeviceConservativeRasterizationPropertiesEXT
    {
        public const VkStructureType STYPE = VkStructureType.PHYSICAL_DEVICE_CONSERVATIVE_RASTERIZATION_PROPERTIES_EXT;
        public       VkStructureType sType;
        public       void*           pNext;
        public       float           primitiveOverestimationSize;
        public       float           maxExtraPrimitiveOverestimationSize;
        public       float           extraPrimitiveOverestimationSizeGranularity;
        public       VkBool32        primitiveUnderestimation;
        public       VkBool32        conservativePointAndLineRasterization;
        public       VkBool32        degenerateTrianglesRasterized;
        public       VkBool32        degenerateLinesRasterized;
        public       VkBool32        fullyCoveredFragmentShaderInputVariable;
        public       VkBool32        conservativeRasterizationPostDepthCoverage;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkPipelineRasterizationConservativeStateCreateInfoEXT
    {
        public const VkStructureType                                        STYPE = VkStructureType.PIPELINE_RASTERIZATION_CONSERVATIVE_STATE_CREATE_INFO_EXT;
        public       VkStructureType                                        sType;
        public       void*                                                  pNext;
        public       VkPipelineRasterizationConservativeStateCreateFlagsEXT flags;
        public       VkConservativeRasterizationModeEXT                     conservativeRasterizationMode;
        public       float                                                  extraPrimitiveOverestimationSize;
    }
}