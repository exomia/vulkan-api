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
///     VkVideoEncodeCapabilitiesKHR - Structure describing general video encode capabilities for a video profile -
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkVideoEncodeCapabilitiesKHR.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkVideoEncodeCapabilitiesKHR.html</a>
/// </summary>
/// <remarks>
///     <list type="table">
///         <item>
///             <term>structextends</term><description>VkVideoCapabilitiesKHR</description>
///         </item>
///         <item>
///             <term>returnedonly</term><description>true</description>
///         </item>
///     </list>
/// </remarks>
[VkStructExtends("VkVideoCapabilitiesKHR")]
[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkVideoEncodeCapabilitiesKHR
{
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_VIDEO_ENCODE_CAPABILITIES_KHR;

    /// <summary>sType is a VkStructureType value identifying this structure.</summary>
    public VkStructureType sType;

    /// <summary>pNext is NULL or a pointer to a structure extending this structure.</summary>
    public void* pNext;

    /// <summary>flags is a bitmask of VkVideoEncodeCapabilityFlagBitsKHRdescribing supported encoding features.</summary>
    public VkVideoEncodeCapabilityFlagsKHR flags;

    /// <summary>
    ///     rateControlModes is a bitmask of VkVideoEncodeRateControlModeFlagBitsKHR indicating supported rate control
    ///     modes.
    /// </summary>
    public VkVideoEncodeRateControlModeFlagsKHR rateControlModes;

    /// <summary>maxRateControlLayers indicates the maximum number of rate control layers supported.</summary>
    public uint maxRateControlLayers;

    /// <summary>maxBitrate indicates the maximum supported bitrate.</summary>
    public ulong maxBitrate;

    /// <summary>
    ///     maxQualityLevels indicates the number of discrete video encode quality levels supported. Implementations must
    ///     support at least one quality level.
    /// </summary>
    public uint maxQualityLevels;

    /// <summary>
    ///     encodeInputPictureGranularity indicates the granularity at which encode input picture data is encoded and
    ///     mayindicate a texel granularity up to the size of the largest supported codec-specific coding block. This
    ///     capability does not impose any valid usage constraints on the application, however, depending on the contents of
    ///     the encode input picture, it may have effects on the encoded bitstream, as described in more detail below.
    /// </summary>
    public VkExtent2D encodeInputPictureGranularity;

    /// <summary>
    ///     supportedEncodeFeedbackFlags is a bitmask of VkVideoEncodeFeedbackFlagBitsKHR values specifying the supported
    ///     flags for video encode feedback queries.
    /// </summary>
    public VkVideoEncodeFeedbackFlagsKHR supportedEncodeFeedbackFlags;
}