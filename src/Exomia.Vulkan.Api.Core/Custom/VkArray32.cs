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
///     Used instead of public fixed T[32].
/// </summary>
[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkArray32<T>
    where T : unmanaged
{
    /// <summary>
    ///     The length of <see cref="VkArray32{T}" />.
    /// </summary>
    public const uint LENGTH = 32;

    /// <summary>
    ///     Indexer to get items within this collection using array index syntax.
    /// </summary>
    /// <param name="index"> Zero-based index of the entry to access. </param>
    /// <returns>
    ///     The indexed item.
    /// </returns>
    public T this[uint index]
    {
        get
        {
#if DEBUG
            if (index >= LENGTH) { throw new ArgumentOutOfRangeException(nameof(index)); }
#endif
            return *((T*)Unsafe.AsPointer(ref this) + index);
        }
        set
        {
#if DEBUG
            if (index >= LENGTH) { throw new ArgumentOutOfRangeException(nameof(index)); }
#endif
            *((T*)Unsafe.AsPointer(ref this) + index) = value;
        }
    }

    /// <summary>
    ///     Indexer to get items within this collection using array index syntax.
    /// </summary>
    /// <param name="index"> Zero-based index of the entry to access. </param>
    /// <returns>
    ///     The indexed item.
    /// </returns>
    public T this[int index]
    {
        get
        {
#if DEBUG
            if (index >= LENGTH || index < 0) { throw new ArgumentOutOfRangeException(nameof(index)); }
#endif
            return *((T*)Unsafe.AsPointer(ref this) + index);
        }
        set
        {
#if DEBUG
            if (index >= LENGTH || index < 0) { throw new ArgumentOutOfRangeException(nameof(index)); }
#endif
            *((T*)Unsafe.AsPointer(ref this) + index) = value;
        }
    }

#pragma warning disable 1591 //Missing XML comment for publicly visible type or member
    public T M01;
    public T M02;
    public T M03;
    public T M04;
    public T M05;
    public T M06;
    public T M07;
    public T M08;
    public T M09;
    public T M10;
    public T M11;
    public T M12;
    public T M13;
    public T M14;
    public T M15;
    public T M16;
    public T M17;
    public T M18;
    public T M19;
    public T M20;
    public T M21;
    public T M22;
    public T M23;
    public T M24;
    public T M25;
    public T M26;
    public T M27;
    public T M28;
    public T M29;
    public T M30;
    public T M31;
    public T M32;
#pragma warning restore 1591 //Missing XML comment for publicly visible type or member
}