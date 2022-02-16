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
///     VkDebugMarkerObjectNameInfoEXT - Specify parameters of a name to give to an object -
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkDebugMarkerObjectNameInfoEXT.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkDebugMarkerObjectNameInfoEXT.html</a>
/// </summary>
[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkDebugMarkerObjectNameInfoEXT
{
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_DEBUG_MARKER_OBJECT_NAME_INFO_EXT;

    /// <summary>sType is the type of this structure.</summary>
    public VkStructureType sType;

    /// <summary>pNext is NULL or a pointer to a structure extending this structure.</summary>
    public void* pNext;

    /// <summary>objectType is a VkDebugReportObjectTypeEXT specifying the type of the object to be named.</summary>
    public VkDebugReportObjectTypeEXT objectType;

    /// <summary>object is the object to be named.</summary>
    public ulong @object;

    /// <summary>pObjectName is a null-terminated UTF-8 string specifying the name to apply to object.</summary>
    public byte* pObjectName;
}