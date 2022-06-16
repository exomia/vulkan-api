#region License

// Copyright (c) 2018-2022, exomia
// All rights reserved.
// 
// This source code is licensed under the BSD-style license found in the
// LICENSE file in the root directory of this source tree.

#endregion

namespace Exomia.Vulkan.Api.Core;

using System.Security;

/// <content>
///     VK_VERSION_1_0 - vulkan
/// </content>
public static partial class Vk
{
    /// <summary>
    ///     vkCreateInstance - Create a new Vulkan instance -
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCreateInstance.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCreateInstance.html</a>
    /// </summary>
    /// <param name="pCreateInfo">
    ///     pCreateInfo is a pointer to a VkInstanceCreateInfo structure controlling creation of the
    ///     instance.
    /// </param>
    /// <param name="pAllocator">pAllocator controls host memory allocation as described in the Memory Allocation chapter.</param>
    /// <param name="pInstance">pInstance points a VkInstance handle in which the resulting instance is returned.</param>
    /// <remarks>
    ///     <list type="table">
    ///         <item>
    ///             <term>successcodes</term><description>VK_SUCCESS</description>
    ///         </item>
    ///         <item>
    ///             <term>errorcodes</term>
    ///             <description>VK_ERROR_OUT_OF_HOST_MEMORY,VK_ERROR_OUT_OF_DEVICE_MEMORY,VK_ERROR_INITIALIZATION_FAILED,VK_ERROR_LAYER_NOT_PRESENT,VK_ERROR_EXTENSION_NOT_PRESENT,VK_ERROR_INCOMPATIBLE_DRIVER</description>
    ///         </item>
    ///     </list>
    /// </remarks>
    [VkVersion("1.0")]
    [SuppressUnmanagedCodeSecurity]
    [DllImport(VK_IMPORT, EntryPoint = "vkCreateInstance")]
    public static extern unsafe VkResult vkCreateInstance(
        VkInstanceCreateInfo*  pCreateInfo,
        VkAllocationCallbacks* pAllocator,
        VkInstance*            pInstance);

    /// <summary>
    ///     vkDestroyInstance - Destroy an instance of Vulkan -
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkDestroyInstance.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkDestroyInstance.html</a>
    /// </summary>
    /// <param name="instance">instance is the handle of the instance to destroy.</param>
    /// <param name="pAllocator">pAllocator controls host memory allocation as described in the Memory Allocation chapter.</param>
    [VkVersion("1.0")]
    [SuppressUnmanagedCodeSecurity]
    [DllImport(VK_IMPORT, EntryPoint = "vkDestroyInstance")]
    public static extern unsafe void vkDestroyInstance(
        VkInstance             instance,
        VkAllocationCallbacks* pAllocator);

    /// <summary>
    ///     vkEnumeratePhysicalDevices - Enumerates the physical devices accessible to a Vulkan instance -
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkEnumeratePhysicalDevices.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkEnumeratePhysicalDevices.html</a>
    /// </summary>
    /// <param name="instance">instance is a handle to a Vulkan instance previously created with vkCreateInstance.</param>
    /// <param name="pPhysicalDeviceCount">
    ///     pPhysicalDeviceCount is a pointer to an integer related to the number of physical
    ///     devices available or queried, as described below.
    /// </param>
    /// <param name="pPhysicalDevices">pPhysicalDevices is either NULL or a pointer to an array of VkPhysicalDevice handles.</param>
    /// <remarks>
    ///     <list type="table">
    ///         <item>
    ///             <term>successcodes</term><description>VK_SUCCESS,VK_INCOMPLETE</description>
    ///         </item>
    ///         <item>
    ///             <term>errorcodes</term>
    ///             <description>VK_ERROR_OUT_OF_HOST_MEMORY,VK_ERROR_OUT_OF_DEVICE_MEMORY,VK_ERROR_INITIALIZATION_FAILED</description>
    ///         </item>
    ///     </list>
    /// </remarks>
    [VkVersion("1.0")]
    [SuppressUnmanagedCodeSecurity]
    [DllImport(VK_IMPORT, EntryPoint = "vkEnumeratePhysicalDevices")]
    public static extern unsafe VkResult vkEnumeratePhysicalDevices(
        VkInstance        instance,
        uint*             pPhysicalDeviceCount,
        VkPhysicalDevice* pPhysicalDevices);

    /// <summary>
    ///     vkGetPhysicalDeviceFeatures - Reports capabilities of a physical device -
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkGetPhysicalDeviceFeatures.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkGetPhysicalDeviceFeatures.html</a>
    /// </summary>
    /// <param name="physicalDevice">physicalDevice is the physical device from which to query the supported features.</param>
    /// <param name="pFeatures">
    ///     pFeatures is a pointer to a VkPhysicalDeviceFeaturesstructure in which the physical device
    ///     features are returned. For each feature, a value of VK_TRUE specifies that the feature is supported on this
    ///     physical device, and VK_FALSE specifies that the feature is not supported.
    /// </param>
    [VkVersion("1.0")]
    [SuppressUnmanagedCodeSecurity]
    [DllImport(VK_IMPORT, EntryPoint = "vkGetPhysicalDeviceFeatures")]
    public static extern unsafe void vkGetPhysicalDeviceFeatures(
        VkPhysicalDevice          physicalDevice,
        VkPhysicalDeviceFeatures* pFeatures);

    /// <summary>
    ///     vkGetPhysicalDeviceFormatProperties - Lists physical device's format capabilities -
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkGetPhysicalDeviceFormatProperties.html">
    ///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkGetPhysicalDeviceFormatProperties.html
    ///     </a>
    /// </summary>
    /// <param name="physicalDevice">physicalDevice is the physical device from which to query the format properties.</param>
    /// <param name="format">format is the format whose properties are queried.</param>
    /// <param name="pFormatProperties">
    ///     pFormatProperties is a pointer to a VkFormatPropertiesstructure in which physical
    ///     device properties for format are returned.
    /// </param>
    [VkVersion("1.0")]
    [SuppressUnmanagedCodeSecurity]
    [DllImport(VK_IMPORT, EntryPoint = "vkGetPhysicalDeviceFormatProperties")]
    public static extern unsafe void vkGetPhysicalDeviceFormatProperties(
        VkPhysicalDevice    physicalDevice,
        VkFormat            format,
        VkFormatProperties* pFormatProperties);

    /// <summary>
    ///     vkGetPhysicalDeviceImageFormatProperties - Lists physical device's image format capabilities -
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkGetPhysicalDeviceImageFormatProperties.html">
    ///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkGetPhysicalDeviceImageFormatProperties.html
    ///     </a>
    /// </summary>
    /// <param name="physicalDevice">physicalDevice is the physical device from which to query the image capabilities.</param>
    /// <param name="format">
    ///     format is a VkFormat value specifying the image format, corresponding to
    ///     VkImageCreateInfo::format.
    /// </param>
    /// <param name="type">
    ///     type is a VkImageType value specifying the image type, corresponding to
    ///     VkImageCreateInfo::imageType.
    /// </param>
    /// <param name="tiling">
    ///     tiling is a VkImageTiling value specifying the image tiling, corresponding to
    ///     VkImageCreateInfo::tiling.
    /// </param>
    /// <param name="usage">
    ///     usage is a bitmask of VkImageUsageFlagBits specifying the intended usage of the image,
    ///     corresponding to VkImageCreateInfo::usage.
    /// </param>
    /// <param name="flags">
    ///     flags is a bitmask of VkImageCreateFlagBits specifying additional parameters of the image,
    ///     corresponding to VkImageCreateInfo::flags.
    /// </param>
    /// <param name="pImageFormatProperties">
    ///     pImageFormatProperties is a pointer to a VkImageFormatProperties structure in
    ///     which capabilities are returned.
    /// </param>
    /// <remarks>
    ///     <list type="table">
    ///         <item>
    ///             <term>successcodes</term><description>VK_SUCCESS</description>
    ///         </item>
    ///         <item>
    ///             <term>errorcodes</term>
    ///             <description>VK_ERROR_OUT_OF_HOST_MEMORY,VK_ERROR_OUT_OF_DEVICE_MEMORY,VK_ERROR_FORMAT_NOT_SUPPORTED</description>
    ///         </item>
    ///     </list>
    /// </remarks>
    [VkVersion("1.0")]
    [SuppressUnmanagedCodeSecurity]
    [DllImport(VK_IMPORT, EntryPoint = "vkGetPhysicalDeviceImageFormatProperties")]
    public static extern unsafe VkResult vkGetPhysicalDeviceImageFormatProperties(
        VkPhysicalDevice         physicalDevice,
        VkFormat                 format,
        VkImageType              type,
        VkImageTiling            tiling,
        VkImageUsageFlags        usage,
        VkImageCreateFlags       flags,
        VkImageFormatProperties* pImageFormatProperties);

    /// <summary>
    ///     vkGetPhysicalDeviceProperties - Returns properties of a physical device -
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkGetPhysicalDeviceProperties.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkGetPhysicalDeviceProperties.html</a>
    /// </summary>
    /// <param name="physicalDevice">physicalDevice is the handle to the physical device whose properties will be queried.</param>
    /// <param name="pProperties">
    ///     pProperties is a pointer to a VkPhysicalDevicePropertiesstructure in which properties are
    ///     returned.
    /// </param>
    [VkVersion("1.0")]
    [SuppressUnmanagedCodeSecurity]
    [DllImport(VK_IMPORT, EntryPoint = "vkGetPhysicalDeviceProperties")]
    public static extern unsafe void vkGetPhysicalDeviceProperties(
        VkPhysicalDevice            physicalDevice,
        VkPhysicalDeviceProperties* pProperties);

    /// <summary>
    ///     vkGetPhysicalDeviceQueueFamilyProperties - Reports properties of the queues of the specified physical device -
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkGetPhysicalDeviceQueueFamilyProperties.html">
    ///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkGetPhysicalDeviceQueueFamilyProperties.html
    ///     </a>
    /// </summary>
    /// <param name="physicalDevice">physicalDevice is the handle to the physical device whose properties will be queried.</param>
    /// <param name="pQueueFamilyPropertyCount">
    ///     pQueueFamilyPropertyCount is a pointer to an integer related to the number of
    ///     queue families available or queried, as described below.
    /// </param>
    /// <param name="pQueueFamilyProperties">
    ///     pQueueFamilyProperties is either NULL or a pointer to an array of
    ///     VkQueueFamilyProperties structures.
    /// </param>
    [VkVersion("1.0")]
    [SuppressUnmanagedCodeSecurity]
    [DllImport(VK_IMPORT, EntryPoint = "vkGetPhysicalDeviceQueueFamilyProperties")]
    public static extern unsafe void vkGetPhysicalDeviceQueueFamilyProperties(
        VkPhysicalDevice         physicalDevice,
        uint*                    pQueueFamilyPropertyCount,
        VkQueueFamilyProperties* pQueueFamilyProperties);

    /// <summary>
    ///     vkGetPhysicalDeviceMemoryProperties - Reports memory information for the specified physical device -
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkGetPhysicalDeviceMemoryProperties.html">
    ///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkGetPhysicalDeviceMemoryProperties.html
    ///     </a>
    /// </summary>
    /// <param name="physicalDevice">physicalDevice is the handle to the device to query.</param>
    /// <param name="pMemoryProperties">
    ///     pMemoryProperties is a pointer to a VkPhysicalDeviceMemoryProperties structure in which
    ///     the properties are returned.
    /// </param>
    [VkVersion("1.0")]
    [SuppressUnmanagedCodeSecurity]
    [DllImport(VK_IMPORT, EntryPoint = "vkGetPhysicalDeviceMemoryProperties")]
    public static extern unsafe void vkGetPhysicalDeviceMemoryProperties(
        VkPhysicalDevice                  physicalDevice,
        VkPhysicalDeviceMemoryProperties* pMemoryProperties);

    /// <summary>
    ///     vkGetInstanceProcAddr - Return a function pointer for a command -
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkGetInstanceProcAddr.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkGetInstanceProcAddr.html</a>
    /// </summary>
    /// <param name="instance">
    ///     instance is the instance that the function pointer will be compatible with, or NULL for commands
    ///     not dependent on any instance.
    /// </param>
    /// <param name="pName">pName is the name of the command to obtain.</param>
    [VkVersion("1.0")]
    [SuppressUnmanagedCodeSecurity]
    [DllImport(VK_IMPORT, EntryPoint = "vkGetInstanceProcAddr")]
    public static extern unsafe delegate*<void> vkGetInstanceProcAddr(
        VkInstance instance,
        byte*      pName);

    /// <summary>
    ///     vkGetDeviceProcAddr - Return a function pointer for a command -
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkGetDeviceProcAddr.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkGetDeviceProcAddr.html</a>
    /// </summary>
    /// <param name="device"> VUID-vkGetDeviceProcAddr-device-parameter device must be a valid VkDevice handle</param>
    /// <param name="pName"> VUID-vkGetDeviceProcAddr-pName-parameter pName must be a null-terminated UTF-8 string</param>
    [VkVersion("1.0")]
    [SuppressUnmanagedCodeSecurity]
    [DllImport(VK_IMPORT, EntryPoint = "vkGetDeviceProcAddr")]
    public static extern unsafe delegate*<void> vkGetDeviceProcAddr(
        VkDevice device,
        byte*    pName);

    /// <summary>
    ///     vkCreateDevice - Create a new device instance -
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCreateDevice.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCreateDevice.html</a>
    /// </summary>
    /// <param name="physicalDevice">
    ///     physicalDevice must be one of the device handles returned from a call to
    ///     vkEnumeratePhysicalDevices (see Physical Device Enumeration).
    /// </param>
    /// <param name="pCreateInfo">
    ///     pCreateInfo is a pointer to a VkDeviceCreateInfo structure containing information about how
    ///     to create the device.
    /// </param>
    /// <param name="pAllocator">pAllocator controls host memory allocation as described in the Memory Allocation chapter.</param>
    /// <param name="pDevice">pDevice is a pointer to a handle in which the created VkDevice is returned.</param>
    /// <remarks>
    ///     <list type="table">
    ///         <item>
    ///             <term>successcodes</term><description>VK_SUCCESS</description>
    ///         </item>
    ///         <item>
    ///             <term>errorcodes</term>
    ///             <description>VK_ERROR_OUT_OF_HOST_MEMORY,VK_ERROR_OUT_OF_DEVICE_MEMORY,VK_ERROR_INITIALIZATION_FAILED,VK_ERROR_EXTENSION_NOT_PRESENT,VK_ERROR_FEATURE_NOT_PRESENT,VK_ERROR_TOO_MANY_OBJECTS,VK_ERROR_DEVICE_LOST</description>
    ///         </item>
    ///     </list>
    /// </remarks>
    [VkVersion("1.0")]
    [SuppressUnmanagedCodeSecurity]
    [DllImport(VK_IMPORT, EntryPoint = "vkCreateDevice")]
    public static extern unsafe VkResult vkCreateDevice(
        VkPhysicalDevice       physicalDevice,
        VkDeviceCreateInfo*    pCreateInfo,
        VkAllocationCallbacks* pAllocator,
        VkDevice*              pDevice);

    /// <summary>
    ///     vkDestroyDevice - Destroy a logical device -
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkDestroyDevice.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkDestroyDevice.html</a>
    /// </summary>
    /// <param name="device">device is the logical device to destroy.</param>
    /// <param name="pAllocator">pAllocator controls host memory allocation as described in the Memory Allocation chapter.</param>
    [VkVersion("1.0")]
    [SuppressUnmanagedCodeSecurity]
    [DllImport(VK_IMPORT, EntryPoint = "vkDestroyDevice")]
    public static extern unsafe void vkDestroyDevice(
        VkDevice               device,
        VkAllocationCallbacks* pAllocator);

    /// <summary>
    ///     vkEnumerateInstanceExtensionProperties - Returns up to requested number of global extension properties -
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkEnumerateInstanceExtensionProperties.html">
    ///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkEnumerateInstanceExtensionProperties.html
    ///     </a>
    /// </summary>
    /// <param name="pLayerName">
    ///     pLayerName is either NULL or a pointer to a null-terminated UTF-8 string naming the layer to
    ///     retrieve extensions from.
    /// </param>
    /// <param name="pPropertyCount">
    ///     pPropertyCount is a pointer to an integer related to the number of extension properties
    ///     available or queried, as described below.
    /// </param>
    /// <param name="pProperties">pProperties is either NULL or a pointer to an array of VkExtensionProperties structures.</param>
    /// <remarks>
    ///     <list type="table">
    ///         <item>
    ///             <term>successcodes</term><description>VK_SUCCESS,VK_INCOMPLETE</description>
    ///         </item>
    ///         <item>
    ///             <term>errorcodes</term>
    ///             <description>VK_ERROR_OUT_OF_HOST_MEMORY,VK_ERROR_OUT_OF_DEVICE_MEMORY,VK_ERROR_LAYER_NOT_PRESENT</description>
    ///         </item>
    ///     </list>
    /// </remarks>
    [VkVersion("1.0")]
    [SuppressUnmanagedCodeSecurity]
    [DllImport(VK_IMPORT, EntryPoint = "vkEnumerateInstanceExtensionProperties")]
    public static extern unsafe VkResult vkEnumerateInstanceExtensionProperties(
        byte*                  pLayerName,
        uint*                  pPropertyCount,
        VkExtensionProperties* pProperties);

    /// <summary>
    ///     vkEnumerateDeviceExtensionProperties - Returns properties of available physical device extensions -
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkEnumerateDeviceExtensionProperties.html">
    ///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkEnumerateDeviceExtensionProperties.html
    ///     </a>
    /// </summary>
    /// <param name="physicalDevice">physicalDevice is the physical device that will be queried.</param>
    /// <param name="pLayerName">
    ///     pLayerName is either NULL or a pointer to a null-terminated UTF-8 string naming the layer to
    ///     retrieve extensions from.
    /// </param>
    /// <param name="pPropertyCount">
    ///     pPropertyCount is a pointer to an integer related to the number of extension properties
    ///     available or queried, and is treated in the same fashion as the
    ///     vkEnumerateInstanceExtensionProperties::pPropertyCountparameter.
    /// </param>
    /// <param name="pProperties">pProperties is either NULL or a pointer to an array of VkExtensionProperties structures.</param>
    /// <remarks>
    ///     <list type="table">
    ///         <item>
    ///             <term>successcodes</term><description>VK_SUCCESS,VK_INCOMPLETE</description>
    ///         </item>
    ///         <item>
    ///             <term>errorcodes</term>
    ///             <description>VK_ERROR_OUT_OF_HOST_MEMORY,VK_ERROR_OUT_OF_DEVICE_MEMORY,VK_ERROR_LAYER_NOT_PRESENT</description>
    ///         </item>
    ///     </list>
    /// </remarks>
    [VkVersion("1.0")]
    [SuppressUnmanagedCodeSecurity]
    [DllImport(VK_IMPORT, EntryPoint = "vkEnumerateDeviceExtensionProperties")]
    public static extern unsafe VkResult vkEnumerateDeviceExtensionProperties(
        VkPhysicalDevice       physicalDevice,
        byte*                  pLayerName,
        uint*                  pPropertyCount,
        VkExtensionProperties* pProperties);

    /// <summary>
    ///     vkEnumerateInstanceLayerProperties - Returns up to requested number of global layer properties -
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkEnumerateInstanceLayerProperties.html">
    ///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkEnumerateInstanceLayerProperties.html
    ///     </a>
    /// </summary>
    /// <param name="pPropertyCount">
    ///     pPropertyCount is a pointer to an integer related to the number of layer properties
    ///     available or queried, as described below.
    /// </param>
    /// <param name="pProperties">pProperties is either NULL or a pointer to an array of VkLayerProperties structures.</param>
    /// <remarks>
    ///     <list type="table">
    ///         <item>
    ///             <term>successcodes</term><description>VK_SUCCESS,VK_INCOMPLETE</description>
    ///         </item>
    ///         <item>
    ///             <term>errorcodes</term><description>VK_ERROR_OUT_OF_HOST_MEMORY,VK_ERROR_OUT_OF_DEVICE_MEMORY</description>
    ///         </item>
    ///     </list>
    /// </remarks>
    [VkVersion("1.0")]
    [SuppressUnmanagedCodeSecurity]
    [DllImport(VK_IMPORT, EntryPoint = "vkEnumerateInstanceLayerProperties")]
    public static extern unsafe VkResult vkEnumerateInstanceLayerProperties(
        uint*              pPropertyCount,
        VkLayerProperties* pProperties);

    /// <summary>
    ///     vkEnumerateDeviceLayerProperties - Returns properties of available physical device layers -
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkEnumerateDeviceLayerProperties.html">
    ///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkEnumerateDeviceLayerProperties.html
    ///     </a>
    /// </summary>
    /// <param name="physicalDevice">physicalDevice is the physical device that will be queried.</param>
    /// <param name="pPropertyCount">
    ///     pPropertyCount is a pointer to an integer related to the number of layer properties
    ///     available or queried.
    /// </param>
    /// <param name="pProperties">pProperties is either NULL or a pointer to an array of VkLayerProperties structures.</param>
    /// <remarks>
    ///     <list type="table">
    ///         <item>
    ///             <term>successcodes</term><description>VK_SUCCESS,VK_INCOMPLETE</description>
    ///         </item>
    ///         <item>
    ///             <term>errorcodes</term><description>VK_ERROR_OUT_OF_HOST_MEMORY,VK_ERROR_OUT_OF_DEVICE_MEMORY</description>
    ///         </item>
    ///     </list>
    /// </remarks>
    [VkVersion("1.0")]
    [SuppressUnmanagedCodeSecurity]
    [DllImport(VK_IMPORT, EntryPoint = "vkEnumerateDeviceLayerProperties")]
    public static extern unsafe VkResult vkEnumerateDeviceLayerProperties(
        VkPhysicalDevice   physicalDevice,
        uint*              pPropertyCount,
        VkLayerProperties* pProperties);

    /// <summary>
    ///     vkGetDeviceQueue - Get a queue handle from a device -
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkGetDeviceQueue.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkGetDeviceQueue.html</a>
    /// </summary>
    /// <param name="device">device is the logical device that owns the queue.</param>
    /// <param name="queueFamilyIndex">queueFamilyIndex is the index of the queue family to which the queue belongs.</param>
    /// <param name="queueIndex">queueIndex is the index within this queue family of the queue to retrieve.</param>
    /// <param name="pQueue">
    ///     pQueue is a pointer to a VkQueue object that will be filled with the handle for the requested
    ///     queue.
    /// </param>
    [VkVersion("1.0")]
    [SuppressUnmanagedCodeSecurity]
    [DllImport(VK_IMPORT, EntryPoint = "vkGetDeviceQueue")]
    public static extern unsafe void vkGetDeviceQueue(
        VkDevice device,
        uint     queueFamilyIndex,
        uint     queueIndex,
        VkQueue* pQueue);

    /// <summary>
    ///     vkQueueSubmit - Submits a sequence of semaphores or command buffers to a queue -
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkQueueSubmit.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkQueueSubmit.html</a>
    /// </summary>
    /// <param name="queue">queue is the queue that the command buffers will be submitted to.</param>
    /// <param name="submitCount">submitCount is the number of elements in the pSubmits array.</param>
    /// <param name="pSubmits">
    ///     pSubmits is a pointer to an array of VkSubmitInfostructures, each specifying a command buffer
    ///     submission batch.
    /// </param>
    /// <param name="fence">
    ///     fence is an optional handle to a fence to be signaled once all submitted command buffers have
    ///     completed execution. If fence is not VK_NULL_HANDLE, it defines a fence signal operation.
    /// </param>
    /// <remarks>
    ///     <list type="table">
    ///         <item>
    ///             <term>successcodes</term><description>VK_SUCCESS</description>
    ///         </item>
    ///         <item>
    ///             <term>errorcodes</term>
    ///             <description>VK_ERROR_OUT_OF_HOST_MEMORY,VK_ERROR_OUT_OF_DEVICE_MEMORY,VK_ERROR_DEVICE_LOST</description>
    ///         </item>
    ///     </list>
    /// </remarks>
    [VkVersion("1.0")]
    [SuppressUnmanagedCodeSecurity]
    [DllImport(VK_IMPORT, EntryPoint = "vkQueueSubmit")]
    public static extern unsafe VkResult vkQueueSubmit(
        VkQueue       queue,
        uint          submitCount,
        VkSubmitInfo* pSubmits,
        VkFence       fence);

    /// <summary>
    ///     vkQueueWaitIdle - Wait for a queue to become idle -
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkQueueWaitIdle.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkQueueWaitIdle.html</a>
    /// </summary>
    /// <param name="queue">queue is the queue on which to wait.</param>
    /// <remarks>
    ///     <list type="table">
    ///         <item>
    ///             <term>successcodes</term><description>VK_SUCCESS</description>
    ///         </item>
    ///         <item>
    ///             <term>errorcodes</term>
    ///             <description>VK_ERROR_OUT_OF_HOST_MEMORY,VK_ERROR_OUT_OF_DEVICE_MEMORY,VK_ERROR_DEVICE_LOST</description>
    ///         </item>
    ///     </list>
    /// </remarks>
    [VkVersion("1.0")]
    [SuppressUnmanagedCodeSecurity]
    [DllImport(VK_IMPORT, EntryPoint = "vkQueueWaitIdle")]
    public static extern VkResult vkQueueWaitIdle(VkQueue queue);

    /// <summary>
    ///     vkDeviceWaitIdle - Wait for a device to become idle -
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkDeviceWaitIdle.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkDeviceWaitIdle.html</a>
    /// </summary>
    /// <param name="device">device is the logical device to idle.</param>
    /// <remarks>
    ///     <list type="table">
    ///         <item>
    ///             <term>successcodes</term><description>VK_SUCCESS</description>
    ///         </item>
    ///         <item>
    ///             <term>errorcodes</term>
    ///             <description>VK_ERROR_OUT_OF_HOST_MEMORY,VK_ERROR_OUT_OF_DEVICE_MEMORY,VK_ERROR_DEVICE_LOST</description>
    ///         </item>
    ///     </list>
    /// </remarks>
    [VkVersion("1.0")]
    [SuppressUnmanagedCodeSecurity]
    [DllImport(VK_IMPORT, EntryPoint = "vkDeviceWaitIdle")]
    public static extern VkResult vkDeviceWaitIdle(VkDevice device);

    /// <summary>
    ///     vkAllocateMemory - Allocate device memory -
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkAllocateMemory.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkAllocateMemory.html</a>
    /// </summary>
    /// <param name="device">device is the logical device that owns the memory.</param>
    /// <param name="pAllocateInfo">
    ///     pAllocateInfo is a pointer to a VkMemoryAllocateInfostructure describing parameters of the
    ///     allocation. A successfully returned allocation must use the requested parameters&#8201;&#8212;&#8201;no
    ///     substitution is permitted by the implementation.
    /// </param>
    /// <param name="pAllocator">pAllocator controls host memory allocation as described in the Memory Allocation chapter.</param>
    /// <param name="pMemory">
    ///     pMemory is a pointer to a VkDeviceMemory handle in which information about the allocated memory
    ///     is returned.
    /// </param>
    /// <remarks>
    ///     <list type="table">
    ///         <item>
    ///             <term>successcodes</term><description>VK_SUCCESS</description>
    ///         </item>
    ///         <item>
    ///             <term>errorcodes</term>
    ///             <description>VK_ERROR_OUT_OF_HOST_MEMORY,VK_ERROR_OUT_OF_DEVICE_MEMORY,VK_ERROR_INVALID_EXTERNAL_HANDLE,VK_ERROR_INVALID_OPAQUE_CAPTURE_ADDRESS_KHR</description>
    ///         </item>
    ///     </list>
    /// </remarks>
    [VkVersion("1.0")]
    [SuppressUnmanagedCodeSecurity]
    [DllImport(VK_IMPORT, EntryPoint = "vkAllocateMemory")]
    public static extern unsafe VkResult vkAllocateMemory(
        VkDevice               device,
        VkMemoryAllocateInfo*  pAllocateInfo,
        VkAllocationCallbacks* pAllocator,
        VkDeviceMemory*        pMemory);

    /// <summary>
    ///     vkFreeMemory - Free device memory -
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkFreeMemory.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkFreeMemory.html</a>
    /// </summary>
    /// <param name="device">device is the logical device that owns the memory.</param>
    /// <param name="memory">memory is the VkDeviceMemory object to be freed.</param>
    /// <param name="pAllocator">pAllocator controls host memory allocation as described in the Memory Allocation chapter.</param>
    [VkVersion("1.0")]
    [SuppressUnmanagedCodeSecurity]
    [DllImport(VK_IMPORT, EntryPoint = "vkFreeMemory")]
    public static extern unsafe void vkFreeMemory(
        VkDevice               device,
        VkDeviceMemory         memory,
        VkAllocationCallbacks* pAllocator);

    /// <summary>
    ///     vkMapMemory - Map a memory object into application address space -
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkMapMemory.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkMapMemory.html</a>
    /// </summary>
    /// <param name="device">device is the logical device that owns the memory.</param>
    /// <param name="memory">memory is the VkDeviceMemory object to be mapped.</param>
    /// <param name="offset">offset is a zero-based byte offset from the beginning of the memory object.</param>
    /// <param name="size">
    ///     size is the size of the memory range to map, or VK_WHOLE_SIZE to map from offset to the end of the
    ///     allocation.
    /// </param>
    /// <param name="flags">flags is reserved for future use.</param>
    /// <param name="ppData">
    ///     ppData is a pointer to a void * variable in which is returned a host-accessible pointer to the
    ///     beginning of the mapped range. This pointer minus offset must be aligned to at least
    ///     VkPhysicalDeviceLimits::minMemoryMapAlignment.
    /// </param>
    /// <remarks>
    ///     <list type="table">
    ///         <item>
    ///             <term>successcodes</term><description>VK_SUCCESS</description>
    ///         </item>
    ///         <item>
    ///             <term>errorcodes</term>
    ///             <description>VK_ERROR_OUT_OF_HOST_MEMORY,VK_ERROR_OUT_OF_DEVICE_MEMORY,VK_ERROR_MEMORY_MAP_FAILED</description>
    ///         </item>
    ///     </list>
    /// </remarks>
    [VkVersion("1.0")]
    [SuppressUnmanagedCodeSecurity]
    [DllImport(VK_IMPORT, EntryPoint = "vkMapMemory")]
    public static extern unsafe VkResult vkMapMemory(
        VkDevice         device,
        VkDeviceMemory   memory,
        VkDeviceSize     offset,
        VkDeviceSize     size,
        VkMemoryMapFlags flags,
        void**           ppData);

    /// <summary>
    ///     vkUnmapMemory - Unmap a previously mapped memory object -
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkUnmapMemory.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkUnmapMemory.html</a>
    /// </summary>
    /// <param name="device">device is the logical device that owns the memory.</param>
    /// <param name="memory">memory is the memory object to be unmapped.</param>
    [VkVersion("1.0")]
    [SuppressUnmanagedCodeSecurity]
    [DllImport(VK_IMPORT, EntryPoint = "vkUnmapMemory")]
    public static extern void vkUnmapMemory(
        VkDevice       device,
        VkDeviceMemory memory);

    /// <summary>
    ///     vkFlushMappedMemoryRanges - Flush mapped memory ranges -
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkFlushMappedMemoryRanges.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkFlushMappedMemoryRanges.html</a>
    /// </summary>
    /// <param name="device">device is the logical device that owns the memory ranges.</param>
    /// <param name="memoryRangeCount">memoryRangeCount is the length of the pMemoryRanges array.</param>
    /// <param name="pMemoryRanges">
    ///     pMemoryRanges is a pointer to an array of VkMappedMemoryRange structures describing the
    ///     memory ranges to flush.
    /// </param>
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
    [VkVersion("1.0")]
    [SuppressUnmanagedCodeSecurity]
    [DllImport(VK_IMPORT, EntryPoint = "vkFlushMappedMemoryRanges")]
    public static extern unsafe VkResult vkFlushMappedMemoryRanges(
        VkDevice             device,
        uint                 memoryRangeCount,
        VkMappedMemoryRange* pMemoryRanges);

    /// <summary>
    ///     vkInvalidateMappedMemoryRanges - Invalidate ranges of mapped memory objects -
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkInvalidateMappedMemoryRanges.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkInvalidateMappedMemoryRanges.html</a>
    /// </summary>
    /// <param name="device">device is the logical device that owns the memory ranges.</param>
    /// <param name="memoryRangeCount">memoryRangeCount is the length of the pMemoryRanges array.</param>
    /// <param name="pMemoryRanges">
    ///     pMemoryRanges is a pointer to an array of VkMappedMemoryRange structures describing the
    ///     memory ranges to invalidate.
    /// </param>
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
    [VkVersion("1.0")]
    [SuppressUnmanagedCodeSecurity]
    [DllImport(VK_IMPORT, EntryPoint = "vkInvalidateMappedMemoryRanges")]
    public static extern unsafe VkResult vkInvalidateMappedMemoryRanges(
        VkDevice             device,
        uint                 memoryRangeCount,
        VkMappedMemoryRange* pMemoryRanges);

    /// <summary>
    ///     vkGetDeviceMemoryCommitment - Query the current commitment for a VkDeviceMemory -
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkGetDeviceMemoryCommitment.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkGetDeviceMemoryCommitment.html</a>
    /// </summary>
    /// <param name="device">device is the logical device that owns the memory.</param>
    /// <param name="memory">memory is the memory object being queried.</param>
    /// <param name="pCommittedMemoryInBytes">
    ///     pCommittedMemoryInBytes is a pointer to a VkDeviceSizevalue in which the number
    ///     of bytes currently committed is returned, on success.
    /// </param>
    [VkVersion("1.0")]
    [SuppressUnmanagedCodeSecurity]
    [DllImport(VK_IMPORT, EntryPoint = "vkGetDeviceMemoryCommitment")]
    public static extern unsafe void vkGetDeviceMemoryCommitment(
        VkDevice       device,
        VkDeviceMemory memory,
        VkDeviceSize*  pCommittedMemoryInBytes);

    /// <summary>
    ///     vkBindBufferMemory - Bind device memory to a buffer object -
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkBindBufferMemory.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkBindBufferMemory.html</a>
    /// </summary>
    /// <param name="device">device is the logical device that owns the buffer and memory.</param>
    /// <param name="buffer">buffer is the buffer to be attached to memory.</param>
    /// <param name="memory">memory is a VkDeviceMemory object describing the device memory to attach.</param>
    /// <param name="memoryOffset">
    ///     memoryOffset is the start offset of the region of memorywhich is to be bound to the buffer.
    ///     The number of bytes returned in the VkMemoryRequirements::size member in memory, starting from memoryOffset bytes,
    ///     will be bound to the specified buffer.
    /// </param>
    /// <remarks>
    ///     <list type="table">
    ///         <item>
    ///             <term>successcodes</term><description>VK_SUCCESS</description>
    ///         </item>
    ///         <item>
    ///             <term>errorcodes</term>
    ///             <description>VK_ERROR_OUT_OF_HOST_MEMORY,VK_ERROR_OUT_OF_DEVICE_MEMORY,VK_ERROR_INVALID_OPAQUE_CAPTURE_ADDRESS_KHR</description>
    ///         </item>
    ///     </list>
    /// </remarks>
    [VkVersion("1.0")]
    [SuppressUnmanagedCodeSecurity]
    [DllImport(VK_IMPORT, EntryPoint = "vkBindBufferMemory")]
    public static extern VkResult vkBindBufferMemory(
        VkDevice       device,
        VkBuffer       buffer,
        VkDeviceMemory memory,
        VkDeviceSize   memoryOffset);

    /// <summary>
    ///     vkBindImageMemory - Bind device memory to an image object -
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkBindImageMemory.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkBindImageMemory.html</a>
    /// </summary>
    /// <param name="device">device is the logical device that owns the image and memory.</param>
    /// <param name="image">image is the image.</param>
    /// <param name="memory">memory is the VkDeviceMemory object describing the device memory to attach.</param>
    /// <param name="memoryOffset">
    ///     memoryOffset is the start offset of the region of memorywhich is to be bound to the image.
    ///     The number of bytes returned in the VkMemoryRequirements::size member in memory, starting from memoryOffset bytes,
    ///     will be bound to the specified image.
    /// </param>
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
    [VkVersion("1.0")]
    [SuppressUnmanagedCodeSecurity]
    [DllImport(VK_IMPORT, EntryPoint = "vkBindImageMemory")]
    public static extern VkResult vkBindImageMemory(
        VkDevice       device,
        VkImage        image,
        VkDeviceMemory memory,
        VkDeviceSize   memoryOffset);

    /// <summary>
    ///     vkGetBufferMemoryRequirements - Returns the memory requirements for specified Vulkan object -
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkGetBufferMemoryRequirements.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkGetBufferMemoryRequirements.html</a>
    /// </summary>
    /// <param name="device">device is the logical device that owns the buffer.</param>
    /// <param name="buffer">buffer is the buffer to query.</param>
    /// <param name="pMemoryRequirements">
    ///     pMemoryRequirements is a pointer to a VkMemoryRequirementsstructure in which the
    ///     memory requirements of the buffer object are returned.
    /// </param>
    [VkVersion("1.0")]
    [SuppressUnmanagedCodeSecurity]
    [DllImport(VK_IMPORT, EntryPoint = "vkGetBufferMemoryRequirements")]
    public static extern unsafe void vkGetBufferMemoryRequirements(
        VkDevice              device,
        VkBuffer              buffer,
        VkMemoryRequirements* pMemoryRequirements);

    /// <summary>
    ///     vkGetImageMemoryRequirements - Returns the memory requirements for specified Vulkan object -
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkGetImageMemoryRequirements.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkGetImageMemoryRequirements.html</a>
    /// </summary>
    /// <param name="device">device is the logical device that owns the image.</param>
    /// <param name="image">image is the image to query.</param>
    /// <param name="pMemoryRequirements">
    ///     pMemoryRequirements is a pointer to a VkMemoryRequirementsstructure in which the
    ///     memory requirements of the image object are returned.
    /// </param>
    [VkVersion("1.0")]
    [SuppressUnmanagedCodeSecurity]
    [DllImport(VK_IMPORT, EntryPoint = "vkGetImageMemoryRequirements")]
    public static extern unsafe void vkGetImageMemoryRequirements(
        VkDevice              device,
        VkImage               image,
        VkMemoryRequirements* pMemoryRequirements);

    /// <summary>
    ///     vkGetImageSparseMemoryRequirements - Query the memory requirements for a sparse image -
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkGetImageSparseMemoryRequirements.html">
    ///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkGetImageSparseMemoryRequirements.html
    ///     </a>
    /// </summary>
    /// <param name="device">device is the logical device that owns the image.</param>
    /// <param name="image">image is the VkImage object to get the memory requirements for.</param>
    /// <param name="pSparseMemoryRequirementCount">
    ///     pSparseMemoryRequirementCount is a pointer to an integer related to the
    ///     number of sparse memory requirements available or queried, as described below.
    /// </param>
    /// <param name="pSparseMemoryRequirements">
    ///     pSparseMemoryRequirements is either NULL or a pointer to an array of
    ///     VkSparseImageMemoryRequirements structures.
    /// </param>
    [VkVersion("1.0")]
    [SuppressUnmanagedCodeSecurity]
    [DllImport(VK_IMPORT, EntryPoint = "vkGetImageSparseMemoryRequirements")]
    public static extern unsafe void vkGetImageSparseMemoryRequirements(
        VkDevice                         device,
        VkImage                          image,
        uint*                            pSparseMemoryRequirementCount,
        VkSparseImageMemoryRequirements* pSparseMemoryRequirements);

    /// <summary>
    ///     vkGetPhysicalDeviceSparseImageFormatProperties - Retrieve properties of an image format applied to sparse images -
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkGetPhysicalDeviceSparseImageFormatProperties.html">
    ///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkGetPhysicalDeviceSparseImageFormatProperties.html
    ///     </a>
    /// </summary>
    /// <param name="physicalDevice">
    ///     physicalDevice is the physical device from which to query the sparse image format
    ///     properties.
    /// </param>
    /// <param name="format">format is the image format.</param>
    /// <param name="type">type is the dimensionality of image.</param>
    /// <param name="samples">samples is a VkSampleCountFlagBits value specifying the number of samples per texel.</param>
    /// <param name="usage">usage is a bitmask describing the intended usage of the image.</param>
    /// <param name="tiling">tiling is the tiling arrangement of the texel blocks in memory.</param>
    /// <param name="pPropertyCount">
    ///     pPropertyCount is a pointer to an integer related to the number of sparse format
    ///     properties available or queried, as described below.
    /// </param>
    /// <param name="pProperties">
    ///     pProperties is either NULL or a pointer to an array of VkSparseImageFormatProperties
    ///     structures.
    /// </param>
    [VkVersion("1.0")]
    [SuppressUnmanagedCodeSecurity]
    [DllImport(VK_IMPORT, EntryPoint = "vkGetPhysicalDeviceSparseImageFormatProperties")]
    public static extern unsafe void vkGetPhysicalDeviceSparseImageFormatProperties(
        VkPhysicalDevice               physicalDevice,
        VkFormat                       format,
        VkImageType                    type,
        VkSampleCountFlagBits          samples,
        VkImageUsageFlags              usage,
        VkImageTiling                  tiling,
        uint*                          pPropertyCount,
        VkSparseImageFormatProperties* pProperties);

    /// <summary>
    ///     vkQueueBindSparse - Bind device memory to a sparse resource object -
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkQueueBindSparse.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkQueueBindSparse.html</a>
    /// </summary>
    /// <param name="queue">queue is the queue that the sparse binding operations will be submitted to.</param>
    /// <param name="bindInfoCount">bindInfoCount is the number of elements in the pBindInfoarray.</param>
    /// <param name="pBindInfo">
    ///     pBindInfo is a pointer to an array of VkBindSparseInfostructures, each specifying a sparse
    ///     binding submission batch.
    /// </param>
    /// <param name="fence">
    ///     fence is an optional handle to a fence to be signaled. If fence is not VK_NULL_HANDLE, it defines a
    ///     fence signal operation.
    /// </param>
    /// <remarks>
    ///     <list type="table">
    ///         <item>
    ///             <term>successcodes</term><description>VK_SUCCESS</description>
    ///         </item>
    ///         <item>
    ///             <term>errorcodes</term>
    ///             <description>VK_ERROR_OUT_OF_HOST_MEMORY,VK_ERROR_OUT_OF_DEVICE_MEMORY,VK_ERROR_DEVICE_LOST</description>
    ///         </item>
    ///     </list>
    /// </remarks>
    [VkVersion("1.0")]
    [SuppressUnmanagedCodeSecurity]
    [DllImport(VK_IMPORT, EntryPoint = "vkQueueBindSparse")]
    public static extern unsafe VkResult vkQueueBindSparse(
        VkQueue           queue,
        uint              bindInfoCount,
        VkBindSparseInfo* pBindInfo,
        VkFence           fence);

    /// <summary>
    ///     vkCreateFence - Create a new fence object -
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCreateFence.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCreateFence.html</a>
    /// </summary>
    /// <param name="device">device is the logical device that creates the fence.</param>
    /// <param name="pCreateInfo">
    ///     pCreateInfo is a pointer to a VkFenceCreateInfo structure containing information about how
    ///     the fence is to be created.
    /// </param>
    /// <param name="pAllocator">pAllocator controls host memory allocation as described in the Memory Allocation chapter.</param>
    /// <param name="pFence">pFence is a pointer to a handle in which the resulting fence object is returned.</param>
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
    [VkVersion("1.0")]
    [SuppressUnmanagedCodeSecurity]
    [DllImport(VK_IMPORT, EntryPoint = "vkCreateFence")]
    public static extern unsafe VkResult vkCreateFence(
        VkDevice               device,
        VkFenceCreateInfo*     pCreateInfo,
        VkAllocationCallbacks* pAllocator,
        VkFence*               pFence);

    /// <summary>
    ///     vkDestroyFence - Destroy a fence object -
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkDestroyFence.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkDestroyFence.html</a>
    /// </summary>
    /// <param name="device">device is the logical device that destroys the fence.</param>
    /// <param name="fence">fence is the handle of the fence to destroy.</param>
    /// <param name="pAllocator">pAllocator controls host memory allocation as described in the Memory Allocation chapter.</param>
    [VkVersion("1.0")]
    [SuppressUnmanagedCodeSecurity]
    [DllImport(VK_IMPORT, EntryPoint = "vkDestroyFence")]
    public static extern unsafe void vkDestroyFence(
        VkDevice               device,
        VkFence                fence,
        VkAllocationCallbacks* pAllocator);

    /// <summary>
    ///     vkResetFences - Resets one or more fence objects -
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkResetFences.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkResetFences.html</a>
    /// </summary>
    /// <param name="device">device is the logical device that owns the fences.</param>
    /// <param name="fenceCount">fenceCount is the number of fences to reset.</param>
    /// <param name="pFences">pFences is a pointer to an array of fence handles to reset.</param>
    /// <remarks>
    ///     <list type="table">
    ///         <item>
    ///             <term>successcodes</term><description>VK_SUCCESS</description>
    ///         </item>
    ///         <item>
    ///             <term>errorcodes</term><description>VK_ERROR_OUT_OF_DEVICE_MEMORY</description>
    ///         </item>
    ///     </list>
    /// </remarks>
    [VkVersion("1.0")]
    [SuppressUnmanagedCodeSecurity]
    [DllImport(VK_IMPORT, EntryPoint = "vkResetFences")]
    public static extern unsafe VkResult vkResetFences(
        VkDevice device,
        uint     fenceCount,
        VkFence* pFences);

    /// <summary>
    ///     vkGetFenceStatus - Return the status of a fence -
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkGetFenceStatus.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkGetFenceStatus.html</a>
    /// </summary>
    /// <param name="device">device is the logical device that owns the fence.</param>
    /// <param name="fence">fence is the handle of the fence to query.</param>
    /// <remarks>
    ///     <list type="table">
    ///         <item>
    ///             <term>successcodes</term><description>VK_SUCCESS,VK_NOT_READY</description>
    ///         </item>
    ///         <item>
    ///             <term>errorcodes</term>
    ///             <description>VK_ERROR_OUT_OF_HOST_MEMORY,VK_ERROR_OUT_OF_DEVICE_MEMORY,VK_ERROR_DEVICE_LOST</description>
    ///         </item>
    ///     </list>
    /// </remarks>
    [VkVersion("1.0")]
    [SuppressUnmanagedCodeSecurity]
    [DllImport(VK_IMPORT, EntryPoint = "vkGetFenceStatus")]
    public static extern VkResult vkGetFenceStatus(
        VkDevice device,
        VkFence  fence);

    /// <summary>
    ///     vkWaitForFences - Wait for one or more fences to become signaled -
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkWaitForFences.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkWaitForFences.html</a>
    /// </summary>
    /// <param name="device">device is the logical device that owns the fences.</param>
    /// <param name="fenceCount">fenceCount is the number of fences to wait on.</param>
    /// <param name="pFences">pFences is a pointer to an array of fenceCount fence handles.</param>
    /// <param name="waitAll">
    ///     waitAll is the condition that must be satisfied to successfully unblock the wait. If waitAll is
    ///     VK_TRUE, then the condition is that all fences in pFences are signaled. Otherwise, the condition is that at least
    ///     one fence in pFences is signaled.
    /// </param>
    /// <param name="timeout">
    ///     timeout is the timeout period in units of nanoseconds. timeout is adjusted to the closest value
    ///     allowed by the implementation-dependent timeout accuracy, which may be substantially longer than one nanosecond,
    ///     and may be longer than the requested period.
    /// </param>
    /// <remarks>
    ///     <list type="table">
    ///         <item>
    ///             <term>successcodes</term><description>VK_SUCCESS,VK_TIMEOUT</description>
    ///         </item>
    ///         <item>
    ///             <term>errorcodes</term>
    ///             <description>VK_ERROR_OUT_OF_HOST_MEMORY,VK_ERROR_OUT_OF_DEVICE_MEMORY,VK_ERROR_DEVICE_LOST</description>
    ///         </item>
    ///     </list>
    /// </remarks>
    [VkVersion("1.0")]
    [SuppressUnmanagedCodeSecurity]
    [DllImport(VK_IMPORT, EntryPoint = "vkWaitForFences")]
    public static extern unsafe VkResult vkWaitForFences(
        VkDevice device,
        uint     fenceCount,
        VkFence* pFences,
        VkBool32 waitAll,
        ulong    timeout);

    /// <summary>
    ///     vkCreateSemaphore - Create a new queue semaphore object -
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCreateSemaphore.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCreateSemaphore.html</a>
    /// </summary>
    /// <param name="device">device is the logical device that creates the semaphore.</param>
    /// <param name="pCreateInfo">
    ///     pCreateInfo is a pointer to a VkSemaphoreCreateInfostructure containing information about how
    ///     the semaphore is to be created.
    /// </param>
    /// <param name="pAllocator">pAllocator controls host memory allocation as described in the Memory Allocation chapter.</param>
    /// <param name="pSemaphore">pSemaphore is a pointer to a handle in which the resulting semaphore object is returned.</param>
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
    [VkVersion("1.0")]
    [SuppressUnmanagedCodeSecurity]
    [DllImport(VK_IMPORT, EntryPoint = "vkCreateSemaphore")]
    public static extern unsafe VkResult vkCreateSemaphore(
        VkDevice               device,
        VkSemaphoreCreateInfo* pCreateInfo,
        VkAllocationCallbacks* pAllocator,
        VkSemaphore*           pSemaphore);

    /// <summary>
    ///     vkDestroySemaphore - Destroy a semaphore object -
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkDestroySemaphore.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkDestroySemaphore.html</a>
    /// </summary>
    /// <param name="device">device is the logical device that destroys the semaphore.</param>
    /// <param name="semaphore">semaphore is the handle of the semaphore to destroy.</param>
    /// <param name="pAllocator">pAllocator controls host memory allocation as described in the Memory Allocation chapter.</param>
    [VkVersion("1.0")]
    [SuppressUnmanagedCodeSecurity]
    [DllImport(VK_IMPORT, EntryPoint = "vkDestroySemaphore")]
    public static extern unsafe void vkDestroySemaphore(
        VkDevice               device,
        VkSemaphore            semaphore,
        VkAllocationCallbacks* pAllocator);

    /// <summary>
    ///     vkCreateEvent - Create a new event object -
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCreateEvent.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCreateEvent.html</a>
    /// </summary>
    /// <param name="device">device is the logical device that creates the event.</param>
    /// <param name="pCreateInfo">
    ///     pCreateInfo is a pointer to a VkEventCreateInfo structure containing information about how
    ///     the event is to be created.
    /// </param>
    /// <param name="pAllocator">pAllocator controls host memory allocation as described in the Memory Allocation chapter.</param>
    /// <param name="pEvent">pEvent is a pointer to a handle in which the resulting event object is returned.</param>
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
    [VkVersion("1.0")]
    [SuppressUnmanagedCodeSecurity]
    [DllImport(VK_IMPORT, EntryPoint = "vkCreateEvent")]
    public static extern unsafe VkResult vkCreateEvent(
        VkDevice               device,
        VkEventCreateInfo*     pCreateInfo,
        VkAllocationCallbacks* pAllocator,
        VkEvent*               pEvent);

    /// <summary>
    ///     vkDestroyEvent - Destroy an event object -
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkDestroyEvent.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkDestroyEvent.html</a>
    /// </summary>
    /// <param name="device">device is the logical device that destroys the event.</param>
    /// <param name="event">event is the handle of the event to destroy.</param>
    /// <param name="pAllocator">pAllocator controls host memory allocation as described in the Memory Allocation chapter.</param>
    [VkVersion("1.0")]
    [SuppressUnmanagedCodeSecurity]
    [DllImport(VK_IMPORT, EntryPoint = "vkDestroyEvent")]
    public static extern unsafe void vkDestroyEvent(
        VkDevice               device,
        VkEvent                @event,
        VkAllocationCallbacks* pAllocator);

    /// <summary>
    ///     vkGetEventStatus - Retrieve the status of an event object -
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkGetEventStatus.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkGetEventStatus.html</a>
    /// </summary>
    /// <param name="device">device is the logical device that owns the event.</param>
    /// <param name="event">event is the handle of the event to query.</param>
    /// <remarks>
    ///     <list type="table">
    ///         <item>
    ///             <term>successcodes</term><description>VK_EVENT_SET,VK_EVENT_RESET</description>
    ///         </item>
    ///         <item>
    ///             <term>errorcodes</term>
    ///             <description>VK_ERROR_OUT_OF_HOST_MEMORY,VK_ERROR_OUT_OF_DEVICE_MEMORY,VK_ERROR_DEVICE_LOST</description>
    ///         </item>
    ///     </list>
    /// </remarks>
    [VkVersion("1.0")]
    [SuppressUnmanagedCodeSecurity]
    [DllImport(VK_IMPORT, EntryPoint = "vkGetEventStatus")]
    public static extern VkResult vkGetEventStatus(
        VkDevice device,
        VkEvent  @event);

    /// <summary>
    ///     vkSetEvent - Set an event to signaled state -
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkSetEvent.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkSetEvent.html</a>
    /// </summary>
    /// <param name="device">device is the logical device that owns the event.</param>
    /// <param name="event">event is the event to set.</param>
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
    [VkVersion("1.0")]
    [SuppressUnmanagedCodeSecurity]
    [DllImport(VK_IMPORT, EntryPoint = "vkSetEvent")]
    public static extern VkResult vkSetEvent(
        VkDevice device,
        VkEvent  @event);

    /// <summary>
    ///     vkResetEvent - Reset an event to non-signaled state -
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkResetEvent.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkResetEvent.html</a>
    /// </summary>
    /// <param name="device">device is the logical device that owns the event.</param>
    /// <param name="event">event is the event to reset.</param>
    /// <remarks>
    ///     <list type="table">
    ///         <item>
    ///             <term>successcodes</term><description>VK_SUCCESS</description>
    ///         </item>
    ///         <item>
    ///             <term>errorcodes</term><description>VK_ERROR_OUT_OF_DEVICE_MEMORY</description>
    ///         </item>
    ///     </list>
    /// </remarks>
    [VkVersion("1.0")]
    [SuppressUnmanagedCodeSecurity]
    [DllImport(VK_IMPORT, EntryPoint = "vkResetEvent")]
    public static extern VkResult vkResetEvent(
        VkDevice device,
        VkEvent  @event);

    /// <summary>
    ///     vkCreateQueryPool - Create a new query pool object -
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCreateQueryPool.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCreateQueryPool.html</a>
    /// </summary>
    /// <param name="device">device is the logical device that creates the query pool.</param>
    /// <param name="pCreateInfo">
    ///     pCreateInfo is a pointer to a VkQueryPoolCreateInfostructure containing the number and type
    ///     of queries to be managed by the pool.
    /// </param>
    /// <param name="pAllocator">pAllocator controls host memory allocation as described in the Memory Allocation chapter.</param>
    /// <param name="pQueryPool">
    ///     pQueryPool is a pointer to a VkQueryPool handle in which the resulting query pool object is
    ///     returned.
    /// </param>
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
    [VkVersion("1.0")]
    [SuppressUnmanagedCodeSecurity]
    [DllImport(VK_IMPORT, EntryPoint = "vkCreateQueryPool")]
    public static extern unsafe VkResult vkCreateQueryPool(
        VkDevice               device,
        VkQueryPoolCreateInfo* pCreateInfo,
        VkAllocationCallbacks* pAllocator,
        VkQueryPool*           pQueryPool);

    /// <summary>
    ///     vkDestroyQueryPool - Destroy a query pool object -
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkDestroyQueryPool.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkDestroyQueryPool.html</a>
    /// </summary>
    /// <param name="device">device is the logical device that destroys the query pool.</param>
    /// <param name="queryPool">queryPool is the query pool to destroy.</param>
    /// <param name="pAllocator">pAllocator controls host memory allocation as described in the Memory Allocation chapter.</param>
    [VkVersion("1.0")]
    [SuppressUnmanagedCodeSecurity]
    [DllImport(VK_IMPORT, EntryPoint = "vkDestroyQueryPool")]
    public static extern unsafe void vkDestroyQueryPool(
        VkDevice               device,
        VkQueryPool            queryPool,
        VkAllocationCallbacks* pAllocator);

    /// <summary>
    ///     vkGetQueryPoolResults - Copy results of queries in a query pool to a host memory region -
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkGetQueryPoolResults.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkGetQueryPoolResults.html</a>
    /// </summary>
    /// <param name="device">device is the logical device that owns the query pool.</param>
    /// <param name="queryPool">queryPool is the query pool managing the queries containing the desired results.</param>
    /// <param name="firstQuery">firstQuery is the initial query index.</param>
    /// <param name="queryCount">queryCount is the number of queries to read.</param>
    /// <param name="dataSize">dataSize is the size in bytes of the buffer pointed to by pData.</param>
    /// <param name="pData">pData is a pointer to a user-allocated buffer where the results will be written</param>
    /// <param name="stride">stride is the stride in bytes between results for individual queries within pData.</param>
    /// <param name="flags">flags is a bitmask of VkQueryResultFlagBits specifying how and when results are returned.</param>
    /// <remarks>
    ///     <list type="table">
    ///         <item>
    ///             <term>successcodes</term><description>VK_SUCCESS,VK_NOT_READY</description>
    ///         </item>
    ///         <item>
    ///             <term>errorcodes</term>
    ///             <description>VK_ERROR_OUT_OF_HOST_MEMORY,VK_ERROR_OUT_OF_DEVICE_MEMORY,VK_ERROR_DEVICE_LOST</description>
    ///         </item>
    ///     </list>
    /// </remarks>
    [VkVersion("1.0")]
    [SuppressUnmanagedCodeSecurity]
    [DllImport(VK_IMPORT, EntryPoint = "vkGetQueryPoolResults")]
    public static extern unsafe VkResult vkGetQueryPoolResults(
        VkDevice           device,
        VkQueryPool        queryPool,
        uint               firstQuery,
        uint               queryCount,
        nuint              dataSize,
        void*              pData,
        VkDeviceSize       stride,
        VkQueryResultFlags flags);

    /// <summary>
    ///     vkCreateBuffer - Create a new buffer object -
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCreateBuffer.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCreateBuffer.html</a>
    /// </summary>
    /// <param name="device">device is the logical device that creates the buffer object.</param>
    /// <param name="pCreateInfo">
    ///     pCreateInfo is a pointer to a VkBufferCreateInfo structure containing parameters affecting
    ///     creation of the buffer.
    /// </param>
    /// <param name="pAllocator">pAllocator controls host memory allocation as described in the Memory Allocation chapter.</param>
    /// <param name="pBuffer">pBuffer is a pointer to a VkBuffer handle in which the resulting buffer object is returned.</param>
    /// <remarks>
    ///     <list type="table">
    ///         <item>
    ///             <term>successcodes</term><description>VK_SUCCESS</description>
    ///         </item>
    ///         <item>
    ///             <term>errorcodes</term>
    ///             <description>VK_ERROR_OUT_OF_HOST_MEMORY,VK_ERROR_OUT_OF_DEVICE_MEMORY,VK_ERROR_INVALID_OPAQUE_CAPTURE_ADDRESS_KHR</description>
    ///         </item>
    ///     </list>
    /// </remarks>
    [VkVersion("1.0")]
    [SuppressUnmanagedCodeSecurity]
    [DllImport(VK_IMPORT, EntryPoint = "vkCreateBuffer")]
    public static extern unsafe VkResult vkCreateBuffer(
        VkDevice               device,
        VkBufferCreateInfo*    pCreateInfo,
        VkAllocationCallbacks* pAllocator,
        VkBuffer*              pBuffer);

    /// <summary>
    ///     vkDestroyBuffer - Destroy a buffer object -
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkDestroyBuffer.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkDestroyBuffer.html</a>
    /// </summary>
    /// <param name="device">device is the logical device that destroys the buffer.</param>
    /// <param name="buffer">buffer is the buffer to destroy.</param>
    /// <param name="pAllocator">pAllocator controls host memory allocation as described in the Memory Allocation chapter.</param>
    [VkVersion("1.0")]
    [SuppressUnmanagedCodeSecurity]
    [DllImport(VK_IMPORT, EntryPoint = "vkDestroyBuffer")]
    public static extern unsafe void vkDestroyBuffer(
        VkDevice               device,
        VkBuffer               buffer,
        VkAllocationCallbacks* pAllocator);

    /// <summary>
    ///     vkCreateBufferView - Create a new buffer view object -
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCreateBufferView.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCreateBufferView.html</a>
    /// </summary>
    /// <param name="device">device is the logical device that creates the buffer view.</param>
    /// <param name="pCreateInfo">
    ///     pCreateInfo is a pointer to a VkBufferViewCreateInfostructure containing parameters to be
    ///     used to create the buffer view.
    /// </param>
    /// <param name="pAllocator">pAllocator controls host memory allocation as described in the Memory Allocation chapter.</param>
    /// <param name="pView">pView is a pointer to a VkBufferView handle in which the resulting buffer view object is returned.</param>
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
    [VkVersion("1.0")]
    [SuppressUnmanagedCodeSecurity]
    [DllImport(VK_IMPORT, EntryPoint = "vkCreateBufferView")]
    public static extern unsafe VkResult vkCreateBufferView(
        VkDevice                device,
        VkBufferViewCreateInfo* pCreateInfo,
        VkAllocationCallbacks*  pAllocator,
        VkBufferView*           pView);

    /// <summary>
    ///     vkDestroyBufferView - Destroy a buffer view object -
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkDestroyBufferView.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkDestroyBufferView.html</a>
    /// </summary>
    /// <param name="device">device is the logical device that destroys the buffer view.</param>
    /// <param name="bufferView">bufferView is the buffer view to destroy.</param>
    /// <param name="pAllocator">pAllocator controls host memory allocation as described in the Memory Allocation chapter.</param>
    [VkVersion("1.0")]
    [SuppressUnmanagedCodeSecurity]
    [DllImport(VK_IMPORT, EntryPoint = "vkDestroyBufferView")]
    public static extern unsafe void vkDestroyBufferView(
        VkDevice               device,
        VkBufferView           bufferView,
        VkAllocationCallbacks* pAllocator);

    /// <summary>
    ///     vkCreateImage - Create a new image object -
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCreateImage.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCreateImage.html</a>
    /// </summary>
    /// <param name="device">device is the logical device that creates the image.</param>
    /// <param name="pCreateInfo">
    ///     pCreateInfo is a pointer to a VkImageCreateInfo structure containing parameters to be used to
    ///     create the image.
    /// </param>
    /// <param name="pAllocator">pAllocator controls host memory allocation as described in the Memory Allocation chapter.</param>
    /// <param name="pImage">pImage is a pointer to a VkImage handle in which the resulting image object is returned.</param>
    /// <remarks>
    ///     <list type="table">
    ///         <item>
    ///             <term>successcodes</term><description>VK_SUCCESS</description>
    ///         </item>
    ///         <item>
    ///             <term>errorcodes</term>
    ///             <description>VK_ERROR_OUT_OF_HOST_MEMORY,VK_ERROR_OUT_OF_DEVICE_MEMORY,VK_ERROR_COMPRESSION_EXHAUSTED_EXT</description>
    ///         </item>
    ///     </list>
    /// </remarks>
    [VkVersion("1.0")]
    [SuppressUnmanagedCodeSecurity]
    [DllImport(VK_IMPORT, EntryPoint = "vkCreateImage")]
    public static extern unsafe VkResult vkCreateImage(
        VkDevice               device,
        VkImageCreateInfo*     pCreateInfo,
        VkAllocationCallbacks* pAllocator,
        VkImage*               pImage);

    /// <summary>
    ///     vkDestroyImage - Destroy an image object -
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkDestroyImage.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkDestroyImage.html</a>
    /// </summary>
    /// <param name="device">device is the logical device that destroys the image.</param>
    /// <param name="image">image is the image to destroy.</param>
    /// <param name="pAllocator">pAllocator controls host memory allocation as described in the Memory Allocation chapter.</param>
    [VkVersion("1.0")]
    [SuppressUnmanagedCodeSecurity]
    [DllImport(VK_IMPORT, EntryPoint = "vkDestroyImage")]
    public static extern unsafe void vkDestroyImage(
        VkDevice               device,
        VkImage                image,
        VkAllocationCallbacks* pAllocator);

    /// <summary>
    ///     vkGetImageSubresourceLayout - Retrieve information about an image subresource -
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkGetImageSubresourceLayout.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkGetImageSubresourceLayout.html</a>
    /// </summary>
    /// <param name="device">device is the logical device that owns the image.</param>
    /// <param name="image">image is the image whose layout is being queried.</param>
    /// <param name="pSubresource">
    ///     pSubresource is a pointer to a VkImageSubresource structure selecting a specific image
    ///     subresource from the image.
    /// </param>
    /// <param name="pLayout">pLayout is a pointer to a VkSubresourceLayout structure in which the layout is returned.</param>
    [VkVersion("1.0")]
    [SuppressUnmanagedCodeSecurity]
    [DllImport(VK_IMPORT, EntryPoint = "vkGetImageSubresourceLayout")]
    public static extern unsafe void vkGetImageSubresourceLayout(
        VkDevice             device,
        VkImage              image,
        VkImageSubresource*  pSubresource,
        VkSubresourceLayout* pLayout);

    /// <summary>
    ///     vkCreateImageView - Create an image view from an existing image -
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCreateImageView.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCreateImageView.html</a>
    /// </summary>
    /// <param name="device">device is the logical device that creates the image view.</param>
    /// <param name="pCreateInfo">
    ///     pCreateInfo is a pointer to a VkImageViewCreateInfostructure containing parameters to be used
    ///     to create the image view.
    /// </param>
    /// <param name="pAllocator">pAllocator controls host memory allocation as described in the Memory Allocation chapter.</param>
    /// <param name="pView">pView is a pointer to a VkImageView handle in which the resulting image view object is returned.</param>
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
    [VkVersion("1.0")]
    [SuppressUnmanagedCodeSecurity]
    [DllImport(VK_IMPORT, EntryPoint = "vkCreateImageView")]
    public static extern unsafe VkResult vkCreateImageView(
        VkDevice               device,
        VkImageViewCreateInfo* pCreateInfo,
        VkAllocationCallbacks* pAllocator,
        VkImageView*           pView);

    /// <summary>
    ///     vkDestroyImageView - Destroy an image view object -
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkDestroyImageView.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkDestroyImageView.html</a>
    /// </summary>
    /// <param name="device">device is the logical device that destroys the image view.</param>
    /// <param name="imageView">imageView is the image view to destroy.</param>
    /// <param name="pAllocator">pAllocator controls host memory allocation as described in the Memory Allocation chapter.</param>
    [VkVersion("1.0")]
    [SuppressUnmanagedCodeSecurity]
    [DllImport(VK_IMPORT, EntryPoint = "vkDestroyImageView")]
    public static extern unsafe void vkDestroyImageView(
        VkDevice               device,
        VkImageView            imageView,
        VkAllocationCallbacks* pAllocator);

    /// <summary>
    ///     vkCreateShaderModule - Creates a new shader module object -
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCreateShaderModule.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCreateShaderModule.html</a>
    /// </summary>
    /// <param name="device">device is the logical device that creates the shader module.</param>
    /// <param name="pCreateInfo">pCreateInfo is a pointer to a VkShaderModuleCreateInfostructure.</param>
    /// <param name="pAllocator">pAllocator controls host memory allocation as described in the Memory Allocation chapter.</param>
    /// <param name="pShaderModule">
    ///     pShaderModule is a pointer to a VkShaderModule handle in which the resulting shader module
    ///     object is returned.
    /// </param>
    /// <remarks>
    ///     <list type="table">
    ///         <item>
    ///             <term>successcodes</term><description>VK_SUCCESS</description>
    ///         </item>
    ///         <item>
    ///             <term>errorcodes</term>
    ///             <description>VK_ERROR_OUT_OF_HOST_MEMORY,VK_ERROR_OUT_OF_DEVICE_MEMORY,VK_ERROR_INVALID_SHADER_NV</description>
    ///         </item>
    ///     </list>
    /// </remarks>
    [VkVersion("1.0")]
    [SuppressUnmanagedCodeSecurity]
    [DllImport(VK_IMPORT, EntryPoint = "vkCreateShaderModule")]
    public static extern unsafe VkResult vkCreateShaderModule(
        VkDevice                  device,
        VkShaderModuleCreateInfo* pCreateInfo,
        VkAllocationCallbacks*    pAllocator,
        VkShaderModule*           pShaderModule);

    /// <summary>
    ///     vkDestroyShaderModule - Destroy a shader module -
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkDestroyShaderModule.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkDestroyShaderModule.html</a>
    /// </summary>
    /// <param name="device">device is the logical device that destroys the shader module.</param>
    /// <param name="shaderModule">shaderModule is the handle of the shader module to destroy.</param>
    /// <param name="pAllocator">pAllocator controls host memory allocation as described in the Memory Allocation chapter.</param>
    [VkVersion("1.0")]
    [SuppressUnmanagedCodeSecurity]
    [DllImport(VK_IMPORT, EntryPoint = "vkDestroyShaderModule")]
    public static extern unsafe void vkDestroyShaderModule(
        VkDevice               device,
        VkShaderModule         shaderModule,
        VkAllocationCallbacks* pAllocator);

    /// <summary>
    ///     vkCreatePipelineCache - Creates a new pipeline cache -
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCreatePipelineCache.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCreatePipelineCache.html</a>
    /// </summary>
    /// <param name="device">device is the logical device that creates the pipeline cache object.</param>
    /// <param name="pCreateInfo">
    ///     pCreateInfo is a pointer to a VkPipelineCacheCreateInfostructure containing initial
    ///     parameters for the pipeline cache object.
    /// </param>
    /// <param name="pAllocator">pAllocator controls host memory allocation as described in the Memory Allocation chapter.</param>
    /// <param name="pPipelineCache">
    ///     pPipelineCache is a pointer to a VkPipelineCache handle in which the resulting pipeline
    ///     cache object is returned.
    /// </param>
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
    [VkVersion("1.0")]
    [SuppressUnmanagedCodeSecurity]
    [DllImport(VK_IMPORT, EntryPoint = "vkCreatePipelineCache")]
    public static extern unsafe VkResult vkCreatePipelineCache(
        VkDevice                   device,
        VkPipelineCacheCreateInfo* pCreateInfo,
        VkAllocationCallbacks*     pAllocator,
        VkPipelineCache*           pPipelineCache);

    /// <summary>
    ///     vkDestroyPipelineCache - Destroy a pipeline cache object -
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkDestroyPipelineCache.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkDestroyPipelineCache.html</a>
    /// </summary>
    /// <param name="device">device is the logical device that destroys the pipeline cache object.</param>
    /// <param name="pipelineCache">pipelineCache is the handle of the pipeline cache to destroy.</param>
    /// <param name="pAllocator">pAllocator controls host memory allocation as described in the Memory Allocation chapter.</param>
    [VkVersion("1.0")]
    [SuppressUnmanagedCodeSecurity]
    [DllImport(VK_IMPORT, EntryPoint = "vkDestroyPipelineCache")]
    public static extern unsafe void vkDestroyPipelineCache(
        VkDevice               device,
        VkPipelineCache        pipelineCache,
        VkAllocationCallbacks* pAllocator);

    /// <summary>
    ///     vkGetPipelineCacheData - Get the data store from a pipeline cache -
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkGetPipelineCacheData.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkGetPipelineCacheData.html</a>
    /// </summary>
    /// <param name="device">device is the logical device that owns the pipeline cache.</param>
    /// <param name="pipelineCache">pipelineCache is the pipeline cache to retrieve data from.</param>
    /// <param name="pDataSize">
    ///     pDataSize is a pointer to a size_t value related to the amount of data in the pipeline cache,
    ///     as described below.
    /// </param>
    /// <param name="pData">pData is either NULL or a pointer to a buffer.</param>
    /// <remarks>
    ///     <list type="table">
    ///         <item>
    ///             <term>successcodes</term><description>VK_SUCCESS,VK_INCOMPLETE</description>
    ///         </item>
    ///         <item>
    ///             <term>errorcodes</term><description>VK_ERROR_OUT_OF_HOST_MEMORY,VK_ERROR_OUT_OF_DEVICE_MEMORY</description>
    ///         </item>
    ///     </list>
    /// </remarks>
    [VkVersion("1.0")]
    [SuppressUnmanagedCodeSecurity]
    [DllImport(VK_IMPORT, EntryPoint = "vkGetPipelineCacheData")]
    public static extern unsafe VkResult vkGetPipelineCacheData(
        VkDevice        device,
        VkPipelineCache pipelineCache,
        nuint*          pDataSize,
        void*           pData);

    /// <summary>
    ///     vkMergePipelineCaches - Combine the data stores of pipeline caches -
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkMergePipelineCaches.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkMergePipelineCaches.html</a>
    /// </summary>
    /// <param name="device">device is the logical device that owns the pipeline cache objects.</param>
    /// <param name="dstCache">dstCache is the handle of the pipeline cache to merge results into.</param>
    /// <param name="srcCacheCount">srcCacheCount is the length of the pSrcCaches array.</param>
    /// <param name="pSrcCaches">
    ///     pSrcCaches is a pointer to an array of pipeline cache handles, which will be merged into
    ///     dstCache. The previous contents of dstCache are included after the merge.
    /// </param>
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
    [VkVersion("1.0")]
    [SuppressUnmanagedCodeSecurity]
    [DllImport(VK_IMPORT, EntryPoint = "vkMergePipelineCaches")]
    public static extern unsafe VkResult vkMergePipelineCaches(
        VkDevice         device,
        VkPipelineCache  dstCache,
        uint             srcCacheCount,
        VkPipelineCache* pSrcCaches);

    /// <summary>
    ///     vkCreateGraphicsPipelines - Create graphics pipelines -
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCreateGraphicsPipelines.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCreateGraphicsPipelines.html</a>
    /// </summary>
    /// <param name="device">device is the logical device that creates the graphics pipelines.</param>
    /// <param name="pipelineCache">
    ///     pipelineCache is either VK_NULL_HANDLE, indicating that pipeline caching is disabled; or
    ///     the handle of a valid pipeline cache object, in which case use of that cache is enabled for the duration of the
    ///     command.
    /// </param>
    /// <param name="createInfoCount">createInfoCount is the length of the pCreateInfos and pPipelines arrays.</param>
    /// <param name="pCreateInfos">pCreateInfos is a pointer to an array of VkGraphicsPipelineCreateInfo structures.</param>
    /// <param name="pAllocator">pAllocator controls host memory allocation as described in the Memory Allocation chapter.</param>
    /// <param name="pPipelines">
    ///     pPipelines is a pointer to an array of VkPipeline handles in which the resulting graphics
    ///     pipeline objects are returned.
    /// </param>
    /// <remarks>
    ///     <list type="table">
    ///         <item>
    ///             <term>successcodes</term><description>VK_SUCCESS,VK_PIPELINE_COMPILE_REQUIRED_EXT</description>
    ///         </item>
    ///         <item>
    ///             <term>errorcodes</term>
    ///             <description>VK_ERROR_OUT_OF_HOST_MEMORY,VK_ERROR_OUT_OF_DEVICE_MEMORY,VK_ERROR_INVALID_SHADER_NV</description>
    ///         </item>
    ///     </list>
    /// </remarks>
    [VkVersion("1.0")]
    [SuppressUnmanagedCodeSecurity]
    [DllImport(VK_IMPORT, EntryPoint = "vkCreateGraphicsPipelines")]
    public static extern unsafe VkResult vkCreateGraphicsPipelines(
        VkDevice                      device,
        VkPipelineCache               pipelineCache,
        uint                          createInfoCount,
        VkGraphicsPipelineCreateInfo* pCreateInfos,
        VkAllocationCallbacks*        pAllocator,
        VkPipeline*                   pPipelines);

    /// <summary>
    ///     vkCreateComputePipelines - Creates a new compute pipeline object -
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCreateComputePipelines.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCreateComputePipelines.html</a>
    /// </summary>
    /// <param name="device">device is the logical device that creates the compute pipelines.</param>
    /// <param name="pipelineCache">
    ///     pipelineCache is either VK_NULL_HANDLE, indicating that pipeline caching is disabled; or
    ///     the handle of a valid pipeline cache object, in which case use of that cache is enabled for the duration of the
    ///     command.
    /// </param>
    /// <param name="createInfoCount">createInfoCount is the length of the pCreateInfos and pPipelines arrays.</param>
    /// <param name="pCreateInfos">pCreateInfos is a pointer to an array of VkComputePipelineCreateInfo structures.</param>
    /// <param name="pAllocator">pAllocator controls host memory allocation as described in the Memory Allocation chapter.</param>
    /// <param name="pPipelines">
    ///     pPipelines is a pointer to an array of VkPipeline handles in which the resulting compute
    ///     pipeline objects are returned.editing-noteTODO (Jon) - Should we say something like &#8220;the i&#8217;th element
    ///     of the pPipelines array is created based on the corresponding element of the pCreateInfos array&#8221;? Also for
    ///     vkCreateGraphicsPipelines below.
    /// </param>
    /// <remarks>
    ///     <list type="table">
    ///         <item>
    ///             <term>successcodes</term><description>VK_SUCCESS,VK_PIPELINE_COMPILE_REQUIRED_EXT</description>
    ///         </item>
    ///         <item>
    ///             <term>errorcodes</term>
    ///             <description>VK_ERROR_OUT_OF_HOST_MEMORY,VK_ERROR_OUT_OF_DEVICE_MEMORY,VK_ERROR_INVALID_SHADER_NV</description>
    ///         </item>
    ///     </list>
    /// </remarks>
    [VkVersion("1.0")]
    [SuppressUnmanagedCodeSecurity]
    [DllImport(VK_IMPORT, EntryPoint = "vkCreateComputePipelines")]
    public static extern unsafe VkResult vkCreateComputePipelines(
        VkDevice                     device,
        VkPipelineCache              pipelineCache,
        uint                         createInfoCount,
        VkComputePipelineCreateInfo* pCreateInfos,
        VkAllocationCallbacks*       pAllocator,
        VkPipeline*                  pPipelines);

    /// <summary>
    ///     vkDestroyPipeline - Destroy a pipeline object -
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkDestroyPipeline.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkDestroyPipeline.html</a>
    /// </summary>
    /// <param name="device">device is the logical device that destroys the pipeline.</param>
    /// <param name="pipeline">pipeline is the handle of the pipeline to destroy.</param>
    /// <param name="pAllocator">pAllocator controls host memory allocation as described in the Memory Allocation chapter.</param>
    [VkVersion("1.0")]
    [SuppressUnmanagedCodeSecurity]
    [DllImport(VK_IMPORT, EntryPoint = "vkDestroyPipeline")]
    public static extern unsafe void vkDestroyPipeline(
        VkDevice               device,
        VkPipeline             pipeline,
        VkAllocationCallbacks* pAllocator);

    /// <summary>
    ///     vkCreatePipelineLayout - Creates a new pipeline layout object -
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCreatePipelineLayout.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCreatePipelineLayout.html</a>
    /// </summary>
    /// <param name="device">device is the logical device that creates the pipeline layout.</param>
    /// <param name="pCreateInfo">
    ///     pCreateInfo is a pointer to a VkPipelineLayoutCreateInfostructure specifying the state of the
    ///     pipeline layout object.
    /// </param>
    /// <param name="pAllocator">pAllocator controls host memory allocation as described in the Memory Allocation chapter.</param>
    /// <param name="pPipelineLayout">
    ///     pPipelineLayout is a pointer to a VkPipelineLayout handle in which the resulting pipeline
    ///     layout object is returned.
    /// </param>
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
    [VkVersion("1.0")]
    [SuppressUnmanagedCodeSecurity]
    [DllImport(VK_IMPORT, EntryPoint = "vkCreatePipelineLayout")]
    public static extern unsafe VkResult vkCreatePipelineLayout(
        VkDevice                    device,
        VkPipelineLayoutCreateInfo* pCreateInfo,
        VkAllocationCallbacks*      pAllocator,
        VkPipelineLayout*           pPipelineLayout);

    /// <summary>
    ///     vkDestroyPipelineLayout - Destroy a pipeline layout object -
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkDestroyPipelineLayout.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkDestroyPipelineLayout.html</a>
    /// </summary>
    /// <param name="device">device is the logical device that destroys the pipeline layout.</param>
    /// <param name="pipelineLayout">pipelineLayout is the pipeline layout to destroy.</param>
    /// <param name="pAllocator">pAllocator controls host memory allocation as described in the Memory Allocation chapter.</param>
    [VkVersion("1.0")]
    [SuppressUnmanagedCodeSecurity]
    [DllImport(VK_IMPORT, EntryPoint = "vkDestroyPipelineLayout")]
    public static extern unsafe void vkDestroyPipelineLayout(
        VkDevice               device,
        VkPipelineLayout       pipelineLayout,
        VkAllocationCallbacks* pAllocator);

    /// <summary>
    ///     vkCreateSampler - Create a new sampler object -
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCreateSampler.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCreateSampler.html</a>
    /// </summary>
    /// <param name="device">device is the logical device that creates the sampler.</param>
    /// <param name="pCreateInfo">
    ///     pCreateInfo is a pointer to a VkSamplerCreateInfo structure specifying the state of the
    ///     sampler object.
    /// </param>
    /// <param name="pAllocator">pAllocator controls host memory allocation as described in the Memory Allocation chapter.</param>
    /// <param name="pSampler">pSampler is a pointer to a VkSampler handle in which the resulting sampler object is returned.</param>
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
    [VkVersion("1.0")]
    [SuppressUnmanagedCodeSecurity]
    [DllImport(VK_IMPORT, EntryPoint = "vkCreateSampler")]
    public static extern unsafe VkResult vkCreateSampler(
        VkDevice               device,
        VkSamplerCreateInfo*   pCreateInfo,
        VkAllocationCallbacks* pAllocator,
        VkSampler*             pSampler);

    /// <summary>
    ///     vkDestroySampler - Destroy a sampler object -
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkDestroySampler.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkDestroySampler.html</a>
    /// </summary>
    /// <param name="device">device is the logical device that destroys the sampler.</param>
    /// <param name="sampler">sampler is the sampler to destroy.</param>
    /// <param name="pAllocator">pAllocator controls host memory allocation as described in the Memory Allocation chapter.</param>
    [VkVersion("1.0")]
    [SuppressUnmanagedCodeSecurity]
    [DllImport(VK_IMPORT, EntryPoint = "vkDestroySampler")]
    public static extern unsafe void vkDestroySampler(
        VkDevice               device,
        VkSampler              sampler,
        VkAllocationCallbacks* pAllocator);

    /// <summary>
    ///     vkCreateDescriptorSetLayout - Create a new descriptor set layout -
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCreateDescriptorSetLayout.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCreateDescriptorSetLayout.html</a>
    /// </summary>
    /// <param name="device">device is the logical device that creates the descriptor set layout.</param>
    /// <param name="pCreateInfo">
    ///     pCreateInfo is a pointer to a VkDescriptorSetLayoutCreateInfo structure specifying the state
    ///     of the descriptor set layout object.
    /// </param>
    /// <param name="pAllocator">pAllocator controls host memory allocation as described in the Memory Allocation chapter.</param>
    /// <param name="pSetLayout">
    ///     pSetLayout is a pointer to a VkDescriptorSetLayout handle in which the resulting descriptor
    ///     set layout object is returned.
    /// </param>
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
    [VkVersion("1.0")]
    [SuppressUnmanagedCodeSecurity]
    [DllImport(VK_IMPORT, EntryPoint = "vkCreateDescriptorSetLayout")]
    public static extern unsafe VkResult vkCreateDescriptorSetLayout(
        VkDevice                         device,
        VkDescriptorSetLayoutCreateInfo* pCreateInfo,
        VkAllocationCallbacks*           pAllocator,
        VkDescriptorSetLayout*           pSetLayout);

    /// <summary>
    ///     vkDestroyDescriptorSetLayout - Destroy a descriptor set layout object -
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkDestroyDescriptorSetLayout.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkDestroyDescriptorSetLayout.html</a>
    /// </summary>
    /// <param name="device">device is the logical device that destroys the descriptor set layout.</param>
    /// <param name="descriptorSetLayout">descriptorSetLayout is the descriptor set layout to destroy.</param>
    /// <param name="pAllocator">pAllocator controls host memory allocation as described in the Memory Allocation chapter.</param>
    [VkVersion("1.0")]
    [SuppressUnmanagedCodeSecurity]
    [DllImport(VK_IMPORT, EntryPoint = "vkDestroyDescriptorSetLayout")]
    public static extern unsafe void vkDestroyDescriptorSetLayout(
        VkDevice               device,
        VkDescriptorSetLayout  descriptorSetLayout,
        VkAllocationCallbacks* pAllocator);

    /// <summary>
    ///     vkCreateDescriptorPool - Creates a descriptor pool object -
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCreateDescriptorPool.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCreateDescriptorPool.html</a>
    /// </summary>
    /// <param name="device">device is the logical device that creates the descriptor pool.</param>
    /// <param name="pCreateInfo">
    ///     pCreateInfo is a pointer to a VkDescriptorPoolCreateInfostructure specifying the state of the
    ///     descriptor pool object.
    /// </param>
    /// <param name="pAllocator">pAllocator controls host memory allocation as described in the Memory Allocation chapter.</param>
    /// <param name="pDescriptorPool">
    ///     pDescriptorPool is a pointer to a VkDescriptorPool handle in which the resulting
    ///     descriptor pool object is returned.
    /// </param>
    /// <remarks>
    ///     <list type="table">
    ///         <item>
    ///             <term>successcodes</term><description>VK_SUCCESS</description>
    ///         </item>
    ///         <item>
    ///             <term>errorcodes</term>
    ///             <description>VK_ERROR_OUT_OF_HOST_MEMORY,VK_ERROR_OUT_OF_DEVICE_MEMORY,VK_ERROR_FRAGMENTATION_EXT</description>
    ///         </item>
    ///     </list>
    /// </remarks>
    [VkVersion("1.0")]
    [SuppressUnmanagedCodeSecurity]
    [DllImport(VK_IMPORT, EntryPoint = "vkCreateDescriptorPool")]
    public static extern unsafe VkResult vkCreateDescriptorPool(
        VkDevice                    device,
        VkDescriptorPoolCreateInfo* pCreateInfo,
        VkAllocationCallbacks*      pAllocator,
        VkDescriptorPool*           pDescriptorPool);

    /// <summary>
    ///     vkDestroyDescriptorPool - Destroy a descriptor pool object -
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkDestroyDescriptorPool.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkDestroyDescriptorPool.html</a>
    /// </summary>
    /// <param name="device">device is the logical device that destroys the descriptor pool.</param>
    /// <param name="descriptorPool">descriptorPool is the descriptor pool to destroy.</param>
    /// <param name="pAllocator">pAllocator controls host memory allocation as described in the Memory Allocation chapter.</param>
    [VkVersion("1.0")]
    [SuppressUnmanagedCodeSecurity]
    [DllImport(VK_IMPORT, EntryPoint = "vkDestroyDescriptorPool")]
    public static extern unsafe void vkDestroyDescriptorPool(
        VkDevice               device,
        VkDescriptorPool       descriptorPool,
        VkAllocationCallbacks* pAllocator);

    /// <summary>
    ///     vkResetDescriptorPool - Resets a descriptor pool object -
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkResetDescriptorPool.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkResetDescriptorPool.html</a>
    /// </summary>
    /// <param name="device">device is the logical device that owns the descriptor pool.</param>
    /// <param name="descriptorPool">descriptorPool is the descriptor pool to be reset.</param>
    /// <param name="flags">flags is reserved for future use.</param>
    /// <remarks>
    ///     <list type="table">
    ///         <item>
    ///             <term>successcodes</term><description>VK_SUCCESS</description>
    ///         </item>
    ///     </list>
    /// </remarks>
    [VkVersion("1.0")]
    [SuppressUnmanagedCodeSecurity]
    [DllImport(VK_IMPORT, EntryPoint = "vkResetDescriptorPool")]
    public static extern VkResult vkResetDescriptorPool(
        VkDevice                   device,
        VkDescriptorPool           descriptorPool,
        VkDescriptorPoolResetFlags flags);

    /// <summary>
    ///     vkAllocateDescriptorSets - Allocate one or more descriptor sets -
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkAllocateDescriptorSets.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkAllocateDescriptorSets.html</a>
    /// </summary>
    /// <param name="device">device is the logical device that owns the descriptor pool.</param>
    /// <param name="pAllocateInfo">
    ///     pAllocateInfo is a pointer to a VkDescriptorSetAllocateInfostructure describing parameters
    ///     of the allocation.
    /// </param>
    /// <param name="pDescriptorSets">
    ///     pDescriptorSets is a pointer to an array of VkDescriptorSethandles in which the resulting
    ///     descriptor set objects are returned.
    /// </param>
    /// <remarks>
    ///     <list type="table">
    ///         <item>
    ///             <term>successcodes</term><description>VK_SUCCESS</description>
    ///         </item>
    ///         <item>
    ///             <term>errorcodes</term>
    ///             <description>VK_ERROR_OUT_OF_HOST_MEMORY,VK_ERROR_OUT_OF_DEVICE_MEMORY,VK_ERROR_FRAGMENTED_POOL,VK_ERROR_OUT_OF_POOL_MEMORY</description>
    ///         </item>
    ///     </list>
    /// </remarks>
    [VkVersion("1.0")]
    [SuppressUnmanagedCodeSecurity]
    [DllImport(VK_IMPORT, EntryPoint = "vkAllocateDescriptorSets")]
    public static extern unsafe VkResult vkAllocateDescriptorSets(
        VkDevice                     device,
        VkDescriptorSetAllocateInfo* pAllocateInfo,
        VkDescriptorSet*             pDescriptorSets);

    /// <summary>
    ///     vkFreeDescriptorSets - Free one or more descriptor sets -
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkFreeDescriptorSets.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkFreeDescriptorSets.html</a>
    /// </summary>
    /// <param name="device">device is the logical device that owns the descriptor pool.</param>
    /// <param name="descriptorPool">descriptorPool is the descriptor pool from which the descriptor sets were allocated.</param>
    /// <param name="descriptorSetCount">descriptorSetCount is the number of elements in the pDescriptorSets array.</param>
    /// <param name="pDescriptorSets">pDescriptorSets is a pointer to an array of handles to VkDescriptorSet objects.</param>
    /// <remarks>
    ///     <list type="table">
    ///         <item>
    ///             <term>successcodes</term><description>VK_SUCCESS</description>
    ///         </item>
    ///     </list>
    /// </remarks>
    [VkVersion("1.0")]
    [SuppressUnmanagedCodeSecurity]
    [DllImport(VK_IMPORT, EntryPoint = "vkFreeDescriptorSets")]
    public static extern unsafe VkResult vkFreeDescriptorSets(
        VkDevice         device,
        VkDescriptorPool descriptorPool,
        uint             descriptorSetCount,
        VkDescriptorSet* pDescriptorSets);

    /// <summary>
    ///     vkUpdateDescriptorSets - Update the contents of a descriptor set object -
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkUpdateDescriptorSets.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkUpdateDescriptorSets.html</a>
    /// </summary>
    /// <param name="device">device is the logical device that updates the descriptor sets.</param>
    /// <param name="descriptorWriteCount">descriptorWriteCount is the number of elements in the pDescriptorWrites array.</param>
    /// <param name="pDescriptorWrites">
    ///     pDescriptorWrites is a pointer to an array of VkWriteDescriptorSet structures
    ///     describing the descriptor sets to write to.
    /// </param>
    /// <param name="descriptorCopyCount">descriptorCopyCount is the number of elements in the pDescriptorCopies array.</param>
    /// <param name="pDescriptorCopies">
    ///     pDescriptorCopies is a pointer to an array of VkCopyDescriptorSet structures describing
    ///     the descriptor sets to copy between.
    /// </param>
    [VkVersion("1.0")]
    [SuppressUnmanagedCodeSecurity]
    [DllImport(VK_IMPORT, EntryPoint = "vkUpdateDescriptorSets")]
    public static extern unsafe void vkUpdateDescriptorSets(
        VkDevice              device,
        uint                  descriptorWriteCount,
        VkWriteDescriptorSet* pDescriptorWrites,
        uint                  descriptorCopyCount,
        VkCopyDescriptorSet*  pDescriptorCopies);

    /// <summary>
    ///     vkCreateFramebuffer - Create a new framebuffer object -
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCreateFramebuffer.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCreateFramebuffer.html</a>
    /// </summary>
    /// <param name="device">device is the logical device that creates the framebuffer.</param>
    /// <param name="pCreateInfo">
    ///     pCreateInfo is a pointer to a VkFramebufferCreateInfostructure describing additional
    ///     information about framebuffer creation.
    /// </param>
    /// <param name="pAllocator">pAllocator controls host memory allocation as described in the Memory Allocation chapter.</param>
    /// <param name="pFramebuffer">
    ///     pFramebuffer is a pointer to a VkFramebuffer handle in which the resulting framebuffer
    ///     object is returned.
    /// </param>
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
    [VkVersion("1.0")]
    [SuppressUnmanagedCodeSecurity]
    [DllImport(VK_IMPORT, EntryPoint = "vkCreateFramebuffer")]
    public static extern unsafe VkResult vkCreateFramebuffer(
        VkDevice                 device,
        VkFramebufferCreateInfo* pCreateInfo,
        VkAllocationCallbacks*   pAllocator,
        VkFramebuffer*           pFramebuffer);

    /// <summary>
    ///     vkDestroyFramebuffer - Destroy a framebuffer object -
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkDestroyFramebuffer.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkDestroyFramebuffer.html</a>
    /// </summary>
    /// <param name="device">device is the logical device that destroys the framebuffer.</param>
    /// <param name="framebuffer">framebuffer is the handle of the framebuffer to destroy.</param>
    /// <param name="pAllocator">pAllocator controls host memory allocation as described in the Memory Allocation chapter.</param>
    [VkVersion("1.0")]
    [SuppressUnmanagedCodeSecurity]
    [DllImport(VK_IMPORT, EntryPoint = "vkDestroyFramebuffer")]
    public static extern unsafe void vkDestroyFramebuffer(
        VkDevice               device,
        VkFramebuffer          framebuffer,
        VkAllocationCallbacks* pAllocator);

    /// <summary>
    ///     vkCreateRenderPass - Create a new render pass object -
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCreateRenderPass.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCreateRenderPass.html</a>
    /// </summary>
    /// <param name="device">device is the logical device that creates the render pass.</param>
    /// <param name="pCreateInfo">
    ///     pCreateInfo is a pointer to a VkRenderPassCreateInfostructure describing the parameters of
    ///     the render pass.
    /// </param>
    /// <param name="pAllocator">pAllocator controls host memory allocation as described in the Memory Allocation chapter.</param>
    /// <param name="pRenderPass">
    ///     pRenderPass is a pointer to a VkRenderPass handle in which the resulting render pass object
    ///     is returned.
    /// </param>
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
    [VkVersion("1.0")]
    [SuppressUnmanagedCodeSecurity]
    [DllImport(VK_IMPORT, EntryPoint = "vkCreateRenderPass")]
    public static extern unsafe VkResult vkCreateRenderPass(
        VkDevice                device,
        VkRenderPassCreateInfo* pCreateInfo,
        VkAllocationCallbacks*  pAllocator,
        VkRenderPass*           pRenderPass);

    /// <summary>
    ///     vkDestroyRenderPass - Destroy a render pass object -
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkDestroyRenderPass.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkDestroyRenderPass.html</a>
    /// </summary>
    /// <param name="device">device is the logical device that destroys the render pass.</param>
    /// <param name="renderPass">renderPass is the handle of the render pass to destroy.</param>
    /// <param name="pAllocator">pAllocator controls host memory allocation as described in the Memory Allocation chapter.</param>
    [VkVersion("1.0")]
    [SuppressUnmanagedCodeSecurity]
    [DllImport(VK_IMPORT, EntryPoint = "vkDestroyRenderPass")]
    public static extern unsafe void vkDestroyRenderPass(
        VkDevice               device,
        VkRenderPass           renderPass,
        VkAllocationCallbacks* pAllocator);

    /// <summary>
    ///     vkGetRenderAreaGranularity - Returns the granularity for optimal render area -
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkGetRenderAreaGranularity.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkGetRenderAreaGranularity.html</a>
    /// </summary>
    /// <param name="device">device is the logical device that owns the render pass.</param>
    /// <param name="renderPass">renderPass is a handle to a render pass.</param>
    /// <param name="pGranularity">pGranularity is a pointer to a VkExtent2D structure in which the granularity is returned.</param>
    [VkVersion("1.0")]
    [SuppressUnmanagedCodeSecurity]
    [DllImport(VK_IMPORT, EntryPoint = "vkGetRenderAreaGranularity")]
    public static extern unsafe void vkGetRenderAreaGranularity(
        VkDevice     device,
        VkRenderPass renderPass,
        VkExtent2D*  pGranularity);

    /// <summary>
    ///     vkCreateCommandPool - Create a new command pool object -
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCreateCommandPool.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCreateCommandPool.html</a>
    /// </summary>
    /// <param name="device">device is the logical device that creates the command pool.</param>
    /// <param name="pCreateInfo">
    ///     pCreateInfo is a pointer to a VkCommandPoolCreateInfostructure specifying the state of the
    ///     command pool object.
    /// </param>
    /// <param name="pAllocator">pAllocator controls host memory allocation as described in the Memory Allocation chapter.</param>
    /// <param name="pCommandPool">pCommandPool is a pointer to a VkCommandPool handle in which the created pool is returned.</param>
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
    [VkVersion("1.0")]
    [SuppressUnmanagedCodeSecurity]
    [DllImport(VK_IMPORT, EntryPoint = "vkCreateCommandPool")]
    public static extern unsafe VkResult vkCreateCommandPool(
        VkDevice                 device,
        VkCommandPoolCreateInfo* pCreateInfo,
        VkAllocationCallbacks*   pAllocator,
        VkCommandPool*           pCommandPool);

    /// <summary>
    ///     vkDestroyCommandPool - Destroy a command pool object -
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkDestroyCommandPool.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkDestroyCommandPool.html</a>
    /// </summary>
    /// <param name="device">device is the logical device that destroys the command pool.</param>
    /// <param name="commandPool">commandPool is the handle of the command pool to destroy.</param>
    /// <param name="pAllocator">pAllocator controls host memory allocation as described in the Memory Allocation chapter.</param>
    [VkVersion("1.0")]
    [SuppressUnmanagedCodeSecurity]
    [DllImport(VK_IMPORT, EntryPoint = "vkDestroyCommandPool")]
    public static extern unsafe void vkDestroyCommandPool(
        VkDevice               device,
        VkCommandPool          commandPool,
        VkAllocationCallbacks* pAllocator);

    /// <summary>
    ///     vkResetCommandPool - Reset a command pool -
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkResetCommandPool.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkResetCommandPool.html</a>
    /// </summary>
    /// <param name="device">device is the logical device that owns the command pool.</param>
    /// <param name="commandPool">commandPool is the command pool to reset.</param>
    /// <param name="flags">flags is a bitmask of VkCommandPoolResetFlagBits controlling the reset operation.</param>
    /// <remarks>
    ///     <list type="table">
    ///         <item>
    ///             <term>successcodes</term><description>VK_SUCCESS</description>
    ///         </item>
    ///         <item>
    ///             <term>errorcodes</term><description>VK_ERROR_OUT_OF_DEVICE_MEMORY</description>
    ///         </item>
    ///     </list>
    /// </remarks>
    [VkVersion("1.0")]
    [SuppressUnmanagedCodeSecurity]
    [DllImport(VK_IMPORT, EntryPoint = "vkResetCommandPool")]
    public static extern VkResult vkResetCommandPool(
        VkDevice                device,
        VkCommandPool           commandPool,
        VkCommandPoolResetFlags flags);

    /// <summary>
    ///     vkAllocateCommandBuffers - Allocate command buffers from an existing command pool -
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkAllocateCommandBuffers.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkAllocateCommandBuffers.html</a>
    /// </summary>
    /// <param name="device">device is the logical device that owns the command pool.</param>
    /// <param name="pAllocateInfo">
    ///     pAllocateInfo is a pointer to a VkCommandBufferAllocateInfostructure describing parameters
    ///     of the allocation.
    /// </param>
    /// <param name="pCommandBuffers">
    ///     pCommandBuffers is a pointer to an array of VkCommandBufferhandles in which the resulting
    ///     command buffer objects are returned. The array must be at least the length specified by the commandBufferCount
    ///     member of pAllocateInfo. Each allocated command buffer begins in the initial state.
    /// </param>
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
    [VkVersion("1.0")]
    [SuppressUnmanagedCodeSecurity]
    [DllImport(VK_IMPORT, EntryPoint = "vkAllocateCommandBuffers")]
    public static extern unsafe VkResult vkAllocateCommandBuffers(
        VkDevice                     device,
        VkCommandBufferAllocateInfo* pAllocateInfo,
        VkCommandBuffer*             pCommandBuffers);

    /// <summary>
    ///     vkFreeCommandBuffers - Free command buffers -
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkFreeCommandBuffers.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkFreeCommandBuffers.html</a>
    /// </summary>
    /// <param name="device">device is the logical device that owns the command pool.</param>
    /// <param name="commandPool">commandPool is the command pool from which the command buffers were allocated.</param>
    /// <param name="commandBufferCount">commandBufferCount is the length of the pCommandBuffersarray.</param>
    /// <param name="pCommandBuffers">pCommandBuffers is a pointer to an array of handles of command buffers to free.</param>
    [VkVersion("1.0")]
    [SuppressUnmanagedCodeSecurity]
    [DllImport(VK_IMPORT, EntryPoint = "vkFreeCommandBuffers")]
    public static extern unsafe void vkFreeCommandBuffers(
        VkDevice         device,
        VkCommandPool    commandPool,
        uint             commandBufferCount,
        VkCommandBuffer* pCommandBuffers);

    /// <summary>
    ///     vkBeginCommandBuffer - Start recording a command buffer -
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkBeginCommandBuffer.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkBeginCommandBuffer.html</a>
    /// </summary>
    /// <param name="commandBuffer">
    ///     commandBuffer is the handle of the command buffer which is to be put in the recording
    ///     state.
    /// </param>
    /// <param name="pBeginInfo">
    ///     pBeginInfo is a pointer to a VkCommandBufferBeginInfostructure defining additional information
    ///     about how the command buffer begins recording.
    /// </param>
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
    [VkVersion("1.0")]
    [SuppressUnmanagedCodeSecurity]
    [DllImport(VK_IMPORT, EntryPoint = "vkBeginCommandBuffer")]
    public static extern unsafe VkResult vkBeginCommandBuffer(
        VkCommandBuffer           commandBuffer,
        VkCommandBufferBeginInfo* pBeginInfo);

    /// <summary>
    ///     vkEndCommandBuffer - Finish recording a command buffer -
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkEndCommandBuffer.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkEndCommandBuffer.html</a>
    /// </summary>
    /// <param name="commandBuffer">commandBuffer is the command buffer to complete recording.</param>
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
    [VkVersion("1.0")]
    [SuppressUnmanagedCodeSecurity]
    [DllImport(VK_IMPORT, EntryPoint = "vkEndCommandBuffer")]
    public static extern VkResult vkEndCommandBuffer(VkCommandBuffer commandBuffer);

    /// <summary>
    ///     vkResetCommandBuffer - Reset a command buffer to the initial state -
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkResetCommandBuffer.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkResetCommandBuffer.html</a>
    /// </summary>
    /// <param name="commandBuffer">
    ///     commandBuffer is the command buffer to reset. The command buffer can be in any state other
    ///     than pending, and is moved into the initial state.
    /// </param>
    /// <param name="flags">flags is a bitmask of VkCommandBufferResetFlagBitscontrolling the reset operation.</param>
    /// <remarks>
    ///     <list type="table">
    ///         <item>
    ///             <term>successcodes</term><description>VK_SUCCESS</description>
    ///         </item>
    ///         <item>
    ///             <term>errorcodes</term><description>VK_ERROR_OUT_OF_DEVICE_MEMORY</description>
    ///         </item>
    ///     </list>
    /// </remarks>
    [VkVersion("1.0")]
    [SuppressUnmanagedCodeSecurity]
    [DllImport(VK_IMPORT, EntryPoint = "vkResetCommandBuffer")]
    public static extern VkResult vkResetCommandBuffer(
        VkCommandBuffer           commandBuffer,
        VkCommandBufferResetFlags flags);

    /// <summary>
    ///     vkCmdBindPipeline - Bind a pipeline object to a command buffer -
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdBindPipeline.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdBindPipeline.html</a>
    /// </summary>
    /// <param name="commandBuffer">commandBuffer is the command buffer that the pipeline will be bound to.</param>
    /// <param name="pipelineBindPoint">
    ///     pipelineBindPoint is a VkPipelineBindPoint value specifying to which bind point the
    ///     pipeline is bound. Binding one does not disturb the others.
    /// </param>
    /// <param name="pipeline">pipeline is the pipeline to be bound.</param>
    [VkVersion("1.0")]
    [SuppressUnmanagedCodeSecurity]
    [DllImport(VK_IMPORT, EntryPoint = "vkCmdBindPipeline")]
    public static extern void vkCmdBindPipeline(
        VkCommandBuffer     commandBuffer,
        VkPipelineBindPoint pipelineBindPoint,
        VkPipeline          pipeline);

    /// <summary>
    ///     vkCmdSetViewport - Set the viewport dynamically for a command buffer -
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdSetViewport.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdSetViewport.html</a>
    /// </summary>
    /// <param name="commandBuffer">commandBuffer is the command buffer into which the command will be recorded.</param>
    /// <param name="firstViewport">
    ///     firstViewport is the index of the first viewport whose parameters are updated by the
    ///     command.
    /// </param>
    /// <param name="viewportCount">viewportCount is the number of viewports whose parameters are updated by the command.</param>
    /// <param name="pViewports">pViewports is a pointer to an array of VkViewport structures specifying viewport parameters.</param>
    [VkVersion("1.0")]
    [SuppressUnmanagedCodeSecurity]
    [DllImport(VK_IMPORT, EntryPoint = "vkCmdSetViewport")]
    public static extern unsafe void vkCmdSetViewport(
        VkCommandBuffer commandBuffer,
        uint            firstViewport,
        uint            viewportCount,
        VkViewport*     pViewports);

    /// <summary>
    ///     vkCmdSetScissor - Set scissor rectangles dynamically for a command buffer -
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdSetScissor.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdSetScissor.html</a>
    /// </summary>
    /// <param name="commandBuffer">commandBuffer is the command buffer into which the command will be recorded.</param>
    /// <param name="firstScissor">firstScissor is the index of the first scissor whose state is updated by the command.</param>
    /// <param name="scissorCount">scissorCount is the number of scissors whose rectangles are updated by the command.</param>
    /// <param name="pScissors">pScissors is a pointer to an array of VkRect2D structures defining scissor rectangles.</param>
    [VkVersion("1.0")]
    [SuppressUnmanagedCodeSecurity]
    [DllImport(VK_IMPORT, EntryPoint = "vkCmdSetScissor")]
    public static extern unsafe void vkCmdSetScissor(
        VkCommandBuffer commandBuffer,
        uint            firstScissor,
        uint            scissorCount,
        VkRect2D*       pScissors);

    /// <summary>
    ///     vkCmdSetLineWidth - Set line width dynamically for a command buffer -
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdSetLineWidth.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdSetLineWidth.html</a>
    /// </summary>
    /// <param name="commandBuffer">commandBuffer is the command buffer into which the command will be recorded.</param>
    /// <param name="lineWidth">lineWidth is the width of rasterized line segments.</param>
    [VkVersion("1.0")]
    [SuppressUnmanagedCodeSecurity]
    [DllImport(VK_IMPORT, EntryPoint = "vkCmdSetLineWidth")]
    public static extern void vkCmdSetLineWidth(
        VkCommandBuffer commandBuffer,
        float           lineWidth);

    /// <summary>
    ///     vkCmdSetDepthBias - Set depth bias factors and clamp dynamically for a command buffer -
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdSetDepthBias.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdSetDepthBias.html</a>
    /// </summary>
    /// <param name="commandBuffer">commandBuffer is the command buffer into which the command will be recorded.</param>
    /// <param name="depthBiasConstantFactor">
    ///     depthBiasConstantFactor is a scalar factor controlling the constant depth value
    ///     added to each fragment.
    /// </param>
    /// <param name="depthBiasClamp">depthBiasClamp is the maximum (or minimum) depth bias of a fragment.</param>
    /// <param name="depthBiasSlopeFactor">
    ///     depthBiasSlopeFactor is a scalar factor applied to a fragment&#8217;s slope in depth
    ///     bias calculations.
    /// </param>
    [VkVersion("1.0")]
    [SuppressUnmanagedCodeSecurity]
    [DllImport(VK_IMPORT, EntryPoint = "vkCmdSetDepthBias")]
    public static extern void vkCmdSetDepthBias(
        VkCommandBuffer commandBuffer,
        float           depthBiasConstantFactor,
        float           depthBiasClamp,
        float           depthBiasSlopeFactor);

    /// <summary>
    ///     vkCmdSetBlendConstants - Set the values of blend constants -
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdSetBlendConstants.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdSetBlendConstants.html</a>
    /// </summary>
    /// <param name="commandBuffer">commandBuffer is the command buffer into which the command will be recorded.</param>
    /// <param name="blendConstants">
    ///     blendConstants is a pointer to an array of four values specifying the Rc, Gc, Bc, and Ac
    ///     components of the blend constant color used in blending, depending on the blend factor.
    /// </param>
    [VkVersion("1.0")]
    [SuppressUnmanagedCodeSecurity]
    [DllImport(VK_IMPORT, EntryPoint = "vkCmdSetBlendConstants")]
    public static extern unsafe void vkCmdSetBlendConstants(
        VkCommandBuffer   commandBuffer,
        VkBlendConstants* blendConstants);

    /// <summary>
    ///     vkCmdSetDepthBounds - Set depth bounds range dynamically for a command buffer -
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdSetDepthBounds.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdSetDepthBounds.html</a>
    /// </summary>
    /// <param name="commandBuffer">commandBuffer is the command buffer into which the command will be recorded.</param>
    /// <param name="minDepthBounds">minDepthBounds is the minimum depth bound.</param>
    /// <param name="maxDepthBounds">maxDepthBounds is the maximum depth bound.</param>
    [VkVersion("1.0")]
    [SuppressUnmanagedCodeSecurity]
    [DllImport(VK_IMPORT, EntryPoint = "vkCmdSetDepthBounds")]
    public static extern void vkCmdSetDepthBounds(
        VkCommandBuffer commandBuffer,
        float           minDepthBounds,
        float           maxDepthBounds);

    /// <summary>
    ///     vkCmdSetStencilCompareMask - Set stencil compare mask dynamically for a command buffer -
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdSetStencilCompareMask.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdSetStencilCompareMask.html</a>
    /// </summary>
    /// <param name="commandBuffer">commandBuffer is the command buffer into which the command will be recorded.</param>
    /// <param name="faceMask">
    ///     faceMask is a bitmask of VkStencilFaceFlagBits specifying the set of stencil state for which to
    ///     update the compare mask.
    /// </param>
    /// <param name="compareMask">compareMask is the new value to use as the stencil compare mask.</param>
    [VkVersion("1.0")]
    [SuppressUnmanagedCodeSecurity]
    [DllImport(VK_IMPORT, EntryPoint = "vkCmdSetStencilCompareMask")]
    public static extern void vkCmdSetStencilCompareMask(
        VkCommandBuffer    commandBuffer,
        VkStencilFaceFlags faceMask,
        uint               compareMask);

    /// <summary>
    ///     vkCmdSetStencilWriteMask - Set stencil write mask dynamically for a command buffer -
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdSetStencilWriteMask.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdSetStencilWriteMask.html</a>
    /// </summary>
    /// <param name="commandBuffer">commandBuffer is the command buffer into which the command will be recorded.</param>
    /// <param name="faceMask">
    ///     faceMask is a bitmask of VkStencilFaceFlagBits specifying the set of stencil state for which to
    ///     update the write mask, as described above for vkCmdSetStencilCompareMask.
    /// </param>
    /// <param name="writeMask">writeMask is the new value to use as the stencil write mask.</param>
    [VkVersion("1.0")]
    [SuppressUnmanagedCodeSecurity]
    [DllImport(VK_IMPORT, EntryPoint = "vkCmdSetStencilWriteMask")]
    public static extern void vkCmdSetStencilWriteMask(
        VkCommandBuffer    commandBuffer,
        VkStencilFaceFlags faceMask,
        uint               writeMask);

    /// <summary>
    ///     vkCmdSetStencilReference - Set stencil reference value dynamically for a command buffer -
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdSetStencilReference.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdSetStencilReference.html</a>
    /// </summary>
    /// <param name="commandBuffer">commandBuffer is the command buffer into which the command will be recorded.</param>
    /// <param name="faceMask">
    ///     faceMask is a bitmask of VkStencilFaceFlagBits specifying the set of stencil state for which to
    ///     update the reference value, as described above for vkCmdSetStencilCompareMask.
    /// </param>
    /// <param name="reference">reference is the new value to use as the stencil reference value.</param>
    [VkVersion("1.0")]
    [SuppressUnmanagedCodeSecurity]
    [DllImport(VK_IMPORT, EntryPoint = "vkCmdSetStencilReference")]
    public static extern void vkCmdSetStencilReference(
        VkCommandBuffer    commandBuffer,
        VkStencilFaceFlags faceMask,
        uint               reference);

    /// <summary>
    ///     vkCmdBindDescriptorSets - Binds descriptor sets to a command buffer -
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdBindDescriptorSets.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdBindDescriptorSets.html</a>
    /// </summary>
    /// <param name="commandBuffer">commandBuffer is the command buffer that the descriptor sets will be bound to.</param>
    /// <param name="pipelineBindPoint">
    ///     pipelineBindPoint is a VkPipelineBindPoint indicating the type of the pipeline that
    ///     will use the descriptors. There is a separate set of bind points for each pipeline type, so binding one does not
    ///     disturb the others.
    /// </param>
    /// <param name="layout">layout is a VkPipelineLayout object used to program the bindings.</param>
    /// <param name="firstSet">firstSet is the set number of the first descriptor set to be bound.</param>
    /// <param name="descriptorSetCount">descriptorSetCount is the number of elements in the pDescriptorSets array.</param>
    /// <param name="pDescriptorSets">
    ///     pDescriptorSets is a pointer to an array of handles to VkDescriptorSet objects describing
    ///     the descriptor sets to bind to.
    /// </param>
    /// <param name="dynamicOffsetCount">dynamicOffsetCount is the number of dynamic offsets in the pDynamicOffsets array.</param>
    /// <param name="pDynamicOffsets">pDynamicOffsets is a pointer to an array of uint32_t values specifying dynamic offsets.</param>
    [VkVersion("1.0")]
    [SuppressUnmanagedCodeSecurity]
    [DllImport(VK_IMPORT, EntryPoint = "vkCmdBindDescriptorSets")]
    public static extern unsafe void vkCmdBindDescriptorSets(
        VkCommandBuffer     commandBuffer,
        VkPipelineBindPoint pipelineBindPoint,
        VkPipelineLayout    layout,
        uint                firstSet,
        uint                descriptorSetCount,
        VkDescriptorSet*    pDescriptorSets,
        uint                dynamicOffsetCount,
        uint*               pDynamicOffsets);

    /// <summary>
    ///     vkCmdBindIndexBuffer - Bind an index buffer to a command buffer -
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdBindIndexBuffer.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdBindIndexBuffer.html</a>
    /// </summary>
    /// <param name="commandBuffer">commandBuffer is the command buffer into which the command is recorded.</param>
    /// <param name="buffer">buffer is the buffer being bound.</param>
    /// <param name="offset">offset is the starting offset in bytes within buffer used in index buffer address calculations.</param>
    /// <param name="indexType">indexType is a VkIndexType value specifying the size of the indices.</param>
    [VkVersion("1.0")]
    [SuppressUnmanagedCodeSecurity]
    [DllImport(VK_IMPORT, EntryPoint = "vkCmdBindIndexBuffer")]
    public static extern void vkCmdBindIndexBuffer(
        VkCommandBuffer commandBuffer,
        VkBuffer        buffer,
        VkDeviceSize    offset,
        VkIndexType     indexType);

    /// <summary>
    ///     vkCmdBindVertexBuffers - Bind vertex buffers to a command buffer -
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdBindVertexBuffers.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdBindVertexBuffers.html</a>
    /// </summary>
    /// <param name="commandBuffer">commandBuffer is the command buffer into which the command is recorded.</param>
    /// <param name="firstBinding">
    ///     firstBinding is the index of the first vertex input binding whose state is updated by the
    ///     command.
    /// </param>
    /// <param name="bindingCount">bindingCount is the number of vertex input bindings whose state is updated by the command.</param>
    /// <param name="pBuffers">pBuffers is a pointer to an array of buffer handles.</param>
    /// <param name="pOffsets">pOffsets is a pointer to an array of buffer offsets.</param>
    [VkVersion("1.0")]
    [SuppressUnmanagedCodeSecurity]
    [DllImport(VK_IMPORT, EntryPoint = "vkCmdBindVertexBuffers")]
    public static extern unsafe void vkCmdBindVertexBuffers(
        VkCommandBuffer commandBuffer,
        uint            firstBinding,
        uint            bindingCount,
        VkBuffer*       pBuffers,
        VkDeviceSize*   pOffsets);

    /// <summary>
    ///     vkCmdDraw - Draw primitives -
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdDraw.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdDraw.html</a>
    /// </summary>
    /// <param name="commandBuffer">commandBuffer is the command buffer into which the command is recorded.</param>
    /// <param name="vertexCount">vertexCount is the number of vertices to draw.</param>
    /// <param name="instanceCount">instanceCount is the number of instances to draw.</param>
    /// <param name="firstVertex">firstVertex is the index of the first vertex to draw.</param>
    /// <param name="firstInstance">firstInstance is the instance ID of the first instance to draw.</param>
    [VkVersion("1.0")]
    [SuppressUnmanagedCodeSecurity]
    [DllImport(VK_IMPORT, EntryPoint = "vkCmdDraw")]
    public static extern void vkCmdDraw(
        VkCommandBuffer commandBuffer,
        uint            vertexCount,
        uint            instanceCount,
        uint            firstVertex,
        uint            firstInstance);

    /// <summary>
    ///     vkCmdDrawIndexed - Draw primitives with indexed vertices -
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdDrawIndexed.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdDrawIndexed.html</a>
    /// </summary>
    /// <param name="commandBuffer">commandBuffer is the command buffer into which the command is recorded.</param>
    /// <param name="indexCount">indexCount is the number of vertices to draw.</param>
    /// <param name="instanceCount">instanceCount is the number of instances to draw.</param>
    /// <param name="firstIndex">firstIndex is the base index within the index buffer.</param>
    /// <param name="vertexOffset">vertexOffset is the value added to the vertex index before indexing into the vertex buffer.</param>
    /// <param name="firstInstance">firstInstance is the instance ID of the first instance to draw.</param>
    [VkVersion("1.0")]
    [SuppressUnmanagedCodeSecurity]
    [DllImport(VK_IMPORT, EntryPoint = "vkCmdDrawIndexed")]
    public static extern void vkCmdDrawIndexed(
        VkCommandBuffer commandBuffer,
        uint            indexCount,
        uint            instanceCount,
        uint            firstIndex,
        int             vertexOffset,
        uint            firstInstance);

    /// <summary>
    ///     vkCmdDrawIndirect - Draw primitives with indirect parameters -
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdDrawIndirect.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdDrawIndirect.html</a>
    /// </summary>
    /// <param name="commandBuffer">commandBuffer is the command buffer into which the command is recorded.</param>
    /// <param name="buffer">buffer is the buffer containing draw parameters.</param>
    /// <param name="offset">offset is the byte offset into buffer where parameters begin.</param>
    /// <param name="drawCount">drawCount is the number of draws to execute, and can be zero.</param>
    /// <param name="stride">stride is the byte stride between successive sets of draw parameters.</param>
    [VkVersion("1.0")]
    [SuppressUnmanagedCodeSecurity]
    [DllImport(VK_IMPORT, EntryPoint = "vkCmdDrawIndirect")]
    public static extern void vkCmdDrawIndirect(
        VkCommandBuffer commandBuffer,
        VkBuffer        buffer,
        VkDeviceSize    offset,
        uint            drawCount,
        uint            stride);

    /// <summary>
    ///     vkCmdDrawIndexedIndirect - Draw primitives with indirect parameters and indexed vertices -
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdDrawIndexedIndirect.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdDrawIndexedIndirect.html</a>
    /// </summary>
    /// <param name="commandBuffer">commandBuffer is the command buffer into which the command is recorded.</param>
    /// <param name="buffer">buffer is the buffer containing draw parameters.</param>
    /// <param name="offset">offset is the byte offset into buffer where parameters begin.</param>
    /// <param name="drawCount">drawCount is the number of draws to execute, and can be zero.</param>
    /// <param name="stride">stride is the byte stride between successive sets of draw parameters.</param>
    [VkVersion("1.0")]
    [SuppressUnmanagedCodeSecurity]
    [DllImport(VK_IMPORT, EntryPoint = "vkCmdDrawIndexedIndirect")]
    public static extern void vkCmdDrawIndexedIndirect(
        VkCommandBuffer commandBuffer,
        VkBuffer        buffer,
        VkDeviceSize    offset,
        uint            drawCount,
        uint            stride);

    /// <summary>
    ///     vkCmdDispatch - Dispatch compute work items -
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdDispatch.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdDispatch.html</a>
    /// </summary>
    /// <param name="commandBuffer">commandBuffer is the command buffer into which the command will be recorded.</param>
    /// <param name="groupCountX">groupCountX is the number of local workgroups to dispatch in the X dimension.</param>
    /// <param name="groupCountY">groupCountY is the number of local workgroups to dispatch in the Y dimension.</param>
    /// <param name="groupCountZ">groupCountZ is the number of local workgroups to dispatch in the Z dimension.</param>
    [VkVersion("1.0")]
    [SuppressUnmanagedCodeSecurity]
    [DllImport(VK_IMPORT, EntryPoint = "vkCmdDispatch")]
    public static extern void vkCmdDispatch(
        VkCommandBuffer commandBuffer,
        uint            groupCountX,
        uint            groupCountY,
        uint            groupCountZ);

    /// <summary>
    ///     vkCmdDispatchIndirect - Dispatch compute work items with indirect parameters -
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdDispatchIndirect.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdDispatchIndirect.html</a>
    /// </summary>
    /// <param name="commandBuffer">commandBuffer is the command buffer into which the command will be recorded.</param>
    /// <param name="buffer">buffer is the buffer containing dispatch parameters.</param>
    /// <param name="offset">offset is the byte offset into buffer where parameters begin.</param>
    [VkVersion("1.0")]
    [SuppressUnmanagedCodeSecurity]
    [DllImport(VK_IMPORT, EntryPoint = "vkCmdDispatchIndirect")]
    public static extern void vkCmdDispatchIndirect(
        VkCommandBuffer commandBuffer,
        VkBuffer        buffer,
        VkDeviceSize    offset);

    /// <summary>
    ///     vkCmdCopyBuffer - Copy data between buffer regions -
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdCopyBuffer.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdCopyBuffer.html</a>
    /// </summary>
    /// <param name="commandBuffer">commandBuffer is the command buffer into which the command will be recorded.</param>
    /// <param name="srcBuffer">srcBuffer is the source buffer.</param>
    /// <param name="dstBuffer">dstBuffer is the destination buffer.</param>
    /// <param name="regionCount">regionCount is the number of regions to copy.</param>
    /// <param name="pRegions">pRegions is a pointer to an array of VkBufferCopy structures specifying the regions to copy.</param>
    [VkVersion("1.0")]
    [SuppressUnmanagedCodeSecurity]
    [DllImport(VK_IMPORT, EntryPoint = "vkCmdCopyBuffer")]
    public static extern unsafe void vkCmdCopyBuffer(
        VkCommandBuffer commandBuffer,
        VkBuffer        srcBuffer,
        VkBuffer        dstBuffer,
        uint            regionCount,
        VkBufferCopy*   pRegions);

    /// <summary>
    ///     vkCmdCopyImage - Copy data between images -
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdCopyImage.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdCopyImage.html</a>
    /// </summary>
    /// <param name="commandBuffer">commandBuffer is the command buffer into which the command will be recorded.</param>
    /// <param name="srcImage">srcImage is the source image.</param>
    /// <param name="srcImageLayout">srcImageLayout is the current layout of the source image subresource.</param>
    /// <param name="dstImage">dstImage is the destination image.</param>
    /// <param name="dstImageLayout">dstImageLayout is the current layout of the destination image subresource.</param>
    /// <param name="regionCount">regionCount is the number of regions to copy.</param>
    /// <param name="pRegions">pRegions is a pointer to an array of VkImageCopy structures specifying the regions to copy.</param>
    [VkVersion("1.0")]
    [SuppressUnmanagedCodeSecurity]
    [DllImport(VK_IMPORT, EntryPoint = "vkCmdCopyImage")]
    public static extern unsafe void vkCmdCopyImage(
        VkCommandBuffer commandBuffer,
        VkImage         srcImage,
        VkImageLayout   srcImageLayout,
        VkImage         dstImage,
        VkImageLayout   dstImageLayout,
        uint            regionCount,
        VkImageCopy*    pRegions);

    /// <summary>
    ///     vkCmdBlitImage - Copy regions of an image, potentially performing format conversion, -
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdBlitImage.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdBlitImage.html</a>
    /// </summary>
    /// <param name="commandBuffer">commandBuffer is the command buffer into which the command will be recorded.</param>
    /// <param name="srcImage">srcImage is the source image.</param>
    /// <param name="srcImageLayout">srcImageLayout is the layout of the source image subresources for the blit.</param>
    /// <param name="dstImage">dstImage is the destination image.</param>
    /// <param name="dstImageLayout">dstImageLayout is the layout of the destination image subresources for the blit.</param>
    /// <param name="regionCount">regionCount is the number of regions to blit.</param>
    /// <param name="pRegions">pRegions is a pointer to an array of VkImageBlit structures specifying the regions to blit.</param>
    /// <param name="filter">filter is a VkFilter specifying the filter to apply if the blits require scaling.</param>
    [VkVersion("1.0")]
    [SuppressUnmanagedCodeSecurity]
    [DllImport(VK_IMPORT, EntryPoint = "vkCmdBlitImage")]
    public static extern unsafe void vkCmdBlitImage(
        VkCommandBuffer commandBuffer,
        VkImage         srcImage,
        VkImageLayout   srcImageLayout,
        VkImage         dstImage,
        VkImageLayout   dstImageLayout,
        uint            regionCount,
        VkImageBlit*    pRegions,
        VkFilter        filter);

    /// <summary>
    ///     vkCmdCopyBufferToImage - Copy data from a buffer into an image -
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdCopyBufferToImage.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdCopyBufferToImage.html</a>
    /// </summary>
    /// <param name="commandBuffer">commandBuffer is the command buffer into which the command will be recorded.</param>
    /// <param name="srcBuffer">srcBuffer is the source buffer.</param>
    /// <param name="dstImage">dstImage is the destination image.</param>
    /// <param name="dstImageLayout">dstImageLayout is the layout of the destination image subresources for the copy.</param>
    /// <param name="regionCount">regionCount is the number of regions to copy.</param>
    /// <param name="pRegions">pRegions is a pointer to an array of VkBufferImageCopystructures specifying the regions to copy.</param>
    [VkVersion("1.0")]
    [SuppressUnmanagedCodeSecurity]
    [DllImport(VK_IMPORT, EntryPoint = "vkCmdCopyBufferToImage")]
    public static extern unsafe void vkCmdCopyBufferToImage(
        VkCommandBuffer    commandBuffer,
        VkBuffer           srcBuffer,
        VkImage            dstImage,
        VkImageLayout      dstImageLayout,
        uint               regionCount,
        VkBufferImageCopy* pRegions);

    /// <summary>
    ///     vkCmdCopyImageToBuffer - Copy image data into a buffer -
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdCopyImageToBuffer.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdCopyImageToBuffer.html</a>
    /// </summary>
    /// <param name="commandBuffer">commandBuffer is the command buffer into which the command will be recorded.</param>
    /// <param name="srcImage">srcImage is the source image.</param>
    /// <param name="srcImageLayout">srcImageLayout is the layout of the source image subresources for the copy.</param>
    /// <param name="dstBuffer">dstBuffer is the destination buffer.</param>
    /// <param name="regionCount">regionCount is the number of regions to copy.</param>
    /// <param name="pRegions">pRegions is a pointer to an array of VkBufferImageCopystructures specifying the regions to copy.</param>
    [VkVersion("1.0")]
    [SuppressUnmanagedCodeSecurity]
    [DllImport(VK_IMPORT, EntryPoint = "vkCmdCopyImageToBuffer")]
    public static extern unsafe void vkCmdCopyImageToBuffer(
        VkCommandBuffer    commandBuffer,
        VkImage            srcImage,
        VkImageLayout      srcImageLayout,
        VkBuffer           dstBuffer,
        uint               regionCount,
        VkBufferImageCopy* pRegions);

    /// <summary>
    ///     vkCmdUpdateBuffer - Update a buffer's contents from host memory -
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdUpdateBuffer.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdUpdateBuffer.html</a>
    /// </summary>
    /// <param name="commandBuffer">commandBuffer is the command buffer into which the command will be recorded.</param>
    /// <param name="dstBuffer">dstBuffer is a handle to the buffer to be updated.</param>
    /// <param name="dstOffset">dstOffset is the byte offset into the buffer to start updating, and must be a multiple of 4.</param>
    /// <param name="dataSize">dataSize is the number of bytes to update, and must be a multiple of 4.</param>
    /// <param name="pData">
    ///     pData is a pointer to the source data for the buffer update, and must be at least dataSize bytes in
    ///     size.
    /// </param>
    [VkVersion("1.0")]
    [SuppressUnmanagedCodeSecurity]
    [DllImport(VK_IMPORT, EntryPoint = "vkCmdUpdateBuffer")]
    public static extern unsafe void vkCmdUpdateBuffer(
        VkCommandBuffer commandBuffer,
        VkBuffer        dstBuffer,
        VkDeviceSize    dstOffset,
        VkDeviceSize    dataSize,
        void*           pData);

    /// <summary>
    ///     vkCmdFillBuffer - Fill a region of a buffer with a fixed value -
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdFillBuffer.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdFillBuffer.html</a>
    /// </summary>
    /// <param name="commandBuffer">commandBuffer is the command buffer into which the command will be recorded.</param>
    /// <param name="dstBuffer">dstBuffer is the buffer to be filled.</param>
    /// <param name="dstOffset">
    ///     dstOffset is the byte offset into the buffer at which to start filling, and must be a multiple
    ///     of 4.
    /// </param>
    /// <param name="size">
    ///     size is the number of bytes to fill, and must be either a multiple of 4, or VK_WHOLE_SIZE to fill
    ///     the range from offset to the end of the buffer. If VK_WHOLE_SIZE is used and the remaining size of the buffer is
    ///     not a multiple of 4, then the nearest smaller multiple is used.
    /// </param>
    /// <param name="data">
    ///     data is the 4-byte word written repeatedly to the buffer to fill size bytes of data. The data word
    ///     is written to memory according to the host endianness.
    /// </param>
    [VkVersion("1.0")]
    [SuppressUnmanagedCodeSecurity]
    [DllImport(VK_IMPORT, EntryPoint = "vkCmdFillBuffer")]
    public static extern void vkCmdFillBuffer(
        VkCommandBuffer commandBuffer,
        VkBuffer        dstBuffer,
        VkDeviceSize    dstOffset,
        VkDeviceSize    size,
        uint            data);

    /// <summary>
    ///     vkCmdClearColorImage - Clear regions of a color image -
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdClearColorImage.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdClearColorImage.html</a>
    /// </summary>
    /// <param name="commandBuffer">commandBuffer is the command buffer into which the command will be recorded.</param>
    /// <param name="image">image is the image to be cleared.</param>
    /// <param name="imageLayout">
    ///     imageLayout specifies the current layout of the image subresource ranges to be cleared, and
    ///     must be VK_IMAGE_LAYOUT_SHARED_PRESENT_KHR, VK_IMAGE_LAYOUT_GENERAL or VK_IMAGE_LAYOUT_TRANSFER_DST_OPTIMAL.
    /// </param>
    /// <param name="pColor">
    ///     pColor is a pointer to a VkClearColorValue structure containing the values that the image
    ///     subresource ranges will be cleared to (see
    ///     https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#clears-values below).
    /// </param>
    /// <param name="rangeCount">rangeCount is the number of image subresource range structures in pRanges.</param>
    /// <param name="pRanges">
    ///     pRanges is a pointer to an array of VkImageSubresourceRangestructures describing a range of
    ///     mipmap levels, array layers, and aspects to be cleared, as described in Image Views.
    /// </param>
    [VkVersion("1.0")]
    [SuppressUnmanagedCodeSecurity]
    [DllImport(VK_IMPORT, EntryPoint = "vkCmdClearColorImage")]
    public static extern unsafe void vkCmdClearColorImage(
        VkCommandBuffer          commandBuffer,
        VkImage                  image,
        VkImageLayout            imageLayout,
        VkClearColorValue*       pColor,
        uint                     rangeCount,
        VkImageSubresourceRange* pRanges);

    /// <summary>
    ///     vkCmdClearDepthStencilImage - Fill regions of a combined depth/stencil image -
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdClearDepthStencilImage.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdClearDepthStencilImage.html</a>
    /// </summary>
    /// <param name="commandBuffer">commandBuffer is the command buffer into which the command will be recorded.</param>
    /// <param name="image">image is the image to be cleared.</param>
    /// <param name="imageLayout">
    ///     imageLayout specifies the current layout of the image subresource ranges to be cleared, and
    ///     must be VK_IMAGE_LAYOUT_GENERAL or VK_IMAGE_LAYOUT_TRANSFER_DST_OPTIMAL.
    /// </param>
    /// <param name="pDepthStencil">
    ///     pDepthStencil is a pointer to a VkClearDepthStencilValuestructure containing the values
    ///     that the depth and stencil image subresource ranges will be cleared to (see
    ///     https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#clears-values below).
    /// </param>
    /// <param name="rangeCount">rangeCount is the number of image subresource range structures in pRanges.</param>
    /// <param name="pRanges">
    ///     pRanges is a pointer to an array of VkImageSubresourceRangestructures describing a range of
    ///     mipmap levels, array layers, and aspects to be cleared, as described in Image Views.
    /// </param>
    [VkVersion("1.0")]
    [SuppressUnmanagedCodeSecurity]
    [DllImport(VK_IMPORT, EntryPoint = "vkCmdClearDepthStencilImage")]
    public static extern unsafe void vkCmdClearDepthStencilImage(
        VkCommandBuffer           commandBuffer,
        VkImage                   image,
        VkImageLayout             imageLayout,
        VkClearDepthStencilValue* pDepthStencil,
        uint                      rangeCount,
        VkImageSubresourceRange*  pRanges);

    /// <summary>
    ///     vkCmdClearAttachments - Clear regions within bound framebuffer attachments -
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdClearAttachments.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdClearAttachments.html</a>
    /// </summary>
    /// <param name="commandBuffer">commandBuffer is the command buffer into which the command will be recorded.</param>
    /// <param name="attachmentCount">attachmentCount is the number of entries in the pAttachmentsarray.</param>
    /// <param name="pAttachments">
    ///     pAttachments is a pointer to an array of VkClearAttachmentstructures defining the
    ///     attachments to clear and the clear values to use. If any attachment index to be cleared is not backed by an image
    ///     view, then the clear has no effect.
    /// </param>
    /// <param name="rectCount">rectCount is the number of entries in the pRects array.</param>
    /// <param name="pRects">
    ///     pRects is a pointer to an array of VkClearRect structures defining regions within each selected
    ///     attachment to clear.
    /// </param>
    [VkVersion("1.0")]
    [SuppressUnmanagedCodeSecurity]
    [DllImport(VK_IMPORT, EntryPoint = "vkCmdClearAttachments")]
    public static extern unsafe void vkCmdClearAttachments(
        VkCommandBuffer    commandBuffer,
        uint               attachmentCount,
        VkClearAttachment* pAttachments,
        uint               rectCount,
        VkClearRect*       pRects);

    /// <summary>
    ///     vkCmdResolveImage - Resolve regions of an image -
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdResolveImage.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdResolveImage.html</a>
    /// </summary>
    /// <param name="commandBuffer">commandBuffer is the command buffer into which the command will be recorded.</param>
    /// <param name="srcImage">srcImage is the source image.</param>
    /// <param name="srcImageLayout">srcImageLayout is the layout of the source image subresources for the resolve.</param>
    /// <param name="dstImage">dstImage is the destination image.</param>
    /// <param name="dstImageLayout">dstImageLayout is the layout of the destination image subresources for the resolve.</param>
    /// <param name="regionCount">regionCount is the number of regions to resolve.</param>
    /// <param name="pRegions">pRegions is a pointer to an array of VkImageResolvestructures specifying the regions to resolve.</param>
    [VkVersion("1.0")]
    [SuppressUnmanagedCodeSecurity]
    [DllImport(VK_IMPORT, EntryPoint = "vkCmdResolveImage")]
    public static extern unsafe void vkCmdResolveImage(
        VkCommandBuffer commandBuffer,
        VkImage         srcImage,
        VkImageLayout   srcImageLayout,
        VkImage         dstImage,
        VkImageLayout   dstImageLayout,
        uint            regionCount,
        VkImageResolve* pRegions);

    /// <summary>
    ///     vkCmdSetEvent - Set an event object to signaled state -
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdSetEvent.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdSetEvent.html</a>
    /// </summary>
    /// <param name="commandBuffer">commandBuffer is the command buffer into which the command is recorded.</param>
    /// <param name="event">event is the event that will be signaled.</param>
    /// <param name="stageMask">stageMask specifies the source stage mask used to determine the first synchronization scope.</param>
    [VkVersion("1.0")]
    [SuppressUnmanagedCodeSecurity]
    [DllImport(VK_IMPORT, EntryPoint = "vkCmdSetEvent")]
    public static extern void vkCmdSetEvent(
        VkCommandBuffer      commandBuffer,
        VkEvent              @event,
        VkPipelineStageFlags stageMask);

    /// <summary>
    ///     vkCmdResetEvent - Reset an event object to non-signaled state -
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdResetEvent.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdResetEvent.html</a>
    /// </summary>
    /// <param name="commandBuffer">commandBuffer is the command buffer into which the command is recorded.</param>
    /// <param name="event">event is the event that will be unsignaled.</param>
    /// <param name="stageMask">
    ///     stageMask is a bitmask of VkPipelineStageFlagBits specifying the source stage mask used to
    ///     determine when the event is unsignaled.
    /// </param>
    [VkVersion("1.0")]
    [SuppressUnmanagedCodeSecurity]
    [DllImport(VK_IMPORT, EntryPoint = "vkCmdResetEvent")]
    public static extern void vkCmdResetEvent(
        VkCommandBuffer      commandBuffer,
        VkEvent              @event,
        VkPipelineStageFlags stageMask);

    /// <summary>
    ///     vkCmdWaitEvents - Wait for one or more events and insert a set of memory -
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdWaitEvents.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdWaitEvents.html</a>
    /// </summary>
    /// <param name="commandBuffer">commandBuffer is the command buffer into which the command is recorded.</param>
    /// <param name="eventCount">eventCount is the length of the pEvents array.</param>
    /// <param name="pEvents">pEvents is a pointer to an array of event object handles to wait on.</param>
    /// <param name="srcStageMask">srcStageMask is a bitmask of VkPipelineStageFlagBitsspecifying the source stage mask.</param>
    /// <param name="dstStageMask">dstStageMask is a bitmask of VkPipelineStageFlagBitsspecifying the destination stage mask.</param>
    /// <param name="memoryBarrierCount">memoryBarrierCount is the length of the pMemoryBarriersarray.</param>
    /// <param name="pMemoryBarriers">pMemoryBarriers is a pointer to an array of VkMemoryBarrierstructures.</param>
    /// <param name="bufferMemoryBarrierCount">bufferMemoryBarrierCount is the length of the pBufferMemoryBarriers array.</param>
    /// <param name="pBufferMemoryBarriers">pBufferMemoryBarriers is a pointer to an array of VkBufferMemoryBarrier structures.</param>
    /// <param name="imageMemoryBarrierCount">imageMemoryBarrierCount is the length of the pImageMemoryBarriers array.</param>
    /// <param name="pImageMemoryBarriers">pImageMemoryBarriers is a pointer to an array of VkImageMemoryBarrier structures.</param>
    [VkVersion("1.0")]
    [SuppressUnmanagedCodeSecurity]
    [DllImport(VK_IMPORT, EntryPoint = "vkCmdWaitEvents")]
    public static extern unsafe void vkCmdWaitEvents(
        VkCommandBuffer        commandBuffer,
        uint                   eventCount,
        VkEvent*               pEvents,
        VkPipelineStageFlags   srcStageMask,
        VkPipelineStageFlags   dstStageMask,
        uint                   memoryBarrierCount,
        VkMemoryBarrier*       pMemoryBarriers,
        uint                   bufferMemoryBarrierCount,
        VkBufferMemoryBarrier* pBufferMemoryBarriers,
        uint                   imageMemoryBarrierCount,
        VkImageMemoryBarrier*  pImageMemoryBarriers);

    /// <summary>
    ///     vkCmdPipelineBarrier - Insert a memory dependency -
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdPipelineBarrier.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdPipelineBarrier.html</a>
    /// </summary>
    /// <param name="commandBuffer">commandBuffer is the command buffer into which the command is recorded.</param>
    /// <param name="srcStageMask">srcStageMask is a bitmask of VkPipelineStageFlagBitsspecifying the source stages.</param>
    /// <param name="dstStageMask">dstStageMask is a bitmask of VkPipelineStageFlagBitsspecifying the destination stages.</param>
    /// <param name="dependencyFlags">
    ///     dependencyFlags is a bitmask of VkDependencyFlagBitsspecifying how execution and memory
    ///     dependencies are formed.
    /// </param>
    /// <param name="memoryBarrierCount">memoryBarrierCount is the length of the pMemoryBarriersarray.</param>
    /// <param name="pMemoryBarriers">pMemoryBarriers is a pointer to an array of VkMemoryBarrierstructures.</param>
    /// <param name="bufferMemoryBarrierCount">bufferMemoryBarrierCount is the length of the pBufferMemoryBarriers array.</param>
    /// <param name="pBufferMemoryBarriers">pBufferMemoryBarriers is a pointer to an array of VkBufferMemoryBarrier structures.</param>
    /// <param name="imageMemoryBarrierCount">imageMemoryBarrierCount is the length of the pImageMemoryBarriers array.</param>
    /// <param name="pImageMemoryBarriers">pImageMemoryBarriers is a pointer to an array of VkImageMemoryBarrier structures.</param>
    [VkVersion("1.0")]
    [SuppressUnmanagedCodeSecurity]
    [DllImport(VK_IMPORT, EntryPoint = "vkCmdPipelineBarrier")]
    public static extern unsafe void vkCmdPipelineBarrier(
        VkCommandBuffer        commandBuffer,
        VkPipelineStageFlags   srcStageMask,
        VkPipelineStageFlags   dstStageMask,
        VkDependencyFlags      dependencyFlags,
        uint                   memoryBarrierCount,
        VkMemoryBarrier*       pMemoryBarriers,
        uint                   bufferMemoryBarrierCount,
        VkBufferMemoryBarrier* pBufferMemoryBarriers,
        uint                   imageMemoryBarrierCount,
        VkImageMemoryBarrier*  pImageMemoryBarriers);

    /// <summary>
    ///     vkCmdBeginQuery - Begin a query -
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdBeginQuery.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdBeginQuery.html</a>
    /// </summary>
    /// <param name="commandBuffer">commandBuffer is the command buffer into which this command will be recorded.</param>
    /// <param name="queryPool">queryPool is the query pool that will manage the results of the query.</param>
    /// <param name="query">query is the query index within the query pool that will contain the results.</param>
    /// <param name="flags">
    ///     flags is a bitmask of VkQueryControlFlagBits specifying constraints on the types of queries that
    ///     can be performed.
    /// </param>
    [VkVersion("1.0")]
    [SuppressUnmanagedCodeSecurity]
    [DllImport(VK_IMPORT, EntryPoint = "vkCmdBeginQuery")]
    public static extern void vkCmdBeginQuery(
        VkCommandBuffer     commandBuffer,
        VkQueryPool         queryPool,
        uint                query,
        VkQueryControlFlags flags);

    /// <summary>
    ///     vkCmdEndQuery - Ends a query -
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdEndQuery.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdEndQuery.html</a>
    /// </summary>
    /// <param name="commandBuffer">commandBuffer is the command buffer into which this command will be recorded.</param>
    /// <param name="queryPool">queryPool is the query pool that is managing the results of the query.</param>
    /// <param name="query">query is the query index within the query pool where the result is stored.</param>
    [VkVersion("1.0")]
    [SuppressUnmanagedCodeSecurity]
    [DllImport(VK_IMPORT, EntryPoint = "vkCmdEndQuery")]
    public static extern void vkCmdEndQuery(
        VkCommandBuffer commandBuffer,
        VkQueryPool     queryPool,
        uint            query);

    /// <summary>
    ///     vkCmdResetQueryPool - Reset queries in a query pool -
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdResetQueryPool.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdResetQueryPool.html</a>
    /// </summary>
    /// <param name="commandBuffer">commandBuffer is the command buffer into which this command will be recorded.</param>
    /// <param name="queryPool">queryPool is the handle of the query pool managing the queries being reset.</param>
    /// <param name="firstQuery">firstQuery is the initial query index to reset.</param>
    /// <param name="queryCount">queryCount is the number of queries to reset.</param>
    [VkVersion("1.0")]
    [SuppressUnmanagedCodeSecurity]
    [DllImport(VK_IMPORT, EntryPoint = "vkCmdResetQueryPool")]
    public static extern void vkCmdResetQueryPool(
        VkCommandBuffer commandBuffer,
        VkQueryPool     queryPool,
        uint            firstQuery,
        uint            queryCount);

    /// <summary>
    ///     vkCmdWriteTimestamp - Write a device timestamp into a query object -
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdWriteTimestamp.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdWriteTimestamp.html</a>
    /// </summary>
    /// <param name="commandBuffer">commandBuffer is the command buffer into which the command will be recorded.</param>
    /// <param name="pipelineStage">pipelineStage is a VkPipelineStageFlagBits value, specifying a stage of the pipeline.</param>
    /// <param name="queryPool">queryPool is the query pool that will manage the timestamp.</param>
    /// <param name="query">query is the query within the query pool that will contain the timestamp.</param>
    [VkVersion("1.0")]
    [SuppressUnmanagedCodeSecurity]
    [DllImport(VK_IMPORT, EntryPoint = "vkCmdWriteTimestamp")]
    public static extern void vkCmdWriteTimestamp(
        VkCommandBuffer         commandBuffer,
        VkPipelineStageFlagBits pipelineStage,
        VkQueryPool             queryPool,
        uint                    query);

    /// <summary>
    ///     vkCmdCopyQueryPoolResults - Copy the results of queries in a query pool to a buffer object -
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdCopyQueryPoolResults.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdCopyQueryPoolResults.html</a>
    /// </summary>
    /// <param name="commandBuffer">commandBuffer is the command buffer into which this command will be recorded.</param>
    /// <param name="queryPool">queryPool is the query pool managing the queries containing the desired results.</param>
    /// <param name="firstQuery">firstQuery is the initial query index.</param>
    /// <param name="queryCount">
    ///     queryCount is the number of queries. firstQuery and queryCount together define a range of
    ///     queries.
    /// </param>
    /// <param name="dstBuffer">dstBuffer is a VkBuffer object that will receive the results of the copy command.</param>
    /// <param name="dstOffset">dstOffset is an offset into dstBuffer.</param>
    /// <param name="stride">
    ///     stride is the stride in bytes between results for individual queries within dstBuffer. The
    ///     required size of the backing memory for dstBuffer is determined as described above for vkGetQueryPoolResults.
    /// </param>
    /// <param name="flags">flags is a bitmask of VkQueryResultFlagBits specifying how and when results are returned.</param>
    [VkVersion("1.0")]
    [SuppressUnmanagedCodeSecurity]
    [DllImport(VK_IMPORT, EntryPoint = "vkCmdCopyQueryPoolResults")]
    public static extern void vkCmdCopyQueryPoolResults(
        VkCommandBuffer    commandBuffer,
        VkQueryPool        queryPool,
        uint               firstQuery,
        uint               queryCount,
        VkBuffer           dstBuffer,
        VkDeviceSize       dstOffset,
        VkDeviceSize       stride,
        VkQueryResultFlags flags);

    /// <summary>
    ///     vkCmdPushConstants - Update the values of push constants -
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdPushConstants.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdPushConstants.html</a>
    /// </summary>
    /// <param name="commandBuffer">commandBuffer is the command buffer in which the push constant update will be recorded.</param>
    /// <param name="layout">layout is the pipeline layout used to program the push constant updates.</param>
    /// <param name="stageFlags">
    ///     stageFlags is a bitmask of VkShaderStageFlagBits specifying the shader stages that will use
    ///     the push constants in the updated range.
    /// </param>
    /// <param name="offset">offset is the start offset of the push constant range to update, in units of bytes.</param>
    /// <param name="size">size is the size of the push constant range to update, in units of bytes.</param>
    /// <param name="pValues">pValues is a pointer to an array of size bytes containing the new push constant values.</param>
    [VkVersion("1.0")]
    [SuppressUnmanagedCodeSecurity]
    [DllImport(VK_IMPORT, EntryPoint = "vkCmdPushConstants")]
    public static extern unsafe void vkCmdPushConstants(
        VkCommandBuffer    commandBuffer,
        VkPipelineLayout   layout,
        VkShaderStageFlags stageFlags,
        uint               offset,
        uint               size,
        void*              pValues);

    /// <summary>
    ///     vkCmdBeginRenderPass - Begin a new render pass -
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdBeginRenderPass.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdBeginRenderPass.html</a>
    /// </summary>
    /// <param name="commandBuffer">commandBuffer is the command buffer in which to record the command.</param>
    /// <param name="pRenderPassBegin">
    ///     pRenderPassBegin is a pointer to a VkRenderPassBeginInfostructure specifying the render
    ///     pass to begin an instance of, and the framebuffer the instance uses.
    /// </param>
    /// <param name="contents">
    ///     contents is a VkSubpassContents value specifying how the commands in the first subpass will be
    ///     provided.
    /// </param>
    [VkVersion("1.0")]
    [SuppressUnmanagedCodeSecurity]
    [DllImport(VK_IMPORT, EntryPoint = "vkCmdBeginRenderPass")]
    public static extern unsafe void vkCmdBeginRenderPass(
        VkCommandBuffer        commandBuffer,
        VkRenderPassBeginInfo* pRenderPassBegin,
        VkSubpassContents      contents);

    /// <summary>
    ///     vkCmdNextSubpass - Transition to the next subpass of a render pass -
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdNextSubpass.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdNextSubpass.html</a>
    /// </summary>
    /// <param name="commandBuffer">commandBuffer is the command buffer in which to record the command.</param>
    /// <param name="contents">
    ///     contents specifies how the commands in the next subpass will be provided, in the same fashion as
    ///     the corresponding parameter of vkCmdBeginRenderPass.
    /// </param>
    [VkVersion("1.0")]
    [SuppressUnmanagedCodeSecurity]
    [DllImport(VK_IMPORT, EntryPoint = "vkCmdNextSubpass")]
    public static extern void vkCmdNextSubpass(
        VkCommandBuffer   commandBuffer,
        VkSubpassContents contents);

    /// <summary>
    ///     vkCmdEndRenderPass - End the current render pass -
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdEndRenderPass.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdEndRenderPass.html</a>
    /// </summary>
    /// <param name="commandBuffer">commandBuffer is the command buffer in which to end the current render pass instance.</param>
    [VkVersion("1.0")]
    [SuppressUnmanagedCodeSecurity]
    [DllImport(VK_IMPORT, EntryPoint = "vkCmdEndRenderPass")]
    public static extern void vkCmdEndRenderPass(VkCommandBuffer commandBuffer);

    /// <summary>
    ///     vkCmdExecuteCommands - Execute a secondary command buffer from a primary command buffer -
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdExecuteCommands.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdExecuteCommands.html</a>
    /// </summary>
    /// <param name="commandBuffer">
    ///     commandBuffer is a handle to a primary command buffer that the secondary command buffers
    ///     are executed in.
    /// </param>
    /// <param name="commandBufferCount">commandBufferCount is the length of the pCommandBuffersarray.</param>
    /// <param name="pCommandBuffers">
    ///     pCommandBuffers is a pointer to an array of commandBufferCount secondary command buffer
    ///     handles, which are recorded to execute in the primary command buffer in the order they are listed in the array.
    /// </param>
    [VkVersion("1.0")]
    [SuppressUnmanagedCodeSecurity]
    [DllImport(VK_IMPORT, EntryPoint = "vkCmdExecuteCommands")]
    public static extern unsafe void vkCmdExecuteCommands(
        VkCommandBuffer  commandBuffer,
        uint             commandBufferCount,
        VkCommandBuffer* pCommandBuffers);
}