#region License

// Copyright (c) 2018-2020, exomia
// All rights reserved.
// 
// This source code is licensed under the BSD-style license found in the
// LICENSE file in the root directory of this source tree.

#endregion

using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Exomia.Vulkan.Api.Core
{
    using static Vk;

    /// <summary>
    ///     A vk bool 32.
    /// </summary>
    public readonly unsafe struct VkBool32
    {
#pragma warning disable 649
        private readonly uint _value;
#pragma warning restore 649
        
        /// <summary>
        ///     Implicit cast that converts the given bool to a Bool32.
        /// </summary>
        /// <param name="value"> The value. </param>
        /// <returns>
        ///     The result of the operation.
        /// </returns>
        public static implicit operator VkBool32(bool value)
        {
            VkBool32 v;
            *(uint*)&v = value ? VK_TRUE : VK_FALSE;
            return v;
        }


        /// <summary>
        ///     Implicit cast that converts the given Bool32 to a bool.
        /// </summary>
        /// <param name="value"> The value. </param>
        /// <returns>
        ///     The result of the operation.
        /// </returns>
        public static implicit operator bool(VkBool32 value)
        {
            return value._value != VK_FALSE;
        }

        /// <inheritdoc/>
        public override string ToString()
        {
            return ((bool)this).ToString();
        }
    }

    /// <summary>
    ///     Used instead of public fixed float blendConstants[4].
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct BlendConstants
    {
        /// <summary>
        ///      The R value
        /// </summary>
        public float R;

        /// <summary>
        ///      The G value
        /// </summary>
        public float G;

        /// <summary>
        ///      The B value
        /// </summary>
        public float B;

        /// <summary>
        ///      The A value
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
        ///      The A value between 0.0f and 1.0f.
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
                Debug.Assert(index < LENGTH, "Index out of range!");
                return *((float*)Unsafe.AsPointer(ref this) + index);
            }

            set
            {
                Debug.Assert(index < LENGTH, "Index out of range!");
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
                Debug.Assert(index < LENGTH, "Index out of range!");
                return *((float*)Unsafe.AsPointer(ref this) + index);
            }

            set
            {
                Debug.Assert(index < LENGTH, "Index out of range!");
                *((float*)Unsafe.AsPointer(ref this) + index) = value;
            }
        }
    }

    /// <summary>
    ///     Used instead of public fixed T[16].
    /// </summary>
    /// <typeparam name="T"> Generic type parameter. </typeparam>
    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkArray16<T> where T : unmanaged
    {
        /// <summary>
        ///     The length of <see cref="VkArray16{T}" />.
        /// </summary>
        public const uint LENGTH = 16;
#pragma warning disable 1591
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
#pragma warning restore 1591

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
                Debug.Assert(index < LENGTH, "Index out of range!");
                return *((T*)Unsafe.AsPointer(ref this) + index);
            }

            set
            {
                Debug.Assert(index < LENGTH, "Index out of range!");
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
                Debug.Assert(index < LENGTH, "Index out of range!");
                return *((T*)Unsafe.AsPointer(ref this) + index);
            }

            set
            {
                Debug.Assert(index < LENGTH, "Index out of range!");
                *((T*)Unsafe.AsPointer(ref this) + index) = value;
            }
        }
    }

    /// <summary>
    ///     List of vk physical devices.
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkPhysicalDeviceArray
    {
        /// <summary>
        ///     <see cref="VK_MAX_DEVICE_GROUP_SIZE"/>
        /// </summary>
        public const int MAX = VK_MAX_DEVICE_GROUP_SIZE;
        
#pragma warning disable 1591
        public readonly VkPhysicalDevice M01;
        public readonly VkPhysicalDevice M02;
        public readonly VkPhysicalDevice M03;
        public readonly VkPhysicalDevice M04;
        public readonly VkPhysicalDevice M05;
        public readonly VkPhysicalDevice M06;
        public readonly VkPhysicalDevice M07;
        public readonly VkPhysicalDevice M08;
        public readonly VkPhysicalDevice M09;
        public readonly VkPhysicalDevice M10;
        public readonly VkPhysicalDevice M11;
        public readonly VkPhysicalDevice M12;
        public readonly VkPhysicalDevice M13;
        public readonly VkPhysicalDevice M14;
        public readonly VkPhysicalDevice M15;
        public readonly VkPhysicalDevice M16;
        public readonly VkPhysicalDevice M17;
        public readonly VkPhysicalDevice M18;
        public readonly VkPhysicalDevice M19;
        public readonly VkPhysicalDevice M20;
        public readonly VkPhysicalDevice M21;
        public readonly VkPhysicalDevice M22;
        public readonly VkPhysicalDevice M23;
        public readonly VkPhysicalDevice M24;
        public readonly VkPhysicalDevice M25;
        public readonly VkPhysicalDevice M26;
        public readonly VkPhysicalDevice M27;
        public readonly VkPhysicalDevice M28;
        public readonly VkPhysicalDevice M29;
        public readonly VkPhysicalDevice M30;
        public readonly VkPhysicalDevice M31;
        public readonly VkPhysicalDevice M32;
#pragma warning restore 1591

        /// <summary>
        ///     Indexer to get items within this collection using array index syntax.
        /// </summary>
        /// <param name="index"> Zero-based index of the entry to access. </param>
        /// <returns>
        ///     The indexed item.
        /// </returns>
        public VkMemoryType this[int index]
        {
            get { return *((VkMemoryType*)Unsafe.AsPointer(ref this) + index); }
            //set { *((VkMemoryType*)Unsafe.AsPointer(ref this) + index) = value; }
        }

#pragma warning disable IDE0044 // Add readonly modifier
    }

    /// <summary>
    ///     A vk version.
    /// </summary>
    public readonly struct VkVersion
    {
        /// <summary>
        ///     The version 1.0.
        /// </summary>
        public static readonly VkVersion VulkanApiVersion10 = new VkVersion(1, 0, 0);

        /// <summary>
        ///     The version 1.1
        /// </summary>
        public static readonly VkVersion VulkanApiVersion11 = new VkVersion(1, 1, 0);

        /// <summary>
        ///     The version 1.2
        /// </summary>
        public static readonly VkVersion VulkanApiVersion12 = new VkVersion(1, 2, 0);

        
        private readonly uint _version;

        /// <summary>
        ///     Initializes a new instance of the <see cref="VkVersion" /> struct.
        /// </summary>
        /// <param name="major"> The major. </param>
        /// <param name="minor"> The minor. </param>
        /// <param name="patch"> The patch. </param>
        public VkVersion(uint major, uint minor, uint patch)
        {
            _version = (major << 22) | ((minor & 0x3FF) << 12) | (patch & 0xFFF);
        }

        /// <summary>
        ///     Gets the major.
        /// </summary>
        /// <value>
        ///     The major.
        /// </value>
        public uint Major
        {
            get { return _version >> 22; }
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
    }
}