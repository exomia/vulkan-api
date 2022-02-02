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
///     Used instead of public fixed T[3].
/// </summary>
/// <typeparam name="T"> Generic type parameter. </typeparam>
[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkArray3<T>
    where T : unmanaged
{
    /// <summary>
    ///     The length of <see cref="VkArray3{T}" />.
    /// </summary>
    public const uint LENGTH = 3;

    /// <summary>
    ///     Indexer to get or set items within this collection using array index syntax.
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
    ///     Indexer to get or set items within this collection using array index syntax.
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
#pragma warning restore 1591 //Missing XML comment for publicly visible type or member
}