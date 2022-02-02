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
///     VkMemoryOpaqueCaptureAddressAllocateInfo - Request a specific address for a memory allocation -
///     <a
///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkMemoryOpaqueCaptureAddressAllocateInfo.html">
///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkMemoryOpaqueCaptureAddressAllocateInfo.html
///     </a>
/// </summary>
/// <remarks>
///     <list type="table">
///         <item>
///             <term>structextends</term><description>VkMemoryAllocateInfo</description>
///         </item>
///     </list>
/// </remarks>
[VkStructExtends("VkMemoryAllocateInfo")]
[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkMemoryOpaqueCaptureAddressAllocateInfo
{
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_MEMORY_OPAQUE_CAPTURE_ADDRESS_ALLOCATE_INFO;

    /// <summary>sType is the type of this structure.</summary>
    public VkStructureType sType;

    /// <summary>pNext is NULL or a pointer to a structure extending this structure.</summary>
    public void* pNext;

    /// <summary>opaqueCaptureAddress is the opaque capture address requested for the memory allocation.</summary>
    public ulong opaqueCaptureAddress;
}