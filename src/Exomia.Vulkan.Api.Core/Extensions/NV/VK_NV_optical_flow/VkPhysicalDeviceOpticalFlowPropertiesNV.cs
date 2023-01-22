#region License

// Copyright (c) 2018-2023, exomia
// All rights reserved.
// 
// This source code is licensed under the BSD-style license found in the
// LICENSE file in the root directory of this source tree.

#endregion

// ReSharper disable UnusedMember.Global
// ReSharper disable InconsistentNaming
// ReSharper disable once CheckNamespace
namespace Exomia.Vulkan.Api.Core;

/// <summary>
///     VkPhysicalDeviceOpticalFlowPropertiesNV - Structure describing properties supported by VK_NV_optical_flow -
///     <a
///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkPhysicalDeviceOpticalFlowPropertiesNV.html">
///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkPhysicalDeviceOpticalFlowPropertiesNV.html
///     </a>
/// </summary>
/// <remarks>
///     <list type="table">
///         <item>
///             <term>structextends</term><description>VkPhysicalDeviceProperties2</description>
///         </item>
///         <item>
///             <term>returnedonly</term><description>true</description>
///         </item>
///     </list>
/// </remarks>
[VkStructExtends("VkPhysicalDeviceProperties2")]
[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPhysicalDeviceOpticalFlowPropertiesNV
{
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_OPTICAL_FLOW_PROPERTIES_NV;

    /// <summary>sType is the type of this structure.</summary>
    public VkStructureType sType;

    /// <summary>pNext is NULL or a pointer to a structure extending this structure.</summary>
    public void* pNext;

    /// <summary>
    ///     supportedOutputGridSizes are the supported VkOpticalFlowGridSizeFlagsNV which can be specified in
    ///     VkOpticalFlowSessionCreateInfoNV::outputGridSize.
    /// </summary>
    public VkOpticalFlowGridSizeFlagsNV supportedOutputGridSizes;

    /// <summary>
    ///     supportedHintGridSizes are the supported VkOpticalFlowGridSizeFlagsNV which can be specified in
    ///     VkOpticalFlowSessionCreateInfoNV::hintGridSize.
    /// </summary>
    public VkOpticalFlowGridSizeFlagsNV supportedHintGridSizes;

    /// <summary>
    ///     hintSupported is a boolean describing whether using hint flow vector map is supported in an optical flow
    ///     session.
    /// </summary>
    public VkBool32 hintSupported;

    /// <summary> costSupported is a boolean describing whether cost map generation is supported in an optical flow session.</summary>
    public VkBool32 costSupported;

    /// <summary>
    ///     bidirectionalFlowSupportedis a boolean describing whether bi-directional flow generation is supported in an
    ///     optical flow session.
    /// </summary>
    public VkBool32 bidirectionalFlowSupported;

    /// <summary>
    ///     globalFlowSupported is a boolean describing whether global flow vector map generation is supported in an
    ///     optical flow session.
    /// </summary>
    public VkBool32 globalFlowSupported;

    /// <summary> minWidth is the minimum width in pixels for images used in an optical flow session.</summary>
    public uint minWidth;

    /// <summary> minHeight is the minimum height in pixels for images used in an optical flow session.</summary>
    public uint minHeight;

    /// <summary> maxWidth is the maximum width in pixels for images used in an optical flow session.</summary>
    public uint maxWidth;

    /// <summary> maxHeight is the maximum height in pixels for images used in an optical flow session.</summary>
    public uint maxHeight;

    /// <summary>
    ///     maxNumRegionsOfInterest is the maximum number of regions of interest which can be used in an optical flow
    ///     session. If this maxNumRegionsOfInterest is 0, regions of interest are not supported in an optical flow session.
    /// </summary>
    public uint maxNumRegionsOfInterest;
}