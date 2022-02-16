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
///     VkPerformanceValueINTEL - Container for value and types of parameters that can be queried -
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkPerformanceValueINTEL.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkPerformanceValueINTEL.html</a>
/// </summary>
[StructLayout(LayoutKind.Sequential)]
public struct VkPerformanceValueINTEL
{
    /// <summary>type is a VkPerformanceValueTypeINTEL value specifying the type of the returned data.</summary>
    public VkPerformanceValueTypeINTEL type;

    /// <summary>data is a VkPerformanceValueDataINTEL union specifying the value of the returned data.</summary>
    public VkPerformanceValueDataINTEL data;
}