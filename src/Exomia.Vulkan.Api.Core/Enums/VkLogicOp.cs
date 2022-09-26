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
///     VkLogicOp - Framebuffer logical operations -
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkLogicOp.html"> https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkLogicOp.html </a>
/// </summary>
public enum VkLogicOp
{
    /// <summary>
    ///     <list type="table">
    ///         <item>
    ///             <term> Operation </term><description> 0 </description>
    ///         </item>
    ///     </list>
    /// </summary>
    VK_LOGIC_OP_CLEAR = 0,

    /// <summary>
    ///     <list type="table">
    ///         <item>
    ///             <term> Operation </term><description> s ∧ d </description>
    ///         </item>
    ///     </list>
    /// </summary>
    VK_LOGIC_OP_AND = 1,

    /// <summary>
    ///     <list type="table">
    ///         <item>
    ///             <term> Operation </term><description> s ∧ ¬ d </description>
    ///         </item>
    ///     </list>
    /// </summary>
    VK_LOGIC_OP_AND_REVERSE = 2,

    /// <summary>
    ///     <list type="table">
    ///         <item>
    ///             <term> Operation </term><description> s </description>
    ///         </item>
    ///     </list>
    /// </summary>
    VK_LOGIC_OP_COPY = 3,

    /// <summary>
    ///     <list type="table">
    ///         <item>
    ///             <term> Operation </term><description> ¬ s ∧ d </description>
    ///         </item>
    ///     </list>
    /// </summary>
    VK_LOGIC_OP_AND_INVERTED = 4,

    /// <summary>
    ///     <list type="table">
    ///         <item>
    ///             <term> Operation </term><description> d </description>
    ///         </item>
    ///     </list>
    /// </summary>
    VK_LOGIC_OP_NO_OP = 5,

    /// <summary>
    ///     <list type="table">
    ///         <item>
    ///             <term> Operation </term><description> s ⊕ d </description>
    ///         </item>
    ///     </list>
    /// </summary>
    VK_LOGIC_OP_XOR = 6,

    /// <summary>
    ///     <list type="table">
    ///         <item>
    ///             <term> Operation </term><description> s ∨ d </description>
    ///         </item>
    ///     </list>
    /// </summary>
    VK_LOGIC_OP_OR = 7,

    /// <summary>
    ///     <list type="table">
    ///         <item>
    ///             <term> Operation </term><description> ¬ (s ∨ d) </description>
    ///         </item>
    ///     </list>
    /// </summary>
    VK_LOGIC_OP_NOR = 8,

    /// <summary>
    ///     <list type="table">
    ///         <item>
    ///             <term> Operation </term><description> ¬ (s ⊕ d) </description>
    ///         </item>
    ///     </list>
    /// </summary>
    VK_LOGIC_OP_EQUIVALENT = 9,

    /// <summary>
    ///     <list type="table">
    ///         <item>
    ///             <term> Operation </term><description> ¬ d </description>
    ///         </item>
    ///     </list>
    /// </summary>
    VK_LOGIC_OP_INVERT = 10,

    /// <summary>
    ///     <list type="table">
    ///         <item>
    ///             <term> Operation </term><description> s ∨ ¬ d </description>
    ///         </item>
    ///     </list>
    /// </summary>
    VK_LOGIC_OP_OR_REVERSE = 11,

    /// <summary>
    ///     <list type="table">
    ///         <item>
    ///             <term> Operation </term><description> ¬ s </description>
    ///         </item>
    ///     </list>
    /// </summary>
    VK_LOGIC_OP_COPY_INVERTED = 12,

    /// <summary>
    ///     <list type="table">
    ///         <item>
    ///             <term> Operation </term><description> ¬ s ∨ d </description>
    ///         </item>
    ///     </list>
    /// </summary>
    VK_LOGIC_OP_OR_INVERTED = 13,

    /// <summary>
    ///     <list type="table">
    ///         <item>
    ///             <term> Operation </term><description> ¬ (s ∧ d) </description>
    ///         </item>
    ///     </list>
    /// </summary>
    VK_LOGIC_OP_NAND = 14,

    /// <summary>
    ///     <list type="table">
    ///         <item>
    ///             <term> Operation </term><description> all 1s </description>
    ///         </item>
    ///     </list>
    /// </summary>
    VK_LOGIC_OP_SET = 15
}