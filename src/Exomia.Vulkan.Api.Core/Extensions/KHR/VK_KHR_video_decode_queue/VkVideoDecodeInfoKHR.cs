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
namespace Exomia.Vulkan.Api.Core;

/// <summary>
///     VkVideoDecodeInfoKHR - Structure specifying video decode parameters -
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkVideoDecodeInfoKHR.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkVideoDecodeInfoKHR.html</a>
/// </summary>
[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkVideoDecodeInfoKHR
{
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_VIDEO_DECODE_INFO_KHR;

    /// <summary>sType is a VkStructureType value identifying this structure.</summary>
    public VkStructureType sType;

    /// <summary>pNext is NULL or a pointer to a structure extending this structure.</summary>
    public void* pNext;

    /// <summary>flags is reserved for future use.</summary>
    public VkVideoDecodeFlagsKHR flags;

    /// <summary>srcBuffer is the source video bitstream buffer to read the encoded bitstream from.</summary>
    public VkBuffer srcBuffer;

    /// <summary>
    ///     srcBufferOffset is the starting offset in bytes from the start of srcBuffer to read the encoded bitstream
    ///     from.
    /// </summary>
    public VkDeviceSize srcBufferOffset;

    /// <summary>
    ///     srcBufferRange is the size in bytes of the encoded bitstream to decode from srcBuffer, starting from
    ///     srcBufferOffset.
    /// </summary>
    public VkDeviceSize srcBufferRange;

    /// <summary>dstPictureResource is the video picture resource to use as the decode output picture.</summary>
    public VkVideoPictureResourceInfoKHR dstPictureResource;

    /// <summary>
    ///     pSetupReferenceSlot is NULL or a pointer to a VkVideoReferenceSlotInfoKHR structure specifying the
    ///     reconstructed picture information.
    /// </summary>
    public VkVideoReferenceSlotInfoKHR* pSetupReferenceSlot;

    /// <summary>referenceSlotCount is the number of elements in the pReferenceSlots array.</summary>
    public uint referenceSlotCount;

    /// <summary>
    ///     pReferenceSlots is NULL or a pointer to an array of VkVideoReferenceSlotInfoKHR structures describing the DPB
    ///     slots and corresponding reference picture resources to use in this video decode operation (the set of active
    ///     reference pictures).
    /// </summary>
    public VkVideoReferenceSlotInfoKHR* pReferenceSlots;
}