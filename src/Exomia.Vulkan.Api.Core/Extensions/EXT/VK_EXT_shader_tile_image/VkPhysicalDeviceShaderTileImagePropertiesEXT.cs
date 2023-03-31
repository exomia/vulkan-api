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
///     VkPhysicalDeviceShaderTileImagePropertiesEXT - Structure containing information about tile image support for a
///     physical device -
///     <a
///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkPhysicalDeviceShaderTileImagePropertiesEXT.html">
///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkPhysicalDeviceShaderTileImagePropertiesEXT.html
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
public unsafe struct VkPhysicalDeviceShaderTileImagePropertiesEXT
{
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_TILE_IMAGE_PROPERTIES_EXT;

    /// <summary>sType is the type of this structure.</summary>
    public VkStructureType sType;

    /// <summary>pNext is NULL or a pointer to a structure extending this structure.</summary>
    public void* pNext;

    /// <summary>
    ///     shaderTileImageCoherentReadAccelerated is a boolean that will be VK_TRUE if coherent reads of tile image data
    ///     is accelerated.
    /// </summary>
    public VkBool32 shaderTileImageCoherentReadAccelerated;

    /// <summary>
    ///     shaderTileImageReadSampleFromPixelRateInvocation is a boolean that will be VK_TRUE if reading from samples
    ///     from a pixel rate fragment invocation is supported when VkPipelineMultisampleStateCreateInfo::rasterizationSamples
    ///     &gt; 1.
    /// </summary>
    public VkBool32 shaderTileImageReadSampleFromPixelRateInvocation;

    /// <summary>
    ///     shaderTileImageReadFromHelperInvocation is a boolean that will be VK_TRUE if reads of tile image data from
    ///     helper fragment invocations result in valid values.
    /// </summary>
    public VkBool32 shaderTileImageReadFromHelperInvocation;
}