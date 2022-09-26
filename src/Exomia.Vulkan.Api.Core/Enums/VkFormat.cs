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
///     VkFormat - Available image formats -
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkFormat.html"> https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkFormat.html </a>
/// </summary>
public enum VkFormat
{
    /// <summary> VK_FORMAT_UNDEFINED specifies that the format is not specified. </summary>
    VK_FORMAT_UNDEFINED = 0,

    /// <summary> VK_FORMAT_R4G4_UNORM_PACK8 specifies a two-component, 8-bit packed unsigned normalized format that has a 4-bit R component in bits 4..7, and a 4-bit G component in bits 0..3. </summary>
    VK_FORMAT_R4G4_UNORM_PACK8 = 1,

    /// <summary> VK_FORMAT_R4G4B4A4_UNORM_PACK16 specifies a four-component, 16-bit packed unsigned normalized format that has a 4-bit R component in bits 12..15, a 4-bit G component in bits 8..11, a 4-bit B component in bits 4..7, and a 4-bit A component in bits 0..3. </summary>
    VK_FORMAT_R4G4B4A4_UNORM_PACK16 = 2,

    /// <summary> VK_FORMAT_B4G4R4A4_UNORM_PACK16 specifies a four-component, 16-bit packed unsigned normalized format that has a 4-bit B component in bits 12..15, a 4-bit G component in bits 8..11, a 4-bit R component in bits 4..7, and a 4-bit A component in bits 0..3. </summary>
    VK_FORMAT_B4G4R4A4_UNORM_PACK16 = 3,

    /// <summary> VK_FORMAT_R5G6B5_UNORM_PACK16 specifies a three-component, 16-bit packed unsigned normalized format that has a 5-bit R component in bits 11..15, a 6-bit G component in bits 5..10, and a 5-bit B component in bits 0..4. </summary>
    VK_FORMAT_R5G6B5_UNORM_PACK16 = 4,

    /// <summary> VK_FORMAT_B5G6R5_UNORM_PACK16 specifies a three-component, 16-bit packed unsigned normalized format that has a 5-bit B component in bits 11..15, a 6-bit G component in bits 5..10, and a 5-bit R component in bits 0..4. </summary>
    VK_FORMAT_B5G6R5_UNORM_PACK16 = 5,

    /// <summary> VK_FORMAT_R5G5B5A1_UNORM_PACK16 specifies a four-component, 16-bit packed unsigned normalized format that has a 5-bit R component in bits 11..15, a 5-bit G component in bits 6..10, a 5-bit B component in bits 1..5, and a 1-bit A component in bit 0. </summary>
    VK_FORMAT_R5G5B5A1_UNORM_PACK16 = 6,

    /// <summary> VK_FORMAT_B5G5R5A1_UNORM_PACK16 specifies a four-component, 16-bit packed unsigned normalized format that has a 5-bit B component in bits 11..15, a 5-bit G component in bits 6..10, a 5-bit R component in bits 1..5, and a 1-bit A component in bit 0. </summary>
    VK_FORMAT_B5G5R5A1_UNORM_PACK16 = 7,

    /// <summary> VK_FORMAT_A1R5G5B5_UNORM_PACK16 specifies a four-component, 16-bit packed unsigned normalized format that has a 1-bit A component in bit 15, a 5-bit R component in bits 10..14, a 5-bit G component in bits 5..9, and a 5-bit B component in bits 0..4. </summary>
    VK_FORMAT_A1R5G5B5_UNORM_PACK16 = 8,

    /// <summary> VK_FORMAT_R8_UNORM specifies a one-component, 8-bit unsigned normalized format that has a single 8-bit R component. </summary>
    VK_FORMAT_R8_UNORM = 9,

    /// <summary> VK_FORMAT_R8_SNORM specifies a one-component, 8-bit signed normalized format that has a single 8-bit R component. </summary>
    VK_FORMAT_R8_SNORM = 10,

    /// <summary> VK_FORMAT_R8_USCALED specifies a one-component, 8-bit unsigned scaled integer format that has a single 8-bit R component. </summary>
    VK_FORMAT_R8_USCALED = 11,

    /// <summary> VK_FORMAT_R8_SSCALED specifies a one-component, 8-bit signed scaled integer format that has a single 8-bit R component. </summary>
    VK_FORMAT_R8_SSCALED = 12,

    /// <summary> VK_FORMAT_R8_UINT specifies a one-component, 8-bit unsigned integer format that has a single 8-bit R component. </summary>
    VK_FORMAT_R8_UINT = 13,

    /// <summary> VK_FORMAT_R8_SINT specifies a one-component, 8-bit signed integer format that has a single 8-bit R component. </summary>
    VK_FORMAT_R8_SINT = 14,

    /// <summary> VK_FORMAT_R8_SRGB specifies a one-component, 8-bit unsigned normalized format that has a single 8-bit R component stored with sRGB nonlinear encoding. </summary>
    VK_FORMAT_R8_SRGB = 15,

    /// <summary> VK_FORMAT_R8G8_UNORM specifies a two-component, 16-bit unsigned normalized format that has an 8-bit R component in byte 0, and an 8-bit G component in byte 1. </summary>
    VK_FORMAT_R8G8_UNORM = 16,

    /// <summary> VK_FORMAT_R8G8_SNORM specifies a two-component, 16-bit signed normalized format that has an 8-bit R component in byte 0, and an 8-bit G component in byte 1. </summary>
    VK_FORMAT_R8G8_SNORM = 17,

    /// <summary> VK_FORMAT_R8G8_USCALED specifies a two-component, 16-bit unsigned scaled integer format that has an 8-bit R component in byte 0, and an 8-bit G component in byte 1. </summary>
    VK_FORMAT_R8G8_USCALED = 18,

    /// <summary> VK_FORMAT_R8G8_SSCALED specifies a two-component, 16-bit signed scaled integer format that has an 8-bit R component in byte 0, and an 8-bit G component in byte 1. </summary>
    VK_FORMAT_R8G8_SSCALED = 19,

    /// <summary> VK_FORMAT_R8G8_UINT specifies a two-component, 16-bit unsigned integer format that has an 8-bit R component in byte 0, and an 8-bit G component in byte 1. </summary>
    VK_FORMAT_R8G8_UINT = 20,

    /// <summary> VK_FORMAT_R8G8_SINT specifies a two-component, 16-bit signed integer format that has an 8-bit R component in byte 0, and an 8-bit G component in byte 1. </summary>
    VK_FORMAT_R8G8_SINT = 21,

    /// <summary> VK_FORMAT_R8G8_SRGB specifies a two-component, 16-bit unsigned normalized format that has an 8-bit R component stored with sRGB nonlinear encoding in byte 0, and an 8-bit G component stored with sRGB nonlinear encoding in byte 1. </summary>
    VK_FORMAT_R8G8_SRGB = 22,

    /// <summary> VK_FORMAT_R8G8B8_UNORM specifies a three-component, 24-bit unsigned normalized format that has an 8-bit R component in byte 0, an 8-bit G component in byte 1, and an 8-bit B component in byte 2. </summary>
    VK_FORMAT_R8G8B8_UNORM = 23,

    /// <summary> VK_FORMAT_R8G8B8_SNORM specifies a three-component, 24-bit signed normalized format that has an 8-bit R component in byte 0, an 8-bit G component in byte 1, and an 8-bit B component in byte 2. </summary>
    VK_FORMAT_R8G8B8_SNORM = 24,

    /// <summary> VK_FORMAT_R8G8B8_USCALED specifies a three-component, 24-bit unsigned scaled format that has an 8-bit R component in byte 0, an 8-bit G component in byte 1, and an 8-bit B component in byte 2. </summary>
    VK_FORMAT_R8G8B8_USCALED = 25,

    /// <summary> VK_FORMAT_R8G8B8_SSCALED specifies a three-component, 24-bit signed scaled format that has an 8-bit R component in byte 0, an 8-bit G component in byte 1, and an 8-bit B component in byte 2. </summary>
    VK_FORMAT_R8G8B8_SSCALED = 26,

    /// <summary> VK_FORMAT_R8G8B8_UINT specifies a three-component, 24-bit unsigned integer format that has an 8-bit R component in byte 0, an 8-bit G component in byte 1, and an 8-bit B component in byte 2. </summary>
    VK_FORMAT_R8G8B8_UINT = 27,

    /// <summary> VK_FORMAT_R8G8B8_SINT specifies a three-component, 24-bit signed integer format that has an 8-bit R component in byte 0, an 8-bit G component in byte 1, and an 8-bit B component in byte 2. </summary>
    VK_FORMAT_R8G8B8_SINT = 28,

    /// <summary> VK_FORMAT_R8G8B8_SRGB specifies a three-component, 24-bit unsigned normalized format that has an 8-bit R component stored with sRGB nonlinear encoding in byte 0, an 8-bit G component stored with sRGB nonlinear encoding in byte 1, and an 8-bit B component stored with sRGB nonlinear encoding in byte 2. </summary>
    VK_FORMAT_R8G8B8_SRGB = 29,

    /// <summary> VK_FORMAT_B8G8R8_UNORM specifies a three-component, 24-bit unsigned normalized format that has an 8-bit B component in byte 0, an 8-bit G component in byte 1, and an 8-bit R component in byte 2. </summary>
    VK_FORMAT_B8G8R8_UNORM = 30,

    /// <summary> VK_FORMAT_B8G8R8_SNORM specifies a three-component, 24-bit signed normalized format that has an 8-bit B component in byte 0, an 8-bit G component in byte 1, and an 8-bit R component in byte 2. </summary>
    VK_FORMAT_B8G8R8_SNORM = 31,

    /// <summary> VK_FORMAT_B8G8R8_USCALED specifies a three-component, 24-bit unsigned scaled format that has an 8-bit B component in byte 0, an 8-bit G component in byte 1, and an 8-bit R component in byte 2. </summary>
    VK_FORMAT_B8G8R8_USCALED = 32,

    /// <summary> VK_FORMAT_B8G8R8_SSCALED specifies a three-component, 24-bit signed scaled format that has an 8-bit B component in byte 0, an 8-bit G component in byte 1, and an 8-bit R component in byte 2. </summary>
    VK_FORMAT_B8G8R8_SSCALED = 33,

    /// <summary> VK_FORMAT_B8G8R8_UINT specifies a three-component, 24-bit unsigned integer format that has an 8-bit B component in byte 0, an 8-bit G component in byte 1, and an 8-bit R component in byte 2. </summary>
    VK_FORMAT_B8G8R8_UINT = 34,

    /// <summary> VK_FORMAT_B8G8R8_SINT specifies a three-component, 24-bit signed integer format that has an 8-bit B component in byte 0, an 8-bit G component in byte 1, and an 8-bit R component in byte 2. </summary>
    VK_FORMAT_B8G8R8_SINT = 35,

    /// <summary> VK_FORMAT_B8G8R8_SRGB specifies a three-component, 24-bit unsigned normalized format that has an 8-bit B component stored with sRGB nonlinear encoding in byte 0, an 8-bit G component stored with sRGB nonlinear encoding in byte 1, and an 8-bit R component stored with sRGB nonlinear encoding in byte 2. </summary>
    VK_FORMAT_B8G8R8_SRGB = 36,

    /// <summary> VK_FORMAT_R8G8B8A8_UNORM specifies a four-component, 32-bit unsigned normalized format that has an 8-bit R component in byte 0, an 8-bit G component in byte 1, an 8-bit B component in byte 2, and an 8-bit A component in byte 3. </summary>
    VK_FORMAT_R8G8B8A8_UNORM = 37,

    /// <summary> VK_FORMAT_R8G8B8A8_SNORM specifies a four-component, 32-bit signed normalized format that has an 8-bit R component in byte 0, an 8-bit G component in byte 1, an 8-bit B component in byte 2, and an 8-bit A component in byte 3. </summary>
    VK_FORMAT_R8G8B8A8_SNORM = 38,

    /// <summary> VK_FORMAT_R8G8B8A8_USCALED specifies a four-component, 32-bit unsigned scaled format that has an 8-bit R component in byte 0, an 8-bit G component in byte 1, an 8-bit B component in byte 2, and an 8-bit A component in byte 3. </summary>
    VK_FORMAT_R8G8B8A8_USCALED = 39,

    /// <summary> VK_FORMAT_R8G8B8A8_SSCALED specifies a four-component, 32-bit signed scaled format that has an 8-bit R component in byte 0, an 8-bit G component in byte 1, an 8-bit B component in byte 2, and an 8-bit A component in byte 3. </summary>
    VK_FORMAT_R8G8B8A8_SSCALED = 40,

    /// <summary> VK_FORMAT_R8G8B8A8_UINT specifies a four-component, 32-bit unsigned integer format that has an 8-bit R component in byte 0, an 8-bit G component in byte 1, an 8-bit B component in byte 2, and an 8-bit A component in byte 3. </summary>
    VK_FORMAT_R8G8B8A8_UINT = 41,

    /// <summary> VK_FORMAT_R8G8B8A8_SINT specifies a four-component, 32-bit signed integer format that has an 8-bit R component in byte 0, an 8-bit G component in byte 1, an 8-bit B component in byte 2, and an 8-bit A component in byte 3. </summary>
    VK_FORMAT_R8G8B8A8_SINT = 42,

    /// <summary> VK_FORMAT_R8G8B8A8_SRGB specifies a four-component, 32-bit unsigned normalized format that has an 8-bit R component stored with sRGB nonlinear encoding in byte 0, an 8-bit G component stored with sRGB nonlinear encoding in byte 1, an 8-bit B component stored with sRGB nonlinear encoding in byte 2, and an 8-bit A component in byte 3. </summary>
    VK_FORMAT_R8G8B8A8_SRGB = 43,

    /// <summary> VK_FORMAT_B8G8R8A8_UNORM specifies a four-component, 32-bit unsigned normalized format that has an 8-bit B component in byte 0, an 8-bit G component in byte 1, an 8-bit R component in byte 2, and an 8-bit A component in byte 3. </summary>
    VK_FORMAT_B8G8R8A8_UNORM = 44,

    /// <summary> VK_FORMAT_B8G8R8A8_SNORM specifies a four-component, 32-bit signed normalized format that has an 8-bit B component in byte 0, an 8-bit G component in byte 1, an 8-bit R component in byte 2, and an 8-bit A component in byte 3. </summary>
    VK_FORMAT_B8G8R8A8_SNORM = 45,

    /// <summary> VK_FORMAT_B8G8R8A8_USCALED specifies a four-component, 32-bit unsigned scaled format that has an 8-bit B component in byte 0, an 8-bit G component in byte 1, an 8-bit R component in byte 2, and an 8-bit A component in byte 3. </summary>
    VK_FORMAT_B8G8R8A8_USCALED = 46,

    /// <summary> VK_FORMAT_B8G8R8A8_SSCALED specifies a four-component, 32-bit signed scaled format that has an 8-bit B component in byte 0, an 8-bit G component in byte 1, an 8-bit R component in byte 2, and an 8-bit A component in byte 3. </summary>
    VK_FORMAT_B8G8R8A8_SSCALED = 47,

    /// <summary> VK_FORMAT_B8G8R8A8_UINT specifies a four-component, 32-bit unsigned integer format that has an 8-bit B component in byte 0, an 8-bit G component in byte 1, an 8-bit R component in byte 2, and an 8-bit A component in byte 3. </summary>
    VK_FORMAT_B8G8R8A8_UINT = 48,

    /// <summary> VK_FORMAT_B8G8R8A8_SINT specifies a four-component, 32-bit signed integer format that has an 8-bit B component in byte 0, an 8-bit G component in byte 1, an 8-bit R component in byte 2, and an 8-bit A component in byte 3. </summary>
    VK_FORMAT_B8G8R8A8_SINT = 49,

    /// <summary> VK_FORMAT_B8G8R8A8_SRGB specifies a four-component, 32-bit unsigned normalized format that has an 8-bit B component stored with sRGB nonlinear encoding in byte 0, an 8-bit G component stored with sRGB nonlinear encoding in byte 1, an 8-bit R component stored with sRGB nonlinear encoding in byte 2, and an 8-bit A component in byte 3. </summary>
    VK_FORMAT_B8G8R8A8_SRGB = 50,

    /// <summary> VK_FORMAT_A8B8G8R8_UNORM_PACK32 specifies a four-component, 32-bit packed unsigned normalized format that has an 8-bit A component in bits 24..31, an 8-bit B component in bits 16..23, an 8-bit G component in bits 8..15, and an 8-bit R component in bits 0..7. </summary>
    VK_FORMAT_A8B8G8R8_UNORM_PACK32 = 51,

    /// <summary> VK_FORMAT_A8B8G8R8_SNORM_PACK32 specifies a four-component, 32-bit packed signed normalized format that has an 8-bit A component in bits 24..31, an 8-bit B component in bits 16..23, an 8-bit G component in bits 8..15, and an 8-bit R component in bits 0..7. </summary>
    VK_FORMAT_A8B8G8R8_SNORM_PACK32 = 52,

    /// <summary> VK_FORMAT_A8B8G8R8_USCALED_PACK32 specifies a four-component, 32-bit packed unsigned scaled integer format that has an 8-bit A component in bits 24..31, an 8-bit B component in bits 16..23, an 8-bit G component in bits 8..15, and an 8-bit R component in bits 0..7. </summary>
    VK_FORMAT_A8B8G8R8_USCALED_PACK32 = 53,

    /// <summary> VK_FORMAT_A8B8G8R8_SSCALED_PACK32 specifies a four-component, 32-bit packed signed scaled integer format that has an 8-bit A component in bits 24..31, an 8-bit B component in bits 16..23, an 8-bit G component in bits 8..15, and an 8-bit R component in bits 0..7. </summary>
    VK_FORMAT_A8B8G8R8_SSCALED_PACK32 = 54,

    /// <summary> VK_FORMAT_A8B8G8R8_UINT_PACK32 specifies a four-component, 32-bit packed unsigned integer format that has an 8-bit A component in bits 24..31, an 8-bit B component in bits 16..23, an 8-bit G component in bits 8..15, and an 8-bit R component in bits 0..7. </summary>
    VK_FORMAT_A8B8G8R8_UINT_PACK32 = 55,

    /// <summary> VK_FORMAT_A8B8G8R8_SINT_PACK32 specifies a four-component, 32-bit packed signed integer format that has an 8-bit A component in bits 24..31, an 8-bit B component in bits 16..23, an 8-bit G component in bits 8..15, and an 8-bit R component in bits 0..7. </summary>
    VK_FORMAT_A8B8G8R8_SINT_PACK32 = 56,

    /// <summary> VK_FORMAT_A8B8G8R8_SRGB_PACK32 specifies a four-component, 32-bit packed unsigned normalized format that has an 8-bit A component in bits 24..31, an 8-bit B component stored with sRGB nonlinear encoding in bits 16..23, an 8-bit G component stored with sRGB nonlinear encoding in bits 8..15, and an 8-bit R component stored with sRGB nonlinear encoding in bits 0..7. </summary>
    VK_FORMAT_A8B8G8R8_SRGB_PACK32 = 57,

    /// <summary> VK_FORMAT_A2R10G10B10_UNORM_PACK32 specifies a four-component, 32-bit packed unsigned normalized format that has a 2-bit A component in bits 30..31, a 10-bit R component in bits 20..29, a 10-bit G component in bits 10..19, and a 10-bit B component in bits 0..9. </summary>
    VK_FORMAT_A2R10G10B10_UNORM_PACK32 = 58,

    /// <summary> VK_FORMAT_A2R10G10B10_SNORM_PACK32 specifies a four-component, 32-bit packed signed normalized format that has a 2-bit A component in bits 30..31, a 10-bit R component in bits 20..29, a 10-bit G component in bits 10..19, and a 10-bit B component in bits 0..9. </summary>
    VK_FORMAT_A2R10G10B10_SNORM_PACK32 = 59,

    /// <summary> VK_FORMAT_A2R10G10B10_USCALED_PACK32 specifies a four-component, 32-bit packed unsigned scaled integer format that has a 2-bit A component in bits 30..31, a 10-bit R component in bits 20..29, a 10-bit G component in bits 10..19, and a 10-bit B component in bits 0..9. </summary>
    VK_FORMAT_A2R10G10B10_USCALED_PACK32 = 60,

    /// <summary> VK_FORMAT_A2R10G10B10_SSCALED_PACK32 specifies a four-component, 32-bit packed signed scaled integer format that has a 2-bit A component in bits 30..31, a 10-bit R component in bits 20..29, a 10-bit G component in bits 10..19, and a 10-bit B component in bits 0..9. </summary>
    VK_FORMAT_A2R10G10B10_SSCALED_PACK32 = 61,

    /// <summary> VK_FORMAT_A2R10G10B10_UINT_PACK32 specifies a four-component, 32-bit packed unsigned integer format that has a 2-bit A component in bits 30..31, a 10-bit R component in bits 20..29, a 10-bit G component in bits 10..19, and a 10-bit B component in bits 0..9. </summary>
    VK_FORMAT_A2R10G10B10_UINT_PACK32 = 62,

    /// <summary> VK_FORMAT_A2R10G10B10_SINT_PACK32 specifies a four-component, 32-bit packed signed integer format that has a 2-bit A component in bits 30..31, a 10-bit R component in bits 20..29, a 10-bit G component in bits 10..19, and a 10-bit B component in bits 0..9. </summary>
    VK_FORMAT_A2R10G10B10_SINT_PACK32 = 63,

    /// <summary> VK_FORMAT_A2B10G10R10_UNORM_PACK32 specifies a four-component, 32-bit packed unsigned normalized format that has a 2-bit A component in bits 30..31, a 10-bit B component in bits 20..29, a 10-bit G component in bits 10..19, and a 10-bit R component in bits 0..9. </summary>
    VK_FORMAT_A2B10G10R10_UNORM_PACK32 = 64,

    /// <summary> VK_FORMAT_A2B10G10R10_SNORM_PACK32 specifies a four-component, 32-bit packed signed normalized format that has a 2-bit A component in bits 30..31, a 10-bit B component in bits 20..29, a 10-bit G component in bits 10..19, and a 10-bit R component in bits 0..9. </summary>
    VK_FORMAT_A2B10G10R10_SNORM_PACK32 = 65,

    /// <summary> VK_FORMAT_A2B10G10R10_USCALED_PACK32 specifies a four-component, 32-bit packed unsigned scaled integer format that has a 2-bit A component in bits 30..31, a 10-bit B component in bits 20..29, a 10-bit G component in bits 10..19, and a 10-bit R component in bits 0..9. </summary>
    VK_FORMAT_A2B10G10R10_USCALED_PACK32 = 66,

    /// <summary> VK_FORMAT_A2B10G10R10_SSCALED_PACK32 specifies a four-component, 32-bit packed signed scaled integer format that has a 2-bit A component in bits 30..31, a 10-bit B component in bits 20..29, a 10-bit G component in bits 10..19, and a 10-bit R component in bits 0..9. </summary>
    VK_FORMAT_A2B10G10R10_SSCALED_PACK32 = 67,

    /// <summary> VK_FORMAT_A2B10G10R10_UINT_PACK32 specifies a four-component, 32-bit packed unsigned integer format that has a 2-bit A component in bits 30..31, a 10-bit B component in bits 20..29, a 10-bit G component in bits 10..19, and a 10-bit R component in bits 0..9. </summary>
    VK_FORMAT_A2B10G10R10_UINT_PACK32 = 68,

    /// <summary> VK_FORMAT_A2B10G10R10_SINT_PACK32 specifies a four-component, 32-bit packed signed integer format that has a 2-bit A component in bits 30..31, a 10-bit B component in bits 20..29, a 10-bit G component in bits 10..19, and a 10-bit R component in bits 0..9. </summary>
    VK_FORMAT_A2B10G10R10_SINT_PACK32 = 69,

    /// <summary> VK_FORMAT_R16_UNORM specifies a one-component, 16-bit unsigned normalized format that has a single 16-bit R component. </summary>
    VK_FORMAT_R16_UNORM = 70,

    /// <summary> VK_FORMAT_R16_SNORM specifies a one-component, 16-bit signed normalized format that has a single 16-bit R component. </summary>
    VK_FORMAT_R16_SNORM = 71,

    /// <summary> VK_FORMAT_R16_USCALED specifies a one-component, 16-bit unsigned scaled integer format that has a single 16-bit R component. </summary>
    VK_FORMAT_R16_USCALED = 72,

    /// <summary> VK_FORMAT_R16_SSCALED specifies a one-component, 16-bit signed scaled integer format that has a single 16-bit R component. </summary>
    VK_FORMAT_R16_SSCALED = 73,

    /// <summary> VK_FORMAT_R16_UINT specifies a one-component, 16-bit unsigned integer format that has a single 16-bit R component. </summary>
    VK_FORMAT_R16_UINT = 74,

    /// <summary> VK_FORMAT_R16_SINT specifies a one-component, 16-bit signed integer format that has a single 16-bit R component. </summary>
    VK_FORMAT_R16_SINT = 75,

    /// <summary> VK_FORMAT_R16_SFLOAT specifies a one-component, 16-bit signed floating-point format that has a single 16-bit R component. </summary>
    VK_FORMAT_R16_SFLOAT = 76,

    /// <summary> VK_FORMAT_R16G16_UNORM specifies a two-component, 32-bit unsigned normalized format that has a 16-bit R component in bytes 0..1, and a 16-bit G component in bytes 2..3. </summary>
    VK_FORMAT_R16G16_UNORM = 77,

    /// <summary> VK_FORMAT_R16G16_SNORM specifies a two-component, 32-bit signed normalized format that has a 16-bit R component in bytes 0..1, and a 16-bit G component in bytes 2..3. </summary>
    VK_FORMAT_R16G16_SNORM = 78,

    /// <summary> VK_FORMAT_R16G16_USCALED specifies a two-component, 32-bit unsigned scaled integer format that has a 16-bit R component in bytes 0..1, and a 16-bit G component in bytes 2..3. </summary>
    VK_FORMAT_R16G16_USCALED = 79,

    /// <summary> VK_FORMAT_R16G16_SSCALED specifies a two-component, 32-bit signed scaled integer format that has a 16-bit R component in bytes 0..1, and a 16-bit G component in bytes 2..3. </summary>
    VK_FORMAT_R16G16_SSCALED = 80,

    /// <summary> VK_FORMAT_R16G16_UINT specifies a two-component, 32-bit unsigned integer format that has a 16-bit R component in bytes 0..1, and a 16-bit G component in bytes 2..3. </summary>
    VK_FORMAT_R16G16_UINT = 81,

    /// <summary> VK_FORMAT_R16G16_SINT specifies a two-component, 32-bit signed integer format that has a 16-bit R component in bytes 0..1, and a 16-bit G component in bytes 2..3. </summary>
    VK_FORMAT_R16G16_SINT = 82,

    /// <summary> VK_FORMAT_R16G16_SFLOAT specifies a two-component, 32-bit signed floating-point format that has a 16-bit R component in bytes 0..1, and a 16-bit G component in bytes 2..3. </summary>
    VK_FORMAT_R16G16_SFLOAT = 83,

    /// <summary> VK_FORMAT_R16G16B16_UNORM specifies a three-component, 48-bit unsigned normalized format that has a 16-bit R component in bytes 0..1, a 16-bit G component in bytes 2..3, and a 16-bit B component in bytes 4..5. </summary>
    VK_FORMAT_R16G16B16_UNORM = 84,

    /// <summary> VK_FORMAT_R16G16B16_SNORM specifies a three-component, 48-bit signed normalized format that has a 16-bit R component in bytes 0..1, a 16-bit G component in bytes 2..3, and a 16-bit B component in bytes 4..5. </summary>
    VK_FORMAT_R16G16B16_SNORM = 85,

    /// <summary> VK_FORMAT_R16G16B16_USCALED specifies a three-component, 48-bit unsigned scaled integer format that has a 16-bit R component in bytes 0..1, a 16-bit G component in bytes 2..3, and a 16-bit B component in bytes 4..5. </summary>
    VK_FORMAT_R16G16B16_USCALED = 86,

    /// <summary> VK_FORMAT_R16G16B16_SSCALED specifies a three-component, 48-bit signed scaled integer format that has a 16-bit R component in bytes 0..1, a 16-bit G component in bytes 2..3, and a 16-bit B component in bytes 4..5. </summary>
    VK_FORMAT_R16G16B16_SSCALED = 87,

    /// <summary> VK_FORMAT_R16G16B16_UINT specifies a three-component, 48-bit unsigned integer format that has a 16-bit R component in bytes 0..1, a 16-bit G component in bytes 2..3, and a 16-bit B component in bytes 4..5. </summary>
    VK_FORMAT_R16G16B16_UINT = 88,

    /// <summary> VK_FORMAT_R16G16B16_SINT specifies a three-component, 48-bit signed integer format that has a 16-bit R component in bytes 0..1, a 16-bit G component in bytes 2..3, and a 16-bit B component in bytes 4..5. </summary>
    VK_FORMAT_R16G16B16_SINT = 89,

    /// <summary> VK_FORMAT_R16G16B16_SFLOAT specifies a three-component, 48-bit signed floating-point format that has a 16-bit R component in bytes 0..1, a 16-bit G component in bytes 2..3, and a 16-bit B component in bytes 4..5. </summary>
    VK_FORMAT_R16G16B16_SFLOAT = 90,

    /// <summary> VK_FORMAT_R16G16B16A16_UNORM specifies a four-component, 64-bit unsigned normalized format that has a 16-bit R component in bytes 0..1, a 16-bit G component in bytes 2..3, a 16-bit B component in bytes 4..5, and a 16-bit A component in bytes 6..7. </summary>
    VK_FORMAT_R16G16B16A16_UNORM = 91,

    /// <summary> VK_FORMAT_R16G16B16A16_SNORM specifies a four-component, 64-bit signed normalized format that has a 16-bit R component in bytes 0..1, a 16-bit G component in bytes 2..3, a 16-bit B component in bytes 4..5, and a 16-bit A component in bytes 6..7. </summary>
    VK_FORMAT_R16G16B16A16_SNORM = 92,

    /// <summary> VK_FORMAT_R16G16B16A16_USCALED specifies a four-component, 64-bit unsigned scaled integer format that has a 16-bit R component in bytes 0..1, a 16-bit G component in bytes 2..3, a 16-bit B component in bytes 4..5, and a 16-bit A component in bytes 6..7. </summary>
    VK_FORMAT_R16G16B16A16_USCALED = 93,

    /// <summary> VK_FORMAT_R16G16B16A16_SSCALED specifies a four-component, 64-bit signed scaled integer format that has a 16-bit R component in bytes 0..1, a 16-bit G component in bytes 2..3, a 16-bit B component in bytes 4..5, and a 16-bit A component in bytes 6..7. </summary>
    VK_FORMAT_R16G16B16A16_SSCALED = 94,

    /// <summary> VK_FORMAT_R16G16B16A16_UINT specifies a four-component, 64-bit unsigned integer format that has a 16-bit R component in bytes 0..1, a 16-bit G component in bytes 2..3, a 16-bit B component in bytes 4..5, and a 16-bit A component in bytes 6..7. </summary>
    VK_FORMAT_R16G16B16A16_UINT = 95,

    /// <summary> VK_FORMAT_R16G16B16A16_SINT specifies a four-component, 64-bit signed integer format that has a 16-bit R component in bytes 0..1, a 16-bit G component in bytes 2..3, a 16-bit B component in bytes 4..5, and a 16-bit A component in bytes 6..7. </summary>
    VK_FORMAT_R16G16B16A16_SINT = 96,

    /// <summary> VK_FORMAT_R16G16B16A16_SFLOAT specifies a four-component, 64-bit signed floating-point format that has a 16-bit R component in bytes 0..1, a 16-bit G component in bytes 2..3, a 16-bit B component in bytes 4..5, and a 16-bit A component in bytes 6..7. </summary>
    VK_FORMAT_R16G16B16A16_SFLOAT = 97,

    /// <summary> VK_FORMAT_R32_UINT specifies a one-component, 32-bit unsigned integer format that has a single 32-bit R component. </summary>
    VK_FORMAT_R32_UINT = 98,

    /// <summary> VK_FORMAT_R32_SINT specifies a one-component, 32-bit signed integer format that has a single 32-bit R component. </summary>
    VK_FORMAT_R32_SINT = 99,

    /// <summary> VK_FORMAT_R32_SFLOAT specifies a one-component, 32-bit signed floating-point format that has a single 32-bit R component. </summary>
    VK_FORMAT_R32_SFLOAT = 100,

    /// <summary> VK_FORMAT_R32G32_UINT specifies a two-component, 64-bit unsigned integer format that has a 32-bit R component in bytes 0..3, and a 32-bit G component in bytes 4..7. </summary>
    VK_FORMAT_R32G32_UINT = 101,

    /// <summary> VK_FORMAT_R32G32_SINT specifies a two-component, 64-bit signed integer format that has a 32-bit R component in bytes 0..3, and a 32-bit G component in bytes 4..7. </summary>
    VK_FORMAT_R32G32_SINT = 102,

    /// <summary> VK_FORMAT_R32G32_SFLOAT specifies a two-component, 64-bit signed floating-point format that has a 32-bit R component in bytes 0..3, and a 32-bit G component in bytes 4..7. </summary>
    VK_FORMAT_R32G32_SFLOAT = 103,

    /// <summary> VK_FORMAT_R32G32B32_UINT specifies a three-component, 96-bit unsigned integer format that has a 32-bit R component in bytes 0..3, a 32-bit G component in bytes 4..7, and a 32-bit B component in bytes 8..11. </summary>
    VK_FORMAT_R32G32B32_UINT = 104,

    /// <summary> VK_FORMAT_R32G32B32_SINT specifies a three-component, 96-bit signed integer format that has a 32-bit R component in bytes 0..3, a 32-bit G component in bytes 4..7, and a 32-bit B component in bytes 8..11. </summary>
    VK_FORMAT_R32G32B32_SINT = 105,

    /// <summary> VK_FORMAT_R32G32B32_SFLOAT specifies a three-component, 96-bit signed floating-point format that has a 32-bit R component in bytes 0..3, a 32-bit G component in bytes 4..7, and a 32-bit B component in bytes 8..11. </summary>
    VK_FORMAT_R32G32B32_SFLOAT = 106,

    /// <summary> VK_FORMAT_R32G32B32A32_UINT specifies a four-component, 128-bit unsigned integer format that has a 32-bit R component in bytes 0..3, a 32-bit G component in bytes 4..7, a 32-bit B component in bytes 8..11, and a 32-bit A component in bytes 12..15. </summary>
    VK_FORMAT_R32G32B32A32_UINT = 107,

    /// <summary> VK_FORMAT_R32G32B32A32_SINT specifies a four-component, 128-bit signed integer format that has a 32-bit R component in bytes 0..3, a 32-bit G component in bytes 4..7, a 32-bit B component in bytes 8..11, and a 32-bit A component in bytes 12..15. </summary>
    VK_FORMAT_R32G32B32A32_SINT = 108,

    /// <summary> VK_FORMAT_R32G32B32A32_SFLOAT specifies a four-component, 128-bit signed floating-point format that has a 32-bit R component in bytes 0..3, a 32-bit G component in bytes 4..7, a 32-bit B component in bytes 8..11, and a 32-bit A component in bytes 12..15. </summary>
    VK_FORMAT_R32G32B32A32_SFLOAT = 109,

    /// <summary> VK_FORMAT_R64_UINT specifies a one-component, 64-bit unsigned integer format that has a single 64-bit R component. </summary>
    VK_FORMAT_R64_UINT = 110,

    /// <summary> VK_FORMAT_R64_SINT specifies a one-component, 64-bit signed integer format that has a single 64-bit R component. </summary>
    VK_FORMAT_R64_SINT = 111,

    /// <summary> VK_FORMAT_R64_SFLOAT specifies a one-component, 64-bit signed floating-point format that has a single 64-bit R component. </summary>
    VK_FORMAT_R64_SFLOAT = 112,

    /// <summary> VK_FORMAT_R64G64_UINT specifies a two-component, 128-bit unsigned integer format that has a 64-bit R component in bytes 0..7, and a 64-bit G component in bytes 8..15. </summary>
    VK_FORMAT_R64G64_UINT = 113,

    /// <summary> VK_FORMAT_R64G64_SINT specifies a two-component, 128-bit signed integer format that has a 64-bit R component in bytes 0..7, and a 64-bit G component in bytes 8..15. </summary>
    VK_FORMAT_R64G64_SINT = 114,

    /// <summary> VK_FORMAT_R64G64_SFLOAT specifies a two-component, 128-bit signed floating-point format that has a 64-bit R component in bytes 0..7, and a 64-bit G component in bytes 8..15. </summary>
    VK_FORMAT_R64G64_SFLOAT = 115,

    /// <summary> VK_FORMAT_R64G64B64_UINT specifies a three-component, 192-bit unsigned integer format that has a 64-bit R component in bytes 0..7, a 64-bit G component in bytes 8..15, and a 64-bit B component in bytes 16..23. </summary>
    VK_FORMAT_R64G64B64_UINT = 116,

    /// <summary> VK_FORMAT_R64G64B64_SINT specifies a three-component, 192-bit signed integer format that has a 64-bit R component in bytes 0..7, a 64-bit G component in bytes 8..15, and a 64-bit B component in bytes 16..23. </summary>
    VK_FORMAT_R64G64B64_SINT = 117,

    /// <summary> VK_FORMAT_R64G64B64_SFLOAT specifies a three-component, 192-bit signed floating-point format that has a 64-bit R component in bytes 0..7, a 64-bit G component in bytes 8..15, and a 64-bit B component in bytes 16..23. </summary>
    VK_FORMAT_R64G64B64_SFLOAT = 118,

    /// <summary> VK_FORMAT_R64G64B64A64_UINT specifies a four-component, 256-bit unsigned integer format that has a 64-bit R component in bytes 0..7, a 64-bit G component in bytes 8..15, a 64-bit B component in bytes 16..23, and a 64-bit A component in bytes 24..31. </summary>
    VK_FORMAT_R64G64B64A64_UINT = 119,

    /// <summary> VK_FORMAT_R64G64B64A64_SINT specifies a four-component, 256-bit signed integer format that has a 64-bit R component in bytes 0..7, a 64-bit G component in bytes 8..15, a 64-bit B component in bytes 16..23, and a 64-bit A component in bytes 24..31. </summary>
    VK_FORMAT_R64G64B64A64_SINT = 120,

    /// <summary> VK_FORMAT_R64G64B64A64_SFLOAT specifies a four-component, 256-bit signed floating-point format that has a 64-bit R component in bytes 0..7, a 64-bit G component in bytes 8..15, a 64-bit B component in bytes 16..23, and a 64-bit A component in bytes 24..31. </summary>
    VK_FORMAT_R64G64B64A64_SFLOAT = 121,

    /// <summary>
    ///     VK_FORMAT_B10G11R11_UFLOAT_PACK32 specifies a three-component, 32-bit packed unsigned floating-point format that has a 10-bit B component in bits 22..31, an 11-bit G component in bits 11..21, an 11-bit R component in bits 0..10. See
    ///     <a class="bare" href="https://registry.khronos.org/vulkan/specs/1.3-extensions/html/vkspec.html#fundamentals-fp10"> https://registry.khronos.org/vulkan/specs/1.3-extensions/html/vkspec.html#fundamentals-fp10 </a>
    ///     and
    ///     <a class="bare" href="https://registry.khronos.org/vulkan/specs/1.3-extensions/html/vkspec.html#fundamentals-fp11"> https://registry.khronos.org/vulkan/specs/1.3-extensions/html/vkspec.html#fundamentals-fp11 </a>
    ///     .
    /// </summary>
    VK_FORMAT_B10G11R11_UFLOAT_PACK32 = 122,

    /// <summary> VK_FORMAT_E5B9G9R9_UFLOAT_PACK32 specifies a three-component, 32-bit packed unsigned floating-point format that has a 5-bit shared exponent in bits 27..31, a 9-bit B component mantissa in bits 18..26, a 9-bit G component mantissa in bits 9..17, and a 9-bit R component mantissa in bits 0..8. </summary>
    VK_FORMAT_E5B9G9R9_UFLOAT_PACK32 = 123,

    /// <summary> VK_FORMAT_D16_UNORM specifies a one-component, 16-bit unsigned normalized format that has a single 16-bit depth component. </summary>
    VK_FORMAT_D16_UNORM = 124,

    /// <summary> VK_FORMAT_X8_D24_UNORM_PACK32 specifies a two-component, 32-bit format that has 24 unsigned normalized bits in the depth component and, optionally, 8 bits that are unused. </summary>
    VK_FORMAT_X8_D24_UNORM_PACK32 = 125,

    /// <summary> VK_FORMAT_D32_SFLOAT specifies a one-component, 32-bit signed floating-point format that has 32 bits in the depth component. </summary>
    VK_FORMAT_D32_SFLOAT = 126,

    /// <summary> VK_FORMAT_S8_UINT specifies a one-component, 8-bit unsigned integer format that has 8 bits in the stencil component. </summary>
    VK_FORMAT_S8_UINT = 127,

    /// <summary> VK_FORMAT_D16_UNORM_S8_UINT specifies a two-component, 24-bit format that has 16 unsigned normalized bits in the depth component and 8 unsigned integer bits in the stencil component. </summary>
    VK_FORMAT_D16_UNORM_S8_UINT = 128,

    /// <summary> VK_FORMAT_D24_UNORM_S8_UINT specifies a two-component, 32-bit packed format that has 8 unsigned integer bits in the stencil component, and 24 unsigned normalized bits in the depth component. </summary>
    VK_FORMAT_D24_UNORM_S8_UINT = 129,

    /// <summary> VK_FORMAT_D32_SFLOAT_S8_UINT specifies a two-component format that has 32 signed float bits in the depth component and 8 unsigned integer bits in the stencil component. There are optionally 24 bits that are unused. </summary>
    VK_FORMAT_D32_SFLOAT_S8_UINT = 130,

    /// <summary> VK_FORMAT_BC1_RGB_UNORM_BLOCK specifies a three-component, block-compressed format where each 64-bit compressed texel block encodes a 4×4 rectangle of unsigned normalized RGB texel data. This format has no alpha and is considered opaque. </summary>
    VK_FORMAT_BC1_RGB_UNORM_BLOCK = 131,

    /// <summary> VK_FORMAT_BC1_RGB_SRGB_BLOCK specifies a three-component, block-compressed format where each 64-bit compressed texel block encodes a 4×4 rectangle of unsigned normalized RGB texel data with sRGB nonlinear encoding. This format has no alpha and is considered opaque. </summary>
    VK_FORMAT_BC1_RGB_SRGB_BLOCK = 132,

    /// <summary> VK_FORMAT_BC1_RGBA_UNORM_BLOCK specifies a four-component, block-compressed format where each 64-bit compressed texel block encodes a 4×4 rectangle of unsigned normalized RGB texel data, and provides 1 bit of alpha. </summary>
    VK_FORMAT_BC1_RGBA_UNORM_BLOCK = 133,

    /// <summary> VK_FORMAT_BC1_RGBA_SRGB_BLOCK specifies a four-component, block-compressed format where each 64-bit compressed texel block encodes a 4×4 rectangle of unsigned normalized RGB texel data with sRGB nonlinear encoding, and provides 1 bit of alpha. </summary>
    VK_FORMAT_BC1_RGBA_SRGB_BLOCK = 134,

    /// <summary> VK_FORMAT_BC2_UNORM_BLOCK specifies a four-component, block-compressed format where each 128-bit compressed texel block encodes a 4×4 rectangle of unsigned normalized RGBA texel data with the first 64 bits encoding alpha values followed by 64 bits encoding RGB values. </summary>
    VK_FORMAT_BC2_UNORM_BLOCK = 135,

    /// <summary> VK_FORMAT_BC2_SRGB_BLOCK specifies a four-component, block-compressed format where each 128-bit compressed texel block encodes a 4×4 rectangle of unsigned normalized RGBA texel data with the first 64 bits encoding alpha values followed by 64 bits encoding RGB values with sRGB nonlinear encoding. </summary>
    VK_FORMAT_BC2_SRGB_BLOCK = 136,

    /// <summary> VK_FORMAT_BC3_UNORM_BLOCK specifies a four-component, block-compressed format where each 128-bit compressed texel block encodes a 4×4 rectangle of unsigned normalized RGBA texel data with the first 64 bits encoding alpha values followed by 64 bits encoding RGB values. </summary>
    VK_FORMAT_BC3_UNORM_BLOCK = 137,

    /// <summary> VK_FORMAT_BC3_SRGB_BLOCK specifies a four-component, block-compressed format where each 128-bit compressed texel block encodes a 4×4 rectangle of unsigned normalized RGBA texel data with the first 64 bits encoding alpha values followed by 64 bits encoding RGB values with sRGB nonlinear encoding. </summary>
    VK_FORMAT_BC3_SRGB_BLOCK = 138,

    /// <summary> VK_FORMAT_BC4_UNORM_BLOCK specifies a one-component, block-compressed format where each 64-bit compressed texel block encodes a 4×4 rectangle of unsigned normalized red texel data. </summary>
    VK_FORMAT_BC4_UNORM_BLOCK = 139,

    /// <summary> VK_FORMAT_BC4_SNORM_BLOCK specifies a one-component, block-compressed format where each 64-bit compressed texel block encodes a 4×4 rectangle of signed normalized red texel data. </summary>
    VK_FORMAT_BC4_SNORM_BLOCK = 140,

    /// <summary> VK_FORMAT_BC5_UNORM_BLOCK specifies a two-component, block-compressed format where each 128-bit compressed texel block encodes a 4×4 rectangle of unsigned normalized RG texel data with the first 64 bits encoding red values followed by 64 bits encoding green values. </summary>
    VK_FORMAT_BC5_UNORM_BLOCK = 141,

    /// <summary> VK_FORMAT_BC5_SNORM_BLOCK specifies a two-component, block-compressed format where each 128-bit compressed texel block encodes a 4×4 rectangle of signed normalized RG texel data with the first 64 bits encoding red values followed by 64 bits encoding green values. </summary>
    VK_FORMAT_BC5_SNORM_BLOCK = 142,

    /// <summary> VK_FORMAT_BC6H_UFLOAT_BLOCK specifies a three-component, block-compressed format where each 128-bit compressed texel block encodes a 4×4 rectangle of unsigned floating-point RGB texel data. </summary>
    VK_FORMAT_BC6H_UFLOAT_BLOCK = 143,

    /// <summary> VK_FORMAT_BC6H_SFLOAT_BLOCK specifies a three-component, block-compressed format where each 128-bit compressed texel block encodes a 4×4 rectangle of signed floating-point RGB texel data. </summary>
    VK_FORMAT_BC6H_SFLOAT_BLOCK = 144,

    /// <summary> VK_FORMAT_BC7_UNORM_BLOCK specifies a four-component, block-compressed format where each 128-bit compressed texel block encodes a 4×4 rectangle of unsigned normalized RGBA texel data. </summary>
    VK_FORMAT_BC7_UNORM_BLOCK = 145,

    /// <summary> VK_FORMAT_BC7_SRGB_BLOCK specifies a four-component, block-compressed format where each 128-bit compressed texel block encodes a 4×4 rectangle of unsigned normalized RGBA texel data with sRGB nonlinear encoding applied to the RGB components. </summary>
    VK_FORMAT_BC7_SRGB_BLOCK = 146,

    /// <summary> VK_FORMAT_ETC2_R8G8B8_UNORM_BLOCK specifies a three-component, ETC2 compressed format where each 64-bit compressed texel block encodes a 4×4 rectangle of unsigned normalized RGB texel data. This format has no alpha and is considered opaque. </summary>
    VK_FORMAT_ETC2_R8G8B8_UNORM_BLOCK = 147,

    /// <summary> VK_FORMAT_ETC2_R8G8B8_SRGB_BLOCK specifies a three-component, ETC2 compressed format where each 64-bit compressed texel block encodes a 4×4 rectangle of unsigned normalized RGB texel data with sRGB nonlinear encoding. This format has no alpha and is considered opaque. </summary>
    VK_FORMAT_ETC2_R8G8B8_SRGB_BLOCK = 148,

    /// <summary> VK_FORMAT_ETC2_R8G8B8A1_UNORM_BLOCK specifies a four-component, ETC2 compressed format where each 64-bit compressed texel block encodes a 4×4 rectangle of unsigned normalized RGB texel data, and provides 1 bit of alpha. </summary>
    VK_FORMAT_ETC2_R8G8B8A1_UNORM_BLOCK = 149,

    /// <summary> VK_FORMAT_ETC2_R8G8B8A1_SRGB_BLOCK specifies a four-component, ETC2 compressed format where each 64-bit compressed texel block encodes a 4×4 rectangle of unsigned normalized RGB texel data with sRGB nonlinear encoding, and provides 1 bit of alpha. </summary>
    VK_FORMAT_ETC2_R8G8B8A1_SRGB_BLOCK = 150,

    /// <summary> VK_FORMAT_ETC2_R8G8B8A8_UNORM_BLOCK specifies a four-component, ETC2 compressed format where each 128-bit compressed texel block encodes a 4×4 rectangle of unsigned normalized RGBA texel data with the first 64 bits encoding alpha values followed by 64 bits encoding RGB values. </summary>
    VK_FORMAT_ETC2_R8G8B8A8_UNORM_BLOCK = 151,

    /// <summary> VK_FORMAT_ETC2_R8G8B8A8_SRGB_BLOCK specifies a four-component, ETC2 compressed format where each 128-bit compressed texel block encodes a 4×4 rectangle of unsigned normalized RGBA texel data with the first 64 bits encoding alpha values followed by 64 bits encoding RGB values with sRGB nonlinear encoding applied. </summary>
    VK_FORMAT_ETC2_R8G8B8A8_SRGB_BLOCK = 152,

    /// <summary> VK_FORMAT_EAC_R11_UNORM_BLOCK specifies a one-component, ETC2 compressed format where each 64-bit compressed texel block encodes a 4×4 rectangle of unsigned normalized red texel data. </summary>
    VK_FORMAT_EAC_R11_UNORM_BLOCK = 153,

    /// <summary> VK_FORMAT_EAC_R11_SNORM_BLOCK specifies a one-component, ETC2 compressed format where each 64-bit compressed texel block encodes a 4×4 rectangle of signed normalized red texel data. </summary>
    VK_FORMAT_EAC_R11_SNORM_BLOCK = 154,

    /// <summary> VK_FORMAT_EAC_R11G11_UNORM_BLOCK specifies a two-component, ETC2 compressed format where each 128-bit compressed texel block encodes a 4×4 rectangle of unsigned normalized RG texel data with the first 64 bits encoding red values followed by 64 bits encoding green values. </summary>
    VK_FORMAT_EAC_R11G11_UNORM_BLOCK = 155,

    /// <summary> VK_FORMAT_EAC_R11G11_SNORM_BLOCK specifies a two-component, ETC2 compressed format where each 128-bit compressed texel block encodes a 4×4 rectangle of signed normalized RG texel data with the first 64 bits encoding red values followed by 64 bits encoding green values. </summary>
    VK_FORMAT_EAC_R11G11_SNORM_BLOCK = 156,

    /// <summary> VK_FORMAT_ASTC_4x4_UNORM_BLOCK specifies a four-component, ASTC compressed format where each 128-bit compressed texel block encodes a 4×4 rectangle of unsigned normalized RGBA texel data. </summary>
    VK_FORMAT_ASTC_4x4_UNORM_BLOCK = 157,

    /// <summary> VK_FORMAT_ASTC_4x4_SRGB_BLOCK specifies a four-component, ASTC compressed format where each 128-bit compressed texel block encodes a 4×4 rectangle of unsigned normalized RGBA texel data with sRGB nonlinear encoding applied to the RGB components. </summary>
    VK_FORMAT_ASTC_4x4_SRGB_BLOCK = 158,

    /// <summary> VK_FORMAT_ASTC_5x4_UNORM_BLOCK specifies a four-component, ASTC compressed format where each 128-bit compressed texel block encodes a 5×4 rectangle of unsigned normalized RGBA texel data. </summary>
    VK_FORMAT_ASTC_5x4_UNORM_BLOCK = 159,

    /// <summary> VK_FORMAT_ASTC_5x4_SRGB_BLOCK specifies a four-component, ASTC compressed format where each 128-bit compressed texel block encodes a 5×4 rectangle of unsigned normalized RGBA texel data with sRGB nonlinear encoding applied to the RGB components. </summary>
    VK_FORMAT_ASTC_5x4_SRGB_BLOCK = 160,

    /// <summary> VK_FORMAT_ASTC_5x5_UNORM_BLOCK specifies a four-component, ASTC compressed format where each 128-bit compressed texel block encodes a 5×5 rectangle of unsigned normalized RGBA texel data. </summary>
    VK_FORMAT_ASTC_5x5_UNORM_BLOCK = 161,

    /// <summary> VK_FORMAT_ASTC_5x5_SRGB_BLOCK specifies a four-component, ASTC compressed format where each 128-bit compressed texel block encodes a 5×5 rectangle of unsigned normalized RGBA texel data with sRGB nonlinear encoding applied to the RGB components. </summary>
    VK_FORMAT_ASTC_5x5_SRGB_BLOCK = 162,

    /// <summary> VK_FORMAT_ASTC_6x5_UNORM_BLOCK specifies a four-component, ASTC compressed format where each 128-bit compressed texel block encodes a 6×5 rectangle of unsigned normalized RGBA texel data. </summary>
    VK_FORMAT_ASTC_6x5_UNORM_BLOCK = 163,

    /// <summary> VK_FORMAT_ASTC_6x5_SRGB_BLOCK specifies a four-component, ASTC compressed format where each 128-bit compressed texel block encodes a 6×5 rectangle of unsigned normalized RGBA texel data with sRGB nonlinear encoding applied to the RGB components. </summary>
    VK_FORMAT_ASTC_6x5_SRGB_BLOCK = 164,

    /// <summary> VK_FORMAT_ASTC_6x6_UNORM_BLOCK specifies a four-component, ASTC compressed format where each 128-bit compressed texel block encodes a 6×6 rectangle of unsigned normalized RGBA texel data. </summary>
    VK_FORMAT_ASTC_6x6_UNORM_BLOCK = 165,

    /// <summary> VK_FORMAT_ASTC_6x6_SRGB_BLOCK specifies a four-component, ASTC compressed format where each 128-bit compressed texel block encodes a 6×6 rectangle of unsigned normalized RGBA texel data with sRGB nonlinear encoding applied to the RGB components. </summary>
    VK_FORMAT_ASTC_6x6_SRGB_BLOCK = 166,

    /// <summary> VK_FORMAT_ASTC_8x5_UNORM_BLOCK specifies a four-component, ASTC compressed format where each 128-bit compressed texel block encodes an 8×5 rectangle of unsigned normalized RGBA texel data. </summary>
    VK_FORMAT_ASTC_8x5_UNORM_BLOCK = 167,

    /// <summary> VK_FORMAT_ASTC_8x5_SRGB_BLOCK specifies a four-component, ASTC compressed format where each 128-bit compressed texel block encodes an 8×5 rectangle of unsigned normalized RGBA texel data with sRGB nonlinear encoding applied to the RGB components. </summary>
    VK_FORMAT_ASTC_8x5_SRGB_BLOCK = 168,

    /// <summary> VK_FORMAT_ASTC_8x6_UNORM_BLOCK specifies a four-component, ASTC compressed format where each 128-bit compressed texel block encodes an 8×6 rectangle of unsigned normalized RGBA texel data. </summary>
    VK_FORMAT_ASTC_8x6_UNORM_BLOCK = 169,

    /// <summary> VK_FORMAT_ASTC_8x6_SRGB_BLOCK specifies a four-component, ASTC compressed format where each 128-bit compressed texel block encodes an 8×6 rectangle of unsigned normalized RGBA texel data with sRGB nonlinear encoding applied to the RGB components. </summary>
    VK_FORMAT_ASTC_8x6_SRGB_BLOCK = 170,

    /// <summary> VK_FORMAT_ASTC_8x8_UNORM_BLOCK specifies a four-component, ASTC compressed format where each 128-bit compressed texel block encodes an 8×8 rectangle of unsigned normalized RGBA texel data. </summary>
    VK_FORMAT_ASTC_8x8_UNORM_BLOCK = 171,

    /// <summary> VK_FORMAT_ASTC_8x8_SRGB_BLOCK specifies a four-component, ASTC compressed format where each 128-bit compressed texel block encodes an 8×8 rectangle of unsigned normalized RGBA texel data with sRGB nonlinear encoding applied to the RGB components. </summary>
    VK_FORMAT_ASTC_8x8_SRGB_BLOCK = 172,

    /// <summary> VK_FORMAT_ASTC_10x5_UNORM_BLOCK specifies a four-component, ASTC compressed format where each 128-bit compressed texel block encodes a 10×5 rectangle of unsigned normalized RGBA texel data. </summary>
    VK_FORMAT_ASTC_10x5_UNORM_BLOCK = 173,

    /// <summary> VK_FORMAT_ASTC_10x5_SRGB_BLOCK specifies a four-component, ASTC compressed format where each 128-bit compressed texel block encodes a 10×5 rectangle of unsigned normalized RGBA texel data with sRGB nonlinear encoding applied to the RGB components. </summary>
    VK_FORMAT_ASTC_10x5_SRGB_BLOCK = 174,

    /// <summary> VK_FORMAT_ASTC_10x6_UNORM_BLOCK specifies a four-component, ASTC compressed format where each 128-bit compressed texel block encodes a 10×6 rectangle of unsigned normalized RGBA texel data. </summary>
    VK_FORMAT_ASTC_10x6_UNORM_BLOCK = 175,

    /// <summary> VK_FORMAT_ASTC_10x6_SRGB_BLOCK specifies a four-component, ASTC compressed format where each 128-bit compressed texel block encodes a 10×6 rectangle of unsigned normalized RGBA texel data with sRGB nonlinear encoding applied to the RGB components. </summary>
    VK_FORMAT_ASTC_10x6_SRGB_BLOCK = 176,

    /// <summary> VK_FORMAT_ASTC_10x8_UNORM_BLOCK specifies a four-component, ASTC compressed format where each 128-bit compressed texel block encodes a 10×8 rectangle of unsigned normalized RGBA texel data. </summary>
    VK_FORMAT_ASTC_10x8_UNORM_BLOCK = 177,

    /// <summary> VK_FORMAT_ASTC_10x8_SRGB_BLOCK specifies a four-component, ASTC compressed format where each 128-bit compressed texel block encodes a 10×8 rectangle of unsigned normalized RGBA texel data with sRGB nonlinear encoding applied to the RGB components. </summary>
    VK_FORMAT_ASTC_10x8_SRGB_BLOCK = 178,

    /// <summary> VK_FORMAT_ASTC_10x10_UNORM_BLOCK specifies a four-component, ASTC compressed format where each 128-bit compressed texel block encodes a 10×10 rectangle of unsigned normalized RGBA texel data. </summary>
    VK_FORMAT_ASTC_10x10_UNORM_BLOCK = 179,

    /// <summary> VK_FORMAT_ASTC_10x10_SRGB_BLOCK specifies a four-component, ASTC compressed format where each 128-bit compressed texel block encodes a 10×10 rectangle of unsigned normalized RGBA texel data with sRGB nonlinear encoding applied to the RGB components. </summary>
    VK_FORMAT_ASTC_10x10_SRGB_BLOCK = 180,

    /// <summary> VK_FORMAT_ASTC_12x10_UNORM_BLOCK specifies a four-component, ASTC compressed format where each 128-bit compressed texel block encodes a 12×10 rectangle of unsigned normalized RGBA texel data. </summary>
    VK_FORMAT_ASTC_12x10_UNORM_BLOCK = 181,

    /// <summary> VK_FORMAT_ASTC_12x10_SRGB_BLOCK specifies a four-component, ASTC compressed format where each 128-bit compressed texel block encodes a 12×10 rectangle of unsigned normalized RGBA texel data with sRGB nonlinear encoding applied to the RGB components. </summary>
    VK_FORMAT_ASTC_12x10_SRGB_BLOCK = 182,

    /// <summary> VK_FORMAT_ASTC_12x12_UNORM_BLOCK specifies a four-component, ASTC compressed format where each 128-bit compressed texel block encodes a 12×12 rectangle of unsigned normalized RGBA texel data. </summary>
    VK_FORMAT_ASTC_12x12_UNORM_BLOCK = 183,

    /// <summary> VK_FORMAT_ASTC_12x12_SRGB_BLOCK specifies a four-component, ASTC compressed format where each 128-bit compressed texel block encodes a 12×12 rectangle of unsigned normalized RGBA texel data with sRGB nonlinear encoding applied to the RGB components. </summary>
    VK_FORMAT_ASTC_12x12_SRGB_BLOCK = 184,

    /// <summary> VK_FORMAT_G8B8G8R8_422_UNORM specifies a four-component, 32-bit format containing a pair of G components, an R component, and a B component, collectively encoding a 2×1 rectangle of unsigned normalized RGB texel data. One G value is present at each i coordinate, with the B and R values shared across both G values and thus recorded at half the horizontal resolution of the image. This format has an 8-bit G component for the even i coordinate in byte 0, an 8-bit B component in byte 1, an 8-bit G component for the odd icoordinate in byte 2, and an 8-bit R component in byte 3. This format only supports images with a width that is a multiple of two. For the purposes of the constraints on copy extents, this format is treated as a compressed format with a 2×1 compressed texel block. </summary>
    VK_FORMAT_G8B8G8R8_422_UNORM = 1000156000,

    /// <summary> VK_FORMAT_B8G8R8G8_422_UNORM specifies a four-component, 32-bit format containing a pair of G components, an R component, and a B component, collectively encoding a 2×1 rectangle of unsigned normalized RGB texel data. One G value is present at each i coordinate, with the B and R values shared across both G values and thus recorded at half the horizontal resolution of the image. This format has an 8-bit B component in byte 0, an 8-bit G component for the even i coordinate in byte 1, an 8-bit R component in byte 2, and an 8-bit G component for the odd i coordinate in byte 3. This format only supports images with a width that is a multiple of two. For the purposes of the constraints on copy extents, this format is treated as a compressed format with a 2×1 compressed texel block. </summary>
    VK_FORMAT_B8G8R8G8_422_UNORM = 1000156001,

    /// <summary>
    ///     VK_FORMAT_G8_B8_R8_3PLANE_420_UNORM specifies an unsigned normalized multi-planar format that has an 8-bit G component in plane 0, an 8-bit B component in plane 1, and an 8-bit R component in plane 2. The horizontal and vertical dimensions of the R and B planes are halved relative to the image dimensions, and each R and B component is shared with the G components for which ⌊iG​×0.5⌋=iB​=iR​ and ⌊jG​×0.5⌋=jB​=jR​. The location of each plane when this image is in linear layout can be determined via
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkGetImageSubresourceLayout.html"> vkGetImageSubresourceLayout </a>
    ///     , using VK_IMAGE_ASPECT_PLANE_0_BIT for the G plane, VK_IMAGE_ASPECT_PLANE_1_BIT for the B plane, and VK_IMAGE_ASPECT_PLANE_2_BIT for the R plane. This format only supports images with a width and height that is a multiple of two.
    /// </summary>
    VK_FORMAT_G8_B8_R8_3PLANE_420_UNORM = 1000156002,

    /// <summary>
    ///     VK_FORMAT_G8_B8R8_2PLANE_420_UNORM specifies an unsigned normalized multi-planar format that has an 8-bit G component in plane 0, and a two-component, 16-bit BR plane 1 consisting of an 8-bit B component in byte 0 and an 8-bit R component in byte 1. The horizontal and vertical dimensions of the BR plane are halved relative to the image dimensions, and each R and B value is shared with the G components for which ⌊iG​×0.5⌋=iB​=iR​ and ⌊jG​×0.5⌋=jB​=jR​. The location of each plane when this image is in linear layout can be determined via
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkGetImageSubresourceLayout.html"> vkGetImageSubresourceLayout </a>
    ///     , using VK_IMAGE_ASPECT_PLANE_0_BIT for the G plane, and VK_IMAGE_ASPECT_PLANE_1_BIT for the BR plane. This format only supports images with a width and height that is a multiple of two.
    /// </summary>
    VK_FORMAT_G8_B8R8_2PLANE_420_UNORM = 1000156003,

    /// <summary>
    ///     VK_FORMAT_G8_B8_R8_3PLANE_422_UNORM specifies an unsigned normalized multi-planar format that has an 8-bit G component in plane 0, an 8-bit B component in plane 1, and an 8-bit R component in plane 2. The horizontal dimension of the R and B plane is halved relative to the image dimensions, and each R and B value is shared with the G components for which ⌊iG​×0.5⌋=iB​=iR​. The location of each plane when this image is in linear layout can be determined via
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkGetImageSubresourceLayout.html"> vkGetImageSubresourceLayout </a>
    ///     , using VK_IMAGE_ASPECT_PLANE_0_BIT for the G plane, VK_IMAGE_ASPECT_PLANE_1_BIT for the B plane, and VK_IMAGE_ASPECT_PLANE_2_BIT for the R plane. This format only supports images with a width that is a multiple of two.
    /// </summary>
    VK_FORMAT_G8_B8_R8_3PLANE_422_UNORM = 1000156004,

    /// <summary>
    ///     VK_FORMAT_G8_B8R8_2PLANE_422_UNORM specifies an unsigned normalized multi-planar format that has an 8-bit G component in plane 0, and a two-component, 16-bit BR plane 1 consisting of an 8-bit B component in byte 0 and an 8-bit R component in byte 1. The horizontal dimension of the BR plane is halved relative to the image dimensions, and each R and B value is shared with the G components for which ⌊iG​×0.5⌋=iB​=iR​. The location of each plane when this image is in linear layout can be determined via
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkGetImageSubresourceLayout.html"> vkGetImageSubresourceLayout </a>
    ///     , using VK_IMAGE_ASPECT_PLANE_0_BIT for the G plane, and VK_IMAGE_ASPECT_PLANE_1_BIT for the BR plane. This format only supports images with a width that is a multiple of two.
    /// </summary>
    VK_FORMAT_G8_B8R8_2PLANE_422_UNORM = 1000156005,

    /// <summary>
    ///     VK_FORMAT_G8_B8_R8_3PLANE_444_UNORM specifies an unsigned normalized multi-planar format that has an 8-bit G component in plane 0, an 8-bit B component in plane 1, and an 8-bit R component in plane 2. Each plane has the same dimensions and each R, G and B component contributes to a single texel. The location of each plane when this image is in linear layout can be determined via
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkGetImageSubresourceLayout.html"> vkGetImageSubresourceLayout </a>
    ///     , using VK_IMAGE_ASPECT_PLANE_0_BIT for the G plane, VK_IMAGE_ASPECT_PLANE_1_BIT for the B plane, and VK_IMAGE_ASPECT_PLANE_2_BIT for the R plane.
    /// </summary>
    VK_FORMAT_G8_B8_R8_3PLANE_444_UNORM = 1000156006,

    /// <summary> VK_FORMAT_R10X6_UNORM_PACK16 specifies a one-component, 16-bit unsigned normalized format that has a single 10-bit R component in the top 10 bits of a 16-bit word, with the bottom 6 bits unused. </summary>
    VK_FORMAT_R10X6_UNORM_PACK16 = 1000156007,

    /// <summary> VK_FORMAT_R10X6G10X6_UNORM_2PACK16 specifies a two-component, 32-bit unsigned normalized format that has a 10-bit R component in the top 10 bits of the word in bytes 0..1, and a 10-bit G component in the top 10 bits of the word in bytes 2..3, with the bottom 6 bits of each word unused. </summary>
    VK_FORMAT_R10X6G10X6_UNORM_2PACK16 = 1000156008,

    /// <summary> VK_FORMAT_R10X6G10X6B10X6A10X6_UNORM_4PACK16 specifies a four-component, 64-bit unsigned normalized format that has a 10-bit R component in the top 10 bits of the word in bytes 0..1, a 10-bit G component in the top 10 bits of the word in bytes 2..3, a 10-bit B component in the top 10 bits of the word in bytes 4..5, and a 10-bit A component in the top 10 bits of the word in bytes 6..7, with the bottom 6 bits of each word unused. </summary>
    VK_FORMAT_R10X6G10X6B10X6A10X6_UNORM_4PACK16 = 1000156009,

    /// <summary> VK_FORMAT_G10X6B10X6G10X6R10X6_422_UNORM_4PACK16 specifies a four-component, 64-bit format containing a pair of G components, an R component, and a B component, collectively encoding a 2×1 rectangle of unsigned normalized RGB texel data. One G value is present at each i coordinate, with the B and R values shared across both G values and thus recorded at half the horizontal resolution of the image. This format has a 10-bit G component for the even i coordinate in the top 10 bits of the word in bytes 0..1, a 10-bit B component in the top 10 bits of the word in bytes 2..3, a 10-bit G component for the odd icoordinate in the top 10 bits of the word in bytes 4..5, and a 10-bit R component in the top 10 bits of the word in bytes 6..7, with the bottom 6 bits of each word unused. This format only supports images with a width that is a multiple of two. For the purposes of the constraints on copy extents, this format is treated as a compressed format with a 2×1 compressed texel block. </summary>
    VK_FORMAT_G10X6B10X6G10X6R10X6_422_UNORM_4PACK16 = 1000156010,

    /// <summary> VK_FORMAT_B10X6G10X6R10X6G10X6_422_UNORM_4PACK16 specifies a four-component, 64-bit format containing a pair of G components, an R component, and a B component, collectively encoding a 2×1 rectangle of unsigned normalized RGB texel data. One G value is present at each i coordinate, with the B and R values shared across both G values and thus recorded at half the horizontal resolution of the image. This format has a 10-bit B component in the top 10 bits of the word in bytes 0..1, a 10-bit G component for the even i coordinate in the top 10 bits of the word in bytes 2..3, a 10-bit R component in the top 10 bits of the word in bytes 4..5, and a 10-bit G component for the odd icoordinate in the top 10 bits of the word in bytes 6..7, with the bottom 6 bits of each word unused. This format only supports images with a width that is a multiple of two. For the purposes of the constraints on copy extents, this format is treated as a compressed format with a 2×1 compressed texel block. </summary>
    VK_FORMAT_B10X6G10X6R10X6G10X6_422_UNORM_4PACK16 = 1000156011,

    /// <summary>
    ///     VK_FORMAT_G10X6_B10X6_R10X6_3PLANE_420_UNORM_3PACK16 specifies an unsigned normalized multi-planar format that has a 10-bit G component in the top 10 bits of each 16-bit word of plane 0, a 10-bit B component in the top 10 bits of each 16-bit word of plane 1, and a 10-bit R component in the top 10 bits of each 16-bit word of plane 2, with the bottom 6 bits of each word unused. The horizontal and vertical dimensions of the R and B planes are halved relative to the image dimensions, and each R and B component is shared with the G components for which ⌊iG​×0.5⌋=iB​=iR​ and ⌊jG​×0.5⌋=jB​=jR​. The location of each plane when this image is in linear layout can be determined via
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkGetImageSubresourceLayout.html"> vkGetImageSubresourceLayout </a>
    ///     , using VK_IMAGE_ASPECT_PLANE_0_BIT for the G plane, VK_IMAGE_ASPECT_PLANE_1_BIT for the B plane, and VK_IMAGE_ASPECT_PLANE_2_BIT for the R plane. This format only supports images with a width and height that is a multiple of two.
    /// </summary>
    VK_FORMAT_G10X6_B10X6_R10X6_3PLANE_420_UNORM_3PACK16 = 1000156012,

    /// <summary>
    ///     VK_FORMAT_G10X6_B10X6R10X6_2PLANE_420_UNORM_3PACK16 specifies an unsigned normalized multi-planar format that has a 10-bit G component in the top 10 bits of each 16-bit word of plane 0, and a two-component, 32-bit BR plane 1 consisting of a 10-bit B component in the top 10 bits of the word in bytes 0..1, and a 10-bit R component in the top 10 bits of the word in bytes 2..3, with the bottom 6 bits of each word unused. The horizontal and vertical dimensions of the BR plane are halved relative to the image dimensions, and each R and B value is shared with the G components for which ⌊iG​×0.5⌋=iB​=iR​ and ⌊jG​×0.5⌋=jB​=jR​. The location of each plane when this image is in linear layout can be determined via
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkGetImageSubresourceLayout.html"> vkGetImageSubresourceLayout </a>
    ///     , using VK_IMAGE_ASPECT_PLANE_0_BIT for the G plane, and VK_IMAGE_ASPECT_PLANE_1_BIT for the BR plane. This format only supports images with a width and height that is a multiple of two.
    /// </summary>
    VK_FORMAT_G10X6_B10X6R10X6_2PLANE_420_UNORM_3PACK16 = 1000156013,

    /// <summary>
    ///     VK_FORMAT_G10X6_B10X6_R10X6_3PLANE_422_UNORM_3PACK16 specifies an unsigned normalized multi-planar format that has a 10-bit G component in the top 10 bits of each 16-bit word of plane 0, a 10-bit B component in the top 10 bits of each 16-bit word of plane 1, and a 10-bit R component in the top 10 bits of each 16-bit word of plane 2, with the bottom 6 bits of each word unused. The horizontal dimension of the R and B plane is halved relative to the image dimensions, and each R and B value is shared with the G components for which ⌊iG​×0.5⌋=iB​=iR​. The location of each plane when this image is in linear layout can be determined via
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkGetImageSubresourceLayout.html"> vkGetImageSubresourceLayout </a>
    ///     , using VK_IMAGE_ASPECT_PLANE_0_BIT for the G plane, VK_IMAGE_ASPECT_PLANE_1_BIT for the B plane, and VK_IMAGE_ASPECT_PLANE_2_BIT for the R plane. This format only supports images with a width that is a multiple of two.
    /// </summary>
    VK_FORMAT_G10X6_B10X6_R10X6_3PLANE_422_UNORM_3PACK16 = 1000156014,

    /// <summary>
    ///     VK_FORMAT_G10X6_B10X6R10X6_2PLANE_422_UNORM_3PACK16 specifies an unsigned normalized multi-planar format that has a 10-bit G component in the top 10 bits of each 16-bit word of plane 0, and a two-component, 32-bit BR plane 1 consisting of a 10-bit B component in the top 10 bits of the word in bytes 0..1, and a 10-bit R component in the top 10 bits of the word in bytes 2..3, with the bottom 6 bits of each word unused. The horizontal dimension of the BR plane is halved relative to the image dimensions, and each R and B value is shared with the G components for which ⌊iG​×0.5⌋=iB​=iR​. The location of each plane when this image is in linear layout can be determined via
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkGetImageSubresourceLayout.html"> vkGetImageSubresourceLayout </a>
    ///     , using VK_IMAGE_ASPECT_PLANE_0_BIT for the G plane, and VK_IMAGE_ASPECT_PLANE_1_BIT for the BR plane. This format only supports images with a width that is a multiple of two.
    /// </summary>
    VK_FORMAT_G10X6_B10X6R10X6_2PLANE_422_UNORM_3PACK16 = 1000156015,

    /// <summary>
    ///     VK_FORMAT_G10X6_B10X6_R10X6_3PLANE_444_UNORM_3PACK16 specifies an unsigned normalized multi-planar format that has a 10-bit G component in the top 10 bits of each 16-bit word of plane 0, a 10-bit B component in the top 10 bits of each 16-bit word of plane 1, and a 10-bit R component in the top 10 bits of each 16-bit word of plane 2, with the bottom 6 bits of each word unused. Each plane has the same dimensions and each R, G and B component contributes to a single texel. The location of each plane when this image is in linear layout can be determined via
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkGetImageSubresourceLayout.html"> vkGetImageSubresourceLayout </a>
    ///     , using VK_IMAGE_ASPECT_PLANE_0_BIT for the G plane, VK_IMAGE_ASPECT_PLANE_1_BIT for the B plane, and VK_IMAGE_ASPECT_PLANE_2_BIT for the R plane.
    /// </summary>
    VK_FORMAT_G10X6_B10X6_R10X6_3PLANE_444_UNORM_3PACK16 = 1000156016,

    /// <summary> VK_FORMAT_R12X4_UNORM_PACK16 specifies a one-component, 16-bit unsigned normalized format that has a single 12-bit R component in the top 12 bits of a 16-bit word, with the bottom 4 bits unused. </summary>
    VK_FORMAT_R12X4_UNORM_PACK16 = 1000156017,

    /// <summary> VK_FORMAT_R12X4G12X4_UNORM_2PACK16 specifies a two-component, 32-bit unsigned normalized format that has a 12-bit R component in the top 12 bits of the word in bytes 0..1, and a 12-bit G component in the top 12 bits of the word in bytes 2..3, with the bottom 4 bits of each word unused. </summary>
    VK_FORMAT_R12X4G12X4_UNORM_2PACK16 = 1000156018,

    /// <summary> VK_FORMAT_R12X4G12X4B12X4A12X4_UNORM_4PACK16 specifies a four-component, 64-bit unsigned normalized format that has a 12-bit R component in the top 12 bits of the word in bytes 0..1, a 12-bit G component in the top 12 bits of the word in bytes 2..3, a 12-bit B component in the top 12 bits of the word in bytes 4..5, and a 12-bit A component in the top 12 bits of the word in bytes 6..7, with the bottom 4 bits of each word unused. </summary>
    VK_FORMAT_R12X4G12X4B12X4A12X4_UNORM_4PACK16 = 1000156019,

    /// <summary> VK_FORMAT_G12X4B12X4G12X4R12X4_422_UNORM_4PACK16 specifies a four-component, 64-bit format containing a pair of G components, an R component, and a B component, collectively encoding a 2×1 rectangle of unsigned normalized RGB texel data. One G value is present at each i coordinate, with the B and R values shared across both G values and thus recorded at half the horizontal resolution of the image. This format has a 12-bit G component for the even i coordinate in the top 12 bits of the word in bytes 0..1, a 12-bit B component in the top 12 bits of the word in bytes 2..3, a 12-bit G component for the odd icoordinate in the top 12 bits of the word in bytes 4..5, and a 12-bit R component in the top 12 bits of the word in bytes 6..7, with the bottom 4 bits of each word unused. This format only supports images with a width that is a multiple of two. For the purposes of the constraints on copy extents, this format is treated as a compressed format with a 2×1 compressed texel block. </summary>
    VK_FORMAT_G12X4B12X4G12X4R12X4_422_UNORM_4PACK16 = 1000156020,

    /// <summary> VK_FORMAT_B12X4G12X4R12X4G12X4_422_UNORM_4PACK16 specifies a four-component, 64-bit format containing a pair of G components, an R component, and a B component, collectively encoding a 2×1 rectangle of unsigned normalized RGB texel data. One G value is present at each i coordinate, with the B and R values shared across both G values and thus recorded at half the horizontal resolution of the image. This format has a 12-bit B component in the top 12 bits of the word in bytes 0..1, a 12-bit G component for the even i coordinate in the top 12 bits of the word in bytes 2..3, a 12-bit R component in the top 12 bits of the word in bytes 4..5, and a 12-bit G component for the odd icoordinate in the top 12 bits of the word in bytes 6..7, with the bottom 4 bits of each word unused. This format only supports images with a width that is a multiple of two. For the purposes of the constraints on copy extents, this format is treated as a compressed format with a 2×1 compressed texel block. </summary>
    VK_FORMAT_B12X4G12X4R12X4G12X4_422_UNORM_4PACK16 = 1000156021,

    /// <summary>
    ///     VK_FORMAT_G12X4_B12X4_R12X4_3PLANE_420_UNORM_3PACK16 specifies an unsigned normalized multi-planar format that has a 12-bit G component in the top 12 bits of each 16-bit word of plane 0, a 12-bit B component in the top 12 bits of each 16-bit word of plane 1, and a 12-bit R component in the top 12 bits of each 16-bit word of plane 2, with the bottom 4 bits of each word unused. The horizontal and vertical dimensions of the R and B planes are halved relative to the image dimensions, and each R and B component is shared with the G components for which ⌊iG​×0.5⌋=iB​=iR​ and ⌊jG​×0.5⌋=jB​=jR​. The location of each plane when this image is in linear layout can be determined via
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkGetImageSubresourceLayout.html"> vkGetImageSubresourceLayout </a>
    ///     , using VK_IMAGE_ASPECT_PLANE_0_BIT for the G plane, VK_IMAGE_ASPECT_PLANE_1_BIT for the B plane, and VK_IMAGE_ASPECT_PLANE_2_BIT for the R plane. This format only supports images with a width and height that is a multiple of two.
    /// </summary>
    VK_FORMAT_G12X4_B12X4_R12X4_3PLANE_420_UNORM_3PACK16 = 1000156022,

    /// <summary>
    ///     VK_FORMAT_G12X4_B12X4R12X4_2PLANE_420_UNORM_3PACK16 specifies an unsigned normalized multi-planar format that has a 12-bit G component in the top 12 bits of each 16-bit word of plane 0, and a two-component, 32-bit BR plane 1 consisting of a 12-bit B component in the top 12 bits of the word in bytes 0..1, and a 12-bit R component in the top 12 bits of the word in bytes 2..3, with the bottom 4 bits of each word unused. The horizontal and vertical dimensions of the BR plane are halved relative to the image dimensions, and each R and B value is shared with the G components for which ⌊iG​×0.5⌋=iB​=iR​ and ⌊jG​×0.5⌋=jB​=jR​. The location of each plane when this image is in linear layout can be determined via
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkGetImageSubresourceLayout.html"> vkGetImageSubresourceLayout </a>
    ///     , using VK_IMAGE_ASPECT_PLANE_0_BIT for the G plane, and VK_IMAGE_ASPECT_PLANE_1_BIT for the BR plane. This format only supports images with a width and height that is a multiple of two.
    /// </summary>
    VK_FORMAT_G12X4_B12X4R12X4_2PLANE_420_UNORM_3PACK16 = 1000156023,

    /// <summary>
    ///     VK_FORMAT_G12X4_B12X4_R12X4_3PLANE_422_UNORM_3PACK16 specifies an unsigned normalized multi-planar format that has a 12-bit G component in the top 12 bits of each 16-bit word of plane 0, a 12-bit B component in the top 12 bits of each 16-bit word of plane 1, and a 12-bit R component in the top 12 bits of each 16-bit word of plane 2, with the bottom 4 bits of each word unused. The horizontal dimension of the R and B plane is halved relative to the image dimensions, and each R and B value is shared with the G components for which ⌊iG​×0.5⌋=iB​=iR​. The location of each plane when this image is in linear layout can be determined via
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkGetImageSubresourceLayout.html"> vkGetImageSubresourceLayout </a>
    ///     , using VK_IMAGE_ASPECT_PLANE_0_BIT for the G plane, VK_IMAGE_ASPECT_PLANE_1_BIT for the B plane, and VK_IMAGE_ASPECT_PLANE_2_BIT for the R plane. This format only supports images with a width that is a multiple of two.
    /// </summary>
    VK_FORMAT_G12X4_B12X4_R12X4_3PLANE_422_UNORM_3PACK16 = 1000156024,

    /// <summary>
    ///     VK_FORMAT_G12X4_B12X4R12X4_2PLANE_422_UNORM_3PACK16 specifies an unsigned normalized multi-planar format that has a 12-bit G component in the top 12 bits of each 16-bit word of plane 0, and a two-component, 32-bit BR plane 1 consisting of a 12-bit B component in the top 12 bits of the word in bytes 0..1, and a 12-bit R component in the top 12 bits of the word in bytes 2..3, with the bottom 4 bits of each word unused. The horizontal dimension of the BR plane is halved relative to the image dimensions, and each R and B value is shared with the G components for which ⌊iG​×0.5⌋=iB​=iR​. The location of each plane when this image is in linear layout can be determined via
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkGetImageSubresourceLayout.html"> vkGetImageSubresourceLayout </a>
    ///     , using VK_IMAGE_ASPECT_PLANE_0_BIT for the G plane, and VK_IMAGE_ASPECT_PLANE_1_BIT for the BR plane. This format only supports images with a width that is a multiple of two.
    /// </summary>
    VK_FORMAT_G12X4_B12X4R12X4_2PLANE_422_UNORM_3PACK16 = 1000156025,

    /// <summary>
    ///     VK_FORMAT_G12X4_B12X4_R12X4_3PLANE_444_UNORM_3PACK16 specifies an unsigned normalized multi-planar format that has a 12-bit G component in the top 12 bits of each 16-bit word of plane 0, a 12-bit B component in the top 12 bits of each 16-bit word of plane 1, and a 12-bit R component in the top 12 bits of each 16-bit word of plane 2, with the bottom 4 bits of each word unused. Each plane has the same dimensions and each R, G and B component contributes to a single texel. The location of each plane when this image is in linear layout can be determined via
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkGetImageSubresourceLayout.html"> vkGetImageSubresourceLayout </a>
    ///     , using VK_IMAGE_ASPECT_PLANE_0_BIT for the G plane, VK_IMAGE_ASPECT_PLANE_1_BIT for the B plane, and VK_IMAGE_ASPECT_PLANE_2_BIT for the R plane.
    /// </summary>
    VK_FORMAT_G12X4_B12X4_R12X4_3PLANE_444_UNORM_3PACK16 = 1000156026,

    /// <summary> VK_FORMAT_G16B16G16R16_422_UNORM specifies a four-component, 64-bit format containing a pair of G components, an R component, and a B component, collectively encoding a 2×1 rectangle of unsigned normalized RGB texel data. One G value is present at each i coordinate, with the B and R values shared across both G values and thus recorded at half the horizontal resolution of the image. This format has a 16-bit G component for the even i coordinate in the word in bytes 0..1, a 16-bit B component in the word in bytes 2..3, a 16-bit G component for the odd i coordinate in the word in bytes 4..5, and a 16-bit R component in the word in bytes 6..7. This format only supports images with a width that is a multiple of two. For the purposes of the constraints on copy extents, this format is treated as a compressed format with a 2×1 compressed texel block. </summary>
    VK_FORMAT_G16B16G16R16_422_UNORM = 1000156027,

    /// <summary> VK_FORMAT_B16G16R16G16_422_UNORM specifies a four-component, 64-bit format containing a pair of G components, an R component, and a B component, collectively encoding a 2×1 rectangle of unsigned normalized RGB texel data. One G value is present at each i coordinate, with the B and R values shared across both G values and thus recorded at half the horizontal resolution of the image. This format has a 16-bit B component in the word in bytes 0..1, a 16-bit G component for the even i coordinate in the word in bytes 2..3, a 16-bit R component in the word in bytes 4..5, and a 16-bit G component for the odd i coordinate in the word in bytes 6..7. This format only supports images with a width that is a multiple of two. For the purposes of the constraints on copy extents, this format is treated as a compressed format with a 2×1 compressed texel block. </summary>
    VK_FORMAT_B16G16R16G16_422_UNORM = 1000156028,

    /// <summary>
    ///     VK_FORMAT_G16_B16_R16_3PLANE_420_UNORM specifies an unsigned normalized multi-planar format that has a 16-bit G component in each 16-bit word of plane 0, a 16-bit B component in each 16-bit word of plane 1, and a 16-bit R component in each 16-bit word of plane 2. The horizontal and vertical dimensions of the R and B planes are halved relative to the image dimensions, and each R and B component is shared with the G components for which ⌊iG​×0.5⌋=iB​=iR​ and ⌊jG​×0.5⌋=jB​=jR​. The location of each plane when this image is in linear layout can be determined via
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkGetImageSubresourceLayout.html"> vkGetImageSubresourceLayout </a>
    ///     , using VK_IMAGE_ASPECT_PLANE_0_BIT for the G plane, VK_IMAGE_ASPECT_PLANE_1_BIT for the B plane, and VK_IMAGE_ASPECT_PLANE_2_BIT for the R plane. This format only supports images with a width and height that is a multiple of two.
    /// </summary>
    VK_FORMAT_G16_B16_R16_3PLANE_420_UNORM = 1000156029,

    /// <summary>
    ///     VK_FORMAT_G16_B16R16_2PLANE_420_UNORM specifies an unsigned normalized multi-planar format that has a 16-bit G component in each 16-bit word of plane 0, and a two-component, 32-bit BR plane 1 consisting of a 16-bit B component in the word in bytes 0..1, and a 16-bit R component in the word in bytes 2..3. The horizontal and vertical dimensions of the BR plane are halved relative to the image dimensions, and each R and B value is shared with the G components for which ⌊iG​×0.5⌋=iB​=iR​ and ⌊jG​×0.5⌋=jB​=jR​. The location of each plane when this image is in linear layout can be determined via
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkGetImageSubresourceLayout.html"> vkGetImageSubresourceLayout </a>
    ///     , using VK_IMAGE_ASPECT_PLANE_0_BIT for the G plane, and VK_IMAGE_ASPECT_PLANE_1_BIT for the BR plane. This format only supports images with a width and height that is a multiple of two.
    /// </summary>
    VK_FORMAT_G16_B16R16_2PLANE_420_UNORM = 1000156030,

    /// <summary>
    ///     VK_FORMAT_G16_B16_R16_3PLANE_422_UNORM specifies an unsigned normalized multi-planar format that has a 16-bit G component in each 16-bit word of plane 0, a 16-bit B component in each 16-bit word of plane 1, and a 16-bit R component in each 16-bit word of plane 2. The horizontal dimension of the R and B plane is halved relative to the image dimensions, and each R and B value is shared with the G components for which ⌊iG​×0.5⌋=iB​=iR​. The location of each plane when this image is in linear layout can be determined via
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkGetImageSubresourceLayout.html"> vkGetImageSubresourceLayout </a>
    ///     , using VK_IMAGE_ASPECT_PLANE_0_BIT for the G plane, VK_IMAGE_ASPECT_PLANE_1_BIT for the B plane, and VK_IMAGE_ASPECT_PLANE_2_BIT for the R plane. This format only supports images with a width that is a multiple of two.
    /// </summary>
    VK_FORMAT_G16_B16_R16_3PLANE_422_UNORM = 1000156031,

    /// <summary>
    ///     VK_FORMAT_G16_B16R16_2PLANE_422_UNORM specifies an unsigned normalized multi-planar format that has a 16-bit G component in each 16-bit word of plane 0, and a two-component, 32-bit BR plane 1 consisting of a 16-bit B component in the word in bytes 0..1, and a 16-bit R component in the word in bytes 2..3. The horizontal dimension of the BR plane is halved relative to the image dimensions, and each R and B value is shared with the G components for which ⌊iG​×0.5⌋=iB​=iR​. The location of each plane when this image is in linear layout can be determined via
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkGetImageSubresourceLayout.html"> vkGetImageSubresourceLayout </a>
    ///     , using VK_IMAGE_ASPECT_PLANE_0_BIT for the G plane, and VK_IMAGE_ASPECT_PLANE_1_BIT for the BR plane. This format only supports images with a width that is a multiple of two.
    /// </summary>
    VK_FORMAT_G16_B16R16_2PLANE_422_UNORM = 1000156032,

    /// <summary>
    ///     VK_FORMAT_G16_B16_R16_3PLANE_444_UNORM specifies an unsigned normalized multi-planar format that has a 16-bit G component in each 16-bit word of plane 0, a 16-bit B component in each 16-bit word of plane 1, and a 16-bit R component in each 16-bit word of plane 2. Each plane has the same dimensions and each R, G and B component contributes to a single texel. The location of each plane when this image is in linear layout can be determined via
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkGetImageSubresourceLayout.html"> vkGetImageSubresourceLayout </a>
    ///     , using VK_IMAGE_ASPECT_PLANE_0_BIT for the G plane, VK_IMAGE_ASPECT_PLANE_1_BIT for the B plane, and VK_IMAGE_ASPECT_PLANE_2_BIT for the R plane.
    /// </summary>
    VK_FORMAT_G16_B16_R16_3PLANE_444_UNORM = 1000156033,

    /// <summary>
    ///     VK_FORMAT_G8_B8R8_2PLANE_444_UNORM specifies an unsigned normalized multi-planar format that has an 8-bit G component in plane 0, and a two-component, 16-bit BR plane 1 consisting of an 8-bit B component in byte 0 and an 8-bit R component in byte 1. Both planes have the same dimensions and each R, G and B component contributes to a single texel. The location of each plane when this image is in linear layout can be determined via
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkGetImageSubresourceLayout.html"> vkGetImageSubresourceLayout </a>
    ///     , using VK_IMAGE_ASPECT_PLANE_0_BIT for the G plane, and VK_IMAGE_ASPECT_PLANE_1_BIT for the BR plane.
    /// </summary>
    VK_FORMAT_G8_B8R8_2PLANE_444_UNORM = 1000330000,

    /// <summary>
    ///     VK_FORMAT_G10X6_B10X6R10X6_2PLANE_444_UNORM_3PACK16 specifies an unsigned normalized multi-planar format that has a 10-bit G component in the top 10 bits of each 16-bit word of plane 0, and a two-component, 32-bit BR plane 1 consisting of a 10-bit B component in the top 10 bits of the word in bytes 0..1, and a 10-bit R component in the top 10 bits of the word in bytes 2..3, the bottom 6 bits of each word unused. Both planes have the same dimensions and each R, G and B component contributes to a single texel. The location of each plane when this image is in linear layout can be determined via
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkGetImageSubresourceLayout.html"> vkGetImageSubresourceLayout </a>
    ///     , using VK_IMAGE_ASPECT_PLANE_0_BIT for the G plane, and VK_IMAGE_ASPECT_PLANE_1_BIT for the BR plane.
    /// </summary>
    VK_FORMAT_G10X6_B10X6R10X6_2PLANE_444_UNORM_3PACK16 = 1000330001,

    /// <summary>
    ///     VK_FORMAT_G12X4_B12X4R12X4_2PLANE_444_UNORM_3PACK16 specifies an unsigned normalized multi-planar format that has a 12-bit G component in the top 12 bits of each 16-bit word of plane 0, and a two-component, 32-bit BR plane 1 consisting of a 12-bit B component in the top 12 bits of the word in bytes 0..1, and a 12-bit R component in the top 12 bits of the word in bytes 2..3, the bottom 4 bits of each word unused. Both planes have the same dimensions and each R, G and B component contributes to a single texel. The location of each plane when this image is in linear layout can be determined via
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkGetImageSubresourceLayout.html"> vkGetImageSubresourceLayout </a>
    ///     , using VK_IMAGE_ASPECT_PLANE_0_BIT for the G plane, and VK_IMAGE_ASPECT_PLANE_1_BIT for the BR plane.
    /// </summary>
    VK_FORMAT_G12X4_B12X4R12X4_2PLANE_444_UNORM_3PACK16 = 1000330002,

    /// <summary>
    ///     VK_FORMAT_G16_B16R16_2PLANE_444_UNORM specifies an unsigned normalized multi-planar format that has a 16-bit G component in each 16-bit word of plane 0, and a two-component, 32-bit BR plane 1 consisting of a 16-bit B component in the word in bytes 0..1, and a 16-bit R component in the word in bytes 2..3. Both planes have the same dimensions and each R, G and B component contributes to a single texel. The location of each plane when this image is in linear layout can be determined via
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkGetImageSubresourceLayout.html"> vkGetImageSubresourceLayout </a>
    ///     , using VK_IMAGE_ASPECT_PLANE_0_BIT for the G plane, and VK_IMAGE_ASPECT_PLANE_1_BIT for the BR plane.
    /// </summary>
    VK_FORMAT_G16_B16R16_2PLANE_444_UNORM = 1000330003,

    /// <summary> VK_FORMAT_A4R4G4B4_UNORM_PACK16 specifies a four-component, 16-bit packed unsigned normalized format that has a 4-bit A component in bits 12..15, a 4-bit R component in bits 8..11, a 4-bit G component in bits 4..7, and a 4-bit B component in bits 0..3. </summary>
    VK_FORMAT_A4R4G4B4_UNORM_PACK16 = 1000340000,

    /// <summary> VK_FORMAT_A4B4G4R4_UNORM_PACK16 specifies a four-component, 16-bit packed unsigned normalized format that has a 4-bit A component in bits 12..15, a 4-bit B component in bits 8..11, a 4-bit G component in bits 4..7, and a 4-bit R component in bits 0..3. </summary>
    VK_FORMAT_A4B4G4R4_UNORM_PACK16 = 1000340001,

    /// <summary> VK_FORMAT_ASTC_4x4_SFLOAT_BLOCK specifies a four-component, ASTC compressed format where each 128-bit compressed texel block encodes a 4×4 rectangle of signed floating-point RGBA texel data. </summary>
    VK_FORMAT_ASTC_4x4_SFLOAT_BLOCK = 1000066000,

    /// <summary> VK_FORMAT_ASTC_5x4_SFLOAT_BLOCK specifies a four-component, ASTC compressed format where each 128-bit compressed texel block encodes a 5×4 rectangle of signed floating-point RGBA texel data. </summary>
    VK_FORMAT_ASTC_5x4_SFLOAT_BLOCK = 1000066001,

    /// <summary> VK_FORMAT_ASTC_5x5_SFLOAT_BLOCK specifies a four-component, ASTC compressed format where each 128-bit compressed texel block encodes a 5×5 rectangle of signed floating-point RGBA texel data. </summary>
    VK_FORMAT_ASTC_5x5_SFLOAT_BLOCK = 1000066002,

    /// <summary> VK_FORMAT_ASTC_6x5_SFLOAT_BLOCK specifies a four-component, ASTC compressed format where each 128-bit compressed texel block encodes a 6×5 rectangle of signed floating-point RGBA texel data. </summary>
    VK_FORMAT_ASTC_6x5_SFLOAT_BLOCK = 1000066003,

    /// <summary> VK_FORMAT_ASTC_6x6_SFLOAT_BLOCK specifies a four-component, ASTC compressed format where each 128-bit compressed texel block encodes a 6×6 rectangle of signed floating-point RGBA texel data. </summary>
    VK_FORMAT_ASTC_6x6_SFLOAT_BLOCK = 1000066004,

    /// <summary> VK_FORMAT_ASTC_8x5_SFLOAT_BLOCK specifies a four-component, ASTC compressed format where each 128-bit compressed texel block encodes a 8×5 rectangle of signed floating-point RGBA texel data. </summary>
    VK_FORMAT_ASTC_8x5_SFLOAT_BLOCK = 1000066005,

    /// <summary> VK_FORMAT_ASTC_8x6_SFLOAT_BLOCK specifies a four-component, ASTC compressed format where each 128-bit compressed texel block encodes a 8×6 rectangle of signed floating-point RGBA texel data. </summary>
    VK_FORMAT_ASTC_8x6_SFLOAT_BLOCK = 1000066006,

    /// <summary> VK_FORMAT_ASTC_8x8_SFLOAT_BLOCK specifies a four-component, ASTC compressed format where each 128-bit compressed texel block encodes a 8×8 rectangle of signed floating-point RGBA texel data. </summary>
    VK_FORMAT_ASTC_8x8_SFLOAT_BLOCK = 1000066007,

    /// <summary> VK_FORMAT_ASTC_10x5_SFLOAT_BLOCK specifies a four-component, ASTC compressed format where each 128-bit compressed texel block encodes a 10×5 rectangle of signed floating-point RGBA texel data. </summary>
    VK_FORMAT_ASTC_10x5_SFLOAT_BLOCK = 1000066008,

    /// <summary> VK_FORMAT_ASTC_10x6_SFLOAT_BLOCK specifies a four-component, ASTC compressed format where each 128-bit compressed texel block encodes a 10×6 rectangle of signed floating-point RGBA texel data. </summary>
    VK_FORMAT_ASTC_10x6_SFLOAT_BLOCK = 1000066009,

    /// <summary> VK_FORMAT_ASTC_10x8_SFLOAT_BLOCK specifies a four-component, ASTC compressed format where each 128-bit compressed texel block encodes a 10×8 rectangle of signed floating-point RGBA texel data. </summary>
    VK_FORMAT_ASTC_10x8_SFLOAT_BLOCK = 1000066010,

    /// <summary> VK_FORMAT_ASTC_10x10_SFLOAT_BLOCK specifies a four-component, ASTC compressed format where each 128-bit compressed texel block encodes a 10×10 rectangle of signed floating-point RGBA texel data. </summary>
    VK_FORMAT_ASTC_10x10_SFLOAT_BLOCK = 1000066011,

    /// <summary> VK_FORMAT_ASTC_12x10_SFLOAT_BLOCK specifies a four-component, ASTC compressed format where each 128-bit compressed texel block encodes a 12×10 rectangle of signed floating-point RGBA texel data. </summary>
    VK_FORMAT_ASTC_12x10_SFLOAT_BLOCK = 1000066012,

    /// <summary> VK_FORMAT_ASTC_12x12_SFLOAT_BLOCK specifies a four-component, ASTC compressed format where each 128-bit compressed texel block encodes a 12×12 rectangle of signed floating-point RGBA texel data. </summary>
    VK_FORMAT_ASTC_12x12_SFLOAT_BLOCK = 1000066013,

    /// <summary> VK_FORMAT_PVRTC1_2BPP_UNORM_BLOCK_IMG specifies a four-component, PVRTC compressed format where each 64-bit compressed texel block encodes an 8×4 rectangle of unsigned normalized RGBA texel data. </summary>
    VK_FORMAT_PVRTC1_2BPP_UNORM_BLOCK_IMG = 1000054000,

    /// <summary> VK_FORMAT_PVRTC1_4BPP_UNORM_BLOCK_IMG specifies a four-component, PVRTC compressed format where each 64-bit compressed texel block encodes a 4×4 rectangle of unsigned normalized RGBA texel data. </summary>
    VK_FORMAT_PVRTC1_4BPP_UNORM_BLOCK_IMG = 1000054001,

    /// <summary> VK_FORMAT_PVRTC2_2BPP_UNORM_BLOCK_IMG specifies a four-component, PVRTC compressed format where each 64-bit compressed texel block encodes an 8×4 rectangle of unsigned normalized RGBA texel data. </summary>
    VK_FORMAT_PVRTC2_2BPP_UNORM_BLOCK_IMG = 1000054002,

    /// <summary> VK_FORMAT_PVRTC2_4BPP_UNORM_BLOCK_IMG specifies a four-component, PVRTC compressed format where each 64-bit compressed texel block encodes a 4×4 rectangle of unsigned normalized RGBA texel data. </summary>
    VK_FORMAT_PVRTC2_4BPP_UNORM_BLOCK_IMG = 1000054003,

    /// <summary> VK_FORMAT_PVRTC1_2BPP_SRGB_BLOCK_IMG specifies a four-component, PVRTC compressed format where each 64-bit compressed texel block encodes an 8×4 rectangle of unsigned normalized RGBA texel data with sRGB nonlinear encoding applied to the RGB components. </summary>
    VK_FORMAT_PVRTC1_2BPP_SRGB_BLOCK_IMG = 1000054004,

    /// <summary> VK_FORMAT_PVRTC1_4BPP_SRGB_BLOCK_IMG specifies a four-component, PVRTC compressed format where each 64-bit compressed texel block encodes a 4×4 rectangle of unsigned normalized RGBA texel data with sRGB nonlinear encoding applied to the RGB components. </summary>
    VK_FORMAT_PVRTC1_4BPP_SRGB_BLOCK_IMG = 1000054005,

    /// <summary> VK_FORMAT_PVRTC2_2BPP_SRGB_BLOCK_IMG specifies a four-component, PVRTC compressed format where each 64-bit compressed texel block encodes an 8×4 rectangle of unsigned normalized RGBA texel data with sRGB nonlinear encoding applied to the RGB components. </summary>
    VK_FORMAT_PVRTC2_2BPP_SRGB_BLOCK_IMG = 1000054006,

    /// <summary> VK_FORMAT_PVRTC2_4BPP_SRGB_BLOCK_IMG specifies a four-component, PVRTC compressed format where each 64-bit compressed texel block encodes a 4×4 rectangle of unsigned normalized RGBA texel data with sRGB nonlinear encoding applied to the RGB components. </summary>
    VK_FORMAT_PVRTC2_4BPP_SRGB_BLOCK_IMG = 1000054007,

    /// <summary>
    ///     VK_FORMAT_ASTC_3x3x3_UNORM_BLOCK_EXT<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkFormat"> https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkFormat </a>
    /// </summary>
    VK_FORMAT_ASTC_3x3x3_UNORM_BLOCK_EXT = 1000288000,

    /// <summary>
    ///     VK_FORMAT_ASTC_3x3x3_SRGB_BLOCK_EXT<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkFormat"> https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkFormat </a>
    /// </summary>
    VK_FORMAT_ASTC_3x3x3_SRGB_BLOCK_EXT = 1000288001,

    /// <summary>
    ///     VK_FORMAT_ASTC_3x3x3_SFLOAT_BLOCK_EXT<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkFormat"> https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkFormat </a>
    /// </summary>
    VK_FORMAT_ASTC_3x3x3_SFLOAT_BLOCK_EXT = 1000288002,

    /// <summary>
    ///     VK_FORMAT_ASTC_4x3x3_UNORM_BLOCK_EXT<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkFormat"> https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkFormat </a>
    /// </summary>
    VK_FORMAT_ASTC_4x3x3_UNORM_BLOCK_EXT = 1000288003,

    /// <summary>
    ///     VK_FORMAT_ASTC_4x3x3_SRGB_BLOCK_EXT<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkFormat"> https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkFormat </a>
    /// </summary>
    VK_FORMAT_ASTC_4x3x3_SRGB_BLOCK_EXT = 1000288004,

    /// <summary>
    ///     VK_FORMAT_ASTC_4x3x3_SFLOAT_BLOCK_EXT<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkFormat"> https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkFormat </a>
    /// </summary>
    VK_FORMAT_ASTC_4x3x3_SFLOAT_BLOCK_EXT = 1000288005,

    /// <summary>
    ///     VK_FORMAT_ASTC_4x4x3_UNORM_BLOCK_EXT<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkFormat"> https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkFormat </a>
    /// </summary>
    VK_FORMAT_ASTC_4x4x3_UNORM_BLOCK_EXT = 1000288006,

    /// <summary>
    ///     VK_FORMAT_ASTC_4x4x3_SRGB_BLOCK_EXT<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkFormat"> https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkFormat </a>
    /// </summary>
    VK_FORMAT_ASTC_4x4x3_SRGB_BLOCK_EXT = 1000288007,

    /// <summary>
    ///     VK_FORMAT_ASTC_4x4x3_SFLOAT_BLOCK_EXT<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkFormat"> https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkFormat </a>
    /// </summary>
    VK_FORMAT_ASTC_4x4x3_SFLOAT_BLOCK_EXT = 1000288008,

    /// <summary>
    ///     VK_FORMAT_ASTC_4x4x4_UNORM_BLOCK_EXT<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkFormat"> https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkFormat </a>
    /// </summary>
    VK_FORMAT_ASTC_4x4x4_UNORM_BLOCK_EXT = 1000288009,

    /// <summary>
    ///     VK_FORMAT_ASTC_4x4x4_SRGB_BLOCK_EXT<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkFormat"> https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkFormat </a>
    /// </summary>
    VK_FORMAT_ASTC_4x4x4_SRGB_BLOCK_EXT = 1000288010,

    /// <summary>
    ///     VK_FORMAT_ASTC_4x4x4_SFLOAT_BLOCK_EXT<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkFormat"> https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkFormat </a>
    /// </summary>
    VK_FORMAT_ASTC_4x4x4_SFLOAT_BLOCK_EXT = 1000288011,

    /// <summary>
    ///     VK_FORMAT_ASTC_5x4x4_UNORM_BLOCK_EXT<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkFormat"> https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkFormat </a>
    /// </summary>
    VK_FORMAT_ASTC_5x4x4_UNORM_BLOCK_EXT = 1000288012,

    /// <summary>
    ///     VK_FORMAT_ASTC_5x4x4_SRGB_BLOCK_EXT<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkFormat"> https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkFormat </a>
    /// </summary>
    VK_FORMAT_ASTC_5x4x4_SRGB_BLOCK_EXT = 1000288013,

    /// <summary>
    ///     VK_FORMAT_ASTC_5x4x4_SFLOAT_BLOCK_EXT<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkFormat"> https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkFormat </a>
    /// </summary>
    VK_FORMAT_ASTC_5x4x4_SFLOAT_BLOCK_EXT = 1000288014,

    /// <summary>
    ///     VK_FORMAT_ASTC_5x5x4_UNORM_BLOCK_EXT<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkFormat"> https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkFormat </a>
    /// </summary>
    VK_FORMAT_ASTC_5x5x4_UNORM_BLOCK_EXT = 1000288015,

    /// <summary>
    ///     VK_FORMAT_ASTC_5x5x4_SRGB_BLOCK_EXT<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkFormat"> https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkFormat </a>
    /// </summary>
    VK_FORMAT_ASTC_5x5x4_SRGB_BLOCK_EXT = 1000288016,

    /// <summary>
    ///     VK_FORMAT_ASTC_5x5x4_SFLOAT_BLOCK_EXT<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkFormat"> https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkFormat </a>
    /// </summary>
    VK_FORMAT_ASTC_5x5x4_SFLOAT_BLOCK_EXT = 1000288017,

    /// <summary>
    ///     VK_FORMAT_ASTC_5x5x5_UNORM_BLOCK_EXT<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkFormat"> https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkFormat </a>
    /// </summary>
    VK_FORMAT_ASTC_5x5x5_UNORM_BLOCK_EXT = 1000288018,

    /// <summary>
    ///     VK_FORMAT_ASTC_5x5x5_SRGB_BLOCK_EXT<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkFormat"> https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkFormat </a>
    /// </summary>
    VK_FORMAT_ASTC_5x5x5_SRGB_BLOCK_EXT = 1000288019,

    /// <summary>
    ///     VK_FORMAT_ASTC_5x5x5_SFLOAT_BLOCK_EXT<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkFormat"> https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkFormat </a>
    /// </summary>
    VK_FORMAT_ASTC_5x5x5_SFLOAT_BLOCK_EXT = 1000288020,

    /// <summary>
    ///     VK_FORMAT_ASTC_6x5x5_UNORM_BLOCK_EXT<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkFormat"> https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkFormat </a>
    /// </summary>
    VK_FORMAT_ASTC_6x5x5_UNORM_BLOCK_EXT = 1000288021,

    /// <summary>
    ///     VK_FORMAT_ASTC_6x5x5_SRGB_BLOCK_EXT<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkFormat"> https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkFormat </a>
    /// </summary>
    VK_FORMAT_ASTC_6x5x5_SRGB_BLOCK_EXT = 1000288022,

    /// <summary>
    ///     VK_FORMAT_ASTC_6x5x5_SFLOAT_BLOCK_EXT<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkFormat"> https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkFormat </a>
    /// </summary>
    VK_FORMAT_ASTC_6x5x5_SFLOAT_BLOCK_EXT = 1000288023,

    /// <summary>
    ///     VK_FORMAT_ASTC_6x6x5_UNORM_BLOCK_EXT<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkFormat"> https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkFormat </a>
    /// </summary>
    VK_FORMAT_ASTC_6x6x5_UNORM_BLOCK_EXT = 1000288024,

    /// <summary>
    ///     VK_FORMAT_ASTC_6x6x5_SRGB_BLOCK_EXT<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkFormat"> https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkFormat </a>
    /// </summary>
    VK_FORMAT_ASTC_6x6x5_SRGB_BLOCK_EXT = 1000288025,

    /// <summary>
    ///     VK_FORMAT_ASTC_6x6x5_SFLOAT_BLOCK_EXT<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkFormat"> https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkFormat </a>
    /// </summary>
    VK_FORMAT_ASTC_6x6x5_SFLOAT_BLOCK_EXT = 1000288026,

    /// <summary>
    ///     VK_FORMAT_ASTC_6x6x6_UNORM_BLOCK_EXT<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkFormat"> https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkFormat </a>
    /// </summary>
    VK_FORMAT_ASTC_6x6x6_UNORM_BLOCK_EXT = 1000288027,

    /// <summary>
    ///     VK_FORMAT_ASTC_6x6x6_SRGB_BLOCK_EXT<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkFormat"> https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkFormat </a>
    /// </summary>
    VK_FORMAT_ASTC_6x6x6_SRGB_BLOCK_EXT = 1000288028,

    /// <summary>
    ///     VK_FORMAT_ASTC_6x6x6_SFLOAT_BLOCK_EXT<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkFormat"> https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkFormat </a>
    /// </summary>
    VK_FORMAT_ASTC_6x6x6_SFLOAT_BLOCK_EXT = 1000288029,

    /// <summary> VK_FORMAT_ASTC_4x4_SFLOAT_BLOCK specifies a four-component, ASTC compressed format where each 128-bit compressed texel block encodes a 4×4 rectangle of signed floating-point RGBA texel data. </summary>
    VK_FORMAT_ASTC_4x4_SFLOAT_BLOCK_EXT = VK_FORMAT_ASTC_4x4_SFLOAT_BLOCK,

    /// <summary> VK_FORMAT_ASTC_5x4_SFLOAT_BLOCK specifies a four-component, ASTC compressed format where each 128-bit compressed texel block encodes a 5×4 rectangle of signed floating-point RGBA texel data. </summary>
    VK_FORMAT_ASTC_5x4_SFLOAT_BLOCK_EXT = VK_FORMAT_ASTC_5x4_SFLOAT_BLOCK,

    /// <summary> VK_FORMAT_ASTC_5x5_SFLOAT_BLOCK specifies a four-component, ASTC compressed format where each 128-bit compressed texel block encodes a 5×5 rectangle of signed floating-point RGBA texel data. </summary>
    VK_FORMAT_ASTC_5x5_SFLOAT_BLOCK_EXT = VK_FORMAT_ASTC_5x5_SFLOAT_BLOCK,

    /// <summary> VK_FORMAT_ASTC_6x5_SFLOAT_BLOCK specifies a four-component, ASTC compressed format where each 128-bit compressed texel block encodes a 6×5 rectangle of signed floating-point RGBA texel data. </summary>
    VK_FORMAT_ASTC_6x5_SFLOAT_BLOCK_EXT = VK_FORMAT_ASTC_6x5_SFLOAT_BLOCK,

    /// <summary> VK_FORMAT_ASTC_6x6_SFLOAT_BLOCK specifies a four-component, ASTC compressed format where each 128-bit compressed texel block encodes a 6×6 rectangle of signed floating-point RGBA texel data. </summary>
    VK_FORMAT_ASTC_6x6_SFLOAT_BLOCK_EXT = VK_FORMAT_ASTC_6x6_SFLOAT_BLOCK,

    /// <summary> VK_FORMAT_ASTC_8x5_SFLOAT_BLOCK specifies a four-component, ASTC compressed format where each 128-bit compressed texel block encodes a 8×5 rectangle of signed floating-point RGBA texel data. </summary>
    VK_FORMAT_ASTC_8x5_SFLOAT_BLOCK_EXT = VK_FORMAT_ASTC_8x5_SFLOAT_BLOCK,

    /// <summary> VK_FORMAT_ASTC_8x6_SFLOAT_BLOCK specifies a four-component, ASTC compressed format where each 128-bit compressed texel block encodes a 8×6 rectangle of signed floating-point RGBA texel data. </summary>
    VK_FORMAT_ASTC_8x6_SFLOAT_BLOCK_EXT = VK_FORMAT_ASTC_8x6_SFLOAT_BLOCK,

    /// <summary> VK_FORMAT_ASTC_8x8_SFLOAT_BLOCK specifies a four-component, ASTC compressed format where each 128-bit compressed texel block encodes a 8×8 rectangle of signed floating-point RGBA texel data. </summary>
    VK_FORMAT_ASTC_8x8_SFLOAT_BLOCK_EXT = VK_FORMAT_ASTC_8x8_SFLOAT_BLOCK,

    /// <summary> VK_FORMAT_ASTC_10x5_SFLOAT_BLOCK specifies a four-component, ASTC compressed format where each 128-bit compressed texel block encodes a 10×5 rectangle of signed floating-point RGBA texel data. </summary>
    VK_FORMAT_ASTC_10x5_SFLOAT_BLOCK_EXT = VK_FORMAT_ASTC_10x5_SFLOAT_BLOCK,

    /// <summary> VK_FORMAT_ASTC_10x6_SFLOAT_BLOCK specifies a four-component, ASTC compressed format where each 128-bit compressed texel block encodes a 10×6 rectangle of signed floating-point RGBA texel data. </summary>
    VK_FORMAT_ASTC_10x6_SFLOAT_BLOCK_EXT = VK_FORMAT_ASTC_10x6_SFLOAT_BLOCK,

    /// <summary> VK_FORMAT_ASTC_10x8_SFLOAT_BLOCK specifies a four-component, ASTC compressed format where each 128-bit compressed texel block encodes a 10×8 rectangle of signed floating-point RGBA texel data. </summary>
    VK_FORMAT_ASTC_10x8_SFLOAT_BLOCK_EXT = VK_FORMAT_ASTC_10x8_SFLOAT_BLOCK,

    /// <summary> VK_FORMAT_ASTC_10x10_SFLOAT_BLOCK specifies a four-component, ASTC compressed format where each 128-bit compressed texel block encodes a 10×10 rectangle of signed floating-point RGBA texel data. </summary>
    VK_FORMAT_ASTC_10x10_SFLOAT_BLOCK_EXT = VK_FORMAT_ASTC_10x10_SFLOAT_BLOCK,

    /// <summary> VK_FORMAT_ASTC_12x10_SFLOAT_BLOCK specifies a four-component, ASTC compressed format where each 128-bit compressed texel block encodes a 12×10 rectangle of signed floating-point RGBA texel data. </summary>
    VK_FORMAT_ASTC_12x10_SFLOAT_BLOCK_EXT = VK_FORMAT_ASTC_12x10_SFLOAT_BLOCK,

    /// <summary> VK_FORMAT_ASTC_12x12_SFLOAT_BLOCK specifies a four-component, ASTC compressed format where each 128-bit compressed texel block encodes a 12×12 rectangle of signed floating-point RGBA texel data. </summary>
    VK_FORMAT_ASTC_12x12_SFLOAT_BLOCK_EXT = VK_FORMAT_ASTC_12x12_SFLOAT_BLOCK,

    /// <summary> VK_FORMAT_G8B8G8R8_422_UNORM specifies a four-component, 32-bit format containing a pair of G components, an R component, and a B component, collectively encoding a 2×1 rectangle of unsigned normalized RGB texel data. One G value is present at each i coordinate, with the B and R values shared across both G values and thus recorded at half the horizontal resolution of the image. This format has an 8-bit G component for the even i coordinate in byte 0, an 8-bit B component in byte 1, an 8-bit G component for the odd icoordinate in byte 2, and an 8-bit R component in byte 3. This format only supports images with a width that is a multiple of two. For the purposes of the constraints on copy extents, this format is treated as a compressed format with a 2×1 compressed texel block. </summary>
    VK_FORMAT_G8B8G8R8_422_UNORM_KHR = VK_FORMAT_G8B8G8R8_422_UNORM,

    /// <summary> VK_FORMAT_B8G8R8G8_422_UNORM specifies a four-component, 32-bit format containing a pair of G components, an R component, and a B component, collectively encoding a 2×1 rectangle of unsigned normalized RGB texel data. One G value is present at each i coordinate, with the B and R values shared across both G values and thus recorded at half the horizontal resolution of the image. This format has an 8-bit B component in byte 0, an 8-bit G component for the even i coordinate in byte 1, an 8-bit R component in byte 2, and an 8-bit G component for the odd i coordinate in byte 3. This format only supports images with a width that is a multiple of two. For the purposes of the constraints on copy extents, this format is treated as a compressed format with a 2×1 compressed texel block. </summary>
    VK_FORMAT_B8G8R8G8_422_UNORM_KHR = VK_FORMAT_B8G8R8G8_422_UNORM,

    /// <summary>
    ///     VK_FORMAT_G8_B8_R8_3PLANE_420_UNORM specifies an unsigned normalized multi-planar format that has an 8-bit G component in plane 0, an 8-bit B component in plane 1, and an 8-bit R component in plane 2. The horizontal and vertical dimensions of the R and B planes are halved relative to the image dimensions, and each R and B component is shared with the G components for which ⌊iG​×0.5⌋=iB​=iR​ and ⌊jG​×0.5⌋=jB​=jR​. The location of each plane when this image is in linear layout can be determined via
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkGetImageSubresourceLayout.html"> vkGetImageSubresourceLayout </a>
    ///     , using VK_IMAGE_ASPECT_PLANE_0_BIT for the G plane, VK_IMAGE_ASPECT_PLANE_1_BIT for the B plane, and VK_IMAGE_ASPECT_PLANE_2_BIT for the R plane. This format only supports images with a width and height that is a multiple of two.
    /// </summary>
    VK_FORMAT_G8_B8_R8_3PLANE_420_UNORM_KHR = VK_FORMAT_G8_B8_R8_3PLANE_420_UNORM,

    /// <summary>
    ///     VK_FORMAT_G8_B8R8_2PLANE_420_UNORM specifies an unsigned normalized multi-planar format that has an 8-bit G component in plane 0, and a two-component, 16-bit BR plane 1 consisting of an 8-bit B component in byte 0 and an 8-bit R component in byte 1. The horizontal and vertical dimensions of the BR plane are halved relative to the image dimensions, and each R and B value is shared with the G components for which ⌊iG​×0.5⌋=iB​=iR​ and ⌊jG​×0.5⌋=jB​=jR​. The location of each plane when this image is in linear layout can be determined via
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkGetImageSubresourceLayout.html"> vkGetImageSubresourceLayout </a>
    ///     , using VK_IMAGE_ASPECT_PLANE_0_BIT for the G plane, and VK_IMAGE_ASPECT_PLANE_1_BIT for the BR plane. This format only supports images with a width and height that is a multiple of two.
    /// </summary>
    VK_FORMAT_G8_B8R8_2PLANE_420_UNORM_KHR = VK_FORMAT_G8_B8R8_2PLANE_420_UNORM,

    /// <summary>
    ///     VK_FORMAT_G8_B8_R8_3PLANE_422_UNORM specifies an unsigned normalized multi-planar format that has an 8-bit G component in plane 0, an 8-bit B component in plane 1, and an 8-bit R component in plane 2. The horizontal dimension of the R and B plane is halved relative to the image dimensions, and each R and B value is shared with the G components for which ⌊iG​×0.5⌋=iB​=iR​. The location of each plane when this image is in linear layout can be determined via
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkGetImageSubresourceLayout.html"> vkGetImageSubresourceLayout </a>
    ///     , using VK_IMAGE_ASPECT_PLANE_0_BIT for the G plane, VK_IMAGE_ASPECT_PLANE_1_BIT for the B plane, and VK_IMAGE_ASPECT_PLANE_2_BIT for the R plane. This format only supports images with a width that is a multiple of two.
    /// </summary>
    VK_FORMAT_G8_B8_R8_3PLANE_422_UNORM_KHR = VK_FORMAT_G8_B8_R8_3PLANE_422_UNORM,

    /// <summary>
    ///     VK_FORMAT_G8_B8R8_2PLANE_422_UNORM specifies an unsigned normalized multi-planar format that has an 8-bit G component in plane 0, and a two-component, 16-bit BR plane 1 consisting of an 8-bit B component in byte 0 and an 8-bit R component in byte 1. The horizontal dimension of the BR plane is halved relative to the image dimensions, and each R and B value is shared with the G components for which ⌊iG​×0.5⌋=iB​=iR​. The location of each plane when this image is in linear layout can be determined via
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkGetImageSubresourceLayout.html"> vkGetImageSubresourceLayout </a>
    ///     , using VK_IMAGE_ASPECT_PLANE_0_BIT for the G plane, and VK_IMAGE_ASPECT_PLANE_1_BIT for the BR plane. This format only supports images with a width that is a multiple of two.
    /// </summary>
    VK_FORMAT_G8_B8R8_2PLANE_422_UNORM_KHR = VK_FORMAT_G8_B8R8_2PLANE_422_UNORM,

    /// <summary>
    ///     VK_FORMAT_G8_B8_R8_3PLANE_444_UNORM specifies an unsigned normalized multi-planar format that has an 8-bit G component in plane 0, an 8-bit B component in plane 1, and an 8-bit R component in plane 2. Each plane has the same dimensions and each R, G and B component contributes to a single texel. The location of each plane when this image is in linear layout can be determined via
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkGetImageSubresourceLayout.html"> vkGetImageSubresourceLayout </a>
    ///     , using VK_IMAGE_ASPECT_PLANE_0_BIT for the G plane, VK_IMAGE_ASPECT_PLANE_1_BIT for the B plane, and VK_IMAGE_ASPECT_PLANE_2_BIT for the R plane.
    /// </summary>
    VK_FORMAT_G8_B8_R8_3PLANE_444_UNORM_KHR = VK_FORMAT_G8_B8_R8_3PLANE_444_UNORM,

    /// <summary> VK_FORMAT_R10X6_UNORM_PACK16 specifies a one-component, 16-bit unsigned normalized format that has a single 10-bit R component in the top 10 bits of a 16-bit word, with the bottom 6 bits unused. </summary>
    VK_FORMAT_R10X6_UNORM_PACK16_KHR = VK_FORMAT_R10X6_UNORM_PACK16,

    /// <summary> VK_FORMAT_R10X6G10X6_UNORM_2PACK16 specifies a two-component, 32-bit unsigned normalized format that has a 10-bit R component in the top 10 bits of the word in bytes 0..1, and a 10-bit G component in the top 10 bits of the word in bytes 2..3, with the bottom 6 bits of each word unused. </summary>
    VK_FORMAT_R10X6G10X6_UNORM_2PACK16_KHR = VK_FORMAT_R10X6G10X6_UNORM_2PACK16,

    /// <summary> VK_FORMAT_R10X6G10X6B10X6A10X6_UNORM_4PACK16 specifies a four-component, 64-bit unsigned normalized format that has a 10-bit R component in the top 10 bits of the word in bytes 0..1, a 10-bit G component in the top 10 bits of the word in bytes 2..3, a 10-bit B component in the top 10 bits of the word in bytes 4..5, and a 10-bit A component in the top 10 bits of the word in bytes 6..7, with the bottom 6 bits of each word unused. </summary>
    VK_FORMAT_R10X6G10X6B10X6A10X6_UNORM_4PACK16_KHR = VK_FORMAT_R10X6G10X6B10X6A10X6_UNORM_4PACK16,

    /// <summary> VK_FORMAT_G10X6B10X6G10X6R10X6_422_UNORM_4PACK16 specifies a four-component, 64-bit format containing a pair of G components, an R component, and a B component, collectively encoding a 2×1 rectangle of unsigned normalized RGB texel data. One G value is present at each i coordinate, with the B and R values shared across both G values and thus recorded at half the horizontal resolution of the image. This format has a 10-bit G component for the even i coordinate in the top 10 bits of the word in bytes 0..1, a 10-bit B component in the top 10 bits of the word in bytes 2..3, a 10-bit G component for the odd icoordinate in the top 10 bits of the word in bytes 4..5, and a 10-bit R component in the top 10 bits of the word in bytes 6..7, with the bottom 6 bits of each word unused. This format only supports images with a width that is a multiple of two. For the purposes of the constraints on copy extents, this format is treated as a compressed format with a 2×1 compressed texel block. </summary>
    VK_FORMAT_G10X6B10X6G10X6R10X6_422_UNORM_4PACK16_KHR = VK_FORMAT_G10X6B10X6G10X6R10X6_422_UNORM_4PACK16,

    /// <summary> VK_FORMAT_B10X6G10X6R10X6G10X6_422_UNORM_4PACK16 specifies a four-component, 64-bit format containing a pair of G components, an R component, and a B component, collectively encoding a 2×1 rectangle of unsigned normalized RGB texel data. One G value is present at each i coordinate, with the B and R values shared across both G values and thus recorded at half the horizontal resolution of the image. This format has a 10-bit B component in the top 10 bits of the word in bytes 0..1, a 10-bit G component for the even i coordinate in the top 10 bits of the word in bytes 2..3, a 10-bit R component in the top 10 bits of the word in bytes 4..5, and a 10-bit G component for the odd icoordinate in the top 10 bits of the word in bytes 6..7, with the bottom 6 bits of each word unused. This format only supports images with a width that is a multiple of two. For the purposes of the constraints on copy extents, this format is treated as a compressed format with a 2×1 compressed texel block. </summary>
    VK_FORMAT_B10X6G10X6R10X6G10X6_422_UNORM_4PACK16_KHR = VK_FORMAT_B10X6G10X6R10X6G10X6_422_UNORM_4PACK16,

    /// <summary>
    ///     VK_FORMAT_G10X6_B10X6_R10X6_3PLANE_420_UNORM_3PACK16 specifies an unsigned normalized multi-planar format that has a 10-bit G component in the top 10 bits of each 16-bit word of plane 0, a 10-bit B component in the top 10 bits of each 16-bit word of plane 1, and a 10-bit R component in the top 10 bits of each 16-bit word of plane 2, with the bottom 6 bits of each word unused. The horizontal and vertical dimensions of the R and B planes are halved relative to the image dimensions, and each R and B component is shared with the G components for which ⌊iG​×0.5⌋=iB​=iR​ and ⌊jG​×0.5⌋=jB​=jR​. The location of each plane when this image is in linear layout can be determined via
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkGetImageSubresourceLayout.html"> vkGetImageSubresourceLayout </a>
    ///     , using VK_IMAGE_ASPECT_PLANE_0_BIT for the G plane, VK_IMAGE_ASPECT_PLANE_1_BIT for the B plane, and VK_IMAGE_ASPECT_PLANE_2_BIT for the R plane. This format only supports images with a width and height that is a multiple of two.
    /// </summary>
    VK_FORMAT_G10X6_B10X6_R10X6_3PLANE_420_UNORM_3PACK16_KHR = VK_FORMAT_G10X6_B10X6_R10X6_3PLANE_420_UNORM_3PACK16,

    /// <summary>
    ///     VK_FORMAT_G10X6_B10X6R10X6_2PLANE_420_UNORM_3PACK16 specifies an unsigned normalized multi-planar format that has a 10-bit G component in the top 10 bits of each 16-bit word of plane 0, and a two-component, 32-bit BR plane 1 consisting of a 10-bit B component in the top 10 bits of the word in bytes 0..1, and a 10-bit R component in the top 10 bits of the word in bytes 2..3, with the bottom 6 bits of each word unused. The horizontal and vertical dimensions of the BR plane are halved relative to the image dimensions, and each R and B value is shared with the G components for which ⌊iG​×0.5⌋=iB​=iR​ and ⌊jG​×0.5⌋=jB​=jR​. The location of each plane when this image is in linear layout can be determined via
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkGetImageSubresourceLayout.html"> vkGetImageSubresourceLayout </a>
    ///     , using VK_IMAGE_ASPECT_PLANE_0_BIT for the G plane, and VK_IMAGE_ASPECT_PLANE_1_BIT for the BR plane. This format only supports images with a width and height that is a multiple of two.
    /// </summary>
    VK_FORMAT_G10X6_B10X6R10X6_2PLANE_420_UNORM_3PACK16_KHR = VK_FORMAT_G10X6_B10X6R10X6_2PLANE_420_UNORM_3PACK16,

    /// <summary>
    ///     VK_FORMAT_G10X6_B10X6_R10X6_3PLANE_422_UNORM_3PACK16 specifies an unsigned normalized multi-planar format that has a 10-bit G component in the top 10 bits of each 16-bit word of plane 0, a 10-bit B component in the top 10 bits of each 16-bit word of plane 1, and a 10-bit R component in the top 10 bits of each 16-bit word of plane 2, with the bottom 6 bits of each word unused. The horizontal dimension of the R and B plane is halved relative to the image dimensions, and each R and B value is shared with the G components for which ⌊iG​×0.5⌋=iB​=iR​. The location of each plane when this image is in linear layout can be determined via
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkGetImageSubresourceLayout.html"> vkGetImageSubresourceLayout </a>
    ///     , using VK_IMAGE_ASPECT_PLANE_0_BIT for the G plane, VK_IMAGE_ASPECT_PLANE_1_BIT for the B plane, and VK_IMAGE_ASPECT_PLANE_2_BIT for the R plane. This format only supports images with a width that is a multiple of two.
    /// </summary>
    VK_FORMAT_G10X6_B10X6_R10X6_3PLANE_422_UNORM_3PACK16_KHR = VK_FORMAT_G10X6_B10X6_R10X6_3PLANE_422_UNORM_3PACK16,

    /// <summary>
    ///     VK_FORMAT_G10X6_B10X6R10X6_2PLANE_422_UNORM_3PACK16 specifies an unsigned normalized multi-planar format that has a 10-bit G component in the top 10 bits of each 16-bit word of plane 0, and a two-component, 32-bit BR plane 1 consisting of a 10-bit B component in the top 10 bits of the word in bytes 0..1, and a 10-bit R component in the top 10 bits of the word in bytes 2..3, with the bottom 6 bits of each word unused. The horizontal dimension of the BR plane is halved relative to the image dimensions, and each R and B value is shared with the G components for which ⌊iG​×0.5⌋=iB​=iR​. The location of each plane when this image is in linear layout can be determined via
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkGetImageSubresourceLayout.html"> vkGetImageSubresourceLayout </a>
    ///     , using VK_IMAGE_ASPECT_PLANE_0_BIT for the G plane, and VK_IMAGE_ASPECT_PLANE_1_BIT for the BR plane. This format only supports images with a width that is a multiple of two.
    /// </summary>
    VK_FORMAT_G10X6_B10X6R10X6_2PLANE_422_UNORM_3PACK16_KHR = VK_FORMAT_G10X6_B10X6R10X6_2PLANE_422_UNORM_3PACK16,

    /// <summary>
    ///     VK_FORMAT_G10X6_B10X6_R10X6_3PLANE_444_UNORM_3PACK16 specifies an unsigned normalized multi-planar format that has a 10-bit G component in the top 10 bits of each 16-bit word of plane 0, a 10-bit B component in the top 10 bits of each 16-bit word of plane 1, and a 10-bit R component in the top 10 bits of each 16-bit word of plane 2, with the bottom 6 bits of each word unused. Each plane has the same dimensions and each R, G and B component contributes to a single texel. The location of each plane when this image is in linear layout can be determined via
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkGetImageSubresourceLayout.html"> vkGetImageSubresourceLayout </a>
    ///     , using VK_IMAGE_ASPECT_PLANE_0_BIT for the G plane, VK_IMAGE_ASPECT_PLANE_1_BIT for the B plane, and VK_IMAGE_ASPECT_PLANE_2_BIT for the R plane.
    /// </summary>
    VK_FORMAT_G10X6_B10X6_R10X6_3PLANE_444_UNORM_3PACK16_KHR = VK_FORMAT_G10X6_B10X6_R10X6_3PLANE_444_UNORM_3PACK16,

    /// <summary> VK_FORMAT_R12X4_UNORM_PACK16 specifies a one-component, 16-bit unsigned normalized format that has a single 12-bit R component in the top 12 bits of a 16-bit word, with the bottom 4 bits unused. </summary>
    VK_FORMAT_R12X4_UNORM_PACK16_KHR = VK_FORMAT_R12X4_UNORM_PACK16,

    /// <summary> VK_FORMAT_R12X4G12X4_UNORM_2PACK16 specifies a two-component, 32-bit unsigned normalized format that has a 12-bit R component in the top 12 bits of the word in bytes 0..1, and a 12-bit G component in the top 12 bits of the word in bytes 2..3, with the bottom 4 bits of each word unused. </summary>
    VK_FORMAT_R12X4G12X4_UNORM_2PACK16_KHR = VK_FORMAT_R12X4G12X4_UNORM_2PACK16,

    /// <summary> VK_FORMAT_R12X4G12X4B12X4A12X4_UNORM_4PACK16 specifies a four-component, 64-bit unsigned normalized format that has a 12-bit R component in the top 12 bits of the word in bytes 0..1, a 12-bit G component in the top 12 bits of the word in bytes 2..3, a 12-bit B component in the top 12 bits of the word in bytes 4..5, and a 12-bit A component in the top 12 bits of the word in bytes 6..7, with the bottom 4 bits of each word unused. </summary>
    VK_FORMAT_R12X4G12X4B12X4A12X4_UNORM_4PACK16_KHR = VK_FORMAT_R12X4G12X4B12X4A12X4_UNORM_4PACK16,

    /// <summary> VK_FORMAT_G12X4B12X4G12X4R12X4_422_UNORM_4PACK16 specifies a four-component, 64-bit format containing a pair of G components, an R component, and a B component, collectively encoding a 2×1 rectangle of unsigned normalized RGB texel data. One G value is present at each i coordinate, with the B and R values shared across both G values and thus recorded at half the horizontal resolution of the image. This format has a 12-bit G component for the even i coordinate in the top 12 bits of the word in bytes 0..1, a 12-bit B component in the top 12 bits of the word in bytes 2..3, a 12-bit G component for the odd icoordinate in the top 12 bits of the word in bytes 4..5, and a 12-bit R component in the top 12 bits of the word in bytes 6..7, with the bottom 4 bits of each word unused. This format only supports images with a width that is a multiple of two. For the purposes of the constraints on copy extents, this format is treated as a compressed format with a 2×1 compressed texel block. </summary>
    VK_FORMAT_G12X4B12X4G12X4R12X4_422_UNORM_4PACK16_KHR = VK_FORMAT_G12X4B12X4G12X4R12X4_422_UNORM_4PACK16,

    /// <summary> VK_FORMAT_B12X4G12X4R12X4G12X4_422_UNORM_4PACK16 specifies a four-component, 64-bit format containing a pair of G components, an R component, and a B component, collectively encoding a 2×1 rectangle of unsigned normalized RGB texel data. One G value is present at each i coordinate, with the B and R values shared across both G values and thus recorded at half the horizontal resolution of the image. This format has a 12-bit B component in the top 12 bits of the word in bytes 0..1, a 12-bit G component for the even i coordinate in the top 12 bits of the word in bytes 2..3, a 12-bit R component in the top 12 bits of the word in bytes 4..5, and a 12-bit G component for the odd icoordinate in the top 12 bits of the word in bytes 6..7, with the bottom 4 bits of each word unused. This format only supports images with a width that is a multiple of two. For the purposes of the constraints on copy extents, this format is treated as a compressed format with a 2×1 compressed texel block. </summary>
    VK_FORMAT_B12X4G12X4R12X4G12X4_422_UNORM_4PACK16_KHR = VK_FORMAT_B12X4G12X4R12X4G12X4_422_UNORM_4PACK16,

    /// <summary>
    ///     VK_FORMAT_G12X4_B12X4_R12X4_3PLANE_420_UNORM_3PACK16 specifies an unsigned normalized multi-planar format that has a 12-bit G component in the top 12 bits of each 16-bit word of plane 0, a 12-bit B component in the top 12 bits of each 16-bit word of plane 1, and a 12-bit R component in the top 12 bits of each 16-bit word of plane 2, with the bottom 4 bits of each word unused. The horizontal and vertical dimensions of the R and B planes are halved relative to the image dimensions, and each R and B component is shared with the G components for which ⌊iG​×0.5⌋=iB​=iR​ and ⌊jG​×0.5⌋=jB​=jR​. The location of each plane when this image is in linear layout can be determined via
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkGetImageSubresourceLayout.html"> vkGetImageSubresourceLayout </a>
    ///     , using VK_IMAGE_ASPECT_PLANE_0_BIT for the G plane, VK_IMAGE_ASPECT_PLANE_1_BIT for the B plane, and VK_IMAGE_ASPECT_PLANE_2_BIT for the R plane. This format only supports images with a width and height that is a multiple of two.
    /// </summary>
    VK_FORMAT_G12X4_B12X4_R12X4_3PLANE_420_UNORM_3PACK16_KHR = VK_FORMAT_G12X4_B12X4_R12X4_3PLANE_420_UNORM_3PACK16,

    /// <summary>
    ///     VK_FORMAT_G12X4_B12X4R12X4_2PLANE_420_UNORM_3PACK16 specifies an unsigned normalized multi-planar format that has a 12-bit G component in the top 12 bits of each 16-bit word of plane 0, and a two-component, 32-bit BR plane 1 consisting of a 12-bit B component in the top 12 bits of the word in bytes 0..1, and a 12-bit R component in the top 12 bits of the word in bytes 2..3, with the bottom 4 bits of each word unused. The horizontal and vertical dimensions of the BR plane are halved relative to the image dimensions, and each R and B value is shared with the G components for which ⌊iG​×0.5⌋=iB​=iR​ and ⌊jG​×0.5⌋=jB​=jR​. The location of each plane when this image is in linear layout can be determined via
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkGetImageSubresourceLayout.html"> vkGetImageSubresourceLayout </a>
    ///     , using VK_IMAGE_ASPECT_PLANE_0_BIT for the G plane, and VK_IMAGE_ASPECT_PLANE_1_BIT for the BR plane. This format only supports images with a width and height that is a multiple of two.
    /// </summary>
    VK_FORMAT_G12X4_B12X4R12X4_2PLANE_420_UNORM_3PACK16_KHR = VK_FORMAT_G12X4_B12X4R12X4_2PLANE_420_UNORM_3PACK16,

    /// <summary>
    ///     VK_FORMAT_G12X4_B12X4_R12X4_3PLANE_422_UNORM_3PACK16 specifies an unsigned normalized multi-planar format that has a 12-bit G component in the top 12 bits of each 16-bit word of plane 0, a 12-bit B component in the top 12 bits of each 16-bit word of plane 1, and a 12-bit R component in the top 12 bits of each 16-bit word of plane 2, with the bottom 4 bits of each word unused. The horizontal dimension of the R and B plane is halved relative to the image dimensions, and each R and B value is shared with the G components for which ⌊iG​×0.5⌋=iB​=iR​. The location of each plane when this image is in linear layout can be determined via
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkGetImageSubresourceLayout.html"> vkGetImageSubresourceLayout </a>
    ///     , using VK_IMAGE_ASPECT_PLANE_0_BIT for the G plane, VK_IMAGE_ASPECT_PLANE_1_BIT for the B plane, and VK_IMAGE_ASPECT_PLANE_2_BIT for the R plane. This format only supports images with a width that is a multiple of two.
    /// </summary>
    VK_FORMAT_G12X4_B12X4_R12X4_3PLANE_422_UNORM_3PACK16_KHR = VK_FORMAT_G12X4_B12X4_R12X4_3PLANE_422_UNORM_3PACK16,

    /// <summary>
    ///     VK_FORMAT_G12X4_B12X4R12X4_2PLANE_422_UNORM_3PACK16 specifies an unsigned normalized multi-planar format that has a 12-bit G component in the top 12 bits of each 16-bit word of plane 0, and a two-component, 32-bit BR plane 1 consisting of a 12-bit B component in the top 12 bits of the word in bytes 0..1, and a 12-bit R component in the top 12 bits of the word in bytes 2..3, with the bottom 4 bits of each word unused. The horizontal dimension of the BR plane is halved relative to the image dimensions, and each R and B value is shared with the G components for which ⌊iG​×0.5⌋=iB​=iR​. The location of each plane when this image is in linear layout can be determined via
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkGetImageSubresourceLayout.html"> vkGetImageSubresourceLayout </a>
    ///     , using VK_IMAGE_ASPECT_PLANE_0_BIT for the G plane, and VK_IMAGE_ASPECT_PLANE_1_BIT for the BR plane. This format only supports images with a width that is a multiple of two.
    /// </summary>
    VK_FORMAT_G12X4_B12X4R12X4_2PLANE_422_UNORM_3PACK16_KHR = VK_FORMAT_G12X4_B12X4R12X4_2PLANE_422_UNORM_3PACK16,

    /// <summary>
    ///     VK_FORMAT_G12X4_B12X4_R12X4_3PLANE_444_UNORM_3PACK16 specifies an unsigned normalized multi-planar format that has a 12-bit G component in the top 12 bits of each 16-bit word of plane 0, a 12-bit B component in the top 12 bits of each 16-bit word of plane 1, and a 12-bit R component in the top 12 bits of each 16-bit word of plane 2, with the bottom 4 bits of each word unused. Each plane has the same dimensions and each R, G and B component contributes to a single texel. The location of each plane when this image is in linear layout can be determined via
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkGetImageSubresourceLayout.html"> vkGetImageSubresourceLayout </a>
    ///     , using VK_IMAGE_ASPECT_PLANE_0_BIT for the G plane, VK_IMAGE_ASPECT_PLANE_1_BIT for the B plane, and VK_IMAGE_ASPECT_PLANE_2_BIT for the R plane.
    /// </summary>
    VK_FORMAT_G12X4_B12X4_R12X4_3PLANE_444_UNORM_3PACK16_KHR = VK_FORMAT_G12X4_B12X4_R12X4_3PLANE_444_UNORM_3PACK16,

    /// <summary> VK_FORMAT_G16B16G16R16_422_UNORM specifies a four-component, 64-bit format containing a pair of G components, an R component, and a B component, collectively encoding a 2×1 rectangle of unsigned normalized RGB texel data. One G value is present at each i coordinate, with the B and R values shared across both G values and thus recorded at half the horizontal resolution of the image. This format has a 16-bit G component for the even i coordinate in the word in bytes 0..1, a 16-bit B component in the word in bytes 2..3, a 16-bit G component for the odd i coordinate in the word in bytes 4..5, and a 16-bit R component in the word in bytes 6..7. This format only supports images with a width that is a multiple of two. For the purposes of the constraints on copy extents, this format is treated as a compressed format with a 2×1 compressed texel block. </summary>
    VK_FORMAT_G16B16G16R16_422_UNORM_KHR = VK_FORMAT_G16B16G16R16_422_UNORM,

    /// <summary> VK_FORMAT_B16G16R16G16_422_UNORM specifies a four-component, 64-bit format containing a pair of G components, an R component, and a B component, collectively encoding a 2×1 rectangle of unsigned normalized RGB texel data. One G value is present at each i coordinate, with the B and R values shared across both G values and thus recorded at half the horizontal resolution of the image. This format has a 16-bit B component in the word in bytes 0..1, a 16-bit G component for the even i coordinate in the word in bytes 2..3, a 16-bit R component in the word in bytes 4..5, and a 16-bit G component for the odd i coordinate in the word in bytes 6..7. This format only supports images with a width that is a multiple of two. For the purposes of the constraints on copy extents, this format is treated as a compressed format with a 2×1 compressed texel block. </summary>
    VK_FORMAT_B16G16R16G16_422_UNORM_KHR = VK_FORMAT_B16G16R16G16_422_UNORM,

    /// <summary>
    ///     VK_FORMAT_G16_B16_R16_3PLANE_420_UNORM specifies an unsigned normalized multi-planar format that has a 16-bit G component in each 16-bit word of plane 0, a 16-bit B component in each 16-bit word of plane 1, and a 16-bit R component in each 16-bit word of plane 2. The horizontal and vertical dimensions of the R and B planes are halved relative to the image dimensions, and each R and B component is shared with the G components for which ⌊iG​×0.5⌋=iB​=iR​ and ⌊jG​×0.5⌋=jB​=jR​. The location of each plane when this image is in linear layout can be determined via
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkGetImageSubresourceLayout.html"> vkGetImageSubresourceLayout </a>
    ///     , using VK_IMAGE_ASPECT_PLANE_0_BIT for the G plane, VK_IMAGE_ASPECT_PLANE_1_BIT for the B plane, and VK_IMAGE_ASPECT_PLANE_2_BIT for the R plane. This format only supports images with a width and height that is a multiple of two.
    /// </summary>
    VK_FORMAT_G16_B16_R16_3PLANE_420_UNORM_KHR = VK_FORMAT_G16_B16_R16_3PLANE_420_UNORM,

    /// <summary>
    ///     VK_FORMAT_G16_B16R16_2PLANE_420_UNORM specifies an unsigned normalized multi-planar format that has a 16-bit G component in each 16-bit word of plane 0, and a two-component, 32-bit BR plane 1 consisting of a 16-bit B component in the word in bytes 0..1, and a 16-bit R component in the word in bytes 2..3. The horizontal and vertical dimensions of the BR plane are halved relative to the image dimensions, and each R and B value is shared with the G components for which ⌊iG​×0.5⌋=iB​=iR​ and ⌊jG​×0.5⌋=jB​=jR​. The location of each plane when this image is in linear layout can be determined via
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkGetImageSubresourceLayout.html"> vkGetImageSubresourceLayout </a>
    ///     , using VK_IMAGE_ASPECT_PLANE_0_BIT for the G plane, and VK_IMAGE_ASPECT_PLANE_1_BIT for the BR plane. This format only supports images with a width and height that is a multiple of two.
    /// </summary>
    VK_FORMAT_G16_B16R16_2PLANE_420_UNORM_KHR = VK_FORMAT_G16_B16R16_2PLANE_420_UNORM,

    /// <summary>
    ///     VK_FORMAT_G16_B16_R16_3PLANE_422_UNORM specifies an unsigned normalized multi-planar format that has a 16-bit G component in each 16-bit word of plane 0, a 16-bit B component in each 16-bit word of plane 1, and a 16-bit R component in each 16-bit word of plane 2. The horizontal dimension of the R and B plane is halved relative to the image dimensions, and each R and B value is shared with the G components for which ⌊iG​×0.5⌋=iB​=iR​. The location of each plane when this image is in linear layout can be determined via
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkGetImageSubresourceLayout.html"> vkGetImageSubresourceLayout </a>
    ///     , using VK_IMAGE_ASPECT_PLANE_0_BIT for the G plane, VK_IMAGE_ASPECT_PLANE_1_BIT for the B plane, and VK_IMAGE_ASPECT_PLANE_2_BIT for the R plane. This format only supports images with a width that is a multiple of two.
    /// </summary>
    VK_FORMAT_G16_B16_R16_3PLANE_422_UNORM_KHR = VK_FORMAT_G16_B16_R16_3PLANE_422_UNORM,

    /// <summary>
    ///     VK_FORMAT_G16_B16R16_2PLANE_422_UNORM specifies an unsigned normalized multi-planar format that has a 16-bit G component in each 16-bit word of plane 0, and a two-component, 32-bit BR plane 1 consisting of a 16-bit B component in the word in bytes 0..1, and a 16-bit R component in the word in bytes 2..3. The horizontal dimension of the BR plane is halved relative to the image dimensions, and each R and B value is shared with the G components for which ⌊iG​×0.5⌋=iB​=iR​. The location of each plane when this image is in linear layout can be determined via
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkGetImageSubresourceLayout.html"> vkGetImageSubresourceLayout </a>
    ///     , using VK_IMAGE_ASPECT_PLANE_0_BIT for the G plane, and VK_IMAGE_ASPECT_PLANE_1_BIT for the BR plane. This format only supports images with a width that is a multiple of two.
    /// </summary>
    VK_FORMAT_G16_B16R16_2PLANE_422_UNORM_KHR = VK_FORMAT_G16_B16R16_2PLANE_422_UNORM,

    /// <summary>
    ///     VK_FORMAT_G16_B16_R16_3PLANE_444_UNORM specifies an unsigned normalized multi-planar format that has a 16-bit G component in each 16-bit word of plane 0, a 16-bit B component in each 16-bit word of plane 1, and a 16-bit R component in each 16-bit word of plane 2. Each plane has the same dimensions and each R, G and B component contributes to a single texel. The location of each plane when this image is in linear layout can be determined via
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkGetImageSubresourceLayout.html"> vkGetImageSubresourceLayout </a>
    ///     , using VK_IMAGE_ASPECT_PLANE_0_BIT for the G plane, VK_IMAGE_ASPECT_PLANE_1_BIT for the B plane, and VK_IMAGE_ASPECT_PLANE_2_BIT for the R plane.
    /// </summary>
    VK_FORMAT_G16_B16_R16_3PLANE_444_UNORM_KHR = VK_FORMAT_G16_B16_R16_3PLANE_444_UNORM,

    /// <summary>
    ///     VK_FORMAT_G8_B8R8_2PLANE_444_UNORM specifies an unsigned normalized multi-planar format that has an 8-bit G component in plane 0, and a two-component, 16-bit BR plane 1 consisting of an 8-bit B component in byte 0 and an 8-bit R component in byte 1. Both planes have the same dimensions and each R, G and B component contributes to a single texel. The location of each plane when this image is in linear layout can be determined via
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkGetImageSubresourceLayout.html"> vkGetImageSubresourceLayout </a>
    ///     , using VK_IMAGE_ASPECT_PLANE_0_BIT for the G plane, and VK_IMAGE_ASPECT_PLANE_1_BIT for the BR plane.
    /// </summary>
    VK_FORMAT_G8_B8R8_2PLANE_444_UNORM_EXT = VK_FORMAT_G8_B8R8_2PLANE_444_UNORM,

    /// <summary>
    ///     VK_FORMAT_G10X6_B10X6R10X6_2PLANE_444_UNORM_3PACK16 specifies an unsigned normalized multi-planar format that has a 10-bit G component in the top 10 bits of each 16-bit word of plane 0, and a two-component, 32-bit BR plane 1 consisting of a 10-bit B component in the top 10 bits of the word in bytes 0..1, and a 10-bit R component in the top 10 bits of the word in bytes 2..3, the bottom 6 bits of each word unused. Both planes have the same dimensions and each R, G and B component contributes to a single texel. The location of each plane when this image is in linear layout can be determined via
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkGetImageSubresourceLayout.html"> vkGetImageSubresourceLayout </a>
    ///     , using VK_IMAGE_ASPECT_PLANE_0_BIT for the G plane, and VK_IMAGE_ASPECT_PLANE_1_BIT for the BR plane.
    /// </summary>
    VK_FORMAT_G10X6_B10X6R10X6_2PLANE_444_UNORM_3PACK16_EXT = VK_FORMAT_G10X6_B10X6R10X6_2PLANE_444_UNORM_3PACK16,

    /// <summary>
    ///     VK_FORMAT_G12X4_B12X4R12X4_2PLANE_444_UNORM_3PACK16 specifies an unsigned normalized multi-planar format that has a 12-bit G component in the top 12 bits of each 16-bit word of plane 0, and a two-component, 32-bit BR plane 1 consisting of a 12-bit B component in the top 12 bits of the word in bytes 0..1, and a 12-bit R component in the top 12 bits of the word in bytes 2..3, the bottom 4 bits of each word unused. Both planes have the same dimensions and each R, G and B component contributes to a single texel. The location of each plane when this image is in linear layout can be determined via
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkGetImageSubresourceLayout.html"> vkGetImageSubresourceLayout </a>
    ///     , using VK_IMAGE_ASPECT_PLANE_0_BIT for the G plane, and VK_IMAGE_ASPECT_PLANE_1_BIT for the BR plane.
    /// </summary>
    VK_FORMAT_G12X4_B12X4R12X4_2PLANE_444_UNORM_3PACK16_EXT = VK_FORMAT_G12X4_B12X4R12X4_2PLANE_444_UNORM_3PACK16,

    /// <summary>
    ///     VK_FORMAT_G16_B16R16_2PLANE_444_UNORM specifies an unsigned normalized multi-planar format that has a 16-bit G component in each 16-bit word of plane 0, and a two-component, 32-bit BR plane 1 consisting of a 16-bit B component in the word in bytes 0..1, and a 16-bit R component in the word in bytes 2..3. Both planes have the same dimensions and each R, G and B component contributes to a single texel. The location of each plane when this image is in linear layout can be determined via
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkGetImageSubresourceLayout.html"> vkGetImageSubresourceLayout </a>
    ///     , using VK_IMAGE_ASPECT_PLANE_0_BIT for the G plane, and VK_IMAGE_ASPECT_PLANE_1_BIT for the BR plane.
    /// </summary>
    VK_FORMAT_G16_B16R16_2PLANE_444_UNORM_EXT = VK_FORMAT_G16_B16R16_2PLANE_444_UNORM,

    /// <summary> VK_FORMAT_A4R4G4B4_UNORM_PACK16 specifies a four-component, 16-bit packed unsigned normalized format that has a 4-bit A component in bits 12..15, a 4-bit R component in bits 8..11, a 4-bit G component in bits 4..7, and a 4-bit B component in bits 0..3. </summary>
    VK_FORMAT_A4R4G4B4_UNORM_PACK16_EXT = VK_FORMAT_A4R4G4B4_UNORM_PACK16,

    /// <summary> VK_FORMAT_A4B4G4R4_UNORM_PACK16 specifies a four-component, 16-bit packed unsigned normalized format that has a 4-bit A component in bits 12..15, a 4-bit B component in bits 8..11, a 4-bit G component in bits 4..7, and a 4-bit R component in bits 0..3. </summary>
    VK_FORMAT_A4B4G4R4_UNORM_PACK16_EXT = VK_FORMAT_A4B4G4R4_UNORM_PACK16
}