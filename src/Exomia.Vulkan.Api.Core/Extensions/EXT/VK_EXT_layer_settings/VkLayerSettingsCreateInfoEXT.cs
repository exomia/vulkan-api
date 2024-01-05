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
///     VkLayerSettingsCreateInfoEXT - Specify layer capabilities for a Vulkan instance -
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkLayerSettingsCreateInfoEXT.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkLayerSettingsCreateInfoEXT.html</a>
/// </summary>
/// <remarks>
///     <list type="table">
///         <item>
///             <term>structextends</term><description>VkInstanceCreateInfo</description>
///         </item>
///     </list>
/// </remarks>
[VkStructExtends("VkInstanceCreateInfo")]
[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkLayerSettingsCreateInfoEXT
{
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_LAYER_SETTINGS_CREATE_INFO_EXT;

    /// <summary>sType is a VkStructureType value identifying this structure.</summary>
    public VkStructureType sType;

    /// <summary>pNext is NULL or a pointer to a structure extending this structure.</summary>
    public void* pNext;

    /// <summary>settingCount is the number of settings to configure.</summary>
    public uint settingCount;

    /// <summary>
    ///     pSettings is a pointer to an array of settingCountVkLayerSettingEXT values specifying the setting to be
    ///     configured.
    /// </summary>
    public VkLayerSettingEXT* pSettings;
}