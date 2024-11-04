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
///     VkHdrVividDynamicMetadataHUAWEI - specify HDR Vivid dynamic metadata -
///     <a
///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkHdrVividDynamicMetadataHUAWEI.html">
///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkHdrVividDynamicMetadataHUAWEI.html
///     </a>
/// </summary>
/// <remarks>
///     <list type="table">
///         <item>
///             <term>structextends</term><description>VkHdrMetadataEXT</description>
///         </item>
///     </list>
/// </remarks>
[VkStructExtends("VkHdrMetadataEXT")]
[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkHdrVividDynamicMetadataHUAWEI
{
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_HDR_VIVID_DYNAMIC_METADATA_HUAWEI;

    /// <summary>sType is a VkStructureType value identifying this structure.</summary>
    public VkStructureType sType;

    /// <summary>pNext is NULL or a pointer to a structure extending this structure.</summary>
    public void* pNext;

    /// <summary>dynamicMetadataSize is the size in bytes of the dynamic metadata.</summary>
    public nuint dynamicMetadataSize;

    /// <summary>pDynamicMetadata is a pointer to the dynamic metadata.</summary>
    public void* pDynamicMetadata;
}