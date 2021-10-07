#region License

// Copyright (c) 2018-2021, exomia
// All rights reserved.
// 
// This source code is licensed under the BSD-style license found in the
// LICENSE file in the root directory of this source tree.

#endregion

#pragma warning disable CA2211 // Non-constant fields should not be visible
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

using System.Runtime.InteropServices;
using Exomia.Vulkan.Api.SourceGenerator;

// ReSharper disable UnusedMember.Global
// ReSharper disable InconsistentNaming
namespace Exomia.Vulkan.Api.Core.Extensions
{
    [VkExtGenerator]
    public static unsafe partial class VkExtExtendedDynamicState2
    {
        public const int    VK_EXT_EXTENDED_DYNAMIC_STATE2                 = 1;
        public const int    VK_EXT_EXTENDED_DYNAMIC_STATE_2_SPEC_VERSION   = 1;
        public const string VK_EXT_EXTENDED_DYNAMIC_STATE_2_EXTENSION_NAME = "VK_EXT_extended_dynamic_state2";

        public static readonly delegate*<
            VkCommandBuffer, /* commandBuffer */
            uint,            /* patchControlPoints */
            void> vkCmdSetPatchControlPointsEXT = null;

        public static readonly delegate*<
            VkCommandBuffer, /* commandBuffer */
            VkBool32,        /* rasterizerDiscardEnable */
            void> vkCmdSetRasterizerDiscardEnableEXT = null;

        public static readonly delegate*<
            VkCommandBuffer, /* commandBuffer */
            VkBool32,        /* depthBiasEnable */
            void> vkCmdSetDepthBiasEnableEXT = null;

        public static readonly delegate*<
            VkCommandBuffer, /* commandBuffer */
            VkLogicOp,       /* logicOp */
            void> vkCmdSetLogicOpEXT = null;

        public static readonly delegate*<
            VkCommandBuffer, /* commandBuffer */
            VkBool32,        /* primitiveRestartEnable */
            void> vkCmdSetPrimitiveRestartEnableEXT = null;

        public static partial void Load(VkDevice vkDevice);
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkPhysicalDeviceExtendedDynamicState2FeaturesEXT
    {
        public const VkStructureType STYPE = VkStructureType.PHYSICAL_DEVICE_EXTENDED_DYNAMIC_STATE_2_FEATURES_EXT;
        public       VkStructureType sType;
        public       void*           pNext;
        public       VkBool32        extendedDynamicState2;
        public       VkBool32        extendedDynamicState2LogicOp;
        public       VkBool32        extendedDynamicState2PatchControlPoints;
    }
}