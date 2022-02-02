#region License

// Copyright (c) 2018-2022, exomia
// All rights reserved.
// 
// This source code is licensed under the BSD-style license found in the
// LICENSE file in the root directory of this source tree.

#endregion

namespace Exomia.Vulkan.Api.Core.Attributes;

/// <summary> Attribute for special use. </summary>
[AttributeUsage(AttributeTargets.Class, AllowMultiple = true)]
public sealed class VkSpecialuseAttribute : Attribute
{
    /// <summary> Gets the value. </summary>
    /// <value> The value. </value>
    public string Value { get; }

    /// <summary> Initializes a new instance of the <see cref="VkSpecialuseAttribute" /> class. </summary>
    /// <param name="value"> The value. </param>
    public VkSpecialuseAttribute(string value)
    {
        Value = value;
    }
}