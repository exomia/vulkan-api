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
///     VkLatencyMarkerNV - Structure used to mark different points in latency -
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkLatencyMarkerNV.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkLatencyMarkerNV.html</a>
/// </summary>
public enum VkLatencyMarkerNV
{
    /// <summary>
    ///     VK_LATENCY_MARKER_SIMULATION_START_NV should be called at the start of the simulation execution each frame,
    ///     but after the call to vkLatencySleepNV.
    /// </summary>
    VK_LATENCY_MARKER_SIMULATION_START_NV = 0,

    /// <summary>VK_LATENCY_MARKER_SIMULATION_END_NV should be called at the end of the simulation execution each frame.</summary>
    VK_LATENCY_MARKER_SIMULATION_END_NV = 1,

    /// <summary>
    ///     VK_LATENCY_MARKER_RENDERSUBMIT_START_NV should be called at the beginning of the render submission execution
    ///     each frame. This should be wherever Vulkan API calls are made and must not span into asynchronous rendering.
    /// </summary>
    VK_LATENCY_MARKER_RENDERSUBMIT_START_NV = 2,

    /// <summary>
    ///     VK_LATENCY_MARKER_RENDERSUBMIT_END_NV should be called at the end of the render submission execution each
    ///     frame.
    /// </summary>
    VK_LATENCY_MARKER_RENDERSUBMIT_END_NV = 3,

    /// <summary>VK_LATENCY_MARKER_PRESENT_START_NV should be called just before vkQueuePresentKHR.</summary>
    VK_LATENCY_MARKER_PRESENT_START_NV = 4,

    /// <summary>VK_LATENCY_MARKER_PRESENT_END_NV should be called when vkQueuePresentKHR returns.</summary>
    VK_LATENCY_MARKER_PRESENT_END_NV = 5,

    /// <summary>VK_LATENCY_MARKER_INPUT_SAMPLE_NV should be called just before the application gathers input data.</summary>
    VK_LATENCY_MARKER_INPUT_SAMPLE_NV = 6,

    /// <summary>
    ///     VK_LATENCY_MARKER_TRIGGER_FLASH_NV should be called anywhere between VK_LATENCY_MARKER_SIMULATION_START_NV and
    ///     VK_LATENCY_MARKER_SIMULATION_END_NV whenever a left mouse click occurs.
    /// </summary>
    VK_LATENCY_MARKER_TRIGGER_FLASH_NV = 7,

    /// <summary>
    ///     VK_LATENCY_MARKER_OUT_OF_BAND_RENDERSUBMIT_START_NV<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkLatencyMarkerNV">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkLatencyMarkerNV</a>
    /// </summary>
    VK_LATENCY_MARKER_OUT_OF_BAND_RENDERSUBMIT_START_NV = 8,

    /// <summary>
    ///     VK_LATENCY_MARKER_OUT_OF_BAND_RENDERSUBMIT_END_NV<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkLatencyMarkerNV">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkLatencyMarkerNV</a>
    /// </summary>
    VK_LATENCY_MARKER_OUT_OF_BAND_RENDERSUBMIT_END_NV = 9,

    /// <summary>
    ///     VK_LATENCY_MARKER_OUT_OF_BAND_PRESENT_START_NV<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkLatencyMarkerNV">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkLatencyMarkerNV</a>
    /// </summary>
    VK_LATENCY_MARKER_OUT_OF_BAND_PRESENT_START_NV = 10,

    /// <summary>
    ///     VK_LATENCY_MARKER_OUT_OF_BAND_PRESENT_END_NV<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkLatencyMarkerNV">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkLatencyMarkerNV</a>
    /// </summary>
    VK_LATENCY_MARKER_OUT_OF_BAND_PRESENT_END_NV = 11
}