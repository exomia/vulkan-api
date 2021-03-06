﻿#region License

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
    public class VkStructsCustomVkColorTests
    {
        [TestMethod]
        public void VkColor_DefaultConstructor_ShouldCreate()
        {
            VkColor color1 = new VkColor();
            VkColor color2;
        }

        [TestMethod]
        public void VkColor_ValidIndexerUint_SetRGBA_ShouldWorkAndNotThrowException()
        {
            VkColor color = new VkColor { [0u] = 0.1f, [1u] = 0.2f, [2u] = 0.3f, [3u] = 0.4f };
            Assert.AreEqual(0.1f, color.R);
            Assert.AreEqual(0.2f, color.G);
            Assert.AreEqual(0.3f, color.B);
            Assert.AreEqual(0.4f, color.A);
        }

        [TestMethod]
        public void VkColor_ValidIndexerInt_SetRGBA_ShouldWorkAndNotThrowException()
        {
            VkColor color = new VkColor { [0] = 0.1f, [1] = 0.2f, [2] = 0.3f, [3] = 0.4f };
            Assert.AreEqual(0.1f, color.R);
            Assert.AreEqual(0.2f, color.G);
            Assert.AreEqual(0.3f, color.B);
            Assert.AreEqual(0.4f, color.A);
        }

        [TestMethod]
        public void VkColor_ValidIndexerUint_GetRGBA_ShouldWorkAndNotThrowException()
        {
            VkColor color = new VkColor { R = 0.1f, G = 0.2f, B = 0.3f, A = 0.4f };
            Assert.AreEqual(0.1f, color[0u]);
            Assert.AreEqual(0.2f, color[1u]);
            Assert.AreEqual(0.3f, color[2u]);
            Assert.AreEqual(0.4f, color[3u]);
        }

        [TestMethod]
        public void VkColor_ValidIndexerInt_GetRGBA_ShouldWorkAndNotThrowException()
        {
            VkColor color = new VkColor { R = 0.1f, G = 0.2f, B = 0.3f, A = 0.4f };
            Assert.AreEqual(0.1f, color[0]);
            Assert.AreEqual(0.2f, color[1]);
            Assert.AreEqual(0.3f, color[2]);
            Assert.AreEqual(0.4f, color[3]);
        }
#if DEBUG
        [DataTestMethod]
        [DataRow(7u)]
        [DataRow(5u)]
        [DataRow(45u)]
        [DataRow(uint.MaxValue)]
        [DataRow(785u)]
        [DataRow(987787898u)]

        // ReSharper disable once HeapView.ClosureAllocation
        public void VkColor_InvalidIndexerUint_Get_ShouldNotWorkAndThrowException(uint index)
        {
            VkColor color = new VkColor { R = 0.1f, G = 0.2f, B = 0.3f, A = 0.4f };
            Assert.ThrowsException<ArgumentOutOfRangeException>(

                // ReSharper disable once HeapView.DelegateAllocation
                () =>
                {
                    float value = color[index];
                });
        }

        [DataTestMethod]
        [DataRow(7)]
        [DataRow(5)]
        [DataRow(45)]
        [DataRow(int.MaxValue)]
        [DataRow(int.MinValue)]
        [DataRow(785)]
        [DataRow(-785)]
        [DataRow(987787898)]

        // ReSharper disable once HeapView.ClosureAllocation
        public void VkColor_InvalidIndexerInt_Get_ShouldNotWorkAndThrowException(int index)
        {
            VkColor color = new VkColor { R = 0.1f, G = 0.2f, B = 0.3f, A = 0.4f };
            Assert.ThrowsException<ArgumentOutOfRangeException>(

                // ReSharper disable once HeapView.DelegateAllocation
                () =>
                {
                    float value = color[index];
                });
        }

        [DataTestMethod]
        [DataRow(7u)]
        [DataRow(5u)]
        [DataRow(45u)]
        [DataRow(uint.MaxValue)]
        [DataRow(785u)]
        [DataRow(987787898u)]

        // ReSharper disable once HeapView.ClosureAllocation
        public void VkColor_InvalidIndexerUint_Set_ShouldNotWorkAndThrowException(uint index)
        {
            VkColor color = new VkColor { R = 0.1f, G = 0.2f, B = 0.3f, A = 0.4f };
            Assert.ThrowsException<ArgumentOutOfRangeException>(

                // ReSharper disable once HeapView.DelegateAllocation
                () =>
                {
                    color[index] = 0.5f;
                });
        }

        [DataTestMethod]
        [DataRow(7)]
        [DataRow(5)]
        [DataRow(45)]
        [DataRow(int.MaxValue)]
        [DataRow(int.MinValue)]
        [DataRow(785)]
        [DataRow(-785)]
        [DataRow(987787898)]

        // ReSharper disable once HeapView.ClosureAllocation
        public void VkColor_InvalidIndexerInt_Set_ShouldNotWorkAndThrowException(int index)
        {
            VkColor color = new VkColor { R = 0.1f, G = 0.2f, B = 0.3f, A = 0.4f };
            Assert.ThrowsException<ArgumentOutOfRangeException>(

                // ReSharper disable once HeapView.DelegateAllocation
                () =>
                {
                    color[index] = 0.5f;
                });
        }
#endif
    }
}

#pragma warning restore CS0219 // Variable is assigned but its value is never used
#pragma warning restore 168