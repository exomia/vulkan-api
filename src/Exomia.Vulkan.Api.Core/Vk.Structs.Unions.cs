#region License

// Copyright (c) 2018-2020, exomia
// All rights reserved.
// 
// This source code is licensed under the BSD-style license found in the
// LICENSE file in the root directory of this source tree.

#endregion

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

using System.Runtime.InteropServices;

// ReSharper disable UnusedMember.Global
namespace Exomia.Vulkan.Api.Core
{
    [StructLayout(LayoutKind.Explicit)]
    public unsafe struct VkClearColorValue
    {
        [FieldOffset(0)]
        public fixed float float32[4];

        [FieldOffset(0)]
        public fixed int int32[4];

        [FieldOffset(0)]
        public fixed uint uint32[4];
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct VkClearValue
    {
        [FieldOffset(0)]
        public VkClearColorValue color;

        [FieldOffset(0)]
        public VkClearDepthStencilValue depthStencil;
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct VkPerformanceCounterResultKHR
    {
        [FieldOffset(0)]
        public int int32;

        [FieldOffset(0)]
        public long int64;

        [FieldOffset(0)]
        public uint uint32;

        [FieldOffset(0)]
        public ulong uint64;

        [FieldOffset(0)]
        public float float32;

        [FieldOffset(0)]
        public double float64;
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct VkPipelineExecutableStatisticValueKHR
    {
        [FieldOffset(0)]
        public bool b32;

        [FieldOffset(0)]
        public long i64;

        [FieldOffset(0)]
        public ulong u64;

        [FieldOffset(0)]
        public double f64;
    }

    [StructLayout(LayoutKind.Explicit)]
    public unsafe struct VkPerformanceValueDataINTEL
    {
        [FieldOffset(0)]
        public uint value32;

        [FieldOffset(0)]
        public ulong value64;

        [FieldOffset(0)]
        public float valueFloat;

        [FieldOffset(0)]
        public bool valueBool;

        [FieldOffset(0)]
        public byte* valueString;
    }

    [StructLayout(LayoutKind.Explicit)]
    public unsafe struct VkDeviceOrHostAddressKHR
    {
        [FieldOffset(0)]
        public VkDeviceAddress deviceAddress;

        [FieldOffset(0)]
        public void* hostAddress;
    }

    [StructLayout(LayoutKind.Explicit)]
    public unsafe struct VkDeviceOrHostAddressConstKHR
    {
        [FieldOffset(0)]
        public VkDeviceAddress deviceAddress;

        [FieldOffset(0)]
        public void* hostAddress;
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct VkAccelerationStructureGeometryDataKHR
    {
        [FieldOffset(0)]
        public VkAccelerationStructureGeometryTrianglesDataKHR triangles;

        [FieldOffset(0)]
        public VkAccelerationStructureGeometryAabbsDataKHR aabbs;

        [FieldOffset(0)]
        public VkAccelerationStructureGeometryInstancesDataKHR instances;
    }
}