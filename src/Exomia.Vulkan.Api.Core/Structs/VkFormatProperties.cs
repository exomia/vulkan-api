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
///     VkFormatProperties - Structure specifying image format properties -
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkFormatProperties.html"> https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkFormatProperties.html </a>
/// </summary>
/// <remarks>
///     <list type="table">
///         <item>
///             <term> returnedonly </term><description> true </description>
///         </item>
///     </list>
/// </remarks>
[StructLayout(LayoutKind.Sequential)]
public struct VkFormatProperties
{
    /// <summary> linearTilingFeatures is a bitmask of VkFormatFeatureFlagBitsspecifying features supported by images created with a tilingparameter of VK_IMAGE_TILING_LINEAR. </summary>
    public VkFormatFeatureFlags linearTilingFeatures;

    /// <summary> optimalTilingFeatures is a bitmask of VkFormatFeatureFlagBits specifying features supported by images created with a tiling parameter of VK_IMAGE_TILING_OPTIMAL. </summary>
    public VkFormatFeatureFlags optimalTilingFeatures;

    /// <summary> bufferFeatures is a bitmask of VkFormatFeatureFlagBitsspecifying features supported by buffers. </summary>
    public VkFormatFeatureFlags bufferFeatures;
}