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
///     VkPipelineCacheHeaderVersionOne - Structure describing the layout of the pipeline cache header -
///     <a
///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkPipelineCacheHeaderVersionOne.html">
///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkPipelineCacheHeaderVersionOne.html
///     </a>
/// </summary>
[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPipelineCacheHeaderVersionOne
{
    /// <summary>headerSize is the length in bytes of the pipeline cache header.</summary>
    public uint headerSize;

    /// <summary>
    ///     headerVersion is a VkPipelineCacheHeaderVersion enum value specifying the version of the header. A consumer of
    ///     the pipeline cache should use the cache version to interpret the remainder of the cache header.
    /// </summary>
    public VkPipelineCacheHeaderVersion headerVersion;

    /// <summary>vendorID is the VkPhysicalDeviceProperties::vendorIDof the implementation.</summary>
    public uint vendorID;

    /// <summary>deviceID is the VkPhysicalDeviceProperties::deviceIDof the implementation.</summary>
    public uint deviceID;

    /// <summary>pipelineCacheUUID is the VkPhysicalDeviceProperties::pipelineCacheUUID of the implementation.</summary>
    public fixed byte pipelineCacheUUID[(int)VK_UUID_SIZE];
}