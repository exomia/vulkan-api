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
///     VkPipelineExecutableInternalRepresentationKHR - Structure describing the textual form of a pipeline executable
///     internal representation -
///     <a
///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkPipelineExecutableInternalRepresentationKHR.html">
///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkPipelineExecutableInternalRepresentationKHR.html
///     </a>
/// </summary>
/// <remarks>
///     <list type="table">
///         <item>
///             <term>returnedonly</term><description>true</description>
///         </item>
///     </list>
/// </remarks>
[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPipelineExecutableInternalRepresentationKHR
{
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_PIPELINE_EXECUTABLE_INTERNAL_REPRESENTATION_KHR;

    /// <summary>sType is the type of this structure.</summary>
    public VkStructureType sType;

    /// <summary>pNext is NULL or a pointer to a structure extending this structure.</summary>
    public void* pNext;

    /// <summary>
    ///     name is an array of VK_MAX_DESCRIPTION_SIZE charcontaining a null-terminated UTF-8 string which is a short
    ///     human readable name for this internal representation.
    /// </summary>
    public fixed byte name[(int)VK_MAX_DESCRIPTION_SIZE];

    /// <summary>
    ///     description is an array of VK_MAX_DESCRIPTION_SIZE charcontaining a null-terminated UTF-8 string which is a
    ///     human readable description for this internal representation.
    /// </summary>
    public fixed byte description[(int)VK_MAX_DESCRIPTION_SIZE];

    /// <summary>
    ///     isText specifies whether the returned data is text or opaque data. If isText is VK_TRUE then the data returned
    ///     in pDatais text and is guaranteed to be a null-terminated UTF-8 string.
    /// </summary>
    public VkBool32 isText;

    /// <summary>
    ///     dataSize is an integer related to the size, in bytes, of the internal representation&#8217;s data, as
    ///     described below.
    /// </summary>
    public nuint dataSize;

    /// <summary>
    ///     pData is either NULL or a pointer to a block of data into which the implementation will write the internal
    ///     representation.
    /// </summary>
    public void* pData;
}