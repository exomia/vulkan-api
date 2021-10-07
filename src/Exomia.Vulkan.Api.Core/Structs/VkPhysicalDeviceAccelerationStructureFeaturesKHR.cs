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
    public unsafe struct VkPhysicalDeviceAccelerationStructureFeaturesKHR
    {
        public const VkStructureType STYPE = VkStructureType.PHYSICAL_DEVICE_ACCELERATION_STRUCTURE_FEATURES_KHR;
        public       VkStructureType sType;
        public       void*           pNext;
        public       VkBool32        accelerationStructure;
        public       VkBool32        accelerationStructureCaptureReplay;
        public       VkBool32        accelerationStructureIndirectBuild;
        public       VkBool32        accelerationStructureHostCommands;
        public       VkBool32        descriptorBindingAccelerationStructureUpdateAfterBind;
    }
}