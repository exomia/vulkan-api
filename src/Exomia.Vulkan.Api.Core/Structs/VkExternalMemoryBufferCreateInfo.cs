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
///     VkExternalMemoryBufferCreateInfo - Specify that a buffer may be backed by external memory -
///     <a
///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkExternalMemoryBufferCreateInfo.html">
///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkExternalMemoryBufferCreateInfo.html
///     </a>
/// </summary>
/// <remarks>
///     <list type="table">
///         <item>
///             <term>structextends</term><description>VkBufferCreateInfo</description>
///         </item>
///     </list>
/// </remarks>
[VkStructExtends("VkBufferCreateInfo")]
[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkExternalMemoryBufferCreateInfo
{
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_EXTERNAL_MEMORY_BUFFER_CREATE_INFO;

    /// <summary>sType is the type of this structure.</summary>
    public VkStructureType sType;

    /// <summary>pNext is NULL or a pointer to a structure extending this structure.</summary>
    public void* pNext;

    /// <summary>
    ///     handleTypes is zero, or a bitmask of VkExternalMemoryHandleTypeFlagBits specifying one or more external memory
    ///     handle types.
    /// </summary>
    public VkExternalMemoryHandleTypeFlags handleTypes;
}