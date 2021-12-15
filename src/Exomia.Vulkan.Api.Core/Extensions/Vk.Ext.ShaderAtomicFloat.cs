﻿#region License

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
namespace Exomia.Vulkan.Api.Core.Extensions
{
    [VkExtGenerator]
    public static partial class VkExtShaderAtomicFloat
    {
        public const int    VK_EXT_SHADER_ATOMIC_FLOAT                = 1;
        public const int    VK_EXT_SHADER_ATOMIC_FLOAT_SPEC_VERSION   = 1;
        public const string VK_EXT_SHADER_ATOMIC_FLOAT_EXTENSION_NAME = "VK_EXT_shader_atomic_float";
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkPhysicalDeviceShaderAtomicFloatFeaturesEXT
    {
        public const VkStructureType STYPE = VkStructureType.PHYSICAL_DEVICE_SHADER_ATOMIC_FLOAT_FEATURES_EXT;
        public       VkStructureType sType;
        public       void*           pNext;
        public       VkBool32        shaderBufferFloat32Atomics;
        public       VkBool32        shaderBufferFloat32AtomicAdd;
        public       VkBool32        shaderBufferFloat64Atomics;
        public       VkBool32        shaderBufferFloat64AtomicAdd;
        public       VkBool32        shaderSharedFloat32Atomics;
        public       VkBool32        shaderSharedFloat32AtomicAdd;
        public       VkBool32        shaderSharedFloat64Atomics;
        public       VkBool32        shaderSharedFloat64AtomicAdd;
        public       VkBool32        shaderImageFloat32Atomics;
        public       VkBool32        shaderImageFloat32AtomicAdd;
        public       VkBool32        sparseImageFloat32Atomics;
        public       VkBool32        sparseImageFloat32AtomicAdd;
    }
}