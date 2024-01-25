#region License

// Copyright (c) 2018-2024, exomia
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
///     VkDebugUtilsMessengerCreateInfoEXT - Structure specifying parameters of a newly created debug messenger -
///     <a
///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkDebugUtilsMessengerCreateInfoEXT.html">
///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkDebugUtilsMessengerCreateInfoEXT.html
///     </a>
/// </summary>
/// <remarks>
///     <list type="table">
///         <item>
///             <term>structextends</term><description>VkInstanceCreateInfo</description>
///         </item>
///     </list>
/// </remarks>
[VkStructExtends("VkInstanceCreateInfo")]
[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkDebugUtilsMessengerCreateInfoEXT
{
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_DEBUG_UTILS_MESSENGER_CREATE_INFO_EXT;

    /// <summary>sType is a VkStructureType value identifying this structure.</summary>
    public VkStructureType sType;

    /// <summary>pNext is NULL or a pointer to a structure extending this structure.</summary>
    public void* pNext;

    /// <summary>flags is 0 and is reserved for future use.</summary>
    public VkDebugUtilsMessengerCreateFlagsEXT flags;

    /// <summary>
    ///     messageSeverity is a bitmask of VkDebugUtilsMessageSeverityFlagBitsEXT specifying which severity of event(s)
    ///     will cause this callback to be called.
    /// </summary>
    public VkDebugUtilsMessageSeverityFlagsEXT messageSeverity;

    /// <summary>
    ///     messageType is a bitmask of VkDebugUtilsMessageTypeFlagBitsEXT specifying which type of event(s) will cause
    ///     this callback to be called.
    /// </summary>
    public VkDebugUtilsMessageTypeFlagsEXT messageType;

    /// <summary>pfnUserCallback is the application callback function to call.</summary>
    public delegate*<VkDebugUtilsMessageSeverityFlagBitsEXT /*messageSeverity*/, VkDebugUtilsMessageTypeFlagsEXT /*messageTypes*/, VkDebugUtilsMessengerCallbackDataEXT* /*pCallbackData*/
      , void* /*pUserData*/, VkBool32> pfnUserCallback;

    /// <summary>pUserData is user data to be passed to the callback.</summary>
    public void* pUserData;
}