#region License

// Copyright (c) 2018-2021, exomia
// All rights reserved.
// 
// This source code is licensed under the BSD-style license found in the
// LICENSE file in the root directory of this source tree.

#endregion

using System;
using System.Runtime.CompilerServices;

namespace Exomia.Vulkan.Api.SourceGenerator
{
    /// <summary> Attribute for vk ignore. This class cannot be inherited. </summary>
    [AttributeUsage(AttributeTargets.Field, AllowMultiple = false)]
    public sealed class VkIgnoreAttribute: Attribute
    {
        /// <summary> Gets the name of the function. </summary>
        /// <value> The name of the function. </value>
        public string FunctionName { get; }
        
        /// <summary> Initializes a new instance of the <see cref="VkIgnoreAttribute"/> class. </summary>
        /// <param name="functionName"> (Optional) Name of the function. </param>
        public VkIgnoreAttribute([CallerMemberName] string functionName = "")
        {
            FunctionName = functionName;
        }
    }
}
