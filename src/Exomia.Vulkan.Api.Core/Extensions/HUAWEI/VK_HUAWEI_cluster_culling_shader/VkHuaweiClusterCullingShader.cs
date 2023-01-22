#region License

// Copyright (c) 2018-2023, exomia
// All rights reserved.
// 
// This source code is licensed under the BSD-style license found in the
// LICENSE file in the root directory of this source tree.

#endregion

global using static Exomia.Vulkan.Api.Core.VkHuaweiClusterCullingShader;

#pragma warning disable CA2211 // Non-constant fields should not be visible
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

// ReSharper disable UnusedMember.Global
// ReSharper disable InconsistentNaming
// ReSharper disable once CheckNamespace
namespace Exomia.Vulkan.Api.Core;

/// <summary>
///     VK_HUAWEI_cluster_culling_shader - device extension (nr. 405) - author 'HUAWEI' [platform '' | contact 'Yuchang
///     Wang @richard_Wang2']<br />
///     <a
///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_HUAWEI_cluster_culling_shader.html">
///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_HUAWEI_cluster_culling_shader.html
///     </a>
/// </summary>
[VkRequires("VK_KHR_get_physical_device_properties2")]
public static unsafe class VkHuaweiClusterCullingShader
{
    /// <summary> The spec version. </summary>
    public const uint VK_HUAWEI_CLUSTER_CULLING_SHADER_SPEC_VERSION = 1;

    /// <summary> The extension name. </summary>
    public const string VK_HUAWEI_CLUSTER_CULLING_SHADER_EXTENSION_NAME = "VK_HUAWEI_cluster_culling_shader";

    /// <summary>
    ///     An UTF8 null terminated version of <see cref="VK_HUAWEI_CLUSTER_CULLING_SHADER_EXTENSION_NAME" /> represented
    ///     by an UTF16 string.
    /// </summary>
    /// <remarks>
    ///     Example usage:<br />
    ///     <br />
    ///     fixed(char* ptr = VK_HUAWEI_CLUSTER_CULLING_SHADER_EXTENSION_NAME_UTF8_NT) {<br />
    ///     sbyte* utf8NtPtr = (sbyte*)ptr; // utf8NtPtr - can now be passed and used directly as a utf8_nt string for
    ///     unmanaged code.<br />
    ///     }
    /// </remarks>
    public const string VK_HUAWEI_CLUSTER_CULLING_SHADER_EXTENSION_NAME_UTF8_NT =
        "\u4b56\u485f\u4155\u4557\u5f49\u4c43\u5355\u4554\u5f52\u5543\u4c4c\u4e49\u5f47\u4853\u4441\u5245\u455f\u5458\u4e45\u4953\u4e4f\u4e5f\u4d41\u0045";

    /// <summary>
    ///     vkCmdDrawClusterHUAWEI - Draw cluster culling work items -
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdDrawClusterHUAWEI.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdDrawClusterHUAWEI.html</a>
    /// </summary>
    /// <param name="commandBuffer">commandBuffer is the command buffer into which the command will be recorded.</param>
    /// <param name="groupCountX">groupCountX is the number of local workgroups to dispatch in the X dimension.</param>
    /// <param name="groupCountY">groupCountY is the number of local workgroups to dispatch in the Y dimension.</param>
    /// <param name="groupCountZ">groupCountZ is the number of local workgroups to dispatch in the Z dimension.</param>
    public static readonly delegate*<
        VkCommandBuffer /*commandBuffer*/,
        uint /*groupCountX*/,
        uint /*groupCountY*/,
        uint /*groupCountZ*/,
        void> vkCmdDrawClusterHUAWEI = null;

    /// <summary>
    ///     vkCmdDrawClusterIndirectHUAWEI - Issue an indirect cluster culling draw into a command buffer -
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdDrawClusterIndirectHUAWEI.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdDrawClusterIndirectHUAWEI.html</a>
    /// </summary>
    /// <param name="commandBuffer">commandBuffer is the command buffer into which the command is recorded.</param>
    /// <param name="buffer">buffer is the buffer containing draw parameters.</param>
    /// <param name="offset">offset is the byte offset into buffer where parameters begin.</param>
    public static readonly delegate*<
        VkCommandBuffer /*commandBuffer*/,
        VkBuffer /*buffer*/,
        VkDeviceSize /*offset*/,
        void> vkCmdDrawClusterIndirectHUAWEI = null;

    /// <summary> Loads all function pointer based on the device for this extension. (see remarks!) </summary>
    /// <param name="device"> The device that the function pointers will be compatible with. </param>
    /// <remarks>
    ///     This load method makes the following function pointers available:<br />
    ///     <list type="bullet">
    ///         <item>
    ///             <description>vkCmdDrawClusterHUAWEI</description>
    ///         </item>
    ///         <item>
    ///             <description>vkCmdDrawClusterIndirectHUAWEI</description>
    ///         </item>
    ///     </list>
    /// </remarks>
    public static void Load(VkDevice device)
    {
        fixed (delegate*<VkCommandBuffer, uint, uint, uint, void>* pvkCmdDrawClusterHUAWEI = &vkCmdDrawClusterHUAWEI)
        {
            *pvkCmdDrawClusterHUAWEI = (delegate*<VkCommandBuffer, uint, uint, uint, void>)GetVkFunction(device, "\u6b76\u6d43\u4464\u6172\u4377\u756c\u7473\u7265\u5548\u5741\u4945\u0000");
        }

        fixed (delegate*<VkCommandBuffer, VkBuffer, VkDeviceSize, void>* pvkCmdDrawClusterIndirectHUAWEI = &vkCmdDrawClusterIndirectHUAWEI)
        {
            *pvkCmdDrawClusterIndirectHUAWEI = (delegate*<VkCommandBuffer, VkBuffer, VkDeviceSize, void>)GetVkFunction(
                device, "\u6b76\u6d43\u4464\u6172\u4377\u756c\u7473\u7265\u6e49\u6964\u6572\u7463\u5548\u5741\u4945\u0000");
        }
    }
}