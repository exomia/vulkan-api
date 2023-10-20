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
///     VkCudaLaunchInfoNV - Structure specifying the parameters to launch a CUDA kernel -
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkCudaLaunchInfoNV.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkCudaLaunchInfoNV.html</a>
/// </summary>
[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkCudaLaunchInfoNV
{
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_CUDA_LAUNCH_INFO_NV;

    /// <summary>sType is a VkStructureType value identifying this structure.</summary>
    public VkStructureType sType;

    /// <summary>pNext is NULL or a pointer to a structure extending this structure.</summary>
    public void* pNext;

    /// <summary>function is the CUDA-Driver handle to the function being launched.</summary>
    public VkCudaFunctionNV function;

    /// <summary>
    ///     gridDimX is the number of local workgroups to dispatch in the X dimension. It must be less than or equal to
    ///     VkPhysicalDeviceLimits::maxComputeWorkGroupCount[0]
    /// </summary>
    public uint gridDimX;

    /// <summary>
    ///     gridDimY is the number of local workgroups to dispatch in the Y dimension. It must be less than or equal to
    ///     VkPhysicalDeviceLimits::maxComputeWorkGroupCount[1]
    /// </summary>
    public uint gridDimY;

    /// <summary>
    ///     gridDimZ is the number of local workgroups to dispatch in the Z dimension. It must be less than or equal to
    ///     VkPhysicalDeviceLimits::maxComputeWorkGroupCount[2]
    /// </summary>
    public uint gridDimZ;

    /// <summary>blockDimX is block size in the X dimension.</summary>
    public uint blockDimX;

    /// <summary>blockDimY is block size in the Y dimension.</summary>
    public uint blockDimY;

    /// <summary>blockDimZ is block size in the Z dimension.</summary>
    public uint blockDimZ;

    /// <summary>sharedMemBytes is the dynamic shared-memory size per thread block in bytes.</summary>
    public uint sharedMemBytes;

    /// <summary>paramCount is the length of the pParams table.</summary>
    public nuint paramCount;

    /// <summary>pParams is a pointer to an array of paramCount pointers, corresponding to the arguments of function.</summary>
    public void** pParams;

    /// <summary>extraCount is reserved for future use.</summary>
    public nuint extraCount;

    /// <summary>pExtras is reserved for future use.</summary>
    public void** pExtras;
}