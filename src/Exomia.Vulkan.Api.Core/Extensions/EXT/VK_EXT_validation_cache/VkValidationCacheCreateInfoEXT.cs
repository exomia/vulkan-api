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
///     VkValidationCacheCreateInfoEXT - Structure specifying parameters of a newly created validation cache -
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkValidationCacheCreateInfoEXT.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkValidationCacheCreateInfoEXT.html</a>
/// </summary>
[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkValidationCacheCreateInfoEXT
{
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_VALIDATION_CACHE_CREATE_INFO_EXT;

    /// <summary>sType is a VkStructureType value identifying this structure.</summary>
    public VkStructureType sType;

    /// <summary>pNext is NULL or a pointer to a structure extending this structure.</summary>
    public void* pNext;

    /// <summary>flags is reserved for future use.</summary>
    public VkValidationCacheCreateFlagsEXT flags;

    /// <summary>
    ///     initialDataSize is the number of bytes in pInitialData. If initialDataSize is zero, the validation cache will
    ///     initially be empty.
    /// </summary>
    public nuint initialDataSize;

    /// <summary>
    ///     pInitialData is a pointer to previously retrieved validation cache data. If the validation cache data is
    ///     incompatible (as defined below) with the device, the validation cache will be initially empty. If initialDataSize
    ///     is zero, pInitialData is ignored.
    /// </summary>
    public void* pInitialData;
}