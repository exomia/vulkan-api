// ReSharper disable UnusedMember.Global
// ReSharper disable InconsistentNaming
// ReSharper disable once CheckNamespace
namespace Exomia.Vulkan.Api.Provisional;

/// <summary> VkVideoEncodeH265CapabilitiesEXT - Structure specifying H.265 encode capabilities - <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkVideoEncodeH265CapabilitiesEXT.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkVideoEncodeH265CapabilitiesEXT.html</a></summary>
    /// <remarks><list type="table">
    ///     <item><term>structextends</term><description>VkVideoCapabilitiesKHR</description></item>
    /// </list></remarks>
[VkStructExtends("VkVideoCapabilitiesKHR")]
[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkVideoEncodeH265CapabilitiesEXT {
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_VIDEO_ENCODE_H265_CAPABILITIES_EXT;

    /// <summary>sType is the type of this structure.</summary>
    public VkStructureType sType;
    /// <summary>pNext is NULL or a pointer to a structure extending this structure.</summary>
    public void* pNext;
    /// <summary>flags is reserved for future use.</summary>
    public VkVideoEncodeH265CapabilityFlagsEXT flags;
    /// <summary>inputModeFlags is a bitmask of VkVideoEncodeH265InputModeFlagBitsEXT describing the command buffer input granularities/modes supported by the implementation.</summary>
    public VkVideoEncodeH265InputModeFlagsEXT inputModeFlags;
    /// <summary>outputModeFlags is a bitmask of VkVideoEncodeH265OutputModeFlagBitsEXT describing the output (bitstream size reporting) granularities/modes supported by the implementation.</summary>
    public VkVideoEncodeH265OutputModeFlagsEXT outputModeFlags;
    /// <summary>ctbSizes is a bitmask of VkVideoEncodeH265CtbSizeFlagBitsEXTdescribing the supported CTB sizes.</summary>
    public VkVideoEncodeH265CtbSizeFlagsEXT ctbSizes;
    /// <summary>inputImageDataAlignment reports the alignment, in pixels, for the width and height of the picture data within the images used in video encoding.</summary>
    public VkExtent2D inputImageDataAlignment;
    /// <summary>maxNumL0ReferenceForP reports the maximum number of reference pictures the implementation supports in the reference list L0 for P pictures.</summary>
    public byte maxNumL0ReferenceForP;
    /// <summary>maxNumL0ReferenceForB reports the maximum number of reference pictures the implementation supports in the reference list L0 for B pictures. The reported value is 0 if encoding of B pictures is not supported.</summary>
    public byte maxNumL0ReferenceForB;
    /// <summary>maxNumL1Reference reports the maximum number of reference pictures the implementation supports in the reference list L1 if encoding of B pictures is supported. The reported value is 0 if encoding of B pictures is not supported.</summary>
    public byte maxNumL1Reference;
    /// <summary>maxNumSubLayers reports the maximum number of sublayers.</summary>
    public byte maxNumSubLayers;
    /// <summary>qualityLevelCount is the number of quality levels supported.</summary>
    public byte qualityLevelCount;
    /// <summary>stdExtensionVersion is a VkExtensionProperties structure in which the H.265 extension name and version supported by the implementation are returned.</summary>
    public VkExtensionProperties stdExtensionVersion;
}
