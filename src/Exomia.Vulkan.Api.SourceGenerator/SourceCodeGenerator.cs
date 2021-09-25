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

        public static string GetUtf8StringAsUtf16(string value)
        {
            StringBuilder valueAsUtf8InUtf16 = new StringBuilder((value.Length * 2) + 1);

            for (int i = 0, n = value.Length - 1; i < n; i += 2)
            {
                byte low  = (byte)value[i];     // is okay, because only ascii is supported
                byte high = (byte)value[i + 1]; // is okay, because only ascii is supported
                valueAsUtf8InUtf16.Append($"\\u{high:x2}{low:x2}");
            }

            return valueAsUtf8InUtf16
                   .Append(
                       value.Length % 2 == 0
                           ? "\\u0000"
                           : $"\\u00{(byte)value[value.Length - 1]:x2}")
                   .ToString();
        }

        public static string GetInstanceLoadingFunction(FunctionPointerInfo fpi, string paramName)
        {
            return $@"{fpi.Name} = ({fpi.TypeSymbol.ToDisplayString()})Utils.LoadVkFunction({paramName}, ""{GetUtf8StringAsUtf16(fpi.Name)}"");";
        }

        public static string GetDeviceLoadingFunction(FunctionPointerInfo fpi, string paramName)
        {
            return $@"{fpi.Name} = ({fpi.TypeSymbol.ToDisplayString()})Utils.LoadVkFunction({paramName}, ""{GetUtf8StringAsUtf16(fpi.Name)}"");";
        }

        public static string GetDelegates(FunctionPointerInfo fpi)
        {
            return $@"public unsafe delegate {fpi.ReturnType} {fpi.Name.Substring(2)}({string.Join(", ", fpi.Parameters.Select(p => $"{p.Type} {p.Name}"))});";
        }

        public static string GetStructsDelegates(FunctionPointerInfo fpi)
        {
            string structName = $"{char.ToUpper(fpi.Name[0])}{fpi.Name.Substring(1)}";

            return $@"public readonly unsafe struct {structName}
{{
    public static readonly {structName} Null = ({structName})null;

    /// <summary> vulkan specs <see href=""https://www.khronos.org/registry/vulkan/specs/1.2-extensions/man/html/{fpi.Name}.html"">{fpi.Name}</see>. </summary>
    public readonly delegate*<{string.Join(", ", fpi.Parameters.Select(p => $"{p.Type} /* {p.Name} */"))}, {fpi.ReturnType}> UnsafeInvoke;

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
            StringBuilder sb = new StringBuilder(
                $@"#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
/// <summary> {extensionClass.ClassName} class. </summary>
/// <remarks>
///     vulkan specs <see href=""https://www.khronos.org/registry/vulkan/specs/{VULKAN_VERSION}-extensions/man/html/{extensionClass.ExtensionName}.html"">{extensionClass.ExtensionName}</see>
/// </remarks>
{GetClassDeclaration(extensionClass)}
{{
    /// <summary> An UTF8 null terminated version represented by an UTF16 string. </summary>
    /// <remarks>
    ///     Example usage:<br />
    ///     <br />
    ///     fixed(char* ptr = {extensionClass.VarExtensionName}_UTF8_NT) {{<br />
    ///         sbyte* utf8NtPtr = (sbyte*)ptr; // utf8NtPtr - can now be passed and used directly as a utf8_nt string for unmanaged code.<br />
    ///     }}
    /// </remarks>
    public const string {extensionClass.VarExtensionName}_UTF8_NT = ""{GetUtf8StringAsUtf16(extensionClass.ExtensionName)}"";");

            if (extensionClass.LoadFunction != null)
            {
                IParameterSymbol parameterSymbol = extensionClass.LoadFunction.Parameters[0]; // must have one item!!!
                string           parameterType   = parameterSymbol.Type.Name;
                string           parameterName   = parameterSymbol.Name;

                Func<FunctionPointerInfo, string, string> extLoaderFuncBuilder = parameterType switch
                {
                    "VkInstance" => GetInstanceLoadingFunction,
                    "VkDevice"   => GetDeviceLoadingFunction,
                    _            => throw new NotSupportedException()
                };

                sb.AppendLine(
                    $@"
    /// <summary> Loads all functions for this extension. </summary>
    /// <param name=""{parameterName}""> The {parameterType}. </param>
    /// <remarks>
    ///     {extensionClass.ExtensionName} - {parameterType} extension <br />
    ///     vulkan specs <see href=""https://www.khronos.org/registry/vulkan/specs/{VULKAN_VERSION}-extensions/man/html/{extensionClass.ExtensionName}.html"">{extensionClass.ExtensionName}</see>
    /// </remarks>
    public static partial void Load({parameterType} {parameterName})
    {{
        {string.Join(Environment.NewLine, extensionClass.Functions.Select(x => extLoaderFuncBuilder(x, parameterName)))}
    }}");
            }

            return sb.AppendLine("}").ToString();
        }

        public static string GetVkFunctions(FunctionPointerInfo fpi)
        {
            return $@"/// <summary> vulkan specs <see href=""https://www.khronos.org/registry/vulkan/specs/1.2-extensions/man/html/{fpi.Name}.html"">{fpi.Name}</see>. </summary>
[FieldOffset(0)] public readonly delegate*<{string.Join(", ", fpi.Parameters.Select(p => $"{p.Type} /* {p.Name} */"))}, {fpi.ReturnType}> {fpi.Name};";
        }

        public static string GetClassDeclaration(VkExtensionClass f)
        {
            string accessibility = f.Symbol.DeclaredAccessibility switch
            {
                Accessibility.Private  => string.Empty,
                Accessibility.Internal => "internal",
                Accessibility.Public   => "public",
                _                      => throw new NotSupportedException(nameof(f.Symbol.DeclaredAccessibility))
            };
            return $@"{accessibility} unsafe{(f.Symbol.IsStatic ? " static " : " ")} partial class {f.ClassName}";
        }

        public static string GetStructDeclaration(VkFunctionClass f)
        {
            string accessibility = f.Symbol.DeclaredAccessibility switch
            {
                Accessibility.Private  => string.Empty,
                Accessibility.Internal => "internal",
                Accessibility.Public   => "public",
                _                      => throw new NotSupportedException(nameof(f.Symbol.DeclaredAccessibility))
            };
            return $@"{accessibility} {(f.Symbol.IsReadOnly ? "readonly " : " ")}unsafe partial struct {f.ClassName}";
        }
    }
}