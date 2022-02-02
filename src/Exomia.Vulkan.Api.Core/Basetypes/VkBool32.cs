#region License

// Copyright (c) 2018-2022, exomia
// All rights reserved.
// 
// This source code is licensed under the BSD-style license found in the
// LICENSE file in the root directory of this source tree.

#endregion

// ReSharper disable UnusedMember.Global
// ReSharper disable once CheckNamespace
namespace Exomia.Vulkan.Api.Core;

/// <summary>
///     A vk bool 32.
/// </summary>
[StructLayout(LayoutKind.Sequential)]
public readonly unsafe struct VkBool32
{
    /// <summary>
    ///     The true value.
    /// </summary>
    public static readonly VkBool32 True = VK_TRUE;

    /// <summary>
    ///     The false value.
    /// </summary>
    public static readonly VkBool32 False = VK_FALSE;

    private readonly uint _value;

    /// <inheritdoc />
    public override string ToString()
    {
        return $"{((bool)this).ToString()}";
    }

    /// <summary>
    ///     Implicit cast that converts the given uint to a VkBool32.
    /// </summary>
    /// <param name="value"> The value. </param>
    /// <returns>
    ///     The result of the operation.
    /// </returns>
    public static implicit operator VkBool32(uint value)
    {
        VkBool32 v;
        *(uint*)&v = value;
        return v;
    }

    /// <summary>
    ///     Implicit cast that converts the given uint to a VkBool32.
    /// </summary>
    /// <param name="value"> The value. </param>
    /// <returns>
    ///     The result of the operation.
    /// </returns>
    public static implicit operator uint(VkBool32 value)
    {
        return value._value;
    }

    /// <summary>
    ///     Implicit cast that converts the given uint to a VkBool32.
    /// </summary>
    /// <param name="value"> The value. </param>
    /// <returns>
    ///     The result of the operation.
    /// </returns>
    public static implicit operator VkBool32(bool value)
    {
        VkBool32 v;
        *(uint*)&v = *(uint*)&value;
        return v;
    }

    /// <summary>
    ///     Implicit cast that converts the given VkBool32 to a bool.
    /// </summary>
    /// <param name="value"> The value. </param>
    /// <returns>
    ///     The result of the operation.
    /// </returns>
    public static implicit operator bool(VkBool32 value)
    {
        return *(bool*)&value;
    }
}