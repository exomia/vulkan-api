using System;
using System.Runtime.CompilerServices;

namespace Exomia.Vulkan.Api.Core
{
    static class Utils
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe void* LoadVkFunction(VkInstance vkInstance, string vkFunctionName)
        {
            fixed (char* pVkFunctionName = vkFunctionName)
            {
                void* vkInstanceProcAddr = Vk.GetInstanceProcAddr(vkInstance, (sbyte*)pVkFunctionName);
                if(vkInstanceProcAddr != null)
                {
                    return vkInstanceProcAddr;
                }
                throw new EntryPointNotFoundException(new string((sbyte*) pVkFunctionName));
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe void* LoadVkFunction(VkDevice vkDevice, string vkFunctionName)
        {
            fixed (char* pVkFunctionName = vkFunctionName)
            {
                void* vkDeviceProcAddr = Vk.GetDeviceProcAddr(vkDevice, (sbyte*)pVkFunctionName);
                if (vkDeviceProcAddr != null)
                {
                    return vkDeviceProcAddr;
                }
                throw new EntryPointNotFoundException(new string((sbyte*)pVkFunctionName));
            }
        }
    }
}
