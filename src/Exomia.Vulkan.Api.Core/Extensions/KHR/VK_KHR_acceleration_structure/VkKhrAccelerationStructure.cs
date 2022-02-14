#region License

// Copyright (c) 2018-2022, exomia
// All rights reserved.
// 
// This source code is licensed under the BSD-style license found in the
// LICENSE file in the root directory of this source tree.

#endregion

global using static Exomia.Vulkan.Api.Core.VkKhrAccelerationStructure;

#pragma warning disable CA2211 // Non-constant fields should not be visible
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

// ReSharper disable UnusedMember.Global
// ReSharper disable InconsistentNaming
// ReSharper disable once CheckNamespace
namespace Exomia.Vulkan.Api.Core;

/// <summary>
///     VK_KHR_acceleration_structure - device extension (nr. 151) - author 'KHR' [platform '' | contact 'Daniel Koch
///     @dgkoch']<br />
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_KHR_acceleration_structure.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_KHR_acceleration_structure.html</a>
/// </summary>
[VkRequires("VK_EXT_descriptor_indexing,VK_KHR_buffer_device_address,VK_KHR_deferred_host_operations")]
public static unsafe class VkKhrAccelerationStructure
{
    /// <summary> The spec version. </summary>
    public const uint VK_KHR_ACCELERATION_STRUCTURE_SPEC_VERSION = 13;

    /// <summary> The extension name. </summary>
    public const string VK_KHR_ACCELERATION_STRUCTURE_EXTENSION_NAME = "VK_KHR_acceleration_structure";

    /// <summary>
    ///     An UTF8 null terminated version of <see cref="VK_KHR_ACCELERATION_STRUCTURE_EXTENSION_NAME" /> represented by
    ///     an UTF16 string.
    /// </summary>
    /// <remarks>
    ///     Example usage:<br />
    ///     <br />
    ///     fixed(char* ptr = VK_KHR_ACCELERATION_STRUCTURE_EXTENSION_NAME_UTF8_NT) {<br />
    ///     sbyte* utf8NtPtr = (sbyte*)ptr; // utf8NtPtr - can now be passed and used directly as a utf8_nt string for
    ///     unmanaged code.<br />
    ///     }
    /// </remarks>
    public const string VK_KHR_ACCELERATION_STRUCTURE_EXTENSION_NAME_UTF8_NT =
        "\u4b56\u4b5f\u5248\u415f\u4343\u4c45\u5245\u5441\u4f49\u5f4e\u5453\u5552\u5443\u5255\u5f45\u5845\u4554\u534e\u4f49\u5f4e\u414e\u454d\u0000";

    /// <summary>
    ///     vkCreateAccelerationStructureKHR - Create a new acceleration structure object -
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCreateAccelerationStructureKHR.html">
    ///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCreateAccelerationStructureKHR.html
    ///     </a>
    /// </summary>
    /// <param name="device">device is the logical device that creates the acceleration structure object.</param>
    /// <param name="pCreateInfo">
    ///     pCreateInfo is a pointer to a VkAccelerationStructureCreateInfoKHR structure containing
    ///     parameters affecting creation of the acceleration structure.
    /// </param>
    /// <param name="pAllocator">pAllocator controls host memory allocation as described in the Memory Allocation chapter.</param>
    /// <param name="pAccelerationStructure">
    ///     pAccelerationStructure is a pointer to a VkAccelerationStructureKHR handle in
    ///     which the resulting acceleration structure object is returned.
    /// </param>
    /// <remarks>
    ///     <list type="table">
    ///         <item>
    ///             <term>successcodes</term><description>VK_SUCCESS</description>
    ///         </item>
    ///         <item>
    ///             <term>errorcodes</term>
    ///             <description>VK_ERROR_OUT_OF_HOST_MEMORY,VK_ERROR_INVALID_OPAQUE_CAPTURE_ADDRESS_KHR</description>
    ///         </item>
    ///     </list>
    /// </remarks>
    public static readonly delegate*<
        VkDevice /*device*/,
        VkAccelerationStructureCreateInfoKHR* /*pCreateInfo*/,
        VkAllocationCallbacks* /*pAllocator*/,
        VkAccelerationStructureKHR* /*pAccelerationStructure*/,
        VkResult> vkCreateAccelerationStructureKHR = null;

    /// <summary>
    ///     vkDestroyAccelerationStructureKHR - Destroy an acceleration structure object -
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkDestroyAccelerationStructureKHR.html">
    ///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkDestroyAccelerationStructureKHR.html
    ///     </a>
    /// </summary>
    /// <param name="device">device is the logical device that destroys the acceleration structure.</param>
    /// <param name="accelerationStructure">accelerationStructure is the acceleration structure to destroy.</param>
    /// <param name="pAllocator">pAllocator controls host memory allocation as described in the Memory Allocation chapter.</param>
    public static readonly delegate*<
        VkDevice /*device*/,
        VkAccelerationStructureKHR /*accelerationStructure*/,
        VkAllocationCallbacks* /*pAllocator*/,
        void> vkDestroyAccelerationStructureKHR = null;

    /// <summary>
    ///     vkCmdBuildAccelerationStructuresKHR - Build an acceleration structure -
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdBuildAccelerationStructuresKHR.html">
    ///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdBuildAccelerationStructuresKHR.html
    ///     </a>
    /// </summary>
    /// <param name="commandBuffer">commandBuffer is the command buffer into which the command will be recorded.</param>
    /// <param name="infoCount">
    ///     infoCount is the number of acceleration structures to build. It specifies the number of the
    ///     pInfos structures and ppBuildRangeInfos pointers that must be provided.
    /// </param>
    /// <param name="pInfos">
    ///     pInfos is a pointer to an array of infoCountVkAccelerationStructureBuildGeometryInfoKHR structures
    ///     defining the geometry used to build each acceleration structure.
    /// </param>
    /// <param name="ppBuildRangeInfos">
    ///     ppBuildRangeInfos is a pointer to an array of infoCountpointers to arrays of
    ///     VkAccelerationStructureBuildRangeInfoKHRstructures. Each ppBuildRangeInfos[i] is a pointer to an array of
    ///     pInfos[i].geometryCountVkAccelerationStructureBuildRangeInfoKHR structures defining dynamic offsets to the
    ///     addresses where geometry data is stored, as defined by pInfos[i].
    /// </param>
    public static readonly delegate*<
        VkCommandBuffer /*commandBuffer*/,
        uint /*infoCount*/,
        VkAccelerationStructureBuildGeometryInfoKHR* /*pInfos*/,
        VkAccelerationStructureBuildRangeInfoKHR** /*ppBuildRangeInfos*/,
        void> vkCmdBuildAccelerationStructuresKHR = null;

    /// <summary>
    ///     vkCmdBuildAccelerationStructuresIndirectKHR - Build an acceleration structure with some parameters provided on the
    ///     device -
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdBuildAccelerationStructuresIndirectKHR.html">
    ///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdBuildAccelerationStructuresIndirectKHR.html
    ///     </a>
    /// </summary>
    /// <param name="commandBuffer">commandBuffer is the command buffer into which the command will be recorded.</param>
    /// <param name="infoCount">infoCount is the number of acceleration structures to build.</param>
    /// <param name="pInfos">
    ///     pInfos is a pointer to an array of infoCountVkAccelerationStructureBuildGeometryInfoKHR structures
    ///     defining the geometry used to build each acceleration structure.
    /// </param>
    /// <param name="pIndirectDeviceAddresses">
    ///     pIndirectDeviceAddresses is a pointer to an array of infoCount buffer device
    ///     addresses which point to pInfos[i].geometryCountVkAccelerationStructureBuildRangeInfoKHR structures defining
    ///     dynamic offsets to the addresses where geometry data is stored, as defined by pInfos[i].
    /// </param>
    /// <param name="pIndirectStrides">
    ///     pIndirectStrides is a pointer to an array of infoCount byte strides between elements of
    ///     pIndirectDeviceAddresses.
    /// </param>
    /// <param name="ppMaxPrimitiveCounts">
    ///     ppMaxPrimitiveCounts is a pointer to an array of infoCountpointers to arrays of
    ///     pInfos[i].geometryCount values indicating the maximum number of primitives that will be built by this command for
    ///     each geometry.
    /// </param>
    public static readonly delegate*<
        VkCommandBuffer /*commandBuffer*/,
        uint /*infoCount*/,
        VkAccelerationStructureBuildGeometryInfoKHR* /*pInfos*/,
        VkDeviceAddress* /*pIndirectDeviceAddresses*/,
        uint* /*pIndirectStrides*/,
        uint** /*ppMaxPrimitiveCounts*/,
        void> vkCmdBuildAccelerationStructuresIndirectKHR = null;

    /// <summary>
    ///     vkBuildAccelerationStructuresKHR - Build an acceleration structure on the host -
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkBuildAccelerationStructuresKHR.html">
    ///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkBuildAccelerationStructuresKHR.html
    ///     </a>
    /// </summary>
    /// <param name="device">device is the VkDevice for which the acceleration structures are being built.</param>
    /// <param name="deferredOperation">
    ///     deferredOperation is an optional VkDeferredOperationKHR to request deferral for this
    ///     command.
    /// </param>
    /// <param name="infoCount">
    ///     infoCount is the number of acceleration structures to build. It specifies the number of the
    ///     pInfos structures and ppBuildRangeInfos pointers that must be provided.
    /// </param>
    /// <param name="pInfos">
    ///     pInfos is a pointer to an array of infoCountVkAccelerationStructureBuildGeometryInfoKHR structures
    ///     defining the geometry used to build each acceleration structure.
    /// </param>
    /// <param name="ppBuildRangeInfos">
    ///     ppBuildRangeInfos is a pointer to an array of infoCountpointers to arrays of
    ///     VkAccelerationStructureBuildRangeInfoKHRstructures. Each ppBuildRangeInfos[i] is a pointer to an array of
    ///     pInfos[i].geometryCountVkAccelerationStructureBuildRangeInfoKHR structures defining dynamic offsets to the
    ///     addresses where geometry data is stored, as defined by pInfos[i].
    /// </param>
    /// <remarks>
    ///     <list type="table">
    ///         <item>
    ///             <term>successcodes</term>
    ///             <description>VK_SUCCESS,VK_OPERATION_DEFERRED_KHR,VK_OPERATION_NOT_DEFERRED_KHR</description>
    ///         </item>
    ///         <item>
    ///             <term>errorcodes</term><description>VK_ERROR_OUT_OF_HOST_MEMORY,VK_ERROR_OUT_OF_DEVICE_MEMORY</description>
    ///         </item>
    ///     </list>
    /// </remarks>
    public static readonly delegate*<
        VkDevice /*device*/,
        VkDeferredOperationKHR /*deferredOperation*/,
        uint /*infoCount*/,
        VkAccelerationStructureBuildGeometryInfoKHR* /*pInfos*/,
        VkAccelerationStructureBuildRangeInfoKHR** /*ppBuildRangeInfos*/,
        VkResult> vkBuildAccelerationStructuresKHR = null;

    /// <summary>
    ///     vkCopyAccelerationStructureKHR - Copy an acceleration structure on the host -
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCopyAccelerationStructureKHR.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCopyAccelerationStructureKHR.html</a>
    /// </summary>
    /// <param name="device">device is the device which owns the acceleration structures.</param>
    /// <param name="deferredOperation">
    ///     deferredOperation is an optional VkDeferredOperationKHR to request deferral for this
    ///     command.
    /// </param>
    /// <param name="pInfo">pInfo is a pointer to a VkCopyAccelerationStructureInfoKHRstructure defining the copy operation.</param>
    /// <remarks>
    ///     <list type="table">
    ///         <item>
    ///             <term>successcodes</term>
    ///             <description>VK_SUCCESS,VK_OPERATION_DEFERRED_KHR,VK_OPERATION_NOT_DEFERRED_KHR</description>
    ///         </item>
    ///         <item>
    ///             <term>errorcodes</term><description>VK_ERROR_OUT_OF_HOST_MEMORY,VK_ERROR_OUT_OF_DEVICE_MEMORY</description>
    ///         </item>
    ///     </list>
    /// </remarks>
    public static readonly delegate*<
        VkDevice /*device*/,
        VkDeferredOperationKHR /*deferredOperation*/,
        VkCopyAccelerationStructureInfoKHR* /*pInfo*/,
        VkResult> vkCopyAccelerationStructureKHR = null;

    /// <summary>
    ///     vkCopyAccelerationStructureToMemoryKHR - Serialize an acceleration structure on the host -
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCopyAccelerationStructureToMemoryKHR.html">
    ///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCopyAccelerationStructureToMemoryKHR.html
    ///     </a>
    /// </summary>
    /// <param name="device">device is the device which owns pInfo-&gt;src.</param>
    /// <param name="deferredOperation">
    ///     deferredOperation is an optional VkDeferredOperationKHR to request deferral for this
    ///     command.
    /// </param>
    /// <param name="pInfo">
    ///     pInfo is a pointer to a VkCopyAccelerationStructureToMemoryInfoKHR structure defining the copy
    ///     operation.
    /// </param>
    /// <remarks>
    ///     <list type="table">
    ///         <item>
    ///             <term>successcodes</term>
    ///             <description>VK_SUCCESS,VK_OPERATION_DEFERRED_KHR,VK_OPERATION_NOT_DEFERRED_KHR</description>
    ///         </item>
    ///         <item>
    ///             <term>errorcodes</term><description>VK_ERROR_OUT_OF_HOST_MEMORY,VK_ERROR_OUT_OF_DEVICE_MEMORY</description>
    ///         </item>
    ///     </list>
    /// </remarks>
    public static readonly delegate*<
        VkDevice /*device*/,
        VkDeferredOperationKHR /*deferredOperation*/,
        VkCopyAccelerationStructureToMemoryInfoKHR* /*pInfo*/,
        VkResult> vkCopyAccelerationStructureToMemoryKHR = null;

    /// <summary>
    ///     vkCopyMemoryToAccelerationStructureKHR - Deserialize an acceleration structure on the host -
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCopyMemoryToAccelerationStructureKHR.html">
    ///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCopyMemoryToAccelerationStructureKHR.html
    ///     </a>
    /// </summary>
    /// <param name="device">device is the device which owns pInfo-&gt;dst.</param>
    /// <param name="deferredOperation">
    ///     deferredOperation is an optional VkDeferredOperationKHR to request deferral for this
    ///     command.
    /// </param>
    /// <param name="pInfo">
    ///     pInfo is a pointer to a VkCopyMemoryToAccelerationStructureInfoKHR structure defining the copy
    ///     operation.
    /// </param>
    /// <remarks>
    ///     <list type="table">
    ///         <item>
    ///             <term>successcodes</term>
    ///             <description>VK_SUCCESS,VK_OPERATION_DEFERRED_KHR,VK_OPERATION_NOT_DEFERRED_KHR</description>
    ///         </item>
    ///         <item>
    ///             <term>errorcodes</term><description>VK_ERROR_OUT_OF_HOST_MEMORY,VK_ERROR_OUT_OF_DEVICE_MEMORY</description>
    ///         </item>
    ///     </list>
    /// </remarks>
    public static readonly delegate*<
        VkDevice /*device*/,
        VkDeferredOperationKHR /*deferredOperation*/,
        VkCopyMemoryToAccelerationStructureInfoKHR* /*pInfo*/,
        VkResult> vkCopyMemoryToAccelerationStructureKHR = null;

    /// <summary>
    ///     vkWriteAccelerationStructuresPropertiesKHR - Query acceleration structure meta-data on the host -
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkWriteAccelerationStructuresPropertiesKHR.html">
    ///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkWriteAccelerationStructuresPropertiesKHR.html
    ///     </a>
    /// </summary>
    /// <param name="device">device is the device which owns the acceleration structures in pAccelerationStructures.</param>
    /// <param name="accelerationStructureCount">
    ///     accelerationStructureCount is the count of acceleration structures for which
    ///     to query the property.
    /// </param>
    /// <param name="pAccelerationStructures">
    ///     pAccelerationStructures is a pointer to an array of existing previously built
    ///     acceleration structures.
    /// </param>
    /// <param name="queryType">queryType is a VkQueryType value specifying the property to be queried.</param>
    /// <param name="dataSize">dataSize is the size in bytes of the buffer pointed to by pData.</param>
    /// <param name="pData">pData is a pointer to a user-allocated buffer where the results will be written.</param>
    /// <param name="stride">stride is the stride in bytes between results for individual queries within pData.</param>
    /// <remarks>
    ///     <list type="table">
    ///         <item>
    ///             <term>successcodes</term><description>VK_SUCCESS</description>
    ///         </item>
    ///         <item>
    ///             <term>errorcodes</term><description>VK_ERROR_OUT_OF_HOST_MEMORY,VK_ERROR_OUT_OF_DEVICE_MEMORY</description>
    ///         </item>
    ///     </list>
    /// </remarks>
    public static readonly delegate*<
        VkDevice /*device*/,
        uint /*accelerationStructureCount*/,
        VkAccelerationStructureKHR* /*pAccelerationStructures*/,
        VkQueryType /*queryType*/,
        nuint /*dataSize*/,
        void* /*pData*/,
        nuint /*stride*/,
        VkResult> vkWriteAccelerationStructuresPropertiesKHR = null;

    /// <summary>
    ///     vkCmdCopyAccelerationStructureKHR - Copy an acceleration structure -
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdCopyAccelerationStructureKHR.html">
    ///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdCopyAccelerationStructureKHR.html
    ///     </a>
    /// </summary>
    /// <param name="commandBuffer">commandBuffer is the command buffer into which the command will be recorded.</param>
    /// <param name="pInfo">pInfo is a pointer to a VkCopyAccelerationStructureInfoKHRstructure defining the copy operation.</param>
    public static readonly delegate*<
        VkCommandBuffer /*commandBuffer*/,
        VkCopyAccelerationStructureInfoKHR* /*pInfo*/,
        void> vkCmdCopyAccelerationStructureKHR = null;

    /// <summary>
    ///     vkCmdCopyAccelerationStructureToMemoryKHR - Copy an acceleration structure to device memory -
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdCopyAccelerationStructureToMemoryKHR.html">
    ///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdCopyAccelerationStructureToMemoryKHR.html
    ///     </a>
    /// </summary>
    /// <param name="commandBuffer">commandBuffer is the command buffer into which the command will be recorded.</param>
    /// <param name="pInfo">
    ///     pInfo is an a pointer to a VkCopyAccelerationStructureToMemoryInfoKHR structure defining the copy
    ///     operation.
    /// </param>
    public static readonly delegate*<
        VkCommandBuffer /*commandBuffer*/,
        VkCopyAccelerationStructureToMemoryInfoKHR* /*pInfo*/,
        void> vkCmdCopyAccelerationStructureToMemoryKHR = null;

    /// <summary>
    ///     vkCmdCopyMemoryToAccelerationStructureKHR - Copy device memory to an acceleration structure -
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdCopyMemoryToAccelerationStructureKHR.html">
    ///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdCopyMemoryToAccelerationStructureKHR.html
    ///     </a>
    /// </summary>
    /// <param name="commandBuffer">commandBuffer is the command buffer into which the command will be recorded.</param>
    /// <param name="pInfo">
    ///     pInfo is a pointer to a VkCopyMemoryToAccelerationStructureInfoKHR structure defining the copy
    ///     operation.
    /// </param>
    public static readonly delegate*<
        VkCommandBuffer /*commandBuffer*/,
        VkCopyMemoryToAccelerationStructureInfoKHR* /*pInfo*/,
        void> vkCmdCopyMemoryToAccelerationStructureKHR = null;

    /// <summary>
    ///     vkGetAccelerationStructureDeviceAddressKHR - Query an address of a acceleration structure -
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkGetAccelerationStructureDeviceAddressKHR.html">
    ///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkGetAccelerationStructureDeviceAddressKHR.html
    ///     </a>
    /// </summary>
    /// <param name="device">device is the logical device that the acceleration structure was created on.</param>
    /// <param name="pInfo">
    ///     pInfo is a pointer to a VkAccelerationStructureDeviceAddressInfoKHR structure specifying the
    ///     acceleration structure to retrieve an address for.
    /// </param>
    public static readonly delegate*<
        VkDevice /*device*/,
        VkAccelerationStructureDeviceAddressInfoKHR* /*pInfo*/,
        VkDeviceAddress> vkGetAccelerationStructureDeviceAddressKHR = null;

    /// <summary>
    ///     vkCmdWriteAccelerationStructuresPropertiesKHR - Write acceleration structure result parameters to query results. -
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdWriteAccelerationStructuresPropertiesKHR.html">
    ///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdWriteAccelerationStructuresPropertiesKHR.html
    ///     </a>
    /// </summary>
    /// <param name="commandBuffer">commandBuffer is the command buffer into which the command will be recorded.</param>
    /// <param name="accelerationStructureCount">
    ///     accelerationStructureCount is the count of acceleration structures for which
    ///     to query the property.
    /// </param>
    /// <param name="pAccelerationStructures">
    ///     pAccelerationStructures is a pointer to an array of existing previously built
    ///     acceleration structures.
    /// </param>
    /// <param name="queryType">queryType is a VkQueryType value specifying the type of queries managed by the pool.</param>
    /// <param name="queryPool">queryPool is the query pool that will manage the results of the query.</param>
    /// <param name="firstQuery">
    ///     firstQuery is the first query index within the query pool that will contain the
    ///     accelerationStructureCount number of results.
    /// </param>
    public static readonly delegate*<
        VkCommandBuffer /*commandBuffer*/,
        uint /*accelerationStructureCount*/,
        VkAccelerationStructureKHR* /*pAccelerationStructures*/,
        VkQueryType /*queryType*/,
        VkQueryPool /*queryPool*/,
        uint /*firstQuery*/,
        void> vkCmdWriteAccelerationStructuresPropertiesKHR = null;

    /// <summary>
    ///     vkGetDeviceAccelerationStructureCompatibilityKHR - Check if a serialized acceleration structure is compatible with
    ///     the current device -
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkGetDeviceAccelerationStructureCompatibilityKHR.html">
    ///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkGetDeviceAccelerationStructureCompatibilityKHR.html
    ///     </a>
    /// </summary>
    /// <param name="device">device is the device to check the version against.</param>
    /// <param name="pVersionInfo">
    ///     pVersionInfo is a pointer to a VkAccelerationStructureVersionInfoKHR structure specifying
    ///     version information to check against the device.
    /// </param>
    /// <param name="pCompatibility">
    ///     pCompatibility is a pointer to a VkAccelerationStructureCompatibilityKHR value in which
    ///     compatibility information is returned.
    /// </param>
    public static readonly delegate*<
        VkDevice /*device*/,
        VkAccelerationStructureVersionInfoKHR* /*pVersionInfo*/,
        VkAccelerationStructureCompatibilityKHR* /*pCompatibility*/,
        void> vkGetDeviceAccelerationStructureCompatibilityKHR = null;

    /// <summary>
    ///     vkGetAccelerationStructureBuildSizesKHR - Retrieve the required size for an acceleration structure -
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkGetAccelerationStructureBuildSizesKHR.html">
    ///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkGetAccelerationStructureBuildSizesKHR.html
    ///     </a>
    /// </summary>
    /// <param name="device">device is the logical device that will be used for creating the acceleration structure.</param>
    /// <param name="buildType">buildType defines whether host or device operations (or both) are being queried for.</param>
    /// <param name="pBuildInfo">
    ///     pBuildInfo is a pointer to a VkAccelerationStructureBuildGeometryInfoKHR structure describing
    ///     parameters of a build operation.
    /// </param>
    /// <param name="pMaxPrimitiveCounts">
    ///     pMaxPrimitiveCounts is a pointer to an array of pBuildInfo-&gt;geometryCount uint32_t
    ///     values defining the number of primitives built into each geometry.
    /// </param>
    /// <param name="pSizeInfo">
    ///     pSizeInfo is a pointer to a VkAccelerationStructureBuildSizesInfoKHR structure which returns
    ///     the size required for an acceleration structure and the sizes required for the scratch buffers, given the build
    ///     parameters.
    /// </param>
    public static readonly delegate*<
        VkDevice /*device*/,
        VkAccelerationStructureBuildTypeKHR /*buildType*/,
        VkAccelerationStructureBuildGeometryInfoKHR* /*pBuildInfo*/,
        uint* /*pMaxPrimitiveCounts*/,
        VkAccelerationStructureBuildSizesInfoKHR* /*pSizeInfo*/,
        void> vkGetAccelerationStructureBuildSizesKHR = null;

    /// <summary> Loads all function pointer for this extension. </summary>
    /// <param name="instance"> The instance that the function pointers will be compatible with in fallback case. </param>
    /// <param name="device"> The device that the function pointers will be compatible with. </param>
    /// <remarks> The load method must always be executed first before a command of this extension can be used. </remarks>
    public static void Load(VkInstance instance, VkDevice device)
    {
        fixed (delegate*<VkDevice, VkAccelerationStructureCreateInfoKHR*, VkAllocationCallbacks*, VkAccelerationStructureKHR*, VkResult>* pvkCreateAccelerationStructureKHR =
                   &vkCreateAccelerationStructureKHR)
        {
            *pvkCreateAccelerationStructureKHR = (delegate*<VkDevice, VkAccelerationStructureCreateInfoKHR*, VkAllocationCallbacks*, VkAccelerationStructureKHR*, VkResult>)Core.Vk.GetVkFunction(
                instance, device, "\u6b76\u7243\u6165\u6574\u6341\u6563\u656c\u6172\u6974\u6e6f\u7453\u7572\u7463\u7275\u4b65\u5248\u0000");
        }
        fixed (delegate*<VkDevice, VkAccelerationStructureKHR, VkAllocationCallbacks*, void>* pvkDestroyAccelerationStructureKHR = &vkDestroyAccelerationStructureKHR)
        {
            *pvkDestroyAccelerationStructureKHR = (delegate*<VkDevice, VkAccelerationStructureKHR, VkAllocationCallbacks*, void>)Core.Vk.GetVkFunction(
                instance, device, "\u6b76\u6544\u7473\u6f72\u4179\u6363\u6c65\u7265\u7461\u6f69\u536e\u7274\u6375\u7574\u6572\u484b\u0052");
        }
        fixed (delegate*<VkCommandBuffer, uint, VkAccelerationStructureBuildGeometryInfoKHR*, VkAccelerationStructureBuildRangeInfoKHR**, void>* pvkCmdBuildAccelerationStructuresKHR =
                   &vkCmdBuildAccelerationStructuresKHR)
        {
            *pvkCmdBuildAccelerationStructuresKHR =
                (delegate*<VkCommandBuffer, uint, VkAccelerationStructureBuildGeometryInfoKHR*, VkAccelerationStructureBuildRangeInfoKHR**, void>)Core.Vk.GetVkFunction(
                    instance, device, "\u6b76\u6d43\u4264\u6975\u646c\u6341\u6563\u656c\u6172\u6974\u6e6f\u7453\u7572\u7463\u7275\u7365\u484b\u0052");
        }
        fixed (delegate*<VkCommandBuffer, uint, VkAccelerationStructureBuildGeometryInfoKHR*, VkDeviceAddress*, uint*, uint**, void>* pvkCmdBuildAccelerationStructuresIndirectKHR =
                   &vkCmdBuildAccelerationStructuresIndirectKHR)
        {
            *pvkCmdBuildAccelerationStructuresIndirectKHR =
                (delegate*<VkCommandBuffer, uint, VkAccelerationStructureBuildGeometryInfoKHR*, VkDeviceAddress*, uint*, uint**, void>)Core.Vk.GetVkFunction(
                    instance, device, "\u6b76\u6d43\u4264\u6975\u646c\u6341\u6563\u656c\u6172\u6974\u6e6f\u7453\u7572\u7463\u7275\u7365\u6e49\u6964\u6572\u7463\u484b\u0052");
        }
        fixed (delegate*<VkDevice, VkDeferredOperationKHR, uint, VkAccelerationStructureBuildGeometryInfoKHR*, VkAccelerationStructureBuildRangeInfoKHR**, VkResult>*
               pvkBuildAccelerationStructuresKHR = &vkBuildAccelerationStructuresKHR)
        {
            *pvkBuildAccelerationStructuresKHR =
                (delegate*<VkDevice, VkDeferredOperationKHR, uint, VkAccelerationStructureBuildGeometryInfoKHR*, VkAccelerationStructureBuildRangeInfoKHR**, VkResult>)Core.Vk.GetVkFunction(
                    instance, device, "\u6b76\u7542\u6c69\u4164\u6363\u6c65\u7265\u7461\u6f69\u536e\u7274\u6375\u7574\u6572\u4b73\u5248\u0000");
        }
        fixed (delegate*<VkDevice, VkDeferredOperationKHR, VkCopyAccelerationStructureInfoKHR*, VkResult>* pvkCopyAccelerationStructureKHR = &vkCopyAccelerationStructureKHR)
        {
            *pvkCopyAccelerationStructureKHR = (delegate*<VkDevice, VkDeferredOperationKHR, VkCopyAccelerationStructureInfoKHR*, VkResult>)Core.Vk.GetVkFunction(
                instance, device, "\u6b76\u6f43\u7970\u6341\u6563\u656c\u6172\u6974\u6e6f\u7453\u7572\u7463\u7275\u4b65\u5248\u0000");
        }
        fixed (delegate*<VkDevice, VkDeferredOperationKHR, VkCopyAccelerationStructureToMemoryInfoKHR*, VkResult>* pvkCopyAccelerationStructureToMemoryKHR = &vkCopyAccelerationStructureToMemoryKHR)
        {
            *pvkCopyAccelerationStructureToMemoryKHR = (delegate*<VkDevice, VkDeferredOperationKHR, VkCopyAccelerationStructureToMemoryInfoKHR*, VkResult>)Core.Vk.GetVkFunction(
                instance, device, "\u6b76\u6f43\u7970\u6341\u6563\u656c\u6172\u6974\u6e6f\u7453\u7572\u7463\u7275\u5465\u4d6f\u6d65\u726f\u4b79\u5248\u0000");
        }
        fixed (delegate*<VkDevice, VkDeferredOperationKHR, VkCopyMemoryToAccelerationStructureInfoKHR*, VkResult>* pvkCopyMemoryToAccelerationStructureKHR = &vkCopyMemoryToAccelerationStructureKHR)
        {
            *pvkCopyMemoryToAccelerationStructureKHR = (delegate*<VkDevice, VkDeferredOperationKHR, VkCopyMemoryToAccelerationStructureInfoKHR*, VkResult>)Core.Vk.GetVkFunction(
                instance, device, "\u6b76\u6f43\u7970\u654d\u6f6d\u7972\u6f54\u6341\u6563\u656c\u6172\u6974\u6e6f\u7453\u7572\u7463\u7275\u4b65\u5248\u0000");
        }
        fixed (delegate*<VkDevice, uint, VkAccelerationStructureKHR*, VkQueryType, nuint, void*, nuint, VkResult>* pvkWriteAccelerationStructuresPropertiesKHR =
                   &vkWriteAccelerationStructuresPropertiesKHR)
        {
            *pvkWriteAccelerationStructuresPropertiesKHR = (delegate*<VkDevice, uint, VkAccelerationStructureKHR*, VkQueryType, nuint, void*, nuint, VkResult>)Core.Vk.GetVkFunction(
                instance, device, "\u6b76\u7257\u7469\u4165\u6363\u6c65\u7265\u7461\u6f69\u536e\u7274\u6375\u7574\u6572\u5073\u6f72\u6570\u7472\u6569\u4b73\u5248\u0000");
        }
        fixed (delegate*<VkCommandBuffer, VkCopyAccelerationStructureInfoKHR*, void>* pvkCmdCopyAccelerationStructureKHR = &vkCmdCopyAccelerationStructureKHR)
        {
            *pvkCmdCopyAccelerationStructureKHR = (delegate*<VkCommandBuffer, VkCopyAccelerationStructureInfoKHR*, void>)Core.Vk.GetVkFunction(
                instance, device, "\u6b76\u6d43\u4364\u706f\u4179\u6363\u6c65\u7265\u7461\u6f69\u536e\u7274\u6375\u7574\u6572\u484b\u0052");
        }
        fixed (delegate*<VkCommandBuffer, VkCopyAccelerationStructureToMemoryInfoKHR*, void>* pvkCmdCopyAccelerationStructureToMemoryKHR = &vkCmdCopyAccelerationStructureToMemoryKHR)
        {
            *pvkCmdCopyAccelerationStructureToMemoryKHR = (delegate*<VkCommandBuffer, VkCopyAccelerationStructureToMemoryInfoKHR*, void>)Core.Vk.GetVkFunction(
                instance, device, "\u6b76\u6d43\u4364\u706f\u4179\u6363\u6c65\u7265\u7461\u6f69\u536e\u7274\u6375\u7574\u6572\u6f54\u654d\u6f6d\u7972\u484b\u0052");
        }
        fixed (delegate*<VkCommandBuffer, VkCopyMemoryToAccelerationStructureInfoKHR*, void>* pvkCmdCopyMemoryToAccelerationStructureKHR = &vkCmdCopyMemoryToAccelerationStructureKHR)
        {
            *pvkCmdCopyMemoryToAccelerationStructureKHR = (delegate*<VkCommandBuffer, VkCopyMemoryToAccelerationStructureInfoKHR*, void>)Core.Vk.GetVkFunction(
                instance, device, "\u6b76\u6d43\u4364\u706f\u4d79\u6d65\u726f\u5479\u416f\u6363\u6c65\u7265\u7461\u6f69\u536e\u7274\u6375\u7574\u6572\u484b\u0052");
        }
        fixed (delegate*<VkDevice, VkAccelerationStructureDeviceAddressInfoKHR*, VkDeviceAddress>* pvkGetAccelerationStructureDeviceAddressKHR = &vkGetAccelerationStructureDeviceAddressKHR)
        {
            *pvkGetAccelerationStructureDeviceAddressKHR = (delegate*<VkDevice, VkAccelerationStructureDeviceAddressInfoKHR*, VkDeviceAddress>)Core.Vk.GetVkFunction(
                instance, device, "\u6b76\u6547\u4174\u6363\u6c65\u7265\u7461\u6f69\u536e\u7274\u6375\u7574\u6572\u6544\u6976\u6563\u6441\u7264\u7365\u4b73\u5248\u0000");
        }
        fixed (delegate*<VkCommandBuffer, uint, VkAccelerationStructureKHR*, VkQueryType, VkQueryPool, uint, void>* pvkCmdWriteAccelerationStructuresPropertiesKHR =
                   &vkCmdWriteAccelerationStructuresPropertiesKHR)
        {
            *pvkCmdWriteAccelerationStructuresPropertiesKHR = (delegate*<VkCommandBuffer, uint, VkAccelerationStructureKHR*, VkQueryType, VkQueryPool, uint, void>)Core.Vk.GetVkFunction(
                instance, device, "\u6b76\u6d43\u5764\u6972\u6574\u6341\u6563\u656c\u6172\u6974\u6e6f\u7453\u7572\u7463\u7275\u7365\u7250\u706f\u7265\u6974\u7365\u484b\u0052");
        }
        fixed (delegate*<VkDevice, VkAccelerationStructureVersionInfoKHR*, VkAccelerationStructureCompatibilityKHR*, void>* pvkGetDeviceAccelerationStructureCompatibilityKHR =
                   &vkGetDeviceAccelerationStructureCompatibilityKHR)
        {
            *pvkGetDeviceAccelerationStructureCompatibilityKHR = (delegate*<VkDevice, VkAccelerationStructureVersionInfoKHR*, VkAccelerationStructureCompatibilityKHR*, void>)Core.Vk.GetVkFunction(
                instance, device, "\u6b76\u6547\u4474\u7665\u6369\u4165\u6363\u6c65\u7265\u7461\u6f69\u536e\u7274\u6375\u7574\u6572\u6f43\u706d\u7461\u6269\u6c69\u7469\u4b79\u5248\u0000");
        }
        fixed (delegate*<VkDevice, VkAccelerationStructureBuildTypeKHR, VkAccelerationStructureBuildGeometryInfoKHR*, uint*, VkAccelerationStructureBuildSizesInfoKHR*, void>*
               pvkGetAccelerationStructureBuildSizesKHR = &vkGetAccelerationStructureBuildSizesKHR)
        {
            *pvkGetAccelerationStructureBuildSizesKHR =
                (delegate*<VkDevice, VkAccelerationStructureBuildTypeKHR, VkAccelerationStructureBuildGeometryInfoKHR*, uint*, VkAccelerationStructureBuildSizesInfoKHR*, void>)Core.Vk.GetVkFunction(
                    instance, device, "\u6b76\u6547\u4174\u6363\u6c65\u7265\u7461\u6f69\u536e\u7274\u6375\u7574\u6572\u7542\u6c69\u5364\u7a69\u7365\u484b\u0052");
        }
    }
}