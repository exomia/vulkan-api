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
///     VkAccelerationStructureMatrixMotionInstanceNV - Structure specifying a single acceleration structure matrix motion
///     instance for building into an acceleration structure geometry -
///     <a
///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkAccelerationStructureMatrixMotionInstanceNV.html">
///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkAccelerationStructureMatrixMotionInstanceNV.html
///     </a>
/// </summary>
[StructLayout(LayoutKind.Sequential)]
public struct VkAccelerationStructureMatrixMotionInstanceNV
{
    /// <summary>
    ///     transformT0 is a VkTransformMatrixKHR structure describing a transformation to be applied to the acceleration
    ///     structure at time 0.
    /// </summary>
    public VkTransformMatrixKHR transformT0;

    /// <summary>
    ///     transformT1 is a VkTransformMatrixKHR structure describing a transformation to be applied to the acceleration
    ///     structure at time 1.
    /// </summary>
    public VkTransformMatrixKHR transformT1;

    private uint _bitfield1;
    private uint _bitfield2;

    /// <summary>
    ///     accelerationStructureReference is either:a device address containing the value obtained from
    ///     vkGetAccelerationStructureDeviceAddressKHRor vkGetAccelerationStructureHandleNV     (used by device operations
    ///     which reference acceleration structures) or,a VkAccelerationStructureKHR object (used by host operations which
    ///     reference acceleration structures).
    /// </summary>
    public ulong accelerationStructureReference;

    /// <summary>
    ///     instanceCustomIndex is a 24-bit user-specified index value accessible to ray shaders in the
    ///     InstanceCustomIndexKHR built-in.
    /// </summary>
    public uint instanceCustomIndex
    {
        get { return (uint)((_bitfield1 >> 0) & 0x00FFFFFF); }
        set { _bitfield1 = (_bitfield1 & 0xFF000000) | (((uint)value & 0x00FFFFFF) << 0); }
    }

    /// <summary>
    ///     mask is an 8-bit visibility mask for the geometry. The instance may only be hit if Cull Mask &amp;
    ///     instance.mask != 0
    /// </summary>
    public uint mask
    {
        get { return (uint)((_bitfield1 >> 24) & 0x000000FF); }
        set { _bitfield1 = (_bitfield1 & 0x00FFFFFF) | (((uint)value & 0x000000FF) << 24); }
    }

    /// <summary>
    ///     instanceShaderBindingTableRecordOffset is a 24-bit offset used in calculating the hit shader binding table
    ///     index.
    /// </summary>
    public uint instanceShaderBindingTableRecordOffset
    {
        get { return (uint)((_bitfield2 >> 0) & 0x00FFFFFF); }
        set { _bitfield2 = (_bitfield2 & 0xFF000000) | (((uint)value & 0x00FFFFFF) << 0); }
    }

    /// <summary>flags is an 8-bit mask of VkGeometryInstanceFlagBitsKHRvalues to apply to this instance.</summary>
    public VkGeometryInstanceFlagsKHR flags
    {
        get { return (VkGeometryInstanceFlagsKHR)((_bitfield2 >> 24) & 0x000000FF); }
        set { _bitfield2 = (_bitfield2 & 0x00FFFFFF) | (((uint)value & 0x000000FF) << 24); }
    }
}