#region License

// Copyright (c) 2018-2021, exomia
// All rights reserved.
// 
// This source code is licensed under the BSD-style license found in the
// LICENSE file in the root directory of this source tree.

#endregion

using System;
using System.Linq;
using System.Text;
using Exomia.Vulkan.Api.SourceGenerator.Models;
using Microsoft.CodeAnalysis;

namespace Exomia.Vulkan.Api.SourceGenerator
{
    static class SourceCodeGenerator
    {
        private const string VULKAN_VERSION = "1.2";

        public static string GetDelegateParameter(FunctionPointerParameter fpp)
        {
            return $"{fpp.Type} {fpp.Name}";
        }

        public static string GetFunctionPointerParameter(FunctionPointerParameter fpp, int maxTypeNameLen)
        {
            return fpp.IsReturnParameter
                ? fpp.Type ?? throw new NullReferenceException(nameof(fpp.Type))
                : $"{(fpp.Type + ',').PadRight(maxTypeNameLen)} /* {fpp.Name} */";
        }

        public static string GetUtf8StringAsUtf16(string value)
        {
            StringBuilder valueAsUft8InUft16 = new StringBuilder((value.Length * 2) + 1);

            for (int i = 0, n = value.Length - 1; i < n; i += 2)
            {
                byte low  = (byte)value[i];     // is okay, because only ascii is supported
                byte high = (byte)value[i + 1]; // is okay, because only ascii is supported
                valueAsUft8InUft16.Append($"\\u{high:x2}{low:x2}");
            }

            return valueAsUft8InUft16
                   .Append(
                       value.Length % 2 == 0
                           ? "\\u0000"
                           : $"\\u00{(byte)value[value.Length - 1]:x2}")
                   .ToString();
        }

        public static string GetInstanceLoadingFunction(FunctionPointerInfo fpi)
        {
            return $@"{fpi.Name} = Utils.LoadVkFunction(vkInstance,
    ""{GetUtf8StringAsUtf16(fpi.Name)}"")
    .{fpi.Name};";
        }

        public static string GetDeviceLoadingFunction(FunctionPointerInfo fpi)
        {
            return $@"{fpi.Name} = Utils.LoadVkFunction(vkDevice,
    ""{GetUtf8StringAsUtf16(fpi.Name)}"")
    .{fpi.Name};";
        }

        public static string GetDelegateStruct(FunctionPointerInfo fpi)
        {
            string structName = $"{char.ToUpper(fpi.Name[0])}{fpi.Name.Substring(1)}";
            int maxTypeNameLen = fpi.Parameters.Where(x => !x.IsReturnParameter)
                                    .Max(x => x.Type.Length) + 1;

            return $@"public readonly unsafe struct {structName}
{{
    public static readonly {structName} Null = null;

    public readonly delegate*<
           {string.Join(Environment.NewLine, fpi.Parameters.Select(x => GetFunctionPointerParameter(x, maxTypeNameLen)))}> UnsafeInvoke;

    public static implicit operator {structName}(void* ptr)
    {{
        {structName} value;
        *(void**)&value = ptr;
        return value;
    }}
}}";
        }

        public static string GetExtensionClass(VkExtensionClass extensionClass)
        {
            IParameterSymbol parameterSymbol = extensionClass.LoadFunction.Parameters[0]; // must have one item!!!
            string           parameterType   = parameterSymbol.Type.Name;
            string           parameterName   = parameterSymbol.Name;

            Func<FunctionPointerInfo, string> extLoaderFuncBuilder = parameterType switch
            {
                "VkInstance" => GetInstanceLoadingFunction,
                "VkDevice"   => GetDeviceLoadingFunction,
                _            => throw new NotSupportedException()
            };

            return $@"public unsafe static partial class {extensionClass.ClassName}
{{
    public const string {extensionClass.VarExtensionName}_UTF8_NT = ""{GetUtf8StringAsUtf16(extensionClass.ExtensionName)}"";
       
    /// <summary>
    /// Loads all functions for this extension.
    /// </summary>
    /// <param name=""{parameterName}""> The {parameterType}. </param>
    /// <remarks>
    ///     {extensionClass.ExtensionName} - {parameterType} extension <br />
    ///     vulkan specs <see href=""https://www.khronos.org/registry/vulkan/specs/{VULKAN_VERSION}-extensions/man/html/{extensionClass.ExtensionName}.html"">{extensionClass.ExtensionName}</see>
    /// </remarks>
    public static partial void Load({parameterType} {parameterName})
    {{
        {string.Join(Environment.NewLine, extensionClass.Functions.Select(x => extLoaderFuncBuilder(x)))}
    }}
}}";
        }
    }
}