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
///     VkCudaFunctionCreateInfoNV - Structure specifying the parameters to create a CUDA Function -
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkCudaFunctionCreateInfoNV.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkCudaFunctionCreateInfoNV.html</a>
/// </summary>
[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkCudaFunctionCreateInfoNV
{
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_CUDA_FUNCTION_CREATE_INFO_NV;

    /// <summary>sType is a VkStructureType value identifying this structure.</summary>
    public VkStructureType sType;

    /// <summary>pNext is NULL or a pointer to a structure extending this structure.</summary>
    public void* pNext;

    /// <summary>module is the CUDA VkCudaModuleNV module in which the function resides.</summary>
    public VkCudaModuleNV module;

    /// <summary>pName is a null-terminated UTF-8 string containing the name of the shader entry point for this stage.</summary>
    public byte* pName;
}