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
    public unsafe struct VkDebugMarkerObjectNameInfoEXT
    {
        public const VkStructureType            STYPE = VkStructureType.DEBUG_MARKER_OBJECT_NAME_INFO_EXT;
        public       VkStructureType            sType;
        public       void*                      pNext;
        public       VkDebugReportObjectTypeEXT objectType;
        public       ulong                      @object;
        public       sbyte*                     pObjectName;
    }


    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkDebugMarkerObjectTagInfoEXT
    {
        public const VkStructureType            STYPE = VkStructureType.DEBUG_MARKER_OBJECT_TAG_INFO_EXT;
        public       VkStructureType            sType;
        public       void*                      pNext;
        public       VkDebugReportObjectTypeEXT objectType;
        public       ulong                      @object;
        public       ulong                      tagName;
        public       nuint                      tagSize;
        public       void*                      pTag;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkDebugMarkerMarkerInfoEXT
    {
        public const VkStructureType STYPE = VkStructureType.DEBUG_MARKER_MARKER_INFO_EXT;
        public       VkStructureType sType;
        public       void*           pNext;
        public       sbyte*          pMarkerName;
        public fixed float           color[4];
    }
}