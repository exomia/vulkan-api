#region License

// Copyright (c) 2018-2024, exomia
// All rights reserved.
// 
// This source code is licensed under the BSD-style license found in the
// LICENSE file in the root directory of this source tree.

#endregion

// ReSharper disable UnusedMember.Global
// ReSharper disable InconsistentNaming
// ReSharper disable once CheckNamespace
namespace Exomia.Vulkan.Api.Win32;

/// <summary>
///     VkWin32KeyedMutexAcquireReleaseInfoKHR - Use the Windows keyed mutex mechanism to synchronize work -
///     <a
///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkWin32KeyedMutexAcquireReleaseInfoKHR.html">
///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkWin32KeyedMutexAcquireReleaseInfoKHR.html
///     </a>
/// </summary>
/// <remarks>
///     <list type="table">
///         <item>
///             <term>structextends</term><description>VkSubmitInfo,VkSubmitInfo2</description>
///         </item>
///     </list>
/// </remarks>
[VkStructExtends("VkSubmitInfo,VkSubmitInfo2")]
[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkWin32KeyedMutexAcquireReleaseInfoKHR
{
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_WIN32_KEYED_MUTEX_ACQUIRE_RELEASE_INFO_KHR;

    /// <summary>sType is a VkStructureType value identifying this structure.</summary>
    public VkStructureType sType;

    /// <summary>pNext is NULL or a pointer to a structure extending this structure.</summary>
    public void* pNext;

    /// <summary>acquireCount is the number of entries in the pAcquireSyncs, pAcquireKeys, and pAcquireTimeouts arrays.</summary>
    public uint acquireCount;

    /// <summary>
    ///     pAcquireSyncs is a pointer to an array of VkDeviceMemoryobjects which were imported from Direct3D 11
    ///     resources.
    /// </summary>
    public VkDeviceMemory* pAcquireSyncs;

    /// <summary>
    ///     pAcquireKeys is a pointer to an array of mutex key values to wait for prior to beginning the submitted work.
    ///     Entries refer to the keyed mutex associated with the corresponding entries in pAcquireSyncs.
    /// </summary>
    public ulong* pAcquireKeys;

    /// <summary>
    ///     pAcquireTimeouts is a pointer to an array of timeout values, in millisecond units, for each acquire specified
    ///     in pAcquireKeys.
    /// </summary>
    public uint* pAcquireTimeouts;

    /// <summary>releaseCount is the number of entries in the pReleaseSyncsand pReleaseKeys arrays.</summary>
    public uint releaseCount;

    /// <summary>
    ///     pReleaseSyncs is a pointer to an array of VkDeviceMemoryobjects which were imported from Direct3D 11
    ///     resources.
    /// </summary>
    public VkDeviceMemory* pReleaseSyncs;

    /// <summary>
    ///     pReleaseKeys is a pointer to an array of mutex key values to set when the submitted work has completed.
    ///     Entries refer to the keyed mutex associated with the corresponding entries in pReleaseSyncs.
    /// </summary>
    public ulong* pReleaseKeys;
}