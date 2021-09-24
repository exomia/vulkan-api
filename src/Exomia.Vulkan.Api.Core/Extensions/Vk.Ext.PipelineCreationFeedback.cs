#pragma warning disable CA2211 // Non-constant fields should not be visible
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

using Exomia.Vulkan.Api.SourceGenerator;
using System;
using System.Runtime.InteropServices;

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

    [Flags]
    public enum VkPipelineCreationFeedbackFlagsEXT
    {
        VALID_BIT_EXT                          = 0x00000001,
        APPLICATION_PIPELINE_CACHE_HIT_BIT_EXT = 0x00000002,
        BASE_PIPELINE_ACCELERATION_BIT_EXT     = 0x00000004,
        FLAG_BITS_MAX_ENUM_EXT                 = 0x7FFFFFFF
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct VkPipelineCreationFeedbackEXT
    {
        public VkPipelineCreationFeedbackFlagsEXT flags;
        public ulong                              duration;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkPipelineCreationFeedbackCreateInfoEXT
    {
        public const VkStructureType                STYPE = VkStructureType.PIPELINE_CREATION_FEEDBACK_CREATE_INFO_EXT;
        public       VkStructureType                sType;
        public       void*                          pNext;
        public       VkPipelineCreationFeedbackEXT* pPipelineCreationFeedback;
        public       uint                           pipelineStageCreationFeedbackCount;
        public       VkPipelineCreationFeedbackEXT* pPipelineStageCreationFeedbacks;
    }
}