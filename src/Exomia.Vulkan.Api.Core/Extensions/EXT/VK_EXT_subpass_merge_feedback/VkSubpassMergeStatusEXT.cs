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
///     VkSubpassMergeStatusEXT - Specify a subpass merging status -
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkSubpassMergeStatusEXT.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkSubpassMergeStatusEXT.html</a>
/// </summary>
public enum VkSubpassMergeStatusEXT
{
    /// <summary>VK_SUBPASS_MERGE_STATUS_MERGED_EXT specifies the subpass is merged with a previous subpass.</summary>
    VK_SUBPASS_MERGE_STATUS_MERGED_EXT = 0,

    /// <summary>
    ///     VK_SUBPASS_MERGE_STATUS_DISALLOWED_EXT specifies the subpass is disallowed to merge with previous subpass. If
    ///     the render pass does not allow subpass merging, then all subpass statuses are set to this value. If a subpass
    ///     description does not allow subpass merging, then only that subpass&#8217;s status is set to this value.
    /// </summary>
    VK_SUBPASS_MERGE_STATUS_DISALLOWED_EXT = 1,

    /// <summary>
    ///     VK_SUBPASS_MERGE_STATUS_NOT_MERGED_SIDE_EFFECTS_EXT specifies the subpass is not merged because it contains
    ///     side effects.
    /// </summary>
    VK_SUBPASS_MERGE_STATUS_NOT_MERGED_SIDE_EFFECTS_EXT = 2,

    /// <summary>
    ///     VK_SUBPASS_MERGE_STATUS_NOT_MERGED_SAMPLES_MISMATCH_EXT specifies the subpass is not merged because sample
    ///     count is not compatible with previous subpass.
    /// </summary>
    VK_SUBPASS_MERGE_STATUS_NOT_MERGED_SAMPLES_MISMATCH_EXT = 3,

    /// <summary>
    ///     VK_SUBPASS_MERGE_STATUS_NOT_MERGED_VIEWS_MISMATCH_EXT specifies the subpass is not merged because view masks
    ///     do not match with previous subpass.
    /// </summary>
    VK_SUBPASS_MERGE_STATUS_NOT_MERGED_VIEWS_MISMATCH_EXT = 4,

    /// <summary>
    ///     VK_SUBPASS_MERGE_STATUS_NOT_MERGED_ALIASING_EXT specifies the subpass is not merged because of attachments
    ///     aliasing between them.
    /// </summary>
    VK_SUBPASS_MERGE_STATUS_NOT_MERGED_ALIASING_EXT = 5,

    /// <summary>
    ///     VK_SUBPASS_MERGE_STATUS_NOT_MERGED_DEPENDENCIES_EXT specifies the subpass is not merged because subpass
    ///     dependencies do not allow merging.
    /// </summary>
    VK_SUBPASS_MERGE_STATUS_NOT_MERGED_DEPENDENCIES_EXT = 6,

    /// <summary>
    ///     VK_SUBPASS_MERGE_STATUS_NOT_MERGED_INCOMPATIBLE_INPUT_ATTACHMENT_EXTspecifies the subpass is not merged
    ///     because input attachment is not a color attachment from previous subpass or the formats are incompatible.
    /// </summary>
    VK_SUBPASS_MERGE_STATUS_NOT_MERGED_INCOMPATIBLE_INPUT_ATTACHMENT_EXT = 7,

    /// <summary>
    ///     VK_SUBPASS_MERGE_STATUS_NOT_MERGED_TOO_MANY_ATTACHMENTS_EXTspecifies the subpass is not merged because of too
    ///     many attachments.
    /// </summary>
    VK_SUBPASS_MERGE_STATUS_NOT_MERGED_TOO_MANY_ATTACHMENTS_EXT = 8,

    /// <summary>
    ///     VK_SUBPASS_MERGE_STATUS_NOT_MERGED_INSUFFICIENT_STORAGE_EXTspecifies the subpass is not merged because of
    ///     insufficient memory.
    /// </summary>
    VK_SUBPASS_MERGE_STATUS_NOT_MERGED_INSUFFICIENT_STORAGE_EXT = 9,

    /// <summary>
    ///     VK_SUBPASS_MERGE_STATUS_NOT_MERGED_DEPTH_STENCIL_COUNT_EXTspecifies the subpass is not merged because of too
    ///     many depth/stencil attachments.
    /// </summary>
    VK_SUBPASS_MERGE_STATUS_NOT_MERGED_DEPTH_STENCIL_COUNT_EXT = 10,

    /// <summary>
    ///     VK_SUBPASS_MERGE_STATUS_NOT_MERGED_RESOLVE_ATTACHMENT_REUSE_EXTspecifies the subpass is not merged because a
    ///     resolve attachment is reused as an input attachment in a subsequent subpass.
    /// </summary>
    VK_SUBPASS_MERGE_STATUS_NOT_MERGED_RESOLVE_ATTACHMENT_REUSE_EXT = 11,

    /// <summary>
    ///     VK_SUBPASS_MERGE_STATUS_NOT_MERGED_SINGLE_SUBPASS_EXT specifies the subpass is not merged because the render
    ///     pass has only one subpass.
    /// </summary>
    VK_SUBPASS_MERGE_STATUS_NOT_MERGED_SINGLE_SUBPASS_EXT = 12,

    /// <summary>
    ///     VK_SUBPASS_MERGE_STATUS_NOT_MERGED_UNSPECIFIED_EXT specifies other reasons why subpass is not merged. It is
    ///     also the recommended default value that should be reported when a subpass is not merged and when no other value is
    ///     appropriate.
    /// </summary>
    VK_SUBPASS_MERGE_STATUS_NOT_MERGED_UNSPECIFIED_EXT = 13
}