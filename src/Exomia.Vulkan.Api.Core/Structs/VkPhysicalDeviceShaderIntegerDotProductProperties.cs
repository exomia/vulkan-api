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
///     VkPhysicalDeviceShaderIntegerDotProductProperties - Structure containing information about integer dot product
///     support for a physical device -
///     <a
///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkPhysicalDeviceShaderIntegerDotProductProperties.html">
///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkPhysicalDeviceShaderIntegerDotProductProperties.html
///     </a>
/// </summary>
/// <remarks>
///     <list type="table">
///         <item>
///             <term>structextends</term><description>VkPhysicalDeviceProperties2</description>
///         </item>
///     </list>
/// </remarks>
[VkStructExtends("VkPhysicalDeviceProperties2")]
[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPhysicalDeviceShaderIntegerDotProductProperties
{
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_INTEGER_DOT_PRODUCT_PROPERTIES;

    /// <summary>sType is the type of this structure.</summary>
    public VkStructureType sType;

    /// <summary>pNext is NULL or a pointer to a structure extending this structure.</summary>
    public void* pNext;

    /// <summary>
    ///     integerDotProduct8BitUnsignedAccelerated is a boolean that will be VK_TRUE if the support for 8-bit unsigned
    ///     dot product operations using the OpUDotKHR SPIR-V instruction is accelerated as defined below.
    /// </summary>
    public VkBool32 integerDotProduct8BitUnsignedAccelerated;

    /// <summary>
    ///     integerDotProduct8BitSignedAccelerated is a boolean that will be VK_TRUE if the support for 8-bit signed dot
    ///     product operations using the OpSDotKHR SPIR-V instruction is accelerated as defined below.
    /// </summary>
    public VkBool32 integerDotProduct8BitSignedAccelerated;

    /// <summary>
    ///     integerDotProduct8BitMixedSignednessAccelerated is a boolean that will be VK_TRUE if the support for 8-bit
    ///     mixed signedness dot product operations using the OpSUDotKHR SPIR-V instruction is accelerated as defined below.
    /// </summary>
    public VkBool32 integerDotProduct8BitMixedSignednessAccelerated;

    /// <summary>
    ///     integerDotProduct4x8BitPackedUnsignedAccelerated is a boolean that will be VK_TRUE if the support for 8-bit
    ///     unsigned dot product operations from operands packed into 32-bit integers using the OpUDotKHR SPIR-V instruction is
    ///     accelerated as defined below.
    /// </summary>
    public VkBool32 integerDotProduct4x8BitPackedUnsignedAccelerated;

    /// <summary>
    ///     integerDotProduct4x8BitPackedSignedAccelerated is a boolean that will be VK_TRUE if the support for 8-bit
    ///     signed dot product operations from operands packed into 32-bit integers using the OpSDotKHR SPIR-V instruction is
    ///     accelerated as defined below.
    /// </summary>
    public VkBool32 integerDotProduct4x8BitPackedSignedAccelerated;

    /// <summary>
    ///     integerDotProduct4x8BitPackedMixedSignednessAccelerated is a boolean that will be VK_TRUE if the support for
    ///     8-bit mixed signedness dot product operations from operands packed into 32-bit integers using the OpSUDotKHR SPIR-V
    ///     instruction is accelerated as defined below.
    /// </summary>
    public VkBool32 integerDotProduct4x8BitPackedMixedSignednessAccelerated;

    /// <summary>
    ///     integerDotProduct16BitUnsignedAccelerated is a boolean that will be VK_TRUE if the support for 16-bit unsigned
    ///     dot product operations using the OpUDotKHR SPIR-V instruction is accelerated as defined below.
    /// </summary>
    public VkBool32 integerDotProduct16BitUnsignedAccelerated;

    /// <summary>
    ///     integerDotProduct16BitSignedAccelerated is a boolean that will be VK_TRUE if the support for 16-bit signed dot
    ///     product operations using the OpSDotKHR SPIR-V instruction is accelerated as defined below.
    /// </summary>
    public VkBool32 integerDotProduct16BitSignedAccelerated;

    /// <summary>
    ///     integerDotProduct16BitMixedSignednessAccelerated is a boolean that will be VK_TRUE if the support for 16-bit
    ///     mixed signedness dot product operations using the OpSUDotKHR SPIR-V instruction is accelerated as defined below.
    /// </summary>
    public VkBool32 integerDotProduct16BitMixedSignednessAccelerated;

    /// <summary>
    ///     integerDotProduct32BitUnsignedAccelerated is a boolean that will be VK_TRUE if the support for 32-bit unsigned
    ///     dot product operations using the OpUDotKHR SPIR-V instruction is accelerated as defined below.
    /// </summary>
    public VkBool32 integerDotProduct32BitUnsignedAccelerated;

    /// <summary>
    ///     integerDotProduct32BitSignedAccelerated is a boolean that will be VK_TRUE if the support for 32-bit signed dot
    ///     product operations using the OpSDotKHR SPIR-V instruction is accelerated as defined below.
    /// </summary>
    public VkBool32 integerDotProduct32BitSignedAccelerated;

    /// <summary>
    ///     integerDotProduct32BitMixedSignednessAccelerated is a boolean that will be VK_TRUE if the support for 32-bit
    ///     mixed signedness dot product operations using the OpSUDotKHR SPIR-V instruction is accelerated as defined below.
    /// </summary>
    public VkBool32 integerDotProduct32BitMixedSignednessAccelerated;

    /// <summary>
    ///     integerDotProduct64BitUnsignedAccelerated is a boolean that will be VK_TRUE if the support for 64-bit unsigned
    ///     dot product operations using the OpUDotKHR SPIR-V instruction is accelerated as defined below.
    /// </summary>
    public VkBool32 integerDotProduct64BitUnsignedAccelerated;

    /// <summary>
    ///     integerDotProduct64BitSignedAccelerated is a boolean that will be VK_TRUE if the support for 64-bit signed dot
    ///     product operations using the OpSDotKHR SPIR-V instruction is accelerated as defined below.
    /// </summary>
    public VkBool32 integerDotProduct64BitSignedAccelerated;

    /// <summary>
    ///     integerDotProduct64BitMixedSignednessAccelerated is a boolean that will be VK_TRUE if the support for 64-bit
    ///     mixed signedness dot product operations using the OpSUDotKHR SPIR-V instruction is accelerated as defined below.
    /// </summary>
    public VkBool32 integerDotProduct64BitMixedSignednessAccelerated;

    /// <summary>
    ///     integerDotProductAccumulatingSaturating8BitUnsignedAccelerated is a boolean that will be VK_TRUE if the
    ///     support for 8-bit unsigned accumulating saturating dot product operations using the OpUDotAccSatKHR SPIR-V
    ///     instruction is accelerated as defined below.
    /// </summary>
    public VkBool32 integerDotProductAccumulatingSaturating8BitUnsignedAccelerated;

    /// <summary>
    ///     integerDotProductAccumulatingSaturating8BitSignedAccelerated is a boolean that will be VK_TRUE if the support
    ///     for 8-bit signed accumulating saturating dot product operations using the OpSDotAccSatKHR SPIR-V instruction is
    ///     accelerated as defined below.
    /// </summary>
    public VkBool32 integerDotProductAccumulatingSaturating8BitSignedAccelerated;

    /// <summary>
    ///     integerDotProductAccumulatingSaturating8BitMixedSignednessAcceleratedis a boolean that will be VK_TRUE if the
    ///     support for 8-bit mixed signedness accumulating saturating dot product operations using the OpSUDotAccSatKHR SPIR-V
    ///     instruction is accelerated as defined below.
    /// </summary>
    public VkBool32 integerDotProductAccumulatingSaturating8BitMixedSignednessAccelerated;

    /// <summary>
    ///     integerDotProductAccumulatingSaturating4x8BitPackedUnsignedAcceleratedis a boolean that will be VK_TRUE if the
    ///     support for 8-bit unsigned accumulating saturating dot product operations from operands packed into 32-bit integers
    ///     using the OpUDotAccSatKHR SPIR-V instruction is accelerated as defined below.
    /// </summary>
    public VkBool32 integerDotProductAccumulatingSaturating4x8BitPackedUnsignedAccelerated;

    /// <summary>
    ///     integerDotProductAccumulatingSaturating4x8BitPackedSignedAcceleratedis a boolean that will be VK_TRUE if the
    ///     support for 8-bit signed accumulating saturating dot product operations from operands packed into 32-bit integers
    ///     using the OpSDotAccSatKHR SPIR-V instruction is accelerated as defined below.
    /// </summary>
    public VkBool32 integerDotProductAccumulatingSaturating4x8BitPackedSignedAccelerated;

    /// <summary>
    ///     integerDotProductAccumulatingSaturating4x8BitPackedMixedSignednessAcceleratedis a boolean that will be VK_TRUE
    ///     if the support for 8-bit mixed signedness accumulating saturating dot product operations from operands packed into
    ///     32-bit integers using the OpSUDotAccSatKHR SPIR-V instruction is accelerated as defined below.
    /// </summary>
    public VkBool32 integerDotProductAccumulatingSaturating4x8BitPackedMixedSignednessAccelerated;

    /// <summary>
    ///     integerDotProductAccumulatingSaturating16BitUnsignedAccelerated is a boolean that will be VK_TRUE if the
    ///     support for 16-bit unsigned accumulating saturating dot product operations using the OpUDotAccSatKHR SPIR-V
    ///     instruction is accelerated as defined below.
    /// </summary>
    public VkBool32 integerDotProductAccumulatingSaturating16BitUnsignedAccelerated;

    /// <summary>
    ///     integerDotProductAccumulatingSaturating16BitSignedAccelerated is a boolean that will be VK_TRUE if the support
    ///     for 16-bit signed accumulating saturating dot product operations using the OpSDotAccSatKHR SPIR-V instruction is
    ///     accelerated as defined below.
    /// </summary>
    public VkBool32 integerDotProductAccumulatingSaturating16BitSignedAccelerated;

    /// <summary>
    ///     integerDotProductAccumulatingSaturating16BitMixedSignednessAcceleratedis a boolean that will be VK_TRUE if the
    ///     support for 16-bit mixed signedness accumulating saturating dot product operations using the OpSUDotAccSatKHR
    ///     SPIR-V instruction is accelerated as defined below.
    /// </summary>
    public VkBool32 integerDotProductAccumulatingSaturating16BitMixedSignednessAccelerated;

    /// <summary>
    ///     integerDotProductAccumulatingSaturating32BitUnsignedAccelerated is a boolean that will be VK_TRUE if the
    ///     support for 32-bit unsigned accumulating saturating dot product operations using the OpUDotAccSatKHR SPIR-V
    ///     instruction is accelerated as defined below.
    /// </summary>
    public VkBool32 integerDotProductAccumulatingSaturating32BitUnsignedAccelerated;

    /// <summary>
    ///     integerDotProductAccumulatingSaturating32BitSignedAccelerated is a boolean that will be VK_TRUE if the support
    ///     for 32-bit signed accumulating saturating dot product operations using the OpSDotAccSatKHR SPIR-V instruction is
    ///     accelerated as defined below.
    /// </summary>
    public VkBool32 integerDotProductAccumulatingSaturating32BitSignedAccelerated;

    /// <summary>
    ///     integerDotProductAccumulatingSaturating32BitMixedSignednessAcceleratedis a boolean that will be VK_TRUE if the
    ///     support for 32-bit mixed signedness accumulating saturating dot product operations using the OpSUDotAccSatKHR
    ///     SPIR-V instruction is accelerated as defined below.
    /// </summary>
    public VkBool32 integerDotProductAccumulatingSaturating32BitMixedSignednessAccelerated;

    /// <summary>
    ///     integerDotProductAccumulatingSaturating64BitUnsignedAccelerated is a boolean that will be VK_TRUE if the
    ///     support for 64-bit unsigned accumulating saturating dot product operations using the OpUDotAccSatKHR SPIR-V
    ///     instruction is accelerated as defined below.
    /// </summary>
    public VkBool32 integerDotProductAccumulatingSaturating64BitUnsignedAccelerated;

    /// <summary>
    ///     integerDotProductAccumulatingSaturating64BitSignedAccelerated is a boolean that will be VK_TRUE if the support
    ///     for 64-bit signed accumulating saturating dot product operations using the OpSDotAccSatKHR SPIR-V instruction is
    ///     accelerated as defined below.
    /// </summary>
    public VkBool32 integerDotProductAccumulatingSaturating64BitSignedAccelerated;

    /// <summary>
    ///     integerDotProductAccumulatingSaturating64BitMixedSignednessAcceleratedis a boolean that will be VK_TRUE if the
    ///     support for 64-bit mixed signedness accumulating saturating dot product operations using the OpSUDotAccSatKHR
    ///     SPIR-V instruction is accelerated as defined below.
    /// </summary>
    public VkBool32 integerDotProductAccumulatingSaturating64BitMixedSignednessAccelerated;
}