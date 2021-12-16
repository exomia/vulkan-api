#region License

// Copyright (c) 2018-2021, exomia
// All rights reserved.
// 
// This source code is licensed under the BSD-style license found in the
// LICENSE file in the root directory of this source tree.

#endregion

#pragma warning disable CA2211 // Non-constant fields should not be visible
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

// ReSharper disable UnusedMember.Global
// ReSharper disable InconsistentNaming
namespace Exomia.Vulkan.Api.Core.Extensions;

[VkExtGenerator]
public static partial class VkExtFragmentDensityMap2
{
    public const int    VK_EXT_FRAGMENT_DENSITY_MAP2                 = 1;
    public const int    VK_EXT_FRAGMENT_DENSITY_MAP_2_SPEC_VERSION   = 1;
    public const string VK_EXT_FRAGMENT_DENSITY_MAP_2_EXTENSION_NAME = "VK_EXT_fragment_density_map2";
}

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPhysicalDeviceFragmentDensityMap2FeaturesEXT
{
    public const VkStructureType STYPE = VkStructureType.PHYSICAL_DEVICE_FRAGMENT_DENSITY_MAP_2_FEATURES_EXT;
    public       VkStructureType sType;
    public       void*           pNext;
    public       VkBool32        fragmentDensityMapDeferred;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPhysicalDeviceFragmentDensityMap2PropertiesEXT
{
    public const VkStructureType STYPE = VkStructureType.PHYSICAL_DEVICE_FRAGMENT_DENSITY_MAP_2_PROPERTIES_EXT;
    public       VkStructureType sType;
    public       void*           pNext;
    public       VkBool32        subsampledLoads;
    public       VkBool32        subsampledCoarseReconstructionEarlyAccess;
    public       uint            maxSubsampledArrayLayers;
    public       uint            maxDescriptorSetSubsampledSamplers;
}