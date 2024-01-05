#region License

// Copyright (c) 2018-2024, exomia
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
///     VkVideoEncodeH264QpKHR - Structure describing H.264 QP values per picture type -
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkVideoEncodeH264QpKHR.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkVideoEncodeH264QpKHR.html</a>
/// </summary>
[StructLayout(LayoutKind.Sequential)]
public struct VkVideoEncodeH264QpKHR
{
    /// <summary>qpI is the QP to be used for I pictures.</summary>
    public int qpI;

    /// <summary>qpP is the QP to be used for P pictures.</summary>
    public int qpP;

    /// <summary>qpB is the QP to be used for B pictures.</summary>
    public int qpB;
}