global using static Exomia.Vulkan.Api.Provisional.VkExtVideoDecodeH265;

#pragma warning disable CA2211 // Non-constant fields should not be visible
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

// ReSharper disable UnusedMember.Global
// ReSharper disable InconsistentNaming
// ReSharper disable once CheckNamespace
namespace Exomia.Vulkan.Api.Provisional;

/// <summary>
///    VK_EXT_video_decode_h265 - device extension (nr. 188) - author 'KHR' [platform 'provisional' | contact 'peter.fang@amd.com']<br/>
///    <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_EXT_video_decode_h265.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_EXT_video_decode_h265.html</a>
/// </summary>
/// <remarks>
///    provisional: true
/// </remarks>
[VkRequires("VK_KHR_video_decode_queue")]
[VkProvisional("true")]
public static unsafe partial class VkExtVideoDecodeH265
{
    /// <summary> The spec version. </summary>
    public const uint VK_EXT_VIDEO_DECODE_H265_SPEC_VERSION = 1;
    /// <summary> The extension name. </summary>
    public const string VK_EXT_VIDEO_DECODE_H265_EXTENSION_NAME = "VK_EXT_video_decode_h265";
    /// <summary> An UTF8 null terminated version of <see cref="VK_EXT_VIDEO_DECODE_H265_EXTENSION_NAME" /> represented by an UTF16 string. </summary>
    /// <remarks>
    ///     Example usage:<br/>
    ///     <br/>
    ///     fixed(char* ptr = VK_EXT_VIDEO_DECODE_H265_EXTENSION_NAME_UTF8_NT) {<br/>
    ///         sbyte* utf8NtPtr = (sbyte*)ptr; // utf8NtPtr - can now be passed and used directly as a utf8_nt string for unmanaged code.<br />
    ///     }
    /// </remarks>
    public const string VK_EXT_VIDEO_DECODE_H265_EXTENSION_NAME_UTF8_NT = "\u4b56\u455f\u5458\u565f\u4449\u4f45\u445f\u4345\u444f\u5f45\u3248\u3536\u455f\u5458\u4e45\u4953\u4e4f\u4e5f\u4d41\u0045";
}
