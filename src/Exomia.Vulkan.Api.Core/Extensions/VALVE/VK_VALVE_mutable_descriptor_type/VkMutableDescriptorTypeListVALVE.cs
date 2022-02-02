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
///     VkMutableDescriptorTypeListVALVE - Structure describing descriptor types that a given descriptor may mutate
///     to -
///     <a
///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkMutableDescriptorTypeListVALVE.html">
///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkMutableDescriptorTypeListVALVE.html
///     </a>
/// </summary>
[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkMutableDescriptorTypeListVALVE
{
    /// <summary>descriptorTypeCount is the number of elements in pDescriptorTypes.</summary>
    public uint descriptorTypeCount;

    /// <summary>
    ///     pDescriptorTypes is NULL or a pointer to an array of descriptorTypeCount VkDescriptorType values defining
    ///     which descriptor types a given binding may mutate to.
    /// </summary>
    public VkDescriptorType* pDescriptorTypes;
}