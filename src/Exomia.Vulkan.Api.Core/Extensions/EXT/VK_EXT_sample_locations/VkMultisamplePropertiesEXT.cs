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
///     VkMultisamplePropertiesEXT - Structure returning information about sample count specific additional
///     multisampling capabilities -
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkMultisamplePropertiesEXT.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkMultisamplePropertiesEXT.html</a>
/// </summary>
/// <remarks>
///     <list type="table">
///         <item>
///             <term>returnedonly</term><description>true</description>
///         </item>
///     </list>
/// </remarks>
[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkMultisamplePropertiesEXT
{
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_MULTISAMPLE_PROPERTIES_EXT;

    /// <summary>sType is the type of this structure.</summary>
    public VkStructureType sType;

    /// <summary>pNext is NULL or a pointer to a structure extending this structure.</summary>
    public void* pNext;

    /// <summary>maxSampleLocationGridSize is the maximum size of the pixel grid in which sample locations can vary.</summary>
    public VkExtent2D maxSampleLocationGridSize;
}