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
///     Used instead of public fixed T[128].
/// </summary>
[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkArray128<T>
    where T : unmanaged
{
    /// <summary>
    ///     The length of <see cref="VkArray128{T}" />.
    /// </summary>
    public const uint LENGTH = 128;

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
    public T M001;
    public T M002;
    public T M003;
    public T M004;
    public T M005;
    public T M006;
    public T M007;
    public T M008;
    public T M009;
    public T M010;
    public T M011;
    public T M012;
    public T M013;
    public T M014;
    public T M015;
    public T M016;
    public T M017;
    public T M018;
    public T M019;
    public T M020;
    public T M021;
    public T M022;
    public T M023;
    public T M024;
    public T M025;
    public T M026;
    public T M027;
    public T M028;
    public T M029;
    public T M030;
    public T M031;
    public T M032;
    public T M033;
    public T M034;
    public T M035;
    public T M036;
    public T M037;
    public T M038;
    public T M039;
    public T M040;
    public T M041;
    public T M042;
    public T M043;
    public T M044;
    public T M045;
    public T M046;
    public T M047;
    public T M048;
    public T M049;
    public T M050;
    public T M051;
    public T M052;
    public T M053;
    public T M054;
    public T M055;
    public T M056;
    public T M057;
    public T M058;
    public T M059;
    public T M060;
    public T M061;
    public T M062;
    public T M063;
    public T M064;
    public T M065;
    public T M066;
    public T M067;
    public T M068;
    public T M069;
    public T M070;
    public T M071;
    public T M072;
    public T M073;
    public T M074;
    public T M075;
    public T M076;
    public T M077;
    public T M078;
    public T M079;
    public T M080;
    public T M081;
    public T M082;
    public T M083;
    public T M084;
    public T M085;
    public T M086;
    public T M087;
    public T M088;
    public T M089;
    public T M090;
    public T M091;
    public T M092;
    public T M093;
    public T M094;
    public T M095;
    public T M096;
    public T M097;
    public T M098;
    public T M099;
    public T M100;
    public T M101;
    public T M102;
    public T M103;
    public T M104;
    public T M105;
    public T M106;
    public T M107;
    public T M108;
    public T M109;
    public T M110;
    public T M111;
    public T M112;
    public T M113;
    public T M114;
    public T M115;
    public T M116;
    public T M117;
    public T M118;
    public T M119;
    public T M120;
    public T M121;
    public T M122;
    public T M123;
    public T M124;
#pragma warning restore 1591 //Missing XML comment for publicly visible type or member
}