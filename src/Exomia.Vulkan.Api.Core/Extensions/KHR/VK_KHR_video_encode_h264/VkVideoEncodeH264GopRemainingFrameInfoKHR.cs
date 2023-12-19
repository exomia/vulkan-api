#region License

// Copyright (c) 2018-2023, exomia
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
///     VkVideoEncodeH264GopRemainingFrameInfoKHR - Structure specifying H.264 encode rate control GOP remaining frame
///     counts -
///     <a
///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkVideoEncodeH264GopRemainingFrameInfoKHR.html">
///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkVideoEncodeH264GopRemainingFrameInfoKHR.html
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
public unsafe struct VkVideoEncodeH264GopRemainingFrameInfoKHR
{
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_VIDEO_ENCODE_H264_GOP_REMAINING_FRAME_INFO_KHR;

    /// <summary>sType is a VkStructureType value identifying this structure.</summary>
    public VkStructureType sType;

    /// <summary>pNext is NULL or a pointer to a structure extending this structure.</summary>
    public void* pNext;

    /// <summary>
    ///     useGopRemainingFrames indicates whether the implementation&#8217;s rate control algorithm should use the
    ///     values specified in gopRemainingI, gopRemainingP, and gopRemainingB. If useGopRemainingFrames is VK_FALSE, then the
    ///     values of gopRemainingI, gopRemainingP, and gopRemainingB are ignored.
    /// </summary>
    public VkBool32 useGopRemainingFrames;

    /// <summary>
    ///     gopRemainingI specifies the number of I frames the implementation&#8217;s rate control algorithm should assume
    ///     to be remaining in the GOP prior to executing the video encode operation.
    /// </summary>
    public uint gopRemainingI;

    /// <summary>
    ///     gopRemainingP specifies the number of P frames the implementation&#8217;s rate control algorithm should assume
    ///     to be remaining in the GOP prior to executing the video encode operation.
    /// </summary>
    public uint gopRemainingP;

    /// <summary>
    ///     gopRemainingB specifies the number of B frames the implementation&#8217;s rate control algorithm should assume
    ///     to be remaining in the GOP prior to executing the video encode operation.
    /// </summary>
    public uint gopRemainingB;
}