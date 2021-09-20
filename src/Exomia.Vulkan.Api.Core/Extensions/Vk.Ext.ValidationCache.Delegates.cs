#region License

// Copyright (c) 2018-2021, exomia
// All rights reserved.
// 
// This source code is licensed under the BSD-style license found in the
// LICENSE file in the root directory of this source tree.

#endregion

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

// ReSharper disable UnusedMember.Global
namespace Exomia.Vulkan.Api.Core.Extensions
{
    public unsafe delegate VkResult CreateValidationCacheEXT(
        VkDevice                        device,
        VkValidationCacheCreateInfoEXT* pCreateInfo,
        VkAllocationCallbacks*          pAllocator,
        VkValidationCacheEXT*           pValidationCache);

    public unsafe delegate void DestroyValidationCacheEXT(
        VkDevice               device,
        VkValidationCacheEXT   validationCache,
        VkAllocationCallbacks* pAllocator);

    public unsafe delegate VkResult MergeValidationCachesEXT(
        VkDevice              device,
        VkValidationCacheEXT  dstCache,
        uint                  srcCacheCount,
        VkValidationCacheEXT* pSrcCaches);

    public unsafe delegate VkResult GetValidationCacheDataEXT(
        VkDevice             device,
        VkValidationCacheEXT validationCache,
        nuint*               pDataSize,
        void*                pData);
}
