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
///     VkOpticalFlowImageFormatInfoNV - Structure describing optical flow image format info -
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkOpticalFlowImageFormatInfoNV.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkOpticalFlowImageFormatInfoNV.html</a>
/// </summary>
/// <remarks>
///     <list type="table">
///         <item>
///             <term>structextends</term><description>VkPhysicalDeviceImageFormatInfo2,VkImageCreateInfo</description>
///         </item>
///     </list>
/// </remarks>
[VkStructExtends("VkPhysicalDeviceImageFormatInfo2,VkImageCreateInfo")]
[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkOpticalFlowImageFormatInfoNV
{
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_OPTICAL_FLOW_IMAGE_FORMAT_INFO_NV;

    /// <summary>sType is the type of this structure.</summary>
    public VkStructureType sType;

    /// <summary>pNext is NULL or a pointer to a structure extending this structure.</summary>
    public void* pNext;

    /// <summary> usage is a bitmask of VkOpticalFlowUsageFlagBitsNV describing the intended optical flow usage of the image.</summary>
    public VkOpticalFlowUsageFlagsNV usage;
}