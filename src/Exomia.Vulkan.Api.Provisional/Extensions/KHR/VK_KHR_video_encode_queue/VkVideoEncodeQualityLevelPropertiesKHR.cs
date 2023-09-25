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
namespace Exomia.Vulkan.Api.Provisional;

/// <summary>
///     VkVideoEncodeQualityLevelPropertiesKHR - Structure describing the video encode quality level properties -
///     <a
///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkVideoEncodeQualityLevelPropertiesKHR.html">
///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkVideoEncodeQualityLevelPropertiesKHR.html
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
public unsafe struct VkVideoEncodeQualityLevelPropertiesKHR
{
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_VIDEO_ENCODE_QUALITY_LEVEL_PROPERTIES_KHR;

    /// <summary>sType is a VkStructureType value identifying this structure.</summary>
    public VkStructureType sType;

    /// <summary>pNext is NULL or a pointer to a structure extending this structure.</summary>
    public void* pNext;

    /// <summary>
    ///     preferredRateControlMode is a VkVideoEncodeRateControlModeFlagBitsKHR value indicating the preferred rate
    ///     control mode to use with the video encode quality level.
    /// </summary>
    public VkVideoEncodeRateControlModeFlagBitsKHR preferredRateControlMode;

    /// <summary>
    ///     preferredRateControlLayerCount indicates the preferred number of rate control layers to use with the quality
    ///     level.
    /// </summary>
    public uint preferredRateControlLayerCount;
}