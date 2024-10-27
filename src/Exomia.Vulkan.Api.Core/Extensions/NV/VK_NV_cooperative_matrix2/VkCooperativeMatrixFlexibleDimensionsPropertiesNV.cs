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
///     VkCooperativeMatrixFlexibleDimensionsPropertiesNV - Structure specifying cooperative matrix properties -
///     <a
///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkCooperativeMatrixFlexibleDimensionsPropertiesNV.html">
///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkCooperativeMatrixFlexibleDimensionsPropertiesNV.html
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
public unsafe struct VkCooperativeMatrixFlexibleDimensionsPropertiesNV
{
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_COOPERATIVE_MATRIX_FLEXIBLE_DIMENSIONS_PROPERTIES_NV;

    /// <summary>sType is a VkStructureType value identifying this structure.</summary>
    public VkStructureType sType;

    /// <summary>pNext is NULL or a pointer to a structure extending this structure.</summary>
    public void* pNext;

    /// <summary>
    ///     MGranularity is the granularity of the number of rows in matrices A, C, and Result. The rows must be an
    ///     integer multiple of this value.
    /// </summary>
    public uint MGranularity;

    /// <summary>
    ///     NGranularity is the granularity of columns in matrices B, C, Result. The columns must be an integer multiple
    ///     of this value.
    /// </summary>
    public uint NGranularity;

    /// <summary>
    ///     KGranularity is the granularity of columns in matrix A and rows in matrix B. The columns/rows must be an
    ///     integer multiple of this value.
    /// </summary>
    public uint KGranularity;

    /// <summary>AType is the component type of matrix A, of type VkComponentTypeKHR.</summary>
    public VkComponentTypeKHR AType;

    /// <summary>BType is the component type of matrix B, of type VkComponentTypeKHR.</summary>
    public VkComponentTypeKHR BType;

    /// <summary>CType is the component type of matrix C, of type VkComponentTypeKHR.</summary>
    public VkComponentTypeKHR CType;

    /// <summary>ResultType is the component type of matrix Result, of type VkComponentTypeKHR.</summary>
    public VkComponentTypeKHR ResultType;

    /// <summary>
    ///     saturatingAccumulation indicates whether the SaturatingAccumulation operand to
    ///     OpCooperativeMatrixMulAddKHRmust be present or not. If it is VK_TRUE, the SaturatingAccumulation operand must be
    ///     present. If it is VK_FALSE, the SaturatingAccumulation operand mustnot be present.
    /// </summary>
    public VkBool32 saturatingAccumulation;

    /// <summary>scope is the scope of all the matrix types, of type VkScopeKHR.</summary>
    public VkScopeKHR scope;

    /// <summary>
    ///     workgroupInvocations is the number of invocations in the local workgroup when this combination of values is
    ///     supported.
    /// </summary>
    public uint workgroupInvocations;
}