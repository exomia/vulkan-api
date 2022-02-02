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
///     VkAttachmentSampleLocationsEXT - Structure specifying the sample locations state to use in the initial layout
///     transition of attachments -
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkAttachmentSampleLocationsEXT.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkAttachmentSampleLocationsEXT.html</a>
/// </summary>
[StructLayout(LayoutKind.Sequential)]
public struct VkAttachmentSampleLocationsEXT
{
    /// <summary>attachmentIndex is the index of the attachment for which the sample locations state is provided.</summary>
    public uint attachmentIndex;

    /// <summary>
    ///     sampleLocationsInfo is the sample locations state to use for the layout transition of the given attachment
    ///     from the initial layout of the attachment to the image layout specified for the attachment in the first subpass
    ///     using it.
    /// </summary>
    public VkSampleLocationsInfoEXT sampleLocationsInfo;
}