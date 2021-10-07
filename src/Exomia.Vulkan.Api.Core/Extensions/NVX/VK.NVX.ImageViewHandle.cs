#region License

// Copyright (c) 2018-2021, exomia
// All rights reserved.
// 
// This source code is licensed under the BSD-style license found in the
// LICENSE file in the root directory of this source tree.

#endregion

#pragma warning disable CA2211 // Non-constant fields should not be visible
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

using System;
using System.Runtime.InteropServices;
using Exomia.Vulkan.Api.SourceGenerator;

// ReSharper disable UnusedMember.Global
// ReSharper disable InconsistentNaming
namespace Exomia.Vulkan.Api.Core.Extensions.NVX
{
    [VkExtGenerator]
    public static unsafe partial class VKNvxImageViewHandle
    {
        public const int    VK_NVX_IMAGE_VIEW_HANDLE                = 1;
        public const int    VK_NVX_IMAGE_VIEW_HANDLE_SPEC_VERSION   = 2;
        public const string VK_NVX_IMAGE_VIEW_HANDLE_EXTENSION_NAME = "VK_NVX_image_view_handle";
        
        public static readonly delegate*<
    VkDevice, /* device */
    VkImageView, /* imageView */
    VkImageViewAddressPropertiesNVX*, /* pProperties */
    VkResult> vkGetImageViewAddressNVX = null;

public static readonly delegate*<
    VkDevice, /* device */
    VkImageViewHandleInfoNVX*, /* pInfo */
    uint> vkGetImageViewHandleNVX = null;



        public static partial void Load(VkInstance vkInstance);
    }




    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkImageViewAddressPropertiesNVX
    {
        public const VkStructureType STYPE = VkStructureType.IMAGE_VIEW_ADDRESS_PROPERTIES_NVX;
        public       VkStructureType sType;
        public       void*           pNext;
        public       VkDeviceAddress deviceAddress;
        public       VkDeviceSize    size;
    }


    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkImageViewHandleInfoNVX
    {
        public const VkStructureType  STYPE = VkStructureType.IMAGE_VIEW_HANDLE_INFO_NVX;
        public       VkStructureType  sType;
        public       void*            pNext;
        public       VkImageView      imageView;
        public       VkDescriptorType descriptorType;
        public       VkSampler        sampler;
    }




}