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
///     VkPhysicalDeviceNestedCommandBufferFeaturesEXT - Structure describing whether nested command buffers are supported
///     by the implementation -
///     <a
///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkPhysicalDeviceNestedCommandBufferFeaturesEXT.html">
///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkPhysicalDeviceNestedCommandBufferFeaturesEXT.html
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
public unsafe struct VkPhysicalDeviceNestedCommandBufferFeaturesEXT
{
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_NESTED_COMMAND_BUFFER_FEATURES_EXT;

    /// <summary>
    ///     sType<br />
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkPhysicalDeviceNestedCommandBufferFeaturesEXT">
    ///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkPhysicalDeviceNestedCommandBufferFeaturesEXT
    ///     </a>
    /// </summary>
    public VkStructureType sType;

    /// <summary>pNext is NULL or a pointer to a structure extending this structure.</summary>
    public void* pNext;

    /// <summary>
    ///     nestedCommandBuffer indicates the implementation supports nested command buffers, which allows Secondary
    ///     Command Buffers to execute other Secondary Command Buffers.
    /// </summary>
    public VkBool32 nestedCommandBuffer;

    /// <summary>
    ///     nestedCommandBufferRendering indicates that it is valid to call vkCmdExecuteCommands inside a Secondary
    ///     Command Buffer recorded with VK_COMMAND_BUFFER_USAGE_RENDER_PASS_CONTINUE_BIT.
    /// </summary>
    public VkBool32 nestedCommandBufferRendering;

    /// <summary>
    ///     nestedCommandBufferSimultaneousUse indicates that the implementation supports nested command buffers with
    ///     command buffers that are recorded with VK_COMMAND_BUFFER_USAGE_SIMULTANEOUS_USE_BIT.
    /// </summary>
    public VkBool32 nestedCommandBufferSimultaneousUse;
}