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
///     VkShaderFloatControlsIndependence - Bitmask specifying whether, and how, shader float controls can be set separately -
///     <a
///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkShaderFloatControlsIndependence.html">
///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkShaderFloatControlsIndependence.html
///     </a>
/// </summary>
public enum VkShaderFloatControlsIndependence
{
    /// <summary> VK_SHADER_FLOAT_CONTROLS_INDEPENDENCE_32_BIT_ONLY specifies that shader float controls for 32-bit floating point can be set independently; other bit widths must be set identically to each other. </summary>
    VK_SHADER_FLOAT_CONTROLS_INDEPENDENCE_32_BIT_ONLY = 0,

    /// <summary> VK_SHADER_FLOAT_CONTROLS_INDEPENDENCE_ALL specifies that shader float controls for all bit widths can be set independently. </summary>
    VK_SHADER_FLOAT_CONTROLS_INDEPENDENCE_ALL = 1,

    /// <summary> VK_SHADER_FLOAT_CONTROLS_INDEPENDENCE_NONE specifies that shader float controls for all bit widths must be set identically. </summary>
    VK_SHADER_FLOAT_CONTROLS_INDEPENDENCE_NONE = 2,

    /// <summary> VK_SHADER_FLOAT_CONTROLS_INDEPENDENCE_32_BIT_ONLY specifies that shader float controls for 32-bit floating point can be set independently; other bit widths must be set identically to each other. </summary>
    VK_SHADER_FLOAT_CONTROLS_INDEPENDENCE_32_BIT_ONLY_KHR = VK_SHADER_FLOAT_CONTROLS_INDEPENDENCE_32_BIT_ONLY,

    /// <summary> VK_SHADER_FLOAT_CONTROLS_INDEPENDENCE_ALL specifies that shader float controls for all bit widths can be set independently. </summary>
    VK_SHADER_FLOAT_CONTROLS_INDEPENDENCE_ALL_KHR = VK_SHADER_FLOAT_CONTROLS_INDEPENDENCE_ALL,

    /// <summary> VK_SHADER_FLOAT_CONTROLS_INDEPENDENCE_NONE specifies that shader float controls for all bit widths must be set identically. </summary>
    VK_SHADER_FLOAT_CONTROLS_INDEPENDENCE_NONE_KHR = VK_SHADER_FLOAT_CONTROLS_INDEPENDENCE_NONE
}