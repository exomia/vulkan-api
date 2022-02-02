#region License

// Copyright (c) 2018-2022, exomia
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
///     VkDriverId - Khronos driver IDs -
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkDriverId.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkDriverId.html</a>
/// </summary>
public enum VkDriverId
{
    /// <summary>
    ///     VK_DRIVER_ID_AMD_PROPRIETARY<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkDriverId">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkDriverId</a>
    /// </summary>
    VK_DRIVER_ID_AMD_PROPRIETARY = 1,

    /// <summary>
    ///     VK_DRIVER_ID_AMD_OPEN_SOURCE<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkDriverId">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkDriverId</a>
    /// </summary>
    VK_DRIVER_ID_AMD_OPEN_SOURCE = 2,

    /// <summary>
    ///     VK_DRIVER_ID_MESA_RADV<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkDriverId">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkDriverId</a>
    /// </summary>
    VK_DRIVER_ID_MESA_RADV = 3,

    /// <summary>
    ///     VK_DRIVER_ID_NVIDIA_PROPRIETARY<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkDriverId">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkDriverId</a>
    /// </summary>
    VK_DRIVER_ID_NVIDIA_PROPRIETARY = 4,

    /// <summary>
    ///     VK_DRIVER_ID_INTEL_PROPRIETARY_WINDOWS<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkDriverId">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkDriverId</a>
    /// </summary>
    VK_DRIVER_ID_INTEL_PROPRIETARY_WINDOWS = 5,

    /// <summary>
    ///     VK_DRIVER_ID_INTEL_OPEN_SOURCE_MESA<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkDriverId">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkDriverId</a>
    /// </summary>
    VK_DRIVER_ID_INTEL_OPEN_SOURCE_MESA = 6,

    /// <summary>
    ///     VK_DRIVER_ID_IMAGINATION_PROPRIETARY<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkDriverId">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkDriverId</a>
    /// </summary>
    VK_DRIVER_ID_IMAGINATION_PROPRIETARY = 7,

    /// <summary>
    ///     VK_DRIVER_ID_QUALCOMM_PROPRIETARY<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkDriverId">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkDriverId</a>
    /// </summary>
    VK_DRIVER_ID_QUALCOMM_PROPRIETARY = 8,

    /// <summary>
    ///     VK_DRIVER_ID_ARM_PROPRIETARY<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkDriverId">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkDriverId</a>
    /// </summary>
    VK_DRIVER_ID_ARM_PROPRIETARY = 9,

    /// <summary>
    ///     VK_DRIVER_ID_GOOGLE_SWIFTSHADER<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkDriverId">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkDriverId</a>
    /// </summary>
    VK_DRIVER_ID_GOOGLE_SWIFTSHADER = 10,

    /// <summary>
    ///     VK_DRIVER_ID_GGP_PROPRIETARY<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkDriverId">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkDriverId</a>
    /// </summary>
    VK_DRIVER_ID_GGP_PROPRIETARY = 11,

    /// <summary>
    ///     VK_DRIVER_ID_BROADCOM_PROPRIETARY<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkDriverId">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkDriverId</a>
    /// </summary>
    VK_DRIVER_ID_BROADCOM_PROPRIETARY = 12,

    /// <summary>
    ///     VK_DRIVER_ID_MESA_LLVMPIPE<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkDriverId">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkDriverId</a>
    /// </summary>
    VK_DRIVER_ID_MESA_LLVMPIPE = 13,

    /// <summary>
    ///     VK_DRIVER_ID_MOLTENVK<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkDriverId">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkDriverId</a>
    /// </summary>
    VK_DRIVER_ID_MOLTENVK = 14,

    /// <summary>
    ///     VK_DRIVER_ID_COREAVI_PROPRIETARY<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkDriverId">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkDriverId</a>
    /// </summary>
    VK_DRIVER_ID_COREAVI_PROPRIETARY = 15,

    /// <summary>
    ///     VK_DRIVER_ID_JUICE_PROPRIETARY<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkDriverId">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkDriverId</a>
    /// </summary>
    VK_DRIVER_ID_JUICE_PROPRIETARY = 16,

    /// <summary>
    ///     VK_DRIVER_ID_VERISILICON_PROPRIETARY<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkDriverId">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkDriverId</a>
    /// </summary>
    VK_DRIVER_ID_VERISILICON_PROPRIETARY = 17,

    /// <summary>
    ///     VK_DRIVER_ID_MESA_TURNIP<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkDriverId">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkDriverId</a>
    /// </summary>
    VK_DRIVER_ID_MESA_TURNIP = 18,

    /// <summary>
    ///     VK_DRIVER_ID_MESA_V3DV<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkDriverId">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkDriverId</a>
    /// </summary>
    VK_DRIVER_ID_MESA_V3DV = 19,

    /// <summary>
    ///     VK_DRIVER_ID_MESA_PANVK<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkDriverId">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkDriverId</a>
    /// </summary>
    VK_DRIVER_ID_MESA_PANVK = 20,

    /// <summary>
    ///     VK_DRIVER_ID_SAMSUNG_PROPRIETARY<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkDriverId">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkDriverId</a>
    /// </summary>
    VK_DRIVER_ID_SAMSUNG_PROPRIETARY = 21,

    /// <summary>
    ///     VK_DRIVER_ID_MESA_VENUS<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkDriverId">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkDriverId</a>
    /// </summary>
    VK_DRIVER_ID_MESA_VENUS = 22,

    /// <summary>
    ///     VK_DRIVER_ID_AMD_PROPRIETARY_KHR<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkDriverId">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkDriverId</a>
    /// </summary>
    VK_DRIVER_ID_AMD_PROPRIETARY_KHR = VK_DRIVER_ID_AMD_PROPRIETARY,

    /// <summary>
    ///     VK_DRIVER_ID_AMD_OPEN_SOURCE_KHR<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkDriverId">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkDriverId</a>
    /// </summary>
    VK_DRIVER_ID_AMD_OPEN_SOURCE_KHR = VK_DRIVER_ID_AMD_OPEN_SOURCE,

    /// <summary>
    ///     VK_DRIVER_ID_MESA_RADV_KHR<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkDriverId">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkDriverId</a>
    /// </summary>
    VK_DRIVER_ID_MESA_RADV_KHR = VK_DRIVER_ID_MESA_RADV,

    /// <summary>
    ///     VK_DRIVER_ID_NVIDIA_PROPRIETARY_KHR<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkDriverId">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkDriverId</a>
    /// </summary>
    VK_DRIVER_ID_NVIDIA_PROPRIETARY_KHR = VK_DRIVER_ID_NVIDIA_PROPRIETARY,

    /// <summary>
    ///     VK_DRIVER_ID_INTEL_PROPRIETARY_WINDOWS_KHR<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkDriverId">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkDriverId</a>
    /// </summary>
    VK_DRIVER_ID_INTEL_PROPRIETARY_WINDOWS_KHR = VK_DRIVER_ID_INTEL_PROPRIETARY_WINDOWS,

    /// <summary>
    ///     VK_DRIVER_ID_INTEL_OPEN_SOURCE_MESA_KHR<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkDriverId">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkDriverId</a>
    /// </summary>
    VK_DRIVER_ID_INTEL_OPEN_SOURCE_MESA_KHR = VK_DRIVER_ID_INTEL_OPEN_SOURCE_MESA,

    /// <summary>
    ///     VK_DRIVER_ID_IMAGINATION_PROPRIETARY_KHR<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkDriverId">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkDriverId</a>
    /// </summary>
    VK_DRIVER_ID_IMAGINATION_PROPRIETARY_KHR = VK_DRIVER_ID_IMAGINATION_PROPRIETARY,

    /// <summary>
    ///     VK_DRIVER_ID_QUALCOMM_PROPRIETARY_KHR<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkDriverId">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkDriverId</a>
    /// </summary>
    VK_DRIVER_ID_QUALCOMM_PROPRIETARY_KHR = VK_DRIVER_ID_QUALCOMM_PROPRIETARY,

    /// <summary>
    ///     VK_DRIVER_ID_ARM_PROPRIETARY_KHR<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkDriverId">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkDriverId</a>
    /// </summary>
    VK_DRIVER_ID_ARM_PROPRIETARY_KHR = VK_DRIVER_ID_ARM_PROPRIETARY,

    /// <summary>
    ///     VK_DRIVER_ID_GOOGLE_SWIFTSHADER_KHR<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkDriverId">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkDriverId</a>
    /// </summary>
    VK_DRIVER_ID_GOOGLE_SWIFTSHADER_KHR = VK_DRIVER_ID_GOOGLE_SWIFTSHADER,

    /// <summary>
    ///     VK_DRIVER_ID_GGP_PROPRIETARY_KHR<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkDriverId">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkDriverId</a>
    /// </summary>
    VK_DRIVER_ID_GGP_PROPRIETARY_KHR = VK_DRIVER_ID_GGP_PROPRIETARY,

    /// <summary>
    ///     VK_DRIVER_ID_BROADCOM_PROPRIETARY_KHR<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkDriverId">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkDriverId</a>
    /// </summary>
    VK_DRIVER_ID_BROADCOM_PROPRIETARY_KHR = VK_DRIVER_ID_BROADCOM_PROPRIETARY
}