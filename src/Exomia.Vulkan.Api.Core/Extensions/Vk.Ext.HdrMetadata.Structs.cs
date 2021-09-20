#region License

// Copyright (c) 2018-2021, exomia
// All rights reserved.
// 
// This source code is licensed under the BSD-style license found in the
// LICENSE file in the root directory of this source tree.

#endregion

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

using System.Runtime.InteropServices;

// ReSharper disable UnusedMember.Global
namespace Exomia.Vulkan.Api.Core.Extensions
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkXYColorEXT
    {
        public float x;
        public float y;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkHdrMetadataEXT
    {
        public const VkStructureType STYPE = VkStructureType.HDR_METADATA_EXT;
        public       VkStructureType sType;
        public       void*           pNext;
        public       VkXYColorEXT    displayPrimaryRed;
        public       VkXYColorEXT    displayPrimaryGreen;
        public       VkXYColorEXT    displayPrimaryBlue;
        public       VkXYColorEXT    whitePoint;
        public       float           maxLuminance;
        public       float           minLuminance;
        public       float           maxContentLightLevel;
        public       float           maxFrameAverageLightLevel;
    }
}
