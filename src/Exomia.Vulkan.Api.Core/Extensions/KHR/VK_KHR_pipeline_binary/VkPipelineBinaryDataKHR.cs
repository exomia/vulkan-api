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
///     VkPipelineBinaryDataKHR - Structure specifying data and length of a pipeline binary -
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkPipelineBinaryDataKHR.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkPipelineBinaryDataKHR.html</a>
/// </summary>
[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPipelineBinaryDataKHR
{
    /// <summary>dataSize is the size of the pData buffer in bytes.</summary>
    public nuint dataSize;

    /// <summary>
    ///     pData is a pointer to a buffer of size bytes that contains pipeline binary data obtained from
    ///     vkGetPipelineBinaryDataKHR.
    /// </summary>
    public void* pData;
}