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
namespace Exomia.Vulkan.Api.Provisional;

/// <summary>
///     VkVideoEncodeRateControlInfoKHR - Structure to set encode stream rate control parameters -
///     <a
///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkVideoEncodeRateControlInfoKHR.html">
///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkVideoEncodeRateControlInfoKHR.html
///     </a>
/// </summary>
/// <remarks>
///     <list type="table">
///         <item>
///             <term>structextends</term><description>VkVideoCodingControlInfoKHR,VkVideoBeginCodingInfoKHR</description>
///         </item>
///     </list>
/// </remarks>
[VkStructExtends("VkVideoCodingControlInfoKHR,VkVideoBeginCodingInfoKHR")]
[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkVideoEncodeRateControlInfoKHR
{
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_VIDEO_ENCODE_RATE_CONTROL_INFO_KHR;

    /// <summary>sType is a VkStructureType value identifying this structure.</summary>
    public VkStructureType sType;

    /// <summary>pNext is NULL or a pointer to a structure extending this structure.</summary>
    public void* pNext;

    /// <summary>flags is reserved for future use.</summary>
    public VkVideoEncodeRateControlFlagsKHR flags;

    /// <summary>
    ///     rateControlMode is a VkVideoEncodeRateControlModeFlagBitsKHRvalue specifying the encode stream rate control
    ///     mode.
    /// </summary>
    public VkVideoEncodeRateControlModeFlagBitsKHR rateControlMode;

    /// <summary>layerCount specifies the number of rate control layers in the video encode stream.</summary>
    public uint layerCount;

    /// <summary>
    ///     pLayers is a pointer to an array of VkVideoEncodeRateControlLayerInfoKHR structures specifying the rate
    ///     control configurations of layerCount rate control layers.
    /// </summary>
    public VkVideoEncodeRateControlLayerInfoKHR* pLayers;

    /// <summary>
    ///     virtualBufferSizeInMs is the leaky bucket model virtual buffer size in milliseconds, with respect to peak
    ///     bitrate. Valid when rate control mode is VK_VIDEO_ENCODE_RATE_CONTROL_MODE_CBR_BIT_KHR or
    ///     VK_VIDEO_ENCODE_RATE_CONTROL_MODE_VBR_BIT_KHR. For example, virtual buffer size is (virtualBufferSizeInMs ×
    ///     maxBitrate / 1000).
    /// </summary>
    public uint virtualBufferSizeInMs;

    /// <summary>
    ///     initialVirtualBufferSizeInMs is the initial occupancy in milliseconds of the virtual buffer in the leaky
    ///     bucket model. Valid when rate control mode is VK_VIDEO_ENCODE_RATE_CONTROL_MODE_CBR_BIT_KHR or
    ///     VK_VIDEO_ENCODE_RATE_CONTROL_MODE_VBR_BIT_KHR.
    /// </summary>
    public uint initialVirtualBufferSizeInMs;
}