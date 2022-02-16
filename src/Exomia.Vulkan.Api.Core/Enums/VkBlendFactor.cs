#region License

// Copyright (c) 2018-2022, exomia
// All rights reserved.
// 
// This source code is licensed under the BSD-style license found in the
// LICENSE file in the root directory of this source tree.

#endregion

// ReSharper disable UnusedMember.Global
// ReSharper disable InconsistentNaming
// ReSharper disable once CheckNamespace
namespace Exomia.Vulkan.Api.Core;

/// <summary>
///     VkBlendFactor - Framebuffer blending factors -
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkBlendFactor.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkBlendFactor.html</a>
/// </summary>
public enum VkBlendFactor
{
    /// <summary>
    ///     <list type="table">
    ///         <item>
    ///             <term>RGB Blend Factors (Sr,Sg,Sb) or (Dr,Dg,Db)</term><description>(0,0,0)</description>
    ///         </item>
    ///         <item>
    ///             <term>Alpha Blend Factor (Sa or Da)</term><description>0</description>
    ///         </item>
    ///     </list>
    /// </summary>
    VK_BLEND_FACTOR_ZERO = 0,

    /// <summary>
    ///     <list type="table">
    ///         <item>
    ///             <term>RGB Blend Factors (Sr,Sg,Sb) or (Dr,Dg,Db)</term><description>(1,1,1)</description>
    ///         </item>
    ///         <item>
    ///             <term>Alpha Blend Factor (Sa or Da)</term><description>1</description>
    ///         </item>
    ///     </list>
    /// </summary>
    VK_BLEND_FACTOR_ONE = 1,

    /// <summary>
    ///     <list type="table">
    ///         <item>
    ///             <term>RGB Blend Factors (Sr,Sg,Sb) or (Dr,Dg,Db)</term><description>(Rs0,Gs0,Bs0)</description>
    ///         </item>
    ///         <item>
    ///             <term>Alpha Blend Factor (Sa or Da)</term><description>As0</description>
    ///         </item>
    ///     </list>
    /// </summary>
    VK_BLEND_FACTOR_SRC_COLOR = 2,

    /// <summary>
    ///     <list type="table">
    ///         <item>
    ///             <term>RGB Blend Factors (Sr,Sg,Sb) or (Dr,Dg,Db)</term><description>(1-Rs0,1-Gs0,1-Bs0)</description>
    ///         </item>
    ///         <item>
    ///             <term>Alpha Blend Factor (Sa or Da)</term><description>1-As0</description>
    ///         </item>
    ///     </list>
    /// </summary>
    VK_BLEND_FACTOR_ONE_MINUS_SRC_COLOR = 3,

    /// <summary>
    ///     <list type="table">
    ///         <item>
    ///             <term>RGB Blend Factors (Sr,Sg,Sb) or (Dr,Dg,Db)</term><description>(Rd,Gd,Bd)</description>
    ///         </item>
    ///         <item>
    ///             <term>Alpha Blend Factor (Sa or Da)</term><description>Ad</description>
    ///         </item>
    ///     </list>
    /// </summary>
    VK_BLEND_FACTOR_DST_COLOR = 4,

    /// <summary>
    ///     <list type="table">
    ///         <item>
    ///             <term>RGB Blend Factors (Sr,Sg,Sb) or (Dr,Dg,Db)</term><description>(1-Rd,1-Gd,1-Bd)</description>
    ///         </item>
    ///         <item>
    ///             <term>Alpha Blend Factor (Sa or Da)</term><description>1-Ad</description>
    ///         </item>
    ///     </list>
    /// </summary>
    VK_BLEND_FACTOR_ONE_MINUS_DST_COLOR = 5,

    /// <summary>
    ///     <list type="table">
    ///         <item>
    ///             <term>RGB Blend Factors (Sr,Sg,Sb) or (Dr,Dg,Db)</term><description>(As0,As0,As0)</description>
    ///         </item>
    ///         <item>
    ///             <term>Alpha Blend Factor (Sa or Da)</term><description>As0</description>
    ///         </item>
    ///     </list>
    /// </summary>
    VK_BLEND_FACTOR_SRC_ALPHA = 6,

    /// <summary>
    ///     <list type="table">
    ///         <item>
    ///             <term>RGB Blend Factors (Sr,Sg,Sb) or (Dr,Dg,Db)</term><description>(1-As0,1-As0,1-As0)</description>
    ///         </item>
    ///         <item>
    ///             <term>Alpha Blend Factor (Sa or Da)</term><description>1-As0</description>
    ///         </item>
    ///     </list>
    /// </summary>
    VK_BLEND_FACTOR_ONE_MINUS_SRC_ALPHA = 7,

    /// <summary>
    ///     <list type="table">
    ///         <item>
    ///             <term>RGB Blend Factors (Sr,Sg,Sb) or (Dr,Dg,Db)</term><description>(Ad,Ad,Ad)</description>
    ///         </item>
    ///         <item>
    ///             <term>Alpha Blend Factor (Sa or Da)</term><description>Ad</description>
    ///         </item>
    ///     </list>
    /// </summary>
    VK_BLEND_FACTOR_DST_ALPHA = 8,

    /// <summary>
    ///     <list type="table">
    ///         <item>
    ///             <term>RGB Blend Factors (Sr,Sg,Sb) or (Dr,Dg,Db)</term><description>(1-Ad,1-Ad,1-Ad)</description>
    ///         </item>
    ///         <item>
    ///             <term>Alpha Blend Factor (Sa or Da)</term><description>1-Ad</description>
    ///         </item>
    ///     </list>
    /// </summary>
    VK_BLEND_FACTOR_ONE_MINUS_DST_ALPHA = 9,

    /// <summary>
    ///     <list type="table">
    ///         <item>
    ///             <term>RGB Blend Factors (Sr,Sg,Sb) or (Dr,Dg,Db)</term><description>(Rc,Gc,Bc)</description>
    ///         </item>
    ///         <item>
    ///             <term>Alpha Blend Factor (Sa or Da)</term><description>Ac</description>
    ///         </item>
    ///     </list>
    /// </summary>
    VK_BLEND_FACTOR_CONSTANT_COLOR = 10,

    /// <summary>
    ///     <list type="table">
    ///         <item>
    ///             <term>RGB Blend Factors (Sr,Sg,Sb) or (Dr,Dg,Db)</term><description>(1-Rc,1-Gc,1-Bc)</description>
    ///         </item>
    ///         <item>
    ///             <term>Alpha Blend Factor (Sa or Da)</term><description>1-Ac</description>
    ///         </item>
    ///     </list>
    /// </summary>
    VK_BLEND_FACTOR_ONE_MINUS_CONSTANT_COLOR = 11,

    /// <summary>
    ///     <list type="table">
    ///         <item>
    ///             <term>RGB Blend Factors (Sr,Sg,Sb) or (Dr,Dg,Db)</term><description>(Ac,Ac,Ac)</description>
    ///         </item>
    ///         <item>
    ///             <term>Alpha Blend Factor (Sa or Da)</term><description>Ac</description>
    ///         </item>
    ///     </list>
    /// </summary>
    VK_BLEND_FACTOR_CONSTANT_ALPHA = 12,

    /// <summary>
    ///     <list type="table">
    ///         <item>
    ///             <term>RGB Blend Factors (Sr,Sg,Sb) or (Dr,Dg,Db)</term><description>(1-Ac,1-Ac,1-Ac)</description>
    ///         </item>
    ///         <item>
    ///             <term>Alpha Blend Factor (Sa or Da)</term><description>1-Ac</description>
    ///         </item>
    ///     </list>
    /// </summary>
    VK_BLEND_FACTOR_ONE_MINUS_CONSTANT_ALPHA = 13,

    /// <summary>
    ///     <list type="table">
    ///         <item>
    ///             <term>RGB Blend Factors (Sr,Sg,Sb) or (Dr,Dg,Db)</term>
    ///             <description>(f,f,f); f = min(As0,1-Ad)</description>
    ///         </item>
    ///         <item>
    ///             <term>Alpha Blend Factor (Sa or Da)</term><description>1</description>
    ///         </item>
    ///     </list>
    /// </summary>
    VK_BLEND_FACTOR_SRC_ALPHA_SATURATE = 14,

    /// <summary>
    ///     <list type="table">
    ///         <item>
    ///             <term>RGB Blend Factors (Sr,Sg,Sb) or (Dr,Dg,Db)</term><description>(Rs1,Gs1,Bs1)</description>
    ///         </item>
    ///         <item>
    ///             <term>Alpha Blend Factor (Sa or Da)</term><description>As1</description>
    ///         </item>
    ///     </list>
    /// </summary>
    VK_BLEND_FACTOR_SRC1_COLOR = 15,

    /// <summary>
    ///     <list type="table">
    ///         <item>
    ///             <term>RGB Blend Factors (Sr,Sg,Sb) or (Dr,Dg,Db)</term><description>(1-Rs1,1-Gs1,1-Bs1)</description>
    ///         </item>
    ///         <item>
    ///             <term>Alpha Blend Factor (Sa or Da)</term><description>1-As1</description>
    ///         </item>
    ///     </list>
    /// </summary>
    VK_BLEND_FACTOR_ONE_MINUS_SRC1_COLOR = 16,

    /// <summary>
    ///     <list type="table">
    ///         <item>
    ///             <term>RGB Blend Factors (Sr,Sg,Sb) or (Dr,Dg,Db)</term><description>(As1,As1,As1)</description>
    ///         </item>
    ///         <item>
    ///             <term>Alpha Blend Factor (Sa or Da)</term><description>As1</description>
    ///         </item>
    ///     </list>
    /// </summary>
    VK_BLEND_FACTOR_SRC1_ALPHA = 17,

    /// <summary>
    ///     <list type="table">
    ///         <item>
    ///             <term>RGB Blend Factors (Sr,Sg,Sb) or (Dr,Dg,Db)</term><description>(1-As1,1-As1,1-As1)</description>
    ///         </item>
    ///         <item>
    ///             <term>Alpha Blend Factor (Sa or Da)</term><description>1-As1</description>
    ///         </item>
    ///     </list>
    /// </summary>
    VK_BLEND_FACTOR_ONE_MINUS_SRC1_ALPHA = 18
}