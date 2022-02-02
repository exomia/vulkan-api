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
///     VkSubpassSampleLocationsEXT - Structure specifying the sample locations state to use for layout transitions
///     of attachments performed after a given subpass -
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkSubpassSampleLocationsEXT.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkSubpassSampleLocationsEXT.html</a>
/// </summary>
[StructLayout(LayoutKind.Sequential)]
public struct VkSubpassSampleLocationsEXT
{
    /// <summary>subpassIndex is the index of the subpass for which the sample locations state is provided.</summary>
    public uint subpassIndex;

    /// <summary>
    ///     sampleLocationsInfo is the sample locations state to use for the layout transition of the depth/stencil
    ///     attachment away from the image layout the attachment is used with in the subpass specified in subpassIndex.
    /// </summary>
    public VkSampleLocationsInfoEXT sampleLocationsInfo;
}