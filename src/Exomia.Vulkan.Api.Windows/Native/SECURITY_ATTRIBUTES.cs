using System.Runtime.InteropServices;

namespace Exomia.Vulkan.Api.Windows.Native
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct SECURITY_ATTRIBUTES
    {
        public int nLength;
        public SECURITY_DESCRIPTOR* lpSecurityDescriptor;
        public int bInheritHandle;
    }
}
