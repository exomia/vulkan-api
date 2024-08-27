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
///     VkLatencyTimingsFrameReportNV - Structure containing latency data -
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkLatencyTimingsFrameReportNV.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkLatencyTimingsFrameReportNV.html</a>
/// </summary>
/// <remarks>
///     <list type="table">
///         <item>
///             <term>returnedonly</term><description>true</description>
///         </item>
///     </list>
/// </remarks>
[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkLatencyTimingsFrameReportNV
{
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_LATENCY_TIMINGS_FRAME_REPORT_NV;

    /// <summary>
    ///     sType<br />
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkLatencyTimingsFrameReportNV">
    ///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkLatencyTimingsFrameReportNV
    ///     </a>
    /// </summary>
    public VkStructureType sType;

    /// <summary>pNext is NULL or a pointer to a structure extending this structure.</summary>
    public void* pNext;

    /// <summary>
    ///     presentID is the application provided value that is used to associate the timestamp with a vkQueuePresentKHR
    ///     command using VkPresentIdKHR::pPresentIds for a given present.
    /// </summary>
    public ulong presentID;

    /// <summary>
    ///     inputSampleTimeUs<br />
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkLatencyTimingsFrameReportNV">
    ///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkLatencyTimingsFrameReportNV
    ///     </a>
    /// </summary>
    public ulong inputSampleTimeUs;

    /// <summary>
    ///     simStartTimeUs is the timestamp written when vkSetLatencyMarkerNV is called with the VkLatencyMarkerNVenum
    ///     VK_LATENCY_MARKER_SIMULATION_START_NV.
    /// </summary>
    public ulong simStartTimeUs;

    /// <summary>
    ///     simEndTimeUs is the timestamp written when vkSetLatencyMarkerNV is called with the VkLatencyMarkerNVenum
    ///     VK_LATENCY_MARKER_SIMULATION_END_NV
    /// </summary>
    public ulong simEndTimeUs;

    /// <summary>
    ///     renderSubmitStartTimeUs<br />
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkLatencyTimingsFrameReportNV">
    ///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkLatencyTimingsFrameReportNV
    ///     </a>
    /// </summary>
    public ulong renderSubmitStartTimeUs;

    /// <summary>
    ///     renderSubmitEndTimeUs<br />
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkLatencyTimingsFrameReportNV">
    ///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkLatencyTimingsFrameReportNV
    ///     </a>
    /// </summary>
    public ulong renderSubmitEndTimeUs;

    /// <summary>
    ///     presentStartTimeUs is the timestamp written when vkSetLatencyMarkerNV is called with the VkLatencyMarkerNVenum
    ///     VK_LATENCY_MARKER_PRESENT_START_NV.
    /// </summary>
    public ulong presentStartTimeUs;

    /// <summary>
    ///     presentEndTimeUs is the timestamp written when vkSetLatencyMarkerNV is called with the VkLatencyMarkerNVenum
    ///     VK_LATENCY_MARKER_PRESENT_END_NV.
    /// </summary>
    public ulong presentEndTimeUs;

    /// <summary>driverStartTimeUs is the timestamp written when the first vkQueueSubmit for the frame is called.</summary>
    public ulong driverStartTimeUs;

    /// <summary>driverEndTimeUs is the timestamp written when the final vkQueueSubmit hands off from the Vulkan Driver.</summary>
    public ulong driverEndTimeUs;

    /// <summary>
    ///     osRenderQueueStartTimeUs is the timestamp written when the final vkQueueSubmit hands off from the Vulkan
    ///     Driver.
    /// </summary>
    public ulong osRenderQueueStartTimeUs;

    /// <summary>osRenderQueueEndTimeUs is the timestamp written when the first submission reaches the GPU.</summary>
    public ulong osRenderQueueEndTimeUs;

    /// <summary>gpuRenderStartTimeUs is the timestamp written when the first submission reaches the GPU.</summary>
    public ulong gpuRenderStartTimeUs;

    /// <summary>gpuRenderEndTimeUs is the timestamp written when the final submission finishes on the GPU for the frame.</summary>
    public ulong gpuRenderEndTimeUs;
}