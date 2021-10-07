#region License

// Copyright (c) 2018-2021, exomia
// All rights reserved.
// 
// This source code is licensed under the BSD-style license found in the
// LICENSE file in the root directory of this source tree.

#endregion

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

using System;

// ReSharper disable UnusedMember.Global
// ReSharper disable once CheckNamespace
namespace Exomia.Vulkan.Api.Core
{
    public readonly unsafe struct VkSwapchainKHR
    {
        public static readonly VkSwapchainKHR Null = (VkSwapchainKHR)null;
#pragma warning disable 649
        private readonly void* _ptr;
#pragma warning restore 649

        public static explicit operator VkSwapchainKHR(void* ptr)
        {
            VkSwapchainKHR value;
            *(void**)&value = ptr;
            return value;
        }

        public static bool operator ==(VkSwapchainKHR left, VkSwapchainKHR right)
        {
            return left._ptr == right._ptr;
        }

        public static bool operator !=(VkSwapchainKHR left, VkSwapchainKHR right)
        {
            return left._ptr != right._ptr;
        }

        public bool Equals(in VkSwapchainKHR obj)
        {
            return obj._ptr == _ptr;
        }

        public override bool Equals(object? obj)
        {
            return obj is VkSwapchainKHR vkSwapchainKHR && Equals(in vkSwapchainKHR);
        }

        public override int GetHashCode()
        {
            return ((IntPtr)_ptr).GetHashCode();
        }

        public static explicit operator void*(VkSwapchainKHR value)
        {
            return value._ptr;
        }
    }
}