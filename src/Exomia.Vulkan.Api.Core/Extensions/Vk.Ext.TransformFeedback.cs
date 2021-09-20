#pragma warning disable CA2211 // Non-constant fields should not be visible
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

using Exomia.Vulkan.Api.SourceGenerator;

// ReSharper disable UnusedMember.Global
namespace Exomia.Vulkan.Api.Core.Extensions
{
    [VkExtGenerator]
    public static unsafe partial class VkExtTransformFeedback
    {
        public const int    VK_EXT_TRANSFORM_FEEDBACK                = 1;
        public const int    VK_EXT_TRANSFORM_FEEDBACK_SPEC_VERSION   = 1;
        public const string VK_EXT_TRANSFORM_FEEDBACK_EXTENSION_NAME = "VK_EXT_transform_feedback";

        public static delegate*<
            VkCommandBuffer, /* commandBuffer */
            uint,            /* firstBinding */
            uint,            /* bindingCount */
            VkBuffer*,       /* pBuffers */
            VkDeviceSize*,   /* pOffsets */
            VkDeviceSize*,   /* pSizes */
            void> vkCmdBindTransformFeedbackBuffersEXT;
        
        public static delegate*<
            VkCommandBuffer, /* commandBuffer */
            uint,            /* firstCounterBuffer */
            uint,            /* counterBufferCount */
            VkBuffer*,       /* pCounterBuffers */
            VkDeviceSize*,   /* pCounterBufferOffsets */
            void> vkCmdBeginTransformFeedbackEXT;
        
        public static delegate*<
            VkCommandBuffer, /* commandBuffer */
            uint,            /* firstCounterBuffer */
            uint,            /* counterBufferCount */
            VkBuffer*,       /* pCounterBuffers */
            VkDeviceSize*,   /* pCounterBufferOffsets */
            void> vkCmdEndTransformFeedbackEXT;
        
        public static delegate*<
            VkCommandBuffer,        /* commandBuffer */
            VkQueryPool,            /* queryPool */
            uint,                   /* query */
            VkQueryControlFlagBits, /* FlagBits */
            uint,                   /* index */
            void> vkCmdBeginQueryIndexedEXT;

        public static delegate*<
            VkCommandBuffer, /* commandBuffer */
            VkQueryPool,     /* queryPool */
            uint,            /* query */
            uint,            /* index */
            void> vkCmdEndQueryIndexedEXT;
        
        public static delegate*<
            VkCommandBuffer, /* commandBuffer */
            uint,            /* instanceCount */
            uint,            /* firstInstance */
            VkBuffer,        /* counterBuffer */
            VkDeviceSize,    /* counterBufferOffset */
            uint,            /* counterOffset */
            uint,            /* vertexStride */
            void> vkCmdDrawIndirectByteCountEXT;
        
        public static partial void Load(VkDevice vkDevice);
    }
}
