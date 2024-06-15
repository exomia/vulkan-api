#region License

// Copyright (c) 2018-2024, exomia
// All rights reserved.
// 
// This source code is licensed under the BSD-style license found in the
// LICENSE file in the root directory of this source tree.

#endregion

global using static Exomia.Vulkan.Api.Core.VkExtDescriptorBuffer;

#pragma warning disable CA2211 // Non-constant fields should not be visible
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

// ReSharper disable UnusedMember.Global
// ReSharper disable InconsistentNaming
// ReSharper disable once CheckNamespace
namespace Exomia.Vulkan.Api.Core;

/// <summary>
///     VK_EXT_descriptor_buffer - device extension (nr. 317) - author 'EXT' [platform '' | contact 'Tobias Hector
///     @tobski']<br />
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_EXT_descriptor_buffer.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_EXT_descriptor_buffer.html</a>
/// </summary>
[VkDepends("((((VK_KHR_get_physical_device_properties2,VK_VERSION_1_1)+VK_KHR_buffer_device_address+VK_EXT_descriptor_indexing),VK_VERSION_1_2)+VK_KHR_synchronization2),VK_VERSION_1_3")]
[VkDeviceExt]
public static unsafe class VkExtDescriptorBuffer
{
    /// <summary> The spec version. </summary>
    public const uint VK_EXT_DESCRIPTOR_BUFFER_SPEC_VERSION = 1;

    /// <summary> The extension name. </summary>
    public const string VK_EXT_DESCRIPTOR_BUFFER_EXTENSION_NAME = "VK_EXT_descriptor_buffer";

    /// <summary>
    ///     An UTF8 null terminated version of <see cref="VK_EXT_DESCRIPTOR_BUFFER_EXTENSION_NAME" /> represented by an
    ///     UTF16 string.
    /// </summary>
    /// <remarks>
    ///     Example usage:<br />
    ///     <br />
    ///     fixed(char* ptr = VK_EXT_DESCRIPTOR_BUFFER_EXTENSION_NAME_UTF8_NT) {<br />
    ///     sbyte* utf8NtPtr = (sbyte*)ptr; // utf8NtPtr - can now be passed and used directly as a utf8_nt string for
    ///     unmanaged code.<br />
    ///     }
    /// </remarks>
    public const string VK_EXT_DESCRIPTOR_BUFFER_EXTENSION_NAME_UTF8_NT = "\u4b56\u455f\u5458\u445f\u5345\u5243\u5049\u4f54\u5f52\u5542\u4646\u5245\u455f\u5458\u4e45\u4953\u4e4f\u4e5f\u4d41\u0045";

    /// <summary>
    ///     vkGetDescriptorSetLayoutSizeEXT - Get the size of a descriptor set layout in memory -
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkGetDescriptorSetLayoutSizeEXT.html">
    ///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkGetDescriptorSetLayoutSizeEXT.html
    ///     </a>
    /// </summary>
    /// <param name="device">device is the logical device that gets the size.</param>
    /// <param name="layout">layout is the descriptor set layout being queried.</param>
    /// <param name="pLayoutSizeInBytes">
    ///     pLayoutSizeInBytes is a pointer to VkDeviceSize where the size in bytes will be
    ///     written.
    /// </param>
    public static readonly delegate*<
        VkDevice /*device*/,
        VkDescriptorSetLayout /*layout*/,
        VkDeviceSize* /*pLayoutSizeInBytes*/,
        void> vkGetDescriptorSetLayoutSizeEXT = null;

    /// <summary>
    ///     vkGetDescriptorSetLayoutBindingOffsetEXT - Get the offset of a binding within a descriptor set layout -
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkGetDescriptorSetLayoutBindingOffsetEXT.html">
    ///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkGetDescriptorSetLayoutBindingOffsetEXT.html
    ///     </a>
    /// </summary>
    /// <param name="device">device is the logical device that gets the offset.</param>
    /// <param name="layout">layout is the descriptor set layout being queried.</param>
    /// <param name="binding">binding is the binding number being queried.</param>
    /// <param name="pOffset">pOffset is a pointer to VkDeviceSize where the byte offset of the binding will be written.</param>
    public static readonly delegate*<
        VkDevice /*device*/,
        VkDescriptorSetLayout /*layout*/,
        uint /*binding*/,
        VkDeviceSize* /*pOffset*/,
        void> vkGetDescriptorSetLayoutBindingOffsetEXT = null;

    /// <summary>
    ///     vkGetDescriptorEXT - To get a descriptor to place in a buffer -
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkGetDescriptorEXT.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkGetDescriptorEXT.html</a>
    /// </summary>
    /// <param name="device">device is the logical device that gets the descriptor.</param>
    /// <param name="pDescriptorInfo">
    ///     pDescriptorInfo is a pointer to a VkDescriptorGetInfoEXTstructure specifying the
    ///     parameters of the descriptor to get.
    /// </param>
    /// <param name="dataSize">dataSize is the amount of the descriptor data to get in bytes.</param>
    /// <param name="pDescriptor">
    ///     pDescriptor is a pointer to an application-allocated buffer where the descriptor will be
    ///     written.
    /// </param>
    public static readonly delegate*<
        VkDevice /*device*/,
        VkDescriptorGetInfoEXT* /*pDescriptorInfo*/,
        nuint /*dataSize*/,
        void* /*pDescriptor*/,
        void> vkGetDescriptorEXT = null;

    /// <summary>
    ///     vkCmdBindDescriptorBuffersEXT - Binding descriptor buffers to a command buffer -
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdBindDescriptorBuffersEXT.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdBindDescriptorBuffersEXT.html</a>
    /// </summary>
    /// <param name="commandBuffer">commandBuffer is the command buffer that the descriptor buffers will be bound to.</param>
    /// <param name="bufferCount">bufferCount is the number of elements in the pBindingInfosarray.</param>
    /// <param name="pBindingInfos">pBindingInfos is a pointer to an array of VkDescriptorBufferBindingInfoEXT structures.</param>
    public static readonly delegate*<
        VkCommandBuffer /*commandBuffer*/,
        uint /*bufferCount*/,
        VkDescriptorBufferBindingInfoEXT* /*pBindingInfos*/,
        void> vkCmdBindDescriptorBuffersEXT = null;

    /// <summary>
    ///     vkCmdSetDescriptorBufferOffsetsEXT - Setting descriptor buffer offsets in a command buffer -
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdSetDescriptorBufferOffsetsEXT.html">
    ///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdSetDescriptorBufferOffsetsEXT.html
    ///     </a>
    /// </summary>
    /// <param name="commandBuffer">commandBuffer is the command buffer in which the descriptor buffer offsets will be set.</param>
    /// <param name="pipelineBindPoint">
    ///     pipelineBindPoint is a VkPipelineBindPoint indicating the type of the pipeline that
    ///     will use the descriptors.
    /// </param>
    /// <param name="layout">layout is a VkPipelineLayout object used to program the bindings.</param>
    /// <param name="firstSet">firstSet is the number of the first set to be bound.</param>
    /// <param name="setCount">setCount is the number of elements in the pBufferIndices and pOffsets arrays.</param>
    /// <param name="pBufferIndices">
    ///     pBufferIndices is a pointer to an array of indices into the descriptor buffer binding
    ///     points set by vkCmdBindDescriptorBuffersEXT.
    /// </param>
    /// <param name="pOffsets">
    ///     pOffsets is a pointer to an array of VkDeviceSize offsets to apply to the bound descriptor
    ///     buffers.
    /// </param>
    public static readonly delegate*<
        VkCommandBuffer /*commandBuffer*/,
        VkPipelineBindPoint /*pipelineBindPoint*/,
        VkPipelineLayout /*layout*/,
        uint /*firstSet*/,
        uint /*setCount*/,
        uint* /*pBufferIndices*/,
        VkDeviceSize* /*pOffsets*/,
        void> vkCmdSetDescriptorBufferOffsetsEXT = null;

    /// <summary>
    ///     vkCmdBindDescriptorBufferEmbeddedSamplersEXT - Setting embedded immutable samplers offsets in a command buffer -
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdBindDescriptorBufferEmbeddedSamplersEXT.html">
    ///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdBindDescriptorBufferEmbeddedSamplersEXT.html
    ///     </a>
    /// </summary>
    /// <param name="commandBuffer">commandBuffer is the command buffer that the embedded immutable samplers will be bound to.</param>
    /// <param name="pipelineBindPoint">
    ///     pipelineBindPoint is a VkPipelineBindPoint indicating the type of the pipeline that
    ///     will use the embedded immutable samplers.
    /// </param>
    /// <param name="layout">layout is a VkPipelineLayout object used to program the bindings.</param>
    /// <param name="set">set is the number of the set to be bound.</param>
    public static readonly delegate*<
        VkCommandBuffer /*commandBuffer*/,
        VkPipelineBindPoint /*pipelineBindPoint*/,
        VkPipelineLayout /*layout*/,
        uint /*set*/,
        void> vkCmdBindDescriptorBufferEmbeddedSamplersEXT = null;

    /// <summary>
    ///     vkGetBufferOpaqueCaptureDescriptorDataEXT - Get buffer opaque capture descriptor data -
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkGetBufferOpaqueCaptureDescriptorDataEXT.html">
    ///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkGetBufferOpaqueCaptureDescriptorDataEXT.html
    ///     </a>
    /// </summary>
    /// <param name="device">device is the logical device that gets the data.</param>
    /// <param name="pInfo">pInfo is a pointer to a VkBufferCaptureDescriptorDataInfoEXTstructure specifying the buffer.</param>
    /// <param name="pData">pData is a pointer to an application-allocated buffer where the data will be written.</param>
    /// <remarks>
    ///     <list type="table">
    ///         <item>
    ///             <term>successcodes</term><description>VK_SUCCESS</description>
    ///         </item>
    ///         <item>
    ///             <term>errorcodes</term><description>VK_ERROR_OUT_OF_HOST_MEMORY,VK_ERROR_OUT_OF_DEVICE_MEMORY</description>
    ///         </item>
    ///     </list>
    /// </remarks>
    public static readonly delegate*<
        VkDevice /*device*/,
        VkBufferCaptureDescriptorDataInfoEXT* /*pInfo*/,
        void* /*pData*/,
        VkResult> vkGetBufferOpaqueCaptureDescriptorDataEXT = null;

    /// <summary>
    ///     vkGetImageOpaqueCaptureDescriptorDataEXT - Get image opaque capture descriptor data -
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkGetImageOpaqueCaptureDescriptorDataEXT.html">
    ///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkGetImageOpaqueCaptureDescriptorDataEXT.html
    ///     </a>
    /// </summary>
    /// <param name="device">device is the logical device that gets the data.</param>
    /// <param name="pInfo">pInfo is a pointer to a VkImageCaptureDescriptorDataInfoEXTstructure specifying the image.</param>
    /// <param name="pData">pData is a pointer to an application-allocated buffer where the data will be written.</param>
    /// <remarks>
    ///     <list type="table">
    ///         <item>
    ///             <term>successcodes</term><description>VK_SUCCESS</description>
    ///         </item>
    ///         <item>
    ///             <term>errorcodes</term><description>VK_ERROR_OUT_OF_HOST_MEMORY,VK_ERROR_OUT_OF_DEVICE_MEMORY</description>
    ///         </item>
    ///     </list>
    /// </remarks>
    public static readonly delegate*<
        VkDevice /*device*/,
        VkImageCaptureDescriptorDataInfoEXT* /*pInfo*/,
        void* /*pData*/,
        VkResult> vkGetImageOpaqueCaptureDescriptorDataEXT = null;

    /// <summary>
    ///     vkGetImageViewOpaqueCaptureDescriptorDataEXT - Get image view opaque capture descriptor data -
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkGetImageViewOpaqueCaptureDescriptorDataEXT.html">
    ///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkGetImageViewOpaqueCaptureDescriptorDataEXT.html
    ///     </a>
    /// </summary>
    /// <param name="device">device is the logical device that gets the data.</param>
    /// <param name="pInfo">
    ///     pInfo is a pointer to a VkImageViewCaptureDescriptorDataInfoEXT structure specifying the image
    ///     view.
    /// </param>
    /// <param name="pData">pData is a pointer to an application-allocated buffer where the data will be written.</param>
    /// <remarks>
    ///     <list type="table">
    ///         <item>
    ///             <term>successcodes</term><description>VK_SUCCESS</description>
    ///         </item>
    ///         <item>
    ///             <term>errorcodes</term><description>VK_ERROR_OUT_OF_HOST_MEMORY,VK_ERROR_OUT_OF_DEVICE_MEMORY</description>
    ///         </item>
    ///     </list>
    /// </remarks>
    public static readonly delegate*<
        VkDevice /*device*/,
        VkImageViewCaptureDescriptorDataInfoEXT* /*pInfo*/,
        void* /*pData*/,
        VkResult> vkGetImageViewOpaqueCaptureDescriptorDataEXT = null;

    /// <summary>
    ///     vkGetSamplerOpaqueCaptureDescriptorDataEXT - Get sampler opaque capture descriptor data -
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkGetSamplerOpaqueCaptureDescriptorDataEXT.html">
    ///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkGetSamplerOpaqueCaptureDescriptorDataEXT.html
    ///     </a>
    /// </summary>
    /// <param name="device">device is the logical device that gets the data.</param>
    /// <param name="pInfo">pInfo is a pointer to a VkSamplerCaptureDescriptorDataInfoEXT structure specifying the sampler.</param>
    /// <param name="pData">pData is a pointer to an application-allocated buffer where the data will be written.</param>
    /// <remarks>
    ///     <list type="table">
    ///         <item>
    ///             <term>successcodes</term><description>VK_SUCCESS</description>
    ///         </item>
    ///         <item>
    ///             <term>errorcodes</term><description>VK_ERROR_OUT_OF_HOST_MEMORY,VK_ERROR_OUT_OF_DEVICE_MEMORY</description>
    ///         </item>
    ///     </list>
    /// </remarks>
    public static readonly delegate*<
        VkDevice /*device*/,
        VkSamplerCaptureDescriptorDataInfoEXT* /*pInfo*/,
        void* /*pData*/,
        VkResult> vkGetSamplerOpaqueCaptureDescriptorDataEXT = null;

    /// <summary>
    ///     vkGetAccelerationStructureOpaqueCaptureDescriptorDataEXT - Get acceleration structure opaque capture descriptor
    ///     data -
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkGetAccelerationStructureOpaqueCaptureDescriptorDataEXT.html">
    ///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkGetAccelerationStructureOpaqueCaptureDescriptorDataEXT.html
    ///     </a>
    /// </summary>
    /// <param name="device">device is the logical device that gets the data.</param>
    /// <param name="pInfo">
    ///     pInfo is a pointer to a VkAccelerationStructureCaptureDescriptorDataInfoEXT structure specifying
    ///     the acceleration structure.
    /// </param>
    /// <param name="pData">pData is a pointer to an application-allocated buffer where the data will be written.</param>
    /// <remarks>
    ///     <list type="table">
    ///         <item>
    ///             <term>successcodes</term><description>VK_SUCCESS</description>
    ///         </item>
    ///         <item>
    ///             <term>errorcodes</term><description>VK_ERROR_OUT_OF_HOST_MEMORY,VK_ERROR_OUT_OF_DEVICE_MEMORY</description>
    ///         </item>
    ///     </list>
    /// </remarks>
    public static readonly delegate*<
        VkDevice /*device*/,
        VkAccelerationStructureCaptureDescriptorDataInfoEXT* /*pInfo*/,
        void* /*pData*/,
        VkResult> vkGetAccelerationStructureOpaqueCaptureDescriptorDataEXT = null;

    /// <summary> Loads all function pointer based on the device for this extension. (see remarks!) </summary>
    /// <param name="device"> The device that the function pointers will be compatible with. </param>
    /// <remarks>
    ///     This load method makes the following function pointers available:<br />
    ///     <list type="bullet">
    ///         <item>
    ///             <description>vkGetDescriptorSetLayoutSizeEXT</description>
    ///         </item>
    ///         <item>
    ///             <description>vkGetDescriptorSetLayoutBindingOffsetEXT</description>
    ///         </item>
    ///         <item>
    ///             <description>vkGetDescriptorEXT</description>
    ///         </item>
    ///         <item>
    ///             <description>vkCmdBindDescriptorBuffersEXT</description>
    ///         </item>
    ///         <item>
    ///             <description>vkCmdSetDescriptorBufferOffsetsEXT</description>
    ///         </item>
    ///         <item>
    ///             <description>vkCmdBindDescriptorBufferEmbeddedSamplersEXT</description>
    ///         </item>
    ///         <item>
    ///             <description>vkGetBufferOpaqueCaptureDescriptorDataEXT</description>
    ///         </item>
    ///         <item>
    ///             <description>vkGetImageOpaqueCaptureDescriptorDataEXT</description>
    ///         </item>
    ///         <item>
    ///             <description>vkGetImageViewOpaqueCaptureDescriptorDataEXT</description>
    ///         </item>
    ///         <item>
    ///             <description>vkGetSamplerOpaqueCaptureDescriptorDataEXT</description>
    ///         </item>
    ///         <item>
    ///             <description>vkGetAccelerationStructureOpaqueCaptureDescriptorDataEXT</description>
    ///         </item>
    ///     </list>
    /// </remarks>
    public static void Load(VkDevice device)
    {
        fixed (delegate*<VkDevice, VkDescriptorSetLayout, VkDeviceSize*, void>* pvkGetDescriptorSetLayoutSizeEXT = &vkGetDescriptorSetLayoutSizeEXT)
        {
            *pvkGetDescriptorSetLayoutSizeEXT = (delegate*<VkDevice, VkDescriptorSetLayout, VkDeviceSize*, void>)GetVkFunction(
                device, "\u6b76\u6547\u4474\u7365\u7263\u7069\u6f74\u5372\u7465\u614c\u6f79\u7475\u6953\u657a\u5845\u0054");
        }

        fixed (delegate*<VkDevice, VkDescriptorSetLayout, uint, VkDeviceSize*, void>* pvkGetDescriptorSetLayoutBindingOffsetEXT = &vkGetDescriptorSetLayoutBindingOffsetEXT)
        {
            *pvkGetDescriptorSetLayoutBindingOffsetEXT = (delegate*<VkDevice, VkDescriptorSetLayout, uint, VkDeviceSize*, void>)GetVkFunction(
                device, "\u6b76\u6547\u4474\u7365\u7263\u7069\u6f74\u5372\u7465\u614c\u6f79\u7475\u6942\u646e\u6e69\u4f67\u6666\u6573\u4574\u5458\u0000");
        }

        fixed (delegate*<VkDevice, VkDescriptorGetInfoEXT*, nuint, void*, void>* pvkGetDescriptorEXT = &vkGetDescriptorEXT)
        {
            *pvkGetDescriptorEXT = (delegate*<VkDevice, VkDescriptorGetInfoEXT*, nuint, void*, void>)GetVkFunction(device, "\u6b76\u6547\u4474\u7365\u7263\u7069\u6f74\u4572\u5458\u0000");
        }

        fixed (delegate*<VkCommandBuffer, uint, VkDescriptorBufferBindingInfoEXT*, void>* pvkCmdBindDescriptorBuffersEXT = &vkCmdBindDescriptorBuffersEXT)
        {
            *pvkCmdBindDescriptorBuffersEXT = (delegate*<VkCommandBuffer, uint, VkDescriptorBufferBindingInfoEXT*, void>)GetVkFunction(
                device, "\u6b76\u6d43\u4264\u6e69\u4464\u7365\u7263\u7069\u6f74\u4272\u6675\u6566\u7372\u5845\u0054");
        }

        fixed (delegate*<VkCommandBuffer, VkPipelineBindPoint, VkPipelineLayout, uint, uint, uint*, VkDeviceSize*, void>* pvkCmdSetDescriptorBufferOffsetsEXT = &vkCmdSetDescriptorBufferOffsetsEXT)
        {
            *pvkCmdSetDescriptorBufferOffsetsEXT = (delegate*<VkCommandBuffer, VkPipelineBindPoint, VkPipelineLayout, uint, uint, uint*, VkDeviceSize*, void>)GetVkFunction(
                device, "\u6b76\u6d43\u5364\u7465\u6544\u6373\u6972\u7470\u726f\u7542\u6666\u7265\u664f\u7366\u7465\u4573\u5458\u0000");
        }

        fixed (delegate*<VkCommandBuffer, VkPipelineBindPoint, VkPipelineLayout, uint, void>* pvkCmdBindDescriptorBufferEmbeddedSamplersEXT = &vkCmdBindDescriptorBufferEmbeddedSamplersEXT)
        {
            *pvkCmdBindDescriptorBufferEmbeddedSamplersEXT = (delegate*<VkCommandBuffer, VkPipelineBindPoint, VkPipelineLayout, uint, void>)GetVkFunction(
                device, "\u6b76\u6d43\u4264\u6e69\u4464\u7365\u7263\u7069\u6f74\u4272\u6675\u6566\u4572\u626d\u6465\u6564\u5364\u6d61\u6c70\u7265\u4573\u5458\u0000");
        }

        fixed (delegate*<VkDevice, VkBufferCaptureDescriptorDataInfoEXT*, void*, VkResult>* pvkGetBufferOpaqueCaptureDescriptorDataEXT = &vkGetBufferOpaqueCaptureDescriptorDataEXT)
        {
            *pvkGetBufferOpaqueCaptureDescriptorDataEXT = (delegate*<VkDevice, VkBufferCaptureDescriptorDataInfoEXT*, void*, VkResult>)GetVkFunction(
                device, "\u6b76\u6547\u4274\u6675\u6566\u4f72\u6170\u7571\u4365\u7061\u7574\u6572\u6544\u6373\u6972\u7470\u726f\u6144\u6174\u5845\u0054");
        }

        fixed (delegate*<VkDevice, VkImageCaptureDescriptorDataInfoEXT*, void*, VkResult>* pvkGetImageOpaqueCaptureDescriptorDataEXT = &vkGetImageOpaqueCaptureDescriptorDataEXT)
        {
            *pvkGetImageOpaqueCaptureDescriptorDataEXT = (delegate*<VkDevice, VkImageCaptureDescriptorDataInfoEXT*, void*, VkResult>)GetVkFunction(
                device, "\u6b76\u6547\u4974\u616d\u6567\u704f\u7161\u6575\u6143\u7470\u7275\u4465\u7365\u7263\u7069\u6f74\u4472\u7461\u4561\u5458\u0000");
        }

        fixed (delegate*<VkDevice, VkImageViewCaptureDescriptorDataInfoEXT*, void*, VkResult>* pvkGetImageViewOpaqueCaptureDescriptorDataEXT = &vkGetImageViewOpaqueCaptureDescriptorDataEXT)
        {
            *pvkGetImageViewOpaqueCaptureDescriptorDataEXT = (delegate*<VkDevice, VkImageViewCaptureDescriptorDataInfoEXT*, void*, VkResult>)GetVkFunction(
                device, "\u6b76\u6547\u4974\u616d\u6567\u6956\u7765\u704f\u7161\u6575\u6143\u7470\u7275\u4465\u7365\u7263\u7069\u6f74\u4472\u7461\u4561\u5458\u0000");
        }

        fixed (delegate*<VkDevice, VkSamplerCaptureDescriptorDataInfoEXT*, void*, VkResult>* pvkGetSamplerOpaqueCaptureDescriptorDataEXT = &vkGetSamplerOpaqueCaptureDescriptorDataEXT)
        {
            *pvkGetSamplerOpaqueCaptureDescriptorDataEXT = (delegate*<VkDevice, VkSamplerCaptureDescriptorDataInfoEXT*, void*, VkResult>)GetVkFunction(
                device, "\u6b76\u6547\u5374\u6d61\u6c70\u7265\u704f\u7161\u6575\u6143\u7470\u7275\u4465\u7365\u7263\u7069\u6f74\u4472\u7461\u4561\u5458\u0000");
        }

        fixed (delegate*<VkDevice, VkAccelerationStructureCaptureDescriptorDataInfoEXT*, void*, VkResult>* pvkGetAccelerationStructureOpaqueCaptureDescriptorDataEXT =
            &vkGetAccelerationStructureOpaqueCaptureDescriptorDataEXT)
        {
            *pvkGetAccelerationStructureOpaqueCaptureDescriptorDataEXT = (delegate*<VkDevice, VkAccelerationStructureCaptureDescriptorDataInfoEXT*, void*, VkResult>)GetVkFunction(
                device,
                "\u6b76\u6547\u4174\u6363\u6c65\u7265\u7461\u6f69\u536e\u7274\u6375\u7574\u6572\u704f\u7161\u6575\u6143\u7470\u7275\u4465\u7365\u7263\u7069\u6f74\u4472\u7461\u4561\u5458\u0000");
        }
    }
}