﻿#region License

// Copyright (c) 2018-2024, exomia
// All rights reserved.
// 
// This source code is licensed under the BSD-style license found in the
// LICENSE file in the root directory of this source tree.

#endregion

namespace Exomia.Vulkan.Api.Core.Attributes;

/// <summary> Attribute for depends. </summary>
[AttributeUsage(AttributeTargets.Class, AllowMultiple = false)]
public sealed class VkDependsAttribute : Attribute
{
    /// <summary> Gets the value. </summary>
    /// <value> The value. </value>
    public string Value { get; }

    /// <summary> Initializes a new instance of the <see cref="VkDependsAttribute" /> class. </summary>
    /// <param name="value"> The value. </param>
    public VkDependsAttribute(string value)
    {
        Value = value;
    }
}