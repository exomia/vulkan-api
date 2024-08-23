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
///     VkPhysicalDevicePipelineBinaryPropertiesKHR - Structure describing properties about the pipeline binary
///     implementation -
///     <a
///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkPhysicalDevicePipelineBinaryPropertiesKHR.html">
///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkPhysicalDevicePipelineBinaryPropertiesKHR.html
///     </a>
/// </summary>
/// <remarks>
///     <list type="table">
///         <item>
///             <term>structextends</term><description>VkPhysicalDeviceProperties2</description>
///         </item>
///     </list>
/// </remarks>
[VkStructExtends("VkPhysicalDeviceProperties2")]
[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPhysicalDevicePipelineBinaryPropertiesKHR
{
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_PIPELINE_BINARY_PROPERTIES_KHR;

    /// <summary>sType is a VkStructureType value identifying this structure.</summary>
    public VkStructureType sType;

    /// <summary>pNext is NULL or a pointer to a structure extending this structure.</summary>
    public void* pNext;

    /// <summary>
    ///     pipelineBinaryInternalCachespecifies that the implementation maintains a pipeline cache internal to the
    ///     implementation. If this is VK_TRUE, applications can create pipeline binaries with only a pipeline create info, and
    ///     in this case, an implementation may be able to create a pipeline binary directly without application needing to
    ///     capture the binary itself.
    /// </summary>
    public VkBool32 pipelineBinaryInternalCache;

    /// <summary>
    ///     pipelineBinaryInternalCacheControl specifies whether the driver&#8217;s internal cache can be disabled. If
    ///     this property is VK_TRUEVkDevicePipelineBinaryInternalCacheControlKHR::disableInternalCachecan be used to disable
    ///     the driver&#8217;s internal cache, allowing an application to take full control of both memory and disk usage.
    /// </summary>
    public VkBool32 pipelineBinaryInternalCacheControl;

    /// <summary>
    ///     pipelineBinaryPrefersInternalCache specifies that the implementation prefers to maintain an internal cache,
    ///     and applications should not store pipeline binaries in their own on-disk caches to avoid increased on-disk storage
    ///     requirements. Applications are encouraged to only store pipeline keys instead, and aim to create pipeline binaries
    ///     from key alone on subsequent runs of the application.
    /// </summary>
    public VkBool32 pipelineBinaryPrefersInternalCache;

    /// <summary>
    ///     pipelineBinaryPrecompiledInternalCache specifies that the implementation may have pipeline binaries in its
    ///     internal cache, which is populated without the application ever having generated that pipeline itself. Applications
    ///     can attempt to create binaries without extracting pipeline binary data from the pipeline prior for a set of
    ///     pipeline keys, including from previous runs of the application.
    /// </summary>
    public VkBool32 pipelineBinaryPrecompiledInternalCache;

    /// <summary>
    ///     pipelineBinaryCompressedData specifies that the binary data is already compressed and so applications should
    ///     not attempt to compress it.
    /// </summary>
    public VkBool32 pipelineBinaryCompressedData;
}