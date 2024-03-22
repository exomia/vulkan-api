#region License

// Copyright (c) 2018-2024, exomia
// All rights reserved.
// 
// This source code is licensed under the BSD-style license found in the
// LICENSE file in the root directory of this source tree.

#endregion

global using static Exomia.Vulkan.Api.Core.VkExtOpacityMicromap;

#pragma warning disable CA2211 // Non-constant fields should not be visible
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

// ReSharper disable UnusedMember.Global
// ReSharper disable InconsistentNaming
// ReSharper disable once CheckNamespace
namespace Exomia.Vulkan.Api.Core;

/// <summary>
///     VK_EXT_opacity_micromap - device extension (nr. 397) - author 'EXT' [platform '' | contact 'Christoph Kubisch
///     @pixeljetstream, Eric Werness']<br />
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_EXT_opacity_micromap.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_EXT_opacity_micromap.html</a>
/// </summary>
[VkDepends("VK_KHR_acceleration_structure+(VK_KHR_synchronization2,VK_VERSION_1_3)")]
[VkDeviceExt]
public static unsafe class VkExtOpacityMicromap
{
    /// <summary> The spec version. </summary>
    public const uint VK_EXT_OPACITY_MICROMAP_SPEC_VERSION = 2;

    /// <summary> The extension name. </summary>
    public const string VK_EXT_OPACITY_MICROMAP_EXTENSION_NAME = "VK_EXT_opacity_micromap";

    /// <summary>
    ///     An UTF8 null terminated version of <see cref="VK_EXT_OPACITY_MICROMAP_EXTENSION_NAME" /> represented by an
    ///     UTF16 string.
    /// </summary>
    /// <remarks>
    ///     Example usage:<br />
    ///     <br />
    ///     fixed(char* ptr = VK_EXT_OPACITY_MICROMAP_EXTENSION_NAME_UTF8_NT) {<br />
    ///     sbyte* utf8NtPtr = (sbyte*)ptr; // utf8NtPtr - can now be passed and used directly as a utf8_nt string for
    ///     unmanaged code.<br />
    ///     }
    /// </remarks>
    public const string VK_EXT_OPACITY_MICROMAP_EXTENSION_NAME_UTF8_NT = "\u4b56\u455f\u5458\u4f5f\u4150\u4943\u5954\u4d5f\u4349\u4f52\u414d\u5f50\u5845\u4554\u534e\u4f49\u5f4e\u414e\u454d\u0000";

    /// <summary>
    ///     vkCreateMicromapEXT - Create a new micromap object -
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCreateMicromapEXT.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCreateMicromapEXT.html</a>
    /// </summary>
    /// <param name="device">device is the logical device that creates the acceleration structure object.</param>
    /// <param name="pCreateInfo">
    ///     pCreateInfo is a pointer to a VkMicromapCreateInfoEXTstructure containing parameters
    ///     affecting creation of the micromap.
    /// </param>
    /// <param name="pAllocator">pAllocator controls host memory allocation as described in the Memory Allocation chapter.</param>
    /// <param name="pMicromap">
    ///     pMicromap is a pointer to a VkMicromapEXT handle in which the resulting micromap object is
    ///     returned.
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
        VkMicromapCreateInfoEXT* /*pCreateInfo*/,
        VkAllocationCallbacks* /*pAllocator*/,
        VkMicromapEXT* /*pMicromap*/,
        VkResult> vkCreateMicromapEXT = null;

    /// <summary>
    ///     vkDestroyMicromapEXT - Destroy a micromap object -
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkDestroyMicromapEXT.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkDestroyMicromapEXT.html</a>
    /// </summary>
    /// <param name="device">device is the logical device that destroys the micromap.</param>
    /// <param name="micromap">micromap is the micromap to destroy.</param>
    /// <param name="pAllocator">pAllocator controls host memory allocation as described in the Memory Allocation chapter.</param>
    public static readonly delegate*<
        VkDevice /*device*/,
        VkMicromapEXT /*micromap*/,
        VkAllocationCallbacks* /*pAllocator*/,
        void> vkDestroyMicromapEXT = null;

    /// <summary>
    ///     vkCmdBuildMicromapsEXT - Build a micromap -
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdBuildMicromapsEXT.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdBuildMicromapsEXT.html</a>
    /// </summary>
    /// <param name="commandBuffer">commandBuffer is the command buffer into which the command will be recorded.</param>
    /// <param name="infoCount">
    ///     infoCount is the number of micromaps to build. It specifies the number of the pInfos structures
    ///     that must be provided.
    /// </param>
    /// <param name="pInfos">
    ///     pInfos is a pointer to an array of infoCountVkMicromapBuildInfoEXT structures defining the data
    ///     used to build each micromap.
    /// </param>
    public static readonly delegate*<
        VkCommandBuffer /*commandBuffer*/,
        uint /*infoCount*/,
        VkMicromapBuildInfoEXT* /*pInfos*/,
        void> vkCmdBuildMicromapsEXT = null;

    /// <summary>
    ///     vkBuildMicromapsEXT - Build a micromap on the host -
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkBuildMicromapsEXT.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkBuildMicromapsEXT.html</a>
    /// </summary>
    /// <param name="device">device is the VkDevice for which the micromaps are being built.</param>
    /// <param name="deferredOperation">
    ///     deferredOperation is an optional VkDeferredOperationKHR to request deferral for this
    ///     command.
    /// </param>
    /// <param name="infoCount">
    ///     infoCount is the number of micromaps to build. It specifies the number of the pInfos that must
    ///     be provided.
    /// </param>
    /// <param name="pInfos">
    ///     pInfos is a pointer to an array of infoCountVkMicromapBuildInfoEXT structures defining the
    ///     geometry used to build each micromap.
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
        VkMicromapBuildInfoEXT* /*pInfos*/,
        VkResult> vkBuildMicromapsEXT = null;

    /// <summary>
    ///     vkCopyMicromapEXT - Copy a micromap on the host -
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCopyMicromapEXT.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCopyMicromapEXT.html</a>
    /// </summary>
    /// <param name="device">device is the device which owns the micromaps.</param>
    /// <param name="deferredOperation">
    ///     deferredOperation is an optional VkDeferredOperationKHR to request deferral for this
    ///     command.
    /// </param>
    /// <param name="pInfo">pInfo is a pointer to a VkCopyMicromapInfoEXT structure defining the copy operation.</param>
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
        VkCopyMicromapInfoEXT* /*pInfo*/,
        VkResult> vkCopyMicromapEXT = null;

    /// <summary>
    ///     vkCopyMicromapToMemoryEXT - Serialize a micromap on the host -
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCopyMicromapToMemoryEXT.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCopyMicromapToMemoryEXT.html</a>
    /// </summary>
    /// <param name="device">device is the device which owns pInfo-&gt;src.</param>
    /// <param name="deferredOperation">
    ///     deferredOperation is an optional VkDeferredOperationKHR to request deferral for this
    ///     command.
    /// </param>
    /// <param name="pInfo">pInfo is a pointer to a VkCopyMicromapToMemoryInfoEXTstructure defining the copy operation.</param>
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
        VkCopyMicromapToMemoryInfoEXT* /*pInfo*/,
        VkResult> vkCopyMicromapToMemoryEXT = null;

    /// <summary>
    ///     vkCopyMemoryToMicromapEXT - Deserialize a micromap on the host -
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCopyMemoryToMicromapEXT.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCopyMemoryToMicromapEXT.html</a>
    /// </summary>
    /// <param name="device">device is the device which owns pInfo-&gt;dst.</param>
    /// <param name="deferredOperation">
    ///     deferredOperation is an optional VkDeferredOperationKHR to request deferral for this
    ///     command.
    /// </param>
    /// <param name="pInfo">pInfo is a pointer to a VkCopyMemoryToMicromapInfoEXTstructure defining the copy operation.</param>
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
        VkCopyMemoryToMicromapInfoEXT* /*pInfo*/,
        VkResult> vkCopyMemoryToMicromapEXT = null;

    /// <summary>
    ///     vkWriteMicromapsPropertiesEXT - Query micromap meta-data on the host -
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkWriteMicromapsPropertiesEXT.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkWriteMicromapsPropertiesEXT.html</a>
    /// </summary>
    /// <param name="device">device is the device which owns the micromaps in pMicromaps.</param>
    /// <param name="micromapCount">micromapCount is the count of micromaps for which to query the property.</param>
    /// <param name="pMicromaps">pMicromaps is a pointer to an array of existing previously built micromaps.</param>
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
        uint /*micromapCount*/,
        VkMicromapEXT* /*pMicromaps*/,
        VkQueryType /*queryType*/,
        nuint /*dataSize*/,
        void* /*pData*/,
        nuint /*stride*/,
        VkResult> vkWriteMicromapsPropertiesEXT = null;

    /// <summary>
    ///     vkCmdCopyMicromapEXT - Copy a micromap -
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdCopyMicromapEXT.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdCopyMicromapEXT.html</a>
    /// </summary>
    /// <param name="commandBuffer">commandBuffer is the command buffer into which the command will be recorded.</param>
    /// <param name="pInfo">pInfo is a pointer to a VkCopyMicromapInfoEXT structure defining the copy operation.</param>
    public static readonly delegate*<
        VkCommandBuffer /*commandBuffer*/,
        VkCopyMicromapInfoEXT* /*pInfo*/,
        void> vkCmdCopyMicromapEXT = null;

    /// <summary>
    ///     vkCmdCopyMicromapToMemoryEXT - Copy a micromap to device memory -
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdCopyMicromapToMemoryEXT.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdCopyMicromapToMemoryEXT.html</a>
    /// </summary>
    /// <param name="commandBuffer">commandBuffer is the command buffer into which the command will be recorded.</param>
    /// <param name="pInfo">pInfo is an a pointer to a VkCopyMicromapToMemoryInfoEXTstructure defining the copy operation.</param>
    public static readonly delegate*<
        VkCommandBuffer /*commandBuffer*/,
        VkCopyMicromapToMemoryInfoEXT* /*pInfo*/,
        void> vkCmdCopyMicromapToMemoryEXT = null;

    /// <summary>
    ///     vkCmdCopyMemoryToMicromapEXT - Copy device memory to a micromap -
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdCopyMemoryToMicromapEXT.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdCopyMemoryToMicromapEXT.html</a>
    /// </summary>
    /// <param name="commandBuffer">commandBuffer is the command buffer into which the command will be recorded.</param>
    /// <param name="pInfo">pInfo is a pointer to a VkCopyMicromapToMemoryInfoEXTstructure defining the copy operation.</param>
    public static readonly delegate*<
        VkCommandBuffer /*commandBuffer*/,
        VkCopyMemoryToMicromapInfoEXT* /*pInfo*/,
        void> vkCmdCopyMemoryToMicromapEXT = null;

    /// <summary>
    ///     vkCmdWriteMicromapsPropertiesEXT - Write micromap result parameters to query results. -
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdWriteMicromapsPropertiesEXT.html">
    ///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdWriteMicromapsPropertiesEXT.html
    ///     </a>
    /// </summary>
    /// <param name="commandBuffer">commandBuffer is the command buffer into which the command will be recorded.</param>
    /// <param name="micromapCount">micromapCount is the count of micromaps for which to query the property.</param>
    /// <param name="pMicromaps">pMicromaps is a pointer to an array of existing previously built micromaps.</param>
    /// <param name="queryType">queryType is a VkQueryType value specifying the type of queries managed by the pool.</param>
    /// <param name="queryPool">queryPool is the query pool that will manage the results of the query.</param>
    /// <param name="firstQuery">
    ///     firstQuery is the first query index within the query pool that will contain the micromapCount
    ///     number of results.
    /// </param>
    public static readonly delegate*<
        VkCommandBuffer /*commandBuffer*/,
        uint /*micromapCount*/,
        VkMicromapEXT* /*pMicromaps*/,
        VkQueryType /*queryType*/,
        VkQueryPool /*queryPool*/,
        uint /*firstQuery*/,
        void> vkCmdWriteMicromapsPropertiesEXT = null;

    /// <summary>
    ///     vkGetDeviceMicromapCompatibilityEXT - Check if a serialized micromap is compatible with the current device -
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkGetDeviceMicromapCompatibilityEXT.html">
    ///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkGetDeviceMicromapCompatibilityEXT.html
    ///     </a>
    /// </summary>
    /// <param name="device">device is the device to check the version against.</param>
    /// <param name="pVersionInfo">
    ///     pVersionInfo is a pointer to a VkMicromapVersionInfoEXTstructure specifying version
    ///     information to check against the device.
    /// </param>
    /// <param name="pCompatibility">
    ///     pCompatibility is a pointer to a VkAccelerationStructureCompatibilityKHR value in which
    ///     compatibility information is returned.
    /// </param>
    public static readonly delegate*<
        VkDevice /*device*/,
        VkMicromapVersionInfoEXT* /*pVersionInfo*/,
        VkAccelerationStructureCompatibilityKHR* /*pCompatibility*/,
        void> vkGetDeviceMicromapCompatibilityEXT = null;

    /// <summary>
    ///     vkGetMicromapBuildSizesEXT - Retrieve the required size for a micromap -
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkGetMicromapBuildSizesEXT.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkGetMicromapBuildSizesEXT.html</a>
    /// </summary>
    /// <param name="device">device is the logical device that will be used for creating the micromap.</param>
    /// <param name="buildType">buildType defines whether host or device operations (or both) are being queried for.</param>
    /// <param name="pBuildInfo">
    ///     pBuildInfo is a pointer to a VkMicromapBuildInfoEXTstructure describing parameters of a build
    ///     operation.
    /// </param>
    /// <param name="pSizeInfo">
    ///     pSizeInfo is a pointer to a VkMicromapBuildSizesInfoEXTstructure which returns the size
    ///     required for a micromap and the sizes required for the scratch buffers, given the build parameters.
    /// </param>
    public static readonly delegate*<
        VkDevice /*device*/,
        VkAccelerationStructureBuildTypeKHR /*buildType*/,
        VkMicromapBuildInfoEXT* /*pBuildInfo*/,
        VkMicromapBuildSizesInfoEXT* /*pSizeInfo*/,
        void> vkGetMicromapBuildSizesEXT = null;

    /// <summary> Loads all function pointer based on the device for this extension. (see remarks!) </summary>
    /// <param name="device"> The device that the function pointers will be compatible with. </param>
    /// <remarks>
    ///     This load method makes the following function pointers available:<br />
    ///     <list type="bullet">
    ///         <item>
    ///             <description>vkCreateMicromapEXT</description>
    ///         </item>
    ///         <item>
    ///             <description>vkDestroyMicromapEXT</description>
    ///         </item>
    ///         <item>
    ///             <description>vkCmdBuildMicromapsEXT</description>
    ///         </item>
    ///         <item>
    ///             <description>vkBuildMicromapsEXT</description>
    ///         </item>
    ///         <item>
    ///             <description>vkCopyMicromapEXT</description>
    ///         </item>
    ///         <item>
    ///             <description>vkCopyMicromapToMemoryEXT</description>
    ///         </item>
    ///         <item>
    ///             <description>vkCopyMemoryToMicromapEXT</description>
    ///         </item>
    ///         <item>
    ///             <description>vkWriteMicromapsPropertiesEXT</description>
    ///         </item>
    ///         <item>
    ///             <description>vkCmdCopyMicromapEXT</description>
    ///         </item>
    ///         <item>
    ///             <description>vkCmdCopyMicromapToMemoryEXT</description>
    ///         </item>
    ///         <item>
    ///             <description>vkCmdCopyMemoryToMicromapEXT</description>
    ///         </item>
    ///         <item>
    ///             <description>vkCmdWriteMicromapsPropertiesEXT</description>
    ///         </item>
    ///         <item>
    ///             <description>vkGetDeviceMicromapCompatibilityEXT</description>
    ///         </item>
    ///         <item>
    ///             <description>vkGetMicromapBuildSizesEXT</description>
    ///         </item>
    ///     </list>
    /// </remarks>
    public static void Load(VkDevice device)
    {
        fixed (delegate*<VkDevice, VkMicromapCreateInfoEXT*, VkAllocationCallbacks*, VkMicromapEXT*, VkResult>* pvkCreateMicromapEXT = &vkCreateMicromapEXT)
        {
            *pvkCreateMicromapEXT =
                (delegate*<VkDevice, VkMicromapCreateInfoEXT*, VkAllocationCallbacks*, VkMicromapEXT*, VkResult>)GetVkFunction(device, "\u6b76\u7243\u6165\u6574\u694d\u7263\u6d6f\u7061\u5845\u0054");
        }

        fixed (delegate*<VkDevice, VkMicromapEXT, VkAllocationCallbacks*, void>* pvkDestroyMicromapEXT = &vkDestroyMicromapEXT)
        {
            *pvkDestroyMicromapEXT = (delegate*<VkDevice, VkMicromapEXT, VkAllocationCallbacks*, void>)GetVkFunction(device, "\u6b76\u6544\u7473\u6f72\u4d79\u6369\u6f72\u616d\u4570\u5458\u0000");
        }

        fixed (delegate*<VkCommandBuffer, uint, VkMicromapBuildInfoEXT*, void>* pvkCmdBuildMicromapsEXT = &vkCmdBuildMicromapsEXT)
        {
            *pvkCmdBuildMicromapsEXT =
                (delegate*<VkCommandBuffer, uint, VkMicromapBuildInfoEXT*, void>)GetVkFunction(device, "\u6b76\u6d43\u4264\u6975\u646c\u694d\u7263\u6d6f\u7061\u4573\u5458\u0000");
        }

        fixed (delegate*<VkDevice, VkDeferredOperationKHR, uint, VkMicromapBuildInfoEXT*, VkResult>* pvkBuildMicromapsEXT = &vkBuildMicromapsEXT)
        {
            *pvkBuildMicromapsEXT =
                (delegate*<VkDevice, VkDeferredOperationKHR, uint, VkMicromapBuildInfoEXT*, VkResult>)GetVkFunction(device, "\u6b76\u7542\u6c69\u4d64\u6369\u6f72\u616d\u7370\u5845\u0054");
        }

        fixed (delegate*<VkDevice, VkDeferredOperationKHR, VkCopyMicromapInfoEXT*, VkResult>* pvkCopyMicromapEXT = &vkCopyMicromapEXT)
        {
            *pvkCopyMicromapEXT = (delegate*<VkDevice, VkDeferredOperationKHR, VkCopyMicromapInfoEXT*, VkResult>)GetVkFunction(device, "\u6b76\u6f43\u7970\u694d\u7263\u6d6f\u7061\u5845\u0054");
        }

        fixed (delegate*<VkDevice, VkDeferredOperationKHR, VkCopyMicromapToMemoryInfoEXT*, VkResult>* pvkCopyMicromapToMemoryEXT = &vkCopyMicromapToMemoryEXT)
        {
            *pvkCopyMicromapToMemoryEXT = (delegate*<VkDevice, VkDeferredOperationKHR, VkCopyMicromapToMemoryInfoEXT*, VkResult>)GetVkFunction(
                device, "\u6b76\u6f43\u7970\u694d\u7263\u6d6f\u7061\u6f54\u654d\u6f6d\u7972\u5845\u0054");
        }

        fixed (delegate*<VkDevice, VkDeferredOperationKHR, VkCopyMemoryToMicromapInfoEXT*, VkResult>* pvkCopyMemoryToMicromapEXT = &vkCopyMemoryToMicromapEXT)
        {
            *pvkCopyMemoryToMicromapEXT = (delegate*<VkDevice, VkDeferredOperationKHR, VkCopyMemoryToMicromapInfoEXT*, VkResult>)GetVkFunction(
                device, "\u6b76\u6f43\u7970\u654d\u6f6d\u7972\u6f54\u694d\u7263\u6d6f\u7061\u5845\u0054");
        }

        fixed (delegate*<VkDevice, uint, VkMicromapEXT*, VkQueryType, nuint, void*, nuint, VkResult>* pvkWriteMicromapsPropertiesEXT = &vkWriteMicromapsPropertiesEXT)
        {
            *pvkWriteMicromapsPropertiesEXT = (delegate*<VkDevice, uint, VkMicromapEXT*, VkQueryType, nuint, void*, nuint, VkResult>)GetVkFunction(
                device, "\u6b76\u7257\u7469\u4d65\u6369\u6f72\u616d\u7370\u7250\u706f\u7265\u6974\u7365\u5845\u0054");
        }

        fixed (delegate*<VkCommandBuffer, VkCopyMicromapInfoEXT*, void>* pvkCmdCopyMicromapEXT = &vkCmdCopyMicromapEXT)
        {
            *pvkCmdCopyMicromapEXT = (delegate*<VkCommandBuffer, VkCopyMicromapInfoEXT*, void>)GetVkFunction(device, "\u6b76\u6d43\u4364\u706f\u4d79\u6369\u6f72\u616d\u4570\u5458\u0000");
        }

        fixed (delegate*<VkCommandBuffer, VkCopyMicromapToMemoryInfoEXT*, void>* pvkCmdCopyMicromapToMemoryEXT = &vkCmdCopyMicromapToMemoryEXT)
        {
            *pvkCmdCopyMicromapToMemoryEXT = (delegate*<VkCommandBuffer, VkCopyMicromapToMemoryInfoEXT*, void>)GetVkFunction(
                device, "\u6b76\u6d43\u4364\u706f\u4d79\u6369\u6f72\u616d\u5470\u4d6f\u6d65\u726f\u4579\u5458\u0000");
        }

        fixed (delegate*<VkCommandBuffer, VkCopyMemoryToMicromapInfoEXT*, void>* pvkCmdCopyMemoryToMicromapEXT = &vkCmdCopyMemoryToMicromapEXT)
        {
            *pvkCmdCopyMemoryToMicromapEXT = (delegate*<VkCommandBuffer, VkCopyMemoryToMicromapInfoEXT*, void>)GetVkFunction(
                device, "\u6b76\u6d43\u4364\u706f\u4d79\u6d65\u726f\u5479\u4d6f\u6369\u6f72\u616d\u4570\u5458\u0000");
        }

        fixed (delegate*<VkCommandBuffer, uint, VkMicromapEXT*, VkQueryType, VkQueryPool, uint, void>* pvkCmdWriteMicromapsPropertiesEXT = &vkCmdWriteMicromapsPropertiesEXT)
        {
            *pvkCmdWriteMicromapsPropertiesEXT = (delegate*<VkCommandBuffer, uint, VkMicromapEXT*, VkQueryType, VkQueryPool, uint, void>)GetVkFunction(
                device, "\u6b76\u6d43\u5764\u6972\u6574\u694d\u7263\u6d6f\u7061\u5073\u6f72\u6570\u7472\u6569\u4573\u5458\u0000");
        }

        fixed (delegate*<VkDevice, VkMicromapVersionInfoEXT*, VkAccelerationStructureCompatibilityKHR*, void>* pvkGetDeviceMicromapCompatibilityEXT = &vkGetDeviceMicromapCompatibilityEXT)
        {
            *pvkGetDeviceMicromapCompatibilityEXT = (delegate*<VkDevice, VkMicromapVersionInfoEXT*, VkAccelerationStructureCompatibilityKHR*, void>)GetVkFunction(
                device, "\u6b76\u6547\u4474\u7665\u6369\u4d65\u6369\u6f72\u616d\u4370\u6d6f\u6170\u6974\u6962\u696c\u7974\u5845\u0054");
        }

        fixed (delegate*<VkDevice, VkAccelerationStructureBuildTypeKHR, VkMicromapBuildInfoEXT*, VkMicromapBuildSizesInfoEXT*, void>* pvkGetMicromapBuildSizesEXT = &vkGetMicromapBuildSizesEXT)
        {
            *pvkGetMicromapBuildSizesEXT = (delegate*<VkDevice, VkAccelerationStructureBuildTypeKHR, VkMicromapBuildInfoEXT*, VkMicromapBuildSizesInfoEXT*, void>)GetVkFunction(
                device, "\u6b76\u6547\u4d74\u6369\u6f72\u616d\u4270\u6975\u646c\u6953\u657a\u4573\u5458\u0000");
        }
    }
}