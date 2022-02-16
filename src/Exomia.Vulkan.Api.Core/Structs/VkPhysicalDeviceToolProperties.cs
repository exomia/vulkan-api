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
///     VkPhysicalDeviceToolProperties - Structure providing information about an active tool -
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkPhysicalDeviceToolProperties.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkPhysicalDeviceToolProperties.html</a>
/// </summary>
/// <remarks>
///     <list type="table">
///         <item>
///             <term>returnedonly</term><description>true</description>
///         </item>
///     </list>
/// </remarks>
[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPhysicalDeviceToolProperties
{
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_TOOL_PROPERTIES;

    /// <summary>sType is the type of this structure.</summary>
    public VkStructureType sType;

    /// <summary>pNext is NULL or a pointer to a structure extending this structure.</summary>
    public void* pNext;

    /// <summary>name is a null-terminated UTF-8 string containing the name of the tool.</summary>
    public fixed byte name[(int)VK_MAX_EXTENSION_NAME_SIZE];

    /// <summary>version is a null-terminated UTF-8 string containing the version of the tool.</summary>
    public fixed byte version[(int)VK_MAX_EXTENSION_NAME_SIZE];

    /// <summary>purposes is a bitmask of VkToolPurposeFlagBits which is populated with purposes supported by the tool.</summary>
    public VkToolPurposeFlags purposes;

    /// <summary>description is a null-terminated UTF-8 string containing a description of the tool.</summary>
    public fixed byte description[(int)VK_MAX_DESCRIPTION_SIZE];

    /// <summary>
    ///     layer is a null-terminated UTF-8 string containing the name of the layer implementing the tool, if the tool is
    ///     implemented in a layer - otherwise it may be an empty string.
    /// </summary>
    public fixed byte layer[(int)VK_MAX_EXTENSION_NAME_SIZE];
}