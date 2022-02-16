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
///     VkDrmFormatModifierProperties2EXT - Structure specifying properties of a format when combined with a DRM
///     format modifier -
///     <a
///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkDrmFormatModifierProperties2EXT.html">
///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkDrmFormatModifierProperties2EXT.html
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
public struct VkDrmFormatModifierProperties2EXT
{
    /// <summary>drmFormatModifier is a Linux DRM format modifier.</summary>
    public ulong drmFormatModifier;

    /// <summary>
    ///     drmFormatModifierPlaneCount is the number of memory planes in any image created with format and
    ///     drmFormatModifier. An image&#8217;s memory planecount is distinct from its format planecount, as explained below.
    /// </summary>
    public uint drmFormatModifierPlaneCount;

    /// <summary>
    ///     drmFormatModifierTilingFeatures is a bitmask of VkFormatFeatureFlagBits2 that are supported by any image
    ///     created with format and drmFormatModifier.
    /// </summary>
    public VkFormatFeatureFlags2 drmFormatModifierTilingFeatures;
}