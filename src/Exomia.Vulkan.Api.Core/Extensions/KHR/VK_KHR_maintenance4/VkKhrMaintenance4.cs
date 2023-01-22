#region License

// Copyright (c) 2018-2023, exomia
// All rights reserved.
// 
// This source code is licensed under the BSD-style license found in the
// LICENSE file in the root directory of this source tree.

#endregion

global using static Exomia.Vulkan.Api.Core.VkKhrMaintenance4;

#pragma warning disable CA2211 // Non-constant fields should not be visible
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

// ReSharper disable UnusedMember.Global
// ReSharper disable InconsistentNaming
// ReSharper disable once CheckNamespace
namespace Exomia.Vulkan.Api.Core;

/// <summary>
///     VK_KHR_maintenance4 - device extension (nr. 414) - author 'KHR' [platform '' | contact 'Piers Daniell
///     @pdaniell-nv']<br />
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_KHR_maintenance4.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_KHR_maintenance4.html</a>
/// </summary>
[Obsolete("promoted to VK_VERSION_1_3", false, UrlFormat = "https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_KHR_maintenance4.html#_deprecation_state")]
public static unsafe class VkKhrMaintenance4
{
    /// <summary> The spec version. </summary>
    public const uint VK_KHR_MAINTENANCE_4_SPEC_VERSION = 2;

    /// <summary> The extension name. </summary>
    public const string VK_KHR_MAINTENANCE_4_EXTENSION_NAME = "VK_KHR_maintenance4";

    /// <summary>
    ///     An UTF8 null terminated version of <see cref="VK_KHR_MAINTENANCE_4_EXTENSION_NAME" /> represented by an UTF16
    ///     string.
    /// </summary>
    /// <remarks>
    ///     Example usage:<br />
    ///     <br />
    ///     fixed(char* ptr = VK_KHR_MAINTENANCE_4_EXTENSION_NAME_UTF8_NT) {<br />
    ///     sbyte* utf8NtPtr = (sbyte*)ptr; // utf8NtPtr - can now be passed and used directly as a utf8_nt string for
    ///     unmanaged code.<br />
    ///     }
    /// </remarks>
    public const string VK_KHR_MAINTENANCE_4_EXTENSION_NAME_UTF8_NT = "\u4b56\u4b5f\u5248\u4d5f\u4941\u544e\u4e45\u4e41\u4543\u345f\u455f\u5458\u4e45\u4953\u4e4f\u4e5f\u4d41\u0045";

    /// vkGetDeviceBufferMemoryRequirementsKHR alias for vkGetDeviceBufferMemoryRequirements
    /// <summary>
    ///     vkGetDeviceBufferMemoryRequirements - Returns the memory requirements for specified Vulkan object -
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkGetDeviceBufferMemoryRequirementsKHR.html">
    ///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkGetDeviceBufferMemoryRequirementsKHR.html
    ///     </a>
    /// </summary>
    public static readonly delegate*<
        VkDevice /*device*/,
        VkDeviceBufferMemoryRequirements* /*pInfo*/,
        VkMemoryRequirements2* /*pMemoryRequirements*/,
        void> vkGetDeviceBufferMemoryRequirementsKHR = null;

    /// vkGetDeviceImageMemoryRequirementsKHR alias for vkGetDeviceImageMemoryRequirements
    /// <summary>
    ///     vkGetDeviceImageMemoryRequirements - Returns the memory requirements for specified Vulkan object -
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkGetDeviceImageMemoryRequirementsKHR.html">
    ///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkGetDeviceImageMemoryRequirementsKHR.html
    ///     </a>
    /// </summary>
    public static readonly delegate*<
        VkDevice /*device*/,
        VkDeviceImageMemoryRequirements* /*pInfo*/,
        VkMemoryRequirements2* /*pMemoryRequirements*/,
        void> vkGetDeviceImageMemoryRequirementsKHR = null;

    /// vkGetDeviceImageSparseMemoryRequirementsKHR alias for vkGetDeviceImageSparseMemoryRequirements
    /// <summary>
    ///     vkGetDeviceImageSparseMemoryRequirements - Query the memory requirements for a sparse image -
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkGetDeviceImageSparseMemoryRequirementsKHR.html">
    ///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkGetDeviceImageSparseMemoryRequirementsKHR.html
    ///     </a>
    /// </summary>
    public static readonly delegate*<
        VkDevice /*device*/,
        VkDeviceImageMemoryRequirements* /*pInfo*/,
        uint* /*pSparseMemoryRequirementCount*/,
        VkSparseImageMemoryRequirements2* /*pSparseMemoryRequirements*/,
        void> vkGetDeviceImageSparseMemoryRequirementsKHR = null;

    /// <summary> Loads all function pointer based on the device for this extension. (see remarks!) </summary>
    /// <param name="device"> The device that the function pointers will be compatible with. </param>
    /// <remarks>
    ///     This load method makes the following function pointers available:<br />
    ///     <list type="bullet">
    ///         <item>
    ///             <description>vkGetDeviceBufferMemoryRequirementsKHR</description>
    ///         </item>
    ///         <item>
    ///             <description>vkGetDeviceImageMemoryRequirementsKHR</description>
    ///         </item>
    ///         <item>
    ///             <description>vkGetDeviceImageSparseMemoryRequirementsKHR</description>
    ///         </item>
    ///     </list>
    /// </remarks>
    public static void Load(VkDevice device)
    {
        fixed (delegate*<VkDevice, VkDeviceBufferMemoryRequirements*, VkMemoryRequirements2*, void>* pvkGetDeviceBufferMemoryRequirementsKHR = &vkGetDeviceBufferMemoryRequirementsKHR)
        {
            *pvkGetDeviceBufferMemoryRequirementsKHR = (delegate*<VkDevice, VkDeviceBufferMemoryRequirements*, VkMemoryRequirements2*, void>)GetVkFunction(
                device, "\u6b76\u6547\u4474\u7665\u6369\u4265\u6675\u6566\u4d72\u6d65\u726f\u5279\u7165\u6975\u6572\u656d\u746e\u4b73\u5248\u0000");
        }

        fixed (delegate*<VkDevice, VkDeviceImageMemoryRequirements*, VkMemoryRequirements2*, void>* pvkGetDeviceImageMemoryRequirementsKHR = &vkGetDeviceImageMemoryRequirementsKHR)
        {
            *pvkGetDeviceImageMemoryRequirementsKHR = (delegate*<VkDevice, VkDeviceImageMemoryRequirements*, VkMemoryRequirements2*, void>)GetVkFunction(
                device, "\u6b76\u6547\u4474\u7665\u6369\u4965\u616d\u6567\u654d\u6f6d\u7972\u6552\u7571\u7269\u6d65\u6e65\u7374\u484b\u0052");
        }

        fixed (delegate*<VkDevice, VkDeviceImageMemoryRequirements*, uint*, VkSparseImageMemoryRequirements2*, void>* pvkGetDeviceImageSparseMemoryRequirementsKHR =
            &vkGetDeviceImageSparseMemoryRequirementsKHR)
        {
            *pvkGetDeviceImageSparseMemoryRequirementsKHR = (delegate*<VkDevice, VkDeviceImageMemoryRequirements*, uint*, VkSparseImageMemoryRequirements2*, void>)GetVkFunction(
                device, "\u6b76\u6547\u4474\u7665\u6369\u4965\u616d\u6567\u7053\u7261\u6573\u654d\u6f6d\u7972\u6552\u7571\u7269\u6d65\u6e65\u7374\u484b\u0052");
        }
    }
}