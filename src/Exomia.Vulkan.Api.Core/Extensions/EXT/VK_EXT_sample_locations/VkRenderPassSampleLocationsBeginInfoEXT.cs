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
///     VkRenderPassSampleLocationsBeginInfoEXT - Structure specifying sample locations to use for the layout transition of
///     custom sample locations compatible depth/stencil attachments -
///     <a
///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkRenderPassSampleLocationsBeginInfoEXT.html">
///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkRenderPassSampleLocationsBeginInfoEXT.html
///     </a>
/// </summary>
/// <remarks>
///     <list type="table">
///         <item>
///             <term>structextends</term><description>VkRenderPassBeginInfo</description>
///         </item>
///     </list>
/// </remarks>
[VkStructExtends("VkRenderPassBeginInfo")]
[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkRenderPassSampleLocationsBeginInfoEXT
{
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_RENDER_PASS_SAMPLE_LOCATIONS_BEGIN_INFO_EXT;

    /// <summary>sType is the type of this structure.</summary>
    public VkStructureType sType;

    /// <summary>pNext is NULL or a pointer to a structure extending this structure.</summary>
    public void* pNext;

    /// <summary>
    ///     attachmentInitialSampleLocationsCount is the number of elements in the pAttachmentInitialSampleLocations
    ///     array.
    /// </summary>
    public uint attachmentInitialSampleLocationsCount;

    /// <summary>
    ///     pAttachmentInitialSampleLocations is a pointer to an array of
    ///     attachmentInitialSampleLocationsCountVkAttachmentSampleLocationsEXT structures specifying the attachment indices
    ///     and their corresponding sample location state. Each element of pAttachmentInitialSampleLocations can specify the
    ///     sample location state to use in the automatic layout transition performed to transition a depth/stencil attachment
    ///     from the initial layout of the attachment to the image layout specified for the attachment in the first subpass
    ///     using it.
    /// </summary>
    public VkAttachmentSampleLocationsEXT* pAttachmentInitialSampleLocations;

    /// <summary>postSubpassSampleLocationsCount is the number of elements in the pPostSubpassSampleLocations array.</summary>
    public uint postSubpassSampleLocationsCount;

    /// <summary>
    ///     pPostSubpassSampleLocations is a pointer to an array of postSubpassSampleLocationsCount
    ///     VkSubpassSampleLocationsEXTstructures specifying the subpass indices and their corresponding sample location state.
    ///     Each element of pPostSubpassSampleLocations can specify the sample location state to use in the automatic layout
    ///     transition performed to transition the depth/stencil attachment used by the specified subpass to the image layout
    ///     specified in a dependent subpass or to the final layout of the attachment in case the specified subpass is the last
    ///     subpass using that attachment. In addition, if
    ///     VkPhysicalDeviceSampleLocationsPropertiesEXT::variableSampleLocationsis VK_FALSE, each element of
    ///     pPostSubpassSampleLocationsmust specify the sample location state that matches the sample locations used by all
    ///     pipelines that will be bound to a command buffer during the specified subpass. If variableSampleLocations is
    ///     VK_TRUE, the sample locations used for rasterization do not depend on pPostSubpassSampleLocations.
    /// </summary>
    public VkSubpassSampleLocationsEXT* pPostSubpassSampleLocations;
}