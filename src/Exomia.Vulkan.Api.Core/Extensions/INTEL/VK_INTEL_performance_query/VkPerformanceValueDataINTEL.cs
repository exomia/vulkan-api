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
///     VkPerformanceValueDataINTEL - Values returned for the parameters -
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkPerformanceValueDataINTEL.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkPerformanceValueDataINTEL.html</a>
/// </summary>
[StructLayout(LayoutKind.Explicit)]
public unsafe struct VkPerformanceValueDataINTEL
{
    /// <summary>data.value32 represents 32-bit integer data.</summary>
    [FieldOffset(0)]
    public uint value32;

    /// <summary>data.value64 represents 64-bit integer data.</summary>
    [FieldOffset(0)]
    public ulong value64;

    /// <summary>data.valueFloat represents floating-point data.</summary>
    [FieldOffset(0)]
    public float valueFloat;

    /// <summary>data.valueBool represents VkBool32 data.</summary>
    [FieldOffset(0)]
    public VkBool32 valueBool;

    /// <summary>data.valueString represents a pointer to a null-terminated UTF-8 string.</summary>
    [FieldOffset(0)]
    public byte* valueString;
}