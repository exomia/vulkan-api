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
///     VkConformanceVersion - Structure containing the conformance test suite version the implementation is compliant with -
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkConformanceVersion.html"> https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkConformanceVersion.html </a>
/// </summary>
[StructLayout(LayoutKind.Sequential)]
public struct VkConformanceVersion
{
    /// <summary> major is the major version number of the conformance test suite. </summary>
    public byte major;

    /// <summary> minor is the minor version number of the conformance test suite. </summary>
    public byte minor;

    /// <summary> subminor is the subminor version number of the conformance test suite. </summary>
    public byte subminor;

    /// <summary> patch is the patch version number of the conformance test suite. </summary>
    public byte patch;
}