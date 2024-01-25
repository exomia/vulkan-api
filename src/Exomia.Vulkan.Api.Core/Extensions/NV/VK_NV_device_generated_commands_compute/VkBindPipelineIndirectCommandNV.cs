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
///     VkBindPipelineIndirectCommandNV - Structure specifying input data for the compute pipeline dispatch token -
///     <a
///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkBindPipelineIndirectCommandNV.html">
///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkBindPipelineIndirectCommandNV.html
///     </a>
/// </summary>
[StructLayout(LayoutKind.Sequential)]
public struct VkBindPipelineIndirectCommandNV
{
    /// <summary>
    ///     pipelineAddress specifies the pipeline address of the compute pipeline that will be used in device generated
    ///     rendering.
    /// </summary>
    public VkDeviceAddress pipelineAddress;
}