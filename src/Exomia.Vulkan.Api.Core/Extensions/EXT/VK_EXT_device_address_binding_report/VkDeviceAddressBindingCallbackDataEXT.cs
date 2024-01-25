#region License

// Copyright (c) 2018-2024, exomia
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
///     VkDeviceAddressBindingCallbackDataEXT - Structure specifying parameters returned to the callback -
///     <a
///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkDeviceAddressBindingCallbackDataEXT.html">
///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkDeviceAddressBindingCallbackDataEXT.html
///     </a>
/// </summary>
/// <remarks>
///     <list type="table">
///         <item>
///             <term>structextends</term><description>VkDebugUtilsMessengerCallbackDataEXT</description>
///         </item>
///     </list>
/// </remarks>
[VkStructExtends("VkDebugUtilsMessengerCallbackDataEXT")]
[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkDeviceAddressBindingCallbackDataEXT
{
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_DEVICE_ADDRESS_BINDING_CALLBACK_DATA_EXT;

    /// <summary>sType is a VkStructureType value identifying this structure.</summary>
    public VkStructureType sType;

    /// <summary>pNext is NULL or a pointer to a structure extending this structure.</summary>
    public void* pNext;

    /// <summary>
    ///     flags is a bitmask of VkDeviceAddressBindingFlagBitsEXTspecifying additional information about the binding
    ///     event that caused the callback to be called.
    /// </summary>
    public VkDeviceAddressBindingFlagsEXT flags;

    /// <summary>
    ///     baseAddress is a GPU-accessible virtual address identifying the start of a region of the virtual address space
    ///     associated with a Vulkan object, as identified by the pObjects member of VkDebugUtilsMessengerCallbackDataEXT.
    /// </summary>
    public VkDeviceAddress baseAddress;

    /// <summary>size is the size in bytes of a region of GPU-accessible virtual address space.</summary>
    public VkDeviceSize size;

    /// <summary>
    ///     bindingType is a VkDeviceAddressBindingTypeEXT specifying the type of binding event that caused the callback
    ///     to be called.
    /// </summary>
    public VkDeviceAddressBindingTypeEXT bindingType;
}