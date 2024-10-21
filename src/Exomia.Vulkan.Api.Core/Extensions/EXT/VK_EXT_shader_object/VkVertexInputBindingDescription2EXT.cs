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
///     VkVertexInputBindingDescription2EXT - Structure specifying the extended vertex input binding description -
///     <a
///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkVertexInputBindingDescription2EXT.html">
///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkVertexInputBindingDescription2EXT.html
///     </a>
/// </summary>
[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkVertexInputBindingDescription2EXT
{
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_VERTEX_INPUT_BINDING_DESCRIPTION_2_EXT;

    /// <summary>sType is a VkStructureType value identifying this structure.</summary>
    public VkStructureType sType;

    /// <summary>pNext is NULL or a pointer to a structure extending this structure.</summary>
    public void* pNext;

    /// <summary>binding is the binding number that this structure describes.</summary>
    public uint binding;

    /// <summary>stride is the byte stride between consecutive elements within the buffer.</summary>
    public uint stride;

    /// <summary>
    ///     inputRate is a VkVertexInputRate value specifying whether vertex attribute addressing is a function of the
    ///     vertex index or of the instance index.
    /// </summary>
    public VkVertexInputRate inputRate;

    /// <summary>
    ///     divisor is the number of successive instances that will use the same value of the vertex attribute when
    ///     instanced rendering is enabled. This member can be a value other than 1 if the vertexAttributeInstanceRateDivisor
    ///     feature is enabled. For example, if the divisor is N, the same vertex attribute will be applied to N successive
    ///     instances before moving on to the next vertex attribute. The maximum value of divisor is implementation-dependent
    ///     and can be queried using VkPhysicalDeviceVertexAttributeDivisorPropertiesEXT::maxVertexAttribDivisor. A value of 0
    ///     can be used for the divisor if the vertexAttributeInstanceRateZeroDivisor feature is enabled. In this case, the
    ///     same vertex attribute will be applied to all instances.
    /// </summary>
    public uint divisor;
}