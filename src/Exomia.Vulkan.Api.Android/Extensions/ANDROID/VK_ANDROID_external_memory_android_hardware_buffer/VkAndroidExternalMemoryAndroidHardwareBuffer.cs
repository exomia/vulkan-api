#region License

// Copyright (c) 2018-2022, exomia
// All rights reserved.
// 
// This source code is licensed under the BSD-style license found in the
// LICENSE file in the root directory of this source tree.

#endregion

global using static Exomia.Vulkan.Api.Android.VkAndroidExternalMemoryAndroidHardwareBuffer;

#pragma warning disable CA2211 // Non-constant fields should not be visible
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

// ReSharper disable UnusedMember.Global
// ReSharper disable InconsistentNaming
// ReSharper disable once CheckNamespace
namespace Exomia.Vulkan.Api.Android;

/// <summary>
///     VK_ANDROID_external_memory_android_hardware_buffer - device extension (nr. 130) - author 'ANDROID' [platform
///     'android' | contact 'Jesse Hall @critsec']<br />
///     <a
///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_ANDROID_external_memory_android_hardware_buffer.html">
///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_ANDROID_external_memory_android_hardware_buffer.html
///     </a>
/// </summary>
[VkRequires("VK_KHR_sampler_ycbcr_conversion,VK_KHR_external_memory,VK_EXT_queue_family_foreign,VK_KHR_dedicated_allocation")]
public static unsafe class VkAndroidExternalMemoryAndroidHardwareBuffer
{
    /// <summary> The spec version. </summary>
    public const uint VK_ANDROID_EXTERNAL_MEMORY_ANDROID_HARDWARE_BUFFER_SPEC_VERSION = 4;

    /// <summary> The extension name. </summary>
    public const string VK_ANDROID_EXTERNAL_MEMORY_ANDROID_HARDWARE_BUFFER_EXTENSION_NAME = "VK_ANDROID_external_memory_android_hardware_buffer";

    /// <summary>
    ///     An UTF8 null terminated version of
    ///     <see cref="VK_ANDROID_EXTERNAL_MEMORY_ANDROID_HARDWARE_BUFFER_EXTENSION_NAME" /> represented by an UTF16 string.
    /// </summary>
    /// <remarks>
    ///     Example usage:<br />
    ///     <br />
    ///     fixed(char* ptr = VK_ANDROID_EXTERNAL_MEMORY_ANDROID_HARDWARE_BUFFER_EXTENSION_NAME_UTF8_NT) {<br />
    ///     sbyte* utf8NtPtr = (sbyte*)ptr; // utf8NtPtr - can now be passed and used directly as a utf8_nt string for
    ///     unmanaged code.<br />
    ///     }
    /// </remarks>
    public const string VK_ANDROID_EXTERNAL_MEMORY_ANDROID_HARDWARE_BUFFER_EXTENSION_NAME_UTF8_NT =
        "\u4b56\u415f\u444e\u4f52\u4449\u455f\u5458\u5245\u414e\u5f4c\u454d\u4f4d\u5952\u415f\u444e\u4f52\u4449\u485f\u5241\u5744\u5241\u5f45\u5542\u4646\u5245\u455f\u5458\u4e45\u4953\u4e4f\u4e5f\u4d41\u0045";

    /// <summary>
    ///     vkGetAndroidHardwareBufferPropertiesANDROID - Get Properties of External Memory Android Hardware Buffers -
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkGetAndroidHardwareBufferPropertiesANDROID.html">
    ///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkGetAndroidHardwareBufferPropertiesANDROID.html
    ///     </a>
    /// </summary>
    /// <param name="device">device is the logical device that will be importing buffer.</param>
    /// <param name="buffer">buffer is the Android hardware buffer which will be imported.</param>
    /// <param name="pProperties">
    ///     pProperties is a pointer to a VkAndroidHardwareBufferPropertiesANDROID structure in which the
    ///     properties of buffer are returned.
    /// </param>
    /// <remarks>
    ///     <list type="table">
    ///         <item>
    ///             <term>successcodes</term><description>VK_SUCCESS</description>
    ///         </item>
    ///         <item>
    ///             <term>errorcodes</term>
    ///             <description>VK_ERROR_OUT_OF_HOST_MEMORY,VK_ERROR_INVALID_EXTERNAL_HANDLE_KHR</description>
    ///         </item>
    ///     </list>
    /// </remarks>
    public static readonly delegate*<
        VkDevice /*device*/,
        AHardwareBuffer* /*buffer*/,
        VkAndroidHardwareBufferPropertiesANDROID* /*pProperties*/,
        VkResult> vkGetAndroidHardwareBufferPropertiesANDROID = null;

    /// <summary>
    ///     vkGetMemoryAndroidHardwareBufferANDROID - Get an Android hardware buffer for a memory object -
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkGetMemoryAndroidHardwareBufferANDROID.html">
    ///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkGetMemoryAndroidHardwareBufferANDROID.html
    ///     </a>
    /// </summary>
    /// <param name="device">device is the logical device that created the device memory being exported.</param>
    /// <param name="pInfo">
    ///     pInfo is a pointer to a VkMemoryGetAndroidHardwareBufferInfoANDROID structure containing parameters
    ///     of the export operation.
    /// </param>
    /// <param name="pBuffer">
    ///     pBuffer will return an Android hardware buffer referencing the payload of the device memory
    ///     object.
    /// </param>
    /// <remarks>
    ///     <list type="table">
    ///         <item>
    ///             <term>successcodes</term><description>VK_SUCCESS</description>
    ///         </item>
    ///         <item>
    ///             <term>errorcodes</term><description>VK_ERROR_TOO_MANY_OBJECTS,VK_ERROR_OUT_OF_HOST_MEMORY</description>
    ///         </item>
    ///     </list>
    /// </remarks>
    public static readonly delegate*<
        VkDevice /*device*/,
        VkMemoryGetAndroidHardwareBufferInfoANDROID* /*pInfo*/,
        AHardwareBuffer** /*pBuffer*/,
        VkResult> vkGetMemoryAndroidHardwareBufferANDROID = null;

    /// <summary> Loads all function pointer based on the device for this extension. (see remarks!) </summary>
    /// <param name="device"> The device that the function pointers will be compatible with. </param>
    /// <remarks>
    ///     This load method makes the following function pointers available:<br />
    ///     <list type="bullet">
    ///         <item>
    ///             <description>vkGetAndroidHardwareBufferPropertiesANDROID</description>
    ///         </item>
    ///         <item>
    ///             <description>vkGetMemoryAndroidHardwareBufferANDROID</description>
    ///         </item>
    ///     </list>
    /// </remarks>
    public static void Load(VkDevice device)
    {
        fixed (delegate*<VkDevice, AHardwareBuffer*, VkAndroidHardwareBufferPropertiesANDROID*, VkResult>* pvkGetAndroidHardwareBufferPropertiesANDROID = &vkGetAndroidHardwareBufferPropertiesANDROID)
        {
            *pvkGetAndroidHardwareBufferPropertiesANDROID = (delegate*<VkDevice, AHardwareBuffer*, VkAndroidHardwareBufferPropertiesANDROID*, VkResult>)Core.Vk.GetVkFunction(
                device, "\u6b76\u6547\u4174\u646e\u6f72\u6469\u6148\u6472\u6177\u6572\u7542\u6666\u7265\u7250\u706f\u7265\u6974\u7365\u4e41\u5244\u494f\u0044");
        }

        fixed (delegate*<VkDevice, VkMemoryGetAndroidHardwareBufferInfoANDROID*, AHardwareBuffer**, VkResult>* pvkGetMemoryAndroidHardwareBufferANDROID = &vkGetMemoryAndroidHardwareBufferANDROID)
        {
            *pvkGetMemoryAndroidHardwareBufferANDROID = (delegate*<VkDevice, VkMemoryGetAndroidHardwareBufferInfoANDROID*, AHardwareBuffer**, VkResult>)Core.Vk.GetVkFunction(
                device, "\u6b76\u6547\u4d74\u6d65\u726f\u4179\u646e\u6f72\u6469\u6148\u6472\u6177\u6572\u7542\u6666\u7265\u4e41\u5244\u494f\u0044");
        }
    }
}