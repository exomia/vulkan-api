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
///     VkPerformanceCounterResultKHR - Union containing a performance counter result -
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkPerformanceCounterResultKHR.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkPerformanceCounterResultKHR.html</a>
/// </summary>
[StructLayout(LayoutKind.Explicit)]
public struct VkPerformanceCounterResultKHR
{
    /// <summary>
    ///     int32<br />
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkPerformanceCounterResultKHR">
    ///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkPerformanceCounterResultKHR
    ///     </a>
    /// </summary>
    [FieldOffset(0)]
    public int int32;

    /// <summary>
    ///     int64<br />
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkPerformanceCounterResultKHR">
    ///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkPerformanceCounterResultKHR
    ///     </a>
    /// </summary>
    [FieldOffset(0)]
    public long int64;

    /// <summary>
    ///     uint32<br />
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkPerformanceCounterResultKHR">
    ///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkPerformanceCounterResultKHR
    ///     </a>
    /// </summary>
    [FieldOffset(0)]
    public uint uint32;

    /// <summary>
    ///     uint64<br />
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkPerformanceCounterResultKHR">
    ///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkPerformanceCounterResultKHR
    ///     </a>
    /// </summary>
    [FieldOffset(0)]
    public ulong uint64;

    /// <summary>
    ///     float32<br />
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkPerformanceCounterResultKHR">
    ///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkPerformanceCounterResultKHR
    ///     </a>
    /// </summary>
    [FieldOffset(0)]
    public float float32;

    /// <summary>
    ///     float64<br />
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkPerformanceCounterResultKHR">
    ///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkPerformanceCounterResultKHR
    ///     </a>
    /// </summary>
    [FieldOffset(0)]
    public double float64;
}