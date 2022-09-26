#region License

// Copyright (c) 2018-2022, exomia
// All rights reserved.
// 
// This source code is licensed under the BSD-style license found in the
// LICENSE file in the root directory of this source tree.

#endregion

global using static Exomia.Vulkan.Api.Fuchsia.VkFuchsiaBufferCollection;

#pragma warning disable CA2211 // Non-constant fields should not be visible
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

// ReSharper disable UnusedMember.Global
// ReSharper disable InconsistentNaming
// ReSharper disable once CheckNamespace
namespace Exomia.Vulkan.Api.Fuchsia;

/// <summary>
///     VK_FUCHSIA_buffer_collection - device extension (nr. 367) - author 'FUCHSIA' [platform 'fuchsia' | contact 'John Rosasco @rosasco']
///     <br />
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_FUCHSIA_buffer_collection.html"> https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_FUCHSIA_buffer_collection.html </a>
/// </summary>
[VkRequires("VK_FUCHSIA_external_memory,VK_KHR_sampler_ycbcr_conversion")]
public static unsafe class VkFuchsiaBufferCollection
{
    /// <summary> The spec version. </summary>
    public const uint VK_FUCHSIA_BUFFER_COLLECTION_SPEC_VERSION = 2;

    /// <summary> The extension name. </summary>
    public const string VK_FUCHSIA_BUFFER_COLLECTION_EXTENSION_NAME = "VK_FUCHSIA_buffer_collection";

    /// <summary> An UTF8 null terminated version of <see cref="VK_FUCHSIA_BUFFER_COLLECTION_EXTENSION_NAME" /> represented by an UTF16 string. </summary>
    /// <remarks>
    ///     Example usage:<br />
    ///     <br />
    ///     fixed(char* ptr = VK_FUCHSIA_BUFFER_COLLECTION_EXTENSION_NAME_UTF8_NT) {<br />
    ///     sbyte* utf8NtPtr = (sbyte*)ptr; // utf8NtPtr - can now be passed and used directly as a utf8_nt string for unmanaged code.
    ///     <br />
    ///     }
    /// </remarks>
    public const string VK_FUCHSIA_BUFFER_COLLECTION_EXTENSION_NAME_UTF8_NT =
        "\u4b56\u465f\u4355\u5348\u4149\u425f\u4655\u4546\u5f52\u4f43\u4c4c\u4345\u4954\u4e4f\u455f\u5458\u4e45\u4953\u4e4f\u4e5f\u4d41\u0045";

    /// <summary>
    ///     vkCreateBufferCollectionFUCHSIA - Create a new buffer collection -
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCreateBufferCollectionFUCHSIA.html">
    ///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCreateBufferCollectionFUCHSIA.html
    ///     </a>
    /// </summary>
    /// <param name="device"> device is the logical device that creates the VkBufferCollectionFUCHSIA </param>
    /// <param name="pCreateInfo"> pCreateInfo is a pointer to a VkBufferCollectionCreateInfoFUCHSIA structure containing parameters affecting creation of the buffer collection </param>
    /// <param name="pAllocator"> pAllocator is a pointer to a VkAllocationCallbacks structure controlling host memory allocation as described in the Memory Allocation chapter </param>
    /// <param name="pCollection"> VUID-vkCreateBufferCollectionFUCHSIA-pCollection-parameter pCollection must be a valid pointer to a VkBufferCollectionFUCHSIA handle </param>
    /// <remarks>
    ///     <list type="table">
    ///         <item>
    ///             <term> successcodes </term><description> VK_SUCCESS </description>
    ///         </item>
    ///         <item>
    ///             <term> errorcodes </term>
    ///             <description> VK_ERROR_OUT_OF_HOST_MEMORY,VK_ERROR_INVALID_EXTERNAL_HANDLE,VK_ERROR_INITIALIZATION_FAILED </description>
    ///         </item>
    ///     </list>
    /// </remarks>
    public static readonly delegate*<
        VkDevice /*device*/,
        VkBufferCollectionCreateInfoFUCHSIA* /*pCreateInfo*/,
        VkAllocationCallbacks* /*pAllocator*/,
        VkBufferCollectionFUCHSIA* /*pCollection*/,
        VkResult> vkCreateBufferCollectionFUCHSIA = null;

    /// <summary>
    ///     vkSetBufferCollectionImageConstraintsFUCHSIA - Set image-based constraints for a buffer collection -
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkSetBufferCollectionImageConstraintsFUCHSIA.html">
    ///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkSetBufferCollectionImageConstraintsFUCHSIA.html
    ///     </a>
    /// </summary>
    /// <param name="device"> device is the logical device </param>
    /// <param name="collection"> collection is the VkBufferCollectionFUCHSIA handle </param>
    /// <param name="pImageConstraintsInfo"> pImageConstraintsInfo is a pointer to a VkImageConstraintsInfoFUCHSIA structure </param>
    /// <remarks>
    ///     <list type="table">
    ///         <item>
    ///             <term> successcodes </term><description> VK_SUCCESS </description>
    ///         </item>
    ///         <item>
    ///             <term> errorcodes </term>
    ///             <description> VK_ERROR_INITIALIZATION_FAILED,VK_ERROR_OUT_OF_HOST_MEMORY,VK_ERROR_FORMAT_NOT_SUPPORTED </description>
    ///         </item>
    ///     </list>
    /// </remarks>
    public static readonly delegate*<
        VkDevice /*device*/,
        VkBufferCollectionFUCHSIA /*collection*/,
        VkImageConstraintsInfoFUCHSIA* /*pImageConstraintsInfo*/,
        VkResult> vkSetBufferCollectionImageConstraintsFUCHSIA = null;

    /// <summary>
    ///     vkSetBufferCollectionBufferConstraintsFUCHSIA - Set buffer-based constraints for a buffer collection -
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkSetBufferCollectionBufferConstraintsFUCHSIA.html">
    ///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkSetBufferCollectionBufferConstraintsFUCHSIA.html
    ///     </a>
    /// </summary>
    /// <param name="device"> device is the logical device </param>
    /// <param name="collection"> collection is the VkBufferCollectionFUCHSIA handle </param>
    /// <param name="pBufferConstraintsInfo"> pBufferConstraintsInfo is a pointer to a VkBufferConstraintsInfoFUCHSIA structure </param>
    /// <remarks>
    ///     <list type="table">
    ///         <item>
    ///             <term> successcodes </term><description> VK_SUCCESS </description>
    ///         </item>
    ///         <item>
    ///             <term> errorcodes </term>
    ///             <description> VK_ERROR_INITIALIZATION_FAILED,VK_ERROR_OUT_OF_HOST_MEMORY,VK_ERROR_FORMAT_NOT_SUPPORTED </description>
    ///         </item>
    ///     </list>
    /// </remarks>
    public static readonly delegate*<
        VkDevice /*device*/,
        VkBufferCollectionFUCHSIA /*collection*/,
        VkBufferConstraintsInfoFUCHSIA* /*pBufferConstraintsInfo*/,
        VkResult> vkSetBufferCollectionBufferConstraintsFUCHSIA = null;

    /// <summary>
    ///     vkDestroyBufferCollectionFUCHSIA - Destroy a buffer collection -
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkDestroyBufferCollectionFUCHSIA.html">
    ///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkDestroyBufferCollectionFUCHSIA.html
    ///     </a>
    /// </summary>
    /// <param name="device"> device is the logical device that creates the VkBufferCollectionFUCHSIA </param>
    /// <param name="collection"> collection is the VkBufferCollectionFUCHSIA handle </param>
    /// <param name="pAllocator"> pAllocator is a pointer to a VkAllocationCallbacks structure controlling host memory allocation as described in the Memory Allocation chapter </param>
    public static readonly delegate*<
        VkDevice /*device*/,
        VkBufferCollectionFUCHSIA /*collection*/,
        VkAllocationCallbacks* /*pAllocator*/,
        void> vkDestroyBufferCollectionFUCHSIA = null;

    /// <summary>
    ///     vkGetBufferCollectionPropertiesFUCHSIA - Retrieve properties from a buffer collection -
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkGetBufferCollectionPropertiesFUCHSIA.html">
    ///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkGetBufferCollectionPropertiesFUCHSIA.html
    ///     </a>
    /// </summary>
    /// <param name="device"> device is the logical device handle </param>
    /// <param name="collection"> collection is the VkBufferCollectionFUCHSIA handle </param>
    /// <param name="pProperties"> pProperties is a pointer to the retrieved VkBufferCollectionPropertiesFUCHSIA struct </param>
    /// <remarks>
    ///     <list type="table">
    ///         <item>
    ///             <term> successcodes </term><description> VK_SUCCESS </description>
    ///         </item>
    ///         <item>
    ///             <term> errorcodes </term>
    ///             <description> VK_ERROR_OUT_OF_HOST_MEMORY,VK_ERROR_INITIALIZATION_FAILED </description>
    ///         </item>
    ///     </list>
    /// </remarks>
    public static readonly delegate*<
        VkDevice /*device*/,
        VkBufferCollectionFUCHSIA /*collection*/,
        VkBufferCollectionPropertiesFUCHSIA* /*pProperties*/,
        VkResult> vkGetBufferCollectionPropertiesFUCHSIA = null;

    /// <summary> Loads all function pointer based on the device for this extension. (see remarks!) </summary>
    /// <param name="device"> The device that the function pointers will be compatible with. </param>
    /// <remarks>
    ///     This load method makes the following function pointers available:<br />
    ///     <list type="bullet">
    ///         <item>
    ///             <description> vkCreateBufferCollectionFUCHSIA </description>
    ///         </item>
    ///         <item>
    ///             <description> vkSetBufferCollectionImageConstraintsFUCHSIA </description>
    ///         </item>
    ///         <item>
    ///             <description> vkSetBufferCollectionBufferConstraintsFUCHSIA </description>
    ///         </item>
    ///         <item>
    ///             <description> vkDestroyBufferCollectionFUCHSIA </description>
    ///         </item>
    ///         <item>
    ///             <description> vkGetBufferCollectionPropertiesFUCHSIA </description>
    ///         </item>
    ///     </list>
    /// </remarks>
    public static void Load(VkDevice device)
    {
        fixed (delegate*<VkDevice, VkBufferCollectionCreateInfoFUCHSIA*, VkAllocationCallbacks*, VkBufferCollectionFUCHSIA*, VkResult>* pvkCreateBufferCollectionFUCHSIA =
            &vkCreateBufferCollectionFUCHSIA)
        {
            *pvkCreateBufferCollectionFUCHSIA = (delegate*<VkDevice, VkBufferCollectionCreateInfoFUCHSIA*, VkAllocationCallbacks*, VkBufferCollectionFUCHSIA*, VkResult>)GetVkFunction(
                device, "\u6b76\u7243\u6165\u6574\u7542\u6666\u7265\u6f43\u6c6c\u6365\u6974\u6e6f\u5546\u4843\u4953\u0041");
        }

        fixed (delegate*<VkDevice, VkBufferCollectionFUCHSIA, VkImageConstraintsInfoFUCHSIA*, VkResult>* pvkSetBufferCollectionImageConstraintsFUCHSIA = &vkSetBufferCollectionImageConstraintsFUCHSIA)
        {
            *pvkSetBufferCollectionImageConstraintsFUCHSIA = (delegate*<VkDevice, VkBufferCollectionFUCHSIA, VkImageConstraintsInfoFUCHSIA*, VkResult>)GetVkFunction(
                device, "\u6b76\u6553\u4274\u6675\u6566\u4372\u6c6f\u656c\u7463\u6f69\u496e\u616d\u6567\u6f43\u736e\u7274\u6961\u746e\u4673\u4355\u5348\u4149\u0000");
        }

        fixed (delegate*<VkDevice, VkBufferCollectionFUCHSIA, VkBufferConstraintsInfoFUCHSIA*, VkResult>* pvkSetBufferCollectionBufferConstraintsFUCHSIA =
            &vkSetBufferCollectionBufferConstraintsFUCHSIA)
        {
            *pvkSetBufferCollectionBufferConstraintsFUCHSIA = (delegate*<VkDevice, VkBufferCollectionFUCHSIA, VkBufferConstraintsInfoFUCHSIA*, VkResult>)GetVkFunction(
                device, "\u6b76\u6553\u4274\u6675\u6566\u4372\u6c6f\u656c\u7463\u6f69\u426e\u6675\u6566\u4372\u6e6f\u7473\u6172\u6e69\u7374\u5546\u4843\u4953\u0041");
        }

        fixed (delegate*<VkDevice, VkBufferCollectionFUCHSIA, VkAllocationCallbacks*, void>* pvkDestroyBufferCollectionFUCHSIA = &vkDestroyBufferCollectionFUCHSIA)
        {
            *pvkDestroyBufferCollectionFUCHSIA = (delegate*<VkDevice, VkBufferCollectionFUCHSIA, VkAllocationCallbacks*, void>)GetVkFunction(
                device, "\u6b76\u6544\u7473\u6f72\u4279\u6675\u6566\u4372\u6c6f\u656c\u7463\u6f69\u466e\u4355\u5348\u4149\u0000");
        }

        fixed (delegate*<VkDevice, VkBufferCollectionFUCHSIA, VkBufferCollectionPropertiesFUCHSIA*, VkResult>* pvkGetBufferCollectionPropertiesFUCHSIA = &vkGetBufferCollectionPropertiesFUCHSIA)
        {
            *pvkGetBufferCollectionPropertiesFUCHSIA = (delegate*<VkDevice, VkBufferCollectionFUCHSIA, VkBufferCollectionPropertiesFUCHSIA*, VkResult>)GetVkFunction(
                device, "\u6b76\u6547\u4274\u6675\u6566\u4372\u6c6f\u656c\u7463\u6f69\u506e\u6f72\u6570\u7472\u6569\u4673\u4355\u5348\u4149\u0000");
        }
    }
}