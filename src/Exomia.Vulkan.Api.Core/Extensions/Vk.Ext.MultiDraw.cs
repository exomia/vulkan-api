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
public static unsafe partial class VkExtMultiDraw
{
    public const int    VK_EXT_MULTI_DRAW                = 1;
    public const int    VK_EXT_MULTI_DRAW_SPEC_VERSION   = 1;
    public const string VK_EXT_MULTI_DRAW_EXTENSION_NAME = "VK_EXT_multi_draw";

    public static readonly delegate*<
        VkCommandBuffer,     /* commandBuffer */
        uint,                /* drawCount */
        VkMultiDrawInfoEXT*, /* pVertexInfo */
        uint,                /* instanceCount */
        uint,                /* firstInstance */
        uint,                /* stride */
        void> vkCmdDrawMultiEXT = null;

    public static readonly delegate*<
        VkCommandBuffer,            /* commandBuffer */
        uint,                       /* drawCount */
        VkMultiDrawIndexedInfoEXT*, /* pIndexInfo */
        uint,                       /* instanceCount */
        uint,                       /* firstInstance */
        uint,                       /* stride */
        int*,                       /* pVertexOffset */
        void> vkCmdDrawMultiIndexedEXT = null;

    public static partial void Load(VkDevice vkDevice);
}

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPhysicalDeviceMultiDrawFeaturesEXT
{
    public const VkStructureType STYPE = VkStructureType.PHYSICAL_DEVICE_MULTI_DRAW_FEATURES_EXT;
    public       VkStructureType sType;
    public       void*           pNext;
    public       VkBool32        multiDraw;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPhysicalDeviceMultiDrawPropertiesEXT
{
    public const VkStructureType STYPE = VkStructureType.PHYSICAL_DEVICE_MULTI_DRAW_PROPERTIES_EXT;
    public       VkStructureType sType;
    public       void*           pNext;
    public       uint            maxMultiDrawCount;
}

[StructLayout(LayoutKind.Sequential)]
public struct VkMultiDrawInfoEXT
{
    public uint firstVertex;
    public uint vertexCount;
}

[StructLayout(LayoutKind.Sequential)]
public struct VkMultiDrawIndexedInfoEXT
{
    public uint firstIndex;
    public uint indexCount;
    public int  vertexOffset;
}