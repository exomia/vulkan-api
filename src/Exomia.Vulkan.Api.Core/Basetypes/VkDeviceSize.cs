#region License

// Copyright (c) 2018-2022, exomia
// All rights reserved.
// 
// This source code is licensed under the BSD-style license found in the
// LICENSE file in the root directory of this source tree.

#endregion

using System.Runtime.CompilerServices;

// ReSharper disable UnusedMember.Global
// ReSharper disable once CheckNamespace
namespace Exomia.Vulkan.Api.Core;

/// <summary> A vk device size. </summary>
public readonly unsafe struct VkDeviceSize
{
    /// <summary> The zero. </summary>
    public static readonly VkDeviceSize Zero = 0ul;

#pragma warning disable 649
    private readonly ulong _size;
#pragma warning restore 649

    /// <summary> Returns a hash code for this object. </summary>
    /// <returns> A hash code for this object. </returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public override int GetHashCode()
    {
        return _size.GetHashCode();
    }

    /// <summary> Tests if this in VkDeviceSize is considered equal to this instance. </summary>
    /// <param name="obj"> The in vk device size to compare to this instance. </param>
    /// <returns> True if the objects are considered equal, false if they are not. </returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public bool Equals(in VkDeviceSize obj)
    {
        return obj._size == _size;
    }

    /// <summary> Tests if this object? is considered equal to this instance. </summary>
    /// <param name="obj"> The object? to compare to this instance. </param>
    /// <returns> True if the objects are considered equal, false if they are not. </returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public override bool Equals(object? obj)
    {
        return obj is VkDeviceSize vkDeviceSize && Equals(in vkDeviceSize);
    }

    /// <summary> Convert this object into a string representation. </summary>
    /// <returns> A string that represents this object. </returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public override string ToString()
    {
        return _size.ToString();
    }

    /// <summary> Implicit cast that converts the given ulong to a VkDeviceSize. </summary>
    /// <param name="size"> The size. </param>
    /// <returns> The result of the operation. </returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static implicit operator VkDeviceSize(ulong size)
    {
        VkDeviceSize value;
        *(ulong*)&value = size;
        return value;
    }

    /// <summary> Explicit cast that converts the given long to a VkDeviceSize. </summary>
    /// <param name="size"> The size. </param>
    /// <returns> The result of the operation. </returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static explicit operator VkDeviceSize(long size)
    {
        VkDeviceSize value;
        *(long*)&value = size;
        return value;
    }

    /// <summary> Equality operator. </summary>
    /// <param name="left">  The left. </param>
    /// <param name="right"> The right. </param>
    /// <returns> The result of the operation. </returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool operator ==(VkDeviceSize left, VkDeviceSize right)
    {
        return left._size == right._size;
    }

    /// <summary> Inequality operator. </summary>
    /// <param name="left">  The left. </param>
    /// <param name="right"> The right. </param>
    /// <returns> The result of the operation. </returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool operator !=(VkDeviceSize left, VkDeviceSize right)
    {
        return left._size != right._size;
    }

    /// <summary> Equality operator. </summary>
    /// <param name="left">  The left. </param>
    /// <param name="right"> The right. </param>
    /// <returns> The result of the operation. </returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool operator ==(VkDeviceSize left, ulong right)
    {
        return left._size == right;
    }

    /// <summary> Inequality operator. </summary>
    /// <param name="left">  The left. </param>
    /// <param name="right"> The right. </param>
    /// <returns> The result of the operation. </returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool operator !=(VkDeviceSize left, ulong right)
    {
        return left._size != right;
    }

    /// <summary> Equality operator. </summary>
    /// <param name="left">  The left. </param>
    /// <param name="right"> The right. </param>
    /// <returns> The result of the operation. </returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool operator ==(VkDeviceSize left, long right)
    {
        return left._size == (ulong)right;
    }

    /// <summary> Inequality operator. </summary>
    /// <param name="left">  The left. </param>
    /// <param name="right"> The right. </param>
    /// <returns> The result of the operation. </returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool operator !=(VkDeviceSize left, long right)
    {
        return left._size != (ulong)right;
    }

    /// <summary> Greater-than-or-equal comparison operator. </summary>
    /// <param name="left">  The left. </param>
    /// <param name="right"> The right. </param>
    /// <returns> The result of the operation. </returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool operator >=(VkDeviceSize left, VkDeviceSize right)
    {
        return left._size >= right._size;
    }

    /// <summary> Less-than-or-equal comparison operator. </summary>
    /// <param name="left">  The left. </param>
    /// <param name="right"> The right. </param>
    /// <returns> The result of the operation. </returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool operator <=(VkDeviceSize left, VkDeviceSize right)
    {
        return left._size <= right._size;
    }

    /// <summary> Greater-than-or-equal comparison operator. </summary>
    /// <param name="left">  The left. </param>
    /// <param name="right"> The right. </param>
    /// <returns> The result of the operation. </returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool operator >=(VkDeviceSize left, ulong right)
    {
        return left._size >= right;
    }

    /// <summary> Less-than-or-equal comparison operator. </summary>
    /// <param name="left">  The left. </param>
    /// <param name="right"> The right. </param>
    /// <returns> The result of the operation. </returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool operator <=(VkDeviceSize left, ulong right)
    {
        return left._size <= right;
    }

    /// <summary> Greater-than-or-equal comparison operator. </summary>
    /// <param name="left">  The left. </param>
    /// <param name="right"> The right. </param>
    /// <returns> The result of the operation. </returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool operator >=(VkDeviceSize left, long right)
    {
        return left._size >= (ulong)right;
    }

    /// <summary> Less-than-or-equal comparison operator. </summary>
    /// <param name="left">  The left. </param>
    /// <param name="right"> The right. </param>
    /// <returns> The result of the operation. </returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool operator <=(VkDeviceSize left, long right)
    {
        return left._size < (ulong)right;
    }

    /// <summary> Greater-than comparison operator. </summary>
    /// <param name="left">  The left. </param>
    /// <param name="right"> The right. </param>
    /// <returns> The result of the operation. </returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool operator >(VkDeviceSize left, VkDeviceSize right)
    {
        return left._size > right._size;
    }

    /// <summary> Less-than comparison operator. </summary>
    /// <param name="left">  The left. </param>
    /// <param name="right"> The right. </param>
    /// <returns> The result of the operation. </returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool operator <(VkDeviceSize left, VkDeviceSize right)
    {
        return left._size < right._size;
    }

    /// <summary> Greater-than comparison operator. </summary>
    /// <param name="left">  The left. </param>
    /// <param name="right"> The right. </param>
    /// <returns> The result of the operation. </returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool operator >(VkDeviceSize left, ulong right)
    {
        return left._size > right;
    }

    /// <summary> Less-than comparison operator. </summary>
    /// <param name="left">  The left. </param>
    /// <param name="right"> The right. </param>
    /// <returns> The result of the operation. </returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool operator <(VkDeviceSize left, ulong right)
    {
        return left._size < right;
    }

    /// <summary> Greater-than comparison operator. </summary>
    /// <param name="left">  The left. </param>
    /// <param name="right"> The right. </param>
    /// <returns> The result of the operation. </returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool operator >(VkDeviceSize left, long right)
    {
        return left._size > (ulong)right;
    }

    /// <summary> Less-than comparison operator. </summary>
    /// <param name="left">  The left. </param>
    /// <param name="right"> The right. </param>
    /// <returns> The result of the operation. </returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool operator <(VkDeviceSize left, long right)
    {
        return left._size < (ulong)right;
    }

    /// <summary> Addition operator. </summary>
    /// <param name="left">  The left. </param>
    /// <param name="right"> The right. </param>
    /// <returns> The result of the operation. </returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static VkDeviceSize operator +(VkDeviceSize left, VkDeviceSize right)
    {
        return left._size + right._size;
    }

    /// <summary> Subtraction operator. </summary>
    /// <param name="left">  The left. </param>
    /// <param name="right"> The right. </param>
    /// <returns> The result of the operation. </returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static VkDeviceSize operator -(VkDeviceSize left, VkDeviceSize right)
    {
        return left._size - right._size;
    }

    /// <summary> Addition operator. </summary>
    /// <param name="left">  The left. </param>
    /// <param name="right"> The right. </param>
    /// <returns> The result of the operation. </returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static VkDeviceSize operator +(VkDeviceSize left, ulong right)
    {
        return left._size + right;
    }

    /// <summary> Subtraction operator. </summary>
    /// <param name="left">  The left. </param>
    /// <param name="right"> The right. </param>
    /// <returns> The result of the operation. </returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static VkDeviceSize operator -(VkDeviceSize left, ulong right)
    {
        return left._size - right;
    }

    /// <summary> Addition operator. </summary>
    /// <param name="left">  The left. </param>
    /// <param name="right"> The right. </param>
    /// <returns> The result of the operation. </returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static VkDeviceSize operator +(VkDeviceSize left, long right)
    {
        return left._size + (ulong)right;
    }

    /// <summary> Subtraction operator. </summary>
    /// <param name="left">  The left. </param>
    /// <param name="right"> The right. </param>
    /// <returns> The result of the operation. </returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static VkDeviceSize operator -(VkDeviceSize left, long right)
    {
        return left._size - (ulong)right;
    }

    /// <summary> Multiplication operator. </summary>
    /// <param name="left">  The left. </param>
    /// <param name="right"> The right. </param>
    /// <returns> The result of the operation. </returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static VkDeviceSize operator *(VkDeviceSize left, VkDeviceSize right)
    {
        return left._size * right._size;
    }

    /// <summary> Division operator. </summary>
    /// <param name="left">  The left. </param>
    /// <param name="right"> The right. </param>
    /// <returns> The result of the operation. </returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static VkDeviceSize operator /(VkDeviceSize left, VkDeviceSize right)
    {
        return left._size / right._size;
    }

    /// <summary> Multiplication operator. </summary>
    /// <param name="left">  The left. </param>
    /// <param name="right"> The right. </param>
    /// <returns> The result of the operation. </returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static VkDeviceSize operator *(VkDeviceSize left, ulong right)
    {
        return left._size * right;
    }

    /// <summary> Division operator. </summary>
    /// <param name="left">  The left. </param>
    /// <param name="right"> The right. </param>
    /// <returns> The result of the operation. </returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static VkDeviceSize operator /(VkDeviceSize left, ulong right)
    {
        return left._size / right;
    }

    /// <summary> Multiplication operator. </summary>
    /// <param name="left">  The left. </param>
    /// <param name="right"> The right. </param>
    /// <returns> The result of the operation. </returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static VkDeviceSize operator *(VkDeviceSize left, long right)
    {
        return left._size * (ulong)right;
    }

    /// <summary> Division operator. </summary>
    /// <param name="left">  The left. </param>
    /// <param name="right"> The right. </param>
    /// <returns> The result of the operation. </returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static VkDeviceSize operator /(VkDeviceSize left, long right)
    {
        return left._size / (ulong)right;
    }

    /// <summary> Implicit cast that converts the given VkDeviceSize to an ulong. </summary>
    /// <param name="value"> The value. </param>
    /// <returns> The result of the operation. </returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static implicit operator ulong(VkDeviceSize value)
    {
        return value._size;
    }

    /// <summary> Implicit cast that converts the given VkDeviceSize to an uint. </summary>
    /// <param name="value"> The value. </param>
    /// <returns> The result of the operation. </returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static implicit operator uint(VkDeviceSize value)
    {
        return (uint)value._size;
    }
}