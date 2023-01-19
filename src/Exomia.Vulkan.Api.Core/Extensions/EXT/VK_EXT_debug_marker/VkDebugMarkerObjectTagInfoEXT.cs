#region License

// Copyright (c) 2018-2023, exomia
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
///     VkDebugMarkerObjectTagInfoEXT - Specify parameters of a tag to attach to an object -
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkDebugMarkerObjectTagInfoEXT.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkDebugMarkerObjectTagInfoEXT.html</a>
/// </summary>
[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkDebugMarkerObjectTagInfoEXT
{
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_DEBUG_MARKER_OBJECT_TAG_INFO_EXT;

    /// <summary>sType is the type of this structure.</summary>
    public VkStructureType sType;

    /// <summary>pNext is NULL or a pointer to a structure extending this structure.</summary>
    public void* pNext;

    /// <summary>objectType is a VkDebugReportObjectTypeEXT specifying the type of the object to be named.</summary>
    public VkDebugReportObjectTypeEXT objectType;

    /// <summary>object is the object to be tagged.</summary>
    public ulong @object;

    /// <summary>tagName is a numerical identifier of the tag.</summary>
    public ulong tagName;

    /// <summary>tagSize is the number of bytes of data to attach to the object.</summary>
    public nuint tagSize;

    /// <summary>pTag is a pointer to an array of tagSize bytes containing the data to be associated with the object.</summary>
    public void* pTag;
}