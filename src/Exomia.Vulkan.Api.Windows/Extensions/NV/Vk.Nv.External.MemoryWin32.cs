#region License

// Copyright (c) 2018-2021, exomia
// All rights reserved.
// 
// This source code is licensed under the BSD-style license found in the
// LICENSE file in the root directory of this source tree.

#endregion

#pragma warning disable CA2211 // Non-constant fields should not be visible
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

using System;
using Exomia.Vulkan.Api.Core;
using Exomia.Vulkan.Api.Core.Extensions.NV;
using Exomia.Vulkan.Api.SourceGenerator;
using Exomia.Vulkan.Api.Windows.Native;

// ReSharper disable UnusedMember.Global
// ReSharper disable InconsistentNaming
namespace Exomia.Vulkan.Api.Windows.Extensions.NV;

[Obsolete(
    "Deprecated by VK_KHR_external_memory_win32 extension", false,
    UrlFormat = "https://www.khronos.org/registry/vulkan/specs/1.2-extensions/man/html/VK_NV_external_memory_win32.html#_deprecation_state")]
[VkExtGenerator]
public static unsafe partial class VkNvExternalMemoryWin32
{
    public const int    VK_NV_EXTERNAL_MEMORY_WIN32                = 1;
    public const int    VK_NV_EXTERNAL_MEMORY_WIN32_SPEC_VERSION   = 1;
    public const string VK_NV_EXTERNAL_MEMORY_WIN32_EXTENSION_NAME = "VK_NV_external_memory_win32";

    public static readonly delegate*<
        VkDevice,                          /* commandBuffer */
        VkDeviceMemory,                    /* lineStippleFactor */
        VkExternalMemoryHandleTypeFlagsNV, /* lineStipplePattern */
        IntPtr,                            /* pHandle */
        VkResult> vkGetMemoryWin32HandleNV = null;

    public static partial void Load(VkDevice vkDevice);
}

public unsafe struct VkExportMemoryWin32HandleInfoNV
{
    public const VkStructureType      STYPE = VkStructureType.EXPORT_MEMORY_WIN32_HANDLE_INFO_NV;
    public       VkStructureType      sType;
    public       void*                pNext;
    public       SECURITY_ATTRIBUTES* pAttributes;
    public       uint                 dwAccess;
}

public unsafe struct VkImportMemoryWin32HandleInfoNV
{
    public const VkStructureType                   STYPE = VkStructureType.IMPORT_MEMORY_WIN32_HANDLE_INFO_NV;
    public       VkStructureType                   sType;
    public       void*                             pNext;
    public       VkExternalMemoryHandleTypeFlagsNV handleType;
    public       IntPtr                            handle;
}