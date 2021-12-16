#region License

// Copyright (c) 2018-2021, exomia
// All rights reserved.
// 
// This source code is licensed under the BSD-style license found in the
// LICENSE file in the root directory of this source tree.

#endregion

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

// ReSharper disable UnusedMember.Global
// ReSharper disable once CheckNamespace
namespace Exomia.Vulkan.Api.Core;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPhysicalDeviceFloatControlsProperties
{
    public const VkStructureType                   STYPE = VkStructureType.PHYSICAL_DEVICE_FLOAT_CONTROLS_PROPERTIES;
    public       VkStructureType                   sType;
    public       void*                             pNext;
    public       VkShaderFloatControlsIndependence denormBehaviorIndependence;
    public       VkShaderFloatControlsIndependence roundingModeIndependence;
    public       VkBool32                          shaderSignedZeroInfNanPreserveFloat16;
    public       VkBool32                          shaderSignedZeroInfNanPreserveFloat32;
    public       VkBool32                          shaderSignedZeroInfNanPreserveFloat64;
    public       VkBool32                          shaderDenormPreserveFloat16;
    public       VkBool32                          shaderDenormPreserveFloat32;
    public       VkBool32                          shaderDenormPreserveFloat64;
    public       VkBool32                          shaderDenormFlushToZeroFloat16;
    public       VkBool32                          shaderDenormFlushToZeroFloat32;
    public       VkBool32                          shaderDenormFlushToZeroFloat64;
    public       VkBool32                          shaderRoundingModeRTEFloat16;
    public       VkBool32                          shaderRoundingModeRTEFloat32;
    public       VkBool32                          shaderRoundingModeRTEFloat64;
    public       VkBool32                          shaderRoundingModeRTZFloat16;
    public       VkBool32                          shaderRoundingModeRTZFloat32;
    public       VkBool32                          shaderRoundingModeRTZFloat64;
}