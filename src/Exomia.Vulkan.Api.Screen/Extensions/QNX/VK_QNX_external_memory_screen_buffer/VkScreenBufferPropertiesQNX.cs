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
///     VkScreenBufferPropertiesQNX - Properties of External Memory QNX Screen Buffers -
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkScreenBufferPropertiesQNX.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkScreenBufferPropertiesQNX.html</a>
/// </summary>
/// <remarks>
///     <list type="table">
///         <item>
///             <term>returnedonly</term><description>true</description>
///         </item>
///     </list>
/// </remarks>
[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkScreenBufferPropertiesQNX
{
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_SCREEN_BUFFER_PROPERTIES_QNX;

    /// <summary>sType is a VkStructureType value identifying this structure.</summary>
    public VkStructureType sType;

    /// <summary>pNext is NULL or a pointer to a structure extending this structure.</summary>
    public void* pNext;

    /// <summary>allocationSize is the size of the external memory.</summary>
    public VkDeviceSize allocationSize;

    /// <summary>
    ///     memoryTypeBits is a bitmask containing one bit set for every memory type which the specified Screen buffer can
    ///     be imported as.
    /// </summary>
    public uint memoryTypeBits;
}