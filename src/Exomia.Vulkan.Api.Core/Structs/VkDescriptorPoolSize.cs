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
///     VkDescriptorPoolSize - Structure specifying descriptor pool size -
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkDescriptorPoolSize.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkDescriptorPoolSize.html</a>
/// </summary>
[StructLayout(LayoutKind.Sequential)]
public struct VkDescriptorPoolSize
{
    /// <summary>type is the type of descriptor.</summary>
    public VkDescriptorType type;

    /// <summary>
    ///     descriptorCount is the number of descriptors of that type to allocate. If type is
    ///     VK_DESCRIPTOR_TYPE_INLINE_UNIFORM_BLOCK then descriptorCount is the number of bytes to allocate for descriptors of
    ///     this type.
    /// </summary>
    public uint descriptorCount;
}