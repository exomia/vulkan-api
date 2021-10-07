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
    public unsafe struct VkDisplayPropertiesKHR
    {
        public VkDisplayKHR               display;
        public sbyte*                     displayName;
        public VkExtent2D                 physicalDimensions;
        public VkExtent2D                 physicalResolution;
        public VkSurfaceTransformFlagsKHR supportedTransforms;
        public VkBool32                   planeReorderPossible;
        public VkBool32                   persistentContent;
    }
}