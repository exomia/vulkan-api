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
///     VkHostImageCopyFlagBitsEXT - Bitmask specifying additional copy parameters -
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkHostImageCopyFlagBitsEXT.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkHostImageCopyFlagBitsEXT.html</a>
/// </summary>
[Flags]
public enum VkHostImageCopyFlagBitsEXT
{
    /// <summary>
    ///     VK_HOST_IMAGE_COPY_MEMCPY_EXT specifies that no memory layout swizzling is to be applied during data copy. For
    ///     copies between memory and images, this flag indicates that image data in host memory is swizzled in exactly the
    ///     same way as the image data on the device. Using this flag indicates that the implementations may use a simple
    ///     memory copy to transfer the data between the host memory and the device memory. The format of the swizzled data in
    ///     host memory is platform dependent and is not defined in this specification.
    /// </summary>
    VK_HOST_IMAGE_COPY_MEMCPY_EXT = 0x1
}