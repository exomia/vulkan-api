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
namespace Exomia.Vulkan.Api.Fuchsia;

/// <summary>
///     VkBufferConstraintsInfoFUCHSIA - Structure buffer-based buffer collection constraints -
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkBufferConstraintsInfoFUCHSIA.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkBufferConstraintsInfoFUCHSIA.html</a>
/// </summary>
[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkBufferConstraintsInfoFUCHSIA
{
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_BUFFER_CONSTRAINTS_INFO_FUCHSIA;

    /// <summary>sType is the type of this structure</summary>
    public VkStructureType sType;

    /// <summary>pNext is NULL or a pointer to a structure extending this structure</summary>
    public void* pNext;

    /// <summary>
    ///     createInfo<br />
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkBufferConstraintsInfoFUCHSIA">
    ///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkBufferConstraintsInfoFUCHSIA
    ///     </a>
    /// </summary>
    public VkBufferCreateInfo createInfo;

    /// <summary>
    ///     requiredFormatFeatures bitmask of VkFormatFeatureFlagBitsrequired features of the buffers in the buffer
    ///     collection
    /// </summary>
    public VkFormatFeatureFlags requiredFormatFeatures;

    /// <summary>
    ///     bufferCollectionConstraints is used to supply parameters for the negotiation and allocation of the buffer
    ///     collection
    /// </summary>
    public VkBufferCollectionConstraintsInfoFUCHSIA bufferCollectionConstraints;
}