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
///     VkMicromapBuildSizesInfoEXT - Structure specifying build sizes for a micromap -
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkMicromapBuildSizesInfoEXT.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkMicromapBuildSizesInfoEXT.html</a>
/// </summary>
[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkMicromapBuildSizesInfoEXT
{
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_MICROMAP_BUILD_SIZES_INFO_EXT;

    /// <summary>sType is the type of this structure.</summary>
    public VkStructureType sType;

    /// <summary>pNext is NULL or a pointer to a structure extending this structure.</summary>
    public void* pNext;

    /// <summary>micromapSize is the size in bytes required in a VkMicromapEXT for a build or update operation.</summary>
    public VkDeviceSize micromapSize;

    /// <summary>buildScratchSize is the size in bytes required in a scratch buffer for a build operation.</summary>
    public VkDeviceSize buildScratchSize;

    /// <summary>
    ///     discardable indicates whether or not the micromap object may be destroyed after an acceleration structure
    ///     build or update. A false value means that acceleration structures built with this micromap may contain references
    ///     to the data contained therein, and the application must not destroy the micromap until ray traversal has concluded.
    ///     A true value means that the information in the micromap will be copied by value into the acceleration structure,
    ///     and the micromap may be destroyed after the acceleration structure build concludes.
    /// </summary>
    public VkBool32 discardable;
}