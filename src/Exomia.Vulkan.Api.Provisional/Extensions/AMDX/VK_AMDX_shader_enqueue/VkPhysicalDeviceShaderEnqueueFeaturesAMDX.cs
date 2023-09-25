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
namespace Exomia.Vulkan.Api.Provisional;

/// <summary>
///     VkPhysicalDeviceShaderEnqueueFeaturesAMDX - Structure describing whether shader enqueue within execution graphs are
///     supported by the implementation -
///     <a
///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkPhysicalDeviceShaderEnqueueFeaturesAMDX.html">
///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkPhysicalDeviceShaderEnqueueFeaturesAMDX.html
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
public unsafe struct VkPhysicalDeviceShaderEnqueueFeaturesAMDX
{
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_ENQUEUE_FEATURES_AMDX;

    /// <summary>
    ///     sType<br />
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkPhysicalDeviceShaderEnqueueFeaturesAMDX">
    ///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkPhysicalDeviceShaderEnqueueFeaturesAMDX
    ///     </a>
    /// </summary>
    public VkStructureType sType;

    /// <summary>pNext is NULL or a pointer to a structure extending this structure.</summary>
    public void* pNext;

    /// <summary> shaderEnqueue indicates whether the implementation supports execution graphs.</summary>
    public VkBool32 shaderEnqueue;
}