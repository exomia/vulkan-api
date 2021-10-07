#region License

// Copyright (c) 2018-2021, exomia
// All rights reserved.
// 
// This source code is licensed under the BSD-style license found in the
// LICENSE file in the root directory of this source tree.

#endregion

using System;
using System.Runtime.CompilerServices;

namespace Exomia.Vulkan.Api.SourceGenerator
{
    static class Utils
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe void* LoadVkFunction(Exomia.Vulkan.Api.Core.VkInstance vkInstance, string vkFunctionName)
        {
            fixed (char* pVkFunctionName = vkFunctionName)
            {
                void* vkInstanceProcAddr = Exomia.Vulkan.Api.Core.Vk.GetInstanceProcAddr(vkInstance, (sbyte*)pVkFunctionName);
                if (vkInstanceProcAddr != null)
                {
                    return vkInstanceProcAddr;
                }
                throw new EntryPointNotFoundException(new string((sbyte*)pVkFunctionName));
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe void* LoadVkFunction(Exomia.Vulkan.Api.Core.VkDevice vkDevice, string vkFunctionName)
        {
            fixed (char* pVkFunctionName = vkFunctionName)
            {
                void* vkDeviceProcAddr = Exomia.Vulkan.Api.Core.Vk.GetDeviceProcAddr(vkDevice, (sbyte*)pVkFunctionName);
                if (vkDeviceProcAddr != null)
                {
                    return vkDeviceProcAddr;
                }
                throw new EntryPointNotFoundException(new string((sbyte*)pVkFunctionName));
            }
        }
    }
}