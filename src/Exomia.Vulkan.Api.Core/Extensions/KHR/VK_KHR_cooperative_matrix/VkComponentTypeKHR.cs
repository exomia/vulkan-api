#region License

// Copyright (c) 2018-2024, exomia
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
///     VkComponentTypeKHR - Specify SPIR-V cooperative matrix component type -
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkComponentTypeKHR.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkComponentTypeKHR.html</a>
/// </summary>
public enum VkComponentTypeKHR
{
    /// <summary>VK_COMPONENT_TYPE_FLOAT16_KHR corresponds to SPIR-V OpTypeFloat 16.</summary>
    VK_COMPONENT_TYPE_FLOAT16_KHR = 0,

    /// <summary>VK_COMPONENT_TYPE_FLOAT32_KHR corresponds to SPIR-V OpTypeFloat 32.</summary>
    VK_COMPONENT_TYPE_FLOAT32_KHR = 1,

    /// <summary>VK_COMPONENT_TYPE_FLOAT64_KHR corresponds to SPIR-V OpTypeFloat 64.</summary>
    VK_COMPONENT_TYPE_FLOAT64_KHR = 2,

    /// <summary>VK_COMPONENT_TYPE_SINT8_KHR corresponds to SPIR-V OpTypeInt 8 1.</summary>
    VK_COMPONENT_TYPE_SINT8_KHR = 3,

    /// <summary>VK_COMPONENT_TYPE_SINT16_KHR corresponds to SPIR-V OpTypeInt16 1.</summary>
    VK_COMPONENT_TYPE_SINT16_KHR = 4,

    /// <summary>VK_COMPONENT_TYPE_SINT32_KHR corresponds to SPIR-V OpTypeInt32 1.</summary>
    VK_COMPONENT_TYPE_SINT32_KHR = 5,

    /// <summary>VK_COMPONENT_TYPE_SINT64_KHR corresponds to SPIR-V OpTypeInt64 1.</summary>
    VK_COMPONENT_TYPE_SINT64_KHR = 6,

    /// <summary>VK_COMPONENT_TYPE_UINT8_KHR corresponds to SPIR-V OpTypeInt 8 0.</summary>
    VK_COMPONENT_TYPE_UINT8_KHR = 7,

    /// <summary>VK_COMPONENT_TYPE_UINT16_KHR corresponds to SPIR-V OpTypeInt16 0.</summary>
    VK_COMPONENT_TYPE_UINT16_KHR = 8,

    /// <summary>VK_COMPONENT_TYPE_UINT32_KHR corresponds to SPIR-V OpTypeInt32 0.</summary>
    VK_COMPONENT_TYPE_UINT32_KHR = 9,

    /// <summary>VK_COMPONENT_TYPE_UINT64_KHR corresponds to SPIR-V OpTypeInt64 0.</summary>
    VK_COMPONENT_TYPE_UINT64_KHR = 10,

    /// <summary>VK_COMPONENT_TYPE_FLOAT16_KHR corresponds to SPIR-V OpTypeFloat 16.</summary>
    VK_COMPONENT_TYPE_FLOAT16_NV = VK_COMPONENT_TYPE_FLOAT16_KHR,

    /// <summary>VK_COMPONENT_TYPE_FLOAT32_KHR corresponds to SPIR-V OpTypeFloat 32.</summary>
    VK_COMPONENT_TYPE_FLOAT32_NV = VK_COMPONENT_TYPE_FLOAT32_KHR,

    /// <summary>VK_COMPONENT_TYPE_FLOAT64_KHR corresponds to SPIR-V OpTypeFloat 64.</summary>
    VK_COMPONENT_TYPE_FLOAT64_NV = VK_COMPONENT_TYPE_FLOAT64_KHR,

    /// <summary>VK_COMPONENT_TYPE_SINT8_KHR corresponds to SPIR-V OpTypeInt 8 1.</summary>
    VK_COMPONENT_TYPE_SINT8_NV = VK_COMPONENT_TYPE_SINT8_KHR,

    /// <summary>VK_COMPONENT_TYPE_SINT16_KHR corresponds to SPIR-V OpTypeInt16 1.</summary>
    VK_COMPONENT_TYPE_SINT16_NV = VK_COMPONENT_TYPE_SINT16_KHR,

    /// <summary>VK_COMPONENT_TYPE_SINT32_KHR corresponds to SPIR-V OpTypeInt32 1.</summary>
    VK_COMPONENT_TYPE_SINT32_NV = VK_COMPONENT_TYPE_SINT32_KHR,

    /// <summary>VK_COMPONENT_TYPE_SINT64_KHR corresponds to SPIR-V OpTypeInt64 1.</summary>
    VK_COMPONENT_TYPE_SINT64_NV = VK_COMPONENT_TYPE_SINT64_KHR,

    /// <summary>VK_COMPONENT_TYPE_UINT8_KHR corresponds to SPIR-V OpTypeInt 8 0.</summary>
    VK_COMPONENT_TYPE_UINT8_NV = VK_COMPONENT_TYPE_UINT8_KHR,

    /// <summary>VK_COMPONENT_TYPE_UINT16_KHR corresponds to SPIR-V OpTypeInt16 0.</summary>
    VK_COMPONENT_TYPE_UINT16_NV = VK_COMPONENT_TYPE_UINT16_KHR,

    /// <summary>VK_COMPONENT_TYPE_UINT32_KHR corresponds to SPIR-V OpTypeInt32 0.</summary>
    VK_COMPONENT_TYPE_UINT32_NV = VK_COMPONENT_TYPE_UINT32_KHR,

    /// <summary>VK_COMPONENT_TYPE_UINT64_KHR corresponds to SPIR-V OpTypeInt64 0.</summary>
    VK_COMPONENT_TYPE_UINT64_NV = VK_COMPONENT_TYPE_UINT64_KHR
}