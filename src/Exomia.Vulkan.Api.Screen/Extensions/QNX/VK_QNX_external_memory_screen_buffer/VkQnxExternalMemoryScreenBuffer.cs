#region License

// Copyright (c) 2018-2023, exomia
// All rights reserved.
// 
// This source code is licensed under the BSD-style license found in the
// LICENSE file in the root directory of this source tree.

#endregion

global using static Exomia.Vulkan.Api.Screen.VkQnxExternalMemoryScreenBuffer;

#pragma warning disable CA2211 // Non-constant fields should not be visible
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

// ReSharper disable UnusedMember.Global
// ReSharper disable InconsistentNaming
// ReSharper disable once CheckNamespace
namespace Exomia.Vulkan.Api.Screen;

/// <summary>
///     VK_QNX_external_memory_screen_buffer - device extension (nr. 530) - author 'QNX' [platform 'screen' | contact 'Mike
///     Gorchak @mgorchak-blackberry, Aaron Ruby @aruby-blackberry']<br />
///     <a
///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_QNX_external_memory_screen_buffer.html">
///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_QNX_external_memory_screen_buffer.html
///     </a>
/// </summary>
[VkDepends("((VK_KHR_sampler_ycbcr_conversion+VK_KHR_external_memory+VK_KHR_dedicated_allocation),VK_VERSION_1_1)+VK_EXT_queue_family_foreign")]
[VkDeviceExt]
public static unsafe class VkQnxExternalMemoryScreenBuffer
{
    /// <summary> The spec version. </summary>
    public const uint VK_QNX_EXTERNAL_MEMORY_SCREEN_BUFFER_SPEC_VERSION = 1;

    /// <summary> The extension name. </summary>
    public const string VK_QNX_EXTERNAL_MEMORY_SCREEN_BUFFER_EXTENSION_NAME = "VK_QNX_external_memory_screen_buffer";

    /// <summary>
    ///     An UTF8 null terminated version of <see cref="VK_QNX_EXTERNAL_MEMORY_SCREEN_BUFFER_EXTENSION_NAME" />
    ///     represented by an UTF16 string.
    /// </summary>
    /// <remarks>
    ///     Example usage:<br />
    ///     <br />
    ///     fixed(char* ptr = VK_QNX_EXTERNAL_MEMORY_SCREEN_BUFFER_EXTENSION_NAME_UTF8_NT) {<br />
    ///     sbyte* utf8NtPtr = (sbyte*)ptr; // utf8NtPtr - can now be passed and used directly as a utf8_nt string for
    ///     unmanaged code.<br />
    ///     }
    /// </remarks>
    public const string VK_QNX_EXTERNAL_MEMORY_SCREEN_BUFFER_EXTENSION_NAME_UTF8_NT =
        "\u4b56\u515f\u584e\u455f\u5458\u5245\u414e\u5f4c\u454d\u4f4d\u5952\u535f\u5243\u4545\u5f4e\u5542\u4646\u5245\u455f\u5458\u4e45\u4953\u4e4f\u4e5f\u4d41\u0045";

    /// <summary>
    ///     vkGetScreenBufferPropertiesQNX - Get Properties of External Memory QNX Screen Buffers -
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkGetScreenBufferPropertiesQNX.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkGetScreenBufferPropertiesQNX.html</a>
    /// </summary>
    /// <param name="device">device is the logical device that will be importing buffer.</param>
    /// <param name="buffer">buffer is the QNX Screen buffer which will be imported.</param>
    /// <param name="pProperties">
    ///     pProperties is a pointer to a VkScreenBufferPropertiesQNXstructure in which the properties of
    ///     buffer are returned.
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
        _screen_buffer* /*buffer*/,
        VkScreenBufferPropertiesQNX* /*pProperties*/,
        VkResult> vkGetScreenBufferPropertiesQNX = null;

    /// <summary> Loads all function pointer based on the device for this extension. (see remarks!) </summary>
    /// <param name="device"> The device that the function pointers will be compatible with. </param>
    /// <remarks>
    ///     This load method makes the following function pointers available:<br />
    ///     <list type="bullet">
    ///         <item>
    ///             <description>vkGetScreenBufferPropertiesQNX</description>
    ///         </item>
    ///     </list>
    /// </remarks>
    public static void Load(VkDevice device)
    {
        fixed (delegate*<VkDevice, _screen_buffer*, VkScreenBufferPropertiesQNX*, VkResult>* pvkGetScreenBufferPropertiesQNX = &vkGetScreenBufferPropertiesQNX)
        {
            *pvkGetScreenBufferPropertiesQNX = (delegate*<VkDevice, _screen_buffer*, VkScreenBufferPropertiesQNX*, VkResult>)GetVkFunction(
                device, "\u6b76\u6547\u5374\u7263\u6565\u426e\u6675\u6566\u5072\u6f72\u6570\u7472\u6569\u5173\u584e\u0000");
        }
    }
}