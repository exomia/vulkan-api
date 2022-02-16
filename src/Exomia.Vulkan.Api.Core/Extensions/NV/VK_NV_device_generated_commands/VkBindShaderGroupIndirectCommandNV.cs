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
///     VkBindShaderGroupIndirectCommandNV - Structure specifying input data for a single shader group command token
///     -
///     <a
///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkBindShaderGroupIndirectCommandNV.html">
///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkBindShaderGroupIndirectCommandNV.html
///     </a>
/// </summary>
[StructLayout(LayoutKind.Sequential)]
public struct VkBindShaderGroupIndirectCommandNV
{
    /// <summary>
    ///     groupIndex<br />
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkBindShaderGroupIndirectCommandNV">
    ///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkBindShaderGroupIndirectCommandNV
    ///     </a>
    /// </summary>
    public uint groupIndex;
}