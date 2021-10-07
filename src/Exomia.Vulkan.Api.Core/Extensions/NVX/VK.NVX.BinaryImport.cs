#region License

// Copyright (c) 2018-2021, exomia
// All rights reserved.
// 
// This source code is licensed under the BSD-style license found in the
// LICENSE file in the root directory of this source tree.

#endregion

#pragma warning disable CA2211 // Non-constant fields should not be visible
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

using System;
using System.Runtime.InteropServices;
using Exomia.Vulkan.Api.SourceGenerator;

// ReSharper disable UnusedMember.Global
// ReSharper disable InconsistentNaming
namespace Exomia.Vulkan.Api.Core.Extensions.NVX
{
    [VkExtGenerator]
    public static unsafe partial class VKNvxBinaryImport
    {
        public const int    VK_NVX_BINARY_IMPORT                = 1;
        public const int    VK_NVX_BINARY_IMPORT_SPEC_VERSION   = 1;
        public const string VK_NVX_BINARY_IMPORT_EXTENSION_NAME = "VK_NVX_binary_import";
        
        public static readonly delegate*<
    VkCommandBuffer, /* commandBuffer */
    VkCuLaunchInfoNVX*, /* pLaunchInfo */
    void> vkCmdCuLaunchKernelNVX = null;

public static readonly delegate*<
    VkDevice, /* device */
    VkCuFunctionCreateInfoNVX*, /* pCreateInfo */
    VkAllocationCallbacks*, /* pAllocator */
    VkCuFunctionNVX*, /* pFunction */
    VkResult> vkCreateCuFunctionNVX = null;

public static readonly delegate*<
    VkDevice, /* device */
    VkCuModuleCreateInfoNVX*, /* pCreateInfo */
    VkAllocationCallbacks*, /* pAllocator */
    VkCuModuleNVX*, /* pModule */
    VkResult> vkCreateCuModuleNVX = null;

public static readonly delegate*<
    VkDevice, /* device */
    VkCuFunctionNVX, /* function */
    VkAllocationCallbacks*, /* pAllocator */
    void> vkDestroyCuFunctionNVX = null;

public static readonly delegate*<
    VkDevice, /* device */
    VkCuModuleNVX, /* module */
    VkAllocationCallbacks*, /* pAllocator */
    void> vkDestroyCuModuleNVX = null;



        public static partial void Load(VkInstance vkInstance);
    }




    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkCuFunctionCreateInfoNVX
    {
        public const VkStructureType STYPE = VkStructureType.CU_FUNCTION_CREATE_INFO_NVX;
        public       VkStructureType sType;
        public       void*           pNext;
        public       VkCuModuleNVX   module;
        public       sbyte*          pName;
    }


    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkCuLaunchInfoNVX
    {
        public const VkStructureType STYPE = VkStructureType.CU_LAUNCH_INFO_NVX;
        public       VkStructureType sType;
        public       void*           pNext;
        public       VkCuFunctionNVX function;
        public       uint            gridDimX;
        public       uint            gridDimY;
        public       uint            gridDimZ;
        public       uint            blockDimX;
        public       uint            blockDimY;
        public       uint            blockDimZ;
        public       uint            sharedMemBytes;
        public       nuint           paramCount;
        public       nuint           extraCount;
    }


    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkCuModuleCreateInfoNVX
    {
        public const VkStructureType STYPE = VkStructureType.CU_MODULE_CREATE_INFO_NVX;
        public       VkStructureType sType;
        public       void*           pNext;
        public       nuint           dataSize;
        public       void*           pData;
    }



    public readonly unsafe struct VkCuFunctionNVX
    {
        public static readonly VkCuFunctionNVX Null = (VkCuFunctionNVX)null;
#pragma warning disable 649
        private readonly void* _ptr;
#pragma warning restore 649

        public static explicit operator VkCuFunctionNVX(void* ptr)
        {
            VkCuFunctionNVX value;
            *(void**)&value = ptr;
            return value;
        }

        public static bool operator ==(VkCuFunctionNVX left, VkCuFunctionNVX right)
        {
            return left._ptr == right._ptr;
        }

        public static bool operator !=(VkCuFunctionNVX left, VkCuFunctionNVX right)
        {
            return left._ptr != right._ptr;
        }

        public bool Equals(in VkCuFunctionNVX obj)
        {
            return obj._ptr == _ptr;
        }

        public override bool Equals(object? obj)
        {
            return obj is VkCuFunctionNVX vkCuFunctionNVX && Equals(in vkCuFunctionNVX);
        }

        public override int GetHashCode()
        {
            return ((IntPtr)_ptr).GetHashCode();
        }

        public static explicit operator void*(VkCuFunctionNVX value)
        {
            return value._ptr;
        }
    }

    public readonly unsafe struct VkCuModuleNVX
    {
        public static readonly VkCuModuleNVX Null = (VkCuModuleNVX)null;
#pragma warning disable 649
        private readonly void* _ptr;
#pragma warning restore 649

        public static explicit operator VkCuModuleNVX(void* ptr)
        {
            VkCuModuleNVX value;
            *(void**)&value = ptr;
            return value;
        }

        public static bool operator ==(VkCuModuleNVX left, VkCuModuleNVX right)
        {
            return left._ptr == right._ptr;
        }

        public static bool operator !=(VkCuModuleNVX left, VkCuModuleNVX right)
        {
            return left._ptr != right._ptr;
        }

        public bool Equals(in VkCuModuleNVX obj)
        {
            return obj._ptr == _ptr;
        }

        public override bool Equals(object? obj)
        {
            return obj is VkCuModuleNVX vkCuModuleNVX && Equals(in vkCuModuleNVX);
        }

        public override int GetHashCode()
        {
            return ((IntPtr)_ptr).GetHashCode();
        }

        public static explicit operator void*(VkCuModuleNVX value)
        {
            return value._ptr;
        }
    }


}