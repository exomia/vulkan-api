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
///     VkCommandBufferInheritanceConditionalRenderingInfoEXT - Structure specifying command buffer inheritance information -
///     <a
///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkCommandBufferInheritanceConditionalRenderingInfoEXT.html">
///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkCommandBufferInheritanceConditionalRenderingInfoEXT.html
///     </a>
/// </summary>
/// <remarks>
///     <list type="table">
///         <item>
///             <term> structextends </term><description> VkCommandBufferInheritanceInfo </description>
///         </item>
///     </list>
/// </remarks>
[VkStructExtends("VkCommandBufferInheritanceInfo")]
[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkCommandBufferInheritanceConditionalRenderingInfoEXT
{
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_COMMAND_BUFFER_INHERITANCE_CONDITIONAL_RENDERING_INFO_EXT;

    /// <summary> sType is the type of this structure. </summary>
    public VkStructureType sType;

    /// <summary> pNext is NULL or a pointer to a structure extending this structure. </summary>
    public void* pNext;

    /// <summary> conditionalRenderingEnable specifies whether the command buffer can be executed while conditional rendering is active in the primary command buffer. If this is VK_TRUE, then this command buffer can be executed whether the primary command buffer has active conditional rendering or not. If this is VK_FALSE, then the primary command buffer must not have conditional rendering active. </summary>
    public VkBool32 conditionalRenderingEnable;
}