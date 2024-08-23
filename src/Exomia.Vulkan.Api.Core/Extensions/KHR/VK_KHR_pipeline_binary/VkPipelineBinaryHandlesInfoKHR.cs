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
///     VkPipelineBinaryHandlesInfoKHR - Structure containing newly created pipeline binaries -
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkPipelineBinaryHandlesInfoKHR.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkPipelineBinaryHandlesInfoKHR.html</a>
/// </summary>
[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPipelineBinaryHandlesInfoKHR
{
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_PIPELINE_BINARY_HANDLES_INFO_KHR;

    /// <summary>sType is a VkStructureType value identifying this structure.</summary>
    public VkStructureType sType;

    /// <summary>pNext is NULL or a pointer to a structure extending this structure.</summary>
    public void* pNext;

    /// <summary>
    ///     pipelineBinaryCount is the number of binaries associated with this pipeline or the number of entries in the
    ///     pPipelineBinaries array.
    /// </summary>
    public uint pipelineBinaryCount;

    /// <summary>
    ///     pPipelineBinaries is NULL or a pointer to an array of VkPipelineBinaryKHR handles in which the resulting
    ///     pipeline binaries are returned.
    /// </summary>
    public VkPipelineBinaryKHR* pPipelineBinaries;
}