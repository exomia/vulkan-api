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
///     VkVideoCapabilitiesKHR - Structure describing general video capabilities for a video profile -
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkVideoCapabilitiesKHR.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkVideoCapabilitiesKHR.html</a>
/// </summary>
/// <remarks>
///     <list type="table">
///         <item>
///             <term>returnedonly</term><description>true</description>
///         </item>
///     </list>
/// </remarks>
[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkVideoCapabilitiesKHR
{
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_VIDEO_CAPABILITIES_KHR;

    /// <summary>sType is a VkStructureType value identifying this structure.</summary>
    public VkStructureType sType;

    /// <summary>pNext is NULL or a pointer to a structure extending this structure.</summary>
    public void* pNext;

    /// <summary>flags is a bitmask of VkVideoCapabilityFlagBitsKHRspecifying capability flags.</summary>
    public VkVideoCapabilityFlagsKHR flags;

    /// <summary>minBitstreamBufferOffsetAlignment is the minimum alignment for bitstream buffer offsets.</summary>
    public VkDeviceSize minBitstreamBufferOffsetAlignment;

    /// <summary>minBitstreamBufferSizeAlignment is the minimum alignment for bitstream buffer range sizes.</summary>
    public VkDeviceSize minBitstreamBufferSizeAlignment;

    /// <summary>pictureAccessGranularity is the granularity at which image access to video picture resources happen.</summary>
    public VkExtent2D pictureAccessGranularity;

    /// <summary>minCodedExtent is the minimum width and height of the coded frames.</summary>
    public VkExtent2D minCodedExtent;

    /// <summary>maxCodedExtent is the maximum width and height of the coded frames.</summary>
    public VkExtent2D maxCodedExtent;

    /// <summary>maxDpbSlots is the maximum number of DPB slotssupported by a single video session.</summary>
    public uint maxDpbSlots;

    /// <summary>
    ///     maxActiveReferencePictures is the maximum number of active reference pictures a single video coding operation
    ///     can use.
    /// </summary>
    public uint maxActiveReferencePictures;

    /// <summary>
    ///     stdHeaderVersion is a VkExtensionProperties structure reporting the Video Std header name and version
    ///     supported for the video profile.
    /// </summary>
    public VkExtensionProperties stdHeaderVersion;
}