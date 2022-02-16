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
///     VkPipelineCreationFeedback - Feedback about the creation of a pipeline or pipeline stage -
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkPipelineCreationFeedback.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkPipelineCreationFeedback.html</a>
/// </summary>
/// <remarks>
///     <list type="table">
///         <item>
///             <term>returnedonly</term><description>true</description>
///         </item>
///     </list>
/// </remarks>
[StructLayout(LayoutKind.Sequential)]
public struct VkPipelineCreationFeedback
{
    /// <summary>
    ///     flags is a bitmask of VkPipelineCreationFeedbackFlagBitsproviding feedback about the creation of a pipeline or
    ///     of a pipeline stage.
    /// </summary>
    public VkPipelineCreationFeedbackFlags flags;

    /// <summary>duration is the duration spent creating a pipeline or pipeline stage in nanoseconds.</summary>
    public ulong duration;
}