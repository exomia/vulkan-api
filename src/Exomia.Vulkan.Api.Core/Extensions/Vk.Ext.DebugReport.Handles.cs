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
namespace Exomia.Vulkan.Api.Core.Extensions
{
    public readonly unsafe struct VkDebugReportCallbackEXT
    {
        public static readonly VkDebugReportCallbackEXT Null = (VkDebugReportCallbackEXT)null;
#pragma warning disable 649
        private readonly void* _ptr;
#pragma warning restore 649

        public static explicit operator VkDebugReportCallbackEXT(void* ptr)
        {
            VkDebugReportCallbackEXT value;
            *(void**)&value = ptr;
            return value;
        }

        public static bool operator ==(VkDebugReportCallbackEXT left, VkDebugReportCallbackEXT right)
        {
            return left._ptr == right._ptr;
        }

        public static bool operator !=(VkDebugReportCallbackEXT left, VkDebugReportCallbackEXT right)
        {
            return left._ptr != right._ptr;
        }

        public bool Equals(in VkDebugReportCallbackEXT obj)
        {
            return obj._ptr == _ptr;
        }

        public override bool Equals(object? obj)
        {
            return obj is VkDebugReportCallbackEXT vkDebugReportCallbackEXT && Equals(in vkDebugReportCallbackEXT);
        }

        public override int GetHashCode()
        {
            return ((IntPtr)_ptr).GetHashCode();
        }

        public static explicit operator void*(VkDebugReportCallbackEXT value)
        {
            return value._ptr;
        }
    }
}