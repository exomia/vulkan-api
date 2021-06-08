#region License

// Copyright (c) 2018-2021, exomia
// All rights reserved.
// 
// This source code is licensed under the BSD-style license found in the
// LICENSE file in the root directory of this source tree.

#endregion

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

// ReSharper disable UnusedMember.Global
namespace Exomia.Vulkan.Api.Core
{
    public readonly unsafe struct VkDeviceAddress
    {
#pragma warning disable 649
        private readonly ulong _address;
#pragma warning restore 649

        public static implicit operator VkDeviceAddress(ulong address)
        {
            VkDeviceAddress value;
            *(ulong*)&value = address;
            return value;
        }

        public static bool operator ==(VkDeviceAddress left, VkDeviceAddress right)
        {
            return left._address == right._address;
        }

        public static bool operator !=(VkDeviceAddress left, VkDeviceAddress right)
        {
            return left._address != right._address;
        }

        public bool Equals(in VkDeviceAddress obj)
        {
            return obj._address == _address;
        }

        public override bool Equals(object? obj)
        {
            return obj is VkDeviceAddress vkDeviceAddress && Equals(in vkDeviceAddress);
        }

        public override int GetHashCode()
        {
            return _address.GetHashCode();
        }

        public static implicit operator ulong(VkDeviceAddress value)
        {
            return value._address;
        }

        public override string ToString()
        {
            return _address.ToString();
        }
    }

    public readonly unsafe struct VkDeviceSize
    {
#pragma warning disable 649
        private readonly ulong _size;
#pragma warning restore 649

        public static implicit operator VkDeviceSize(ulong size)
        {
            VkDeviceSize value;
            *(ulong*)&value = size;
            return value;
        }

        public static bool operator ==(VkDeviceSize left, VkDeviceSize right)
        {
            return left._size == right._size;
        }

        public static bool operator !=(VkDeviceSize left, VkDeviceSize right)
        {
            return left._size != right._size;
        }

        public bool Equals(in VkDeviceSize obj)
        {
            return obj._size == _size;
        }

        public override bool Equals(object? obj)
        {
            return obj is VkDeviceSize vkDeviceSize && Equals(in vkDeviceSize);
        }

        public override int GetHashCode()
        {
            return _size.GetHashCode();
        }

        public static implicit operator ulong(VkDeviceSize value)
        {
            return value._size;
        }

        public override string ToString()
        {
            return _size.ToString();
        }
    }
}
