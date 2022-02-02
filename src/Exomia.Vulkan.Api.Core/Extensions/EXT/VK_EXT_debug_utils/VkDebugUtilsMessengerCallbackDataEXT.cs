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
///     VkDebugUtilsMessengerCallbackDataEXT - Structure specifying parameters returned to the callback -
///     <a
///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkDebugUtilsMessengerCallbackDataEXT.html">
///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkDebugUtilsMessengerCallbackDataEXT.html
///     </a>
/// </summary>
[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkDebugUtilsMessengerCallbackDataEXT
{
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_DEBUG_UTILS_MESSENGER_CALLBACK_DATA_EXT;

    /// <summary>sType is the type of this structure.</summary>
    public VkStructureType sType;

    /// <summary>pNext is NULL or a pointer to a structure extending this structure.</summary>
    public void* pNext;

    /// <summary>flags is 0 and is reserved for future use.</summary>
    public VkDebugUtilsMessengerCallbackDataFlagsEXT flags;

    /// <summary>
    ///     pMessageIdName is a null-terminated string that identifies the particular message ID that is associated with
    ///     the provided message. If the message corresponds to a validation layer message, then this string may contain the
    ///     portion of the Vulkan specification that is believed to have been violated.
    /// </summary>
    public byte* pMessageIdName;

    /// <summary>
    ///     messageIdNumber is the ID number of the triggering message. If the message corresponds to a validation layer
    ///     message, then this number is related to the internal number associated with the message being triggered.
    /// </summary>
    public int messageIdNumber;

    /// <summary>pMessage is a null-terminated string detailing the trigger conditions.</summary>
    public byte* pMessage;

    /// <summary>queueLabelCount is a count of items contained in the pQueueLabels array.</summary>
    public uint queueLabelCount;

    /// <summary>
    ///     pQueueLabels is NULL or a pointer to an array of VkDebugUtilsLabelEXT active in the current VkQueue at the
    ///     time the callback was triggered. Refer to Queue Labels for more information.
    /// </summary>
    public VkDebugUtilsLabelEXT* pQueueLabels;

    /// <summary>cmdBufLabelCount is a count of items contained in the pCmdBufLabels array.</summary>
    public uint cmdBufLabelCount;

    /// <summary>
    ///     pCmdBufLabels is NULL or a pointer to an array of VkDebugUtilsLabelEXT active in the current VkCommandBufferat
    ///     the time the callback was triggered. Refer to Command Buffer Labels for more information.
    /// </summary>
    public VkDebugUtilsLabelEXT* pCmdBufLabels;

    /// <summary>objectCount is a count of items contained in the pObjectsarray.</summary>
    public uint objectCount;

    /// <summary>
    ///     pObjects is a pointer to an array of VkDebugUtilsObjectNameInfoEXT objects related to the detected issue. The
    ///     array is roughly in order or importance, but the 0th element is always guaranteed to be the most important object
    ///     for this message.
    /// </summary>
    public VkDebugUtilsObjectNameInfoEXT* pObjects;
}