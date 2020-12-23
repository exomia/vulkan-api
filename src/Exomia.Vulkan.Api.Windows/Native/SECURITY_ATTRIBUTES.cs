#region License

// Copyright (c) 2018-2020, exomia
// All rights reserved.
// 
// This source code is licensed under the BSD-style license found in the
// LICENSE file in the root directory of this source tree.

#endregion

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

using System.Runtime.InteropServices;

namespace Exomia.Vulkan.Api.Windows.Native
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct SECURITY_ATTRIBUTES
    {
        public int                  nLength;
        public SECURITY_DESCRIPTOR* lpSecurityDescriptor;
        public int                  bInheritHandle;
    }
}