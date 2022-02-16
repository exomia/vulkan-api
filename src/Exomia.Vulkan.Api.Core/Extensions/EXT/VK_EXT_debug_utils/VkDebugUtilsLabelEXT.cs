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
///     VkDebugUtilsLabelEXT - Specify parameters of a label region -
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkDebugUtilsLabelEXT.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkDebugUtilsLabelEXT.html</a>
/// </summary>
[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkDebugUtilsLabelEXT
{
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_DEBUG_UTILS_LABEL_EXT;

    /// <summary>sType is the type of this structure.</summary>
    public VkStructureType sType;

    /// <summary>pNext is NULL or a pointer to a structure extending this structure.</summary>
    public void* pNext;

    /// <summary>pLabelName is a pointer to a null-terminated UTF-8 string containing the name of the label.</summary>
    public byte* pLabelName;

    /// <summary>
    ///     color is an optional RGBA color value that can be associated with the label. A particular implementation may
    ///     choose to ignore this color value. The values contain RGBA values in order, in the range 0.0 to 1.0. If all
    ///     elements in color are set to 0.0 then it is ignored.
    /// </summary>
    public VkColor color;
}