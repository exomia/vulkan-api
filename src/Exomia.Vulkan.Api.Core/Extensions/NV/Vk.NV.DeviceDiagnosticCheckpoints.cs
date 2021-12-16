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
namespace Exomia.Vulkan.Api.Core.Extensions.NV;

[VkExtGenerator]
public static unsafe partial class VkNvDeviceDiagnosticCheckpoints
{
    public const int    VK_NV_DEVICE_DIAGNOSTIC_CHECKPOINTS                = 1;
    public const int    VK_NV_DEVICE_DIAGNOSTIC_CHECKPOINTS_SPEC_VERSION   = 2;
    public const string VK_NV_DEVICE_DIAGNOSTIC_CHECKPOINTS_EXTENSION_NAME = "VK_NV_device_diagnostic_checkpoints";

    public static readonly delegate*<
        VkCommandBuffer, /* commandBuffer */
        void*,           /* pCheckpointMarker */
        void> vkCmdSetCheckpointNV = null;

    public static readonly delegate*<
        VkQueue,             /* queue */
        uint*,               /* pCheckpointDataCount */
        VkCheckpointDataNV*, /* pCheckpointData */
        void> vkGetQueueCheckpointDataNV = null;

    public static partial void Load(VkDevice vkDevice);
}

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkCheckpointDataNV
{
    public const VkStructureType         STYPE = VkStructureType.CHECKPOINT_DATA_NV;
    public       VkStructureType         sType;
    public       void*                   pNext;
    public       VkPipelineStageFlagBits stage;
    public       void*                   pCheckpointMarker;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkQueueFamilyCheckpointPropertiesNV
{
    public const VkStructureType         STYPE = VkStructureType.QUEUE_FAMILY_CHECKPOINT_PROPERTIES_NV;
    public       VkStructureType         sType;
    public       void*                   pNext;
    public       VkPipelineStageFlagBits checkpointExecutionStageMask;
}