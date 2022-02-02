// ReSharper disable UnusedMember.Global
// ReSharper disable InconsistentNaming
// ReSharper disable once CheckNamespace
namespace Exomia.Vulkan.Api.Provisional;

/// <summary> VkQueryResultStatusKHR - Specific status codes for operations - <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkQueryResultStatusKHR.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkQueryResultStatusKHR.html</a> </summary>
public enum VkQueryResultStatusKHR : int {
    /// <summary>VK_QUERY_RESULT_STATUS_ERROR_KHR specifies that operations did not complete successfully.</summary>
    VK_QUERY_RESULT_STATUS_ERROR_KHR = -1,
    /// <summary>VK_QUERY_RESULT_STATUS_NOT_READY_KHR specifies that the query result is not yet available.</summary>
    VK_QUERY_RESULT_STATUS_NOT_READY_KHR = 0,
    /// <summary>VK_QUERY_RESULT_STATUS_COMPLETE_KHR specifies that operations completed successfully and the query result is available.</summary>
    VK_QUERY_RESULT_STATUS_COMPLETE_KHR = 1
}
