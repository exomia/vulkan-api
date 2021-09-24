#pragma warning disable CA2211 // Non-constant fields should not be visible
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

using Exomia.Vulkan.Api.SourceGenerator;
using System.Runtime.InteropServices;

// ReSharper disable UnusedMember.Global
namespace Exomia.Vulkan.Api.Core.Extensions
{
    [VkExtGenerator]
    public static unsafe partial class VkExtMemoryBudget
    {
        public const int    VK_EXT_MEMORY_BUDGET                = 1;
        public const int    VK_EXT_MEMORY_BUDGET_SPEC_VERSION   = 1;
        public const string VK_EXT_MEMORY_BUDGET_EXTENSION_NAME = "VK_EXT_memory_budget";
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkPhysicalDeviceMemoryBudgetPropertiesEXT
    {
        public const VkStructureType         STYPE = VkStructureType.PHYSICAL_DEVICE_MEMORY_BUDGET_PROPERTIES_EXT;
        public       VkStructureType         sType;
        public       void*                   pNext;
        public       VkArray16<VkDeviceSize> heapBudget;
        public       VkArray16<VkDeviceSize> heapUsage;
    }
}