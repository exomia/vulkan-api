#pragma warning disable CA2211 // Non-constant fields should not be visible
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

using Exomia.Vulkan.Api.SourceGenerator;

// ReSharper disable UnusedMember.Global
namespace Exomia.Vulkan.Api.Core.Extensions
{
    [VkExtGenerator]
    public static unsafe partial class VkExtPipelineCreationFeedback
    {
        public const int    VK_EXT_PIPELINE_CREATION_FEEDBACK                = 1;
        public const int    VK_EXT_PIPELINE_CREATION_FEEDBACK_SPEC_VERSION   = 1;
        public const string VK_EXT_PIPELINE_CREATION_FEEDBACK_EXTENSION_NAME = "VK_EXT_pipeline_creation_feedback";
    }
}
