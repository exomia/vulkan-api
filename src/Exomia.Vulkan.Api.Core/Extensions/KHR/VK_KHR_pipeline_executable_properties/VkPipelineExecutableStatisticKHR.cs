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
namespace Exomia.Vulkan.Api.Core;

/// <summary>
///     VkPipelineExecutableStatisticKHR - Structure describing a compile-time pipeline executable statistic -
///     <a
///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkPipelineExecutableStatisticKHR.html">
///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkPipelineExecutableStatisticKHR.html
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
public unsafe struct VkPipelineExecutableStatisticKHR
{
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_PIPELINE_EXECUTABLE_STATISTIC_KHR;

    /// <summary>sType is the type of this structure.</summary>
    public VkStructureType sType;

    /// <summary>pNext is NULL or a pointer to a structure extending this structure.</summary>
    public void* pNext;

    /// <summary>
    ///     name is an array of VK_MAX_DESCRIPTION_SIZE charcontaining a null-terminated UTF-8 string which is a short
    ///     human readable name for this statistic.
    /// </summary>
    public fixed byte name[(int)VK_MAX_DESCRIPTION_SIZE];

    /// <summary>
    ///     description is an array of VK_MAX_DESCRIPTION_SIZE charcontaining a null-terminated UTF-8 string which is a
    ///     human readable description for this statistic.
    /// </summary>
    public fixed byte description[(int)VK_MAX_DESCRIPTION_SIZE];

    /// <summary>format is a VkPipelineExecutableStatisticFormatKHR value specifying the format of the data found in value.</summary>
    public VkPipelineExecutableStatisticFormatKHR format;

    /// <summary>value is the value of this statistic.</summary>
    public VkPipelineExecutableStatisticValueKHR value;
}