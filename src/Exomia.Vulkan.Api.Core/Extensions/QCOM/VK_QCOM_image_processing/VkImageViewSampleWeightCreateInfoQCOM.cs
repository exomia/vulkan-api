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
///     VkImageViewSampleWeightCreateInfoQCOM - Structure describing weight sampling parameters for image view -
///     <a
///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkImageViewSampleWeightCreateInfoQCOM.html">
///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkImageViewSampleWeightCreateInfoQCOM.html
///     </a>
/// </summary>
/// <remarks>
///     <list type="table">
///         <item>
///             <term>structextends</term><description>VkImageViewCreateInfo</description>
///         </item>
///     </list>
/// </remarks>
[VkStructExtends("VkImageViewCreateInfo")]
[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkImageViewSampleWeightCreateInfoQCOM
{
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_IMAGE_VIEW_SAMPLE_WEIGHT_CREATE_INFO_QCOM;

    /// <summary>sType is a VkStructureType value identifying this structure.</summary>
    public VkStructureType sType;

    /// <summary>pNext is NULL or a pointer to a structure extending this structure.</summary>
    public void* pNext;

    /// <summary>filterCenter is a VkOffset2D describing the location of the weight filter origin.</summary>
    public VkOffset2D filterCenter;

    /// <summary>filterSize is a VkExtent2D specifying weight filter dimensions.</summary>
    public VkExtent2D filterSize;

    /// <summary>numPhases is number of sub-pixel filter phases.</summary>
    public uint numPhases;
}