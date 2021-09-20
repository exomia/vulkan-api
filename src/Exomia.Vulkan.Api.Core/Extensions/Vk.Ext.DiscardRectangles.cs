#pragma warning disable CA2211 // Non-constant fields should not be visible
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

using Exomia.Vulkan.Api.SourceGenerator;

// ReSharper disable UnusedMember.Global
namespace Exomia.Vulkan.Api.Core.Extensions
{
    [VkExtGenerator]
    public static unsafe partial class VkExtDiscardRectangles
    {
        public const int    VK_EXT_DISCARD_RECTANGLES                = 1;
        public const int    VK_EXT_DISCARD_RECTANGLES_SPEC_VERSION   = 1;
        public const string VK_EXT_DISCARD_RECTANGLES_EXTENSION_NAME = "VK_EXT_discard_rectangles";

        public static delegate*<
            VkCommandBuffer, /* commandBuffer */
            uint,            /* firstDiscardRectangle */
            uint,            /* discardRectangleCount */
            VkRect2D*,       /* pDiscardRectangles */
            void> vkCmdSetDiscardRectangleEXT;

        public static partial void Load(VkDevice vkDevice);
    }
}
