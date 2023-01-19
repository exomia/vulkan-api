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
///     VkPhysicalDeviceSparseProperties - Structure specifying physical device sparse memory properties -
///     <a
///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkPhysicalDeviceSparseProperties.html">
///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkPhysicalDeviceSparseProperties.html
///     </a>
/// </summary>
/// <remarks>
///     <list type="table">
///         <item>
///             <term>returnedonly</term><description>true</description>
///         </item>
///     </list>
/// </remarks>
[StructLayout(LayoutKind.Sequential)]
public struct VkPhysicalDeviceSparseProperties
{
    /// <summary>
    ///     residencyStandard2DBlockShape is VK_TRUE if the physical device will access all single-sample 2D sparse
    ///     resources using the standard sparse image block shapes (based on image format), as described in the Standard Sparse
    ///     Image Block Shapes (Single Sample) table. If this property is not supported the value returned in the
    ///     imageGranularity member of the VkSparseImageFormatPropertiesstructure for single-sample 2D images is not required
    ///     to match the standard sparse image block dimensions listed in the table.
    /// </summary>
    public VkBool32 residencyStandard2DBlockShape;

    /// <summary>
    ///     residencyStandard2DMultisampleBlockShape is VK_TRUE if the physical device will access all multisample 2D
    ///     sparse resources using the standard sparse image block shapes (based on image format), as described in the Standard
    ///     Sparse Image Block Shapes (MSAA) table. If this property is not supported, the value returned in the
    ///     imageGranularity member of the VkSparseImageFormatPropertiesstructure for multisample 2D images is not required to
    ///     match the standard sparse image block dimensions listed in the table.
    /// </summary>
    public VkBool32 residencyStandard2DMultisampleBlockShape;

    /// <summary>
    ///     residencyStandard3DBlockShape is VK_TRUE if the physical device will access all 3D sparse resources using the
    ///     standard sparse image block shapes (based on image format), as described in the Standard Sparse Image Block Shapes
    ///     (Single Sample) table. If this property is not supported, the value returned in the imageGranularity member of the
    ///     VkSparseImageFormatPropertiesstructure for 3D images is not required to match the standard sparse image block
    ///     dimensions listed in the table.
    /// </summary>
    public VkBool32 residencyStandard3DBlockShape;

    /// <summary>
    ///     residencyAlignedMipSize is VK_TRUE if images with mip level dimensions that are not integer multiples of the
    ///     corresponding dimensions of the sparse image block may be placed in the mip tail. If this property is not reported,
    ///     only mip levels with dimensions smaller than the imageGranularity member of the VkSparseImageFormatProperties
    ///     structure will be placed in the mip tail. If this property is reported the implementation is allowed to return
    ///     VK_SPARSE_IMAGE_FORMAT_ALIGNED_MIP_SIZE_BIT in the flagsmember of VkSparseImageFormatProperties, indicating that
    ///     mip level dimensions that are not integer multiples of the corresponding dimensions of the sparse image block will
    ///     be placed in the mip tail.
    /// </summary>
    public VkBool32 residencyAlignedMipSize;

    /// <summary>
    ///     residencyNonResidentStrict specifies whether the physical device can consistently access non-resident regions
    ///     of a resource. If this property is VK_TRUE, access to non-resident regions of resources will be guaranteed to
    ///     return values as if the resource was populated with 0; writes to non-resident regions will be discarded.
    /// </summary>
    public VkBool32 residencyNonResidentStrict;
}