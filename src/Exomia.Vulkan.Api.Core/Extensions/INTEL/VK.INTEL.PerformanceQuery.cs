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
namespace Exomia.Vulkan.Api.Core.Extensions.INTEL
{
    [VkExtGenerator]
    public static unsafe partial class VKIntelPerformanceQuery
    {
        public const int    VK_INTEL_PERFORMANCE_QUERY                = 1;
        public const int    VK_INTEL_PERFORMANCE_QUERY_SPEC_VERSION   = 2;
        public const string VK_INTEL_PERFORMANCE_QUERY_EXTENSION_NAME = "VK_INTEL_performance_query";
        
        public static readonly delegate*<
    VkDevice, /* device */
    VkPerformanceConfigurationAcquireInfoINTEL*, /* pAcquireInfo */
    VkPerformanceConfigurationINTEL*, /* pConfiguration */
    VkResult> vkAcquirePerformanceConfigurationINTEL = null;

public static readonly delegate*<
    VkCommandBuffer, /* commandBuffer */
    VkPerformanceMarkerInfoINTEL*, /* pMarkerInfo */
    VkResult> vkCmdSetPerformanceMarkerINTEL = null;

public static readonly delegate*<
    VkCommandBuffer, /* commandBuffer */
    VkPerformanceOverrideInfoINTEL*, /* pOverrideInfo */
    VkResult> vkCmdSetPerformanceOverrideINTEL = null;

public static readonly delegate*<
    VkCommandBuffer, /* commandBuffer */
    VkPerformanceStreamMarkerInfoINTEL*, /* pMarkerInfo */
    VkResult> vkCmdSetPerformanceStreamMarkerINTEL = null;

public static readonly delegate*<
    VkDevice, /* device */
    VkPerformanceParameterTypeINTEL, /* parameter */
    VkPerformanceValueINTEL*, /* pValue */
    VkResult> vkGetPerformanceParameterINTEL = null;

public static readonly delegate*<
    VkDevice, /* device */
    VkInitializePerformanceApiInfoINTEL*, /* pInitializeInfo */
    VkResult> vkInitializePerformanceApiINTEL = null;

public static readonly delegate*<
    VkQueue, /* queue */
    VkPerformanceConfigurationINTEL, /* configuration */
    VkResult> vkQueueSetPerformanceConfigurationINTEL = null;

public static readonly delegate*<
    VkDevice, /* device */
    VkPerformanceConfigurationINTEL, /* configuration */
    VkResult> vkReleasePerformanceConfigurationINTEL = null;

public static readonly delegate*<
    VkDevice, /* device */
    void> vkUninitializePerformanceApiINTEL = null;



        public static partial void Load(VkDevice vkDevice);
    }


    public enum VkPerformanceConfigurationTypeINTEL
    {
        COMMAND_QUEUE_METRICS_DISCOVERY_ACTIVATED_INTEL = 0,
        MAX_ENUM_INTEL                                  = 0x7FFFFFFF
    }


    public enum VkPerformanceOverrideTypeINTEL
    {
        NULL_HARDWARE_INTEL    = 0,
        FLUSH_GPU_CACHES_INTEL = 1,
        MAX_ENUM_INTEL         = 0x7FFFFFFF
    }


    public enum VkPerformanceParameterTypeINTEL
    {
        HW_COUNTERS_SUPPORTED_INTEL    = 0,
        STREAM_MARKER_VALID_BITS_INTEL = 1,
        MAX_ENUM_INTEL                 = 0x7FFFFFFF
    }


    public enum VkPerformanceValueTypeINTEL
    {
        UINT32_INTEL   = 0,
        UINT64_INTEL   = 1,
        FLOAT_INTEL    = 2,
        BOOL_INTEL     = 3,
        STRING_INTEL   = 4,
        MAX_ENUM_INTEL = 0x7FFFFFFF
    }


    public enum VkQueryPoolSamplingModeINTEL
    {
        MANUAL_INTEL   = 0,
        MAX_ENUM_INTEL = 0x7FFFFFFF
    }




    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkInitializePerformanceApiInfoINTEL
    {
        public const VkStructureType STYPE = VkStructureType.INITIALIZE_PERFORMANCE_API_INFO_INTEL;
        public       VkStructureType sType;
        public       void*           pNext;
        public       void*           pUserData;
    }


    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkPerformanceConfigurationAcquireInfoINTEL
    {
        public const VkStructureType                     STYPE = VkStructureType.PERFORMANCE_CONFIGURATION_ACQUIRE_INFO_INTEL;
        public       VkStructureType                     sType;
        public       void*                               pNext;
        public       VkPerformanceConfigurationTypeINTEL type;
    }


    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkPerformanceMarkerInfoINTEL
    {
        public const VkStructureType STYPE = VkStructureType.PERFORMANCE_MARKER_INFO_INTEL;
        public       VkStructureType sType;
        public       void*           pNext;
        public       ulong           marker;
    }


    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkPerformanceOverrideInfoINTEL
    {
        public const VkStructureType                STYPE = VkStructureType.PERFORMANCE_OVERRIDE_INFO_INTEL;
        public       VkStructureType                sType;
        public       void*                          pNext;
        public       VkPerformanceOverrideTypeINTEL type;
        public       VkBool32                       enable;
        public       ulong                          parameter;
    }


    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkPerformanceStreamMarkerInfoINTEL
    {
        public const VkStructureType STYPE = VkStructureType.PERFORMANCE_STREAM_MARKER_INFO_INTEL;
        public       VkStructureType sType;
        public       void*           pNext;
        public       uint            marker;
    }


    [StructLayout(LayoutKind.Sequential)]
    public struct VkPerformanceValueINTEL
    {
        public VkPerformanceValueTypeINTEL type;
        public VkPerformanceValueDataINTEL data;
    }


    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkQueryPoolPerformanceQueryCreateInfoINTEL
    {
        public const VkStructureType              STYPE = VkStructureType.QUERY_POOL_PERFORMANCE_QUERY_CREATE_INFO_INTEL;
        public       VkStructureType              sType;
        public       void*                        pNext;
        public       VkQueryPoolSamplingModeINTEL performanceCountersSampling;
    }



    public readonly unsafe struct VkPerformanceConfigurationINTEL
    {
        public static readonly VkPerformanceConfigurationINTEL Null = (VkPerformanceConfigurationINTEL)null;
#pragma warning disable 649
        private readonly void* _ptr;
#pragma warning restore 649

        public static explicit operator VkPerformanceConfigurationINTEL(void* ptr)
        {
            VkPerformanceConfigurationINTEL value;
            *(void**)&value = ptr;
            return value;
        }

        public static bool operator ==(VkPerformanceConfigurationINTEL left, VkPerformanceConfigurationINTEL right)
        {
            return left._ptr == right._ptr;
        }

        public static bool operator !=(VkPerformanceConfigurationINTEL left, VkPerformanceConfigurationINTEL right)
        {
            return left._ptr != right._ptr;
        }

        public bool Equals(in VkPerformanceConfigurationINTEL obj)
        {
            return obj._ptr == _ptr;
        }

        public override bool Equals(object? obj)
        {
            return obj is VkPerformanceConfigurationINTEL vkPerformanceConfigurationINTEL && Equals(in vkPerformanceConfigurationINTEL);
        }

        public override int GetHashCode()
        {
            return ((IntPtr)_ptr).GetHashCode();
        }

        public static explicit operator void*(VkPerformanceConfigurationINTEL value)
        {
            return value._ptr;
        }
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
        public VkBool32 valueBool;

        [FieldOffset(0)]
        public sbyte* valueString;
    }


}