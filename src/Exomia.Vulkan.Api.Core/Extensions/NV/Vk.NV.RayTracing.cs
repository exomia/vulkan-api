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
    public static unsafe partial class VKNvRayTracing
    {
        public const int    VK_NV_RAY_TRACING                = 1;
        public const int    VK_NV_RAY_TRACING_SPEC_VERSION   = 3;
        public const string VK_NV_RAY_TRACING_EXTENSION_NAME = "VK_NV_ray_tracing";

        public static readonly delegate*<
            VkDevice,                                 /* device */
            uint,                                     /* bindInfoCount */
            VkBindAccelerationStructureMemoryInfoNV*, /* pBindInfos */
            VkResult> vkBindAccelerationStructureMemoryNV = null;

        public static readonly delegate*<
            VkCommandBuffer,                /* commandBuffer */
            VkAccelerationStructureInfoNV*, /* pInfo */
            VkBuffer,                       /* instanceData */
            VkDeviceSize,                   /* instanceOffset */
            uint,                           /* update */
            VkAccelerationStructureNV,      /* dst */
            VkAccelerationStructureNV,      /* src */
            VkBuffer,                       /* scratch */
            VkDeviceSize,                   /* scratchOffset */
            void> vkCmdBuildAccelerationStructureNV = null;

        public static readonly delegate*<
            VkCommandBuffer,                    /* commandBuffer */
            VkAccelerationStructureNV,          /* dst */
            VkAccelerationStructureNV,          /* src */
            VkCopyAccelerationStructureModeKHR, /* mode */
            void> vkCmdCopyAccelerationStructureNV = null;

        public static readonly delegate*<
            VkCommandBuffer, /* commandBuffer */
            VkBuffer,        /* raygenShaderBindingTableBuffer */
            VkDeviceSize,    /* raygenShaderBindingOffset */
            VkBuffer,        /* missShaderBindingTableBuffer */
            VkDeviceSize,    /* missShaderBindingOffset */
            VkDeviceSize,    /* missShaderBindingStride */
            VkBuffer,        /* hitShaderBindingTableBuffer */
            VkDeviceSize,    /* hitShaderBindingOffset */
            VkDeviceSize,    /* hitShaderBindingStride */
            VkBuffer,        /* callableShaderBindingTableBuffer */
            VkDeviceSize,    /* callableShaderBindingOffset */
            VkDeviceSize,    /* callableShaderBindingStride */
            uint,            /* width */
            uint,            /* height */
            uint,            /* depth */
            void> vkCmdTraceRaysNV = null;

        public static readonly delegate*<
            VkCommandBuffer,            /* commandBuffer */
            uint,                       /* accelerationStructureCount */
            VkAccelerationStructureNV*, /* pAccelerationStructures */
            VkQueryType,                /* queryType */
            VkQueryPool,                /* queryPool */
            uint,                       /* firstQuery */
            void> vkCmdWriteAccelerationStructuresPropertiesNV = null;

        public static readonly delegate*<
            VkDevice,   /* device */
            VkPipeline, /* pipeline */
            uint,       /* shader */
            VkResult> vkCompileDeferredNV = null;

        public static readonly delegate*<
            VkDevice,                             /* device */
            VkAccelerationStructureCreateInfoNV*, /* pCreateInfo */
            VkAllocationCallbacks*,               /* pAllocator */
            VkAccelerationStructureNV*,           /* pAccelerationStructure */
            VkResult> vkCreateAccelerationStructureNV = null;

        public static readonly delegate*<
            VkDevice,                          /* device */
            VkPipelineCache,                   /* pipelineCache */
            uint,                              /* createInfoCount */
            VkRayTracingPipelineCreateInfoNV*, /* pCreateInfos */
            VkAllocationCallbacks*,            /* pAllocator */
            VkPipeline*,                       /* pPipelines */
            VkResult> vkCreateRayTracingPipelinesNV = null;

        public static readonly delegate*<
            VkDevice,                  /* device */
            VkAccelerationStructureNV, /* accelerationStructure */
            VkAllocationCallbacks*,    /* pAllocator */
            void> vkDestroyAccelerationStructureNV = null;

        public static readonly delegate*<
            VkDevice,                  /* device */
            VkAccelerationStructureNV, /* accelerationStructure */
            nuint,                     /* dataSize */
            void*,                     /* pData */
            VkResult> vkGetAccelerationStructureHandleNV = null;

        public static readonly delegate*<
            VkDevice,                                         /* device */
            VkAccelerationStructureMemoryRequirementsInfoNV*, /* pInfo */
            VkMemoryRequirements2*,                           /* pMemoryRequirements */
            void> vkGetAccelerationStructureMemoryRequirementsNV = null;

        public static readonly delegate*<
            VkDevice,   /* device */
            VkPipeline, /* pipeline */
            uint,       /* firstGroup */
            uint,       /* groupCount */
            nuint,      /* dataSize */
            void*,      /* pData */
            VkResult> vkGetRayTracingShaderGroupHandlesNV = null;

        public static partial void Load(VkDevice vkDevice);
    }

    public enum VkAccelerationStructureMemoryRequirementsTypeNV
    {
        OBJECT_NV         = 0,
        BUILD_SCRATCH_NV  = 1,
        UPDATE_SCRATCH_NV = 2,
        MAX_ENUM_NV       = 0x7FFFFFFF
    }

    public enum VkAccelerationStructureTypeKHR
    {
        TOP_LEVEL_KHR    = 0,
        BOTTOM_LEVEL_KHR = 1,
        GENERIC_KHR      = 2,
        TOP_LEVEL_NV     = TOP_LEVEL_KHR,
        BOTTOM_LEVEL_NV  = BOTTOM_LEVEL_KHR,
        MAX_ENUM_KHR     = 0x7FFFFFFF
    }

    [Flags]
    public enum VkBuildAccelerationStructureFlagsNV : uint
    {
        /// <summary>
        ///     Reserved for future use
        /// </summary>
        Reserved = 0
    }

    public enum VkCopyAccelerationStructureModeKHR
    {
        CLONE_KHR       = 0,
        COMPACT_KHR     = 1,
        SERIALIZE_KHR   = 2,
        DESERIALIZE_KHR = 3,
        CLONE_NV        = CLONE_KHR,
        COMPACT_NV      = COMPACT_KHR,
        MAX_ENUM_KHR    = 0x7FFFFFFF
    }

    [Flags]
    public enum VkGeometryFlagsKHR
    {
        OPAQUE_BIT_KHR                          = 0x00000001,
        NO_DUPLICATE_ANY_HIT_INVOCATION_BIT_KHR = 0x00000002,
        OPAQUE_BIT_NV                           = OPAQUE_BIT_KHR,
        NO_DUPLICATE_ANY_HIT_INVOCATION_BIT_NV  = NO_DUPLICATE_ANY_HIT_INVOCATION_BIT_KHR,
        FLAG_BITS_MAX_ENUM_KHR                  = 0x7FFFFFFF
    }

    [Flags]
    public enum VkGeometryInstanceFlagsKHR
    {
        TRIANGLE_FACING_CULL_DISABLE_BIT_KHR    = 0x00000001,
        TRIANGLE_FRONT_COUNTERCLOCKWISE_BIT_KHR = 0x00000002,
        FORCE_OPAQUE_BIT_KHR                    = 0x00000004,
        FORCE_NO_OPAQUE_BIT_KHR                 = 0x00000008,
        TRIANGLE_CULL_DISABLE_BIT_NV            = TRIANGLE_FACING_CULL_DISABLE_BIT_KHR,
        TRIANGLE_FRONT_COUNTERCLOCKWISE_BIT_NV  = TRIANGLE_FRONT_COUNTERCLOCKWISE_BIT_KHR,
        FORCE_OPAQUE_BIT_NV                     = FORCE_OPAQUE_BIT_KHR,
        FORCE_NO_OPAQUE_BIT_NV                  = FORCE_NO_OPAQUE_BIT_KHR,
        FLAG_BITS_MAX_ENUM_KHR                  = 0x7FFFFFFF
    }

    public enum VkGeometryTypeKHR
    {
        TRIANGLES_KHR = 0,
        AABBS_KHR     = 1,
        INSTANCES_KHR = 2,
        TRIANGLES_NV  = TRIANGLES_KHR,
        AABBS_NV      = AABBS_KHR,
        MAX_ENUM_KHR  = 0x7FFFFFFF
    }

    public enum VkRayTracingShaderGroupTypeKHR
    {
        GENERAL_KHR              = 0,
        TRIANGLES_HIT_GROUP_KHR  = 1,
        PROCEDURAL_HIT_GROUP_KHR = 2,
        GENERAL_NV               = GENERAL_KHR,
        TRIANGLES_HIT_GROUP_NV   = TRIANGLES_HIT_GROUP_KHR,
        PROCEDURAL_HIT_GROUP_NV  = PROCEDURAL_HIT_GROUP_KHR,
        MAX_ENUM_KHR             = 0x7FFFFFFF
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct VkAabbPositionsKHR
    {
        public float minX;
        public float minY;
        public float minZ;
        public float maxX;
        public float maxY;
        public float maxZ;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkAccelerationStructureCreateInfoNV
    {
        public const VkStructureType               STYPE = VkStructureType.ACCELERATION_STRUCTURE_CREATE_INFO_NV;
        public       VkStructureType               sType;
        public       void*                         pNext;
        public       VkDeviceSize                  compactedSize;
        public       VkAccelerationStructureInfoNV info;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkAccelerationStructureInfoNV
    {
        public const VkStructureType                     STYPE = VkStructureType.ACCELERATION_STRUCTURE_INFO_NV;
        public       VkStructureType                     sType;
        public       void*                               pNext;
        public       VkAccelerationStructureTypeKHR      type;
        public       VkBuildAccelerationStructureFlagsNV flags;
        public       uint                                instanceCount;
        public       uint                                geometryCount;
        public       VkGeometryNV*                       pGeometries;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct VkAccelerationStructureInstanceKHR
    {
        public  VkTransformMatrixKHR transform;
        private uint                 value1;
        private uint                 value2;
        public  ulong                accelerationStructureReference;

        public uint InstanceCustomIndex
        {
            get { return value1 & 0x00FFFFFF; }
            set { value1 = (value1 & 0xFF000000) | (value & 0x00FFFFFF); }
        }

        public uint Mask
        {
            get { return value1 >> 24; }
            set { value1 = (value << 24) | (value1 & 0x00FFFFFF); }
        }

        public uint InstanceShaderBindingTableRecordOffset
        {
            get { return value2 & 0x00FFFFFF; }
            set { value2 = (value2 & 0xFF000000) | (value & 0x00FFFFFF); }
        }

        public VkGeometryInstanceFlagsKHR FlagBits
        {
            get { return (VkGeometryInstanceFlagsKHR)(value2 >> 24); }
            set { value2 = ((uint)value << 24) | (value2 & 0x00FFFFFF); }
        }
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkAccelerationStructureMemoryRequirementsInfoNV
    {
        public const VkStructureType                                 STYPE = VkStructureType.ACCELERATION_STRUCTURE_MEMORY_REQUIREMENTS_INFO_NV;
        public       VkStructureType                                 sType;
        public       void*                                           pNext;
        public       VkAccelerationStructureMemoryRequirementsTypeNV type;
        public       VkAccelerationStructureNV                       accelerationStructure;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkBindAccelerationStructureMemoryInfoNV
    {
        public const VkStructureType           STYPE = VkStructureType.BIND_ACCELERATION_STRUCTURE_MEMORY_INFO_NV;
        public       VkStructureType           sType;
        public       void*                     pNext;
        public       VkAccelerationStructureNV accelerationStructure;
        public       VkDeviceMemory            memory;
        public       VkDeviceSize              memoryOffset;
        public       uint                      deviceIndexCount;
        public       uint*                     pDeviceIndices;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkGeometryAABBNV
    {
        public const VkStructureType STYPE = VkStructureType.GEOMETRY_AABB_NV;
        public       VkStructureType sType;
        public       void*           pNext;
        public       VkBuffer        aabbData;
        public       uint            numAABBs;
        public       uint            stride;
        public       VkDeviceSize    offset;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct VkGeometryDataNV
    {
        public VkGeometryTrianglesNV triangles;
        public VkGeometryAABBNV      aabbs;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkGeometryNV
    {
        public const VkStructureType    STYPE = VkStructureType.GEOMETRY_NV;
        public       VkStructureType    sType;
        public       void*              pNext;
        public       VkGeometryTypeKHR  geometryType;
        public       VkGeometryDataNV   geometry;
        public       VkGeometryFlagsKHR flags;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkGeometryTrianglesNV
    {
        public const VkStructureType STYPE = VkStructureType.GEOMETRY_TRIANGLES_NV;
        public       VkStructureType sType;
        public       void*           pNext;
        public       VkBuffer        vertexData;
        public       VkDeviceSize    vertexOffset;
        public       uint            vertexCount;
        public       VkDeviceSize    vertexStride;
        public       VkFormat        vertexFormat;
        public       VkBuffer        indexData;
        public       VkDeviceSize    indexOffset;
        public       uint            indexCount;
        public       VkIndexType     indexType;
        public       VkBuffer        transformData;
        public       VkDeviceSize    transformOffset;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkMemoryRequirements2
    {
        public const VkStructureType      STYPE = VkStructureType.MEMORY_REQUIREMENTS_2;
        public       VkStructureType      sType;
        public       void*                pNext;
        public       VkMemoryRequirements memoryRequirements;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkRayTracingPipelineCreateInfoNV
    {
        public const VkStructureType                      STYPE = VkStructureType.RAY_TRACING_PIPELINE_CREATE_INFO_NV;
        public       VkStructureType                      sType;
        public       void*                                pNext;
        public       VkPipelineCreateFlagBits             flags;
        public       uint                                 stageCount;
        public       VkPipelineShaderStageCreateInfo*     pStages;
        public       uint                                 groupCount;
        public       VkRayTracingShaderGroupCreateInfoNV* pGroups;
        public       uint                                 maxRecursionDepth;
        public       VkPipelineLayout                     layout;
        public       VkPipeline                           basePipelineHandle;
        public       int                                  basePipelineIndex;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkRayTracingShaderGroupCreateInfoNV
    {
        public const VkStructureType                STYPE = VkStructureType.RAY_TRACING_SHADER_GROUP_CREATE_INFO_NV;
        public       VkStructureType                sType;
        public       void*                          pNext;
        public       VkRayTracingShaderGroupTypeKHR type;
        public       uint                           generalShader;
        public       uint                           closestHitShader;
        public       uint                           anyHitShader;
        public       uint                           intersectionShader;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct VkTransformMatrixKHR
    {
        public float M11;
        public float M12;
        public float M13;
        public float M14;
        public float M21;
        public float M22;
        public float M23;
        public float M24;
        public float M31;
        public float M32;
        public float M33;
        public float M34;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkPhysicalDeviceRayTracingPropertiesNV
    {
        public const VkStructureType STYPE = VkStructureType.PHYSICAL_DEVICE_RAY_TRACING_PROPERTIES_NV;
        public       VkStructureType sType;
        public       void*           pNext;
        public       uint            shaderGroupHandleSize;
        public       uint            maxRecursionDepth;
        public       uint            maxShaderGroupStride;
        public       uint            shaderGroupBaseAlignment;
        public       ulong           maxGeometryCount;
        public       ulong           maxInstanceCount;
        public       ulong           maxTriangleCount;
        public       uint            maxDescriptorSetAccelerationStructures;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkWriteDescriptorSetAccelerationStructureNV
    {
        public const VkStructureType            STYPE = VkStructureType.WRITE_DESCRIPTOR_SET_ACCELERATION_STRUCTURE_NV;
        public       VkStructureType            sType;
        public       void*                      pNext;
        public       uint                       accelerationStructureCount;
        public       VkAccelerationStructureNV* pAccelerationStructures;
    }

    public readonly unsafe struct VkAccelerationStructureNV
    {
        public static readonly VkAccelerationStructureNV Null = (VkAccelerationStructureNV)null;
#pragma warning disable 649
        private readonly void* _ptr;
#pragma warning restore 649

        public static explicit operator VkAccelerationStructureNV(void* ptr)
        {
            VkAccelerationStructureNV value;
            *(void**)&value = ptr;
            return value;
        }

        public static bool operator ==(VkAccelerationStructureNV left, VkAccelerationStructureNV right)
        {
            return left._ptr == right._ptr;
        }

        public static bool operator !=(VkAccelerationStructureNV left, VkAccelerationStructureNV right)
        {
            return left._ptr != right._ptr;
        }

        public bool Equals(in VkAccelerationStructureNV obj)
        {
            return obj._ptr == _ptr;
        }

        public override bool Equals(object? obj)
        {
            return obj is VkAccelerationStructureNV vkAccelerationStructureNV && Equals(in vkAccelerationStructureNV);
        }

        public override int GetHashCode()
        {
            return ((IntPtr)_ptr).GetHashCode();
        }

        public static explicit operator void*(VkAccelerationStructureNV value)
        {
            return value._ptr;
        }
    }
}