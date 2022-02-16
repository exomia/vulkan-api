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
///     VkRefreshCycleDurationGOOGLE - Structure containing the RC duration of a display -
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkRefreshCycleDurationGOOGLE.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkRefreshCycleDurationGOOGLE.html</a>
/// </summary>
/// <remarks>
///     <list type="table">
///         <item>
///             <term>returnedonly</term><description>true</description>
///         </item>
///     </list>
/// </remarks>
[StructLayout(LayoutKind.Sequential)]
public struct VkRefreshCycleDurationGOOGLE
{
    /// <summary>refreshDuration is the number of nanoseconds from the start of one refresh cycle to the next.</summary>
    public ulong refreshDuration;
}