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
using Exomia.Vulkan.Api.SourceGenerator;

// ReSharper disable UnusedMember.Global
// ReSharper disable InconsistentNaming
namespace Exomia.Vulkan.Api.Windows.Extensions.NV;

[Obsolete(
    "Promoted to VK_KHR_win32_keyed_mutex extension", false,
    UrlFormat = "https://www.khronos.org/registry/vulkan/specs/1.2-extensions/man/html/VK_NV_win32_keyed_mutex.html#_deprecation_state")]
[VkExtGenerator]
public static partial class VkNvWin32KeyedMutex
{
    public const int    VK_NV_WIN32_KEYED_MUTEX                = 1;
    public const int    VK_NV_WIN32_KEYED_MUTEX_SPEC_VERSION   = 2;
    public const string VK_NV_WIN32_KEYED_MUTEX_EXTENSION_NAME = "VK_NV_win32_keyed_mutex";
}

public unsafe struct VkWin32KeyedMutexAcquireReleaseInfoNV
{
    public const VkStructureType STYPE = VkStructureType.WIN32_KEYED_MUTEX_ACQUIRE_RELEASE_INFO_NV;
    public       VkStructureType sType;
    public       void*           pNext;
    public       uint            acquireCount;
    public       VkDeviceMemory* pAcquireSyncs;
    public       ulong*          pAcquireKeys;
    public       uint*           pAcquireTimeoutMilliseconds;
    public       uint            releaseCount;
    public       VkDeviceMemory* pReleaseSyncs;
    public       ulong*          pReleaseKeys;
}