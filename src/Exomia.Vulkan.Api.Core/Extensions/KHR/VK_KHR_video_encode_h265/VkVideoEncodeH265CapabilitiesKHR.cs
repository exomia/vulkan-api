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
///     VkVideoEncodeH265CapabilitiesKHR - Structure describing H.265 encode capabilities -
///     <a
///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkVideoEncodeH265CapabilitiesKHR.html">
///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkVideoEncodeH265CapabilitiesKHR.html
///     </a>
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
public unsafe struct VkVideoEncodeH265CapabilitiesKHR
{
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_VIDEO_ENCODE_H265_CAPABILITIES_KHR;

    /// <summary>sType is a VkStructureType value identifying this structure.</summary>
    public VkStructureType sType;

    /// <summary>pNext is NULL or a pointer to a structure extending this structure.</summary>
    public void* pNext;

    /// <summary>flags is a bitmask of VkVideoEncodeH265CapabilityFlagBitsKHRindicating supported H.265 encoding capabilities.</summary>
    public VkVideoEncodeH265CapabilityFlagsKHR flags;

    /// <summary>
    ///     maxLevelIdc is a StdVideoH265LevelIdc value indicating the maximum H.265 level supported by the profile, where
    ///     enum constant STD_VIDEO_H265_LEVEL_IDC_&lt;major&gt;_&lt;minor&gt; identifies H.265 level &lt;major&gt;.&lt;minor
    ///     &gt; as defined in section A.4 of the ITU-T H.265 Specification.
    /// </summary>
    public StdVideoH265LevelIdc maxLevelIdc;

    /// <summary>
    ///     maxSliceSegmentCount indicates the maximum number of slice segments that can be encoded for a single picture.
    ///     Further restrictions may apply to the number of slice segments that can be encoded for a single picture depending
    ///     on other capabilities and codec-specific rules.
    /// </summary>
    public uint maxSliceSegmentCount;

    /// <summary>
    ///     maxTiles indicates the maximum number of H.265 tile columns and rows, as defined in sections 3.175 and 3.176
    ///     of the ITU-T H.265 Specification that can be encoded for a single picture. Further restrictions may apply to the
    ///     number of H.265 tiles that canbe encoded for a single picture depending on other capabilities and codec-specific
    ///     rules.
    /// </summary>
    public VkExtent2D maxTiles;

    /// <summary>ctbSizes is a bitmask of VkVideoEncodeH265CtbSizeFlagBitsKHRdescribing the supported CTB sizes.</summary>
    public VkVideoEncodeH265CtbSizeFlagsKHR ctbSizes;

    /// <summary>
    ///     transformBlockSizes is a bitmask of VkVideoEncodeH265TransformBlockSizeFlagBitsKHR describing the supported
    ///     transform block sizes.
    /// </summary>
    public VkVideoEncodeH265TransformBlockSizeFlagsKHR transformBlockSizes;

    /// <summary>
    ///     maxPPictureL0ReferenceCount indicates the maximum number of reference pictures the implementation supports in
    ///     the reference list L0 for P pictures.NoteAs implementations may override the reference lists,
    ///     maxPPictureL0ReferenceCount does not limit the number of elements that the application can specify in the L0
    ///     reference list for P pictures. However, if maxPPictureL0ReferenceCount is zero, then the use of P pictures is not
    ///     allowed. In case of H.265 encoding, backward-only predictive pictures can be encoded even if P pictures are not
    ///     supported, as the ITU-T H.265 Specification supports generalized P &amp; B frames (also known as low delay B
    ///     frames) whereas B frames can refer to past frames through both the L0 and L1 reference lists.
    /// </summary>
    public uint maxPPictureL0ReferenceCount;

    /// <summary>
    ///     maxBPictureL0ReferenceCount indicates the maximum number of reference pictures the implementation supports in
    ///     the reference list L0 for B pictures.
    /// </summary>
    public uint maxBPictureL0ReferenceCount;

    /// <summary>
    ///     maxL1ReferenceCount indicates the maximum number of reference pictures the implementation supports in the
    ///     reference list L1 if encoding of B pictures is supported.NoteAs implementations may override the reference lists,
    ///     maxBPictureL0ReferenceCount and maxL1ReferenceCount does not limit the number of elements that the application can
    ///     specify in the L0 and L1 reference lists for B pictures. However, if maxBPictureL0ReferenceCount and
    ///     maxL1ReferenceCountare both zero, then the use of B pictures is not allowed.
    /// </summary>
    public uint maxL1ReferenceCount;

    /// <summary>maxSubLayerCount indicates the maximum number of H.265 sub-layers supported by the implementation.</summary>
    public uint maxSubLayerCount;

    /// <summary>
    ///     expectDyadicTemporalSubLayerPattern indicates that the implementation&#8217;s rate control algorithms expect
    ///     the application to use a dyadic temporal sub-layer patternwhen encoding multiple temporal sub-layers.
    /// </summary>
    public VkBool32 expectDyadicTemporalSubLayerPattern;

    /// <summary>minQp indicates the minimum QP value supported.</summary>
    public int minQp;

    /// <summary>maxQp indicates the maximum QP value supported.</summary>
    public int maxQp;

    /// <summary>
    ///     prefersGopRemainingFrames indicates that the implementation&#8217;s rate control algorithm prefers the
    ///     application to specify the number of frames of each type remaining in the current group of pictures when beginning
    ///     a video coding scope.
    /// </summary>
    public VkBool32 prefersGopRemainingFrames;

    /// <summary>
    ///     requiresGopRemainingFrames indicates that the implementation&#8217;s rate control algorithm requires the
    ///     application to specify the number of frames of each type remaining in the current group of pictures when beginning
    ///     a video coding scope.
    /// </summary>
    public VkBool32 requiresGopRemainingFrames;

    /// <summary>
    ///     stdSyntaxFlags is a bitmask of VkVideoEncodeH265StdFlagBitsKHR indicating capabilities related to H.265 syntax
    ///     elements.
    /// </summary>
    public VkVideoEncodeH265StdFlagsKHR stdSyntaxFlags;
}