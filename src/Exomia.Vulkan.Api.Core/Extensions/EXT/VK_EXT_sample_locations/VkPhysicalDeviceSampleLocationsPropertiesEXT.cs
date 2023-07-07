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
///     VkPhysicalDeviceSampleLocationsPropertiesEXT - Structure describing sample location limits that can be supported by
///     an implementation -
///     <a
///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkPhysicalDeviceSampleLocationsPropertiesEXT.html">
///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkPhysicalDeviceSampleLocationsPropertiesEXT.html
///     </a>
/// </summary>
/// <remarks>
///     <list type="table">
///         <item>
///             <term>structextends</term><description>VkPhysicalDeviceProperties2</description>
///         </item>
///         <item>
///             <term>returnedonly</term><description>true</description>
///         </item>
///     </list>
/// </remarks>
[VkStructExtends("VkPhysicalDeviceProperties2")]
[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPhysicalDeviceSampleLocationsPropertiesEXT
{
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SAMPLE_LOCATIONS_PROPERTIES_EXT;

    /// <summary>sType is a VkStructureType value identifying this structure.</summary>
    public VkStructureType sType;

    /// <summary>pNext is NULL or a pointer to a structure extending this structure.</summary>
    public void* pNext;

    /// <summary>
    ///     sampleLocationSampleCountsis a bitmask of VkSampleCountFlagBits indicating the sample counts supporting
    ///     custom sample locations.
    /// </summary>
    public VkSampleCountFlags sampleLocationSampleCounts;

    /// <summary>
    ///     maxSampleLocationGridSize is the maximum size of the pixel grid in which sample locations can vary that is
    ///     supported for all sample counts in sampleLocationSampleCounts.
    /// </summary>
    public VkExtent2D maxSampleLocationGridSize;

    /// <summary>sampleLocationCoordinateRange[2] is the range of supported sample location coordinates.</summary>
    public VkArray2<float> sampleLocationCoordinateRange;

    /// <summary> sampleLocationSubPixelBitsis the number of bits of subpixel precision for sample locations.</summary>
    public uint sampleLocationSubPixelBits;

    /// <summary>
    ///     variableSampleLocationsspecifies whether the sample locations used by all pipelines that will be bound to a
    ///     command buffer during a subpass must match. If set to VK_TRUE, the implementation supports variable sample
    ///     locations in a subpass. If set to VK_FALSE, then the sample locations must stay constant in each subpass.
    /// </summary>
    public VkBool32 variableSampleLocations;
}