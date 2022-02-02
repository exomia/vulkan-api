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
///     VkExternalImageFormatPropertiesNV - Structure specifying external image format properties -
///     <a
///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkExternalImageFormatPropertiesNV.html">
///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkExternalImageFormatPropertiesNV.html
///     </a>
/// </summary>
/// <remarks>
///     <list type="table">
///         <item>
///             <term>returnedonly</term><description>true</description>
///         </item>
///     </list>
/// </remarks>
[StructLayout(LayoutKind.Sequential)]
public struct VkExternalImageFormatPropertiesNV
{
    /// <summary>
    ///     imageFormatProperties will be filled in as when calling vkGetPhysicalDeviceImageFormatProperties, but the
    ///     values returned may vary depending on the external handle type requested.
    /// </summary>
    public VkImageFormatProperties imageFormatProperties;

    /// <summary>
    ///     externalMemoryFeatures is a bitmask of VkExternalMemoryFeatureFlagBitsNV, indicating properties of the
    ///     external memory handle type (vkGetPhysicalDeviceExternalImageFormatPropertiesNV::externalHandleType) being queried,
    ///     or 0 if the external memory handle type is 0.
    /// </summary>
    public VkExternalMemoryFeatureFlagsNV externalMemoryFeatures;

    /// <summary>
    ///     exportFromImportedHandleTypes is a bitmask of VkExternalMemoryHandleTypeFlagBitsNV containing a bit set for
    ///     every external handle type that may be used to create memory from which the handles of the type specified in
    ///     vkGetPhysicalDeviceExternalImageFormatPropertiesNV::externalHandleTypecan be exported, or 0 if the external memory
    ///     handle type is 0.
    /// </summary>
    public VkExternalMemoryHandleTypeFlagsNV exportFromImportedHandleTypes;

    /// <summary>
    ///     compatibleHandleTypes is a bitmask of VkExternalMemoryHandleTypeFlagBitsNV containing a bit set for every
    ///     external handle type that may be specified simultaneously with the handle type specified by
    ///     vkGetPhysicalDeviceExternalImageFormatPropertiesNV::externalHandleTypewhen calling vkAllocateMemory, or 0 if the
    ///     external memory handle type is 0. compatibleHandleTypes will always contain
    ///     vkGetPhysicalDeviceExternalImageFormatPropertiesNV::externalHandleType
    /// </summary>
    public VkExternalMemoryHandleTypeFlagsNV compatibleHandleTypes;
}