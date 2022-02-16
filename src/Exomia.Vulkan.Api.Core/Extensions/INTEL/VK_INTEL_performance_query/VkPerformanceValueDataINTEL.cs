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
    /// <summary>
    ///     value32<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkPerformanceValueDataINTEL">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkPerformanceValueDataINTEL</a>
    /// </summary>
    [FieldOffset(0)]
    public uint value32;

    /// <summary>
    ///     value64<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkPerformanceValueDataINTEL">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkPerformanceValueDataINTEL</a>
    /// </summary>
    [FieldOffset(0)]
    public ulong value64;

    /// <summary>
    ///     valueFloat<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkPerformanceValueDataINTEL">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkPerformanceValueDataINTEL</a>
    /// </summary>
    [FieldOffset(0)]
    public float valueFloat;

    /// <summary>
    ///     valueBool<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkPerformanceValueDataINTEL">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkPerformanceValueDataINTEL</a>
    /// </summary>
    [FieldOffset(0)]
    public VkBool32 valueBool;

    /// <summary>
    ///     valueString<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkPerformanceValueDataINTEL">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkPerformanceValueDataINTEL</a>
    /// </summary>
    [FieldOffset(0)]
    public byte* valueString;
}