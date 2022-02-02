#region License

// Copyright (c) 2018-2022, exomia
// All rights reserved.
// 
// This source code is licensed under the BSD-style license found in the
// LICENSE file in the root directory of this source tree.

#endregion

// ReSharper disable UnusedMember.Global
// ReSharper disable once CheckNamespace
namespace Exomia.Vulkan.Api.Core;

/// <summary>
///     VkDescriptorUpdateTemplate - Opaque handle to a descriptor update template -
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkDescriptorUpdateTemplate.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkDescriptorUpdateTemplate.html</a>
/// </summary>
public readonly unsafe struct VkDescriptorUpdateTemplate
{
    /// <summary> The null value. </summary>
    public static readonly VkDescriptorUpdateTemplate Null = (VkDescriptorUpdateTemplate)null;
#pragma warning disable 649
    private readonly void* _ptr;
#pragma warning restore 649

    /// <summary> Returns a hash code for this object. </summary>
    /// <returns> A hash code for this object. </returns>
    public override int GetHashCode()
    {
        return ((IntPtr)_ptr).GetHashCode();
    }

    /// <summary> Tests if this in VkDescriptorUpdateTemplate is considered equal to this instance. </summary>
    /// <param name="obj"> The in VkDescriptorUpdateTemplate to compare to this instance. </param>
    /// <returns> True if the objects are considered equal, false if they are not. </returns>
    public bool Equals(in VkDescriptorUpdateTemplate obj)
    {
        return obj._ptr == _ptr;
    }

    /// <summary> Tests if the object is considered equal to this instance. </summary>
    /// <param name="obj"> The object to compare to this instance. </param>
    /// <returns> True if the objects are considered equal, false if they are not. </returns>
    public override bool Equals(object? obj)
    {
        return obj is VkDescriptorUpdateTemplate vkDescriptorUpdateTemplate && Equals(in vkDescriptorUpdateTemplate);
    }

    /// <summary> Explicit cast that converts the given void* to a VkDescriptorUpdateTemplate. </summary>
    /// <param name="ptr"> [in,out] If non-null, the pointer. </param>
    /// <returns> The result of the operation. </returns>
    public static explicit operator VkDescriptorUpdateTemplate(void* ptr)
    {
        VkDescriptorUpdateTemplate value;
        *(void**)&value = ptr;
        return value;
    }

    /// <summary> Equality operator. </summary>
    /// <param name="left">  The left. </param>
    /// <param name="right"> The right. </param>
    /// <returns> The result of the operation. </returns>
    public static bool operator ==(VkDescriptorUpdateTemplate left, VkDescriptorUpdateTemplate right)
    {
        return left._ptr == right._ptr;
    }

    /// <summary> Inequality operator. </summary>
    /// <param name="left">  The left. </param>
    /// <param name="right"> The right. </param>
    /// <returns> The result of the operation. </returns>
    public static bool operator !=(VkDescriptorUpdateTemplate left, VkDescriptorUpdateTemplate right)
    {
        return left._ptr != right._ptr;
    }

    /// <summary> Explicit cast that converts the given VkDescriptorUpdateTemplate to a void*. </summary>
    /// <param name="value"> The value. </param>
    /// <returns> The result of the operation. </returns>
    public static explicit operator void*(VkDescriptorUpdateTemplate value)
    {
        return value._ptr;
    }
}