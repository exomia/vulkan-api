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
namespace Exomia.Vulkan.Api.Core.Extensions.NVX
{
    [VkExtGenerator]
    public static partial class VKNvxMultiviewPerViewAttributes
    {
        public const int    VK_NVX_MULTIVIEW_PER_VIEW_ATTRIBUTES                = 1;
        public const int    VK_NVX_MULTIVIEW_PER_VIEW_ATTRIBUTES_SPEC_VERSION   = 1;
        public const string VK_NVX_MULTIVIEW_PER_VIEW_ATTRIBUTES_EXTENSION_NAME = "VK_NVX_multiview_per_view_attributes";
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkPhysicalDeviceMultiviewPerViewAttributesPropertiesNVX
    {
        public const VkStructureType STYPE = VkStructureType.PHYSICAL_DEVICE_MULTIVIEW_PER_VIEW_ATTRIBUTES_PROPERTIES_NVX;
        public       VkStructureType sType;
        public       void*           pNext;
        public       VkBool32        perViewPositionAllComponents;
    }
}