#region License

// Copyright (c) 2018-2022, exomia
// All rights reserved.
// 
// This source code is licensed under the BSD-style license found in the
// LICENSE file in the root directory of this source tree.

#endregion

global using static Exomia.Vulkan.Api.Core.VkExtDebugUtils;

#pragma warning disable CA2211 // Non-constant fields should not be visible
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

// ReSharper disable UnusedMember.Global
// ReSharper disable InconsistentNaming
// ReSharper disable once CheckNamespace
namespace Exomia.Vulkan.Api.Core;

/// <summary>
///     VK_EXT_debug_utils - instance extension (nr. 129) - author 'EXT' [platform '' | contact 'Mark Young @marky-lunarg']
///     <br />
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_EXT_debug_utils.html"> https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_EXT_debug_utils.html </a>
/// </summary>
/// <remarks>
///     specialuse: debugging
/// </remarks>
[VkSpecialuse("debugging")]
public static unsafe class VkExtDebugUtils
{
    /// <summary> The spec version. </summary>
    public const uint VK_EXT_DEBUG_UTILS_SPEC_VERSION = 2;

    /// <summary> The extension name. </summary>
    public const string VK_EXT_DEBUG_UTILS_EXTENSION_NAME = "VK_EXT_debug_utils";

    /// <summary> An UTF8 null terminated version of <see cref="VK_EXT_DEBUG_UTILS_EXTENSION_NAME" /> represented by an UTF16 string. </summary>
    /// <remarks>
    ///     Example usage:<br />
    ///     <br />
    ///     fixed(char* ptr = VK_EXT_DEBUG_UTILS_EXTENSION_NAME_UTF8_NT) {<br />
    ///     sbyte* utf8NtPtr = (sbyte*)ptr; // utf8NtPtr - can now be passed and used directly as a utf8_nt string for unmanaged code.
    ///     <br />
    ///     }
    /// </remarks>
    public const string VK_EXT_DEBUG_UTILS_EXTENSION_NAME_UTF8_NT = "\u4b56\u455f\u5458\u445f\u4245\u4755\u555f\u4954\u534c\u455f\u5458\u4e45\u4953\u4e4f\u4e5f\u4d41\u0045";

    /// <summary>
    ///     vkSetDebugUtilsObjectNameEXT - Give a user-friendly name to an object -
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkSetDebugUtilsObjectNameEXT.html"> https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkSetDebugUtilsObjectNameEXT.html </a>
    /// </summary>
    /// <param name="device"> device is the device that created the object. </param>
    /// <param name="pNameInfo"> pNameInfo is a pointer to a VkDebugUtilsObjectNameInfoEXTstructure specifying parameters of the name to set on the object. </param>
    /// <remarks>
    ///     <list type="table">
    ///         <item>
    ///             <term> successcodes </term><description> VK_SUCCESS </description>
    ///         </item>
    ///         <item>
    ///             <term> errorcodes </term>
    ///             <description> VK_ERROR_OUT_OF_HOST_MEMORY,VK_ERROR_OUT_OF_DEVICE_MEMORY </description>
    ///         </item>
    ///     </list>
    /// </remarks>
    public static readonly delegate*<
        VkDevice /*device*/,
        VkDebugUtilsObjectNameInfoEXT* /*pNameInfo*/,
        VkResult> vkSetDebugUtilsObjectNameEXT = null;

    /// <summary>
    ///     vkSetDebugUtilsObjectTagEXT - Attach arbitrary data to an object -
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkSetDebugUtilsObjectTagEXT.html"> https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkSetDebugUtilsObjectTagEXT.html </a>
    /// </summary>
    /// <param name="device"> device is the device that created the object. </param>
    /// <param name="pTagInfo"> pTagInfo is a pointer to a VkDebugUtilsObjectTagInfoEXTstructure specifying parameters of the tag to attach to the object. </param>
    /// <remarks>
    ///     <list type="table">
    ///         <item>
    ///             <term> successcodes </term><description> VK_SUCCESS </description>
    ///         </item>
    ///         <item>
    ///             <term> errorcodes </term>
    ///             <description> VK_ERROR_OUT_OF_HOST_MEMORY,VK_ERROR_OUT_OF_DEVICE_MEMORY </description>
    ///         </item>
    ///     </list>
    /// </remarks>
    public static readonly delegate*<
        VkDevice /*device*/,
        VkDebugUtilsObjectTagInfoEXT* /*pTagInfo*/,
        VkResult> vkSetDebugUtilsObjectTagEXT = null;

    /// <summary>
    ///     vkQueueBeginDebugUtilsLabelEXT - Open a queue debug label region -
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkQueueBeginDebugUtilsLabelEXT.html"> https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkQueueBeginDebugUtilsLabelEXT.html </a>
    /// </summary>
    /// <param name="queue"> queue is the queue in which to start a debug label region. </param>
    /// <param name="pLabelInfo"> pLabelInfo is a pointer to a VkDebugUtilsLabelEXT structure specifying parameters of the label region to open. </param>
    public static readonly delegate*<
        VkQueue /*queue*/,
        VkDebugUtilsLabelEXT* /*pLabelInfo*/,
        void> vkQueueBeginDebugUtilsLabelEXT = null;

    /// <summary>
    ///     vkQueueEndDebugUtilsLabelEXT - Close a queue debug label region -
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkQueueEndDebugUtilsLabelEXT.html"> https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkQueueEndDebugUtilsLabelEXT.html </a>
    /// </summary>
    /// <param name="queue"> queue is the queue in which a debug label region should be closed. </param>
    public static readonly delegate*<
        VkQueue /*queue*/,
        void> vkQueueEndDebugUtilsLabelEXT = null;

    /// <summary>
    ///     vkQueueInsertDebugUtilsLabelEXT - Insert a label into a queue -
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkQueueInsertDebugUtilsLabelEXT.html">
    ///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkQueueInsertDebugUtilsLabelEXT.html
    ///     </a>
    /// </summary>
    /// <param name="queue"> queue is the queue into which a debug label will be inserted. </param>
    /// <param name="pLabelInfo"> pLabelInfo is a pointer to a VkDebugUtilsLabelEXT structure specifying parameters of the label to insert. </param>
    public static readonly delegate*<
        VkQueue /*queue*/,
        VkDebugUtilsLabelEXT* /*pLabelInfo*/,
        void> vkQueueInsertDebugUtilsLabelEXT = null;

    /// <summary>
    ///     vkCmdBeginDebugUtilsLabelEXT - Open a command buffer debug label region -
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdBeginDebugUtilsLabelEXT.html"> https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdBeginDebugUtilsLabelEXT.html </a>
    /// </summary>
    /// <param name="commandBuffer"> commandBuffer is the command buffer into which the command is recorded. </param>
    /// <param name="pLabelInfo"> pLabelInfo is a pointer to a VkDebugUtilsLabelEXT structure specifying parameters of the label region to open. </param>
    public static readonly delegate*<
        VkCommandBuffer /*commandBuffer*/,
        VkDebugUtilsLabelEXT* /*pLabelInfo*/,
        void> vkCmdBeginDebugUtilsLabelEXT = null;

    /// <summary>
    ///     vkCmdEndDebugUtilsLabelEXT - Close a command buffer label region -
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdEndDebugUtilsLabelEXT.html"> https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdEndDebugUtilsLabelEXT.html </a>
    /// </summary>
    /// <param name="commandBuffer"> commandBuffer is the command buffer into which the command is recorded. </param>
    public static readonly delegate*<
        VkCommandBuffer /*commandBuffer*/,
        void> vkCmdEndDebugUtilsLabelEXT = null;

    /// <summary>
    ///     vkCmdInsertDebugUtilsLabelEXT - Insert a label into a command buffer -
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdInsertDebugUtilsLabelEXT.html"> https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdInsertDebugUtilsLabelEXT.html </a>
    /// </summary>
    /// <param name="commandBuffer"> commandBuffer is the command buffer into which the command is recorded. </param>
    /// <param name="pLabelInfo"> VUID-vkCmdInsertDebugUtilsLabelEXT-pLabelInfo-parameter pLabelInfo must be a valid pointer to a valid VkDebugUtilsLabelEXT structure </param>
    public static readonly delegate*<
        VkCommandBuffer /*commandBuffer*/,
        VkDebugUtilsLabelEXT* /*pLabelInfo*/,
        void> vkCmdInsertDebugUtilsLabelEXT = null;

    /// <summary>
    ///     vkCreateDebugUtilsMessengerEXT - Create a debug messenger object -
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCreateDebugUtilsMessengerEXT.html"> https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCreateDebugUtilsMessengerEXT.html </a>
    /// </summary>
    /// <param name="instance"> instance is the instance the messenger will be used with. </param>
    /// <param name="pCreateInfo"> pCreateInfo is a pointer to a VkDebugUtilsMessengerCreateInfoEXT structure containing the callback pointer, as well as defining conditions under which this messenger will trigger the callback. </param>
    /// <param name="pAllocator"> pAllocator controls host memory allocation as described in the Memory Allocation chapter. </param>
    /// <param name="pMessenger"> pMessenger is a pointer to a VkDebugUtilsMessengerEXT handle in which the created object is returned. </param>
    /// <remarks>
    ///     <list type="table">
    ///         <item>
    ///             <term> successcodes </term><description> VK_SUCCESS </description>
    ///         </item>
    ///         <item>
    ///             <term> errorcodes </term><description> VK_ERROR_OUT_OF_HOST_MEMORY </description>
    ///         </item>
    ///     </list>
    /// </remarks>
    public static readonly delegate*<
        VkInstance /*instance*/,
        VkDebugUtilsMessengerCreateInfoEXT* /*pCreateInfo*/,
        VkAllocationCallbacks* /*pAllocator*/,
        VkDebugUtilsMessengerEXT* /*pMessenger*/,
        VkResult> vkCreateDebugUtilsMessengerEXT = null;

    /// <summary>
    ///     vkDestroyDebugUtilsMessengerEXT - Destroy a debug messenger object -
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkDestroyDebugUtilsMessengerEXT.html">
    ///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkDestroyDebugUtilsMessengerEXT.html
    ///     </a>
    /// </summary>
    /// <param name="instance"> instance is the instance where the callback was created. </param>
    /// <param name="messenger"> messenger is the VkDebugUtilsMessengerEXT object to destroy. messenger is an externally synchronized object and must not be used on more than one thread at a time. This means that vkDestroyDebugUtilsMessengerEXT must not be called when a callback is active. </param>
    /// <param name="pAllocator"> pAllocator controls host memory allocation as described in the Memory Allocation chapter. </param>
    public static readonly delegate*<
        VkInstance /*instance*/,
        VkDebugUtilsMessengerEXT /*messenger*/,
        VkAllocationCallbacks* /*pAllocator*/,
        void> vkDestroyDebugUtilsMessengerEXT = null;

    /// <summary>
    ///     vkSubmitDebugUtilsMessageEXT - Inject a message into a debug stream -
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkSubmitDebugUtilsMessageEXT.html"> https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkSubmitDebugUtilsMessageEXT.html </a>
    /// </summary>
    /// <param name="instance"> instance is the debug stream&#8217;s VkInstance. </param>
    /// <param name="messageSeverity"> messageSeverity is a VkDebugUtilsMessageSeverityFlagBitsEXTvalue specifying the severity of this event/message. </param>
    /// <param name="messageTypes"> messageTypes is a bitmask of VkDebugUtilsMessageTypeFlagBitsEXT specifying which type of event(s) to identify with this message. </param>
    /// <param name="pCallbackData"> pCallbackData contains all the callback related data in the VkDebugUtilsMessengerCallbackDataEXT structure. </param>
    public static readonly delegate*<
        VkInstance /*instance*/,
        VkDebugUtilsMessageSeverityFlagBitsEXT /*messageSeverity*/,
        VkDebugUtilsMessageTypeFlagsEXT /*messageTypes*/,
        VkDebugUtilsMessengerCallbackDataEXT* /*pCallbackData*/,
        void> vkSubmitDebugUtilsMessageEXT = null;

    /// <summary> Loads all function pointer based on the device for this extension. (see remarks!) </summary>
    /// <param name="device"> The device that the function pointers will be compatible with. </param>
    /// <remarks>
    ///     This load method makes the following function pointers available:<br />
    ///     <list type="bullet">
    ///         <item>
    ///             <description> vkSetDebugUtilsObjectNameEXT </description>
    ///         </item>
    ///         <item>
    ///             <description> vkSetDebugUtilsObjectTagEXT </description>
    ///         </item>
    ///         <item>
    ///             <description> vkQueueBeginDebugUtilsLabelEXT </description>
    ///         </item>
    ///         <item>
    ///             <description> vkQueueEndDebugUtilsLabelEXT </description>
    ///         </item>
    ///         <item>
    ///             <description> vkQueueInsertDebugUtilsLabelEXT </description>
    ///         </item>
    ///         <item>
    ///             <description> vkCmdBeginDebugUtilsLabelEXT </description>
    ///         </item>
    ///         <item>
    ///             <description> vkCmdEndDebugUtilsLabelEXT </description>
    ///         </item>
    ///         <item>
    ///             <description> vkCmdInsertDebugUtilsLabelEXT </description>
    ///         </item>
    ///     </list>
    /// </remarks>
    public static void Load(VkDevice device)
    {
        fixed (delegate*<VkDevice, VkDebugUtilsObjectNameInfoEXT*, VkResult>* pvkSetDebugUtilsObjectNameEXT = &vkSetDebugUtilsObjectNameEXT)
        {
            *pvkSetDebugUtilsObjectNameEXT = (delegate*<VkDevice, VkDebugUtilsObjectNameInfoEXT*, VkResult>)GetVkFunction(
                device, "\u6b76\u6553\u4474\u6265\u6775\u7455\u6c69\u4f73\u6a62\u6365\u4e74\u6d61\u4565\u5458\u0000");
        }

        fixed (delegate*<VkDevice, VkDebugUtilsObjectTagInfoEXT*, VkResult>* pvkSetDebugUtilsObjectTagEXT = &vkSetDebugUtilsObjectTagEXT)
        {
            *pvkSetDebugUtilsObjectTagEXT = (delegate*<VkDevice, VkDebugUtilsObjectTagInfoEXT*, VkResult>)GetVkFunction(
                device, "\u6b76\u6553\u4474\u6265\u6775\u7455\u6c69\u4f73\u6a62\u6365\u5474\u6761\u5845\u0054");
        }

        fixed (delegate*<VkQueue, VkDebugUtilsLabelEXT*, void>* pvkQueueBeginDebugUtilsLabelEXT = &vkQueueBeginDebugUtilsLabelEXT)
        {
            *pvkQueueBeginDebugUtilsLabelEXT = (delegate*<VkQueue, VkDebugUtilsLabelEXT*, void>)GetVkFunction(
                device, "\u6b76\u7551\u7565\u4265\u6765\u6e69\u6544\u7562\u5567\u6974\u736c\u614c\u6562\u456c\u5458\u0000");
        }

        fixed (delegate*<VkQueue, void>* pvkQueueEndDebugUtilsLabelEXT = &vkQueueEndDebugUtilsLabelEXT)
        {
            *pvkQueueEndDebugUtilsLabelEXT = (delegate*<VkQueue, void>)GetVkFunction(device, "\u6b76\u7551\u7565\u4565\u646e\u6544\u7562\u5567\u6974\u736c\u614c\u6562\u456c\u5458\u0000");
        }

        fixed (delegate*<VkQueue, VkDebugUtilsLabelEXT*, void>* pvkQueueInsertDebugUtilsLabelEXT = &vkQueueInsertDebugUtilsLabelEXT)
        {
            *pvkQueueInsertDebugUtilsLabelEXT = (delegate*<VkQueue, VkDebugUtilsLabelEXT*, void>)GetVkFunction(
                device, "\u6b76\u7551\u7565\u4965\u736e\u7265\u4474\u6265\u6775\u7455\u6c69\u4c73\u6261\u6c65\u5845\u0054");
        }

        fixed (delegate*<VkCommandBuffer, VkDebugUtilsLabelEXT*, void>* pvkCmdBeginDebugUtilsLabelEXT = &vkCmdBeginDebugUtilsLabelEXT)
        {
            *pvkCmdBeginDebugUtilsLabelEXT = (delegate*<VkCommandBuffer, VkDebugUtilsLabelEXT*, void>)GetVkFunction(
                device, "\u6b76\u6d43\u4264\u6765\u6e69\u6544\u7562\u5567\u6974\u736c\u614c\u6562\u456c\u5458\u0000");
        }

        fixed (delegate*<VkCommandBuffer, void>* pvkCmdEndDebugUtilsLabelEXT = &vkCmdEndDebugUtilsLabelEXT)
        {
            *pvkCmdEndDebugUtilsLabelEXT = (delegate*<VkCommandBuffer, void>)GetVkFunction(device, "\u6b76\u6d43\u4564\u646e\u6544\u7562\u5567\u6974\u736c\u614c\u6562\u456c\u5458\u0000");
        }

        fixed (delegate*<VkCommandBuffer, VkDebugUtilsLabelEXT*, void>* pvkCmdInsertDebugUtilsLabelEXT = &vkCmdInsertDebugUtilsLabelEXT)
        {
            *pvkCmdInsertDebugUtilsLabelEXT = (delegate*<VkCommandBuffer, VkDebugUtilsLabelEXT*, void>)GetVkFunction(
                device, "\u6b76\u6d43\u4964\u736e\u7265\u4474\u6265\u6775\u7455\u6c69\u4c73\u6261\u6c65\u5845\u0054");
        }
    }

    /// <summary> Loads all function pointer based on the instance for this extension. (see remarks!) </summary>
    /// <param name="instance"> The instance that the function pointers will be compatible with. </param>
    /// <remarks>
    ///     This load method makes the following function pointers available:<br />
    ///     <list type="bullet">
    ///         <item>
    ///             <description> vkCreateDebugUtilsMessengerEXT </description>
    ///         </item>
    ///         <item>
    ///             <description> vkDestroyDebugUtilsMessengerEXT </description>
    ///         </item>
    ///         <item>
    ///             <description> vkSubmitDebugUtilsMessageEXT </description>
    ///         </item>
    ///     </list>
    /// </remarks>
    public static void Load(VkInstance instance)
    {
        fixed (delegate*<VkInstance, VkDebugUtilsMessengerCreateInfoEXT*, VkAllocationCallbacks*, VkDebugUtilsMessengerEXT*, VkResult>* pvkCreateDebugUtilsMessengerEXT =
            &vkCreateDebugUtilsMessengerEXT)
        {
            *pvkCreateDebugUtilsMessengerEXT = (delegate*<VkInstance, VkDebugUtilsMessengerCreateInfoEXT*, VkAllocationCallbacks*, VkDebugUtilsMessengerEXT*, VkResult>)GetVkFunction(
                instance, "\u6b76\u7243\u6165\u6574\u6544\u7562\u5567\u6974\u736c\u654d\u7373\u6e65\u6567\u4572\u5458\u0000");
        }

        fixed (delegate*<VkInstance, VkDebugUtilsMessengerEXT, VkAllocationCallbacks*, void>* pvkDestroyDebugUtilsMessengerEXT = &vkDestroyDebugUtilsMessengerEXT)
        {
            *pvkDestroyDebugUtilsMessengerEXT = (delegate*<VkInstance, VkDebugUtilsMessengerEXT, VkAllocationCallbacks*, void>)GetVkFunction(
                instance, "\u6b76\u6544\u7473\u6f72\u4479\u6265\u6775\u7455\u6c69\u4d73\u7365\u6573\u676e\u7265\u5845\u0054");
        }

        fixed (delegate*<VkInstance, VkDebugUtilsMessageSeverityFlagBitsEXT, VkDebugUtilsMessageTypeFlagsEXT, VkDebugUtilsMessengerCallbackDataEXT*, void>* pvkSubmitDebugUtilsMessageEXT =
            &vkSubmitDebugUtilsMessageEXT)
        {
            *pvkSubmitDebugUtilsMessageEXT = (delegate*<VkInstance, VkDebugUtilsMessageSeverityFlagBitsEXT, VkDebugUtilsMessageTypeFlagsEXT, VkDebugUtilsMessengerCallbackDataEXT*, void>)GetVkFunction(
                instance, "\u6b76\u7553\u6d62\u7469\u6544\u7562\u5567\u6974\u736c\u654d\u7373\u6761\u4565\u5458\u0000");
        }
    }
}