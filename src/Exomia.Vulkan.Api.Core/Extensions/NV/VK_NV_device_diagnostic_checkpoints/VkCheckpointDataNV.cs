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
///     VkCheckpointDataNV - Return structure for command buffer checkpoint data -
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkCheckpointDataNV.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkCheckpointDataNV.html</a>
/// </summary>
/// <remarks>
///     <list type="table">
///         <item>
///             <term>returnedonly</term><description>true</description>
///         </item>
///     </list>
/// </remarks>
[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkCheckpointDataNV
{
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_CHECKPOINT_DATA_NV;

    /// <summary>sType is a VkStructureType value identifying this structure.</summary>
    public VkStructureType sType;

    /// <summary>pNext is NULL or a pointer to a structure extending this structure.</summary>
    public void* pNext;

    /// <summary>stage is a VkPipelineStageFlagBits value specifying which pipeline stage the checkpoint marker data refers to.</summary>
    public VkPipelineStageFlagBits stage;

    /// <summary>pCheckpointMarker contains the value of the last checkpoint marker executed in the stage that stage refers to.</summary>
    public void* pCheckpointMarker;
}