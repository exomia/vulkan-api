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
namespace Exomia.Vulkan.Api.Android;

/// <summary>
///     VkAndroidHardwareBufferFormatProperties2ANDROID - Structure describing the image format properties of an Android
///     hardware buffer -
///     <a
///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkAndroidHardwareBufferFormatProperties2ANDROID.html">
///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkAndroidHardwareBufferFormatProperties2ANDROID.html
///     </a>
/// </summary>
/// <remarks>
///     <list type="table">
///         <item>
///             <term>structextends</term><description>VkAndroidHardwareBufferPropertiesANDROID</description>
///         </item>
///         <item>
///             <term>returnedonly</term><description>true</description>
///         </item>
///     </list>
/// </remarks>
[VkStructExtends("VkAndroidHardwareBufferPropertiesANDROID")]
[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkAndroidHardwareBufferFormatProperties2ANDROID
{
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_ANDROID_HARDWARE_BUFFER_FORMAT_PROPERTIES_2_ANDROID;

    /// <summary>sType is the type of this structure.</summary>
    public VkStructureType sType;

    /// <summary>pNext is NULL or a pointer to a structure extending this structure.</summary>
    public void* pNext;

    /// <summary>
    ///     format is the Vulkan format corresponding to the Android hardware buffer&#8217;s format, or
    ///     VK_FORMAT_UNDEFINED if there is not an equivalent Vulkan format.
    /// </summary>
    public VkFormat format;

    /// <summary>
    ///     externalFormat is an implementation-defined external format identifier for use with VkExternalFormatANDROID.
    ///     It must not be zero.
    /// </summary>
    public ulong externalFormat;

    /// <summary>
    ///     formatFeatures describes the capabilities of this external format when used with an image bound to memory
    ///     imported from buffer.
    /// </summary>
    public VkFormatFeatureFlags2 formatFeatures;

    /// <summary>
    ///     samplerYcbcrConversionComponents is the component swizzle that should be used in
    ///     VkSamplerYcbcrConversionCreateInfo.
    /// </summary>
    public VkComponentMapping samplerYcbcrConversionComponents;

    /// <summary>suggestedYcbcrModel is a suggested color model to use in the VkSamplerYcbcrConversionCreateInfo.</summary>
    public VkSamplerYcbcrModelConversion suggestedYcbcrModel;

    /// <summary>suggestedYcbcrRange is a suggested numerical value range to use in VkSamplerYcbcrConversionCreateInfo.</summary>
    public VkSamplerYcbcrRange suggestedYcbcrRange;

    /// <summary>suggestedXChromaOffset is a suggested X chroma offset to use in VkSamplerYcbcrConversionCreateInfo.</summary>
    public VkChromaLocation suggestedXChromaOffset;

    /// <summary>suggestedYChromaOffset is a suggested Y chroma offset to use in VkSamplerYcbcrConversionCreateInfo.</summary>
    public VkChromaLocation suggestedYChromaOffset;
}