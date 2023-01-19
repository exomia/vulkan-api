#region License

// Copyright (c) 2018-2023, exomia
// All rights reserved.
// 
// This source code is licensed under the BSD-style license found in the
// LICENSE file in the root directory of this source tree.

#endregion

namespace Exomia.Vulkan.Api.Core.Attributes;

/// <summary> Attribute for provisional. </summary>
[AttributeUsage(AttributeTargets.Class, AllowMultiple = true)]
public sealed class VkProvisionalAttribute : Attribute
{
    /// <summary> Gets the value. </summary>
    /// <value> The value. </value>
    public string Value { get; }

    /// <summary> Initializes a new instance of the <see cref="VkProvisionalAttribute" /> class. </summary>
    /// <param name="value"> The value. </param>
    public VkProvisionalAttribute(string value)
    {
        Value = value;
    }
}