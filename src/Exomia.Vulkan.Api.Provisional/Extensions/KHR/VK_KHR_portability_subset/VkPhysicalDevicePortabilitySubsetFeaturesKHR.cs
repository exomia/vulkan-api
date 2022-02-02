// ReSharper disable UnusedMember.Global
// ReSharper disable InconsistentNaming
// ReSharper disable once CheckNamespace
namespace Exomia.Vulkan.Api.Provisional;

/// <summary> VkPhysicalDevicePortabilitySubsetFeaturesKHR - Structure describing the features that may not be supported by an implementation of the Vulkan 1.0 Portability Subset - <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkPhysicalDevicePortabilitySubsetFeaturesKHR.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkPhysicalDevicePortabilitySubsetFeaturesKHR.html</a></summary>
    /// <remarks><list type="table">
    ///     <item><term>structextends</term><description>VkPhysicalDeviceFeatures2,VkDeviceCreateInfo</description></item>
    /// </list></remarks>
[VkStructExtends("VkPhysicalDeviceFeatures2,VkDeviceCreateInfo")]
[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPhysicalDevicePortabilitySubsetFeaturesKHR {
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_PORTABILITY_SUBSET_FEATURES_KHR;

    /// <summary>sType is the type of this structure.</summary>
    public VkStructureType sType;
    /// <summary>pNext is NULL or a pointer to a structure extending this structure.</summary>
    public void* pNext;
    /// <summary>constantAlphaColorBlendFactors indicates whether this implementation supports constant alpha https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#framebuffer-blendfactorsused as source or destination color https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#framebuffer-blending.</summary>
    public VkBool32 constantAlphaColorBlendFactors;
    /// <summary> events indicates whether this implementation supports synchronization using https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#synchronization-events.</summary>
    public VkBool32 events;
    /// <summary>imageViewFormatReinterpretation indicates whether this implementation supports a VkImageView being created with a texel format containing a different number of components, or a different number of bits in each component, than the texel format of the underlying VkImage.</summary>
    public VkBool32 imageViewFormatReinterpretation;
    /// <summary> imageViewFormatSwizzleindicates whether this implementation supports remapping format components using VkImageViewCreateInfo::components.</summary>
    public VkBool32 imageViewFormatSwizzle;
    /// <summary> imageView2DOn3DImage indicates whether this implementation supports a VkImage being created with the VK_IMAGE_CREATE_2D_ARRAY_COMPATIBLE_BIT flag set, permitting a 2D or 2D array image view to be created on a 3D VkImage.</summary>
    public VkBool32 imageView2DOn3DImage;
    /// <summary> multisampleArrayImage indicates whether this implementation supports a VkImage being created as a 2D array with multiple samples per texel.</summary>
    public VkBool32 multisampleArrayImage;
    /// <summary> mutableComparisonSamplersindicates whether this implementation allows descriptors with comparison samplers to be updated.</summary>
    public VkBool32 mutableComparisonSamplers;
    /// <summary> pointPolygons indicates whether this implementation supports https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#primsrast using a pointhttps://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#primsrast-polygonmode.</summary>
    public VkBool32 pointPolygons;
    /// <summary> samplerMipLodBias indicates whether this implementation supports setting a mipmap LOD bias value when creating a sampler.</summary>
    public VkBool32 samplerMipLodBias;
    /// <summary> separateStencilMaskRefindicates whether this implementation supports separate front and back https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#fragops-stencil reference values.</summary>
    public VkBool32 separateStencilMaskRef;
    /// <summary>shaderSampleRateInterpolationFunctions indicates whether this implementation supports fragment shaders which use the InterpolationFunction capability and the extended instructions InterpolateAtCentroid, InterpolateAtOffset, and InterpolateAtSample from the GLSL.std.450 extended instruction set. This member is only meaningful if the sampleRateShading feature is supported.</summary>
    public VkBool32 shaderSampleRateInterpolationFunctions;
    /// <summary> tessellationIsolines indicates whether this implementation supports isoline output from the https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#tessellation stage of a graphics pipeline. This member is only meaningful if tessellation shaders are supported.</summary>
    public VkBool32 tessellationIsolines;
    /// <summary> tessellationPointMode indicates whether this implementation supports point output from the https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#tessellation stage of a graphics pipeline. This member is only meaningful if tessellation shaders are supported.</summary>
    public VkBool32 tessellationPointMode;
    /// <summary> triangleFans indicates whether this implementation supports https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#drawing-triangle-fans primitive topology.</summary>
    public VkBool32 triangleFans;
    /// <summary>vertexAttributeAccessBeyondStride indicates whether this implementation supports accessing a vertex input attribute beyond the stride of the corresponding vertex input binding.</summary>
    public VkBool32 vertexAttributeAccessBeyondStride;
}
