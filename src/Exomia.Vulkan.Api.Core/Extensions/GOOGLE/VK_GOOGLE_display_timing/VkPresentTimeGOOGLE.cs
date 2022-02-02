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
///     VkPresentTimeGOOGLE - The earliest time image should be presented -
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkPresentTimeGOOGLE.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkPresentTimeGOOGLE.html</a>
/// </summary>
[StructLayout(LayoutKind.Sequential)]
public struct VkPresentTimeGOOGLE
{
    /// <summary>
    ///     presentID is an application-provided identification value, that can be used with the results of
    ///     vkGetPastPresentationTimingGOOGLE, in order to uniquely identify this present. In order to be useful to the
    ///     application, it should be unique within some period of time that is meaningful to the application.
    /// </summary>
    public uint presentID;

    /// <summary>
    ///     desiredPresentTime specifies that the image given should not be displayed to the user any earlier than this
    ///     time. desiredPresentTime is a time in nanoseconds, relative to a monotonically-increasing clock (e.g.
    ///     CLOCK_MONOTONIC (see clock_gettime(2)) on Android and Linux). A value of zero specifies that the presentation
    ///     engine may display the image at any time. This is useful when the application desires to provide presentID,
    /// </summary>
    public ulong desiredPresentTime;
}