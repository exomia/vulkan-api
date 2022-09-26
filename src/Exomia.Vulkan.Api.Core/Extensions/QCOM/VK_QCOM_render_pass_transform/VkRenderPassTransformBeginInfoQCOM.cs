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
///     VkRenderPassTransformBeginInfoQCOM - Structure describing transform parameters of a render pass instance -
///     <a
///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkRenderPassTransformBeginInfoQCOM.html">
///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkRenderPassTransformBeginInfoQCOM.html
///     </a>
/// </summary>
/// <remarks>
///     <list type="table">
///         <item>
///             <term> structextends </term><description> VkRenderPassBeginInfo </description>
///         </item>
///     </list>
/// </remarks>
[VkStructExtends("VkRenderPassBeginInfo")]
[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkRenderPassTransformBeginInfoQCOM
{
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_RENDER_PASS_TRANSFORM_BEGIN_INFO_QCOM;

    /// <summary> sType is the type of this structure. </summary>
    public VkStructureType sType;

    /// <summary> pNext is NULL or a pointer to a structure extending this structure. </summary>
    public void* pNext;

    /// <summary> transform is a VkSurfaceTransformFlagBitsKHR value describing the transform to be applied to rasterization. </summary>
    public VkSurfaceTransformFlagBitsKHR transform;
}