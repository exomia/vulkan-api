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
///     VkVideoEncodeAV1PictureInfoKHR - Structure specifies AV1 encode frame parameters -
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkVideoEncodeAV1PictureInfoKHR.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkVideoEncodeAV1PictureInfoKHR.html</a>
/// </summary>
/// <remarks>
///     <list type="table">
///         <item>
///             <term>structextends</term><description>VkVideoEncodeInfoKHR</description>
///         </item>
///     </list>
/// </remarks>
[VkStructExtends("VkVideoEncodeInfoKHR")]
[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkVideoEncodeAV1PictureInfoKHR
{
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_VIDEO_ENCODE_AV1_PICTURE_INFO_KHR;

    /// <summary>sType is a VkStructureType value identifying this structure.</summary>
    public VkStructureType sType;

    /// <summary>pNext is NULL or a pointer to a structure extending this structure.</summary>
    public void* pNext;

    /// <summary>predictionMode specifies the AV1 prediction mode to use for the encoded frame.</summary>
    public VkVideoEncodeAV1PredictionModeKHR predictionMode;

    /// <summary>
    ///     rateControlGroup specifies the AV1 rate control group to use for the encoded frame when the current rate
    ///     control mode is not VK_VIDEO_ENCODE_RATE_CONTROL_MODE_DISABLED_BIT_KHR. Otherwise it is ignored.
    /// </summary>
    public VkVideoEncodeAV1RateControlGroupKHR rateControlGroup;

    /// <summary>
    ///     constantQIndex is the quantizer index to use for the encoded frame if the current rate control modeconfigured
    ///     for the video session is VK_VIDEO_ENCODE_RATE_CONTROL_MODE_DISABLED_BIT_KHR.
    /// </summary>
    public uint constantQIndex;

    /// <summary>pStdPictureInfo is a pointer to a StdVideoEncodeAV1PictureInfo structure specifying AV1 picture information.</summary>
    public StdVideoEncodeAV1PictureInfo* pStdPictureInfo;

    /// <summary>
    ///     referenceNameSlotIndices is an array of seven (VK_MAX_VIDEO_AV1_REFERENCES_PER_FRAME_KHR, which is equal to
    ///     the Video Std definition STD_VIDEO_AV1_REFS_PER_FRAME) signed integer values specifying the index of the DPB slot
    ///     or a negative integer value for each AV1 reference nameused for inter coding. In particular, the DPB slot index for
    ///     the AV1 reference name frameis specified in referenceNameSlotIndices[frame -
    ///     STD_VIDEO_AV1_REFERENCE_NAME_LAST_FRAME].
    /// </summary>
    public fixed int referenceNameSlotIndices[(int)VK_MAX_VIDEO_AV1_REFERENCES_PER_FRAME_KHR];

    /// <summary>
    ///     primaryReferenceCdfOnly controls whether the primary reference frame indicated by the value of
    ///     pStdPictureInfo-&gt;primary_ref_frameis used only for CDF data reference, as defined in sections 6.8.2 of the AV1
    ///     Specification. If set to VK_TRUE, then the primary reference frame&#8217;s picture data will not be used for sample
    ///     prediction.
    /// </summary>
    public VkBool32 primaryReferenceCdfOnly;

    /// <summary>
    ///     generateObuExtensionHeader controls whether OBU extension headers are generated into the target bitstream, as
    ///     defined in sections 5.3.1, 5.3.2, and 5.3.3 of the AV1 Specification.
    /// </summary>
    public VkBool32 generateObuExtensionHeader;
}