using Exomia.Vulkan.Api.SourceGenerator.Models;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.Text;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;

namespace Exomia.Vulkan.Api.SourceGenerator
{
    static class SourceCodeGenerator
    {
        public static string GetDelegateParamerer(FunctionPointerParameter fpp)
        {
            return fpp.Type + " " + fpp.Name;
        }
        public static string GetFunctionPointerParamerer(FunctionPointerParameter fpp, int maxTypeNameLen)
        {
            return fpp.IsReturnParameter
                ? fpp.Type
                : (fpp.Type + ',').PadRight(maxTypeNameLen) + "/* " + fpp.Name + " */";
        }

        public static string GetUtf8StringAsUtf16(string value)
        {
            string valueAsUft8InUft16 = string.Empty;
            if (((uint)value.Length << 31 >> 31) > 0)
            {
                for (int i = 0, n = value.Length - 1; i < n; i += 2)
                {
                    byte lower = (byte)value[i];     // is okay, bc only ascii is supported
                    byte hight = (byte)value[i + 1]; // is okay, bc only ascii is supported
                    valueAsUft8InUft16 += $"\\u{hight:x2}{lower:x2}";
                }

                valueAsUft8InUft16 += $"\\u00{((byte)value[value.Length - 1]):x2}";
            }
            else
            {
                for (int i = 0, n = value.Length; i < n; i += 2)
                {
                    byte lower = (byte)value[i];     // is okay, bc only ascii is supported
                    byte hight = (byte)value[i + 1]; // is okay, bc only ascii is supported
                    valueAsUft8InUft16 += $"\\u{hight:x2}{lower:x2}";
                }
                valueAsUft8InUft16 += "\\u0000";
            }

            return valueAsUft8InUft16;
        }

        public static string GetInstanceLodingFunction(FunctionPointerInfo fpi)
        {
            return $@"{fpi.Name} = Utils.LoadVkFunction(vkInstance,
    ""{GetUtf8StringAsUtf16(fpi.Name)}"")
    .{fpi.Name};";
        }

        public static string GetDeviceLodingFunction(FunctionPointerInfo fpi)
        {
            return $@"{fpi.Name} = Utils.LoadVkFunction(vkDevice,
    ""{GetUtf8StringAsUtf16(fpi.Name)}"")
    .{fpi.Name};";
        }

        public static string GetDelegateStuct(FunctionPointerInfo fpi)
        {
            string structName = $"{char.ToUpper(fpi.Name[0])}{fpi.Name.Substring(1)}";
            int maxTypeNameLen = fpi.Parameters.Where(x => !x.IsReturnParameter)
                                               .Max(x => x.Type.Length) + 1;

            return $@"public readonly unsafe struct {structName}
{{
    public static readonly {structName} Null = null;

    public readonly delegate*<
           {string.Join(Environment.NewLine, fpi.Parameters.Select(x => GetFunctionPointerParamerer(x, maxTypeNameLen)))}> UnsafeInvoke;

    public static implicit operator {structName}(void* ptr)
    {{
        {structName} value;
        *(void**)&value = ptr;
        return value;
    }}
}}";
        }

        public static string GetExtentionClass(VkExtensionClass extentionClass)
        {
            IParameterSymbol parameterSymbol = extentionClass.LoadFunction.Parameters[0]; // must have one item!!!
            string parameterType = parameterSymbol.Type.Name;
            string parameterName = parameterSymbol.Name;

            Func<FunctionPointerInfo, string> extLoaderFuncBuilder = parameterType switch
            {
                "VkInstance" => GetInstanceLodingFunction,
                "VkDevice" => GetDeviceLodingFunction,
                _ => throw new NotSupportedException()
            };
            
            return $@"public unsafe static partial class {extentionClass.ClassName}
{{
    public const string {extentionClass.VarExtensionName}_UTF8_NT = ""{GetUtf8StringAsUtf16(extentionClass.ExtentionName)}"";
       
    public static partial void Load({parameterType} {parameterName})
    {{
        {string.Join(Environment.NewLine, extentionClass.Functions.Select(x => extLoaderFuncBuilder(x)))}
    }}
}}";

        }

    }
}
