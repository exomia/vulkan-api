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
///     VkVideoSessionParametersCreateInfoKHR - Structure specifying parameters of a newly created video session parameters
///     object -
///     <a
///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkVideoSessionParametersCreateInfoKHR.html">
///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkVideoSessionParametersCreateInfoKHR.html
///     </a>
/// </summary>
[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkVideoSessionParametersCreateInfoKHR
{
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_VIDEO_SESSION_PARAMETERS_CREATE_INFO_KHR;

    /// <summary>sType is the type of this structure.</summary>
    public VkStructureType sType;

    /// <summary>pNext is NULL or a pointer to a structure extending this structure.</summary>
    public void* pNext;

    /// <summary>flags is reserved for future use.</summary>
    public VkVideoSessionParametersCreateFlagsKHR flags;

    /// <summary>
    ///     videoSessionParametersTemplate is VK_NULL_HANDLE or a valid handle to a VkVideoSessionParametersKHR object
    ///     used as a template for constructing the new video session parameters object.
    /// </summary>
    public VkVideoSessionParametersKHR videoSessionParametersTemplate;

    /// <summary>
    ///     videoSession is the video session object against which the video session parameters object is going to be
    ///     created.
    /// </summary>
    public VkVideoSessionKHR videoSession;
}