#region License

// Copyright (c) 2018-2021, exomia
// All rights reserved.
// 
// This source code is licensed under the BSD-style license found in the
// LICENSE file in the root directory of this source tree.

#endregion

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Exomia.Vulkan.Api.Core
{
    /// <summary>
    ///     A vk bool 32.
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public readonly unsafe struct VkBool32
    {
        /// <summary>
        ///     The true value.
        /// </summary>
        public static readonly VkBool32 True = Vk.VK_TRUE;

        /// <summary>
        ///     The false value.
        /// </summary>
        public static readonly VkBool32 False = Vk.VK_FALSE;

        private readonly uint _value;

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

        /// <inheritdoc />
        public override string ToString()
        {
            return $"{((bool)this).ToString()}";
        }
    }

    /// <summary>
    ///     Used instead of public fixed float blendConstants[4].
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct BlendConstants
    {
        /// <summary>
        ///     The R value
        /// </summary>
        public float R;

        /// <summary>
        ///     The G value
        /// </summary>
        public float G;

        /// <summary>
        ///     The B value
        /// </summary>
        public float B;

        /// <summary>
        ///     The A value
        /// </summary>
        public float A;
    }

    /// <summary>
    ///     used instead of public fixed float color[4];
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkColor
    {
        /// <summary>
        ///     The length of <see cref="VkColor" />.
        /// </summary>
        public const uint LENGTH = 4;

        /// <summary>
        ///     The R value between 0.0f and 1.0f.
        /// </summary>
        public float R;

        /// <summary>
        ///     The G value between 0.0f and 1.0f.
        /// </summary>
        public float G;

        /// <summary>
        ///     The B value between 0.0f and 1.0f.
        /// </summary>
        public float B;

        /// <summary>
        ///     The A value between 0.0f and 1.0f.
        /// </summary>
        public float A;

        /// <summary>
        ///     Indexer to get or set items within this collection using array index syntax.
        /// </summary>
        /// <param name="index"> Zero-based index of the entry to access. </param>
        /// <returns>
        ///     The indexed item.
        /// </returns>
        public float this[uint index]
        {
            get
            {
#if DEBUG
                if (index >= LENGTH) { throw new ArgumentOutOfRangeException(nameof(index)); }
#endif
                return *((float*)Unsafe.AsPointer(ref this) + index);
            }

            set
            {
#if DEBUG
                if (index >= LENGTH) { throw new ArgumentOutOfRangeException(nameof(index)); }
#endif
                *((float*)Unsafe.AsPointer(ref this) + index) = value;
            }
        }

        /// <summary>
        ///     Indexer to get or set items within this collection using array index syntax.
        /// </summary>
        /// <param name="index"> Zero-based index of the entry to access. </param>
        /// <returns>
        ///     The indexed item.
        /// </returns>
        public float this[int index]
        {
            get
            {
#if DEBUG
                if (index >= LENGTH || index < 0) { throw new ArgumentOutOfRangeException(nameof(index)); }
#endif
                return *((float*)Unsafe.AsPointer(ref this) + index);
            }

            set
            {
#if DEBUG
                if (index >= LENGTH || index < 0) { throw new ArgumentOutOfRangeException(nameof(index)); }
#endif
                *((float*)Unsafe.AsPointer(ref this) + index) = value;
            }
        }
    }

    /// <summary>
    ///     Used instead of public fixed T[16].
    /// </summary>
    /// <typeparam name="T"> Generic type parameter. </typeparam>
    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkArray16<T>
        where T : unmanaged
    {
        /// <summary>
        ///     The length of <see cref="VkArray16{T}" />.
        /// </summary>
        public const uint LENGTH = 16;

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
#pragma warning restore 1591 //Missing XML comment for publicly visible type or member

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
    }

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
    }

    /// <summary>
    ///     A vk version.
    /// </summary>
    public readonly struct VkVersion
    {
        /// <summary>
        ///     The version 1.0.
        /// </summary>
        public static readonly VkVersion VulkanApiVersion10 = new VkVersion(0, 1, 0, 0);

        /// <summary>
        ///     The version 1.1
        /// </summary>
        public static readonly VkVersion VulkanApiVersion11 = new VkVersion(0, 1, 1, 0);

        /// <summary>
        ///     The version 1.2
        /// </summary>
        public static readonly VkVersion VulkanApiVersion12 = new VkVersion(0, 1, 2, 0);

        private readonly uint _version;

        internal VkVersion(uint version)
        {
            _version = version;
        }

        /// <summary>
        ///     Initializes a new instance of the <see cref="VkVersion" /> struct.
        /// </summary>
        /// <param name="variant"> The variant. </param>
        /// <param name="major"> The major. </param>
        /// <param name="minor"> The minor. </param>
        /// <param name="patch"> The patch. </param>
        public VkVersion(uint variant, uint major, uint minor, uint patch)
            : this((variant << 29) | ((major & 0x7FU) << 22) | ((minor & 0x3FFU) << 12) | (patch & 0xFFFU)) { }

        /// <summary>
        ///     Gets the major.
        /// </summary>
        /// <value>
        ///     The major.
        /// </value>
        public uint Variant
        {
            get { return _version >> 29; }
        }

        /// <summary>
        ///     Gets the major.
        /// </summary>
        /// <value>
        ///     The major.
        /// </value>
        public uint Major
        {
            get { return (_version >> 22) & 0x7FU; }
        }

        /// <summary>
        ///     Gets the minor.
        /// </summary>
        /// <value>
        ///     The minor.
        /// </value>
        public uint Minor
        {
            get { return (_version >> 12) & 0x3FF; }
        }

        /// <summary>
        ///     Gets the patch.
        /// </summary>
        /// <value>
        ///     The patch.
        /// </value>
        public uint Patch
        {
            get { return _version & 0xFFF; }
        }

        /// <inheritdoc />
        public override string ToString()
        {
            return $"{Major.ToString()}.{Minor.ToString()}.{Patch.ToString()}";
        }

        /// <summary>
        ///     Tests if this VkVersion is considered equal to another.
        /// </summary>
        /// <param name="other"> The vk version to compare to this object. </param>
        /// <returns>
        ///     True if the objects are considered equal, false if they are not.
        /// </returns>
        public bool Equals(VkVersion other)
        {
            return _version == other._version;
        }

        /// <inheritdoc />
        public override bool Equals(object? obj)
        {
            return obj is VkVersion other && Equals(other);
        }

        /// <inheritdoc />
        public override int GetHashCode()
        {
            return (int)_version;
        }

        /// <summary>
        ///     Equality operator.
        /// </summary>
        /// <param name="a"> The first instance to compare. </param>
        /// <param name="b"> The second instance to compare. </param>
        /// <returns>
        ///     The result of the operation.
        /// </returns>
        public static bool operator ==(VkVersion a, VkVersion b)
        {
            return a._version == b._version;
        }

        /// <summary>
        ///     Inequality operator.
        /// </summary>
        /// <param name="a"> The first instance to compare. </param>
        /// <param name="b"> The second instance to compare. </param>
        /// <returns>
        ///     The result of the operation.
        /// </returns>
        public static bool operator !=(VkVersion a, VkVersion b)
        {
            return a._version != b._version;
        }

        /// <summary>
        ///     Less-than comparison operator.
        /// </summary>
        /// <param name="a"> The first instance to compare. </param>
        /// <param name="b"> The second instance to compare. </param>
        /// <returns>
        ///     The result of the operation.
        /// </returns>
        public static bool operator <(VkVersion a, VkVersion b)
        {
            return a._version < b._version;
        }

        /// <summary>
        ///     Greater-than comparison operator.
        /// </summary>
        /// <param name="a"> The first instance to compare. </param>
        /// <param name="b"> The second instance to compare. </param>
        /// <returns>
        ///     The result of the operation.
        /// </returns>
        public static bool operator >(VkVersion a, VkVersion b)
        {
            return a._version > b._version;
        }

        /// <summary>
        ///     Less-than-or-equal comparison operator.
        /// </summary>
        /// <param name="a"> The first instance to compare. </param>
        /// <param name="b"> The second instance to compare. </param>
        /// <returns>
        ///     The result of the operation.
        /// </returns>
        public static bool operator <=(VkVersion a, VkVersion b)
        {
            return a._version <= b._version;
        }

        /// <summary>
        ///     Greater-than-or-equal comparison operator.
        /// </summary>
        /// <param name="a"> The first instance to compare. </param>
        /// <param name="b"> The second instance to compare. </param>
        /// <returns>
        ///     The result of the operation.
        /// </returns>
        public static bool operator >=(VkVersion a, VkVersion b)
        {
            return a._version >= b._version;
        }
    }
}