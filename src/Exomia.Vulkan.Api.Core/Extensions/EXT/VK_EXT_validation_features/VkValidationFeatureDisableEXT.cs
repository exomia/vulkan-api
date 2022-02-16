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
///     VkValidationFeatureDisableEXT - Specify validation features to disable -
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkValidationFeatureDisableEXT.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkValidationFeatureDisableEXT.html</a>
/// </summary>
public enum VkValidationFeatureDisableEXT
{
    /// <summary>VK_VALIDATION_FEATURE_DISABLE_ALL_EXT specifies that all validation checks are disabled.</summary>
    VK_VALIDATION_FEATURE_DISABLE_ALL_EXT = 0,

    /// <summary>
    ///     VK_VALIDATION_FEATURE_DISABLE_SHADERS_EXT specifies that shader validation is disabled. This feature is
    ///     enabled by default.
    /// </summary>
    VK_VALIDATION_FEATURE_DISABLE_SHADERS_EXT = 1,

    /// <summary>
    ///     VK_VALIDATION_FEATURE_DISABLE_THREAD_SAFETY_EXT specifies that thread safety validation is disabled. This
    ///     feature is enabled by default.
    /// </summary>
    VK_VALIDATION_FEATURE_DISABLE_THREAD_SAFETY_EXT = 2,

    /// <summary>
    ///     VK_VALIDATION_FEATURE_DISABLE_API_PARAMETERS_EXT specifies that stateless parameter validation is disabled.
    ///     This feature is enabled by default.
    /// </summary>
    VK_VALIDATION_FEATURE_DISABLE_API_PARAMETERS_EXT = 3,

    /// <summary>
    ///     VK_VALIDATION_FEATURE_DISABLE_OBJECT_LIFETIMES_EXT specifies that object lifetime validation is disabled. This
    ///     feature is enabled by default.
    /// </summary>
    VK_VALIDATION_FEATURE_DISABLE_OBJECT_LIFETIMES_EXT = 4,

    /// <summary>
    ///     VK_VALIDATION_FEATURE_DISABLE_CORE_CHECKS_EXT specifies that core validation checks are disabled. This feature
    ///     is enabled by default. If this feature is disabled, the shader validation and GPU-assisted validation features are
    ///     also disabled.
    /// </summary>
    VK_VALIDATION_FEATURE_DISABLE_CORE_CHECKS_EXT = 5,

    /// <summary>
    ///     VK_VALIDATION_FEATURE_DISABLE_UNIQUE_HANDLES_EXT specifies that protection against duplicate non-dispatchable
    ///     object handles is disabled. This feature is enabled by default.
    /// </summary>
    VK_VALIDATION_FEATURE_DISABLE_UNIQUE_HANDLES_EXT = 6,

    /// <summary>
    ///     VK_VALIDATION_FEATURE_DISABLE_SHADER_VALIDATION_CACHE_EXTspecifies that there will be no caching of shader
    ///     validation results and every shader will be validated on every application execution. Shader validation caching is
    ///     enabled by default.
    /// </summary>
    VK_VALIDATION_FEATURE_DISABLE_SHADER_VALIDATION_CACHE_EXT = 7
}