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
///     VkGeneratedCommandsInfoNV - Structure specifying parameters for the generation of commands -
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkGeneratedCommandsInfoNV.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkGeneratedCommandsInfoNV.html</a>
/// </summary>
[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkGeneratedCommandsInfoNV
{
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_GENERATED_COMMANDS_INFO_NV;

    /// <summary>sType is the type of this structure.</summary>
    public VkStructureType sType;

    /// <summary>pNext is NULL or a pointer to a structure extending this structure.</summary>
    public void* pNext;

    /// <summary>pipelineBindPoint is the VkPipelineBindPoint used for the pipeline.</summary>
    public VkPipelineBindPoint pipelineBindPoint;

    /// <summary>pipeline is the VkPipeline used in the generation and execution process.</summary>
    public VkPipeline pipeline;

    /// <summary>indirectCommandsLayout is the VkIndirectCommandsLayoutNVthat provides the command sequence to generate.</summary>
    public VkIndirectCommandsLayoutNV indirectCommandsLayout;

    /// <summary>streamCount defines the number of input streams</summary>
    public uint streamCount;

    /// <summary>
    ///     pStreams is a pointer to an array of streamCountVkIndirectCommandsStreamNV structures providing the input data
    ///     for the tokens used in indirectCommandsLayout.
    /// </summary>
    public VkIndirectCommandsStreamNV* pStreams;

    /// <summary>
    ///     sequencesCount is the maximum number of sequences to reserve. If sequencesCountBuffer is VK_NULL_HANDLE, this
    ///     is also the actual number of sequences generated.
    /// </summary>
    public uint sequencesCount;

    /// <summary>
    ///     preprocessBuffer is the VkBuffer that is used for preprocessing the input data for execution. If this
    ///     structure is used with vkCmdExecuteGeneratedCommandsNVwith its isPreprocessed set to VK_TRUE, then the
    ///     preprocessing step is skipped and data is only read from this buffer.
    /// </summary>
    public VkBuffer preprocessBuffer;

    /// <summary>preprocessOffset is the byte offset into preprocessBufferwhere the preprocessed data is stored.</summary>
    public VkDeviceSize preprocessOffset;

    /// <summary>
    ///     preprocessSize is the maximum byte size within the preprocessBuffer after the preprocessOffset that is
    ///     available for preprocessing.
    /// </summary>
    public VkDeviceSize preprocessSize;

    /// <summary>
    ///     sequencesCountBuffer is a VkBuffer in which the actual number of sequences is provided as single uint32_t
    ///     value.
    /// </summary>
    public VkBuffer sequencesCountBuffer;

    /// <summary>sequencesCountOffset is the byte offset into sequencesCountBuffer where the count value is stored.</summary>
    public VkDeviceSize sequencesCountOffset;

    /// <summary>sequencesIndexBuffer is a VkBuffer that encodes the used sequence indices as uint32_t array.</summary>
    public VkBuffer sequencesIndexBuffer;

    /// <summary>sequencesIndexOffset is the byte offset into sequencesIndexBuffer where the index values start.</summary>
    public VkDeviceSize sequencesIndexOffset;
}