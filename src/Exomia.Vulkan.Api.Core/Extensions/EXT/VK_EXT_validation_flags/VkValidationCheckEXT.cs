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
///     VkValidationCheckEXT - Specify validation checks to disable -
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkValidationCheckEXT.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkValidationCheckEXT.html</a>
/// </summary>
public enum VkValidationCheckEXT
{
    /// <summary>VK_VALIDATION_CHECK_ALL_EXT specifies that all validation checks are disabled.</summary>
    VK_VALIDATION_CHECK_ALL_EXT = 0,

    /// <summary>VK_VALIDATION_CHECK_SHADERS_EXT specifies that shader validation is disabled.</summary>
    VK_VALIDATION_CHECK_SHADERS_EXT = 1
}