#region License

// Copyright (c) 2018-2024, exomia
// All rights reserved.
// 
// This source code is licensed under the BSD-style license found in the
// LICENSE file in the root directory of this source tree.

#endregion

// ReSharper disable UnusedMember.Global
// ReSharper disable once CheckNamespace
namespace Exomia.Vulkan.Api.Core;

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

    /// <summary> Initializes a new instance of the <see cref="VkColor" /> struct. </summary>
    /// <param name="r"> The R value between 0.0f and 1.0f. </param>
    /// <param name="g"> The G value between 0.0f and 1.0f. </param>
    /// <param name="b"> The B value between 0.0f and 1.0f. </param>
    /// <param name="a"> (Optional) The A value between 0.0f and 1.0f. </param>
    public VkColor(float r, float g, float b, float a = 1.0f)
    {
        R = r;
        G = g;
        B = b;
        A = a;
    }

    /// <summary> Initializes a new instance of the <see cref="VkColor" /> struct. </summary>
    /// <param name="colors"> [in,out] If non-null, the colors. </param>
    public VkColor(float* colors)
    {
        R = *(colors + 0);
        G = *(colors + 1);
        B = *(colors + 2);
        A = *(colors + 3);
    }

    /// <inheritdoc />
    public override string ToString()
    {
        return $"R:{R} G:{G} B:{B} A:{A}";
    }

    /// <summary> Implicit cast that converts the given VkColor to a VkClearColorValue. </summary>
    /// <param name="color"> The color. </param>
    /// <returns> The result of the operation. </returns>
    public static implicit operator VkClearColorValue(VkColor color)
    {
        return *(VkClearColorValue*)&color;
    }

    /// <summary> Implicit cast that converts the given VkClearColorValue to a VkColor. </summary>
    /// <param name="color"> The color. </param>
    /// <returns> The result of the operation. </returns>
    public static implicit operator VkColor(VkClearColorValue color)
    {
        return *(VkColor*)&color;
    }
}