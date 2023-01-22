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
///     VkPhysicalDeviceFragmentShaderInterlockFeaturesEXT - Structure describing fragment shader interlock features that
///     can be supported by an implementation -
///     <a
///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkPhysicalDeviceFragmentShaderInterlockFeaturesEXT.html">
///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkPhysicalDeviceFragmentShaderInterlockFeaturesEXT.html
///     </a>
/// </summary>
/// <remarks>
///     <list type="table">
///         <item>
///             <term>structextends</term><description>VkPhysicalDeviceFeatures2,VkDeviceCreateInfo</description>
///         </item>
///     </list>
/// </remarks>
[VkStructExtends("VkPhysicalDeviceFeatures2,VkDeviceCreateInfo")]
[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPhysicalDeviceFragmentShaderInterlockFeaturesEXT
{
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_FRAGMENT_SHADER_INTERLOCK_FEATURES_EXT;

    /// <summary>sType is the type of this structure.</summary>
    public VkStructureType sType;

    /// <summary>pNext is NULL or a pointer to a structure extending this structure.</summary>
    public void* pNext;

    /// <summary>
    ///     fragmentShaderSampleInterlock indicates that the implementation supports the FragmentShaderSampleInterlockEXT
    ///     SPIR-V capability.
    /// </summary>
    public VkBool32 fragmentShaderSampleInterlock;

    /// <summary>
    ///     fragmentShaderPixelInterlock indicates that the implementation supports the FragmentShaderPixelInterlockEXT
    ///     SPIR-V capability.
    /// </summary>
    public VkBool32 fragmentShaderPixelInterlock;

    /// <summary>
    ///     fragmentShaderShadingRateInterlock indicates that the implementation supports the
    ///     FragmentShaderShadingRateInterlockEXTSPIR-V capability.
    /// </summary>
    public VkBool32 fragmentShaderShadingRateInterlock;
}