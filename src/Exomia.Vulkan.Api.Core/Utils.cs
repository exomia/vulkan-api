using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Exomia.Vulkan.Api.Core
{
    static class Utils
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static VkFunction LoadVkFunction(VkInstance vkInstance, string vkFunctionName)
        {
            fixed (char* pVkFunctionName = vkFunctionName)
            {
                void* vkInstaceProcAddr = Vk.GetInstanceProcAddr(vkInstance, (sbyte*)pVkFunctionName);
                if(vkInstaceProcAddr != null)
                {
                    return vkInstaceProcAddr;
                }
                throw new EntryPointNotFoundException(new string((sbyte*) pVkFunctionName));
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static VkFunction LoadVkFunction(VkDevice vkDevice, string vkFunctionName)
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
