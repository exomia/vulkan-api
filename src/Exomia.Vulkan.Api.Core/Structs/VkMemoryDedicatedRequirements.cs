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
///     VkMemoryDedicatedRequirements - Structure describing dedicated allocation requirements of buffer and image resources -
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkMemoryDedicatedRequirements.html"> https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkMemoryDedicatedRequirements.html </a>
/// </summary>
/// <remarks>
///     <list type="table">
///         <item>
///             <term> structextends </term><description> VkMemoryRequirements2 </description>
///         </item>
///         <item>
///             <term> returnedonly </term><description> true </description>
///         </item>
///     </list>
/// </remarks>
[VkStructExtends("VkMemoryRequirements2")]
[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkMemoryDedicatedRequirements
{
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_MEMORY_DEDICATED_REQUIREMENTS;

    /// <summary> sType is the type of this structure. </summary>
    public VkStructureType sType;

    /// <summary> pNext is NULL or a pointer to a structure extending this structure. </summary>
    public void* pNext;

    /// <summary> prefersDedicatedAllocation specifies that the implementation would prefer a dedicated allocation for this resource. The application is still free to suballocate the resource but it mayget better performance if a dedicated allocation is used. </summary>
    public VkBool32 prefersDedicatedAllocation;

    /// <summary> requiresDedicatedAllocation specifies that a dedicated allocation is required for this resource. </summary>
    public VkBool32 requiresDedicatedAllocation;
}