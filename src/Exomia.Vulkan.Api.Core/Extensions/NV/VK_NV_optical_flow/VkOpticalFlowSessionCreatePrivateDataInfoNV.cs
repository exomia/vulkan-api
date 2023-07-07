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
///     VkOpticalFlowSessionCreatePrivateDataInfoNV - Structure for NV internal use only -
///     <a
///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkOpticalFlowSessionCreatePrivateDataInfoNV.html">
///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkOpticalFlowSessionCreatePrivateDataInfoNV.html
///     </a>
/// </summary>
/// <remarks>
///     <list type="table">
///         <item>
///             <term>structextends</term><description>VkOpticalFlowSessionCreateInfoNV</description>
///         </item>
///     </list>
/// </remarks>
[VkStructExtends("VkOpticalFlowSessionCreateInfoNV")]
[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkOpticalFlowSessionCreatePrivateDataInfoNV
{
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_OPTICAL_FLOW_SESSION_CREATE_PRIVATE_DATA_INFO_NV;

    /// <summary>sType is a VkStructureType value identifying this structure.</summary>
    public VkStructureType sType;

    /// <summary>pNext is NULL or a pointer to a structure extending this structure.</summary>
    public void* pNext;

    /// <summary>
    ///     id is an identifier for data which is passed at a memory location specified in
    ///     VkOpticalFlowSessionCreatePrivateDataInfoNV::pPrivateData.
    /// </summary>
    public uint id;

    /// <summary>
    ///     size is the size of data in bytes which is passed at a memory location specified in
    ///     VkOpticalFlowSessionCreatePrivateDataInfoNV::pPrivateData.
    /// </summary>
    public uint size;

    /// <summary>pPrivateData is a pointer to NV internal data.</summary>
    public void* pPrivateData;
}