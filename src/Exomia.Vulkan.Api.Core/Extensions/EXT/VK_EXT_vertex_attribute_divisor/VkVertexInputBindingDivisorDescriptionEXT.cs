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
///     VkVertexInputBindingDivisorDescriptionEXT - Structure specifying a divisor used in instanced rendering -
///     <a
///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkVertexInputBindingDivisorDescriptionEXT.html">
///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkVertexInputBindingDivisorDescriptionEXT.html
///     </a>
/// </summary>
[StructLayout(LayoutKind.Sequential)]
public struct VkVertexInputBindingDivisorDescriptionEXT
{
    /// <summary> binding is the binding number for which the divisor is specified. </summary>
    public uint binding;

    /// <summary> divisor is the number of successive instances that will use the same value of the vertex attribute when instanced rendering is enabled. For example, if the divisor is N, the same vertex attribute will be applied to N successive instances before moving on to the next vertex attribute. The maximum value of divisor is implementation-dependent and can be queried using VkPhysicalDeviceVertexAttributeDivisorPropertiesEXT::maxVertexAttribDivisor. A value of 0 can be used for the divisor if the vertexAttributeInstanceRateZeroDivisor feature is enabled. In this case, the same vertex attribute will be applied to all instances. </summary>
    public uint divisor;
}