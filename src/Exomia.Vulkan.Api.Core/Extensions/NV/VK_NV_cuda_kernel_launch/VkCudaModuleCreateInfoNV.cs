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
///     VkCudaModuleCreateInfoNV - Structure specifying the parameters to create a CUDA Module -
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkCudaModuleCreateInfoNV.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkCudaModuleCreateInfoNV.html</a>
/// </summary>
[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkCudaModuleCreateInfoNV
{
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_CUDA_MODULE_CREATE_INFO_NV;

    /// <summary>sType is a VkStructureType value identifying this structure.</summary>
    public VkStructureType sType;

    /// <summary>pNext may be NULL or may be a pointer to a structure extending this structure.</summary>
    public void* pNext;

    /// <summary>dataSize is the length of the pData array.</summary>
    public nuint dataSize;

    /// <summary>pData is a pointer to CUDA code</summary>
    public void* pData;
}