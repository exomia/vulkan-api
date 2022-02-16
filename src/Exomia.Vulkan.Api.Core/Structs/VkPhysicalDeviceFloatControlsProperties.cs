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
///     VkPhysicalDeviceFloatControlsProperties - Structure describing properties supported by VK_KHR_shader_float_controls
///     -
///     <a
///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkPhysicalDeviceFloatControlsProperties.html">
///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkPhysicalDeviceFloatControlsProperties.html
///     </a>
/// </summary>
/// <remarks>
///     <list type="table">
///         <item>
///             <term>structextends</term><description>VkPhysicalDeviceProperties2</description>
///         </item>
///         <item>
///             <term>returnedonly</term><description>true</description>
///         </item>
///     </list>
/// </remarks>
[VkStructExtends("VkPhysicalDeviceProperties2")]
[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPhysicalDeviceFloatControlsProperties
{
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_FLOAT_CONTROLS_PROPERTIES;

    /// <summary>sType is the type of this structure.</summary>
    public VkStructureType sType;

    /// <summary>pNext is NULL or a pointer to a structure extending this structure.</summary>
    public void* pNext;

    /// <summary>
    ///     denormBehaviorIndependence is a VkShaderFloatControlsIndependence value indicating whether, and how, denorm
    ///     behavior can be set independently for different bit widths.
    /// </summary>
    public VkShaderFloatControlsIndependence denormBehaviorIndependence;

    /// <summary>
    ///     roundingModeIndependence is a VkShaderFloatControlsIndependence value indicating whether, and how, rounding
    ///     modes can be set independently for different bit widths.
    /// </summary>
    public VkShaderFloatControlsIndependence roundingModeIndependence;

    /// <summary>
    ///     shaderSignedZeroInfNanPreserveFloat16 is a boolean value indicating whether sign of a zero, Nans and ±∞ can be
    ///     preserved in 16-bit floating-point computations. It also indicates whether the SignedZeroInfNanPreserve execution
    ///     mode can be used for 16-bit floating-point types.
    /// </summary>
    public VkBool32 shaderSignedZeroInfNanPreserveFloat16;

    /// <summary>
    ///     shaderSignedZeroInfNanPreserveFloat32 is a boolean value indicating whether sign of a zero, Nans and ±∞ can be
    ///     preserved in 32-bit floating-point computations. It also indicates whether the SignedZeroInfNanPreserve execution
    ///     mode can be used for 32-bit floating-point types.
    /// </summary>
    public VkBool32 shaderSignedZeroInfNanPreserveFloat32;

    /// <summary>
    ///     shaderSignedZeroInfNanPreserveFloat64 is a boolean value indicating whether sign of a zero, Nans and ±∞ can be
    ///     preserved in 64-bit floating-point computations. It also indicates whether the SignedZeroInfNanPreserve execution
    ///     mode can be used for 64-bit floating-point types.
    /// </summary>
    public VkBool32 shaderSignedZeroInfNanPreserveFloat64;

    /// <summary>
    ///     shaderDenormPreserveFloat16 is a boolean value indicating whether denormals can be preserved in 16-bit
    ///     floating-point computations. It also indicates whether the DenormPreserve execution mode can be used for 16-bit
    ///     floating-point types.
    /// </summary>
    public VkBool32 shaderDenormPreserveFloat16;

    /// <summary>
    ///     shaderDenormPreserveFloat32 is a boolean value indicating whether denormals can be preserved in 32-bit
    ///     floating-point computations. It also indicates whether the DenormPreserve execution mode can be used for 32-bit
    ///     floating-point types.
    /// </summary>
    public VkBool32 shaderDenormPreserveFloat32;

    /// <summary>
    ///     shaderDenormPreserveFloat64 is a boolean value indicating whether denormals can be preserved in 64-bit
    ///     floating-point computations. It also indicates whether the DenormPreserve execution mode can be used for 64-bit
    ///     floating-point types.
    /// </summary>
    public VkBool32 shaderDenormPreserveFloat64;

    /// <summary>
    ///     shaderDenormFlushToZeroFloat16 is a boolean value indicating whether denormals can be flushed to zero in
    ///     16-bit floating-point computations. It also indicates whether the DenormFlushToZero execution mode canbe used for
    ///     16-bit floating-point types.
    /// </summary>
    public VkBool32 shaderDenormFlushToZeroFloat16;

    /// <summary>
    ///     shaderDenormFlushToZeroFloat32 is a boolean value indicating whether denormals can be flushed to zero in
    ///     32-bit floating-point computations. It also indicates whether the DenormFlushToZero execution mode canbe used for
    ///     32-bit floating-point types.
    /// </summary>
    public VkBool32 shaderDenormFlushToZeroFloat32;

    /// <summary>
    ///     shaderDenormFlushToZeroFloat64 is a boolean value indicating whether denormals can be flushed to zero in
    ///     64-bit floating-point computations. It also indicates whether the DenormFlushToZero execution mode canbe used for
    ///     64-bit floating-point types.
    /// </summary>
    public VkBool32 shaderDenormFlushToZeroFloat64;

    /// <summary>
    ///     shaderRoundingModeRTEFloat16 is a boolean value indicating whether an implementation supports the
    ///     round-to-nearest-even rounding mode for 16-bit floating-point arithmetic and conversion instructions. It also
    ///     indicates whether the RoundingModeRTE execution mode canbe used for 16-bit floating-point types.
    /// </summary>
    public VkBool32 shaderRoundingModeRTEFloat16;

    /// <summary>
    ///     shaderRoundingModeRTEFloat32 is a boolean value indicating whether an implementation supports the
    ///     round-to-nearest-even rounding mode for 32-bit floating-point arithmetic and conversion instructions. It also
    ///     indicates whether the RoundingModeRTE execution mode canbe used for 32-bit floating-point types.
    /// </summary>
    public VkBool32 shaderRoundingModeRTEFloat32;

    /// <summary>
    ///     shaderRoundingModeRTEFloat64 is a boolean value indicating whether an implementation supports the
    ///     round-to-nearest-even rounding mode for 64-bit floating-point arithmetic and conversion instructions. It also
    ///     indicates whether the RoundingModeRTE execution mode canbe used for 64-bit floating-point types.
    /// </summary>
    public VkBool32 shaderRoundingModeRTEFloat64;

    /// <summary>
    ///     shaderRoundingModeRTZFloat16 is a boolean value indicating whether an implementation supports the
    ///     round-towards-zero rounding mode for 16-bit floating-point arithmetic and conversion instructions. It also
    ///     indicates whether the RoundingModeRTZ execution mode canbe used for 16-bit floating-point types.
    /// </summary>
    public VkBool32 shaderRoundingModeRTZFloat16;

    /// <summary>
    ///     shaderRoundingModeRTZFloat32 is a boolean value indicating whether an implementation supports the
    ///     round-towards-zero rounding mode for 32-bit floating-point arithmetic and conversion instructions. It also
    ///     indicates whether the RoundingModeRTZ execution mode canbe used for 32-bit floating-point types.
    /// </summary>
    public VkBool32 shaderRoundingModeRTZFloat32;

    /// <summary>
    ///     shaderRoundingModeRTZFloat64 is a boolean value indicating whether an implementation supports the
    ///     round-towards-zero rounding mode for 64-bit floating-point arithmetic and conversion instructions. It also
    ///     indicates whether the RoundingModeRTZ execution mode canbe used for 64-bit floating-point types.
    /// </summary>
    public VkBool32 shaderRoundingModeRTZFloat64;
}