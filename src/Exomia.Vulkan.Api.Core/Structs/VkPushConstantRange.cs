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
///     VkPushConstantRange - Structure specifying a push constant range -
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkPushConstantRange.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkPushConstantRange.html</a>
/// </summary>
[StructLayout(LayoutKind.Sequential)]
public struct VkPushConstantRange
{
    /// <summary>
    ///     stageFlags is a set of stage flags describing the shader stages that will access a range of push constants. If
    ///     a particular stage is not included in the range, then accessing members of that range of push constants from the
    ///     corresponding shader stage will return undefined values.
    /// </summary>
    public VkShaderStageFlags stageFlags;

    /// <summary>
    ///     offset and size are the start offset and size, respectively, consumed by the range. Both offset and size are
    ///     in units of bytes and must be a multiple of 4. The layout of the push constant variables is specified in the
    ///     shader.
    /// </summary>
    public uint offset;

    /// <summary>
    ///     offset and size are the start offset and size, respectively, consumed by the range. Both offset and size are
    ///     in units of bytes and must be a multiple of 4. The layout of the push constant variables is specified in the
    ///     shader.
    /// </summary>
    public uint size;
}