#region License

// Copyright (c) 2018-2021, exomia
// All rights reserved.
// 
// This source code is licensed under the BSD-style license found in the
// LICENSE file in the root directory of this source tree.

#endregion

#pragma warning disable CA2211 // Non-constant fields should not be visible
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

// ReSharper disable UnusedMember.Global
// ReSharper disable InconsistentNaming
namespace Exomia.Vulkan.Api.Core.Extensions;

[VkExtGenerator]
public static partial class VkExtProvokingVertex
{
    public const int    VK_EXT_PROVOKING_VERTEX                = 1;
    public const int    VK_EXT_PROVOKING_VERTEX_SPEC_VERSION   = 1;
    public const string VK_EXT_PROVOKING_VERTEX_EXTENSION_NAME = "VK_EXT_provoking_vertex";
}

public enum VkProvokingVertexModeEXT
{
    FIRST_VERTEX_EXT = 0,
    LAST_VERTEX_EXT  = 1,
    MAX_ENUM_EXT     = 0x7FFFFFFF
}

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPhysicalDeviceProvokingVertexFeaturesEXT
{
    public const VkStructureType STYPE = VkStructureType.PHYSICAL_DEVICE_PROVOKING_VERTEX_FEATURES_EXT;
    public       VkStructureType sType;
    public       void*           pNext;
    public       VkBool32        provokingVertexLast;
    public       VkBool32        transformFeedbackPreservesProvokingVertex;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPhysicalDeviceProvokingVertexPropertiesEXT
{
    public const VkStructureType STYPE = VkStructureType.PHYSICAL_DEVICE_PROVOKING_VERTEX_PROPERTIES_EXT;
    public       VkStructureType sType;
    public       void*           pNext;
    public       VkBool32        provokingVertexModePerPipeline;
    public       VkBool32        transformFeedbackPreservesTriangleFanProvokingVertex;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPipelineRasterizationProvokingVertexStateCreateInfoEXT
{
    public const VkStructureType          STYPE = VkStructureType.PIPELINE_RASTERIZATION_PROVOKING_VERTEX_STATE_CREATE_INFO_EXT;
    public       VkStructureType          sType;
    public       void*                    pNext;
    public       VkProvokingVertexModeEXT provokingVertexMode;
}