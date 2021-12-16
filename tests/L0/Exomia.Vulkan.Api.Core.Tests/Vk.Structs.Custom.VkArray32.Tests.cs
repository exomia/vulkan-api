#region License

// Copyright (c) 2018-2021, exomia
// All rights reserved.
// 
// This source code is licensed under the BSD-style license found in the
// LICENSE file in the root directory of this source tree.

#endregion

using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

#pragma warning disable 168
#pragma warning disable CS0219 // Variable is assigned but its value is never used

// ReSharper disable UnusedVariable
namespace Exomia.Vulkan.Api.Core.Tests;

[TestClass]
public class VkStructsCustomVkArray32Tests
{
    [TestMethod]
    public void VkArray32_DefaultConstructor_ShouldCreate()
    {
        VkArray32<int> arr1 = new VkArray32<int>();
        VkArray32<int> arr2;
    }

    [TestMethod]
    public void VkArray32_ValidIndexerUint_Set01To32_ShouldWorkAndNotThrowException()
    {
        VkArray32<uint> arr = new VkArray32<uint>();
        for (uint i = 0; i < VkArray32<int>.LENGTH; i++)
        {
            arr[i] = i + 1;
        }
        Assert.AreEqual(1u,  arr.M01);
        Assert.AreEqual(2u,  arr.M02);
        Assert.AreEqual(3u,  arr.M03);
        Assert.AreEqual(4u,  arr.M04);
        Assert.AreEqual(5u,  arr.M05);
        Assert.AreEqual(6u,  arr.M06);
        Assert.AreEqual(7u,  arr.M07);
        Assert.AreEqual(8u,  arr.M08);
        Assert.AreEqual(9u,  arr.M09);
        Assert.AreEqual(10u, arr.M10);
        Assert.AreEqual(11u, arr.M11);
        Assert.AreEqual(12u, arr.M12);
        Assert.AreEqual(13u, arr.M13);
        Assert.AreEqual(14u, arr.M14);
        Assert.AreEqual(15u, arr.M15);
        Assert.AreEqual(16u, arr.M16);
        Assert.AreEqual(17u, arr.M17);
        Assert.AreEqual(18u, arr.M18);
        Assert.AreEqual(19u, arr.M19);
        Assert.AreEqual(20u, arr.M20);
        Assert.AreEqual(21u, arr.M21);
        Assert.AreEqual(22u, arr.M22);
        Assert.AreEqual(23u, arr.M23);
        Assert.AreEqual(24u, arr.M24);
        Assert.AreEqual(25u, arr.M25);
        Assert.AreEqual(26u, arr.M26);
        Assert.AreEqual(27u, arr.M27);
        Assert.AreEqual(28u, arr.M28);
        Assert.AreEqual(29u, arr.M29);
        Assert.AreEqual(30u, arr.M30);
        Assert.AreEqual(31u, arr.M31);
        Assert.AreEqual(32u, arr.M32);
    }

    [TestMethod]
    public void VkArray32_ValidIndexerInt_Set01To32_ShouldWorkAndNotThrowException()
    {
        VkArray32<int> arr = new VkArray32<int>();
        for (int i = 0; i < VkArray32<int>.LENGTH; i++)
        {
            arr[i] = i + 1;
        }
        Assert.AreEqual(1,  arr.M01);
        Assert.AreEqual(2,  arr.M02);
        Assert.AreEqual(3,  arr.M03);
        Assert.AreEqual(4,  arr.M04);
        Assert.AreEqual(5,  arr.M05);
        Assert.AreEqual(6,  arr.M06);
        Assert.AreEqual(7,  arr.M07);
        Assert.AreEqual(8,  arr.M08);
        Assert.AreEqual(9,  arr.M09);
        Assert.AreEqual(10, arr.M10);
        Assert.AreEqual(11, arr.M11);
        Assert.AreEqual(12, arr.M12);
        Assert.AreEqual(13, arr.M13);
        Assert.AreEqual(14, arr.M14);
        Assert.AreEqual(15, arr.M15);
        Assert.AreEqual(16, arr.M16);
        Assert.AreEqual(17, arr.M17);
        Assert.AreEqual(18, arr.M18);
        Assert.AreEqual(19, arr.M19);
        Assert.AreEqual(20, arr.M20);
        Assert.AreEqual(21, arr.M21);
        Assert.AreEqual(22, arr.M22);
        Assert.AreEqual(23, arr.M23);
        Assert.AreEqual(24, arr.M24);
        Assert.AreEqual(25, arr.M25);
        Assert.AreEqual(26, arr.M26);
        Assert.AreEqual(27, arr.M27);
        Assert.AreEqual(28, arr.M28);
        Assert.AreEqual(29, arr.M29);
        Assert.AreEqual(30, arr.M30);
        Assert.AreEqual(31, arr.M31);
        Assert.AreEqual(32, arr.M32);
    }

    [TestMethod]
    public void VkArray32_ValidIndexerUint_Get01To32_ShouldWorkAndNotThrowException()
    {
        VkArray32<uint> arr = new VkArray32<uint>
        {
            M01 = 1u,
            M02 = 2u,
            M03 = 3u,
            M04 = 4u,
            M05 = 5u,
            M06 = 6u,
            M07 = 7u,
            M08 = 8u,
            M09 = 9u,
            M10 = 10u,
            M11 = 11u,
            M12 = 12u,
            M13 = 13u,
            M14 = 14u,
            M15 = 15u,
            M16 = 16u,
            M17 = 17u,
            M18 = 18u,
            M19 = 19u,
            M20 = 20u,
            M21 = 21u,
            M22 = 22u,
            M23 = 23u,
            M24 = 24u,
            M25 = 25u,
            M26 = 26u,
            M27 = 27u,
            M28 = 28u,
            M29 = 29u,
            M30 = 30u,
            M31 = 31u,
            M32 = 32u
        };

        for (uint i = 0; i < VkArray32<int>.LENGTH; i++)
        {
            Assert.AreEqual(i + 1, arr[i]);
        }
    }

    [TestMethod]
    public void VkArray32_ValidIndexerInt_Get01To32_ShouldWorkAndNotThrowException()
    {
        VkArray32<int> arr = new VkArray32<int>
        {
            M01 = 1,
            M02 = 2,
            M03 = 3,
            M04 = 4,
            M05 = 5,
            M06 = 6,
            M07 = 7,
            M08 = 8,
            M09 = 9,
            M10 = 10,
            M11 = 11,
            M12 = 12,
            M13 = 13,
            M14 = 14,
            M15 = 15,
            M16 = 16,
            M17 = 17,
            M18 = 18,
            M19 = 19,
            M20 = 20,
            M21 = 21,
            M22 = 22,
            M23 = 23,
            M24 = 24,
            M25 = 25,
            M26 = 26,
            M27 = 27,
            M28 = 28,
            M29 = 29,
            M30 = 30,
            M31 = 31,
            M32 = 32
        };

        for (int i = 0; i < VkArray32<int>.LENGTH; i++)
        {
            Assert.AreEqual(i + 1, arr[i]);
        }
    }
#if DEBUG
    [DataTestMethod]
    [DataRow(45u)]
    [DataRow(uint.MaxValue)]
    [DataRow(785u)]
    [DataRow(987787898u)]

    // ReSharper disable once HeapView.ClosureAllocation
    public void VkArray32_InvalidIndexerUint_Get_ShouldNotWorkAndThrowException(uint index)
    {
        VkArray32<int> arr = new VkArray32<int>
        {
            M01 = 1,
            M02 = 2,
            M03 = 3,
            M04 = 4,
            M05 = 5,
            M06 = 6,
            M07 = 7,
            M08 = 8,
            M09 = 9,
            M10 = 10,
            M11 = 11,
            M12 = 12,
            M13 = 13,
            M14 = 14,
            M15 = 15,
            M16 = 16,
            M17 = 17,
            M18 = 18,
            M19 = 19,
            M20 = 20,
            M21 = 21,
            M22 = 22,
            M23 = 23,
            M24 = 24,
            M25 = 25,
            M26 = 26,
            M27 = 27,
            M28 = 28,
            M29 = 29,
            M30 = 30,
            M31 = 31,
            M32 = 32
        };
        Assert.ThrowsException<ArgumentOutOfRangeException>(

            // ReSharper disable once HeapView.DelegateAllocation
            () =>
            {
                int value = arr[index];
            });
    }

    [DataTestMethod]
    [DataRow(45)]
    [DataRow(int.MaxValue)]
    [DataRow(int.MinValue)]
    [DataRow(785)]
    [DataRow(-785)]
    [DataRow(987787898)]

    // ReSharper disable once HeapView.ClosureAllocation
    public void VkArray32_InvalidIndexerInt_Get_ShouldNotWorkAndThrowException(int index)
    {
        VkArray32<int> arr = new VkArray32<int>
        {
            M01 = 1,
            M02 = 2,
            M03 = 3,
            M04 = 4,
            M05 = 5,
            M06 = 6,
            M07 = 7,
            M08 = 8,
            M09 = 9,
            M10 = 10,
            M11 = 11,
            M12 = 12,
            M13 = 13,
            M14 = 14,
            M15 = 15,
            M16 = 16,
            M17 = 17,
            M18 = 18,
            M19 = 19,
            M20 = 20,
            M21 = 21,
            M22 = 22,
            M23 = 23,
            M24 = 24,
            M25 = 25,
            M26 = 26,
            M27 = 27,
            M28 = 28,
            M29 = 29,
            M30 = 30,
            M31 = 31,
            M32 = 32
        };
        Assert.ThrowsException<ArgumentOutOfRangeException>(

            // ReSharper disable once HeapView.DelegateAllocation
            () =>
            {
                int value = arr[index];
            });
    }

    [DataTestMethod]
    [DataRow(45u)]
    [DataRow(uint.MaxValue)]
    [DataRow(785u)]
    [DataRow(987787898u)]

    // ReSharper disable once HeapView.ClosureAllocation
    public void VkArray32_InvalidIndexerUint_Set_ShouldNotWorkAndThrowException(uint index)
    {
        VkArray32<int> arr = new VkArray32<int>
        {
            M01 = 1,
            M02 = 2,
            M03 = 3,
            M04 = 4,
            M05 = 5,
            M06 = 6,
            M07 = 7,
            M08 = 8,
            M09 = 9,
            M10 = 10,
            M11 = 11,
            M12 = 12,
            M13 = 13,
            M14 = 14,
            M15 = 15,
            M16 = 16,
            M17 = 17,
            M18 = 18,
            M19 = 19,
            M20 = 20,
            M21 = 21,
            M22 = 22,
            M23 = 23,
            M24 = 24,
            M25 = 25,
            M26 = 26,
            M27 = 27,
            M28 = 28,
            M29 = 29,
            M30 = 30,
            M31 = 31,
            M32 = 32
        };
        Assert.ThrowsException<ArgumentOutOfRangeException>(

            // ReSharper disable once HeapView.DelegateAllocation
            () =>
            {
                arr[index] = 4;
            });
    }

    [DataTestMethod]
    [DataRow(45)]
    [DataRow(int.MaxValue)]
    [DataRow(int.MinValue)]
    [DataRow(785)]
    [DataRow(-785)]
    [DataRow(987787898)]

    // ReSharper disable once HeapView.ClosureAllocation
    public void VkArray32_InvalidIndexerInt_Set_ShouldNotWorkAndThrowException(int index)
    {
        VkArray32<int> arr = new VkArray32<int>
        {
            M01 = 1,
            M02 = 2,
            M03 = 3,
            M04 = 4,
            M05 = 5,
            M06 = 6,
            M07 = 7,
            M08 = 8,
            M09 = 9,
            M10 = 10,
            M11 = 11,
            M12 = 12,
            M13 = 13,
            M14 = 14,
            M15 = 15,
            M16 = 16,
            M17 = 17,
            M18 = 18,
            M19 = 19,
            M20 = 20,
            M21 = 21,
            M22 = 22,
            M23 = 23,
            M24 = 24,
            M25 = 25,
            M26 = 26,
            M27 = 27,
            M28 = 28,
            M29 = 29,
            M30 = 30,
            M31 = 31,
            M32 = 32
        };
        Assert.ThrowsException<ArgumentOutOfRangeException>(

            // ReSharper disable once HeapView.DelegateAllocation
            () =>
            {
                arr[index] = 4;
            });
    }
#endif
}

#pragma warning restore CS0219 // Variable is assigned but its value is never used
#pragma warning restore 168