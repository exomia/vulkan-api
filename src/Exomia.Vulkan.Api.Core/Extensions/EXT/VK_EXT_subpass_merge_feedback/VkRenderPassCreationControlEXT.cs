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
///     VkRenderPassCreationControlEXT - Control about the creation of render pass or subpass -
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkRenderPassCreationControlEXT.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkRenderPassCreationControlEXT.html</a>
/// </summary>
/// <remarks>
///     <list type="table">
///         <item>
///             <term>structextends</term><description>VkRenderPassCreateInfo2,VkSubpassDescription2</description>
///         </item>
///     </list>
/// </remarks>
[VkStructExtends("VkRenderPassCreateInfo2,VkSubpassDescription2")]
[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkRenderPassCreationControlEXT
{
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_RENDER_PASS_CREATION_CONTROL_EXT;

    /// <summary>sType is a VkStructureType value identifying this structure.</summary>
    public VkStructureType sType;

    /// <summary>pNext is NULL or a pointer to a structure extending this structure.</summary>
    public void* pNext;

    /// <summary>disallowMerging is a boolean value indicating whether subpass merging will be disabled.</summary>
    public VkBool32 disallowMerging;
}