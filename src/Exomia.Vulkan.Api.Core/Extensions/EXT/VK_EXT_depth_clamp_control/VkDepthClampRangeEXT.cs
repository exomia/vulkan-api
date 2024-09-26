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
///     VkDepthClampRangeEXT - Structure specifying a depth clamp range -
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkDepthClampRangeEXT.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkDepthClampRangeEXT.html</a>
/// </summary>
[StructLayout(LayoutKind.Sequential)]
public struct VkDepthClampRangeEXT
{
    /// <summary>minDepthClamp sets zmin in the depth clamp range of the viewport.</summary>
    public float minDepthClamp;

    /// <summary>maxDepthClamp sets zmax in the depth clamp range of the viewport.</summary>
    public float maxDepthClamp;
}