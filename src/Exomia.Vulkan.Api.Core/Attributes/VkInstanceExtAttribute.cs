#region License

// Copyright (c) 2018-2023, exomia
// All rights reserved.
// 
// This source code is licensed under the BSD-style license found in the
// LICENSE file in the root directory of this source tree.

#endregion

namespace Exomia.Vulkan.Api.Core.Attributes;

/// <summary> Attribute to mark an extension as an instance extension. </summary>
[AttributeUsage(AttributeTargets.Class, AllowMultiple = false)]
public sealed class VkInstanceExtAttribute : Attribute { }