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
namespace Exomia.Vulkan.Api.Core.Tests
{
    [TestClass]
    public class VkStructsCustomVkArray16Tests
    {
        [TestMethod]
        public void VkArray16_DefaultConstructor_ShouldCreate()
        {
            VkArray16<int> arr1 = new VkArray16<int>();
            VkArray16<int> arr2;
        }

        [TestMethod]
        public void VkArray16_ValidIndexerUint_Set01To16_ShouldWorkAndNotThrowException()
        {
            VkArray16<uint> arr = new VkArray16<uint>();
            for (uint i = 0; i < VkArray16<int>.LENGTH; i++)
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
        }

        [TestMethod]
        public void VkArray16_ValidIndexerInt_Set01To16_ShouldWorkAndNotThrowException()
        {
            VkArray16<int> arr = new VkArray16<int>();
            for (int i = 0; i < VkArray16<int>.LENGTH; i++)
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
        }

        [TestMethod]
        public void VkArray16_ValidIndexerUint_Get01To16_ShouldWorkAndNotThrowException()
        {
            VkArray16<uint> arr = new VkArray16<uint>
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
                M16 = 16u
            };

            for (uint i = 0; i < VkArray16<int>.LENGTH; i++)
            {
                Assert.AreEqual(i + 1, arr[i]);
            }
        }

        [TestMethod]
        public void VkArray16_ValidIndexerInt_Get01To16_ShouldWorkAndNotThrowException()
        {
            VkArray16<int> arr = new VkArray16<int>
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
                M16 = 16
            };

            for (int i = 0; i < VkArray16<int>.LENGTH; i++)
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
        public void VkArray16_InvalidIndexerUint_Get_ShouldNotWorkAndThrowException(uint index)
        {
            VkArray16<int> arr = new VkArray16<int>
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
                M16 = 16
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
        public void VkArray16_InvalidIndexerInt_Get_ShouldNotWorkAndThrowException(int index)
        {
            VkArray16<int> arr = new VkArray16<int>
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
                M16 = 16
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
        public void VkArray16_InvalidIndexerUint_Set_ShouldNotWorkAndThrowException(uint index)
        {
            VkArray16<int> arr = new VkArray16<int>
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
                M16 = 16
            };
            Assert.ThrowsException<ArgumentOutOfRangeException>(

                // ReSharper disable once HeapView.DelegateAllocation
                () =>
                {
                    arr[index] = 5;
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
        public void VkArray16_InvalidIndexerInt_Set_ShouldNotWorkAndThrowException(int index)
        {
            VkArray16<int> arr = new VkArray16<int>
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
                M16 = 16
            };
            Assert.ThrowsException<ArgumentOutOfRangeException>(

                // ReSharper disable once HeapView.DelegateAllocation
                () =>
                {
                    arr[index] = 5;
                });
        }
#endif
    }
}

#pragma warning restore CS0219 // Variable is assigned but its value is never used
#pragma warning restore 168