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
///     VkValidationFeatureEnableEXT - Specify validation features to enable -
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkValidationFeatureEnableEXT.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkValidationFeatureEnableEXT.html</a>
/// </summary>
public enum VkValidationFeatureEnableEXT
{
    /// <summary>
    ///     VK_VALIDATION_FEATURE_ENABLE_GPU_ASSISTED_EXT specifies that GPU-assisted validation is enabled. Activating
    ///     this feature instruments shader programs to generate additional diagnostic data. This feature is disabled by
    ///     default.
    /// </summary>
    VK_VALIDATION_FEATURE_ENABLE_GPU_ASSISTED_EXT = 0,

    /// <summary>
    ///     VK_VALIDATION_FEATURE_ENABLE_GPU_ASSISTED_RESERVE_BINDING_SLOT_EXTspecifies that the validation layers reserve
    ///     a descriptor set binding slot for their own use. The layer reports a value for
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkPhysicalDeviceLimits.html">VkPhysicalDeviceLimits</a>
    ///     ::maxBoundDescriptorSets that is one less than the value reported by the device. If the device supports the binding
    ///     of only one descriptor set, the validation layer does not perform GPU-assisted validation. This feature is disabled
    ///     by default.
    /// </summary>
    VK_VALIDATION_FEATURE_ENABLE_GPU_ASSISTED_RESERVE_BINDING_SLOT_EXT = 1,

    /// <summary>
    ///     VK_VALIDATION_FEATURE_ENABLE_BEST_PRACTICES_EXT specifies that Vulkan best-practices validation is enabled.
    ///     Activating this feature enables the output of warnings related to common misuse of the API, but which are not
    ///     explicitly prohibited by the specification. This feature is disabled by default.
    /// </summary>
    VK_VALIDATION_FEATURE_ENABLE_BEST_PRACTICES_EXT = 2,

    /// <summary>
    ///     VK_VALIDATION_FEATURE_ENABLE_DEBUG_PRINTF_EXT specifies that the layers will process debugPrintfEXT operations
    ///     in shaders and send the resulting output to the debug callback. This feature is disabled by default.
    /// </summary>
    VK_VALIDATION_FEATURE_ENABLE_DEBUG_PRINTF_EXT = 3,

    /// <summary>
    ///     VK_VALIDATION_FEATURE_ENABLE_SYNCHRONIZATION_VALIDATION_EXTspecifies that Vulkan synchronization validation is
    ///     enabled. This feature reports resource access conflicts due to missing or incorrect synchronization operations
    ///     between actions (Draw, Copy, Dispatch, Blit) reading or writing the same regions of memory. This feature is
    ///     disabled by default.
    /// </summary>
    VK_VALIDATION_FEATURE_ENABLE_SYNCHRONIZATION_VALIDATION_EXT = 4
}