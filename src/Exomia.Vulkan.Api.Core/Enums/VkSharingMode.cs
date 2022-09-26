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
///     VkSharingMode - Buffer and image sharing modes -
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkSharingMode.html"> https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkSharingMode.html </a>
/// </summary>
public enum VkSharingMode
{
    /// <summary> VK_SHARING_MODE_EXCLUSIVE specifies that access to any range or image subresource of the object will be exclusive to a single queue family at a time. </summary>
    VK_SHARING_MODE_EXCLUSIVE = 0,

    /// <summary> VK_SHARING_MODE_CONCURRENT specifies that concurrent access to any range or image subresource of the object from multiple queue families is supported. </summary>
    VK_SHARING_MODE_CONCURRENT = 1
}