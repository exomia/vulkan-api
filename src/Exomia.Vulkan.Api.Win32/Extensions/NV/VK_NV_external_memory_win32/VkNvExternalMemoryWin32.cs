global using static Exomia.Vulkan.Api.Win32.VkNvExternalMemoryWin32;

#pragma warning disable CA2211 // Non-constant fields should not be visible
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

// ReSharper disable UnusedMember.Global
// ReSharper disable InconsistentNaming
// ReSharper disable once CheckNamespace
namespace Exomia.Vulkan.Api.Win32;

/// <summary>
///    VK_NV_external_memory_win32 - device extension (nr. 58) - author 'NV' [platform 'win32' | contact 'James Jones @cubanismo']<br/>
///    <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_NV_external_memory_win32.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_NV_external_memory_win32.html</a>
/// </summary>
[VkRequires("VK_NV_external_memory")]
[Obsolete("deprecated by VK_KHR_external_memory_win32", false, UrlFormat = "https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_NV_external_memory_win32.html#_deprecation_state")]
public static unsafe partial class VkNvExternalMemoryWin32
{
    /// <summary> The spec version. </summary>
    public const uint VK_NV_EXTERNAL_MEMORY_WIN32_SPEC_VERSION = 1;
    /// <summary> The extension name. </summary>
    public const string VK_NV_EXTERNAL_MEMORY_WIN32_EXTENSION_NAME = "VK_NV_external_memory_win32";
    /// <summary> An UTF8 null terminated version of <see cref="VK_NV_EXTERNAL_MEMORY_WIN32_EXTENSION_NAME" /> represented by an UTF16 string. </summary>
    /// <remarks>
    ///     Example usage:<br/>
    ///     <br/>
    ///     fixed(char* ptr = VK_NV_EXTERNAL_MEMORY_WIN32_EXTENSION_NAME_UTF8_NT) {<br/>
    ///         sbyte* utf8NtPtr = (sbyte*)ptr; // utf8NtPtr - can now be passed and used directly as a utf8_nt string for unmanaged code.<br />
    ///     }
    /// </remarks>
    public const string VK_NV_EXTERNAL_MEMORY_WIN32_EXTENSION_NAME_UTF8_NT = "\u4b56\u4e5f\u5f56\u5845\u4554\u4e52\u4c41\u4d5f\u4d45\u524f\u5f59\u4957\u334e\u5f32\u5845\u4554\u534e\u4f49\u5f4e\u414e\u454d\u0000";

    /// <summary> vkGetMemoryWin32HandleNV - Retrieve Win32 handle to a device memory object - <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkGetMemoryWin32HandleNV.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkGetMemoryWin32HandleNV.html</a> </summary>
    /// <param name="device">device is the logical device that owns the memory.</param>
    /// <param name="memory">memory is the VkDeviceMemory object.</param>
    /// <param name="handleType">handleType is a bitmask of VkExternalMemoryHandleTypeFlagBitsNV containing a single bit specifying the type of handle requested.</param>
    /// <param name="pHandle"><a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkGetMemoryWin32HandleNV.html">requestLink</a></param>
    /// <remarks><list type="table">
    ///     <item><term>successcodes</term><description>VK_SUCCESS</description></item>
    ///     <item><term>errorcodes</term><description>VK_ERROR_TOO_MANY_OBJECTS,VK_ERROR_OUT_OF_HOST_MEMORY</description></item>
    /// </list></remarks>
    public static readonly delegate*<
        VkDevice /*device*/, 
        VkDeviceMemory /*memory*/, 
        VkExternalMemoryHandleTypeFlagsNV /*handleType*/, 
        HANDLE* /*pHandle*/, 
        VkResult> vkGetMemoryWin32HandleNV = null;

    /// <summary> Loads all function pointer for this extension. </summary>
    /// <param name="device"> The device that the function pointers will be compatible with. </param>
    /// <remarks> The load method must always be executed first before a command of this extension can be used. </remarks>
    public static void Load(VkDevice device) {
        fixed(delegate*<VkDevice, VkDeviceMemory, VkExternalMemoryHandleTypeFlagsNV, HANDLE*, VkResult>* pvkGetMemoryWin32HandleNV = &vkGetMemoryWin32HandleNV) 
        {
            *pvkGetMemoryWin32HandleNV = (delegate*<VkDevice, VkDeviceMemory, VkExternalMemoryHandleTypeFlagsNV, HANDLE*, VkResult>)Exomia.Vulkan.Api.Core.Vk.GetVkFunction(device, "\u6b76\u6547\u4d74\u6d65\u726f\u5779\u6e69\u3233\u6148\u646e\u656c\u564e\u0000");
        }
    }
}
