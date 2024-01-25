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
///     VkSubmitFlagBits - Bitmask specifying behavior of a submission -
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkSubmitFlagBits.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkSubmitFlagBits.html</a>
/// </summary>
[Flags]
public enum VkSubmitFlagBits
{
    /// <summary>VK_SUBMIT_PROTECTED_BIT specifies that this batch is a protected submission.</summary>
    VK_SUBMIT_PROTECTED_BIT = 0x1,

    /// <summary>VK_SUBMIT_PROTECTED_BIT specifies that this batch is a protected submission.</summary>
    VK_SUBMIT_PROTECTED_BIT_KHR = VK_SUBMIT_PROTECTED_BIT
}