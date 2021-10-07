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
namespace Exomia.Vulkan.Api.Core.Extensions.NV
{
    [VkExtGenerator]
    public static unsafe partial class VKNvCooperativeMatrix
    {
        public const int    VK_NV_COOPERATIVE_MATRIX                = 1;
        public const int    VK_NV_COOPERATIVE_MATRIX_SPEC_VERSION   = 1;
        public const string VK_NV_COOPERATIVE_MATRIX_EXTENSION_NAME = "VK_NV_cooperative_matrix";
        
        public static readonly delegate*<
    VkPhysicalDevice, /* physicalDevice */
    uint*, /* pPropertyCount */
    VkCooperativeMatrixPropertiesNV*, /* pProperties */
    VkResult> vkGetPhysicalDeviceCooperativeMatrixPropertiesNV = null;



        public static partial void Load(VkDevice vkDevice);
    }


    public enum VkComponentTypeNV
    {
        FLOAT16_NV  = 0,
        FLOAT32_NV  = 1,
        FLOAT64_NV  = 2,
        SINT8_NV    = 3,
        SINT16_NV   = 4,
        SINT32_NV   = 5,
        SINT64_NV   = 6,
        UINT8_NV    = 7,
        UINT16_NV   = 8,
        UINT32_NV   = 9,
        UINT64_NV   = 10,
        MAX_ENUM_NV = 0x7FFFFFFF
    }


    public enum VkScopeNV
    {
        DEVICE_NV       = 1,
        WORKGROUP_NV    = 2,
        SUBGROUP_NV     = 3,
        QUEUE_FAMILY_NV = 5,
        MAX_ENUM_NV     = 0x7FFFFFFF
    }




    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkCooperativeMatrixPropertiesNV
    {
        public const VkStructureType   STYPE = VkStructureType.COOPERATIVE_MATRIX_PROPERTIES_NV;
        public       VkStructureType   sType;
        public       void*             pNext;
        public       uint              MSize;
        public       uint              NSize;
        public       uint              KSize;
        public       VkComponentTypeNV AType;
        public       VkComponentTypeNV BType;
        public       VkComponentTypeNV CType;
        public       VkComponentTypeNV DType;
        public       VkScopeNV         scope;
    }


    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkPhysicalDeviceCooperativeMatrixFeaturesNV
    {
        public const VkStructureType STYPE = VkStructureType.PHYSICAL_DEVICE_COOPERATIVE_MATRIX_FEATURES_NV;
        public       VkStructureType sType;
        public       void*           pNext;
        public       VkBool32        cooperativeMatrix;
        public       VkBool32        cooperativeMatrixRobustBufferAccess;
    }


    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkPhysicalDeviceCooperativeMatrixPropertiesNV
    {
        public const VkStructureType       STYPE = VkStructureType.PHYSICAL_DEVICE_COOPERATIVE_MATRIX_PROPERTIES_NV;
        public       VkStructureType       sType;
        public       void*                 pNext;
        public       VkShaderStageFlagBits cooperativeMatrixSupportedStages;
    }




}