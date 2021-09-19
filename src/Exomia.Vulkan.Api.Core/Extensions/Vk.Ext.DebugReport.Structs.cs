#region License

// Copyright (c) 2018-2021, exomia
// All rights reserved.
// 
// This source code is licensed under the BSD-style license found in the
// LICENSE file in the root directory of this source tree.

#endregion

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

using System.Runtime.InteropServices;

// ReSharper disable UnusedMember.Global
namespace Exomia.Vulkan.Api.Core.Extensions
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkDebugReportCallbackCreateInfoEXT
    {
        public const VkStructureType       STYPE = VkStructureType.DEBUG_REPORT_CALLBACK_CREATE_INFO_EXT;
        public       VkStructureType       sType;
        public       void*                 pNext;
        public       VkDebugReportFlagsEXT flags;

        public delegate*<               /*vkDebugReportCallbackEXT*/
            VkDebugReportFlagsEXT,      /* FlagBits                  */
            VkDebugReportObjectTypeEXT, /* objectType             */
            ulong,                      /* @object                */
            nuint,                      /* location               */
            int,                        /* messageCode            */
            sbyte*,                     /* pLayerPrefix           */
            sbyte*,                     /* pMessage               */
            void*,                      /* pUserData              */
            VkBool32> pfnCallback;

        public void* pUserData;
    }
}