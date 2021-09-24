#pragma warning disable CA2211 // Non-constant fields should not be visible
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

using System;
using Exomia.Vulkan.Api.SourceGenerator;

// ReSharper disable UnusedMember.Global
namespace Exomia.Vulkan.Api.Core.Extensions
{
    [Obsolete("Deprecated by Vulkan 1.2", false, UrlFormat = "https://www.khronos.org/registry/vulkan/specs/1.2-extensions/man/html/VK_EXT_shader_subgroup_ballot.html#_deprecation_state")]
    [VkExtGenerator]
    public static partial class VkExtShaderSubgroupBallot
    {
        public const int    VK_EXT_SHADER_SUBGROUP_BALLOT                = 1;
        public const int    VK_EXT_SHADER_SUBGROUP_BALLOT_SPEC_VERSION   = 1;
        public const string VK_EXT_SHADER_SUBGROUP_BALLOT_EXTENSION_NAME = "VK_EXT_shader_subgroup_ballot";
    }
}