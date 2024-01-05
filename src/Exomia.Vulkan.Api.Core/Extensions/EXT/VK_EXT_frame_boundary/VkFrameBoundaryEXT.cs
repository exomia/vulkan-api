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
///     VkFrameBoundaryEXT - Add frame boundary information to queue submissions -
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkFrameBoundaryEXT.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkFrameBoundaryEXT.html</a>
/// </summary>
/// <remarks>
///     <list type="table">
///         <item>
///             <term>structextends</term>
///             <description>VkSubmitInfo,VkSubmitInfo2,VkPresentInfoKHR,VkBindSparseInfo</description>
///         </item>
///     </list>
/// </remarks>
[VkStructExtends("VkSubmitInfo,VkSubmitInfo2,VkPresentInfoKHR,VkBindSparseInfo")]
[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkFrameBoundaryEXT
{
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_FRAME_BOUNDARY_EXT;

    /// <summary>sType is a VkStructureType value identifying this structure.</summary>
    public VkStructureType sType;

    /// <summary>pNext is NULL or a pointer to a structure extending this structure.</summary>
    public void* pNext;

    /// <summary>flags is a bitmask of VkFrameBoundaryFlagBitsEXT that can flag the last submission of a frame identifier.</summary>
    public VkFrameBoundaryFlagsEXT flags;

    /// <summary>frameID is the frame identifier.</summary>
    public ulong frameID;

    /// <summary>imageCount is the number of images that store frame results.</summary>
    public uint imageCount;

    /// <summary>pImages is a pointer to an array of VkImage objects with imageCount entries.</summary>
    public VkImage* pImages;

    /// <summary>bufferCount is the number of buffers the store the frame results.</summary>
    public uint bufferCount;

    /// <summary>pBuffers is a pointer to an array of VkBuffer objects with bufferCount entries.</summary>
    public VkBuffer* pBuffers;

    /// <summary>tagName is a numerical identifier for tag data.</summary>
    public ulong tagName;

    /// <summary>tagSize is the number of bytes of tag data.</summary>
    public nuint tagSize;

    /// <summary>pTag is a pointer to an array of tagSize bytes containing tag data.</summary>
    public void* pTag;
}