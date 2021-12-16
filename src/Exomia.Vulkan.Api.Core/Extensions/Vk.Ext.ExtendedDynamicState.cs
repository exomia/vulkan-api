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
namespace Exomia.Vulkan.Api.Core.Extensions;

[VkExtGenerator]
public static unsafe partial class VkExtExtendedDynamicState
{
    public const int    VK_EXT_EXTENDED_DYNAMIC_STATE                = 1;
    public const int    VK_EXT_EXTENDED_DYNAMIC_STATE_SPEC_VERSION   = 1;
    public const string VK_EXT_EXTENDED_DYNAMIC_STATE_EXTENSION_NAME = "VK_EXT_extended_dynamic_state";

    public static readonly delegate*<
        VkCommandBuffer,    /* commandBuffer */
        VkCullModeFlagBits, /* cullMode */
        void> vkCmdSetCullModeEXT = null;

    public static readonly delegate*<
        VkCommandBuffer, /* commandBuffer */
        VkFrontFace,     /* frontFace */
        void> vkCmdSetFrontFaceEXT = null;

    public static readonly delegate*<
        VkCommandBuffer,     /* commandBuffer */
        VkPrimitiveTopology, /* primitiveTopology */
        void> vkCmdSetPrimitiveTopologyEXT = null;

    public static readonly delegate*<
        VkCommandBuffer, /* commandBuffer */
        uint,            /* viewportCount */
        VkViewport*,     /* pViewports */
        void> vkCmdSetViewportWithCountEXT = null;

    public static readonly delegate*<
        VkCommandBuffer, /* commandBuffer */
        uint,            /* scissorCount */
        VkRect2D*,       /* pScissors */
        void> vkCmdSetScissorWithCountEXT = null;

    public static readonly delegate*<
        VkCommandBuffer, /* commandBuffer */
        uint,            /* firstBinding */
        uint,            /* bindingCount */
        VkBuffer*,       /* pBuffers */
        VkDeviceSize*,   /* pOffsets */
        VkDeviceSize*,   /* pSizes */
        VkDeviceSize*,   /* pStrides */
        void> vkCmdBindVertexBuffers2EXT = null;

    public static readonly delegate*<
        VkCommandBuffer, /* commandBuffer */
        uint,            /* depthTestEnable */
        void> vkCmdSetDepthTestEnableEXT = null;

    public static readonly delegate*<
        VkCommandBuffer, /* commandBuffer */
        uint,            /* depthWriteEnable */
        void> vkCmdSetDepthWriteEnableEXT = null;

    public static readonly delegate*<
        VkCommandBuffer, /* commandBuffer */
        VkCompareOp,     /* depthCompareOp */
        void> vkCmdSetDepthCompareOpEXT = null;

    public static readonly delegate*<
        VkCommandBuffer, /* commandBuffer */
        uint,            /* depthBoundsTestEnable */
        void> vkCmdSetDepthBoundsTestEnableEXT = null;

    public static readonly delegate*<
        VkCommandBuffer, /* commandBuffer */
        uint,            /* stencilTestEnable */
        void> vkCmdSetStencilTestEnableEXT = null;

    public static readonly delegate*<
        VkCommandBuffer,       /* commandBuffer */
        VkStencilFaceFlagBits, /* faceMask */
        VkStencilOp,           /* failOp */
        VkStencilOp,           /* passOp */
        VkStencilOp,           /* depthFailOp */
        VkCompareOp,           /* compareOp */
        void> vkCmdSetStencilOpEXT = null;

    public static partial void Load(VkDevice vkDevice);
}

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPhysicalDeviceExtendedDynamicStateFeaturesEXT
{
    public const VkStructureType STYPE = VkStructureType.PHYSICAL_DEVICE_EXTENDED_DYNAMIC_STATE_FEATURES_EXT;
    public       VkStructureType sType;
    public       void*           pNext;
    public       VkBool32        extendedDynamicState;
}