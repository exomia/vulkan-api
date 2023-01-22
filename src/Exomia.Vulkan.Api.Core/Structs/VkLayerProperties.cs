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
///     VkLayerProperties - Structure specifying layer properties -
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkLayerProperties.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkLayerProperties.html</a>
/// </summary>
/// <remarks>
///     <list type="table">
///         <item>
///             <term>returnedonly</term><description>true</description>
///         </item>
///     </list>
/// </remarks>
[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkLayerProperties
{
    /// <summary>
    ///     layerName is an array of VK_MAX_EXTENSION_NAME_SIZEchar containing a null-terminated UTF-8 string which is the
    ///     name of the layer. Use this name in the ppEnabledLayerNames array passed in the VkInstanceCreateInfo structure to
    ///     enable this layer for an instance.
    /// </summary>
    public fixed byte layerName[(int)VK_MAX_EXTENSION_NAME_SIZE];

    /// <summary>
    ///     specVersion is the Vulkan version the layer was written to, encoded as described in
    ///     https://registry.khronos.org/vulkan/specs/1.3-extensions/html/vkspec.html#extendingvulkan-coreversions-versionnumbers.
    /// </summary>
    public VkVersion specVersion;

    /// <summary>
    ///     implementationVersion is the version of this layer. It is an integer, increasing with backward compatible
    ///     changes.
    /// </summary>
    public VkVersion implementationVersion;

    /// <summary>
    ///     description is an array of VK_MAX_DESCRIPTION_SIZE charcontaining a null-terminated UTF-8 string which
    ///     provides additional details that can be used by the application to identify the layer.
    /// </summary>
    public fixed byte description[(int)VK_MAX_DESCRIPTION_SIZE];
}