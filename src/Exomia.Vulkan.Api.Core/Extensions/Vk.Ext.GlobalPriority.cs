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
public static partial class VkExtGlobalPriority
{
    public const int    VK_EXT_GLOBAL_PRIORITY                = 1;
    public const int    VK_EXT_GLOBAL_PRIORITY_SPEC_VERSION   = 2;
    public const string VK_EXT_GLOBAL_PRIORITY_EXTENSION_NAME = "VK_EXT_global_priority";
}

public enum VkQueueGlobalPriorityEXT
{
    LOW_EXT      = 128,
    MEDIUM_EXT   = 256,
    HIGH_EXT     = 512,
    REALTIME_EXT = 1024,
    MAX_ENUM_EXT = 0x7FFFFFFF
}

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkDeviceQueueGlobalPriorityCreateInfoEXT
{
    public const VkStructureType          STYPE = VkStructureType.DEVICE_QUEUE_GLOBAL_PRIORITY_CREATE_INFO_EXT;
    public       VkStructureType          sType;
    public       void*                    pNext;
    public       VkQueueGlobalPriorityEXT globalPriority;
}