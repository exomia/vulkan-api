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
///     VkPhysicalDeviceTexelBufferAlignmentProperties - Structure describing the texel buffer alignment requirements
///     supported by an implementation -
///     <a
///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkPhysicalDeviceTexelBufferAlignmentProperties.html">
///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkPhysicalDeviceTexelBufferAlignmentProperties.html
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
public unsafe struct VkPhysicalDeviceTexelBufferAlignmentProperties
{
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_TEXEL_BUFFER_ALIGNMENT_PROPERTIES;

    /// <summary>sType is the type of this structure.</summary>
    public VkStructureType sType;

    /// <summary>pNext is NULL or a pointer to a structure extending this structure.</summary>
    public void* pNext;

    /// <summary>
    ///     storageTexelBufferOffsetAlignmentBytes is a byte alignment that is sufficient for a storage texel buffer of
    ///     any format. The value must be a power of two.
    /// </summary>
    public VkDeviceSize storageTexelBufferOffsetAlignmentBytes;

    /// <summary>
    ///     storageTexelBufferOffsetSingleTexelAlignment indicates whether single texel alignment is sufficient for a
    ///     storage texel buffer of any format. The value must be a power of two.
    /// </summary>
    public VkBool32 storageTexelBufferOffsetSingleTexelAlignment;

    /// <summary>
    ///     uniformTexelBufferOffsetAlignmentBytes is a byte alignment that is sufficient for a uniform texel buffer of
    ///     any format. The value must be a power of two.
    /// </summary>
    public VkDeviceSize uniformTexelBufferOffsetAlignmentBytes;

    /// <summary>
    ///     uniformTexelBufferOffsetSingleTexelAlignment indicates whether single texel alignment is sufficient for a
    ///     uniform texel buffer of any format. The value must be a power of two.
    /// </summary>
    public VkBool32 uniformTexelBufferOffsetSingleTexelAlignment;
}