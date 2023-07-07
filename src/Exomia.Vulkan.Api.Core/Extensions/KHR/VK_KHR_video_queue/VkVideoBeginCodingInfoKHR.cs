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
///     VkVideoBeginCodingInfoKHR - Structure specifying video coding scope begin information -
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkVideoBeginCodingInfoKHR.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkVideoBeginCodingInfoKHR.html</a>
/// </summary>
[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkVideoBeginCodingInfoKHR
{
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_VIDEO_BEGIN_CODING_INFO_KHR;

    /// <summary>sType is a VkStructureType value identifying this structure.</summary>
    public VkStructureType sType;

    /// <summary>pNext is NULL or a pointer to a structure extending this structure.</summary>
    public void* pNext;

    /// <summary>flags is reserved for future use.</summary>
    public VkVideoBeginCodingFlagsKHR flags;

    /// <summary>videoSession is the video session object to be bound for the processing of the video commands.</summary>
    public VkVideoSessionKHR videoSession;

    /// <summary>
    ///     videoSessionParameters is VK_NULL_HANDLE or a handle of a VkVideoSessionParametersKHR object to be used for
    ///     the processing of the video commands. If VK_NULL_HANDLE, then no video session parameters object is bound for the
    ///     duration of the video coding scope.
    /// </summary>
    public VkVideoSessionParametersKHR videoSessionParameters;

    /// <summary>referenceSlotCount is the number of elements in the pReferenceSlots array.</summary>
    public uint referenceSlotCount;

    /// <summary>
    ///     pReferenceSlots is a pointer to an array of VkVideoReferenceSlotInfoKHR structures specifying the information
    ///     used to determine the set of bound reference picture resources for the video coding scope and their initial
    ///     association with DPB slot indices.
    /// </summary>
    public VkVideoReferenceSlotInfoKHR* pReferenceSlots;
}