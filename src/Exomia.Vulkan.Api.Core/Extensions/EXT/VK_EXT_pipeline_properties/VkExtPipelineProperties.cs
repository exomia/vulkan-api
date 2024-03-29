#region License

// Copyright (c) 2018-2024, exomia
// All rights reserved.
// 
// This source code is licensed under the BSD-style license found in the
// LICENSE file in the root directory of this source tree.

#endregion

global using static Exomia.Vulkan.Api.Core.VkExtPipelineProperties;

#pragma warning disable CA2211 // Non-constant fields should not be visible
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

// ReSharper disable UnusedMember.Global
// ReSharper disable InconsistentNaming
// ReSharper disable once CheckNamespace
namespace Exomia.Vulkan.Api.Core;

/// <summary>
///     VK_EXT_pipeline_properties - device extension (nr. 373) - author 'EXT' [platform '' | contact 'Mukund Keshava
///     @mkeshavanv']<br />
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_EXT_pipeline_properties.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_EXT_pipeline_properties.html</a>
/// </summary>
[VkDepends("VK_KHR_get_physical_device_properties2,VK_VERSION_1_1")]
[VkDeviceExt]
public static unsafe class VkExtPipelineProperties
{
    /// <summary> The spec version. </summary>
    public const uint VK_EXT_PIPELINE_PROPERTIES_SPEC_VERSION = 1;

    /// <summary> The extension name. </summary>
    public const string VK_EXT_PIPELINE_PROPERTIES_EXTENSION_NAME = "VK_EXT_pipeline_properties";

    /// <summary>
    ///     An UTF8 null terminated version of <see cref="VK_EXT_PIPELINE_PROPERTIES_EXTENSION_NAME" /> represented by an
    ///     UTF16 string.
    /// </summary>
    /// <remarks>
    ///     Example usage:<br />
    ///     <br />
    ///     fixed(char* ptr = VK_EXT_PIPELINE_PROPERTIES_EXTENSION_NAME_UTF8_NT) {<br />
    ///     sbyte* utf8NtPtr = (sbyte*)ptr; // utf8NtPtr - can now be passed and used directly as a utf8_nt string for
    ///     unmanaged code.<br />
    ///     }
    /// </remarks>
    public const string VK_EXT_PIPELINE_PROPERTIES_EXTENSION_NAME_UTF8_NT =
        "\u4b56\u455f\u5458\u505f\u5049\u4c45\u4e49\u5f45\u5250\u504f\u5245\u4954\u5345\u455f\u5458\u4e45\u4953\u4e4f\u4e5f\u4d41\u0045";

    /// <summary>
    ///     vkGetPipelinePropertiesEXT - Query pipeline properties -
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkGetPipelinePropertiesEXT.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkGetPipelinePropertiesEXT.html</a>
    /// </summary>
    /// <param name="device">device is the logical device that created the pipeline.</param>
    /// <param name="pPipelineInfo">
    ///     pPipelineInfo is a pointer to a VkPipelineInfoEXT structure which describes the pipeline
    ///     being queried.
    /// </param>
    /// <param name="pPipelineProperties">
    ///     pPipelineProperties is a pointer to a VkBaseOutStructurestructure in which the
    ///     pipeline properties will be written.
    /// </param>
    /// <remarks>
    ///     <list type="table">
    ///         <item>
    ///             <term>successcodes</term><description>VK_SUCCESS</description>
    ///         </item>
    ///         <item>
    ///             <term>errorcodes</term><description>VK_ERROR_OUT_OF_HOST_MEMORY</description>
    ///         </item>
    ///     </list>
    /// </remarks>
    public static readonly delegate*<
        VkDevice /*device*/,
        VkPipelineInfoEXT* /*pPipelineInfo*/,
        VkBaseOutStructure* /*pPipelineProperties*/,
        VkResult> vkGetPipelinePropertiesEXT = null;

    /// <summary> Loads all function pointer based on the device for this extension. (see remarks!) </summary>
    /// <param name="device"> The device that the function pointers will be compatible with. </param>
    /// <remarks>
    ///     This load method makes the following function pointers available:<br />
    ///     <list type="bullet">
    ///         <item>
    ///             <description>vkGetPipelinePropertiesEXT</description>
    ///         </item>
    ///     </list>
    /// </remarks>
    public static void Load(VkDevice device)
    {
        fixed (delegate*<VkDevice, VkPipelineInfoEXT*, VkBaseOutStructure*, VkResult>* pvkGetPipelinePropertiesEXT = &vkGetPipelinePropertiesEXT)
        {
            *pvkGetPipelinePropertiesEXT = (delegate*<VkDevice, VkPipelineInfoEXT*, VkBaseOutStructure*, VkResult>)GetVkFunction(
                device, "\u6b76\u6547\u5074\u7069\u6c65\u6e69\u5065\u6f72\u6570\u7472\u6569\u4573\u5458\u0000");
        }
    }
}