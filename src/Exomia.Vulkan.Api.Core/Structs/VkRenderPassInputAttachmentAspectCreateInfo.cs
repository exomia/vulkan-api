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
///     VkRenderPassInputAttachmentAspectCreateInfo - Structure specifying, for a given subpass/input attachment pair, which aspect can: be read. -
///     <a
///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkRenderPassInputAttachmentAspectCreateInfo.html">
///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkRenderPassInputAttachmentAspectCreateInfo.html
///     </a>
/// </summary>
/// <remarks>
///     <list type="table">
///         <item>
///             <term> structextends </term><description> VkRenderPassCreateInfo </description>
///         </item>
///     </list>
/// </remarks>
[VkStructExtends("VkRenderPassCreateInfo")]
[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkRenderPassInputAttachmentAspectCreateInfo
{
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_RENDER_PASS_INPUT_ATTACHMENT_ASPECT_CREATE_INFO;

    /// <summary> sType is the type of this structure. </summary>
    public VkStructureType sType;

    /// <summary> pNext is NULL or a pointer to a structure extending this structure. </summary>
    public void* pNext;

    /// <summary> aspectReferenceCount is the number of elements in the pAspectReferences array. </summary>
    public uint aspectReferenceCount;

    /// <summary> pAspectReferences is a pointer to an array of aspectReferenceCount VkInputAttachmentAspectReferencestructures containing a mask describing which aspect(s) can be accessed for a given input attachment within a given subpass. </summary>
    public VkInputAttachmentAspectReference* pAspectReferences;
}