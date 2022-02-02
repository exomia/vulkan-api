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
///     VkPhysicalDeviceShadingRateImagePropertiesNV - Structure describing shading rate image limits that can be supported
///     by an implementation -
///     <a
///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkPhysicalDeviceShadingRateImagePropertiesNV.html">
///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkPhysicalDeviceShadingRateImagePropertiesNV.html
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
public unsafe struct VkPhysicalDeviceShadingRateImagePropertiesNV
{
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADING_RATE_IMAGE_PROPERTIES_NV;

    /// <summary>sType is the type of this structure.</summary>
    public VkStructureType sType;

    /// <summary>pNext is NULL or a pointer to a structure extending this structure.</summary>
    public void* pNext;

    /// <summary>
    ///     shadingRateTexelSize indicates the width and height of the portion of the framebuffer corresponding to each
    ///     texel in the shading rate image.
    /// </summary>
    public VkExtent2D shadingRateTexelSize;

    /// <summary> shadingRatePaletteSize indicates the maximum number of palette entries supported for the shading rate image.</summary>
    public uint shadingRatePaletteSize;

    /// <summary>
    ///     shadingRateMaxCoarseSamplesspecifies the maximum number of coverage samples supported in a single fragment.
    ///     If the product of the fragment size derived from the base shading rate and the number of coverage samples per pixel
    ///     exceeds this limit, the final shading rate will be adjusted so that its product does not exceed the limit.
    /// </summary>
    public uint shadingRateMaxCoarseSamples;
}