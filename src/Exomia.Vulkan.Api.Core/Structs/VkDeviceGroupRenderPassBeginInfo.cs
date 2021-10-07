#region License

// Copyright (c) 2018-2021, exomia
// All rights reserved.
// 
// This source code is licensed under the BSD-style license found in the
// LICENSE file in the root directory of this source tree.

#endregion

using System.Runtime.InteropServices;

namespace Exomia.Vulkan.Api.Core
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkDeviceGroupRenderPassBeginInfo
    {
        public const VkStructureType STYPE = VkStructureType.DEVICE_GROUP_RENDER_PASS_BEGIN_INFO;
        public       VkStructureType sType;
        public       void*           pNext;
        public       uint            deviceMask;
        public       uint            deviceRenderAreaCount;
        public       VkRect2D*       pDeviceRenderAreas;
    }
}