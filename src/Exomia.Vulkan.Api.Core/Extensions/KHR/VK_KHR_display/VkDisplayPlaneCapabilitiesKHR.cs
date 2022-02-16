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
///     VkDisplayPlaneCapabilitiesKHR - Structure describing capabilities of a mode and plane combination -
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkDisplayPlaneCapabilitiesKHR.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkDisplayPlaneCapabilitiesKHR.html</a>
/// </summary>
/// <remarks>
///     <list type="table">
///         <item>
///             <term>returnedonly</term><description>true</description>
///         </item>
///     </list>
/// </remarks>
[StructLayout(LayoutKind.Sequential)]
public struct VkDisplayPlaneCapabilitiesKHR
{
    /// <summary>supportedAlpha is a bitmask of VkDisplayPlaneAlphaFlagBitsKHR describing the supported alpha blending modes.</summary>
    public VkDisplayPlaneAlphaFlagsKHR supportedAlpha;

    /// <summary>minSrcPosition is the minimum source rectangle offset supported by this plane using the specified mode.</summary>
    public VkOffset2D minSrcPosition;

    /// <summary>
    ///     maxSrcPosition is the maximum source rectangle offset supported by this plane using the specified mode. The x
    ///     and y components of maxSrcPosition must each be greater than or equal to the x and y components of minSrcPosition,
    ///     respectively.
    /// </summary>
    public VkOffset2D maxSrcPosition;

    /// <summary>minSrcExtent is the minimum source rectangle size supported by this plane using the specified mode.</summary>
    public VkExtent2D minSrcExtent;

    /// <summary>maxSrcExtent is the maximum source rectangle size supported by this plane using the specified mode.</summary>
    public VkExtent2D maxSrcExtent;

    /// <summary>
    ///     minDstPosition, maxDstPosition, minDstExtent, maxDstExtent all have similar semantics to their corresponding
    ///     *Src* equivalents, but apply to the output region within the mode rather than the input region within the source
    ///     image. Unlike the *Src* offsets, minDstPosition and maxDstPosition may contain negative values.
    /// </summary>
    public VkOffset2D minDstPosition;

    /// <summary>
    ///     minDstPosition, maxDstPosition, minDstExtent, maxDstExtent all have similar semantics to their corresponding
    ///     *Src* equivalents, but apply to the output region within the mode rather than the input region within the source
    ///     image. Unlike the *Src* offsets, minDstPosition and maxDstPosition may contain negative values.
    /// </summary>
    public VkOffset2D maxDstPosition;

    /// <summary>
    ///     minDstPosition, maxDstPosition, minDstExtent, maxDstExtent all have similar semantics to their corresponding
    ///     *Src* equivalents, but apply to the output region within the mode rather than the input region within the source
    ///     image. Unlike the *Src* offsets, minDstPosition and maxDstPosition may contain negative values.
    /// </summary>
    public VkExtent2D minDstExtent;

    /// <summary>
    ///     minDstPosition, maxDstPosition, minDstExtent, maxDstExtent all have similar semantics to their corresponding
    ///     *Src* equivalents, but apply to the output region within the mode rather than the input region within the source
    ///     image. Unlike the *Src* offsets, minDstPosition and maxDstPosition may contain negative values.
    /// </summary>
    public VkExtent2D maxDstExtent;
}