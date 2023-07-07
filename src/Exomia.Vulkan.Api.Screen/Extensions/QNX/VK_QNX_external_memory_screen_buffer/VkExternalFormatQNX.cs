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
namespace Exomia.Vulkan.Api.Screen;

/// <summary>
///     VkExternalFormatQNX - Structure containing a QNX Screen buffer external format -
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkExternalFormatQNX.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkExternalFormatQNX.html</a>
/// </summary>
/// <remarks>
///     <list type="table">
///         <item>
///             <term>structextends</term><description>VkImageCreateInfo,VkSamplerYcbcrConversionCreateInfo</description>
///         </item>
///     </list>
/// </remarks>
[VkStructExtends("VkImageCreateInfo,VkSamplerYcbcrConversionCreateInfo")]
[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkExternalFormatQNX
{
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_EXTERNAL_FORMAT_QNX;

    /// <summary>sType is a VkStructureType value identifying this structure.</summary>
    public VkStructureType sType;

    /// <summary>pNext is NULL or a pointer to a structure extending this structure.</summary>
    public void* pNext;

    /// <summary>externalFormat is an implementation-defined identifier for the external format</summary>
    public ulong externalFormat;
}