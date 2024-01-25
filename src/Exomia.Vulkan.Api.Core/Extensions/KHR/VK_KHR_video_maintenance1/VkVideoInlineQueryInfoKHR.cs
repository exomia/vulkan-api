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
///     VkVideoInlineQueryInfoKHR - Structure specifying inline query information for video coding commands -
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkVideoInlineQueryInfoKHR.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkVideoInlineQueryInfoKHR.html</a>
/// </summary>
/// <remarks>
///     <list type="table">
///         <item>
///             <term>structextends</term><description>VkVideoDecodeInfoKHR,VkVideoEncodeInfoKHR</description>
///         </item>
///     </list>
/// </remarks>
[VkStructExtends("VkVideoDecodeInfoKHR,VkVideoEncodeInfoKHR")]
[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkVideoInlineQueryInfoKHR
{
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_VIDEO_INLINE_QUERY_INFO_KHR;

    /// <summary>sType is a VkStructureType value identifying this structure.</summary>
    public VkStructureType sType;

    /// <summary>pNext is NULL or a pointer to a structure extending this structure.</summary>
    public void* pNext;

    /// <summary>
    ///     queryPool is VK_NULL_HANDLE or a valid handle to a VkQueryPool object that will manage the results of the
    ///     queries.
    /// </summary>
    public VkQueryPool queryPool;

    /// <summary>
    ///     firstQuery is the query index within the query pool that will contain the query results for the first video
    ///     coding operation. The query results of subsequent video coding operations will be contained by subsequent query
    ///     indices.
    /// </summary>
    public uint firstQuery;

    /// <summary>
    ///     queryCount is the number of queries to execute.NoteIn practice, if queryPool is not VK_NULL_HANDLE, then
    ///     queryCount will always have to match the number of video coding operations issued by the video coding command this
    ///     structure is specified to, meaning that using inline queries in a video coding command will always execute a query
    ///     for each issued video coding operation.
    /// </summary>
    public uint queryCount;
}