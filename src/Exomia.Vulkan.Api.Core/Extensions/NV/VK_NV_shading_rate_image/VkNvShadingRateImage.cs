#region License

// Copyright (c) 2018-2023, exomia
// All rights reserved.
// 
// This source code is licensed under the BSD-style license found in the
// LICENSE file in the root directory of this source tree.

#endregion

global using static Exomia.Vulkan.Api.Core.VkNvShadingRateImage;

#pragma warning disable CA2211 // Non-constant fields should not be visible
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

// ReSharper disable UnusedMember.Global
// ReSharper disable InconsistentNaming
// ReSharper disable once CheckNamespace
namespace Exomia.Vulkan.Api.Core;

/// <summary>
///     VK_NV_shading_rate_image - device extension (nr. 165) - author 'NV' [platform '' | contact 'Pat Brown @nvpbrown']
///     <br />
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_NV_shading_rate_image.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_NV_shading_rate_image.html</a>
/// </summary>
[VkDepends("VK_KHR_get_physical_device_properties2")]
public static unsafe class VkNvShadingRateImage
{
    /// <summary> The spec version. </summary>
    public const uint VK_NV_SHADING_RATE_IMAGE_SPEC_VERSION = 3;

    /// <summary> The extension name. </summary>
    public const string VK_NV_SHADING_RATE_IMAGE_EXTENSION_NAME = "VK_NV_shading_rate_image";

    /// <summary>
    ///     An UTF8 null terminated version of <see cref="VK_NV_SHADING_RATE_IMAGE_EXTENSION_NAME" /> represented by an
    ///     UTF16 string.
    /// </summary>
    /// <remarks>
    ///     Example usage:<br />
    ///     <br />
    ///     fixed(char* ptr = VK_NV_SHADING_RATE_IMAGE_EXTENSION_NAME_UTF8_NT) {<br />
    ///     sbyte* utf8NtPtr = (sbyte*)ptr; // utf8NtPtr - can now be passed and used directly as a utf8_nt string for
    ///     unmanaged code.<br />
    ///     }
    /// </remarks>
    public const string VK_NV_SHADING_RATE_IMAGE_EXTENSION_NAME_UTF8_NT = "\u4b56\u4e5f\u5f56\u4853\u4441\u4e49\u5f47\u4152\u4554\u495f\u414d\u4547\u455f\u5458\u4e45\u4953\u4e4f\u4e5f\u4d41\u0045";

    /// <summary>
    ///     vkCmdBindShadingRateImageNV - Bind a shading rate image on a command buffer -
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdBindShadingRateImageNV.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdBindShadingRateImageNV.html</a>
    /// </summary>
    /// <param name="commandBuffer">commandBuffer is the command buffer into which the command will be recorded.</param>
    /// <param name="imageView">
    ///     imageView is an image view handle specifying the shading rate image. imageView may be set to
    ///     VK_NULL_HANDLE, which is equivalent to specifying a view of an image filled with zero values.
    /// </param>
    /// <param name="imageLayout">
    ///     imageLayout is the layout that the image subresources accessible from imageView will be in
    ///     when the shading rate image is accessed.
    /// </param>
    public static readonly delegate*<
        VkCommandBuffer /*commandBuffer*/,
        VkImageView /*imageView*/,
        VkImageLayout /*imageLayout*/,
        void> vkCmdBindShadingRateImageNV = null;

    /// <summary>
    ///     vkCmdSetViewportShadingRatePaletteNV - Set shading rate image palettes dynamically for a command buffer -
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdSetViewportShadingRatePaletteNV.html">
    ///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdSetViewportShadingRatePaletteNV.html
    ///     </a>
    /// </summary>
    /// <param name="commandBuffer">commandBuffer is the command buffer into which the command will be recorded.</param>
    /// <param name="firstViewport">
    ///     firstViewport is the index of the first viewport whose shading rate palette is updated by
    ///     the command.
    /// </param>
    /// <param name="viewportCount">
    ///     viewportCount is the number of viewports whose shading rate palettes are updated by the
    ///     command.
    /// </param>
    /// <param name="pShadingRatePalettes">
    ///     pShadingRatePalettes is a pointer to an array of VkShadingRatePaletteNV structures
    ///     defining the palette for each viewport.
    /// </param>
    public static readonly delegate*<
        VkCommandBuffer /*commandBuffer*/,
        uint /*firstViewport*/,
        uint /*viewportCount*/,
        VkShadingRatePaletteNV* /*pShadingRatePalettes*/,
        void> vkCmdSetViewportShadingRatePaletteNV = null;

    /// <summary>
    ///     vkCmdSetCoarseSampleOrderNV - Set order of coverage samples for coarse fragments dynamically for a command
    ///     buffer -
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdSetCoarseSampleOrderNV.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdSetCoarseSampleOrderNV.html</a>
    /// </summary>
    /// <param name="commandBuffer">commandBuffer is the command buffer into which the command will be recorded.</param>
    /// <param name="sampleOrderType">
    ///     sampleOrderType specifies the mechanism used to order coverage samples in fragments
    ///     larger than one pixel.
    /// </param>
    /// <param name="customSampleOrderCount">
    ///     customSampleOrderCount specifies the number of custom sample orderings to use when
    ///     ordering coverage samples.
    /// </param>
    /// <param name="pCustomSampleOrders">
    ///     pCustomSampleOrders is a pointer to an array of VkCoarseSampleOrderCustomNV
    ///     structures, each structure specifying the coverage sample order for a single combination of fragment area and
    ///     coverage sample count.
    /// </param>
    public static readonly delegate*<
        VkCommandBuffer /*commandBuffer*/,
        VkCoarseSampleOrderTypeNV /*sampleOrderType*/,
        uint /*customSampleOrderCount*/,
        VkCoarseSampleOrderCustomNV* /*pCustomSampleOrders*/,
        void> vkCmdSetCoarseSampleOrderNV = null;

    /// <summary> Loads all function pointer based on the device for this extension. (see remarks!) </summary>
    /// <param name="device"> The device that the function pointers will be compatible with. </param>
    /// <remarks>
    ///     This load method makes the following function pointers available:<br />
    ///     <list type="bullet">
    ///         <item>
    ///             <description>vkCmdBindShadingRateImageNV</description>
    ///         </item>
    ///         <item>
    ///             <description>vkCmdSetViewportShadingRatePaletteNV</description>
    ///         </item>
    ///         <item>
    ///             <description>vkCmdSetCoarseSampleOrderNV</description>
    ///         </item>
    ///     </list>
    /// </remarks>
    public static void Load(VkDevice device)
    {
        fixed (delegate*<VkCommandBuffer, VkImageView, VkImageLayout, void>* pvkCmdBindShadingRateImageNV = &vkCmdBindShadingRateImageNV)
        {
            *pvkCmdBindShadingRateImageNV = (delegate*<VkCommandBuffer, VkImageView, VkImageLayout, void>)GetVkFunction(
                device, "\u6b76\u6d43\u4264\u6e69\u5364\u6168\u6964\u676e\u6152\u6574\u6d49\u6761\u4e65\u0056");
        }

        fixed (delegate*<VkCommandBuffer, uint, uint, VkShadingRatePaletteNV*, void>* pvkCmdSetViewportShadingRatePaletteNV = &vkCmdSetViewportShadingRatePaletteNV)
        {
            *pvkCmdSetViewportShadingRatePaletteNV = (delegate*<VkCommandBuffer, uint, uint, VkShadingRatePaletteNV*, void>)GetVkFunction(
                device, "\u6b76\u6d43\u5364\u7465\u6956\u7765\u6f70\u7472\u6853\u6461\u6e69\u5267\u7461\u5065\u6c61\u7465\u6574\u564e\u0000");
        }

        fixed (delegate*<VkCommandBuffer, VkCoarseSampleOrderTypeNV, uint, VkCoarseSampleOrderCustomNV*, void>* pvkCmdSetCoarseSampleOrderNV = &vkCmdSetCoarseSampleOrderNV)
        {
            *pvkCmdSetCoarseSampleOrderNV = (delegate*<VkCommandBuffer, VkCoarseSampleOrderTypeNV, uint, VkCoarseSampleOrderCustomNV*, void>)GetVkFunction(
                device, "\u6b76\u6d43\u5364\u7465\u6f43\u7261\u6573\u6153\u706d\u656c\u724f\u6564\u4e72\u0056");
        }
    }
}