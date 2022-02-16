#region License

// Copyright (c) 2018-2022, exomia
// All rights reserved.
// 
// This source code is licensed under the BSD-style license found in the
// LICENSE file in the root directory of this source tree.

#endregion

global using static Exomia.Vulkan.Api.Core.VkKhrGetMemoryRequirements2;

#pragma warning disable CA2211 // Non-constant fields should not be visible
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

// ReSharper disable UnusedMember.Global
// ReSharper disable InconsistentNaming
// ReSharper disable once CheckNamespace
namespace Exomia.Vulkan.Api.Core;

/// <summary>
///     VK_KHR_get_memory_requirements2 - device extension (nr. 147) - author 'KHR' [platform '' | contact 'Jason Ekstrand
///     @jekstrand']<br />
///     <a
///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_KHR_get_memory_requirements2.html">
///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_KHR_get_memory_requirements2.html
///     </a>
/// </summary>
[Obsolete("promoted to VK_VERSION_1_1", false, UrlFormat = "https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_KHR_get_memory_requirements2.html#_deprecation_state")]
public static unsafe class VkKhrGetMemoryRequirements2
{
    /// <summary> The spec version. </summary>
    public const uint VK_KHR_GET_MEMORY_REQUIREMENTS_2_SPEC_VERSION = 1;

    /// <summary> The extension name. </summary>
    public const string VK_KHR_GET_MEMORY_REQUIREMENTS_2_EXTENSION_NAME = "VK_KHR_get_memory_requirements2";

    /// <summary>
    ///     An UTF8 null terminated version of <see cref="VK_KHR_GET_MEMORY_REQUIREMENTS_2_EXTENSION_NAME" /> represented
    ///     by an UTF16 string.
    /// </summary>
    /// <remarks>
    ///     Example usage:<br />
    ///     <br />
    ///     fixed(char* ptr = VK_KHR_GET_MEMORY_REQUIREMENTS_2_EXTENSION_NAME_UTF8_NT) {<br />
    ///     sbyte* utf8NtPtr = (sbyte*)ptr; // utf8NtPtr - can now be passed and used directly as a utf8_nt string for
    ///     unmanaged code.<br />
    ///     }
    /// </remarks>
    public const string VK_KHR_GET_MEMORY_REQUIREMENTS_2_EXTENSION_NAME_UTF8_NT =
        "\u4b56\u4b5f\u5248\u475f\u5445\u4d5f\u4d45\u524f\u5f59\u4552\u5551\u5249\u4d45\u4e45\u5354\u325f\u455f\u5458\u4e45\u4953\u4e4f\u4e5f\u4d41\u0045";

    /// vkGetImageMemoryRequirements2KHR alias for vkGetImageMemoryRequirements2
    /// <summary>
    ///     vkGetImageMemoryRequirements2 - Returns the memory requirements for specified Vulkan object -
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkGetImageMemoryRequirements2KHR.html">
    ///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkGetImageMemoryRequirements2KHR.html
    ///     </a>
    /// </summary>
    public static readonly delegate*<
        VkDevice /*device*/,
        VkImageMemoryRequirementsInfo2* /*pInfo*/,
        VkMemoryRequirements2* /*pMemoryRequirements*/,
        void> vkGetImageMemoryRequirements2KHR = null;

    /// vkGetBufferMemoryRequirements2KHR alias for vkGetBufferMemoryRequirements2
    /// <summary>
    ///     vkGetBufferMemoryRequirements2 - Returns the memory requirements for specified Vulkan object -
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkGetBufferMemoryRequirements2KHR.html">
    ///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkGetBufferMemoryRequirements2KHR.html
    ///     </a>
    /// </summary>
    public static readonly delegate*<
        VkDevice /*device*/,
        VkBufferMemoryRequirementsInfo2* /*pInfo*/,
        VkMemoryRequirements2* /*pMemoryRequirements*/,
        void> vkGetBufferMemoryRequirements2KHR = null;

    /// vkGetImageSparseMemoryRequirements2KHR alias for vkGetImageSparseMemoryRequirements2
    /// <summary>
    ///     vkGetImageSparseMemoryRequirements2 - Query the memory requirements for a sparse image -
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkGetImageSparseMemoryRequirements2KHR.html">
    ///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkGetImageSparseMemoryRequirements2KHR.html
    ///     </a>
    /// </summary>
    public static readonly delegate*<
        VkDevice /*device*/,
        VkImageSparseMemoryRequirementsInfo2* /*pInfo*/,
        uint* /*pSparseMemoryRequirementCount*/,
        VkSparseImageMemoryRequirements2* /*pSparseMemoryRequirements*/,
        void> vkGetImageSparseMemoryRequirements2KHR = null;

    /// <summary> Loads all function pointer based on the device for this extension. (see remarks!) </summary>
    /// <param name="device"> The device that the function pointers will be compatible with. </param>
    /// <remarks>
    ///     This load method makes the following function pointers available:<br />
    ///     <list type="bullet">
    ///         <item>
    ///             <description>vkGetImageMemoryRequirements2KHR</description>
    ///         </item>
    ///         <item>
    ///             <description>vkGetBufferMemoryRequirements2KHR</description>
    ///         </item>
    ///         <item>
    ///             <description>vkGetImageSparseMemoryRequirements2KHR</description>
    ///         </item>
    ///     </list>
    /// </remarks>
    public static void Load(VkDevice device)
    {
        fixed (delegate*<VkDevice, VkImageMemoryRequirementsInfo2*, VkMemoryRequirements2*, void>* pvkGetImageMemoryRequirements2KHR = &vkGetImageMemoryRequirements2KHR)
        {
            *pvkGetImageMemoryRequirements2KHR = (delegate*<VkDevice, VkImageMemoryRequirementsInfo2*, VkMemoryRequirements2*, void>)Core.Vk.GetVkFunction(
                device, "\u6b76\u6547\u4974\u616d\u6567\u654d\u6f6d\u7972\u6552\u7571\u7269\u6d65\u6e65\u7374\u4b32\u5248\u0000");
        }

        fixed (delegate*<VkDevice, VkBufferMemoryRequirementsInfo2*, VkMemoryRequirements2*, void>* pvkGetBufferMemoryRequirements2KHR = &vkGetBufferMemoryRequirements2KHR)
        {
            *pvkGetBufferMemoryRequirements2KHR = (delegate*<VkDevice, VkBufferMemoryRequirementsInfo2*, VkMemoryRequirements2*, void>)Core.Vk.GetVkFunction(
                device, "\u6b76\u6547\u4274\u6675\u6566\u4d72\u6d65\u726f\u5279\u7165\u6975\u6572\u656d\u746e\u3273\u484b\u0052");
        }

        fixed (delegate*<VkDevice, VkImageSparseMemoryRequirementsInfo2*, uint*, VkSparseImageMemoryRequirements2*, void>* pvkGetImageSparseMemoryRequirements2KHR =
                   &vkGetImageSparseMemoryRequirements2KHR)
        {
            *pvkGetImageSparseMemoryRequirements2KHR = (delegate*<VkDevice, VkImageSparseMemoryRequirementsInfo2*, uint*, VkSparseImageMemoryRequirements2*, void>)Core.Vk.GetVkFunction(
                device, "\u6b76\u6547\u4974\u616d\u6567\u7053\u7261\u6573\u654d\u6f6d\u7972\u6552\u7571\u7269\u6d65\u6e65\u7374\u4b32\u5248\u0000");
        }
    }
}