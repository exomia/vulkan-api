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
///     VkAmigoProfilingSubmitInfoSEC - Stub description of VkAmigoProfilingSubmitInfoSEC -
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkAmigoProfilingSubmitInfoSEC.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkAmigoProfilingSubmitInfoSEC.html</a>
/// </summary>
/// <remarks>
///     <list type="table">
///         <item>
///             <term>structextends</term><description>VkSubmitInfo</description>
///         </item>
///     </list>
/// </remarks>
[VkStructExtends("VkSubmitInfo")]
[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkAmigoProfilingSubmitInfoSEC
{
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_AMIGO_PROFILING_SUBMIT_INFO_SEC;

    /// <summary>
    ///     sType<br />
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkAmigoProfilingSubmitInfoSEC">
    ///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkAmigoProfilingSubmitInfoSEC
    ///     </a>
    /// </summary>
    public VkStructureType sType;

    /// <summary>
    ///     pNext<br />
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkAmigoProfilingSubmitInfoSEC">
    ///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkAmigoProfilingSubmitInfoSEC
    ///     </a>
    /// </summary>
    public void* pNext;

    /// <summary>
    ///     firstDrawTimestamp<br />
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkAmigoProfilingSubmitInfoSEC">
    ///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkAmigoProfilingSubmitInfoSEC
    ///     </a>
    /// </summary>
    public ulong firstDrawTimestamp;

    /// <summary>
    ///     swapBufferTimestamp<br />
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkAmigoProfilingSubmitInfoSEC">
    ///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkAmigoProfilingSubmitInfoSEC
    ///     </a>
    /// </summary>
    public ulong swapBufferTimestamp;
}