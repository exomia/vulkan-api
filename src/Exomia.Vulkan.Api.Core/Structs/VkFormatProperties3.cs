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
///     VkFormatProperties3 - Structure specifying image format properties -
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkFormatProperties3.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkFormatProperties3.html</a>
/// </summary>
/// <remarks>
///     <list type="table">
///         <item>
///             <term>structextends</term><description>VkFormatProperties2</description>
///         </item>
///         <item>
///             <term>returnedonly</term><description>true</description>
///         </item>
///     </list>
/// </remarks>
[VkStructExtends("VkFormatProperties2")]
[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkFormatProperties3
{
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_FORMAT_PROPERTIES_3;

    /// <summary>
    ///     sType<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkFormatProperties3">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkFormatProperties3</a>
    /// </summary>
    public VkStructureType sType;

    /// <summary>pNext is NULL or a pointer to a structure extending this structure.</summary>
    public void* pNext;

    /// <summary>
    ///     linearTilingFeatures is a bitmask of VkFormatFeatureFlagBits2 specifying features supported by images created
    ///     with a tiling parameter of VK_IMAGE_TILING_LINEAR.
    /// </summary>
    public VkFormatFeatureFlags2 linearTilingFeatures;

    /// <summary>
    ///     optimalTilingFeatures is a bitmask of VkFormatFeatureFlagBits2 specifying features supported by images created
    ///     with a tiling parameter of VK_IMAGE_TILING_OPTIMAL.
    /// </summary>
    public VkFormatFeatureFlags2 optimalTilingFeatures;

    /// <summary>bufferFeatures is a bitmask of VkFormatFeatureFlagBits2specifying features supported by buffers.</summary>
    public VkFormatFeatureFlags2 bufferFeatures;
}