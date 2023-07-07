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
///     VkVideoSessionCreateInfoKHR - Structure specifying parameters of a newly created video session -
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkVideoSessionCreateInfoKHR.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkVideoSessionCreateInfoKHR.html</a>
/// </summary>
[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkVideoSessionCreateInfoKHR
{
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_VIDEO_SESSION_CREATE_INFO_KHR;

    /// <summary>sType is a VkStructureType value identifying this structure.</summary>
    public VkStructureType sType;

    /// <summary>pNext is NULL or a pointer to a structure extending this structure.</summary>
    public void* pNext;

    /// <summary>queueFamilyIndex is the index of the queue family the created video session will be used with.</summary>
    public uint queueFamilyIndex;

    /// <summary>flags is a bitmask of VkVideoSessionCreateFlagBitsKHRspecifying creation flags.</summary>
    public VkVideoSessionCreateFlagsKHR flags;

    /// <summary>
    ///     pVideoProfile is a pointer to a VkVideoProfileInfoKHRstructure specifying the video profile the created video
    ///     session will be used with.
    /// </summary>
    public VkVideoProfileInfoKHR* pVideoProfile;

    /// <summary>
    ///     pictureFormat is the image format the created video session will be used with. If pVideoProfile-&gt;
    ///     videoCodecOperation specifies a decode operation, then pictureFormat is the image format of decode output pictures
    ///     usable with the created video session. If pVideoProfile-&gt;videoCodecOperation specifies an encode operation, then
    ///     pictureFormat is the image format of encode input pictures usable with the created video session.
    /// </summary>
    public VkFormat pictureFormat;

    /// <summary>
    ///     maxCodedExtent is the maximum width and height of the coded frames the created video session will be used
    ///     with.
    /// </summary>
    public VkExtent2D maxCodedExtent;

    /// <summary>
    ///     referencePictureFormat is the image format of reference pictures stored in the DPB the created video session
    ///     will be used with.
    /// </summary>
    public VkFormat referencePictureFormat;

    /// <summary>maxDpbSlots is the maximum number of DPB Slots that can be used with the created video session.</summary>
    public uint maxDpbSlots;

    /// <summary>
    ///     maxActiveReferencePictures is the maximum number of active reference pictures that can be used in a single
    ///     video coding operation using the created video session.
    /// </summary>
    public uint maxActiveReferencePictures;

    /// <summary>
    ///     pStdHeaderVersion is a pointer to a VkExtensionPropertiesstructure requesting the Video Std header version to
    ///     use for the videoCodecOperation specified in pVideoProfile.
    /// </summary>
    public VkExtensionProperties* pStdHeaderVersion;
}