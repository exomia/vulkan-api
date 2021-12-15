﻿#region License

// Copyright (c) 2018-2021, exomia
// All rights reserved.
// 
// This source code is licensed under the BSD-style license found in the
// LICENSE file in the root directory of this source tree.

#endregion

using System.Runtime.CompilerServices;

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

// ReSharper disable UnusedMember.Global
// ReSharper disable once CheckNamespace
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
}