using System.Runtime.InteropServices;

// ReSharper disable IdentifierTypo
// ReSharper disable InconsistentNaming
namespace Exomia.Vulkan.Api.Win32;


/// <summary> 
///     A security attributes.<br/>
///     <a href="https://docs.microsoft.com/en-us/windows/win32/api/wtypesbase/ns-wtypesbase-security_attributes">https://docs.microsoft.com/en-us/windows/win32/api/wtypesbase/ns-wtypesbase-security_attributes</a>
/// </summary>
[StructLayout(LayoutKind.Sequential)]
public unsafe struct SECURITY_ATTRIBUTES
{
    public int                  nLength;
    public SECURITY_DESCRIPTOR* lpSecurityDescriptor;
    public int                  bInheritHandle;
}