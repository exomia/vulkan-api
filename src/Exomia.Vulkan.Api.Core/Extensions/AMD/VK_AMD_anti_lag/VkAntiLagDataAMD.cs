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
namespace Exomia.Vulkan.Api.Core;

/// <summary>
///     VkAntiLagDataAMD - Structure specifying the parameters for vkAntiLagUpdateAMD -
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkAntiLagDataAMD.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkAntiLagDataAMD.html</a>
/// </summary>
[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkAntiLagDataAMD
{
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_ANTI_LAG_DATA_AMD;

    /// <summary>sType is a VkStructureType value identifying this structure.</summary>
    public VkStructureType sType;

    /// <summary>pNext is NULL or a pointer to a structure extending this structure.</summary>
    public void* pNext;

    /// <summary>mode is a VkAntiLagModeAMD value specifying the anti-lag status.</summary>
    public VkAntiLagModeAMD mode;

    /// <summary>
    ///     maxFPS is the framerate limit, in frames per second, used by the application. This limit will be imposed if
    ///     anti-lag is enabled. If the application tries to render faster, the framerate will be reduced to match this limit.
    ///     A value of 0 will disable the limit.
    /// </summary>
    public uint maxFPS;

    /// <summary>
    ///     pPresentationInfo is a pointer to a VkAntiLagPresentationInfoAMD structure containing information about the
    ///     application stage.
    /// </summary>
    public VkAntiLagPresentationInfoAMD* pPresentationInfo;
}