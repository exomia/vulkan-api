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
///     VkCuModuleTexturingModeCreateInfoNVX - Stub description of VkCuModuleTexturingModeCreateInfoNVX -
///     <a
///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkCuModuleTexturingModeCreateInfoNVX.html">
///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkCuModuleTexturingModeCreateInfoNVX.html
///     </a>
/// </summary>
/// <remarks>
///     <list type="table">
///         <item>
///             <term>structextends</term><description>VkCuModuleCreateInfoNVX</description>
///         </item>
///     </list>
/// </remarks>
[VkStructExtends("VkCuModuleCreateInfoNVX")]
[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkCuModuleTexturingModeCreateInfoNVX
{
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_CU_MODULE_TEXTURING_MODE_CREATE_INFO_NVX;

    /// <summary>
    ///     sType<br />
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkCuModuleTexturingModeCreateInfoNVX">
    ///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkCuModuleTexturingModeCreateInfoNVX
    ///     </a>
    /// </summary>
    public VkStructureType sType;

    /// <summary>
    ///     pNext<br />
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkCuModuleTexturingModeCreateInfoNVX">
    ///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkCuModuleTexturingModeCreateInfoNVX
    ///     </a>
    /// </summary>
    public void* pNext;

    /// <summary>
    ///     use64bitTexturing<br />
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkCuModuleTexturingModeCreateInfoNVX">
    ///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkCuModuleTexturingModeCreateInfoNVX
    ///     </a>
    /// </summary>
    public VkBool32 use64bitTexturing;
}