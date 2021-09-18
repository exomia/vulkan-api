using Microsoft.CodeAnalysis;
using System.Collections.Generic;

namespace Exomia.Vulkan.Api.SourceGenerator.Models
{
    struct VkExtensionClass
    {
        public string ClassName;
        public string VarExtensionName;
        public string ExtentionName;
        public IMethodSymbol LoadFunction;
        public List<FunctionPointerInfo> Functions;
    }
}
