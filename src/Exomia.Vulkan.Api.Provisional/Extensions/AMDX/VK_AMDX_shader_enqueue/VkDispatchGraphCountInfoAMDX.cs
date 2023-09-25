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
namespace Exomia.Vulkan.Api.Provisional;

/// <summary>
///     VkDispatchGraphCountInfoAMDX - Structure specifying count parameters for execution graph dispatch -
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkDispatchGraphCountInfoAMDX.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkDispatchGraphCountInfoAMDX.html</a>
/// </summary>
[StructLayout(LayoutKind.Sequential)]
public struct VkDispatchGraphCountInfoAMDX
{
    /// <summary>count is the number of dispatches to perform.</summary>
    public uint count;

    /// <summary>infos is the device or host address of a flat array of VkDispatchGraphInfoAMDX structures</summary>
    public VkDeviceOrHostAddressConstAMDX infos;

    /// <summary>stride is the byte stride between successive VkDispatchGraphInfoAMDX structures in infos</summary>
    public ulong stride;
}