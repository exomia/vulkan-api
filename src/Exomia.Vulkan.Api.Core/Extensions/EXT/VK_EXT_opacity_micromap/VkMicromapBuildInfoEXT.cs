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
///     VkMicromapBuildInfoEXT - Structure specifying the  data used to build a micromap -
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkMicromapBuildInfoEXT.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkMicromapBuildInfoEXT.html</a>
/// </summary>
[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkMicromapBuildInfoEXT
{
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_MICROMAP_BUILD_INFO_EXT;

    /// <summary>sType is a VkStructureType value identifying this structure.</summary>
    public VkStructureType sType;

    /// <summary>pNext is NULL or a pointer to a structure extending this structure.</summary>
    public void* pNext;

    /// <summary>type is a VkMicromapTypeEXT value specifying the type of micromap being built.</summary>
    public VkMicromapTypeEXT type;

    /// <summary>flags is a bitmask of VkBuildMicromapFlagBitsEXT specifying additional parameters of the micromap.</summary>
    public VkBuildMicromapFlagsEXT flags;

    /// <summary>mode is a VkBuildMicromapModeEXT value specifying the type of operation to perform.</summary>
    public VkBuildMicromapModeEXT mode;

    /// <summary>dstMicromap is a pointer to the target micromap for the build.</summary>
    public VkMicromapEXT dstMicromap;

    /// <summary>
    ///     usageCountsCount specifies the number of usage counts structures that will be used to determine the size of
    ///     this micromap.
    /// </summary>
    public uint usageCountsCount;

    /// <summary>pUsageCounts is a pointer to an array of VkMicromapUsageEXTstructures.</summary>
    public VkMicromapUsageEXT* pUsageCounts;

    /// <summary>ppUsageCounts is a pointer to an array of pointers to VkMicromapUsageEXT structures.</summary>
    public VkMicromapUsageEXT** ppUsageCounts;

    /// <summary>data is the device or host address to memory which contains the data for the micromap.</summary>
    public VkDeviceOrHostAddressConstKHR data;

    /// <summary>scratchData is the device or host address to memory that will be used as scratch memory for the build.</summary>
    public VkDeviceOrHostAddressKHR scratchData;

    /// <summary>triangleArray is the device or host address to memory containing the VkMicromapTriangleEXT data</summary>
    public VkDeviceOrHostAddressConstKHR triangleArray;

    /// <summary>triangleArrayStride is the stride in bytes between each element of triangleArray</summary>
    public VkDeviceSize triangleArrayStride;
}