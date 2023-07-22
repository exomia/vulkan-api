#region License

// Copyright (c) 2018-2023, exomia
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
///     VkPipelineIndirectDeviceAddressInfoNV - Structure specifying the pipeline to query an address for -
///     <a
///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkPipelineIndirectDeviceAddressInfoNV.html">
///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkPipelineIndirectDeviceAddressInfoNV.html
///     </a>
/// </summary>
[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPipelineIndirectDeviceAddressInfoNV
{
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_PIPELINE_INDIRECT_DEVICE_ADDRESS_INFO_NV;

    /// <summary>
    ///     sType<br />
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkPipelineIndirectDeviceAddressInfoNV">
    ///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkPipelineIndirectDeviceAddressInfoNV
    ///     </a>
    /// </summary>
    public VkStructureType sType;

    /// <summary>
    ///     pNext<br />
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkPipelineIndirectDeviceAddressInfoNV">
    ///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkPipelineIndirectDeviceAddressInfoNV
    ///     </a>
    /// </summary>
    public void* pNext;

    /// <summary>
    ///     pipelineBindPoint<br />
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkPipelineIndirectDeviceAddressInfoNV">
    ///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkPipelineIndirectDeviceAddressInfoNV
    ///     </a>
    /// </summary>
    public VkPipelineBindPoint pipelineBindPoint;

    /// <summary>
    ///     pipeline<br />
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkPipelineIndirectDeviceAddressInfoNV">
    ///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkPipelineIndirectDeviceAddressInfoNV
    ///     </a>
    /// </summary>
    public VkPipeline pipeline;
}