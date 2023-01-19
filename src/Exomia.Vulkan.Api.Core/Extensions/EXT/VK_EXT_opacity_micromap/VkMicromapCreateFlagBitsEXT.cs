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
///     VkMicromapCreateFlagBitsEXT - Bitmask specifying additional creation parameters for micromap -
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkMicromapCreateFlagBitsEXT.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkMicromapCreateFlagBitsEXT.html</a>
/// </summary>
[Flags]
public enum VkMicromapCreateFlagBitsEXT
{
    /// <summary>
    ///     VK_MICROMAP_CREATE_DEVICE_ADDRESS_CAPTURE_REPLAY_BIT_EXT specifies that the micromap&#8217;s address can be
    ///     saved and reused on a subsequent run.
    /// </summary>
    VK_MICROMAP_CREATE_DEVICE_ADDRESS_CAPTURE_REPLAY_BIT_EXT = 0x1
}