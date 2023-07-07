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
///     VkApplicationInfo - Structure specifying application information -
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkApplicationInfo.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkApplicationInfo.html</a>
/// </summary>
[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkApplicationInfo
{
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_APPLICATION_INFO;

    /// <summary>sType is a VkStructureType value identifying this structure.</summary>
    public VkStructureType sType;

    /// <summary>pNext is NULL or a pointer to a structure extending this structure.</summary>
    public void* pNext;

    /// <summary>
    ///     pApplicationName is NULL or is a pointer to a null-terminated UTF-8 string containing the name of the
    ///     application.
    /// </summary>
    public byte* pApplicationName;

    /// <summary>
    ///     applicationVersion is an unsigned integer variable containing the developer-supplied version number of the
    ///     application.
    /// </summary>
    public VkVersion applicationVersion;

    /// <summary>
    ///     pEngineName is NULL or is a pointer to a null-terminated UTF-8 string containing the name of the engine (if
    ///     any) used to create the application.
    /// </summary>
    public byte* pEngineName;

    /// <summary>
    ///     engineVersion is an unsigned integer variable containing the developer-supplied version number of the engine
    ///     used to create the application.
    /// </summary>
    public VkVersion engineVersion;

    /// <summary>
    ///     apiVersion must be the highest version of Vulkan that the application is designed to use, encoded as described
    ///     in
    ///     https://registry.khronos.org/vulkan/specs/1.3-extensions/html/vkspec.html#extendingvulkan-coreversions-versionnumbers.
    ///     The patch version number specified in apiVersion is ignored when creating an instance object. The variant version
    ///     of the instance must match that requested in apiVersion.
    /// </summary>
    public VkVersion apiVersion;
}