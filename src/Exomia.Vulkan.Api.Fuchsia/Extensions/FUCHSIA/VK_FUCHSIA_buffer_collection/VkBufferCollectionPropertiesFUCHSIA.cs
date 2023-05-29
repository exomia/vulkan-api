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
namespace Exomia.Vulkan.Api.Fuchsia;

/// <summary>
///     VkBufferCollectionPropertiesFUCHSIA - Structure specifying the negotiated format chosen by Sysmem -
///     <a
///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkBufferCollectionPropertiesFUCHSIA.html">
///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkBufferCollectionPropertiesFUCHSIA.html
///     </a>
/// </summary>
[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkBufferCollectionPropertiesFUCHSIA
{
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_BUFFER_COLLECTION_PROPERTIES_FUCHSIA;

    /// <summary>sType is the type of this structure.</summary>
    public VkStructureType sType;

    /// <summary>pNext is NULL or a pointer to a structure extending this structure</summary>
    public void* pNext;

    /// <summary>
    ///     memoryTypeBits is a bitmask containing one bit set for every memory type which the buffer collection can be
    ///     imported as buffer collection
    /// </summary>
    public uint memoryTypeBits;

    /// <summary>bufferCount is the number of buffers in the collection</summary>
    public uint bufferCount;

    /// <summary>createInfoIndex as described in Sysmem chosen create infos</summary>
    public uint createInfoIndex;

    /// <summary>sysmemPixelFormat is the Sysmem PixelFormatType as defined in fuchsia.sysmem/image_formats.fidl</summary>
    public ulong sysmemPixelFormat;

    /// <summary>formatFeatures is a bitmask of VkFormatFeatureFlagBitsshared by the buffer collection</summary>
    public VkFormatFeatureFlags formatFeatures;

    /// <summary>sysmemColorSpaceIndex is a VkSysmemColorSpaceFUCHSIA struct specifying the color space</summary>
    public VkSysmemColorSpaceFUCHSIA sysmemColorSpaceIndex;

    /// <summary>samplerYcbcrConversionComponents is a VkComponentMappingstruct specifying the component mapping</summary>
    public VkComponentMapping samplerYcbcrConversionComponents;

    /// <summary>suggestedYcbcrModel is a VkSamplerYcbcrModelConversion value specifying the suggested Y′CBCR model</summary>
    public VkSamplerYcbcrModelConversion suggestedYcbcrModel;

    /// <summary>suggestedYcbcrRange is a VkSamplerYcbcrRange value specifying the suggested Y′CBCR range</summary>
    public VkSamplerYcbcrRange suggestedYcbcrRange;

    /// <summary>suggestedXChromaOffset is a VkChromaLocation value specifying the suggested X chroma offset</summary>
    public VkChromaLocation suggestedXChromaOffset;

    /// <summary>suggestedYChromaOffset is a VkChromaLocation value specifying the suggested Y chroma offset</summary>
    public VkChromaLocation suggestedYChromaOffset;
}