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
///     VkVideoEncodeH264CapabilitiesEXT - Structure specifying H.264 encode capabilities -
///     <a
///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkVideoEncodeH264CapabilitiesEXT.html">
///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkVideoEncodeH264CapabilitiesEXT.html
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
public unsafe struct VkVideoEncodeH264CapabilitiesEXT
{
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_VIDEO_ENCODE_H264_CAPABILITIES_EXT;

    /// <summary>sType is a VkStructureType value identifying this structure.</summary>
    public VkStructureType sType;

    /// <summary>pNext is NULL or a pointer to a structure extending this structure.</summary>
    public void* pNext;

    /// <summary>flags is a bitmask of VkVideoEncodeH264CapabilityFlagBitsEXTindicating supported H.264 encoding capabilities.</summary>
    public VkVideoEncodeH264CapabilityFlagsEXT flags;

    /// <summary>maxLevelIdc is a StdVideoH264LevelIdc value indicating the maximum H.264 level supported.</summary>
    public StdVideoH264LevelIdc maxLevelIdc;

    /// <summary>
    ///     maxSliceCount indicates the maximum number of slices that can be encoded for a single picture. Further
    ///     restrictions may apply to the number of slices that can be encoded for a single picture depending on other
    ///     capabilities and codec-specific rules.
    /// </summary>
    public uint maxSliceCount;

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
    ///     maxL1ReferenceCount reports the maximum number of reference pictures the implementation supports in the
    ///     reference list L1 if encoding of B pictures is supported. The reported value is 0 if encoding of B pictures is not
    ///     supported.
    /// </summary>
    public uint maxL1ReferenceCount;

    /// <summary>maxTemporalLayerCount indicates the maximum number of H.264 temporal layers supported by the implementation.</summary>
    public uint maxTemporalLayerCount;

    /// <summary>
    ///     expectDyadicTemporalLayerPattern indicates that the implementation&#8217;s rate control algorithms expect the
    ///     application to use a dyadic temporal layer pattern when encoding multiple temporal layers.
    /// </summary>
    public VkBool32 expectDyadicTemporalLayerPattern;

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
    ///     stdSyntaxFlags is a bitmask of VkVideoEncodeH264StdFlagBitsEXT indicating capabilities related to H.264 syntax
    ///     elements.
    /// </summary>
    public VkVideoEncodeH264StdFlagsEXT stdSyntaxFlags;
}