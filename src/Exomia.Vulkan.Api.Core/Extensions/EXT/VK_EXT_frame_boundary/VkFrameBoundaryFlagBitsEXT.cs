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
///     VkFrameBoundaryFlagBitsEXT - Bitmask specifying whether a queue submission is the last one for a given frame
///     -
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkFrameBoundaryFlagBitsEXT.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkFrameBoundaryFlagBitsEXT.html</a>
/// </summary>
[Flags]
public enum VkFrameBoundaryFlagBitsEXT
{
    /// <summary>
    ///     VK_FRAME_BOUNDARY_FRAME_END_BIT_EXT specifies that this queue submission is the last one for this frame, i.e.
    ///     once this queue submission has terminated, then the work for this frame is completed.
    /// </summary>
    VK_FRAME_BOUNDARY_FRAME_END_BIT_EXT = 0x1
}