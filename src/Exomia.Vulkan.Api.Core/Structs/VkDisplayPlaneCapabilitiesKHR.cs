#region License

// Copyright (c) 2018-2021, exomia
// All rights reserved.
// 
// This source code is licensed under the BSD-style license found in the
// LICENSE file in the root directory of this source tree.

#endregion

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

// ReSharper disable UnusedMember.Global
// ReSharper disable once CheckNamespace
namespace Exomia.Vulkan.Api.Core;

[StructLayout(LayoutKind.Sequential)]
public struct VkDisplayPlaneCapabilitiesKHR
{
    public VkDisplayPlaneAlphaFlagsKHR supportedAlpha;
    public VkOffset2D                  minSrcPosition;
    public VkOffset2D                  maxSrcPosition;
    public VkExtent2D                  minSrcExtent;
    public VkExtent2D                  maxSrcExtent;
    public VkOffset2D                  minDstPosition;
    public VkOffset2D                  maxDstPosition;
    public VkExtent2D                  minDstExtent;
    public VkExtent2D                  maxDstExtent;
}