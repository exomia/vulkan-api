#region License

// Copyright (c) 2018-2024, exomia
// All rights reserved.
// 
// This source code is licensed under the BSD-style license found in the
// LICENSE file in the root directory of this source tree.

#endregion

// ReSharper disable UnusedMember.Global
// ReSharper disable once CheckNamespace
namespace Exomia.Vulkan.Api.Core;

/// <summary>
///     VkAccelerationStructureNV - Opaque handle to an acceleration structure object -
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkAccelerationStructureNV.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkAccelerationStructureNV.html</a>
/// </summary>
public readonly unsafe struct VkAccelerationStructureNV
{
    /// <summary> The null value. </summary>
    public static readonly VkAccelerationStructureNV Null = (VkAccelerationStructureNV)null;
#pragma warning disable 649
    private readonly void* _ptr;
#pragma warning restore 649

    /// <summary> Returns a hash code for this object. </summary>
    /// <returns> A hash code for this object. </returns>
    public override int GetHashCode()
    {
        return ((IntPtr)_ptr).GetHashCode();
    }

    /// <summary> Tests if this in VkAccelerationStructureNV is considered equal to this instance. </summary>
    /// <param name="obj"> The in VkAccelerationStructureNV to compare to this instance. </param>
    /// <returns> True if the objects are considered equal, false if they are not. </returns>
    public bool Equals(in VkAccelerationStructureNV obj)
    {
        return obj._ptr == _ptr;
    }

    /// <summary> Tests if the object is considered equal to this instance. </summary>
    /// <param name="obj"> The object to compare to this instance. </param>
    /// <returns> True if the objects are considered equal, false if they are not. </returns>
    public override bool Equals(object? obj)
    {
        return obj is VkAccelerationStructureNV vkAccelerationStructureNV && Equals(in vkAccelerationStructureNV);
    }

    /// <summary> Explicit cast that converts the given void* to a VkAccelerationStructureNV. </summary>
    /// <param name="ptr"> [in,out] If non-null, the pointer. </param>
    /// <returns> The result of the operation. </returns>
    public static explicit operator VkAccelerationStructureNV(void* ptr)
    {
        VkAccelerationStructureNV value;
        *(void**)&value = ptr;
        return value;
    }

    /// <summary> Equality operator. </summary>
    /// <param name="left">  The left. </param>
    /// <param name="right"> The right. </param>
    /// <returns> The result of the operation. </returns>
    public static bool operator ==(VkAccelerationStructureNV left, VkAccelerationStructureNV right)
    {
        return left._ptr == right._ptr;
    }

    /// <summary> Inequality operator. </summary>
    /// <param name="left">  The left. </param>
    /// <param name="right"> The right. </param>
    /// <returns> The result of the operation. </returns>
    public static bool operator !=(VkAccelerationStructureNV left, VkAccelerationStructureNV right)
    {
        return left._ptr != right._ptr;
    }

    /// <summary> Explicit cast that converts the given VkAccelerationStructureNV to a void*. </summary>
    /// <param name="value"> The value. </param>
    /// <returns> The result of the operation. </returns>
    public static explicit operator void*(VkAccelerationStructureNV value)
    {
        return value._ptr;
    }
}