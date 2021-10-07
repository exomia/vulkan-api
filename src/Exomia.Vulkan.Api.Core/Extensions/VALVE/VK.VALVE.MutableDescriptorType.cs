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
namespace Exomia.Vulkan.Api.Core.Extensions.VALVE
{
    [VkExtGenerator]
    public static unsafe partial class VKValveMutableDescriptorType
    {
        public const int    VK_VALVE_MUTABLE_DESCRIPTOR_TYPE                = 1;
        public const int    VK_VALVE_MUTABLE_DESCRIPTOR_TYPE_SPEC_VERSION   = 1;
        public const string VK_VALVE_MUTABLE_DESCRIPTOR_TYPE_EXTENSION_NAME = "VK_VALVE_mutable_descriptor_type";
        
        

        public static partial void Load(VkInstance vkInstance);
    }




    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkMutableDescriptorTypeListVALVE
    {
        public uint              descriptorTypeCount;
        public VkDescriptorType* pDescriptorTypes;
    }


    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkMutableDescriptorTypeCreateInfoVALVE
    {
        public const VkStructureType                   STYPE = VkStructureType.MUTABLE_DESCRIPTOR_TYPE_CREATE_INFO_VALVE;
        public       VkStructureType                   sType;
        public       void*                             pNext;
        public       uint                              mutableDescriptorTypeListCount;
        public       VkMutableDescriptorTypeListVALVE* pMutableDescriptorTypeLists;
    }

    

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkPhysicalDeviceMutableDescriptorTypeFeaturesVALVE
    {
        public const VkStructureType STYPE = VkStructureType.PHYSICAL_DEVICE_MUTABLE_DESCRIPTOR_TYPE_FEATURES_VALVE;
        public       VkStructureType sType;
        public       void*           pNext;
        public       VkBool32        mutableDescriptorType;
    }




}