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
///     VkValidationFeaturesEXT - Specify validation features to enable or disable for a Vulkan instance -
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkValidationFeaturesEXT.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkValidationFeaturesEXT.html</a>
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
public unsafe struct VkValidationFeaturesEXT
{
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_VALIDATION_FEATURES_EXT;

    /// <summary>sType is the type of this structure.</summary>
    public VkStructureType sType;

    /// <summary>pNext is NULL or a pointer to a structure extending this structure.</summary>
    public void* pNext;

    /// <summary>enabledValidationFeatureCount is the number of features to enable.</summary>
    public uint enabledValidationFeatureCount;

    /// <summary>
    ///     pEnabledValidationFeatures is a pointer to an array of VkValidationFeatureEnableEXT values specifying the
    ///     validation features to be enabled.
    /// </summary>
    public VkValidationFeatureEnableEXT* pEnabledValidationFeatures;

    /// <summary>disabledValidationFeatureCount is the number of features to disable.</summary>
    public uint disabledValidationFeatureCount;

    /// <summary>
    ///     pDisabledValidationFeatures is a pointer to an array of VkValidationFeatureDisableEXT values specifying the
    ///     validation features to be disabled.
    /// </summary>
    public VkValidationFeatureDisableEXT* pDisabledValidationFeatures;
}