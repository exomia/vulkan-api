#region License

// Copyright (c) 2018-2021, exomia
// All rights reserved.
// 
// This source code is licensed under the BSD-style license found in the
// LICENSE file in the root directory of this source tree.

#endregion

using System.Runtime.InteropServices;

namespace Exomia.Vulkan.Api.Core
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkAllocationCallbacks
    {
        public void* pUserData;

        public delegate*<            /*vkAllocationFunction*/
            void*,                   /* pUserData          */
            nuint,                   /* size               */
            nuint,                   /* alignment          */
            VkSystemAllocationScope, /* allocationScope    */
            void*> pfnAllocation;

        public delegate*<            /*vkReallocationFunction*/
            void*,                   /* pUserData            */
            void*,                   /* pOriginal            */
            nuint,                   /* size                 */
            nuint,                   /* alignment            */
            VkSystemAllocationScope, /* allocationScope      */
            void*> pfnReallocation;

        public delegate*< /*FreeFunction*/
            void*,        /* pUserData  */
            void*,        /* pMemory    */
            void> pfnFree;

        public delegate*<             /*vkInternalAllocationNotification*/
            void*,                    /* pUserData                      */
            nuint,                    /* size                           */
            VkInternalAllocationType, /* allocationType                 */
            VkSystemAllocationScope,  /* allocationScope                */
            void> pfnInternalAllocation;

        public delegate*<             /*vkInternalFreeNotification*/
            void*,                    /* pUserData                */
            nuint,                    /* size                     */
            VkInternalAllocationType, /* allocationType           */
            VkSystemAllocationScope,  /* allocationScope          */
            void> pfnInternalFree;
    }
}