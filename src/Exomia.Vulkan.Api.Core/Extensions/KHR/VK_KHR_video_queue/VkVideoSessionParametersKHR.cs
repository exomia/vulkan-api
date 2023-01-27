#region License

// Copyright (c) 2018-2023, exomia
// All rights reserved.
// 
// This source code is licensed under the BSD-style license found in the
// LICENSE file in the root directory of this source tree.

#endregion

// ReSharper disable UnusedMember.Global
// ReSharper disable once CheckNamespace
namespace Exomia.Vulkan.Api.Core;

/// <summary>
///     VkVideoSessionParametersKHR - Opaque handle to a video session parameters object -
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkVideoSessionParametersKHR.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkVideoSessionParametersKHR.html</a>
/// </summary>
public readonly unsafe struct VkVideoSessionParametersKHR
{
    /// <summary> The null value. </summary>
    public static readonly VkVideoSessionParametersKHR Null = (VkVideoSessionParametersKHR)null;
#pragma warning disable 649
    private readonly void* _ptr;
#pragma warning restore 649

    /// <summary> Returns a hash code for this object. </summary>
    /// <returns> A hash code for this object. </returns>
    public override int GetHashCode()
    {
        return ((IntPtr)_ptr).GetHashCode();
    }

    /// <summary> Tests if this in VkVideoSessionParametersKHR is considered equal to this instance. </summary>
    /// <param name="obj"> The in VkVideoSessionParametersKHR to compare to this instance. </param>
    /// <returns> True if the objects are considered equal, false if they are not. </returns>
    public bool Equals(in VkVideoSessionParametersKHR obj)
    {
        return obj._ptr == _ptr;
    }

    /// <summary> Tests if the object is considered equal to this instance. </summary>
    /// <param name="obj"> The object to compare to this instance. </param>
    /// <returns> True if the objects are considered equal, false if they are not. </returns>
    public override bool Equals(object? obj)
    {
        return obj is VkVideoSessionParametersKHR vkVideoSessionParametersKHR && Equals(in vkVideoSessionParametersKHR);
    }

    /// <summary> Explicit cast that converts the given void* to a VkVideoSessionParametersKHR. </summary>
    /// <param name="ptr"> [in,out] If non-null, the pointer. </param>
    /// <returns> The result of the operation. </returns>
    public static explicit operator VkVideoSessionParametersKHR(void* ptr)
    {
        VkVideoSessionParametersKHR value;
        *(void**)&value = ptr;
        return value;
    }

    /// <summary> Equality operator. </summary>
    /// <param name="left">  The left. </param>
    /// <param name="right"> The right. </param>
    /// <returns> The result of the operation. </returns>
    public static bool operator ==(VkVideoSessionParametersKHR left, VkVideoSessionParametersKHR right)
    {
        return left._ptr == right._ptr;
    }

    /// <summary> Inequality operator. </summary>
    /// <param name="left">  The left. </param>
    /// <param name="right"> The right. </param>
    /// <returns> The result of the operation. </returns>
    public static bool operator !=(VkVideoSessionParametersKHR left, VkVideoSessionParametersKHR right)
    {
        return left._ptr != right._ptr;
    }

    /// <summary> Explicit cast that converts the given VkVideoSessionParametersKHR to a void*. </summary>
    /// <param name="value"> The value. </param>
    /// <returns> The result of the operation. </returns>
    public static explicit operator void*(VkVideoSessionParametersKHR value)
    {
        return value._ptr;
    }
}