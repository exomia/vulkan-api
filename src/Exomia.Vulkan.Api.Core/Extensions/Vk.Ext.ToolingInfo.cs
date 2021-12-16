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
public static unsafe partial class VkExtToolingInfo
{
    public const int    VK_EXT_TOOLING_INFO                = 1;
    public const int    VK_EXT_TOOLING_INFO_SPEC_VERSION   = 1;
    public const string VK_EXT_TOOLING_INFO_EXTENSION_NAME = "VK_EXT_tooling_info";

    public static readonly delegate*<
        VkPhysicalDevice,                   /* physicalDevice */
        uint*,                              /* pToolCount */
        VkPhysicalDeviceToolPropertiesEXT*, /* pToolProperties */
        VkResult> vkGetPhysicalDeviceToolPropertiesEXT = null;

    public static partial void Load(VkDevice vkDevice);
}

[Flags]
public enum VkToolPurposeFlagsEXT
{
    VALIDATION_BIT_EXT          = 0x00000001,
    PROFILING_BIT_EXT           = 0x00000002,
    TRACING_BIT_EXT             = 0x00000004,
    ADDITIONAL_FEATURES_BIT_EXT = 0x00000008,
    MODIFYING_FEATURES_BIT_EXT  = 0x00000010,
    DEBUG_REPORTING_BIT_EXT     = 0x00000020,
    DEBUG_MARKERS_BIT_EXT       = 0x00000040,
    FLAG_BITS_MAX_ENUM_EXT      = 0x7FFFFFFF
}

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPhysicalDeviceToolPropertiesEXT
{
    public const VkStructureType       STYPE = VkStructureType.PHYSICAL_DEVICE_TOOL_PROPERTIES_EXT;
    public       VkStructureType       sType;
    public       void*                 pNext;
    public fixed sbyte                 name[(int)Vk.VK_MAX_EXTENSION_NAME_SIZE];
    public fixed sbyte                 version[(int)Vk.VK_MAX_EXTENSION_NAME_SIZE];
    public       VkToolPurposeFlagsEXT purposes;
    public fixed sbyte                 description[(int)Vk.VK_MAX_DESCRIPTION_SIZE];
    public fixed sbyte                 layer[(int)Vk.VK_MAX_EXTENSION_NAME_SIZE];
}