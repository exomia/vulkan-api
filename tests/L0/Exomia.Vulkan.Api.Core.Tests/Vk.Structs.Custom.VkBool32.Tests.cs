#region License

// Copyright (c) 2018-2021, exomia
// All rights reserved.
// 
// This source code is licensed under the BSD-style license found in the
// LICENSE file in the root directory of this source tree.

#endregion

using Microsoft.VisualStudio.TestTools.UnitTesting;

#pragma warning disable 168
#pragma warning disable CS0219 // Variable is assigned but its value is never used

// ReSharper disable UnusedVariable
namespace Exomia.Vulkan.Api.Core.Tests
{
    [TestClass]
    public class VkStructsCustomVkBool32Tests
    {
        [TestMethod]
        public void VkBool32_DefaultConstructor_ShouldCreate()
        {
            VkBool32 value1 = new VkBool32();
            VkBool32 value2;
        }

        [DataTestMethod]
        [DataRow(0u)]
        [DataRow(1u)]
        [DataRow(45u)]
        [DataRow(uint.MaxValue)]
        [DataRow(785u)]
        [DataRow(987787898u)]
        public void VkBool32_ImplicitOperator_FromUint32_ShouldWorkAndNotThrowException(uint value)
        {
            VkBool32 bool32 = value;
        }

        [DataTestMethod]
        [DataRow(0u)]
        [DataRow(1u)]
        [DataRow(45u)]
        [DataRow(uint.MaxValue)]
        [DataRow(785u)]
        [DataRow(987787898u)]
        public void VkBool32_ImplicitOperator_ToUint32_ShouldWorkAndNotThrowException(uint value)
        {
            VkBool32 bool32 = value;
            uint     v      = bool32;
            Assert.AreEqual(value, v);
        }

        [DataTestMethod]
        [DataRow(0u)]
        [DataRow(1u)]
        [DataRow(45u)]
        [DataRow(uint.MaxValue)]
        [DataRow(785u)]
        [DataRow(987787898u)]
        public void VkBool32_ImplicitOperator_FromUint32ToBool_ShouldWorkAndNotThrowException(uint value)
        {
            VkBool32 bool32 = value;
            bool     v      = bool32;
        }

        [TestMethod]
        public void VkBool32_ImplicitOperator_FromBool_ShouldWorkAndNotThrowException()
        {
            VkBool32 bool32_t = true;
            VkBool32 bool32_f = false;
        }

        [TestMethod]
        public void VkBool32_ImplicitOperator_FromBoolToBool_ShouldWorkAndNotThrowException()
        {
            VkBool32 valueT = true;
            VkBool32 valueF = false;

            bool vt = valueT;
            bool vf = valueF;

            Assert.AreEqual(true,  vt);
            Assert.AreEqual(false, vf);
        }

        [DataTestMethod]
        [DataRow(1u)]
        [DataRow(Vk.VK_TRUE)]
        [DataRow(45u)]
        [DataRow(uint.MaxValue)]
        [DataRow(785u)]
        [DataRow(987787898u)]
        public void VkBool32_TruthyValues_ShouldBeTrue_UsingImplicitOperatorToBool(uint value)
        {
            VkBool32 bool32 = value;

            Assert.IsTrue(bool32);
        }

        [DataTestMethod]
        [DataRow(0u)]
        [DataRow(Vk.VK_FALSE)]
        public void VkBool32_FalsyValues_ShouldBeFalse_UsingImplicitOperatorToBool(uint value)
        {
            VkBool32 bool32 = value;

            Assert.IsFalse(bool32);
        }
    }
}

#pragma warning restore CS0219 // Variable is assigned but its value is never used
#pragma warning restore 168