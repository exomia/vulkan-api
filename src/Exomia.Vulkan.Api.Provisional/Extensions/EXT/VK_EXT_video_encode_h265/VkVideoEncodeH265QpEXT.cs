// ReSharper disable UnusedMember.Global
// ReSharper disable InconsistentNaming
// ReSharper disable once CheckNamespace
namespace Exomia.Vulkan.Api.Provisional;

/// <summary> VkVideoEncodeH265QpEXT - Structure describing H.265 QP values per picture type - <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkVideoEncodeH265QpEXT.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkVideoEncodeH265QpEXT.html</a></summary>
[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkVideoEncodeH265QpEXT {
    /// <summary>qpI is the QP to be used for I-frames.</summary>
    public int qpI;
    /// <summary>qpP is the QP to be used for P-frames.</summary>
    public int qpP;
    /// <summary>qpB is the QP to be used for B-frames.</summary>
    public int qpB;
}
