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
///     VkRenderPassCreationFeedbackInfoEXT - Feedback about the creation of render pass -
///     <a
///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkRenderPassCreationFeedbackInfoEXT.html">
///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkRenderPassCreationFeedbackInfoEXT.html
///     </a>
/// </summary>
/// <remarks>
///     <list type="table">
///         <item>
///             <term>structextends</term><description>VkRenderPassCreateInfo2,VkRenderPassCreationControlEXT</description>
///         </item>
///     </list>
/// </remarks>
[VkStructExtends("VkRenderPassCreateInfo2,VkRenderPassCreationControlEXT")]
[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkRenderPassCreationFeedbackInfoEXT
{
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_RENDER_PASS_CREATION_FEEDBACK_INFO_EXT;

    /// <summary>sType is the type of this structure.</summary>
    public VkStructureType sType;

    /// <summary>pNext is NULL or a pointer to an extension-specific structure.</summary>
    public void* pNext;

    /// <summary>postMergeSubpassCount is the subpass count after merge.</summary>
    public uint postMergeSubpassCount;
}