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
///     VkPipelineBinaryKeysAndDataKHR - Structure specifying arrays of key and data pairs -
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkPipelineBinaryKeysAndDataKHR.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkPipelineBinaryKeysAndDataKHR.html</a>
/// </summary>
[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPipelineBinaryKeysAndDataKHR
{
    /// <summary>binaryCount is the size of the pPipelineBinaryKeys and pPipelineBinaryData arrays</summary>
    public uint binaryCount;

    /// <summary>
    ///     pPipelineBinaryKeys is a pointer to an array of VkPipelineBinaryKeyKHR structures containing the pipeline
    ///     binary keys
    /// </summary>
    public VkPipelineBinaryKeyKHR* pPipelineBinaryKeys;

    /// <summary>
    ///     pPipelineBinaryData is a pointer to an array of VkPipelineBinaryDataKHR structures containing the pipeline
    ///     binary data
    /// </summary>
    public VkPipelineBinaryDataKHR* pPipelineBinaryData;
}