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
///     VkPastPresentationTimingGOOGLE - Structure containing timing information about a previously-presented image -
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkPastPresentationTimingGOOGLE.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkPastPresentationTimingGOOGLE.html</a>
/// </summary>
/// <remarks>
///     <list type="table">
///         <item>
///             <term>returnedonly</term><description>true</description>
///         </item>
///     </list>
/// </remarks>
[StructLayout(LayoutKind.Sequential)]
public struct VkPastPresentationTimingGOOGLE
{
    /// <summary>
    ///     presentID is an application-provided value that was given to a previous vkQueuePresentKHR command via
    ///     VkPresentTimeGOOGLE::presentID (see below). It can be used to uniquely identify a previous present with the
    ///     vkQueuePresentKHR command.
    /// </summary>
    public uint presentID;

    /// <summary>
    ///     desiredPresentTime is an application-provided value that was given to a previous vkQueuePresentKHR command via
    ///     VkPresentTimeGOOGLE::desiredPresentTime. If non-zero, it was used by the application to indicate that an image not
    ///     be presented any sooner than desiredPresentTime.
    /// </summary>
    public ulong desiredPresentTime;

    /// <summary>actualPresentTime is the time when the image of the swapchain was actually displayed.</summary>
    public ulong actualPresentTime;

    /// <summary>
    ///     earliestPresentTime is the time when the image of the swapchain could have been displayed. This may differ
    ///     from actualPresentTime if the application requested that the image be presented no sooner than
    ///     VkPresentTimeGOOGLE::desiredPresentTime.
    /// </summary>
    public ulong earliestPresentTime;

    /// <summary>
    ///     presentMargin is an indication of how early the vkQueuePresentKHR command was processed compared to how soon
    ///     it needed to be processed, and still be presented at earliestPresentTime.
    /// </summary>
    public ulong presentMargin;
}