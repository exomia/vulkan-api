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
///     VkBindImageMemoryInfo - Structure specifying how to bind an image to memory -
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkBindImageMemoryInfo.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkBindImageMemoryInfo.html</a>
/// </summary>
[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkBindImageMemoryInfo
{
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_BIND_IMAGE_MEMORY_INFO;

    /// <summary>sType is the type of this structure.</summary>
    public VkStructureType sType;

    /// <summary>pNext is NULL or a pointer to a structure extending this structure.</summary>
    public void* pNext;

    /// <summary>image is the image to be attached to memory.</summary>
    public VkImage image;

    /// <summary>memory is a VkDeviceMemory object describing the device memory to attach.</summary>
    public VkDeviceMemory memory;

    /// <summary>
    ///     memoryOffset is the start offset of the region of memorywhich is to be bound to the image. The number of bytes
    ///     returned in the VkMemoryRequirements::size member in memory, starting from memoryOffset bytes, will be bound to the
    ///     specified image.
    /// </summary>
    public VkDeviceSize memoryOffset;
}