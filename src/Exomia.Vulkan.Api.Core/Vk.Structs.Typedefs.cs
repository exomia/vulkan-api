#region License

// Copyright (c) 2018-2021, exomia
// All rights reserved.
// 
// This source code is licensed under the BSD-style license found in the
// LICENSE file in the root directory of this source tree.

#endregion

using System.Runtime.CompilerServices;

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

// ReSharper disable UnusedMember.Global
namespace Exomia.Vulkan.Api.Core
{
    public readonly unsafe struct VkDeviceAddress
    {
#pragma warning disable 649
        private readonly ulong _address;
#pragma warning restore 649

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator VkDeviceAddress(ulong address)
        {
            VkDeviceAddress value;
            *(ulong*)&value = address;
            return value;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator ==(VkDeviceAddress left, VkDeviceAddress right)
        {
            return left._address == right._address;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator !=(VkDeviceAddress left, VkDeviceAddress right)
        {
            return left._address != right._address;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Equals(in VkDeviceAddress obj)
        {
            return obj._address == _address;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override bool Equals(object? obj)
        {
            return obj is VkDeviceAddress vkDeviceAddress && Equals(in vkDeviceAddress);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override int GetHashCode()
        {
            return _address.GetHashCode();
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator ulong(VkDeviceAddress value)
        {
            return value._address;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override string ToString()
        {
            return _address.ToString();
        }
    }

    public readonly unsafe struct VkDeviceSize
    {
        public static readonly VkDeviceSize Zero = 0ul;
#pragma warning disable 649
        private readonly ulong _size;
#pragma warning restore 649

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator VkDeviceSize(ulong size)
        {
            VkDeviceSize value;
            *(ulong*)&value = size;
            return value;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator VkDeviceSize(long size)
        {
            VkDeviceSize value;
            *(long*)&value = size;
            return value;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator ==(VkDeviceSize left, VkDeviceSize right)
        {
            return left._size == right._size;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator !=(VkDeviceSize left, VkDeviceSize right)
        {
            return left._size != right._size;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator ==(VkDeviceSize left, ulong right)
        {
            return left._size == right;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator !=(VkDeviceSize left, ulong right)
        {
            return left._size != right;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator ==(VkDeviceSize left, long right)
        {
            return left._size == (ulong)right;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator !=(VkDeviceSize left, long right)
        {
            return left._size != (ulong)right;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator >=(VkDeviceSize left, VkDeviceSize right)
        {
            return left._size >= right._size;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator <=(VkDeviceSize left, VkDeviceSize right)
        {
            return left._size <= right._size;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator >=(VkDeviceSize left, ulong right)
        {
            return left._size >= right;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator <=(VkDeviceSize left, ulong right)
        {
            return left._size <= right;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator >=(VkDeviceSize left, long right)
        {
            return left._size >= (ulong)right;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator <=(VkDeviceSize left, long right)
        {
            return left._size < (ulong)right;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator >(VkDeviceSize left, VkDeviceSize right)
        {
            return left._size > right._size;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator <(VkDeviceSize left, VkDeviceSize right)
        {
            return left._size < right._size;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator >(VkDeviceSize left, ulong right)
        {
            return left._size > right;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator <(VkDeviceSize left, ulong right)
        {
            return left._size < right;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator >(VkDeviceSize left, long right)
        {
            return left._size > (ulong)right;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator <(VkDeviceSize left, long right)
        {
            return left._size < (ulong)right;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkDeviceSize operator +(VkDeviceSize left, VkDeviceSize right)
        {
            return left._size + right._size;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkDeviceSize operator -(VkDeviceSize left, VkDeviceSize right)
        {
            return left._size - right._size;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkDeviceSize operator +(VkDeviceSize left, ulong right)
        {
            return left._size + right;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkDeviceSize operator -(VkDeviceSize left, ulong right)
        {
            return left._size - right;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkDeviceSize operator +(VkDeviceSize left, long right)
        {
            return left._size + (ulong)right;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkDeviceSize operator -(VkDeviceSize left, long right)
        {
            return left._size - (ulong)right;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkDeviceSize operator *(VkDeviceSize left, VkDeviceSize right)
        {
            return left._size * right._size;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkDeviceSize operator /(VkDeviceSize left, VkDeviceSize right)
        {
            return left._size / right._size;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkDeviceSize operator *(VkDeviceSize left, ulong right)
        {
            return left._size * right;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkDeviceSize operator /(VkDeviceSize left, ulong right)
        {
            return left._size / right;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkDeviceSize operator *(VkDeviceSize left, long right)
        {
            return left._size * (ulong)right;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkDeviceSize operator /(VkDeviceSize left, long right)
        {
            return left._size / (ulong)right;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Equals(in VkDeviceSize obj)
        {
            return obj._size == _size;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override bool Equals(object? obj)
        {
            return obj is VkDeviceSize vkDeviceSize && Equals(in vkDeviceSize);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override int GetHashCode()
        {
            return _size.GetHashCode();
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator ulong(VkDeviceSize value)
        {
            return value._size;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator uint(VkDeviceSize value)
        {
            return (uint)value._size;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override string ToString()
        {
            return _size.ToString();
        }
    }
}