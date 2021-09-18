using Microsoft.CodeAnalysis.CSharp.Syntax;
using System.Collections.Generic;

namespace Exomia.Vulkan.Api.SourceGenerator.Models
{
    struct FunctionPointerInfo
    {
        public string Name;
        public List<FunctionPointerParameter> Parameters;
    }
}
