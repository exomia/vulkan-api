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
///     VkExternalMemoryProperties - Structure specifying external memory handle type capabilities -
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkExternalMemoryProperties.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkExternalMemoryProperties.html</a>
/// </summary>
/// <remarks>
///     <list type="table">
///         <item>
///             <term>returnedonly</term><description>true</description>
///         </item>
///     </list>
/// </remarks>
[StructLayout(LayoutKind.Sequential)]
public struct VkExternalMemoryProperties
{
    /// <summary>externalMemoryFeatures is a bitmask of VkExternalMemoryFeatureFlagBits specifying the features of handleType.</summary>
    public VkExternalMemoryFeatureFlags externalMemoryFeatures;

    /// <summary>
    ///     exportFromImportedHandleTypes is a bitmask of VkExternalMemoryHandleTypeFlagBits specifying which types of
    ///     imported handle handleType can be exported from.
    /// </summary>
    public VkExternalMemoryHandleTypeFlags exportFromImportedHandleTypes;

    /// <summary>
    ///     compatibleHandleTypes is a bitmask of VkExternalMemoryHandleTypeFlagBits specifying handle types which can be
    ///     specified at the same time as handleType when creating an image compatible with external memory.
    /// </summary>
    public VkExternalMemoryHandleTypeFlags compatibleHandleTypes;
}