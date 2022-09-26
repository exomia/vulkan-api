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
///     VkExternalFenceProperties - Structure describing supported external fence handle features -
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkExternalFenceProperties.html"> https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkExternalFenceProperties.html </a>
/// </summary>
/// <remarks>
///     <list type="table">
///         <item>
///             <term> returnedonly </term><description> true </description>
///         </item>
///     </list>
/// </remarks>
[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkExternalFenceProperties
{
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_EXTERNAL_FENCE_PROPERTIES;

    /// <summary>
    ///     sType<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkExternalFenceProperties"> https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkExternalFenceProperties </a>
    /// </summary>
    public VkStructureType sType;

    /// <summary> pNext is NULL or a pointer to a structure extending this structure. </summary>
    public void* pNext;

    /// <summary> exportFromImportedHandleTypes is a bitmask of VkExternalFenceHandleTypeFlagBits indicating which types of imported handle handleType can be exported from. </summary>
    public VkExternalFenceHandleTypeFlags exportFromImportedHandleTypes;

    /// <summary> compatibleHandleTypes is a bitmask of VkExternalFenceHandleTypeFlagBits specifying handle types which can be specified at the same time as handleType when creating a fence. </summary>
    public VkExternalFenceHandleTypeFlags compatibleHandleTypes;

    /// <summary> externalFenceFeatures is a bitmask of VkExternalFenceFeatureFlagBits indicating the features of handleType. </summary>
    public VkExternalFenceFeatureFlags externalFenceFeatures;
}