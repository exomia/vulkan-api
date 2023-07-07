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
///     VkValidationFlagsEXT - Specify validation checks to disable for a Vulkan instance -
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkValidationFlagsEXT.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkValidationFlagsEXT.html</a>
/// </summary>
/// <remarks>
///     <list type="table">
///         <item>
///             <term>structextends</term><description>VkInstanceCreateInfo</description>
///         </item>
///     </list>
/// </remarks>
[VkStructExtends("VkInstanceCreateInfo")]
[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkValidationFlagsEXT
{
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_VALIDATION_FLAGS_EXT;

    /// <summary>sType is a VkStructureType value identifying this structure.</summary>
    public VkStructureType sType;

    /// <summary>pNext is NULL or a pointer to a structure extending this structure.</summary>
    public void* pNext;

    /// <summary>disabledValidationCheckCount is the number of checks to disable.</summary>
    public uint disabledValidationCheckCount;

    /// <summary>
    ///     pDisabledValidationChecks is a pointer to an array of VkValidationCheckEXT values specifying the validation
    ///     checks to be disabled.
    /// </summary>
    public VkValidationCheckEXT* pDisabledValidationChecks;
}