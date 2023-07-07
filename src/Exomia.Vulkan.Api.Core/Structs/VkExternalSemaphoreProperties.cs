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
///     VkExternalSemaphoreProperties - Structure describing supported external semaphore handle features -
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkExternalSemaphoreProperties.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkExternalSemaphoreProperties.html</a>
/// </summary>
/// <remarks>
///     <list type="table">
///         <item>
///             <term>returnedonly</term><description>true</description>
///         </item>
///     </list>
/// </remarks>
[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkExternalSemaphoreProperties
{
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_EXTERNAL_SEMAPHORE_PROPERTIES;

    /// <summary>sType is a VkStructureType value identifying this structure.</summary>
    public VkStructureType sType;

    /// <summary>pNext is NULL or a pointer to a structure extending this structure.</summary>
    public void* pNext;

    /// <summary>
    ///     exportFromImportedHandleTypes is a bitmask of VkExternalSemaphoreHandleTypeFlagBits specifying which types of
    ///     imported handle handleType can be exported from.
    /// </summary>
    public VkExternalSemaphoreHandleTypeFlags exportFromImportedHandleTypes;

    /// <summary>
    ///     compatibleHandleTypes is a bitmask of VkExternalSemaphoreHandleTypeFlagBits specifying handle types which can
    ///     be specified at the same time as handleType when creating a semaphore.
    /// </summary>
    public VkExternalSemaphoreHandleTypeFlags compatibleHandleTypes;

    /// <summary>
    ///     externalSemaphoreFeatures is a bitmask of VkExternalSemaphoreFeatureFlagBits describing the features of
    ///     handleType.
    /// </summary>
    public VkExternalSemaphoreFeatureFlags externalSemaphoreFeatures;
}