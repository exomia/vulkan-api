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
///     VkDebugReportCallbackCreateInfoEXT - Structure specifying parameters of a newly created debug report callback
///     -
///     <a
///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkDebugReportCallbackCreateInfoEXT.html">
///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkDebugReportCallbackCreateInfoEXT.html
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
public unsafe struct VkDebugReportCallbackCreateInfoEXT
{
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_DEBUG_REPORT_CALLBACK_CREATE_INFO_EXT;

    /// <summary>sType is a VkStructureType value identifying this structure.</summary>
    public VkStructureType sType;

    /// <summary>pNext is NULL or a pointer to a structure extending this structure.</summary>
    public void* pNext;

    /// <summary>
    ///     flags is a bitmask of VkDebugReportFlagBitsEXT specifying which event(s) will cause this callback to be
    ///     called.
    /// </summary>
    public VkDebugReportFlagsEXT flags;

    /// <summary>pfnCallback is the application callback function to call.</summary>
    public delegate*<VkDebugReportFlagsEXT /*flags*/, VkDebugReportObjectTypeEXT /*objectType*/, ulong /*object*/, nuint /*location*/, int /*messageCode*/, byte* /*pLayerPrefix*/, byte* /*pMessage*/
      , void* /*pUserData*/, VkBool32> pfnCallback;

    /// <summary>pUserData is user data to be passed to the callback.</summary>
    public void* pUserData;
}