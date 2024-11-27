#region License

// Copyright (c) 2018-2024, exomia
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
///     VkVideoFormatAV1QuantizationMapPropertiesKHR - Structure describing AV1 quantization map properties -
///     <a
///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkVideoFormatAV1QuantizationMapPropertiesKHR.html">
///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkVideoFormatAV1QuantizationMapPropertiesKHR.html
///     </a>
/// </summary>
/// <remarks>
///     <list type="table">
///         <item>
///             <term>structextends</term><description>VkVideoFormatPropertiesKHR</description>
///         </item>
///         <item>
///             <term>returnedonly</term><description>true</description>
///         </item>
///     </list>
/// </remarks>
[VkStructExtends("VkVideoFormatPropertiesKHR")]
[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkVideoFormatAV1QuantizationMapPropertiesKHR
{
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_VIDEO_FORMAT_AV1_QUANTIZATION_MAP_PROPERTIES_KHR;

    /// <summary>sType is a VkStructureType value identifying this structure.</summary>
    public VkStructureType sType;

    /// <summary>pNext is NULL or a pointer to a structure extending this structure.</summary>
    public void* pNext;

    /// <summary>
    ///     compatibleSuperblockSizes is a bitmask of VkVideoEncodeAV1SuperblockSizeFlagBitsKHR indicating the AV1
    ///     superblock sizes that quantization maps using this video format are compatible with.NoteThe value of
    ///     compatibleSuperblockSizes does not limit the use of the specific quantization map format, but does limit the
    ///     implementation in being able to encode pictures with superblock sizes not included in compatibleSuperblockSizes but
    ///     otherwise supported by the used video profile, as indicated by VkVideoEncodeAV1CapabilitiesKHR::superblockSizes. In
    ///     particular, using smaller quantization map texel sizes may prevent implementations from encoding with larger
    ///     superblock sizes which may have a negative impact on the efficiency of the encoder.
    /// </summary>
    public VkVideoEncodeAV1SuperblockSizeFlagsKHR compatibleSuperblockSizes;
}