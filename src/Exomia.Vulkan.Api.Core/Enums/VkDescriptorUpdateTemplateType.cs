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
///     VkDescriptorUpdateTemplateType - Indicates the valid usage of the descriptor update template -
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkDescriptorUpdateTemplateType.html"> https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkDescriptorUpdateTemplateType.html </a>
/// </summary>
public enum VkDescriptorUpdateTemplateType
{
    /// <summary> VK_DESCRIPTOR_UPDATE_TEMPLATE_TYPE_DESCRIPTOR_SET specifies that the descriptor update template will be used for descriptor set updates only. </summary>
    VK_DESCRIPTOR_UPDATE_TEMPLATE_TYPE_DESCRIPTOR_SET = 0,

    /// <summary> VK_DESCRIPTOR_UPDATE_TEMPLATE_TYPE_PUSH_DESCRIPTORS_KHR specifies that the descriptor update template will be used for push descriptor updates only. </summary>
    VK_DESCRIPTOR_UPDATE_TEMPLATE_TYPE_PUSH_DESCRIPTORS_KHR = 1,

    /// <summary> VK_DESCRIPTOR_UPDATE_TEMPLATE_TYPE_DESCRIPTOR_SET specifies that the descriptor update template will be used for descriptor set updates only. </summary>
    VK_DESCRIPTOR_UPDATE_TEMPLATE_TYPE_DESCRIPTOR_SET_KHR = VK_DESCRIPTOR_UPDATE_TEMPLATE_TYPE_DESCRIPTOR_SET
}