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
namespace Exomia.Vulkan.Api.Core;

/// <summary>
///     VkLayerSettingEXT - Specify a layer capability to configure -
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkLayerSettingEXT.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkLayerSettingEXT.html</a>
/// </summary>
[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkLayerSettingEXT
{
    /// <summary>pLayerName is a pointer to a null-terminated UTF-8 string naming the layer to configure the setting from.</summary>
    public byte* pLayerName;

    /// <summary>
    ///     pSettingName is a pointer to a null-terminated UTF-8 string naming the setting to configure. Unknown
    ///     pSettingName by the layer are ignored.
    /// </summary>
    public byte* pSettingName;

    /// <summary>type is a VkLayerSettingTypeEXT value specifying the type of the pValues values.</summary>
    public VkLayerSettingTypeEXT type;

    /// <summary>
    ///     valueCount<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkLayerSettingEXT">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkLayerSettingEXT</a>
    /// </summary>
    public uint valueCount;

    /// <summary>pValues is a pointer to an array of count values of the type indicated by type to configure the layer setting.</summary>
    public void* pValues;
}