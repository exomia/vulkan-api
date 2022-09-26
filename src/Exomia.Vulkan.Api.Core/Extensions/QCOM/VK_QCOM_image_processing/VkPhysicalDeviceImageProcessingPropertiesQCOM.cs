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
///     VkPhysicalDeviceImageProcessingPropertiesQCOM - Structure containing image processing properties -
///     <a
///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkPhysicalDeviceImageProcessingPropertiesQCOM.html">
///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkPhysicalDeviceImageProcessingPropertiesQCOM.html
///     </a>
/// </summary>
/// <remarks>
///     <list type="table">
///         <item>
///             <term> structextends </term><description> VkPhysicalDeviceProperties2 </description>
///         </item>
///         <item>
///             <term> returnedonly </term><description> true </description>
///         </item>
///     </list>
/// </remarks>
[VkStructExtends("VkPhysicalDeviceProperties2")]
[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPhysicalDeviceImageProcessingPropertiesQCOM
{
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_IMAGE_PROCESSING_PROPERTIES_QCOM;

    /// <summary> sType is the type of this structure. </summary>
    public VkStructureType sType;

    /// <summary> pNext is NULL or a pointer to a structure extending this structure. </summary>
    public void* pNext;

    /// <summary> maxWeightFilterPhases is the maximum value that can be specified for VkImageViewSampleWeightCreateInfoQCOM::numPhases. in weight image samplingoperations. </summary>
    public uint maxWeightFilterPhases;

    /// <summary> maxWeightFilterDimension is a VkExtent2D describing the largest dimensions (width and height) that can be specified for VkImageViewSampleWeightCreateInfoQCOM::filterSize. </summary>
    public VkExtent2D maxWeightFilterDimension;

    /// <summary> maxBlockMatchRegion is a VkExtent2D describing the largest dimensions (width and height) that can be specified for blockSize in block matching operations. </summary>
    public VkExtent2D maxBlockMatchRegion;

    /// <summary> maxBoxFilterBlockSize is a VkExtent2D describing the the maximum dimensions (width and height) that can be specified for blocksize in box filter sampling operations. </summary>
    public VkExtent2D maxBoxFilterBlockSize;
}