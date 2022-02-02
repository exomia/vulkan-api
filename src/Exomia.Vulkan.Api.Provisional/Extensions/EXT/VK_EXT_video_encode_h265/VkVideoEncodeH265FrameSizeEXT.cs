// ReSharper disable UnusedMember.Global
// ReSharper disable InconsistentNaming
// ReSharper disable once CheckNamespace
namespace Exomia.Vulkan.Api.Provisional;

/// <summary> VkVideoEncodeH265FrameSizeEXT - Structure describing frame size values per H.265 picture type - <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkVideoEncodeH265FrameSizeEXT.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkVideoEncodeH265FrameSizeEXT.html</a></summary>
[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkVideoEncodeH265FrameSizeEXT {
    /// <summary>frameISize is the size in bytes to be used for I-frames.</summary>
    public uint frameISize;
    /// <summary>framePSize is the size in bytes to be used for P-frames.</summary>
    public uint framePSize;
    /// <summary>frameBSize is the size in bytes to be used for B-frames.</summary>
    public uint frameBSize;
}
