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
///     VkIndirectCommandsIndexBufferTokenEXT - Structure specifying layout token info for a single index buffer command
///     token -
///     <a
///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkIndirectCommandsIndexBufferTokenEXT.html">
///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkIndirectCommandsIndexBufferTokenEXT.html
///     </a>
/// </summary>
[StructLayout(LayoutKind.Sequential)]
public struct VkIndirectCommandsIndexBufferTokenEXT
{
    /// <summary>mode specifies the mode to use with this token.</summary>
    public VkIndirectCommandsInputModeFlagBitsEXT mode;
}