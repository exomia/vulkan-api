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
///     VkMicromapUsageEXT - Structure specifying the usage information used to build a micromap -
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkMicromapUsageEXT.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkMicromapUsageEXT.html</a>
/// </summary>
[StructLayout(LayoutKind.Sequential)]
public struct VkMicromapUsageEXT
{
    /// <summary>
    ///     count is the number of triangles in the usage format defined by the subdivisionLevel and format below in the
    ///     micromap
    /// </summary>
    public uint count;

    /// <summary>subdivisionLevel is the subdivision level of this usage format</summary>
    public uint subdivisionLevel;

    /// <summary>format is the format of this usage format</summary>
    public uint format;
}