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
///     VkQueueFamilyProperties - Structure providing information about a queue family -
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkQueueFamilyProperties.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkQueueFamilyProperties.html</a>
/// </summary>
/// <remarks>
///     <list type="table">
///         <item>
///             <term>returnedonly</term><description>true</description>
///         </item>
///     </list>
/// </remarks>
[StructLayout(LayoutKind.Sequential)]
public struct VkQueueFamilyProperties
{
    /// <summary>queueFlags is a bitmask of VkQueueFlagBits indicating capabilities of the queues in this queue family.</summary>
    public VkQueueFlags queueFlags;

    /// <summary>
    ///     queueCount is the unsigned integer count of queues in this queue family. Each queue family must support at
    ///     least one queue.
    /// </summary>
    public uint queueCount;

    /// <summary>
    ///     timestampValidBits is the unsigned integer count of meaningful bits in the timestamps written via
    ///     vkCmdWriteTimestamp2 or vkCmdWriteTimestamp. The valid range for the count is 36 to 64 bits, or a value of 0,
    ///     indicating no support for timestamps. Bits outside the valid range are guaranteed to be zeros.
    /// </summary>
    public uint timestampValidBits;

    /// <summary>
    ///     minImageTransferGranularity is the minimum granularity supported for image transfer operations on the queues
    ///     in this queue family.
    /// </summary>
    public VkExtent3D minImageTransferGranularity;
}