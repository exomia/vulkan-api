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
///     VkComputePipelineIndirectBufferInfoNV - Structure describing the device address where pipeline's metadata will be
///     saved -
///     <a
///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkComputePipelineIndirectBufferInfoNV.html">
///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkComputePipelineIndirectBufferInfoNV.html
///     </a>
/// </summary>
[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkComputePipelineIndirectBufferInfoNV
{
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_COMPUTE_PIPELINE_INDIRECT_BUFFER_INFO_NV;

    /// <summary>
    ///     sType<br />
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkComputePipelineIndirectBufferInfoNV">
    ///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkComputePipelineIndirectBufferInfoNV
    ///     </a>
    /// </summary>
    public VkStructureType sType;

    /// <summary>
    ///     pNext<br />
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkComputePipelineIndirectBufferInfoNV">
    ///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkComputePipelineIndirectBufferInfoNV
    ///     </a>
    /// </summary>
    public void* pNext;

    /// <summary>
    ///     deviceAddress<br />
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkComputePipelineIndirectBufferInfoNV">
    ///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkComputePipelineIndirectBufferInfoNV
    ///     </a>
    /// </summary>
    public VkDeviceAddress deviceAddress;

    /// <summary>
    ///     size<br />
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkComputePipelineIndirectBufferInfoNV">
    ///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkComputePipelineIndirectBufferInfoNV
    ///     </a>
    /// </summary>
    public VkDeviceSize size;

    /// <summary>
    ///     pipelineDeviceAddressCaptureReplay<br />
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkComputePipelineIndirectBufferInfoNV">
    ///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkComputePipelineIndirectBufferInfoNV
    ///     </a>
    /// </summary>
    public VkDeviceAddress pipelineDeviceAddressCaptureReplay;
}