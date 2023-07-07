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
namespace Exomia.Vulkan.Api.Core;

/// <summary>
///     VkSubpassFragmentDensityMapOffsetEndInfoQCOM - Structure specifying fragment density map offset subpass end
///     information -
///     <a
///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkSubpassFragmentDensityMapOffsetEndInfoQCOM.html">
///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkSubpassFragmentDensityMapOffsetEndInfoQCOM.html
///     </a>
/// </summary>
/// <remarks>
///     <list type="table">
///         <item>
///             <term>structextends</term><description>VkSubpassEndInfo</description>
///         </item>
///     </list>
/// </remarks>
[VkStructExtends("VkSubpassEndInfo")]
[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkSubpassFragmentDensityMapOffsetEndInfoQCOM
{
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_SUBPASS_FRAGMENT_DENSITY_MAP_OFFSET_END_INFO_QCOM;

    /// <summary>sType is a VkStructureType value identifying this structure.</summary>
    public VkStructureType sType;

    /// <summary>pNext is NULL or a pointer to a structure extending this structure.</summary>
    public void* pNext;

    /// <summary>fragmentDensityOffsetCount is the number of offsets being specified.</summary>
    public uint fragmentDensityOffsetCount;

    /// <summary>
    ///     pFragmentDensityOffsets is a pointer to an array of VkOffset2D structs, each of which describes the offset per
    ///     layer.
    /// </summary>
    public VkOffset2D* pFragmentDensityOffsets;
}