#region License

// Copyright (c) 2018-2023, exomia
// All rights reserved.
// 
// This source code is licensed under the BSD-style license found in the
// LICENSE file in the root directory of this source tree.

#endregion

using System.Runtime.CompilerServices;

// ReSharper disable UnusedMember.Global
// ReSharper disable once CheckNamespace
namespace Exomia.Vulkan.Api.Core;

/// <summary> A vk device address. </summary>
public readonly unsafe struct VkDeviceAddress
{
#pragma warning disable 649
    private readonly ulong _address;
#pragma warning restore 649

    /// <summary> Returns a hash code for this object. </summary>
    /// <returns> A hash code for this object. </returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public override int GetHashCode()
    {
        return _address.GetHashCode();
    }

    /// <summary> Tests if this in VkDeviceAddress is considered equal to this instance. </summary>
    /// <param name="obj"> The in vk device address to compare to this instance. </param>
    /// <returns> True if the objects are considered equal, false if they are not. </returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public bool Equals(in VkDeviceAddress obj)
    {
        return obj._address == _address;
    }

    /// <summary> Tests if this object? is considered equal to this instance. </summary>
    /// <param name="obj"> The object? to compare to this instance. </param>
    /// <returns> True if the objects are considered equal, false if they are not. </returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public override bool Equals(object? obj)
    {
        return obj is VkDeviceAddress vkDeviceAddress && Equals(in vkDeviceAddress);
    }

    /// <summary> Convert this object into a string representation. </summary>
    /// <returns> A string that represents this object. </returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public override string ToString()
    {
        return _address.ToString();
    }

    /// <summary> Implicit cast that converts the given ulong to the VkDeviceAddress. </summary>
    /// <param name="address"> The address. </param>
    /// <returns> The result of the operation. </returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static implicit operator VkDeviceAddress(ulong address)
    {
        VkDeviceAddress value;
        *(ulong*)&value = address;
        return value;
    }

    /// <summary> Equality operator. </summary>
    /// <param name="left">  The left. </param>
    /// <param name="right"> The right. </param>
    /// <returns> The result of the operation. </returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool operator ==(VkDeviceAddress left, VkDeviceAddress right)
    {
        return left._address == right._address;
    }

    /// <summary> Inequality operator. </summary>
    /// <param name="left">  The left. </param>
    /// <param name="right"> The right. </param>
    /// <returns> The result of the operation. </returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool operator !=(VkDeviceAddress left, VkDeviceAddress right)
    {
        return left._address != right._address;
    }

    /// <summary> Implicit cast that converts the given VkDeviceAddress to an ulong. </summary>
    /// <param name="value"> The value. </param>
    /// <returns> The result of the operation. </returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static implicit operator ulong(VkDeviceAddress value)
    {
        return value._address;
    }
}