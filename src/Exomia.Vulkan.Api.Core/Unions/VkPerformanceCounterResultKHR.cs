#region License

// Copyright (c) 2018-2021, exomia
// All rights reserved.
// 
// This source code is licensed under the BSD-style license found in the
// LICENSE file in the root directory of this source tree.

#endregion

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

using System.Runtime.InteropServices;

// ReSharper disable UnusedMember.Global
// ReSharper disable once CheckNamespace
namespace Exomia.Vulkan.Api.Core
{
    [StructLayout(LayoutKind.Explicit)]
    public struct VkPerformanceCounterResultKHR
    {
        [FieldOffset(0)]
        public int int32;

        [FieldOffset(0)]
        public long int64;

        [FieldOffset(0)]
        public uint uint32;

        [FieldOffset(0)]
        public ulong uint64;

        [FieldOffset(0)]
        public float float32;

        [FieldOffset(0)]
        public double float64;
    }
}