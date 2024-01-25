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
///     VkVideoEncodeInfoKHR - Structure specifying video encode parameters -
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkVideoEncodeInfoKHR.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkVideoEncodeInfoKHR.html</a>
/// </summary>
[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkVideoEncodeInfoKHR
{
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_VIDEO_ENCODE_INFO_KHR;

    /// <summary>sType is a VkStructureType value identifying this structure.</summary>
    public VkStructureType sType;

    /// <summary>pNext is a pointer to a structure extending this structure.</summary>
    public void* pNext;

    /// <summary>flags is reserved for future use.</summary>
    public VkVideoEncodeFlagsKHR flags;

    /// <summary>dstBuffer is the destination video bitstream buffer to write the encoded bitstream to.</summary>
    public VkBuffer dstBuffer;

    /// <summary>dstBufferOffset is the starting offset in bytes from the start of dstBuffer to write the encoded bitstream to.</summary>
    public VkDeviceSize dstBufferOffset;

    /// <summary>
    ///     dstBufferRange is the maximum bitstream size in bytes that can be written to dstBuffer, starting from
    ///     dstBufferOffset.
    /// </summary>
    public VkDeviceSize dstBufferRange;

    /// <summary>srcPictureResource is the video picture resource to use as the encode input picture.</summary>
    public VkVideoPictureResourceInfoKHR srcPictureResource;

    /// <summary>
    ///     pSetupReferenceSlot is NULL or a pointer to a VkVideoReferenceSlotInfoKHR structure specifying the
    ///     reconstructed picture information.
    /// </summary>
    public VkVideoReferenceSlotInfoKHR* pSetupReferenceSlot;

    /// <summary>referenceSlotCount is the number of elements in the pReferenceSlots array.</summary>
    public uint referenceSlotCount;

    /// <summary>
    ///     pReferenceSlots is NULL or a pointer to an array of VkVideoReferenceSlotInfoKHR structures describing the DPB
    ///     slots and corresponding reference picture resources to use in this video encode operation (the set of active
    ///     reference pictures).
    /// </summary>
    public VkVideoReferenceSlotInfoKHR* pReferenceSlots;

    /// <summary>
    ///     precedingExternallyEncodedBytes is the number of bytes externally encoded by the application to the video
    ///     bitstream and is used to update the internal state of the implementation&#8217;s rate control algorithm to account
    ///     for the bitrate budget consumed by these externally encoded bytes.
    /// </summary>
    public uint precedingExternallyEncodedBytes;
}