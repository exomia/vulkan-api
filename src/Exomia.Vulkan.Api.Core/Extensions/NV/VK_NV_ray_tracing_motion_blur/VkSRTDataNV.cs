#region License

// Copyright (c) 2018-2022, exomia
// All rights reserved.
// 
// This source code is licensed under the BSD-style license found in the
// LICENSE file in the root directory of this source tree.

#endregion

// ReSharper disable UnusedMember.Global
// ReSharper disable InconsistentNaming
// ReSharper disable once CheckNamespace
namespace Exomia.Vulkan.Api.Core;

/// <summary>
///     VkSRTDataNV - Structure specifying a transform in SRT decomposition -
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkSRTDataNV.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkSRTDataNV.html</a>
/// </summary>
[StructLayout(LayoutKind.Sequential)]
public struct VkSRTDataNV
{
    /// <summary>sx is the x component of the scale of the transform</summary>
    public float sx;

    /// <summary>a is one component of the shear for the transform</summary>
    public float a;

    /// <summary>b is one component of the shear for the transform</summary>
    public float b;

    /// <summary>pvx is the x component of the pivot point of the transform</summary>
    public float pvx;

    /// <summary>sy is the y component of the scale of the transform</summary>
    public float sy;

    /// <summary>c is one component of the shear for the transform</summary>
    public float c;

    /// <summary>pvy is the y component of the pivot point of the transform</summary>
    public float pvy;

    /// <summary>sz is the z component of the scale of the transform</summary>
    public float sz;

    /// <summary>pvz is the z component of the pivot point of the transform</summary>
    public float pvz;

    /// <summary>qx is the x component of the rotation quaternion</summary>
    public float qx;

    /// <summary>qy is the y component of the rotation quaternion</summary>
    public float qy;

    /// <summary>qz is the z component of the rotation quaternion</summary>
    public float qz;

    /// <summary>qw is the w component of the rotation quaternion</summary>
    public float qw;

    /// <summary>tx is the x component of the post-rotation translation</summary>
    public float tx;

    /// <summary>ty is the y component of the post-rotation translation</summary>
    public float ty;

    /// <summary>tz is the z component of the post-rotation translation</summary>
    public float tz;
}