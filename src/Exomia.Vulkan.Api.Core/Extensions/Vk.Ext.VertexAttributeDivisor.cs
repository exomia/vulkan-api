#region License

// Copyright (c) 2018-2021, exomia
// All rights reserved.
// 
// This source code is licensed under the BSD-style license found in the
// LICENSE file in the root directory of this source tree.

#endregion

#pragma warning disable CA2211 // Non-constant fields should not be visible
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

using System.Runtime.InteropServices;
using Exomia.Vulkan.Api.SourceGenerator;

// ReSharper disable UnusedMember.Global
namespace Exomia.Vulkan.Api.Core.Extensions
{
    [VkExtGenerator]
    public static partial class VkExtVertexAttributeDivisor
    {
        public const int    VK_EXT_VERTEX_ATTRIBUTE_DIVISOR                = 1;
        public const int    VK_EXT_VERTEX_ATTRIBUTE_DIVISOR_SPEC_VERSION   = 3;
        public const string VK_EXT_VERTEX_ATTRIBUTE_DIVISOR_EXTENSION_NAME = "VK_EXT_vertex_attribute_divisor";
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkPhysicalDeviceVertexAttributeDivisorPropertiesEXT
    {
        public const VkStructureType STYPE = VkStructureType.PHYSICAL_DEVICE_VERTEX_ATTRIBUTE_DIVISOR_PROPERTIES_EXT;
        public       VkStructureType sType;
        public       void*           pNext;
        public       uint            maxVertexAttribDivisor;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct VkVertexInputBindingDivisorDescriptionEXT
    {
        public uint binding;
        public uint divisor;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkPipelineVertexInputDivisorStateCreateInfoEXT
    {
        public const VkStructureType                            STYPE = VkStructureType.PIPELINE_VERTEX_INPUT_DIVISOR_STATE_CREATE_INFO_EXT;
        public       VkStructureType                            sType;
        public       void*                                      pNext;
        public       uint                                       vertexBindingDivisorCount;
        public       VkVertexInputBindingDivisorDescriptionEXT* pVertexBindingDivisors;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkPhysicalDeviceVertexAttributeDivisorFeaturesEXT
    {
        public const VkStructureType STYPE = VkStructureType.PHYSICAL_DEVICE_VERTEX_ATTRIBUTE_DIVISOR_FEATURES_EXT;
        public       VkStructureType sType;
        public       void*           pNext;
        public       VkBool32        vertexAttributeInstanceRateDivisor;
        public       VkBool32        vertexAttributeInstanceRateZeroDivisor;
    }
}