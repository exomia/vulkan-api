using System;
using System.Runtime.InteropServices;

namespace Exomia.Vulkan.Api.Windows.Native
{
    [StructLayout(LayoutKind.Sequential)]
    public struct SECURITY_DESCRIPTOR
    {
        public byte revision;
        public byte size;
        public short control;
        public IntPtr owner;
        public IntPtr group;
        public IntPtr sacl;
        public IntPtr dacl;
    }
}
