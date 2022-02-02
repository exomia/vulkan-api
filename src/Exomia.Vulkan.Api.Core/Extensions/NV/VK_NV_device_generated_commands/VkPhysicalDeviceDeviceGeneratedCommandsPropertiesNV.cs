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
///     VkPhysicalDeviceDeviceGeneratedCommandsPropertiesNV - Structure describing push descriptor limits that can be
///     supported by an implementation -
///     <a
///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkPhysicalDeviceDeviceGeneratedCommandsPropertiesNV.html">
///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkPhysicalDeviceDeviceGeneratedCommandsPropertiesNV.html
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
public unsafe struct VkPhysicalDeviceDeviceGeneratedCommandsPropertiesNV
{
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_DEVICE_GENERATED_COMMANDS_PROPERTIES_NV;

    /// <summary>sType is the type of this structure.</summary>
    public VkStructureType sType;

    /// <summary>pNext is NULL or a pointer to a structure extending this structure.</summary>
    public void* pNext;

    /// <summary>
    ///     maxGraphicsShaderGroupCount is the maximum number of shader groups in
    ///     VkGraphicsPipelineShaderGroupsCreateInfoNV.
    /// </summary>
    public uint maxGraphicsShaderGroupCount;

    /// <summary>
    ///     maxIndirectSequenceCount is the maximum number of sequences in VkGeneratedCommandsInfoNV and in
    ///     VkGeneratedCommandsMemoryRequirementsInfoNV.
    /// </summary>
    public uint maxIndirectSequenceCount;

    /// <summary>
    ///     maxIndirectCommandsLayoutTokenCount is the maximum number of tokens in
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkIndirectCommandsLayoutCreateInfoNV.html">
    ///         VkIndirectCommandsLayoutCreateInfoNV
    ///     </a>
    ///     .
    /// </summary>
    public uint maxIndirectCommandsTokenCount;

    /// <summary>maxIndirectCommandsStreamCount is the maximum number of streams in VkIndirectCommandsLayoutCreateInfoNV.</summary>
    public uint maxIndirectCommandsStreamCount;

    /// <summary>maxIndirectCommandsTokenOffset is the maximum offset in VkIndirectCommandsLayoutTokenNV.</summary>
    public uint maxIndirectCommandsTokenOffset;

    /// <summary>maxIndirectCommandsStreamStride is the maximum stream stride in VkIndirectCommandsLayoutCreateInfoNV.</summary>
    public uint maxIndirectCommandsStreamStride;

    /// <summary>
    ///     minSequencesCountBufferOffsetAlignment is the minimum alignment for memory addresses which can be used in
    ///     VkGeneratedCommandsInfoNV.
    /// </summary>
    public uint minSequencesCountBufferOffsetAlignment;

    /// <summary>
    ///     minSequencesIndexBufferOffsetAlignment is the minimum alignment for memory addresses which can be used in
    ///     VkGeneratedCommandsInfoNV.
    /// </summary>
    public uint minSequencesIndexBufferOffsetAlignment;

    /// <summary>
    ///     minIndirectCommandsBufferOffsetAlignment is the minimum alignment for memory addresses used in
    ///     VkIndirectCommandsStreamNV, and as preprocess buffer in VkGeneratedCommandsInfoNV.
    /// </summary>
    public uint minIndirectCommandsBufferOffsetAlignment;
}