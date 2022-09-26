#region License

// Copyright (c) 2018-2022, exomia
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
///     VkTraceRaysIndirectCommandKHR - Structure specifying the parameters of an indirect ray tracing command -
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkTraceRaysIndirectCommandKHR.html"> https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkTraceRaysIndirectCommandKHR.html </a>
/// </summary>
[StructLayout(LayoutKind.Sequential)]
public struct VkTraceRaysIndirectCommandKHR
{
    /// <summary> width is the width of the ray trace query dimensions. </summary>
    public uint width;

    /// <summary> height is height of the ray trace query dimensions. </summary>
    public uint height;

    /// <summary> depth is depth of the ray trace query dimensions. </summary>
    public uint depth;
}