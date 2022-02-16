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
///     VkSetStateFlagsIndirectCommandNV - Structure specifying input data for a single state flag command token -
///     <a
///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkSetStateFlagsIndirectCommandNV.html">
///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkSetStateFlagsIndirectCommandNV.html
///     </a>
/// </summary>
[StructLayout(LayoutKind.Sequential)]
public struct VkSetStateFlagsIndirectCommandNV
{
    /// <summary>
    ///     data encodes packed state that this command alters.Bit 0: If set represents VK_FRONT_FACE_CLOCKWISE, otherwise
    ///     VK_FRONT_FACE_COUNTER_CLOCKWISE
    /// </summary>
    public uint data;
}