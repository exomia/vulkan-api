#region License

// Copyright (c) 2018-2023, exomia
// All rights reserved.
// 
// This source code is licensed under the BSD-style license found in the
// LICENSE file in the root directory of this source tree.

#endregion

// ReSharper disable UnusedMember.Global
// ReSharper disable once CheckNamespace
namespace Exomia.Vulkan.Api.Core;

/// <summary>
///     Used instead of public fixed float blendConstants[4] and float blendConstants[4].
/// </summary>
[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkBlendConstants
{
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

    /// <inheritdoc />
    public override string ToString()
    {
        return $"R:{R} G:{G} B:{B} A:{A}";
    }

    /// <summary> Implicit cast that converts the given VkColor to a VkBlendConstants. </summary>
    /// <param name="color"> The color. </param>
    /// <returns> The result of the operation. </returns>
    public static implicit operator VkBlendConstants(VkColor color)
    {
        return *(VkBlendConstants*)&color;
    }
}