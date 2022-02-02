// ReSharper disable UnusedMember.Global
// ReSharper disable InconsistentNaming
// ReSharper disable once CheckNamespace
namespace Exomia.Vulkan.Api.Provisional;

/// <summary> VkVideoEncodeH264CapabilitiesEXT - Structure specifying H.264 encode capabilities - <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkVideoEncodeH264CapabilitiesEXT.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkVideoEncodeH264CapabilitiesEXT.html</a></summary>
    /// <remarks><list type="table">
    ///     <item><term>structextends</term><description>VkVideoCapabilitiesKHR</description></item>
    /// </list></remarks>
[VkStructExtends("VkVideoCapabilitiesKHR")]
[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkVideoEncodeH264CapabilitiesEXT {
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_VIDEO_ENCODE_H264_CAPABILITIES_EXT;

    /// <summary>sType is the type of this structure.</summary>
    public VkStructureType sType;
    /// <summary>pNext is NULL or a pointer to a structure extending this structure.</summary>
    public void* pNext;
    /// <summary>flags is a bitmask of VkVideoEncodeH264CapabilityFlagBitsEXTdescribing supported encoding tools.</summary>
    public VkVideoEncodeH264CapabilityFlagsEXT flags;
    /// <summary>inputModeFlags is a bitmask of VkVideoEncodeH264InputModeFlagBitsEXT describing supported command buffer input granularities/modes.</summary>
    public VkVideoEncodeH264InputModeFlagsEXT inputModeFlags;
    /// <summary>outputModeFlags is a bitmask of VkVideoEncodeH264OutputModeFlagBitsEXT describing supported output (bitstream size reporting) granularities/modes.</summary>
    public VkVideoEncodeH264OutputModeFlagsEXT outputModeFlags;
    /// <summary>minPictureSizeInMbs reports the minimum encoded picture width and height in Macroblocks.</summary>
    public VkExtent2D minPictureSizeInMbs;
    /// <summary>maxPictureSizeInMbs reports the maximum encoded picture width and height in Macroblocks.</summary>
    public VkExtent2D maxPictureSizeInMbs;
    /// <summary>inputImageDataAlignment reports alignment of data that must be filled in the input image horizontally and vertically in pixels. Max is 16: Data must be filled up to Macroblock boundary (no extrapolation/filling is supported by implementation). Min is 1: The implementation will take care of all needed extrapolation/filling up to the next Macroblock boundary.</summary>
    public VkExtent2D inputImageDataAlignment;
    /// <summary>maxNumL0ReferenceForP reports the maximum number of reference pictures the encoder supports as list0 references for P pictures.</summary>
    public byte maxNumL0ReferenceForP;
    /// <summary>maxNumL0ReferenceForB reports the maximum number of reference pictures the encoder supports as list0 references for B pictures. Reports 0 if B pictures are not supported.</summary>
    public byte maxNumL0ReferenceForB;
    /// <summary>maxNumL1Reference reports the maximum number of reference pictures the encoder supports as list1 references if B pictures are supported. Reports 0 if B pictures are not supported.</summary>
    public byte maxNumL1Reference;
    /// <summary>qualityLevelCount is the number of discrete quality levels supported.</summary>
    public byte qualityLevelCount;
    /// <summary>stdExtensionVersion is the specific H.264 extension name and version supported by this implementation.</summary>
    public VkExtensionProperties stdExtensionVersion;
}
