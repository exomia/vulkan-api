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
///     VkDeviceGroupSubmitInfo - Structure indicating which physical devices execute semaphore operations and
///     command buffers -
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkDeviceGroupSubmitInfo.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkDeviceGroupSubmitInfo.html</a>
/// </summary>
/// <remarks>
///     <list type="table">
///         <item>
///             <term>structextends</term><description>VkSubmitInfo</description>
///         </item>
///     </list>
/// </remarks>
[VkStructExtends("VkSubmitInfo")]
[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkDeviceGroupSubmitInfo
{
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_DEVICE_GROUP_SUBMIT_INFO;

    /// <summary>sType is a VkStructureType value identifying this structure.</summary>
    public VkStructureType sType;

    /// <summary>pNext is NULL or a pointer to a structure extending this structure.</summary>
    public void* pNext;

    /// <summary>waitSemaphoreCount is the number of elements in the pWaitSemaphoreDeviceIndices array.</summary>
    public uint waitSemaphoreCount;

    /// <summary>
    ///     pWaitSemaphoreDeviceIndices is a pointer to an array of waitSemaphoreCount device indices indicating which
    ///     physical device executes the semaphore wait operation in the corresponding element of
    ///     VkSubmitInfo::pWaitSemaphores.
    /// </summary>
    public uint* pWaitSemaphoreDeviceIndices;

    /// <summary>commandBufferCount is the number of elements in the pCommandBufferDeviceMasks array.</summary>
    public uint commandBufferCount;

    /// <summary>
    ///     pCommandBufferDeviceMasks is a pointer to an array of commandBufferCount device masks indicating which
    ///     physical devices execute the command buffer in the corresponding element of VkSubmitInfo::pCommandBuffers. A
    ///     physical device executes the command buffer if the corresponding bit is set in the mask.
    /// </summary>
    public uint* pCommandBufferDeviceMasks;

    /// <summary>signalSemaphoreCount is the number of elements in the pSignalSemaphoreDeviceIndices array.</summary>
    public uint signalSemaphoreCount;

    /// <summary>
    ///     pSignalSemaphoreDeviceIndices is a pointer to an array of signalSemaphoreCount device indices indicating which
    ///     physical device executes the semaphore signal operation in the corresponding element of
    ///     VkSubmitInfo::pSignalSemaphores.
    /// </summary>
    public uint* pSignalSemaphoreDeviceIndices;
}