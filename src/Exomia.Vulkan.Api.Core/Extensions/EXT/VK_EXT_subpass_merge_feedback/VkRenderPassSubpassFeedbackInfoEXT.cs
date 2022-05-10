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
///     VkRenderPassSubpassFeedbackInfoEXT - Feedback about the creation of subpass -
///     <a
///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkRenderPassSubpassFeedbackInfoEXT.html">
///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkRenderPassSubpassFeedbackInfoEXT.html
///     </a>
/// </summary>
/// <remarks>
///     <list type="table">
///         <item>
///             <term>structextends</term><description>VkSubpassDescription2,VkRenderPassCreationControlEXT</description>
///         </item>
///     </list>
/// </remarks>
[VkStructExtends("VkSubpassDescription2,VkRenderPassCreationControlEXT")]
[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkRenderPassSubpassFeedbackInfoEXT
{
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_RENDER_PASS_SUBPASS_FEEDBACK_INFO_EXT;

    /// <summary>sType is the type of this structure.</summary>
    public VkStructureType sType;

    /// <summary>pNext is NULL or a pointer to an extension-specific structure.</summary>
    public void* pNext;

    /// <summary>
    ///     subpassMergeStatus is a VkSubpassMergeStatusEXT value specifying information about whether the subpass is
    ///     merged with previous subpass and the reason why it is not merged.
    /// </summary>
    public VkSubpassMergeStatusEXT subpassMergeStatus;

    /// <summary>
    ///     description is an array of VK_MAX_DESCRIPTION_SIZE charcontaining a null-terminated UTF-8 string which
    ///     provides additional details.
    /// </summary>
    public fixed byte description[(int)VK_MAX_DESCRIPTION_SIZE];

    /// <summary>postMergeIndex is the subpass index after the subpass merging.</summary>
    public uint postMergeIndex;
}