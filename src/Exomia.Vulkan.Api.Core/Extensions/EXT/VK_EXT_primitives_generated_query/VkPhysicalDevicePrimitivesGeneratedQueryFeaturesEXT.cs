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
///     VkPhysicalDevicePrimitivesGeneratedQueryFeaturesEXT - Structure describing support for primitives generated query -
///     <a
///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkPhysicalDevicePrimitivesGeneratedQueryFeaturesEXT.html">
///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkPhysicalDevicePrimitivesGeneratedQueryFeaturesEXT.html
///     </a>
/// </summary>
/// <remarks>
///     <list type="table">
///         <item>
///             <term> structextends </term><description> VkPhysicalDeviceFeatures2,VkDeviceCreateInfo </description>
///         </item>
///     </list>
/// </remarks>
[VkStructExtends("VkPhysicalDeviceFeatures2,VkDeviceCreateInfo")]
[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPhysicalDevicePrimitivesGeneratedQueryFeaturesEXT
{
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_PRIMITIVES_GENERATED_QUERY_FEATURES_EXT;

    /// <summary> sType is the type of this structure. </summary>
    public VkStructureType sType;

    /// <summary> pNext is NULL or a pointer to a structure extending this structure. </summary>
    public void* pNext;

    /// <summary> primitivesGeneratedQueryindicates whether the implementation supports the VK_QUERY_TYPE_PRIMITIVES_GENERATED_EXT query type. </summary>
    public VkBool32 primitivesGeneratedQuery;

    /// <summary> primitivesGeneratedQueryWithRasterizerDiscard indicates whether the implementation supports this query when rasterization discard is enabled. </summary>
    public VkBool32 primitivesGeneratedQueryWithRasterizerDiscard;

    /// <summary> primitivesGeneratedQueryWithNonZeroStreams indicates whether the implementation supports this query with a non-zero index in vkCmdBeginQueryIndexedEXT. </summary>
    public VkBool32 primitivesGeneratedQueryWithNonZeroStreams;
}