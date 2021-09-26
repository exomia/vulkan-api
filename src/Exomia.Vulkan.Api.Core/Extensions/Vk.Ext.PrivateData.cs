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
namespace Exomia.Vulkan.Api.Core.Extensions
{
    [VkExtGenerator]
    public static unsafe partial class VkExtPrivateData
    {
        public const int    VK_EXT_PRIVATE_DATA                = 1;
        public const int    VK_EXT_PRIVATE_DATA_SPEC_VERSION   = 1;
        public const string VK_EXT_PRIVATE_DATA_EXTENSION_NAME = "VK_EXT_private_data";

        public static delegate*<
            VkDevice,                        /* device */
            VkPrivateDataSlotCreateInfoEXT*, /* pCreateInfo */
            VkAllocationCallbacks*,          /* pAllocator */
            VkPrivateDataSlotEXT*,           /* pPrivateDataSlot */
            VkResult> vkCreatePrivateDataSlotEXT;

        public static delegate*<
            VkDevice,               /* device */
            VkPrivateDataSlotEXT,   /* privateDataSlot */
            VkAllocationCallbacks*, /* pAllocator */
            void> vkDestroyPrivateDataSlotEXT;

        public static delegate*<
            VkDevice,             /* device */
            VkObjectType,         /* objectType */
            ulong,                /* objectHandle */
            VkPrivateDataSlotEXT, /* privateDataSlot */
            ulong,                /* data */
            VkResult> vkSetPrivateDataEXT;

        public static delegate*<
            VkDevice,             /* device */
            VkObjectType,         /* objectType */
            ulong,                /* objectHandle */
            VkPrivateDataSlotEXT, /* privateDataSlot */
            ulong*,               /* pData */
            void> vkGetPrivateDataEXT;

        public static partial void Load(VkDevice vkDevice);
    }

    [Flags]
    public enum VkPrivateDataSlotCreateFlagsEXT
    {
        MAX_ENUM_EXT = 0x7FFFFFFF
    }

    public readonly unsafe struct VkPrivateDataSlotEXT
    {
        public static readonly VkPrivateDataSlotEXT Null = (VkPrivateDataSlotEXT)null;
#pragma warning disable 649
        private readonly void* _ptr;
#pragma warning restore 649

        public static explicit operator VkPrivateDataSlotEXT(void* ptr)
        {
            VkPrivateDataSlotEXT value;
            *(void**)&value = ptr;
            return value;
        }

        public static bool operator ==(VkPrivateDataSlotEXT left, VkPrivateDataSlotEXT right)
        {
            return left._ptr == right._ptr;
        }

        public static bool operator !=(VkPrivateDataSlotEXT left, VkPrivateDataSlotEXT right)
        {
            return left._ptr != right._ptr;
        }

        public bool Equals(in VkPrivateDataSlotEXT obj)
        {
            return obj._ptr == _ptr;
        }

        public override bool Equals(object? obj)
        {
            return obj is VkPrivateDataSlotEXT vkPrivateDataSlotEXT && Equals(in vkPrivateDataSlotEXT);
        }

        public override int GetHashCode()
        {
            return ((IntPtr)_ptr).GetHashCode();
        }

        public static explicit operator void*(VkPrivateDataSlotEXT value)
        {
            return value._ptr;
        }
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkPhysicalDevicePrivateDataFeaturesEXT
    {
        public const VkStructureType STYPE = VkStructureType.PHYSICAL_DEVICE_PRIVATE_DATA_FEATURES_EXT;
        public       VkStructureType sType;
        public       void*           pNext;
        public       VkBool32        privateData;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkDevicePrivateDataCreateInfoEXT
    {
        public const VkStructureType STYPE = VkStructureType.DEVICE_PRIVATE_DATA_CREATE_INFO_EXT;
        public       VkStructureType sType;
        public       void*           pNext;
        public       uint            privateDataSlotRequestCount;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkPrivateDataSlotCreateInfoEXT
    {
        public const VkStructureType                 STYPE = VkStructureType.PRIVATE_DATA_SLOT_CREATE_INFO_EXT;
        public       VkStructureType                 sType;
        public       void*                           pNext;
        public       VkPrivateDataSlotCreateFlagsEXT flags;
    }
}