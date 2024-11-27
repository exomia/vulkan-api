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
///     VkVideoFormatH265QuantizationMapPropertiesKHR - Structure describing H.265 quantization map properties -
///     <a
///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkVideoFormatH265QuantizationMapPropertiesKHR.html">
///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkVideoFormatH265QuantizationMapPropertiesKHR.html
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
public unsafe struct VkVideoFormatH265QuantizationMapPropertiesKHR
{
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_VIDEO_FORMAT_H265_QUANTIZATION_MAP_PROPERTIES_KHR;

    /// <summary>sType is a VkStructureType value identifying this structure.</summary>
    public VkStructureType sType;

    /// <summary>pNext is NULL or a pointer to a structure extending this structure.</summary>
    public void* pNext;

    /// <summary>
    ///     compatibleCtbSizes is a bitmask of VkVideoEncodeH265CtbSizeFlagBitsKHR indicating the CTB sizes that
    ///     quantization maps using this video format are compatible with.NoteThe value of compatibleCtbSizes does not limit
    ///     the use of the specific quantization map format, but does limit the implementation in being able to encode pictures
    ///     with CTB sizes not included in compatibleCtbSizes but otherwise supported by the used video profile, as indicated
    ///     by VkVideoEncodeH265CapabilitiesKHR::ctbSizes. In particular, using smaller quantization map texel sizes may
    ///     prevent implementations from encoding with larger CTB sizes which may have a negative impact on the efficiency of
    ///     the encoder.
    /// </summary>
    public VkVideoEncodeH265CtbSizeFlagsKHR compatibleCtbSizes;
}