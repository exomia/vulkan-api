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
///     VkCooperativeMatrixPropertiesNV - Structure specifying cooperative matrix properties -
///     <a
///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkCooperativeMatrixPropertiesNV.html">
///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkCooperativeMatrixPropertiesNV.html
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
public unsafe struct VkCooperativeMatrixPropertiesNV
{
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_COOPERATIVE_MATRIX_PROPERTIES_NV;

    /// <summary>sType is a VkStructureType value identifying this structure.</summary>
    public VkStructureType sType;

    /// <summary>pNext is NULL or a pointer to a structure extending this structure.</summary>
    public void* pNext;

    /// <summary>MSize is the number of rows in matrices A, C, and D.</summary>
    public uint MSize;

    /// <summary>NSize is the number of columns in matrices B, C, D.</summary>
    public uint NSize;

    /// <summary>KSize is the number of columns in matrix A and rows in matrix B.</summary>
    public uint KSize;

    /// <summary>AType is the component type of matrix A, of type VkComponentTypeNV.</summary>
    public VkComponentTypeNV AType;

    /// <summary>BType is the component type of matrix B, of type VkComponentTypeNV.</summary>
    public VkComponentTypeNV BType;

    /// <summary>CType is the component type of matrix C, of type VkComponentTypeNV.</summary>
    public VkComponentTypeNV CType;

    /// <summary>DType is the component type of matrix D, of type VkComponentTypeNV.</summary>
    public VkComponentTypeNV DType;

    /// <summary>scope is the scope of all the matrix types, of type VkScopeNV.</summary>
    public VkScopeNV scope;
}