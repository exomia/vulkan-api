using System;
using System.Runtime.InteropServices;

// ReSharper disable IdentifierTypo
// ReSharper disable InconsistentNaming
namespace Exomia.Vulkan.Api.Win32;

/// <summary> 
///     A security descriptor.<br/>
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