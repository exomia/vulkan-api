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
///     VkCopyCommandTransformInfoQCOM - Structure describing transform parameters of rotated copy command -
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkCopyCommandTransformInfoQCOM.html"> https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkCopyCommandTransformInfoQCOM.html </a>
/// </summary>
/// <remarks>
///     <list type="table">
///         <item>
///             <term> structextends </term><description> VkBufferImageCopy2,VkImageBlit2 </description>
///         </item>
///     </list>
/// </remarks>
[VkStructExtends("VkBufferImageCopy2,VkImageBlit2")]
[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkCopyCommandTransformInfoQCOM
{
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_COPY_COMMAND_TRANSFORM_INFO_QCOM;

    /// <summary> sType is the type of this structure. </summary>
    public VkStructureType sType;

    /// <summary> pNext is NULL or a pointer to a structure extending this structure. </summary>
    public void* pNext;

    /// <summary> transform is a VkSurfaceTransformFlagBitsKHR value describing the transform to be applied. </summary>
    public VkSurfaceTransformFlagBitsKHR transform;
}