﻿// ReSharper disable UnusedMember.Global
// ReSharper disable InconsistentNaming
// ReSharper disable once CheckNamespace
namespace Exomia.Vulkan.Api.Provisional;

/// <summary> VkVideoDecodeH264PictureInfoEXT - Structure specifies H.264 decode picture parameters when decoding a picture - <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkVideoDecodeH264PictureInfoEXT.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkVideoDecodeH264PictureInfoEXT.html</a></summary>
    /// <remarks><list type="table">
    ///     <item><term>structextends</term><description>VkVideoDecodeInfoKHR</description></item>
    /// </list></remarks>
[VkStructExtends("VkVideoDecodeInfoKHR")]
[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkVideoDecodeH264PictureInfoEXT {
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_VIDEO_DECODE_H264_PICTURE_INFO_EXT;

    /// <summary>sType is the type of this structure.</summary>
    public VkStructureType sType;
    /// <summary>pNext is NULL or a pointer to a structure extending this structure.</summary>
    public void* pNext;
    /// <summary>pStdPictureInfo is a pointer to a StdVideoDecodeH264PictureInfo structure specifying the codec standard specific picture information from the H.264 specification.</summary>
    public StdVideoDecodeH264PictureInfo* pStdPictureInfo;
    /// <summary>slicesCount is the number of slices in this picture.</summary>
    public uint slicesCount;
    /// <summary>pSlicesDataOffsets is a pointer to an array of slicesCountoffsets indicating the start offset of each slice within the bitstream buffer.</summary>
    public uint* pSlicesDataOffsets;
}
