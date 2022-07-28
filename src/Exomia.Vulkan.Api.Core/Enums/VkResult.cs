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
///     VkResult - Vulkan command return codes -
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkResult.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkResult.html</a>
/// </summary>
public enum VkResult
{
    /// <summary>VK_SUCCESS Command successfully completed</summary>
    VK_SUCCESS = 0,

    /// <summary>VK_NOT_READY A fence or query has not yet completed</summary>
    VK_NOT_READY = 1,

    /// <summary>VK_TIMEOUT A wait operation has not completed in the specified time</summary>
    VK_TIMEOUT = 2,

    /// <summary>VK_EVENT_SET An event is signaled</summary>
    VK_EVENT_SET = 3,

    /// <summary>VK_EVENT_RESET An event is unsignaled</summary>
    VK_EVENT_RESET = 4,

    /// <summary>VK_INCOMPLETE A return array was too small for the result</summary>
    VK_INCOMPLETE = 5,

    /// <summary>VK_ERROR_OUT_OF_HOST_MEMORY A host memory allocation has failed.</summary>
    VK_ERROR_OUT_OF_HOST_MEMORY = -1,

    /// <summary>VK_ERROR_OUT_OF_DEVICE_MEMORY A device memory allocation has failed.</summary>
    VK_ERROR_OUT_OF_DEVICE_MEMORY = -2,

    /// <summary>
    ///     VK_ERROR_INITIALIZATION_FAILED Initialization of an object could not be completed for implementation-specific
    ///     reasons.
    /// </summary>
    VK_ERROR_INITIALIZATION_FAILED = -3,

    /// <summary>
    ///     VK_ERROR_DEVICE_LOST The logical or physical device has been lost. See
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#devsandqueues-lost-device">
    ///         Lost
    ///         Device
    ///     </a>
    /// </summary>
    VK_ERROR_DEVICE_LOST = -4,

    /// <summary>VK_ERROR_MEMORY_MAP_FAILED Mapping of a memory object has failed.</summary>
    VK_ERROR_MEMORY_MAP_FAILED = -5,

    /// <summary>VK_ERROR_LAYER_NOT_PRESENT A requested layer is not present or could not be loaded.</summary>
    VK_ERROR_LAYER_NOT_PRESENT = -6,

    /// <summary>VK_ERROR_EXTENSION_NOT_PRESENT A requested extension is not supported.</summary>
    VK_ERROR_EXTENSION_NOT_PRESENT = -7,

    /// <summary>VK_ERROR_FEATURE_NOT_PRESENT A requested feature is not supported.</summary>
    VK_ERROR_FEATURE_NOT_PRESENT = -8,

    /// <summary>
    ///     VK_ERROR_INCOMPATIBLE_DRIVER The requested version of Vulkan is not supported by the driver or is otherwise
    ///     incompatible for implementation-specific reasons.
    /// </summary>
    VK_ERROR_INCOMPATIBLE_DRIVER = -9,

    /// <summary>VK_ERROR_TOO_MANY_OBJECTS Too many objects of the type have already been created.</summary>
    VK_ERROR_TOO_MANY_OBJECTS = -10,

    /// <summary>VK_ERROR_FORMAT_NOT_SUPPORTED A requested format is not supported on this device.</summary>
    VK_ERROR_FORMAT_NOT_SUPPORTED = -11,

    /// <summary>
    ///     VK_ERROR_FRAGMENTED_POOL A pool allocation has failed due to fragmentation of the pool&#8217;s memory. This
    ///     must only be returned if no attempt to allocate host or device memory was made to accommodate the new allocation.
    ///     This should be returned in preference to VK_ERROR_OUT_OF_POOL_MEMORY, but only if the implementation is certain
    ///     that the pool allocation failure was due to fragmentation.
    /// </summary>
    VK_ERROR_FRAGMENTED_POOL = -12,

    /// <summary>
    ///     VK_ERROR_UNKNOWN An unknown error has occurred; either the application has provided invalid input, or an
    ///     implementation failure has occurred.
    /// </summary>
    VK_ERROR_UNKNOWN = -13,

    /// <summary>
    ///     VK_ERROR_OUT_OF_POOL_MEMORY A pool memory allocation has failed. This must only be returned if no attempt to
    ///     allocate host or device memory was made to accommodate the new allocation. If the failure was definitely due to
    ///     fragmentation of the pool, VK_ERROR_FRAGMENTED_POOL should be returned instead.
    /// </summary>
    VK_ERROR_OUT_OF_POOL_MEMORY = -1000069000,

    /// <summary>VK_ERROR_INVALID_EXTERNAL_HANDLE An external handle is not a valid handle of the specified type.</summary>
    VK_ERROR_INVALID_EXTERNAL_HANDLE = -1000072003,

    /// <summary>VK_ERROR_FRAGMENTATION A descriptor pool creation has failed due to fragmentation.</summary>
    VK_ERROR_FRAGMENTATION = -1000161000,

    /// <summary>
    ///     VK_ERROR_INVALID_OPAQUE_CAPTURE_ADDRESS A buffer creation or memory allocation failed because the requested
    ///     address is not available. A shader group handle assignment failed because the requested shader group handle
    ///     information is no longer valid.
    /// </summary>
    VK_ERROR_INVALID_OPAQUE_CAPTURE_ADDRESS = -1000257000,

    /// <summary>
    ///     VK_PIPELINE_COMPILE_REQUIRED A requested pipeline creation would have required compilation, but the
    ///     application requested compilation to not be performed.
    /// </summary>
    VK_PIPELINE_COMPILE_REQUIRED = 1000297000,

    /// <summary>VK_ERROR_SURFACE_LOST_KHR A surface is no longer available.</summary>
    VK_ERROR_SURFACE_LOST_KHR = -1000000000,

    /// <summary>
    ///     VK_ERROR_NATIVE_WINDOW_IN_USE_KHR The requested window is already in use by Vulkan or another API in a manner
    ///     which prevents it from being used again.
    /// </summary>
    VK_ERROR_NATIVE_WINDOW_IN_USE_KHR = -1000000001,

    /// <summary>
    ///     VK_SUBOPTIMAL_KHR A swapchain no longer matches the surface properties exactly, but can still be used to
    ///     present to the surface successfully.
    /// </summary>
    VK_SUBOPTIMAL_KHR = 1000001003,

    /// <summary>
    ///     VK_ERROR_OUT_OF_DATE_KHR A surface has changed in such a way that it is no longer compatible with the
    ///     swapchain, and further presentation requests using the swapchain will fail. Applications must query the new surface
    ///     properties and recreate their swapchain if they wish to continue presenting to the surface.
    /// </summary>
    VK_ERROR_OUT_OF_DATE_KHR = -1000001004,

    /// <summary>
    ///     VK_ERROR_INCOMPATIBLE_DISPLAY_KHR The display used by a swapchain does not use the same presentable image
    ///     layout, or is incompatible in a way that prevents sharing an image.
    /// </summary>
    VK_ERROR_INCOMPATIBLE_DISPLAY_KHR = -1000003001,

    /// <summary>
    ///     VK_ERROR_VALIDATION_FAILED_EXT<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkResult">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkResult</a>
    /// </summary>
    VK_ERROR_VALIDATION_FAILED_EXT = -1000011001,

    /// <summary>
    ///     VK_ERROR_INVALID_SHADER_NV One or more shaders failed to compile or link. More details are reported back to
    ///     the application via VK_EXT_debug_report if enabled.
    /// </summary>
    VK_ERROR_INVALID_SHADER_NV = -1000012000,

    /// <summary>
    ///     VK_ERROR_IMAGE_USAGE_NOT_SUPPORTED_KHR The requested
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkImageUsageFlags.html">VkImageUsageFlags</a>
    ///     are not supported.
    /// </summary>
    VK_ERROR_IMAGE_USAGE_NOT_SUPPORTED_KHR = -1000023000,

    /// <summary>VK_ERROR_VIDEO_PICTURE_LAYOUT_NOT_SUPPORTED_KHR The requested video picture layout is not supported.</summary>
    VK_ERROR_VIDEO_PICTURE_LAYOUT_NOT_SUPPORTED_KHR = -1000023001,

    /// <summary>
    ///     VK_ERROR_VIDEO_PROFILE_OPERATION_NOT_SUPPORTED_KHR A video profile operation specified via
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkVideoProfileKHR.html">VkVideoProfileKHR</a>
    ///     ::videoCodecOperation is not supported.
    /// </summary>
    VK_ERROR_VIDEO_PROFILE_OPERATION_NOT_SUPPORTED_KHR = -1000023002,

    /// <summary>
    ///     VK_ERROR_VIDEO_PROFILE_FORMAT_NOT_SUPPORTED_KHR Format parameters in a requested
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkVideoProfileKHR.html">VkVideoProfileKHR</a>
    ///     chain are not supported.
    /// </summary>
    VK_ERROR_VIDEO_PROFILE_FORMAT_NOT_SUPPORTED_KHR = -1000023003,

    /// <summary>
    ///     VK_ERROR_VIDEO_PROFILE_CODEC_NOT_SUPPORTED_KHR Codec-specific parameters in a requested
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkVideoProfileKHR.html">VkVideoProfileKHR</a>
    ///     chain are not supported.
    /// </summary>
    VK_ERROR_VIDEO_PROFILE_CODEC_NOT_SUPPORTED_KHR = -1000023004,

    /// <summary>VK_ERROR_VIDEO_STD_VERSION_NOT_SUPPORTED_KHR The specified video Std header version is not supported.</summary>
    VK_ERROR_VIDEO_STD_VERSION_NOT_SUPPORTED_KHR = -1000023005,

    /// <summary>
    ///     VK_ERROR_INVALID_DRM_FORMAT_MODIFIER_PLANE_LAYOUT_EXT<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkResult">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkResult</a>
    /// </summary>
    VK_ERROR_INVALID_DRM_FORMAT_MODIFIER_PLANE_LAYOUT_EXT = -1000158000,

    /// <summary>
    ///     VK_ERROR_NOT_PERMITTED_KHR<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkResult">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkResult</a>
    /// </summary>
    VK_ERROR_NOT_PERMITTED_KHR = -1000174001,

    /// <summary>
    ///     VK_ERROR_FULL_SCREEN_EXCLUSIVE_MODE_LOST_EXT An operation on a swapchain created with
    ///     VK_FULL_SCREEN_EXCLUSIVE_APPLICATION_CONTROLLED_EXT failed as it did not have exclusive full-screen access. This
    ///     may occur due to implementation-dependent reasons, outside of the application&#8217;s control.
    /// </summary>
    VK_ERROR_FULL_SCREEN_EXCLUSIVE_MODE_LOST_EXT = -1000255000,

    /// <summary>
    ///     VK_THREAD_IDLE_KHR A deferred operation is not complete but there is currently no work for this thread to do
    ///     at the time of this call.
    /// </summary>
    VK_THREAD_IDLE_KHR = 1000268000,

    /// <summary>
    ///     VK_THREAD_DONE_KHR A deferred operation is not complete but there is no work remaining to assign to additional
    ///     threads.
    /// </summary>
    VK_THREAD_DONE_KHR = 1000268001,

    /// <summary>VK_OPERATION_DEFERRED_KHR A deferred operation was requested and at least some of the work was deferred.</summary>
    VK_OPERATION_DEFERRED_KHR = 1000268002,

    /// <summary>VK_OPERATION_NOT_DEFERRED_KHR A deferred operation was requested and no operations were deferred.</summary>
    VK_OPERATION_NOT_DEFERRED_KHR = 1000268003,

    /// <summary>
    ///     VK_ERROR_COMPRESSION_EXHAUSTED_EXT An image creation failed because internal resources required for
    ///     compression are exhausted. This must only be returned when fixed-rate compression is requested.
    /// </summary>
    VK_ERROR_COMPRESSION_EXHAUSTED_EXT = -1000338000,

    /// <summary>
    ///     VK_ERROR_OUT_OF_POOL_MEMORY A pool memory allocation has failed. This must only be returned if no attempt to
    ///     allocate host or device memory was made to accommodate the new allocation. If the failure was definitely due to
    ///     fragmentation of the pool, VK_ERROR_FRAGMENTED_POOL should be returned instead.
    /// </summary>
    VK_ERROR_OUT_OF_POOL_MEMORY_KHR = VK_ERROR_OUT_OF_POOL_MEMORY,

    /// <summary>VK_ERROR_INVALID_EXTERNAL_HANDLE An external handle is not a valid handle of the specified type.</summary>
    VK_ERROR_INVALID_EXTERNAL_HANDLE_KHR = VK_ERROR_INVALID_EXTERNAL_HANDLE,

    /// <summary>VK_ERROR_FRAGMENTATION A descriptor pool creation has failed due to fragmentation.</summary>
    VK_ERROR_FRAGMENTATION_EXT = VK_ERROR_FRAGMENTATION,

    /// <summary>
    ///     VK_ERROR_NOT_PERMITTED_EXT<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkResult">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkResult</a>
    /// </summary>
    VK_ERROR_NOT_PERMITTED_EXT = VK_ERROR_NOT_PERMITTED_KHR,

    /// <summary>
    ///     VK_ERROR_INVALID_OPAQUE_CAPTURE_ADDRESS A buffer creation or memory allocation failed because the requested
    ///     address is not available. A shader group handle assignment failed because the requested shader group handle
    ///     information is no longer valid.
    /// </summary>
    VK_ERROR_INVALID_DEVICE_ADDRESS_EXT = VK_ERROR_INVALID_OPAQUE_CAPTURE_ADDRESS,

    /// <summary>
    ///     VK_ERROR_INVALID_OPAQUE_CAPTURE_ADDRESS A buffer creation or memory allocation failed because the requested
    ///     address is not available. A shader group handle assignment failed because the requested shader group handle
    ///     information is no longer valid.
    /// </summary>
    VK_ERROR_INVALID_OPAQUE_CAPTURE_ADDRESS_KHR = VK_ERROR_INVALID_OPAQUE_CAPTURE_ADDRESS,

    /// <summary>
    ///     VK_PIPELINE_COMPILE_REQUIRED A requested pipeline creation would have required compilation, but the
    ///     application requested compilation to not be performed.
    /// </summary>
    VK_PIPELINE_COMPILE_REQUIRED_EXT = VK_PIPELINE_COMPILE_REQUIRED,

    /// <summary>
    ///     VK_PIPELINE_COMPILE_REQUIRED A requested pipeline creation would have required compilation, but the
    ///     application requested compilation to not be performed.
    /// </summary>
    VK_ERROR_PIPELINE_COMPILE_REQUIRED_EXT = VK_PIPELINE_COMPILE_REQUIRED
}