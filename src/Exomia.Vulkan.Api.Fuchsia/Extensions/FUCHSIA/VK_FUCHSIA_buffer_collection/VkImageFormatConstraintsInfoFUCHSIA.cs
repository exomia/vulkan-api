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
namespace Exomia.Vulkan.Api.Fuchsia;

/// <summary>
///     VkImageFormatConstraintsInfoFUCHSIA - Structure image-based buffer collection constraints -
///     <a
///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkImageFormatConstraintsInfoFUCHSIA.html">
///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkImageFormatConstraintsInfoFUCHSIA.html
///     </a>
/// </summary>
[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkImageFormatConstraintsInfoFUCHSIA
{
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_IMAGE_FORMAT_CONSTRAINTS_INFO_FUCHSIA;

    /// <summary>sType is the type of this structure</summary>
    public VkStructureType sType;

    /// <summary>pNext is NULL or a pointer to a structure extending this structure</summary>
    public void* pNext;

    /// <summary>
    ///     imageCreateInfo is the VkImageCreateInfo used to create a VkImage that is to use memory from the
    ///     VkBufferCollectionFUCHSIA
    /// </summary>
    public VkImageCreateInfo imageCreateInfo;

    /// <summary>
    ///     requiredFormatFeatures is a bitmask of VkFormatFeatureFlagBits specifying required features of the buffers in
    ///     the buffer collection
    /// </summary>
    public VkFormatFeatureFlags requiredFormatFeatures;

    /// <summary>flags is reserved for future use</summary>
    public VkImageFormatConstraintsFlagsFUCHSIA flags;

    /// <summary>sysmemPixelFormat is a PixelFormatType value from the fuchsia.sysmem/image_formats.fidl FIDL interface</summary>
    public ulong sysmemPixelFormat;

    /// <summary>colorSpaceCount the element count of pColorSpaces</summary>
    public uint colorSpaceCount;

    /// <summary>pColorSpaces is a pointer to an array of VkSysmemColorSpaceFUCHSIA structs of size colorSpaceCount</summary>
    public VkSysmemColorSpaceFUCHSIA* pColorSpaces;
}