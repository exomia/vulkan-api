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
namespace Exomia.Vulkan.Api.Screen;

/// <summary>
///     VkScreenBufferFormatPropertiesQNX - Structure describing the image format properties of a QNX Screen buffer -
///     <a
///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkScreenBufferFormatPropertiesQNX.html">
///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkScreenBufferFormatPropertiesQNX.html
///     </a>
/// </summary>
/// <remarks>
///     <list type="table">
///         <item>
///             <term>structextends</term><description>VkScreenBufferPropertiesQNX</description>
///         </item>
///         <item>
///             <term>returnedonly</term><description>true</description>
///         </item>
///     </list>
/// </remarks>
[VkStructExtends("VkScreenBufferPropertiesQNX")]
[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkScreenBufferFormatPropertiesQNX
{
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_SCREEN_BUFFER_FORMAT_PROPERTIES_QNX;

    /// <summary>sType is a VkStructureType value identifying this structure.</summary>
    public VkStructureType sType;

    /// <summary>pNext is NULL or a pointer to a structure extending this structure.</summary>
    public void* pNext;

    /// <summary>
    ///     format is the Vulkan format corresponding to the Screen buffer&#8217;s format or VK_FORMAT_UNDEFINED if there
    ///     is not an equivalent Vulkan format.
    /// </summary>
    public VkFormat format;

    /// <summary>
    ///     externalFormat is an implementation-defined external format identifier for use with VkExternalFormatQNX. It
    ///     must not be zero.
    /// </summary>
    public ulong externalFormat;

    /// <summary>screenUsage is an implementation-defined external usage identifier for the QNX Screen buffer.</summary>
    public ulong screenUsage;

    /// <summary>
    ///     formatFeatures describes the capabilities of this external format when used with an image bound to memory
    ///     imported from buffer.
    /// </summary>
    public VkFormatFeatureFlags formatFeatures;

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