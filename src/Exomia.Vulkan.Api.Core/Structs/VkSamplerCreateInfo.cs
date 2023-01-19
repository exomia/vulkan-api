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
///     VkSamplerCreateInfo - Structure specifying parameters of a newly created sampler -
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkSamplerCreateInfo.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkSamplerCreateInfo.html</a>
/// </summary>
[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkSamplerCreateInfo
{
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_SAMPLER_CREATE_INFO;

    /// <summary>sType is the type of this structure.</summary>
    public VkStructureType sType;

    /// <summary>pNext is NULL or a pointer to a structure extending this structure.</summary>
    public void* pNext;

    /// <summary>flags is a bitmask of VkSamplerCreateFlagBits describing additional parameters of the sampler.</summary>
    public VkSamplerCreateFlags flags;

    /// <summary>magFilter is a VkFilter value specifying the magnification filter to apply to lookups.</summary>
    public VkFilter magFilter;

    /// <summary>minFilter is a VkFilter value specifying the minification filter to apply to lookups.</summary>
    public VkFilter minFilter;

    /// <summary>mipmapMode is a VkSamplerMipmapMode value specifying the mipmap filter to apply to lookups.</summary>
    public VkSamplerMipmapMode mipmapMode;

    /// <summary>addressModeU is a VkSamplerAddressMode value specifying the addressing mode for U coordinates outside [0,1).</summary>
    public VkSamplerAddressMode addressModeU;

    /// <summary>addressModeV is a VkSamplerAddressMode value specifying the addressing mode for V coordinates outside [0,1).</summary>
    public VkSamplerAddressMode addressModeV;

    /// <summary>addressModeW is a VkSamplerAddressMode value specifying the addressing mode for W coordinates outside [0,1).</summary>
    public VkSamplerAddressMode addressModeW;

    /// <summary>
    ///     mipLodBias is the bias to be added to mipmap LOD (level-of-detail) calculation and bias provided by image
    ///     sampling functions in SPIR-V, as described in the Level-of-Detail Operationsection.
    /// </summary>
    public float mipLodBias;

    /// <summary>
    ///     anisotropyEnable is VK_TRUE to enable anisotropic filtering, as described in the Texel Anisotropic
    ///     Filteringsection, or VK_FALSE otherwise.
    /// </summary>
    public VkBool32 anisotropyEnable;

    /// <summary>
    ///     maxAnisotropy is the anisotropy value clamp used by the sampler when anisotropyEnable is VK_TRUE. If
    ///     anisotropyEnable is VK_FALSE, maxAnisotropy is ignored.
    /// </summary>
    public float maxAnisotropy;

    /// <summary>
    ///     compareEnable is VK_TRUE to enable comparison against a reference value during lookups, or VK_FALSE
    ///     otherwise.Note: Some implementations will default to shader state if this member does not match.
    /// </summary>
    public VkBool32 compareEnable;

    /// <summary>
    ///     compareOp is a VkCompareOp value specifying the comparison operator to apply to fetched data before filtering
    ///     as described in the Depth Compare Operation section.
    /// </summary>
    public VkCompareOp compareOp;

    /// <summary>minLod is used to clamp the minimum of the computed LOD value.</summary>
    public float minLod;

    /// <summary>
    ///     maxLod is used to clamp the maximum of the computed LOD value. To avoid clamping the maximum value, set maxLod
    ///     to the constant VK_LOD_CLAMP_NONE.
    /// </summary>
    public float maxLod;

    /// <summary>borderColor is a VkBorderColor value specifying the predefined border color to use.</summary>
    public VkBorderColor borderColor;

    /// <summary>
    ///     unnormalizedCoordinatescontrols whether to use unnormalized or normalized texel coordinates to address texels
    ///     of the image. When set to VK_TRUE, the range of the image coordinates used to lookup the texel is in the range of
    ///     zero to the image size in each dimension. When set to VK_FALSE the range of image coordinates is zero to one.When
    ///     unnormalizedCoordinates is VK_TRUE, images the sampler is used with in the shader have the following
    ///     requirements:The viewType must be either VK_IMAGE_VIEW_TYPE_1D or VK_IMAGE_VIEW_TYPE_2D.The image view must have a
    ///     single layer and a single mip level.When unnormalizedCoordinates is VK_TRUE, image built-in functions in the shader
    ///     that use the sampler have the following requirements:The functions must not use projection.The functions must not
    ///     use offsets.
    /// </summary>
    public VkBool32 unnormalizedCoordinates;
}