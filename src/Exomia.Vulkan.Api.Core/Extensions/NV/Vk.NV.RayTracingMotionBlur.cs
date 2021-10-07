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
    public static partial class VkNvRayTracingMotionBlur
    {
        public const int    VK_NV_RAY_TRACING_MOTION_BLUR                = 1;
        public const int    VK_NV_RAY_TRACING_MOTION_BLUR_SPEC_VERSION   = 1;
        public const string VK_NV_RAY_TRACING_MOTION_BLUR_EXTENSION_NAME = "VK_NV_ray_tracing_motion_blur";
    }

    public enum VkAccelerationStructureMotionInstanceTypeNV
    {
        STATIC_NV        = 0,
        MATRIX_MOTION_NV = 1,
        SRT_MOTION_NV    = 2,
        MAX_ENUM_NV      = 0x7FFFFFFF
    }

    [Flags]
    public enum VkAccelerationStructureMotionInfoFlagsNV : uint
    {
        /// <summary>
        ///     Reserved for future use
        /// </summary>
        Reserved = 0
    }

    [Flags]
    public enum VkAccelerationStructureMotionInstanceFlagsNV : uint
    {
        /// <summary>
        ///     Reserved for future use
        /// </summary>
        Reserved = 0
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct VkAccelerationStructureMatrixMotionInstanceNV
    {
        public VkTransformMatrixKHR transformT0;
        public VkTransformMatrixKHR transformT1;

        private uint value1;

        public uint instanceCustomIndex
        {
            get { return value1 & 0x00FFFFFF; }
            set { value1 = (value1 & 0xFF000000) | (value & 0x00FFFFFF); }
        }

        public uint mask
        {
            get { return value1 >> 24; }
            set { value1 = (value << 24) | (value1 & 0x00FFFFFF); }
        }

        private uint value2;

        public uint instanceShaderBindingTableRecordOffset
        {
            get { return value2 & 0x00FFFFFF; }
            set { value2 = (value2 & 0xFF000000) | (value & 0x00FFFFFF); }
        }

        public VkGeometryInstanceFlagsKHR flags
        {
            get { return (VkGeometryInstanceFlagsKHR)(value2 >> 24); }
            set { value2 = ((uint)value << 24) | (value2 & 0x00FFFFFF); }
        }

        public ulong accelerationStructureReference;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct VkAccelerationStructureMotionInstanceNV
    {
        public VkAccelerationStructureMotionInstanceTypeNV  type;
        public VkAccelerationStructureMotionInstanceFlagsNV flags;
        public VkAccelerationStructureMotionInstanceDataNV  data;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct VkAccelerationStructureSRTMotionInstanceNV
    {
        public  VkSRTDataNV transformT0;
        public  VkSRTDataNV transformT1;
        private uint        value1;

        public uint instanceCustomIndex
        {
            get { return value1 & 0x00FFFFFF; }
            set { value1 = (value1 & 0xFF000000) | (value & 0x00FFFFFF); }
        }

        public uint mask
        {
            get { return value1 >> 24; }
            set { value1 = (value << 24) | (value1 & 0x00FFFFFF); }
        }

        private uint value2;

        public uint instanceShaderBindingTableRecordOffset
        {
            get { return value2 & 0x00FFFFFF; }
            set { value2 = (value2 & 0xFF000000) | (value & 0x00FFFFFF); }
        }

        public VkGeometryInstanceFlagsKHR flags
        {
            get { return (VkGeometryInstanceFlagsKHR)(value2 >> 24); }
            set { value2 = ((uint)value << 24) | (value2 & 0x00FFFFFF); }
        }

        public ulong accelerationStructureReference;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct VkSRTDataNV
    {
        public float sx;
        public float a;
        public float b;
        public float pvx;
        public float sy;
        public float c;
        public float pvy;
        public float sz;
        public float pvz;
        public float qx;
        public float qy;
        public float qz;
        public float qw;
        public float tx;
        public float ty;
        public float tz;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkAccelerationStructureMotionInfoNV
    {
        public const VkStructureType                          STYPE = VkStructureType.ACCELERATION_STRUCTURE_MOTION_INFO_NV;
        public       VkStructureType                          sType;
        public       void*                                    pNext;
        public       uint                                     maxInstances;
        public       VkAccelerationStructureMotionInfoFlagsNV flags;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkAccelerationStructureGeometryMotionTrianglesDataNV
    {
        public const VkStructureType               STYPE = VkStructureType.ACCELERATION_STRUCTURE_GEOMETRY_MOTION_TRIANGLES_DATA_NV;
        public       VkStructureType               sType;
        public       void*                         pNext;
        public       VkDeviceOrHostAddressConstKHR vertexData;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkPhysicalDeviceRayTracingMotionBlurFeaturesNV
    {
        public const VkStructureType STYPE = VkStructureType.PHYSICAL_DEVICE_RAY_TRACING_MOTION_BLUR_FEATURES_NV;
        public       VkStructureType sType;
        public       void*           pNext;
        public       VkBool32        rayTracingMotionBlur;
        public       VkBool32        rayTracingMotionBlurPipelineTraceRaysIndirect;
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct VkAccelerationStructureMotionInstanceDataNV
    {
        [FieldOffset(0)]
        public VkAccelerationStructureInstanceKHR staticInstance;

        [FieldOffset(0)]
        public VkAccelerationStructureMatrixMotionInstanceNV matrixMotionInstance;

        [FieldOffset(0)]
        public VkAccelerationStructureSRTMotionInstanceNV srtMotionInstance;
    }
}