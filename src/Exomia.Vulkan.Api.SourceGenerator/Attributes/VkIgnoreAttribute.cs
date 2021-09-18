using System;
using System.Runtime.CompilerServices;

namespace Exomia.Vulkan.Api.SourceGenerator
{
    [AttributeUsage(AttributeTargets.Field, AllowMultiple = false)]
    public sealed class VkIgnoreAttribute: Attribute
    {

        public string FunctionName { get; private set; }

        public VkIgnoreAttribute([CallerMemberName] string functionName = "")
        {
            FunctionName = functionName;
        }
    }
}
