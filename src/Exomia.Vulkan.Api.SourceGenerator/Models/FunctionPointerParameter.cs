using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.Operations;
using Microsoft.CodeAnalysis.Text;
using System;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;

namespace Exomia.Vulkan.Api.SourceGenerator.Models
{
    struct FunctionPointerParameter
    {
        public bool IsReturnParameter;
        public FunctionPointerParameterSyntax ParameterSyntax;
        public string Name;
        public string Type;
        
    }


}
