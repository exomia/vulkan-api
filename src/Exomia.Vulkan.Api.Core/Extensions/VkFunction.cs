#region License

// Copyright (c) 2018-2021, exomia
// All rights reserved.
// 
// This source code is licensed under the BSD-style license found in the
// LICENSE file in the root directory of this source tree.

#endregion

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

// ReSharper disable UnusedMember.Global
// ReSharper disable UnassignedReadonlyField
namespace Exomia.Vulkan.Api.Core.Extensions;

[VkFunctionGenerator]
[StructLayout(LayoutKind.Explicit)]
public readonly unsafe partial struct VkFunction
{
    public static readonly VkFunction Null = null;

    [FieldOffset(0)]
    private readonly void* _ptr;

    public static implicit operator VkFunction(void* ptr)
    {
        VkFunction value;
        *(void**)&value = ptr;
        return value;
    }

    public static implicit operator void*(VkFunction vkFunc)
    {
        return vkFunc._ptr;
    }

    public static implicit operator IntPtr(VkFunction vkFunc)
    {
        return (IntPtr)vkFunc._ptr;
    }

    public static bool operator ==(VkFunction left, VkFunction right)
    {
        return left._ptr == right._ptr;
    }

    public static bool operator !=(VkFunction left, VkFunction right)
    {
        return left._ptr != right._ptr;
    }

    public bool Equals(in VkFunction obj)
    {
        return obj._ptr == _ptr;
    }

    public override bool Equals(object? obj)
    {
        return obj is VkFunction vkFunction && Equals(in vkFunction);
    }

    public override int GetHashCode()
    {
        return ((IntPtr)_ptr).GetHashCode();
    }
}