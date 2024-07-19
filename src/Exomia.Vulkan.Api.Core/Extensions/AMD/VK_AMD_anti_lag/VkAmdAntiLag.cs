#region License

// Copyright (c) 2018-2024, exomia
// All rights reserved.
// 
// This source code is licensed under the BSD-style license found in the
// LICENSE file in the root directory of this source tree.

#endregion

global using static Exomia.Vulkan.Api.Core.VkAmdAntiLag;

#pragma warning disable CA2211 // Non-constant fields should not be visible
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

// ReSharper disable UnusedMember.Global
// ReSharper disable InconsistentNaming
// ReSharper disable once CheckNamespace
namespace Exomia.Vulkan.Api.Core;

/// <summary>
///     VK_AMD_anti_lag - device extension (nr. 477) - author 'AMD' [platform '' | contact 'Stu Smith']<br />
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_AMD_anti_lag.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_AMD_anti_lag.html</a>
/// </summary>
[VkDeviceExt]
public static unsafe class VkAmdAntiLag
{
    /// <summary> The spec version. </summary>
    public const uint VK_AMD_ANTI_LAG_SPEC_VERSION = 1;

    /// <summary> The extension name. </summary>
    public const string VK_AMD_ANTI_LAG_EXTENSION_NAME = "VK_AMD_anti_lag";

    /// <summary>
    ///     An UTF8 null terminated version of <see cref="VK_AMD_ANTI_LAG_EXTENSION_NAME" /> represented by an UTF16
    ///     string.
    /// </summary>
    /// <remarks>
    ///     Example usage:<br />
    ///     <br />
    ///     fixed(char* ptr = VK_AMD_ANTI_LAG_EXTENSION_NAME_UTF8_NT) {<br />
    ///     sbyte* utf8NtPtr = (sbyte*)ptr; // utf8NtPtr - can now be passed and used directly as a utf8_nt string for
    ///     unmanaged code.<br />
    ///     }
    /// </remarks>
    public const string VK_AMD_ANTI_LAG_EXTENSION_NAME_UTF8_NT = "\u4b56\u415f\u444d\u415f\u544e\u5f49\u414c\u5f47\u5845\u4554\u534e\u4f49\u5f4e\u414e\u454d\u0000";

    /// <summary>
    ///     vkAntiLagUpdateAMD - Provide information to reduce latency -
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkAntiLagUpdateAMD.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkAntiLagUpdateAMD.html</a>
    /// </summary>
    /// <param name="device">device is the logical device</param>
    /// <param name="pData">pData is a pointer to a VkAntiLagDataAMD structure containing latency reduction parameters.</param>
    public static readonly delegate*<
        VkDevice /*device*/,
        VkAntiLagDataAMD* /*pData*/,
        void> vkAntiLagUpdateAMD = null;

    /// <summary> Loads all function pointer based on the device for this extension. (see remarks!) </summary>
    /// <param name="device"> The device that the function pointers will be compatible with. </param>
    /// <remarks>
    ///     This load method makes the following function pointers available:<br />
    ///     <list type="bullet">
    ///         <item>
    ///             <description>vkAntiLagUpdateAMD</description>
    ///         </item>
    ///     </list>
    /// </remarks>
    public static void Load(VkDevice device)
    {
        fixed (delegate*<VkDevice, VkAntiLagDataAMD*, void>* pvkAntiLagUpdateAMD = &vkAntiLagUpdateAMD)
        {
            *pvkAntiLagUpdateAMD = (delegate*<VkDevice, VkAntiLagDataAMD*, void>)GetVkFunction(device, "\u6b76\u6e41\u6974\u614c\u5567\u6470\u7461\u4165\u444d\u0000");
        }
    }
}