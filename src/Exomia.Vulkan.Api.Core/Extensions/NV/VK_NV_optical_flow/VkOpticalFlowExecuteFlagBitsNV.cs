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
///     VkOpticalFlowExecuteFlagBitsNV - Bits specifying flags for a optical flow vector calculation -
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkOpticalFlowExecuteFlagBitsNV.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkOpticalFlowExecuteFlagBitsNV.html</a>
/// </summary>
[Flags]
public enum VkOpticalFlowExecuteFlagBitsNV
{
    /// <summary>
    ///     VK_OPTICAL_FLOW_EXECUTE_DISABLE_TEMPORAL_HINTS_BIT_NV specifies that temporal hints from previously generated
    ///     flow vectors are not used. If temporal hints are enabled, optical flow vectors from previous
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdOpticalFlowExecuteNV.html">vkCmdOpticalFlowExecuteNV</a>
    ///     call are automatically used as hints for the current
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdOpticalFlowExecuteNV.html">vkCmdOpticalFlowExecuteNV</a>
    ///     call, to take advantage of temporal correlation in a video sequence. Temporal hints should be disabled if there is
    ///     a-priori knowledge of no temporal correlation (e.g. a scene change, independent successive frame pairs).
    /// </summary>
    VK_OPTICAL_FLOW_EXECUTE_DISABLE_TEMPORAL_HINTS_BIT_NV = 0x1
}