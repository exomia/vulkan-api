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
///     VkDispatchGraphInfoAMDX - Structure specifying node parameters for execution graph dispatch -
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkDispatchGraphInfoAMDX.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkDispatchGraphInfoAMDX.html</a>
/// </summary>
[StructLayout(LayoutKind.Sequential)]
public struct VkDispatchGraphInfoAMDX
{
    /// <summary>nodeIndex is the index of a node in an execution graph to be dispatched.</summary>
    public uint nodeIndex;

    /// <summary>payloadCount is the number of payloads to dispatch for the specified node.</summary>
    public uint payloadCount;

    /// <summary>
    ///     payloads is a device or host address pointer to a flat array of payloads with size equal to the product of
    ///     payloadCount and payloadStride
    /// </summary>
    public VkDeviceOrHostAddressConstAMDX payloads;

    /// <summary>payloadStride is the byte stride between successive payloads in payloads</summary>
    public ulong payloadStride;
}