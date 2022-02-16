#region License

// Copyright (c) 2018-2022, exomia
// All rights reserved.
// 
// This source code is licensed under the BSD-style license found in the
// LICENSE file in the root directory of this source tree.

#endregion

// ReSharper disable UnusedMember.Global
// ReSharper disable InconsistentNaming
// ReSharper disable once CheckNamespace
namespace Exomia.Vulkan.Api.Core;

/// <summary>
///     VkProtectedSubmitInfo - Structure indicating whether the submission is protected -
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkProtectedSubmitInfo.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkProtectedSubmitInfo.html</a>
/// </summary>
/// <remarks>
///     <list type="table">
///         <item>
///             <term>structextends</term><description>VkSubmitInfo</description>
///         </item>
///     </list>
/// </remarks>
[VkStructExtends("VkSubmitInfo")]
[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkProtectedSubmitInfo
{
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_PROTECTED_SUBMIT_INFO;

    /// <summary> VUID-VkProtectedSubmitInfo-sType-sType sType must be VK_STRUCTURE_TYPE_PROTECTED_SUBMIT_INFO</summary>
    public VkStructureType sType;

    /// <summary>
    ///     protectedSubmit specifies whether the batch is protected. If protectedSubmit is VK_TRUE, the batch is
    ///     protected. If protectedSubmit is VK_FALSE, the batch is unprotected. If the VkSubmitInfo::pNext chain does not
    ///     include this structure, the batch is unprotected.
    /// </summary>
    public void* pNext;

    /// <summary>
    ///     protectedSubmit specifies whether the batch is protected. If protectedSubmit is VK_TRUE, the batch is
    ///     protected. If protectedSubmit is VK_FALSE, the batch is unprotected. If the VkSubmitInfo::pNext chain does not
    ///     include this structure, the batch is unprotected.
    /// </summary>
    public VkBool32 protectedSubmit;
}