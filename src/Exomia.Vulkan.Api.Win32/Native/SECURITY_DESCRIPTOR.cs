#region License

// Copyright (c) 2018-2022, exomia
// All rights reserved.
// 
// This source code is licensed under the BSD-style license found in the
// LICENSE file in the root directory of this source tree.

#endregion

#pragma warning disable CS1591

// ReSharper disable IdentifierTypo
// ReSharper disable InconsistentNaming
// ReSharper disable once CheckNamespace
namespace Exomia.Vulkan.Api.Win32;

/// <summary>
///     A security descriptor.<br />
///     <a href="https://docs.microsoft.com/en-us/windows/win32/api/winnt/ns-winnt-security_descriptor">https://docs.microsoft.com/en-us/windows/win32/api/winnt/ns-winnt-security_descriptor</a>
/// </summary>
[StructLayout(LayoutKind.Sequential)]
public struct SECURITY_DESCRIPTOR
{
    public byte   revision;
    public byte   size;
    public short  control;
    public IntPtr owner;
    public IntPtr group;
    public IntPtr sacl;
    public IntPtr dacl;
}