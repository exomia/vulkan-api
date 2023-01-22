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
namespace Exomia.Vulkan.Api.Core;

/// <summary>
///     VkShaderResourceUsageAMD - Resource usage information about a particular shader within a pipeline -
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkShaderResourceUsageAMD.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkShaderResourceUsageAMD.html</a>
/// </summary>
/// <remarks>
///     <list type="table">
///         <item>
///             <term>returnedonly</term><description>true</description>
///         </item>
///     </list>
/// </remarks>
[StructLayout(LayoutKind.Sequential)]
public struct VkShaderResourceUsageAMD
{
    /// <summary>numUsedVgprs is the number of vector instruction general-purpose registers used by this shader.</summary>
    public uint numUsedVgprs;

    /// <summary>numUsedSgprs is the number of scalar instruction general-purpose registers used by this shader.</summary>
    public uint numUsedSgprs;

    /// <summary>ldsSizePerLocalWorkGroup is the maximum local data store size per work group in bytes.</summary>
    public uint ldsSizePerLocalWorkGroup;

    /// <summary>ldsUsageSizeInBytes is the LDS usage size in bytes per work group by this shader.</summary>
    public nuint ldsUsageSizeInBytes;

    /// <summary>scratchMemUsageInBytes is the scratch memory usage in bytes by this shader.</summary>
    public nuint scratchMemUsageInBytes;
}