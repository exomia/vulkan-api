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
///     VkOutOfBandQueueTypeInfoNV - Structure used to describe the queue that is being marked as Out of Band -
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkOutOfBandQueueTypeInfoNV.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkOutOfBandQueueTypeInfoNV.html</a>
/// </summary>
[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkOutOfBandQueueTypeInfoNV
{
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_OUT_OF_BAND_QUEUE_TYPE_INFO_NV;

    /// <summary>sType is a VkStructureType value identifying this structure.</summary>
    public VkStructureType sType;

    /// <summary>pNext is NULL or a pointer to a structure extending this structure.</summary>
    public void* pNext;

    /// <summary>queueType describes the usage of the queue to be marked as out of band.</summary>
    public VkOutOfBandQueueTypeNV queueType;
}