#region License

// Copyright (c) 2018-2021, exomia
// All rights reserved.
// 
// This source code is licensed under the BSD-style license found in the
// LICENSE file in the root directory of this source tree.

#endregion

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

using System;
using Exomia.Vulkan.Api.Core;
using Exomia.Vulkan.Api.Windows.Native;

// ReSharper disable UnusedMember.Global
// ReSharper disable InconsistentNaming
// ReSharper disable once CheckNamespace
namespace Exomia.Vulkan.Api.Windows
{
    public unsafe struct VkExportMemoryWin32HandleInfoKHR
    {
        public const VkStructureType      STYPE = VkStructureType.EXPORT_MEMORY_WIN32_HANDLE_INFO_KHR;
        public       VkStructureType      sType;
        public       void*                pNext;
        public       SECURITY_ATTRIBUTES* pAttributes;
        public       uint                 dwAccess;
        public       char*                pName;
    }
}