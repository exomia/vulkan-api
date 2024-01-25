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

    /// <summary>sType is a VkStructureType value identifying this structure.</summary>
    public VkStructureType sType;

    /// <summary>pNext is NULL or a pointer to a structure extending this structure.</summary>
    public void* pNext;

    /// <summary>deviceAddress is the address where the pipeline&#8217;s metadata will be stored.</summary>
    public VkDeviceAddress deviceAddress;

    /// <summary>
    ///     size is the size of pipeline&#8217;s metadata that was queried using
    ///     vkGetPipelineIndirectMemoryRequirementsNV.
    /// </summary>
    public VkDeviceSize size;

    /// <summary>
    ///     pipelineDeviceAddressCaptureReplay is the device address where pipeline&#8217;s metadata was originally saved
    ///     and can now be used to re-populate deviceAddress for replay.
    /// </summary>
    public VkDeviceAddress pipelineDeviceAddressCaptureReplay;
}