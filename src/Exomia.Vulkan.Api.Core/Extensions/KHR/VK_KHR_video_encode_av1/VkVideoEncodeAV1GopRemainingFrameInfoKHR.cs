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
///     VkVideoEncodeAV1GopRemainingFrameInfoKHR - Structure specifying AV1 encode rate control GOP remaining frame counts
///     -
///     <a
///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkVideoEncodeAV1GopRemainingFrameInfoKHR.html">
///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkVideoEncodeAV1GopRemainingFrameInfoKHR.html
///     </a>
/// </summary>
/// <remarks>
///     <list type="table">
///         <item>
///             <term>structextends</term><description>VkVideoBeginCodingInfoKHR</description>
///         </item>
///     </list>
/// </remarks>
[VkStructExtends("VkVideoBeginCodingInfoKHR")]
[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkVideoEncodeAV1GopRemainingFrameInfoKHR
{
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_VIDEO_ENCODE_AV1_GOP_REMAINING_FRAME_INFO_KHR;

    /// <summary>sType is a VkStructureType value identifying this structure.</summary>
    public VkStructureType sType;

    /// <summary>pNext is NULL or a pointer to a structure extending this structure.</summary>
    public void* pNext;

    /// <summary>
    ///     useGopRemainingFrames indicates whether the implementation&#8217;s rate control algorithm should use the
    ///     values specified in gopRemainingIntra, gopRemainingPredictive, and gopRemainingBipredictive. If
    ///     useGopRemainingFrames is VK_FALSE, then the values of gopRemainingIntra, gopRemainingPredictive, and
    ///     gopRemainingBipredictive are ignored.
    /// </summary>
    public VkBool32 useGopRemainingFrames;

    /// <summary>
    ///     gopRemainingIntra specifies the number of frames encoded with VK_VIDEO_ENCODE_AV1_RATE_CONTROL_GROUP_INTRA_KHR
    ///     the implementation&#8217;s rate control algorithm should assume to be remaining in the GOP prior to executing the
    ///     next video encode operation.
    /// </summary>
    public uint gopRemainingIntra;

    /// <summary>
    ///     gopRemainingPredictive specifies the number of frames encoded with
    ///     VK_VIDEO_ENCODE_AV1_RATE_CONTROL_GROUP_PREDICTIVE_KHR the implementation&#8217;s rate control algorithm should
    ///     assume to be remaining in the GOP prior to executing the next video encode operation.
    /// </summary>
    public uint gopRemainingPredictive;

    /// <summary>
    ///     gopRemainingBipredictive specifies the number of frames encoded with
    ///     VK_VIDEO_ENCODE_AV1_RATE_CONTROL_GROUP_BIPREDICTIVE_KHR the implementation&#8217;s rate control algorithm should
    ///     assume to be remaining in the GOP prior to executing the next video encode operation.
    /// </summary>
    public uint gopRemainingBipredictive;
}