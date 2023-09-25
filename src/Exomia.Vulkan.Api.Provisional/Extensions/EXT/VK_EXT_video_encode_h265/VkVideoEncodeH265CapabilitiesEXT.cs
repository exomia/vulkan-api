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
///     VkVideoEncodeH265CapabilitiesEXT - Structure specifying H.265 encode capabilities -
///     <a
///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkVideoEncodeH265CapabilitiesEXT.html">
///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkVideoEncodeH265CapabilitiesEXT.html
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
public unsafe struct VkVideoEncodeH265CapabilitiesEXT
{
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_VIDEO_ENCODE_H265_CAPABILITIES_EXT;

    /// <summary>sType is a VkStructureType value identifying this structure.</summary>
    public VkStructureType sType;

    /// <summary>pNext is NULL or a pointer to a structure extending this structure.</summary>
    public void* pNext;

    /// <summary>flags is a bitmask of VkVideoEncodeH265CapabilityFlagBitsEXTindicating supported H.265 encoding capabilities.</summary>
    public VkVideoEncodeH265CapabilityFlagsEXT flags;

    /// <summary>maxLevelIdc is a StdVideoH265LevelIdc value indicating the maximum H.265 level supported.</summary>
    public StdVideoH265LevelIdc maxLevelIdc;

    /// <summary>
    ///     maxSliceSegmentCount indicates the maximum number of slice segments that can be encoded for a single picture.
    ///     Further restrictions may apply to the number of slice segments that can be encoded for a single picture depending
    ///     on other capabilities and codec-specific rules.
    /// </summary>
    public uint maxSliceSegmentCount;

    /// <summary>
    ///     maxTiles indicates the maximum number of H.265 tile columns and rows that can be encoded for a single picture.
    ///     Further restrictions may apply to the number of H.265 tiles that canbe encoded for a single picture depending on
    ///     other capabilities and codec-specific rules.
    /// </summary>
    public VkExtent2D maxTiles;

    /// <summary>ctbSizes is a bitmask of VkVideoEncodeH265CtbSizeFlagBitsEXTdescribing the supported CTB sizes.</summary>
    public VkVideoEncodeH265CtbSizeFlagsEXT ctbSizes;

    /// <summary>
    ///     transformBlockSizes is a bitmask of VkVideoEncodeH265TransformBlockSizeFlagBitsEXT describing the supported
    ///     transform block sizes.
    /// </summary>
    public VkVideoEncodeH265TransformBlockSizeFlagsEXT transformBlockSizes;

    /// <summary>
    ///     maxPPictureL0ReferenceCount indicates the maximum number of reference pictures the implementation supports in
    ///     the reference list L0 for P pictures.
    /// </summary>
    public uint maxPPictureL0ReferenceCount;

    /// <summary>
    ///     maxBPictureL0ReferenceCount indicates the maximum number of reference pictures the implementation supports in
    ///     the reference list L0 for B pictures. The reported value is 0 if encoding of B pictures is not supported.
    /// </summary>
    public uint maxBPictureL0ReferenceCount;

    /// <summary>
    ///     maxL1ReferenceCount indicates the maximum number of reference pictures the implementation supports in the
    ///     reference list L1 if encoding of B pictures is supported. The reported value is 0 if encoding of B pictures is not
    ///     supported.
    /// </summary>
    public uint maxL1ReferenceCount;

    /// <summary>maxSubLayerCount indicates the maximum number of H.265 sub-layers supported by the implementation.</summary>
    public uint maxSubLayerCount;

    /// <summary>
    ///     expectDyadicTemporalSubLayerPattern indicates that the implementation&#8217;s rate control algorithms expect
    ///     the application to use a dyadic temporal sub-layer pattern when encoding multiple temporal sub-layers.
    /// </summary>
    public VkBool32 expectDyadicTemporalSubLayerPattern;

    /// <summary>minQp indicates the minimum QP value supported.</summary>
    public int minQp;

    /// <summary>maxQp indicates the maximum QP value supported.</summary>
    public int maxQp;

    /// <summary>
    ///     prefersGopRemainingFrames indicates that the implementation&#8217;s rate control algorithm prefers the
    ///     application to specify the number of frames of each type remaining in the current group of pictures.
    /// </summary>
    public VkBool32 prefersGopRemainingFrames;

    /// <summary>
    ///     requiresGopRemainingFrames indicates that the implementation&#8217;s rate control algorithm requires the
    ///     application to specify the number of frames of each type remaining in the current group of pictures.
    /// </summary>
    public VkBool32 requiresGopRemainingFrames;

    /// <summary>
    ///     stdSyntaxFlags is a bitmask of VkVideoEncodeH265StdFlagBitsEXT indicating capabilities related to H.265 syntax
    ///     elements.
    /// </summary>
    public VkVideoEncodeH265StdFlagsEXT stdSyntaxFlags;
}