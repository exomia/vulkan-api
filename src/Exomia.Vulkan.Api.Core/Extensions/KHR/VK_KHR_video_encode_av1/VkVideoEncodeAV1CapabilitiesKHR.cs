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
///     VkVideoEncodeAV1CapabilitiesKHR - Structure describing AV1 encode capabilities -
///     <a
///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkVideoEncodeAV1CapabilitiesKHR.html">
///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkVideoEncodeAV1CapabilitiesKHR.html
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
public unsafe struct VkVideoEncodeAV1CapabilitiesKHR
{
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_VIDEO_ENCODE_AV1_CAPABILITIES_KHR;

    /// <summary>sType is a VkStructureType value identifying this structure.</summary>
    public VkStructureType sType;

    /// <summary>pNext is NULL or a pointer to a structure extending this structure.</summary>
    public void* pNext;

    /// <summary>flags is a bitmask of VkVideoEncodeAV1CapabilityFlagBitsKHRindicating supported AV1 encoding capabilities.</summary>
    public VkVideoEncodeAV1CapabilityFlagsKHR flags;

    /// <summary>
    ///     maxLevel is a StdVideoAV1Level value indicating the maximum AV1 level supported by the profile, as defined in
    ///     section A.3 of the AV1 Specification.
    /// </summary>
    public StdVideoAV1Level maxLevel;

    /// <summary>
    ///     codedPictureAlignment indicates the alignment at which the implementation will code pictures. This capability
    ///     does not impose any valid usage constraints on the application. However, depending on the codedExtent of the encode
    ///     input picture resource, this capability may result in a change of the resolution of the encoded picture, as
    ///     described in more detail below.
    /// </summary>
    public VkExtent2D codedPictureAlignment;

    /// <summary>maxTiles indicates the maximum number of AV1 tile columns and rows the implementation supports.</summary>
    public VkExtent2D maxTiles;

    /// <summary>minTileSize indicates the minimum extent of individual AV1 tiles the implementation supports.</summary>
    public VkExtent2D minTileSize;

    /// <summary>maxTileSize indicates the maximum extent of individual AV1 tiles the implementation supports.</summary>
    public VkExtent2D maxTileSize;

    /// <summary>
    ///     superblockSizes is a bitmask of VkVideoEncodeAV1SuperblockSizeFlagBitsKHR values indicating the supported AV1
    ///     superblock sizes.
    /// </summary>
    public VkVideoEncodeAV1SuperblockSizeFlagsKHR superblockSizes;

    /// <summary>
    ///     maxSingleReferenceCount indicates the maximum number of reference pictures the implementation supports when
    ///     using single reference prediction mode.
    /// </summary>
    public uint maxSingleReferenceCount;

    /// <summary>
    ///     singleReferenceNameMask is a bitmask of supported AV1 reference names when using single reference prediction
    ///     mode.
    /// </summary>
    public uint singleReferenceNameMask;

    /// <summary>
    ///     maxUnidirectionalCompoundReferenceCount indicates the maximum number of reference pictures the implementation
    ///     supports when using unidirectional compound prediction mode.
    /// </summary>
    public uint maxUnidirectionalCompoundReferenceCount;

    /// <summary>
    ///     maxUnidirectionalCompoundGroup1ReferenceCount indicates the maximum number of reference pictures the
    ///     implementation supports when using unidirectional compound prediction mode from reference frame group 1, as defined
    ///     in section 6.10.24 of the AV1 Specification.
    /// </summary>
    public uint maxUnidirectionalCompoundGroup1ReferenceCount;

    /// <summary>
    ///     unidirectionalCompoundReferenceNameMask is a bitmask of supported AV1 reference names when using
    ///     unidirectional compound prediction mode.
    /// </summary>
    public uint unidirectionalCompoundReferenceNameMask;

    /// <summary>
    ///     maxBidirectionalCompoundReferenceCount indicates the maximum number of reference pictures the implementation
    ///     supports when using bidirectional compound prediction mode.
    /// </summary>
    public uint maxBidirectionalCompoundReferenceCount;

    /// <summary>
    ///     maxBidirectionalCompoundGroup1ReferenceCount indicates the maximum number of reference pictures the
    ///     implementation supports when using bidirectional compound prediction modefrom reference frame group 1, as defined
    ///     in section 6.10.24 of the AV1 Specification.
    /// </summary>
    public uint maxBidirectionalCompoundGroup1ReferenceCount;

    /// <summary>
    ///     maxBidirectionalCompoundGroup2ReferenceCount indicates the maximum number of reference pictures the
    ///     implementation supports when using bidirectional compound prediction modefrom reference frame group 2, as defined
    ///     in section 6.10.24 of the AV1 Specification.
    /// </summary>
    public uint maxBidirectionalCompoundGroup2ReferenceCount;

    /// <summary>
    ///     bidirectionalCompoundReferenceNameMask is a bitmask of supported AV1 reference names when using bidirectional
    ///     compound prediction mode.
    /// </summary>
    public uint bidirectionalCompoundReferenceNameMask;

    /// <summary>maxTemporalLayerCount indicates the maximum number of AV1 temporal layers supported by the implementation.</summary>
    public uint maxTemporalLayerCount;

    /// <summary>maxSpatialLayerCount indicates the maximum number of AV1 spatial layers supported by the implementation.</summary>
    public uint maxSpatialLayerCount;

    /// <summary>maxOperatingPoints indicates the maximum number of AV1 operating points supported by the implementation.</summary>
    public uint maxOperatingPoints;

    /// <summary>minQIndex indicates the minimum quantizer index value supported.</summary>
    public uint minQIndex;

    /// <summary>maxQIndex indicates the maximum quantizer index value supported.</summary>
    public uint maxQIndex;

    /// <summary>
    ///     prefersGopRemainingFrames indicates that the implementation&#8217;s rate control algorithm prefers the
    ///     application to specify the number of frames in each AV1 rate control groupremaining in the current group of
    ///     pictures when beginning a video coding scope.
    /// </summary>
    public VkBool32 prefersGopRemainingFrames;

    /// <summary>
    ///     requiresGopRemainingFrames indicates that the implementation&#8217;s rate control algorithm requires the
    ///     application to specify the number of frames in each AV1 rate control groupremaining in the current group of
    ///     pictures when beginning a video coding scope.
    /// </summary>
    public VkBool32 requiresGopRemainingFrames;

    /// <summary>
    ///     stdSyntaxFlags is a bitmask of VkVideoEncodeAV1StdFlagBitsKHR indicating capabilities related to AV1 syntax
    ///     elements.
    /// </summary>
    public VkVideoEncodeAV1StdFlagsKHR stdSyntaxFlags;
}