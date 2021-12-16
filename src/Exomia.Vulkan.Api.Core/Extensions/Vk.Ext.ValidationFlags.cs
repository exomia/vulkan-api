#region License

// Copyright (c) 2018-2021, exomia
// All rights reserved.
// 
// This source code is licensed under the BSD-style license found in the
// LICENSE file in the root directory of this source tree.

#endregion

#pragma warning disable CA2211 // Non-constant fields should not be visible
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

// ReSharper disable UnusedMember.Global
// ReSharper disable InconsistentNaming
namespace Exomia.Vulkan.Api.Core.Extensions;

[Obsolete(
    "Deprecation by VK_EXT_validation_features", false,
    UrlFormat = "https://www.khronos.org/registry/vulkan/specs/1.2-extensions/man/html/VK_EXT_validation_flags.html#_deprecation_by_vk_ext_validation_features")]
[VkExtGenerator]
public static partial class VkExtValidationFlags
{
    public const int    VK_EXT_VALIDATION_FLAGS                = 1;
    public const int    VK_EXT_VALIDATION_FLAGS_SPEC_VERSION   = 2;
    public const string VK_EXT_VALIDATION_FLAGS_EXTENSION_NAME = "VK_EXT_validation_flags";
}

public enum VkValidationCheckEXT
{
    ALL_EXT      = 0,
    SHADERS_EXT  = 1,
    MAX_ENUM_EXT = 0x7FFFFFFF
}

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkValidationFlagsEXT
{
    public const VkStructureType       STYPE = VkStructureType.VALIDATION_FLAGS_EXT;
    public       VkStructureType       sType;
    public       void*                 pNext;
    public       uint                  disabledValidationCheckCount;
    public       VkValidationCheckEXT* pDisabledValidationChecks;
}