// ReSharper disable UnusedMember.Global
// ReSharper disable InconsistentNaming
// ReSharper disable once CheckNamespace
namespace Exomia.Vulkan.Api.Fuchsia;

/// <summary> VkSysmemColorSpaceFUCHSIA - Structure describing the buffer collections color space - <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkSysmemColorSpaceFUCHSIA.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkSysmemColorSpaceFUCHSIA.html</a></summary>
[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkSysmemColorSpaceFUCHSIA {
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_SYSMEM_COLOR_SPACE_FUCHSIA;

    /// <summary>sType is the type of this structure</summary>
    public VkStructureType sType;
    /// <summary>pNext is NULL or a pointer to a structure extending this structure</summary>
    public void* pNext;
    /// <summary>colorSpace value of the Sysmem ColorSpaceType</summary>
    public uint colorSpace;
}
