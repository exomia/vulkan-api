#pragma warning disable CA2211 // Non-constant fields should not be visible
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

using Exomia.Vulkan.Api.SourceGenerator;

// ReSharper disable UnusedMember.Global
namespace Exomia.Vulkan.Api.Core.Extensions
{
    [VkExtGenerator]
    public static unsafe partial class VkExtConditionalRendering
    {
        public const int    VK_EXT_CONDITIONAL_RENDERING                = 1;
        public const int    VK_EXT_CONDITIONAL_RENDERING_SPEC_VERSION   = 2;
        public const string VK_EXT_CONDITIONAL_RENDERING_EXTENSION_NAME = "VK_EXT_conditional_rendering";
        
        public static delegate*<
            VkCommandBuffer,                     /* commandBuffer */
            VkConditionalRenderingBeginInfoEXT*, /* pConditionalRenderingBegin */
            void> vkCmdBeginConditionalRenderingEXT;

        public static delegate*<
            VkCommandBuffer, /* commandBuffer */
            void> vkCmdEndConditionalRenderingEXT;

        public static partial void Load(VkDevice vkDevice);
    }
}
