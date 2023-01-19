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
///     VkClearColorValue - Structure specifying a clear color value -
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkClearColorValue.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkClearColorValue.html</a>
/// </summary>
[StructLayout(LayoutKind.Explicit)]
public unsafe struct VkClearColorValue
{
    /// <summary>
    ///     float32 are the color clear values when the format of the image or attachment is one of the formats in the
    ///     https://registry.khronos.org/vulkan/specs/1.3-extensions/html/vkspec.html#formats-numericformat table other than
    ///     signed integer (SINT) or unsigned integer (UINT). Floating point values are automatically converted to the format
    ///     of the image, with the clear value being treated as linear if the image is sRGB.
    /// </summary>
    [FieldOffset(0)]
    public fixed float float32[4];

    /// <summary>
    ///     int32 are the color clear values when the format of the image or attachment is signed integer (SINT). Signed
    ///     integer values are converted to the format of the image by casting to the smaller type (with negative 32-bit values
    ///     mapping to negative values in the smaller type). If the integer clear value is not representable in the target type
    ///     (e.g. would overflow in conversion to that type), the clear value is undefined.
    /// </summary>
    [FieldOffset(0)]
    public fixed int int32[4];

    /// <summary>
    ///     uint32 are the color clear values when the format of the image or attachment is unsigned integer (UINT).
    ///     Unsigned integer values are converted to the format of the image by casting to the integer type with fewer bits.
    /// </summary>
    [FieldOffset(0)]
    public fixed uint uint32[4];
}