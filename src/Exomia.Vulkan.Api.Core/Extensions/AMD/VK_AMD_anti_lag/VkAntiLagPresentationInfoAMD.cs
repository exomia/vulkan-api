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
///     VkAntiLagPresentationInfoAMD - Structure specifying information about stage -
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkAntiLagPresentationInfoAMD.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkAntiLagPresentationInfoAMD.html</a>
/// </summary>
[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkAntiLagPresentationInfoAMD
{
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_ANTI_LAG_PRESENTATION_INFO_AMD;

    /// <summary>sType is a VkStructureType value identifying this structure.</summary>
    public VkStructureType sType;

    /// <summary>pNext is NULL or a pointer to a structure extending this structure.</summary>
    public void* pNext;

    /// <summary>stage is a VkAntiLagStageAMD value specifying the current application stage.</summary>
    public VkAntiLagStageAMD stage;

    /// <summary>
    ///     frameIndex is set just before the application processes input data (VK_ANTI_LAG_STAGE_INPUT_AMD). The same
    ///     frameIndex value should be set before the frame with current input data will be presented by
    ///     vkQueuePresentKHR(VK_ANTI_LAG_STAGE_PRESENT_AMD). This should be done for each frame.
    /// </summary>
    public ulong frameIndex;
}