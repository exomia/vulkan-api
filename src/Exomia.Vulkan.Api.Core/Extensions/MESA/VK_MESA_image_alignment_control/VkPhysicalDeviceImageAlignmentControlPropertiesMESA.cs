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
///     VkPhysicalDeviceImageAlignmentControlPropertiesMESA - Structure describing supported image alignments for a
///     physical device -
///     <a
///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkPhysicalDeviceImageAlignmentControlPropertiesMESA.html">
///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkPhysicalDeviceImageAlignmentControlPropertiesMESA.html
///     </a>
/// </summary>
/// <remarks>
///     <list type="table">
///         <item>
///             <term>structextends</term><description>VkPhysicalDeviceProperties2</description>
///         </item>
///     </list>
/// </remarks>
[VkStructExtends("VkPhysicalDeviceProperties2")]
[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPhysicalDeviceImageAlignmentControlPropertiesMESA
{
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_IMAGE_ALIGNMENT_CONTROL_PROPERTIES_MESA;

    /// <summary>
    ///     sType<br />
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkPhysicalDeviceImageAlignmentControlPropertiesMESA">
    ///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkPhysicalDeviceImageAlignmentControlPropertiesMESA
    ///     </a>
    /// </summary>
    public VkStructureType sType;

    /// <summary>pNext is NULL or a pointer to a structure extending this structure.</summary>
    public void* pNext;

    /// <summary>
    ///     supportedImageAlignmentMaskis a bitwise-or of all potentially supported image alignments for a given physical
    ///     device when using VK_IMAGE_TILING_OPTIMAL. If a given alignment is supported, the application can request an image
    ///     to have that alignment. A given set of image creation parameters may support a subset of these alignments. To
    ///     determine if a particular alignment is supported for a given set of image creation parameters, check
    ///     VkMemoryRequirements::alignment after chaining in VkImageAlignmentControlCreateInfoMESA.
    /// </summary>
    public uint supportedImageAlignmentMask;
}