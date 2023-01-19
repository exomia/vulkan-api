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
///     VkTraceRaysIndirectCommand2KHR - Structure specifying the parameters of an indirect trace ray command with
///     indirect shader binding tables -
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkTraceRaysIndirectCommand2KHR.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkTraceRaysIndirectCommand2KHR.html</a>
/// </summary>
[StructLayout(LayoutKind.Sequential)]
public struct VkTraceRaysIndirectCommand2KHR
{
    /// <summary>
    ///     raygenShaderRecordAddress is a VkDeviceAddress of the ray generation shader binding table record used by this
    ///     command.
    /// </summary>
    public VkDeviceAddress raygenShaderRecordAddress;

    /// <summary>
    ///     raygenShaderRecordSize is a VkDeviceSize number of bytes corresponding to the ray generation shader binding
    ///     table record at base address raygenShaderRecordAddress.
    /// </summary>
    public VkDeviceSize raygenShaderRecordSize;

    /// <summary>
    ///     missShaderBindingTableAddress is a VkDeviceAddress of the first record in the miss shader binding table used
    ///     by this command.
    /// </summary>
    public VkDeviceAddress missShaderBindingTableAddress;

    /// <summary>
    ///     missShaderBindingTableSize is a VkDeviceSize number of bytes corresponding to the total size of the miss
    ///     shader binding table at missShaderBindingTableAddress that may be accessed by this command.
    /// </summary>
    public VkDeviceSize missShaderBindingTableSize;

    /// <summary>
    ///     missShaderBindingTableStride is a VkDeviceSize number of bytes between records of the miss shader binding
    ///     table.
    /// </summary>
    public VkDeviceSize missShaderBindingTableStride;

    /// <summary>
    ///     hitShaderBindingTableAddress is a VkDeviceAddress of the first record in the hit shader binding table used by
    ///     this command.
    /// </summary>
    public VkDeviceAddress hitShaderBindingTableAddress;

    /// <summary>
    ///     hitShaderBindingTableSize is a VkDeviceSize number of bytes corresponding to the total size of the hit shader
    ///     binding table at hitShaderBindingTableAddress that may be accessed by this command.
    /// </summary>
    public VkDeviceSize hitShaderBindingTableSize;

    /// <summary>hitShaderBindingTableStride is a VkDeviceSize number of bytes between records of the hit shader binding table.</summary>
    public VkDeviceSize hitShaderBindingTableStride;

    /// <summary>
    ///     callableShaderBindingTableAddress is a VkDeviceAddress of the first record in the callable shader binding
    ///     table used by this command.
    /// </summary>
    public VkDeviceAddress callableShaderBindingTableAddress;

    /// <summary>
    ///     callableShaderBindingTableSize is a VkDeviceSize number of bytes corresponding to the total size of the
    ///     callable shader binding table at callableShaderBindingTableAddress that may be accessed by this command.
    /// </summary>
    public VkDeviceSize callableShaderBindingTableSize;

    /// <summary>
    ///     callableShaderBindingTableStride is a VkDeviceSize number of bytes between records of the callable shader
    ///     binding table.
    /// </summary>
    public VkDeviceSize callableShaderBindingTableStride;

    /// <summary>width is the width of the ray trace query dimensions.</summary>
    public uint width;

    /// <summary>height is height of the ray trace query dimensions.</summary>
    public uint height;

    /// <summary>depth is depth of the ray trace query dimensions.</summary>
    public uint depth;
}