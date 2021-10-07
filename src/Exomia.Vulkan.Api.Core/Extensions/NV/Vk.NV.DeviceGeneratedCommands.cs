#region License

// Copyright (c) 2018-2021, exomia
// All rights reserved.
// 
// This source code is licensed under the BSD-style license found in the
// LICENSE file in the root directory of this source tree.

#endregion

#pragma warning disable CA2211 // Non-constant fields should not be visible
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

using System;
using System.Runtime.InteropServices;
using Exomia.Vulkan.Api.SourceGenerator;

// ReSharper disable UnusedMember.Global
// ReSharper disable InconsistentNaming
namespace Exomia.Vulkan.Api.Core.Extensions.NV
{
    [VkExtGenerator]
    public static unsafe partial class VkNvDeviceGeneratedCommands
    {
        public const int    VK_NV_DEVICE_GENERATED_COMMANDS                = 1;
        public const int    VK_NV_DEVICE_GENERATED_COMMANDS_SPEC_VERSION   = 3;
        public const string VK_NV_DEVICE_GENERATED_COMMANDS_EXTENSION_NAME = "VK_NV_device_generated_commands";

        public static readonly delegate*<
            VkCommandBuffer,     /* commandBuffer */
            VkPipelineBindPoint, /* pipelineBindPoint */
            VkPipeline,          /* pipeline */
            uint,                /* groupIndex */
            void> vkCmdBindPipelineShaderGroupNV = null;

        public static readonly delegate*<
            VkCommandBuffer,            /* commandBuffer */
            uint,                       /* isPreprocessed */
            VkGeneratedCommandsInfoNV*, /* pGeneratedCommandsInfo */
            void> vkCmdExecuteGeneratedCommandsNV = null;

        public static readonly delegate*<
            VkCommandBuffer,            /* commandBuffer */
            VkGeneratedCommandsInfoNV*, /* pGeneratedCommandsInfo */
            void> vkCmdPreprocessGeneratedCommandsNV = null;

        public static readonly delegate*<
            VkDevice,                              /* device */
            VkIndirectCommandsLayoutCreateInfoNV*, /* pCreateInfo */
            VkAllocationCallbacks*,                /* pAllocator */
            VkIndirectCommandsLayoutNV*,           /* pIndirectCommandsLayout */
            VkResult> vkCreateIndirectCommandsLayoutNV = null;

        public static readonly delegate*<
            VkDevice,                   /* device */
            VkIndirectCommandsLayoutNV, /* indirectCommandsLayout */
            VkAllocationCallbacks*,     /* pAllocator */
            void> vkDestroyIndirectCommandsLayoutNV = null;

        public static readonly delegate*<
            VkDevice,                                     /* device */
            VkGeneratedCommandsMemoryRequirementsInfoNV*, /* pInfo */
            VkMemoryRequirements2*,                       /* pMemoryRequirements */
            void> vkGetGeneratedCommandsMemoryRequirementsNV = null;

        public static partial void Load(VkDevice vkDevice);
    }

    [Flags]
    public enum VkIndirectCommandsLayoutUsageFlagsNV
    {
        EXPLICIT_PREPROCESS_BIT_NV = 0x00000001,
        INDEXED_SEQUENCES_BIT_NV   = 0x00000002,
        UNORDERED_SEQUENCES_BIT_NV = 0x00000004,
        FLAG_BITS_MAX_ENUM_NV      = 0x7FFFFFFF
    }

    public enum VkIndirectCommandsTokenTypeNV
    {
        SHADER_GROUP_NV  = 0,
        STATE_FLAGS_NV   = 1,
        INDEX_BUFFER_NV  = 2,
        VERTEX_BUFFER_NV = 3,
        PUSH_CONSTANT_NV = 4,
        DRAW_INDEXED_NV  = 5,
        DRAW_NV          = 6,
        DRAW_TASKS_NV    = 7,
        MAX_ENUM_NV      = 0x7FFFFFFF
    }

    [Flags]
    public enum VkIndirectStateFlagsNV
    {
        FRONTFACE_BIT_NV = 0x00000001,
        BITS_MAX_ENUM_NV = 0x7FFFFFFF
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct VkBindIndexBufferIndirectCommandNV
    {
        public VkDeviceAddress bufferAddress;
        public uint            size;
        public VkIndexType     indexType;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct VkBindShaderGroupIndirectCommandNV
    {
        public uint groupIndex;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct VkBindVertexBufferIndirectCommandNV
    {
        public VkDeviceAddress bufferAddress;
        public uint            size;
        public uint            stride;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkGeneratedCommandsInfoNV
    {
        public const VkStructureType             STYPE = VkStructureType.GENERATED_COMMANDS_INFO_NV;
        public       VkStructureType             sType;
        public       void*                       pNext;
        public       VkPipelineBindPoint         pipelineBindPoint;
        public       VkPipeline                  pipeline;
        public       VkIndirectCommandsLayoutNV  indirectCommandsLayout;
        public       uint                        streamCount;
        public       VkIndirectCommandsStreamNV* pStreams;
        public       uint                        sequencesCount;
        public       VkBuffer                    preprocessBuffer;
        public       VkDeviceSize                preprocessOffset;
        public       VkDeviceSize                preprocessSize;
        public       VkBuffer                    sequencesCountBuffer;
        public       VkDeviceSize                sequencesCountOffset;
        public       VkBuffer                    sequencesIndexBuffer;
        public       VkDeviceSize                sequencesIndexOffset;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkGeneratedCommandsMemoryRequirementsInfoNV
    {
        public const VkStructureType            STYPE = VkStructureType.GENERATED_COMMANDS_MEMORY_REQUIREMENTS_INFO_NV;
        public       VkStructureType            sType;
        public       void*                      pNext;
        public       VkPipelineBindPoint        pipelineBindPoint;
        public       VkPipeline                 pipeline;
        public       VkIndirectCommandsLayoutNV indirectCommandsLayout;
        public       uint                       maxSequencesCount;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkGraphicsShaderGroupCreateInfoNV
    {
        public const VkStructureType                        STYPE = VkStructureType.GRAPHICS_SHADER_GROUP_CREATE_INFO_NV;
        public       VkStructureType                        sType;
        public       void*                                  pNext;
        public       uint                                   stageCount;
        public       VkPipelineShaderStageCreateInfo*       pStages;
        public       VkPipelineVertexInputStateCreateInfo*  pVertexInputState;
        public       VkPipelineTessellationStateCreateInfo* pTessellationState;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkIndirectCommandsLayoutCreateInfoNV
    {
        public const VkStructureType                      STYPE = VkStructureType.INDIRECT_COMMANDS_LAYOUT_CREATE_INFO_NV;
        public       VkStructureType                      sType;
        public       void*                                pNext;
        public       VkIndirectCommandsLayoutUsageFlagsNV flags;
        public       VkPipelineBindPoint                  pipelineBindPoint;
        public       uint                                 tokenCount;
        public       VkIndirectCommandsLayoutTokenNV*     pTokens;
        public       uint                                 streamCount;
        public       uint*                                pStreamStrides;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkIndirectCommandsLayoutTokenNV
    {
        public const VkStructureType               STYPE = VkStructureType.INDIRECT_COMMANDS_LAYOUT_TOKEN_NV;
        public       VkStructureType               sType;
        public       void*                         pNext;
        public       VkIndirectCommandsTokenTypeNV tokenType;
        public       uint                          stream;
        public       uint                          offset;
        public       uint                          vertexBindingUnit;
        public       VkBool32                      vertexDynamicStride;
        public       VkPipelineLayout              pushconstantPipelineLayout;
        public       VkShaderStageFlagBits         pushconstantShaderStageFlags;
        public       uint                          pushconstantOffset;
        public       uint                          pushconstantSize;
        public       VkIndirectStateFlagsNV        indirectStateFlags;
        public       uint                          indexTypeCount;
        public       VkIndexType*                  pIndexTypes;
        public       uint*                         pIndexTypeValues;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct VkIndirectCommandsStreamNV
    {
        public VkBuffer     buffer;
        public VkDeviceSize offset;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct VkSetStateFlagsIndirectCommandNV
    {
        public uint data;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkGraphicsPipelineShaderGroupsCreateInfoNV
    {
        public const VkStructureType                    STYPE = VkStructureType.GRAPHICS_PIPELINE_SHADER_GROUPS_CREATE_INFO_NV;
        public       VkStructureType                    sType;
        public       void*                              pNext;
        public       uint                               groupCount;
        public       VkGraphicsShaderGroupCreateInfoNV* pGroups;
        public       uint                               pipelineCount;
        public       VkPipeline*                        pPipelines;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkPhysicalDeviceDeviceGeneratedCommandsFeaturesNV
    {
        public const VkStructureType STYPE = VkStructureType.PHYSICAL_DEVICE_DEVICE_GENERATED_COMMANDS_FEATURES_NV;
        public       VkStructureType sType;
        public       void*           pNext;
        public       VkBool32        deviceGeneratedCommands;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkPhysicalDeviceDeviceGeneratedCommandsPropertiesNV
    {
        public const VkStructureType STYPE = VkStructureType.PHYSICAL_DEVICE_DEVICE_GENERATED_COMMANDS_PROPERTIES_NV;
        public       VkStructureType sType;
        public       void*           pNext;
        public       uint            maxGraphicsShaderGroupCount;
        public       uint            maxIndirectSequenceCount;
        public       uint            maxIndirectCommandsTokenCount;
        public       uint            maxIndirectCommandsStreamCount;
        public       uint            maxIndirectCommandsTokenOffset;
        public       uint            maxIndirectCommandsStreamStride;
        public       uint            minSequencesCountBufferOffsetAlignment;
        public       uint            minSequencesIndexBufferOffsetAlignment;
        public       uint            minIndirectCommandsBufferOffsetAlignment;
    }

    public readonly unsafe struct VkIndirectCommandsLayoutNV
    {
        public static readonly VkIndirectCommandsLayoutNV Null = (VkIndirectCommandsLayoutNV)null;
#pragma warning disable 649
        private readonly void* _ptr;
#pragma warning restore 649

        public static explicit operator VkIndirectCommandsLayoutNV(void* ptr)
        {
            VkIndirectCommandsLayoutNV value;
            *(void**)&value = ptr;
            return value;
        }

        public static bool operator ==(VkIndirectCommandsLayoutNV left, VkIndirectCommandsLayoutNV right)
        {
            return left._ptr == right._ptr;
        }

        public static bool operator !=(VkIndirectCommandsLayoutNV left, VkIndirectCommandsLayoutNV right)
        {
            return left._ptr != right._ptr;
        }

        public bool Equals(in VkIndirectCommandsLayoutNV obj)
        {
            return obj._ptr == _ptr;
        }

        public override bool Equals(object? obj)
        {
            return obj is VkIndirectCommandsLayoutNV vkIndirectCommandsLayoutNV && Equals(in vkIndirectCommandsLayoutNV);
        }

        public override int GetHashCode()
        {
            return ((IntPtr)_ptr).GetHashCode();
        }

        public static explicit operator void*(VkIndirectCommandsLayoutNV value)
        {
            return value._ptr;
        }
    }
}