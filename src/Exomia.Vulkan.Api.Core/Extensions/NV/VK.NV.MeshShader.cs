#region License

// Copyright (c) 2018-2021, exomia
// All rights reserved.
// 
// This source code is licensed under the BSD-style license found in the
// LICENSE file in the root directory of this source tree.

#endregion

#pragma warning disable CA2211 // Non-constant fields should not be visible
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

// ReSharper disable UnusedMember.Global
// ReSharper disable InconsistentNaming
namespace Exomia.Vulkan.Api.Core.Extensions.NV
{
    [VkExtGenerator]
    public static unsafe partial class VkExtAcquireDrmDisplay
    {
        public const int    VK_EXT_ACQUIRE_DRM_DISPLAY                = 1;
        public const int    VK_EXT_ACQUIRE_DRM_DISPLAY_SPEC_VERSION   = 1;
        public const string VK_EXT_ACQUIRE_DRM_DISPLAY_EXTENSION_NAME = "VK_NV_mesh_shader";
        public static readonly delegate*<
    VkCommandBuffer, /* commandBuffer */
    VkBuffer, /* buffer */
    VkDeviceSize, /* offset */
    VkBuffer, /* countBuffer */
    VkDeviceSize, /* countBufferOffset */
    uint, /* maxDrawCount */
    uint, /* stride */
    void> vkCmdDrawMeshTasksIndirectCountNV = null;

public static readonly delegate*<
    VkCommandBuffer, /* commandBuffer */
    VkBuffer, /* buffer */
    VkDeviceSize, /* offset */
    uint, /* drawCount */
    uint, /* stride */
    void> vkCmdDrawMeshTasksIndirectNV = null;

public static readonly delegate*<
    VkCommandBuffer, /* commandBuffer */
    uint, /* taskCount */
    uint, /* firstTask */
    void> vkCmdDrawMeshTasksNV = null;

        public static partial void Load(VkInstance vkInstance);
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct VkDrawMeshTasksIndirectCommandNV
    {
        public uint taskCount;
        public uint firstTask;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkPhysicalDeviceMeshShaderFeaturesNV
    {
        public const VkStructureType STYPE = VkStructureType.PHYSICAL_DEVICE_MESH_SHADER_FEATURES_NV;
        public       VkStructureType sType;
        public       void*           pNext;
        public       VkBool32        taskShader;
        public       VkBool32        meshShader;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkPhysicalDeviceMeshShaderPropertiesNV
    {
        public const VkStructureType STYPE = VkStructureType.PHYSICAL_DEVICE_MESH_SHADER_PROPERTIES_NV;
        public       VkStructureType sType;
        public       void*           pNext;
        public       uint            maxDrawMeshTasksCount;
        public       uint            maxTaskWorkGroupInvocations;
        public fixed uint            maxTaskWorkGroupSize[3];
        public       uint            maxTaskTotalMemorySize;
        public       uint            maxTaskOutputCount;
        public       uint            maxMeshWorkGroupInvocations;
        public fixed uint            maxMeshWorkGroupSize[3];
        public       uint            maxMeshTotalMemorySize;
        public       uint            maxMeshOutputVertices;
        public       uint            maxMeshOutputPrimitives;
        public       uint            maxMeshMultiviewViewCount;
        public       uint            meshOutputPerVertexGranularity;
        public       uint            meshOutputPerPrimitiveGranularity;
    }
}