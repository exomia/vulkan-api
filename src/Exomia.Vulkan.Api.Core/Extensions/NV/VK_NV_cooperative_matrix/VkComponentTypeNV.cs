#region License

// Copyright (c) 2018-2022, exomia
// All rights reserved.
// 
// This source code is licensed under the BSD-style license found in the
// LICENSE file in the root directory of this source tree.

#endregion

// ReSharper disable UnusedMember.Global
// ReSharper disable InconsistentNaming
// ReSharper disable once CheckNamespace
namespace Exomia.Vulkan.Api.Core;

/// <summary>
///     VkComponentTypeNV - Specify SPIR-V cooperative matrix component type -
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkComponentTypeNV.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkComponentTypeNV.html</a>
/// </summary>
public enum VkComponentTypeNV
{
    /// <summary>VK_COMPONENT_TYPE_FLOAT16_NV corresponds to SPIR-V OpTypeFloat 16.</summary>
    VK_COMPONENT_TYPE_FLOAT16_NV = 0,

    /// <summary>VK_COMPONENT_TYPE_FLOAT32_NV corresponds to SPIR-V OpTypeFloat 32.</summary>
    VK_COMPONENT_TYPE_FLOAT32_NV = 1,

    /// <summary>VK_COMPONENT_TYPE_FLOAT64_NV corresponds to SPIR-V OpTypeFloat 64.</summary>
    VK_COMPONENT_TYPE_FLOAT64_NV = 2,

    /// <summary>VK_COMPONENT_TYPE_SINT8_NV corresponds to SPIR-V OpTypeInt 8 1.</summary>
    VK_COMPONENT_TYPE_SINT8_NV = 3,

    /// <summary>VK_COMPONENT_TYPE_SINT16_NV corresponds to SPIR-V OpTypeInt16 1.</summary>
    VK_COMPONENT_TYPE_SINT16_NV = 4,

    /// <summary>VK_COMPONENT_TYPE_SINT32_NV corresponds to SPIR-V OpTypeInt32 1.</summary>
    VK_COMPONENT_TYPE_SINT32_NV = 5,

    /// <summary>VK_COMPONENT_TYPE_SINT64_NV corresponds to SPIR-V OpTypeInt64 1.</summary>
    VK_COMPONENT_TYPE_SINT64_NV = 6,

    /// <summary>VK_COMPONENT_TYPE_UINT8_NV corresponds to SPIR-V OpTypeInt 8 0.</summary>
    VK_COMPONENT_TYPE_UINT8_NV = 7,

    /// <summary>VK_COMPONENT_TYPE_UINT16_NV corresponds to SPIR-V OpTypeInt16 0.</summary>
    VK_COMPONENT_TYPE_UINT16_NV = 8,

    /// <summary>VK_COMPONENT_TYPE_UINT32_NV corresponds to SPIR-V OpTypeInt32 0.</summary>
    VK_COMPONENT_TYPE_UINT32_NV = 9,

    /// <summary>VK_COMPONENT_TYPE_UINT64_NV corresponds to SPIR-V OpTypeInt64 0.</summary>
    VK_COMPONENT_TYPE_UINT64_NV = 10
}