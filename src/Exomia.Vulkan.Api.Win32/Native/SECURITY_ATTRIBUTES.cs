#region License

// Copyright (c) 2018-2024, exomia
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
///     A security attributes.<br />
///     <a href="https://docs.microsoft.com/en-us/windows/win32/api/wtypesbase/ns-wtypesbase-security_attributes">https://docs.microsoft.com/en-us/windows/win32/api/wtypesbase/ns-wtypesbase-security_attributes</a>
/// </summary>
[StructLayout(LayoutKind.Sequential)]
public unsafe struct SECURITY_ATTRIBUTES
{
    public int                  nLength;
    public SECURITY_DESCRIPTOR* lpSecurityDescriptor;
    public int                  bInheritHandle;
}