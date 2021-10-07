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
    public static unsafe partial class VkExtVertexInputDynamicState
    {
        public const int    VK_EXT_VERTEX_INPUT_DYNAMIC_STATE                = 1;
        public const int    VK_EXT_VERTEX_INPUT_DYNAMIC_STATE_SPEC_VERSION   = 2;
        public const string VK_EXT_VERTEX_INPUT_DYNAMIC_STATE_EXTENSION_NAME = "VK_EXT_vertex_input_dynamic_state";

        public static readonly delegate*<
            VkCommandBuffer,                        /* commandBuffer */
            uint,                                   /* vertexBindingDescriptionCount */
            VkVertexInputBindingDescription2EXT*,   /* pVertexBindingDescriptions */
            uint,                                   /* vertexAttributeDescriptionCount */
            VkVertexInputAttributeDescription2EXT*, /* pVertexAttributeDescriptions */
            void> vkCmdSetVertexInputEXT = null;

        public static partial void Load(VkDevice vkDevice);
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkPhysicalDeviceVertexInputDynamicStateFeaturesEXT
    {
        public const VkStructureType STYPE = VkStructureType.PHYSICAL_DEVICE_VERTEX_INPUT_DYNAMIC_STATE_FEATURES_EXT;
        public       VkStructureType sType;
        public       void*           pNext;
        public       VkBool32        vertexInputDynamicState;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkVertexInputBindingDescription2EXT
    {
        public const VkStructureType   STYPE = VkStructureType.VERTEX_INPUT_BINDING_DESCRIPTION_2_EXT;
        public       VkStructureType   sType;
        public       void*             pNext;
        public       uint              binding;
        public       uint              stride;
        public       VkVertexInputRate inputRate;
        public       uint              divisor;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkVertexInputAttributeDescription2EXT
    {
        public const VkStructureType STYPE = VkStructureType.VERTEX_INPUT_ATTRIBUTE_DESCRIPTION_2_EXT;
        public       VkStructureType sType;
        public       void*           pNext;
        public       uint            location;
        public       uint            binding;
        public       VkFormat        format;
        public       uint            offset;
    }
}