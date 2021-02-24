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
    public class VkStructsCustomVkVersionTests
    {
        [TestMethod]
        public void VkVersion_DefaultConstructor_ShouldCreate()
        {
            VkVersion version1 = new VkVersion();
            VkVersion version2;
        }

        [TestMethod]
        public void VkVersion_MajorMinorPatchConstructor_ShouldCreate()
        {
            VkVersion version = new VkVersion(1u, 1u, 1u);
        }

        [TestMethod]
        public void VkVersion_StaticVulkanApiVersions_ShouldMatch()
        {
            VkVersion version10 = new VkVersion(1u, 0u, 0u);
            VkVersion version11 = new VkVersion(1u, 1u, 0u);
            VkVersion version12 = new VkVersion(1u, 2u, 0u);

            Assert.AreEqual(version10, VkVersion.VulkanApiVersion10);
            Assert.AreEqual(version11, VkVersion.VulkanApiVersion11);
            Assert.AreEqual(version12, VkVersion.VulkanApiVersion12);
        }

        [TestMethod]
        public void VkVersion_ToString_ShouldWork()
        {
            string v10 = VkVersion.VulkanApiVersion10.ToString();
            string v11 = VkVersion.VulkanApiVersion11.ToString();
            string v12 = VkVersion.VulkanApiVersion12.ToString();
        }

        [DataTestMethod]
        [DataRow(1u,  0u, 0u)]
        [DataRow(78u, 8u, 9u)]
        [DataRow(0u,  0u, 0u)]
        [DataRow(2u,  1u, 1u)]
        [DataRow(1u,  0u, 451u)]
        [DataRow(7u,  8u, 8u)]
        [DataRow(1u,  1u, 2u)]
        public void VkVersion_ConstructWithValidMajorMinorPatchValues_GetMajorMinorPatchProperties_ShouldReturnExpectedValues(uint major, uint minor, uint patch)
        {
            VkVersion version = new VkVersion(major, minor, patch);
            Assert.AreEqual(major, version.Major);
            Assert.AreEqual(minor, version.Minor);
            Assert.AreEqual(patch, version.Patch);
        }

        [DataTestMethod]
        [DataRow(1u,  0u, uint.MaxValue)]
        [DataRow(78u, 8u, 4096u)]
        [DataRow(78u, 8u, 4789u)]
        [DataRow(0u,  0u, 45872u)]
        [DataRow(2u,  1u, 124558u)]
        [DataRow(1u,  0u, 4453453u)]
        public void VkVersion_ConstructWithValidMajorMinorValues_OverflowPatch_GetMajorMinorProperties_ShouldReturnExpectedValues(uint major, uint minor, uint patch)
        {
            VkVersion version = new VkVersion(major, minor, patch);
            Assert.AreEqual(major, version.Major);
            Assert.AreEqual(minor, version.Minor);

            Assert.AreNotEqual(patch, version.Patch);
        }

        [DataTestMethod]
        [DataRow(1u,  1024u,         0u)]
        [DataRow(78u, 4454u,         8u)]
        [DataRow(0u,  uint.MaxValue, 0u)]
        [DataRow(2u,  16458u,        1u)]
        [DataRow(1u,  15567425u,     0u)]
        public void VkVersion_ConstructWithValidMajorPatchValues_OverflowMinor_GetMajorPatchProperties_ShouldReturnExpectedValues(uint major, uint minor, uint patch)
        {
            VkVersion version = new VkVersion(major, minor, patch);
            Assert.AreEqual(major, version.Major);
            Assert.AreEqual(patch, version.Patch);

            Assert.AreNotEqual(minor, version.Minor);
        }

        [DataTestMethod]
        [DataRow(1u,  0u, 9u)]
        [DataRow(78u, 8u, 9u)]
        [DataRow(0u,  0u, 0u)]
        [DataRow(2u,  1u, 1u)]
        [DataRow(1u,  0u, 451u)]
        [DataRow(7u,  8u, 8u)]
        [DataRow(1u,  1u, 2u)]
        public void VkVersion_SameVkVersion_ShouldEqualOther_UsingEqualMethod(uint major, uint minor, uint patch)
        {
            VkVersion version1 = new VkVersion(major, minor, patch);
            VkVersion version2 = new VkVersion(major, minor, patch);

            Assert.AreEqual(version1, version2);
        }

        [DataTestMethod]
        [DataRow(1u,  0u, 9u)]
        [DataRow(78u, 8u, 9u)]
        [DataRow(0u,  0u, 0u)]
        [DataRow(2u,  1u, 1u)]
        [DataRow(1u,  0u, 451u)]
        [DataRow(7u,  8u, 8u)]
        [DataRow(1u,  1u, 2u)]
        public void VkVersion_DifferentVkVersion_ShouldNotEqual_UsingEqualMethod(uint major, uint minor, uint patch)
        {
            VkVersion version1 = new VkVersion(1u,    0u,    0u);
            VkVersion version2 = new VkVersion(major, minor, patch);

            Assert.AreNotEqual(version1, version2);
        }

        [DataTestMethod]
        [DataRow(1u,  0u, 0u)]
        [DataRow(78u, 8u, 9u)]
        [DataRow(0u,  0u, 0u)]
        [DataRow(2u,  1u, 1u)]
        [DataRow(1u,  0u, 451u)]
        [DataRow(7u,  8u, 8u)]
        [DataRow(1u,  1u, 2u)]
        public void VkVersion_GetHashCode_ShouldWork(uint major, uint minor, uint patch)
        {
            VkVersion version1 = new VkVersion(major, minor, patch);
            VkVersion version2 = new VkVersion(major, minor, patch);

            Assert.AreEqual(version1.GetHashCode(), version2.GetHashCode());
        }

        [DataTestMethod]
        [DataRow(1u,  0u, 0u)]
        [DataRow(78u, 8u, 9u)]
        [DataRow(0u,  0u, 0u)]
        [DataRow(2u,  1u, 1u)]
        [DataRow(1u,  0u, 451u)]
        [DataRow(7u,  8u, 8u)]
        [DataRow(1u,  1u, 2u)]
        public void VkVersion_SameVkVersion_ShouldEqualOther_UsingEqualOperator(uint major, uint minor, uint patch)
        {
            VkVersion version1 = new VkVersion(major, minor, patch);
            VkVersion version2 = new VkVersion(major, minor, patch);

            Assert.IsTrue(version1 == version2);
        }

        [DataTestMethod]
        [DataRow(1u,  0u, 9u)]
        [DataRow(78u, 8u, 9u)]
        [DataRow(0u,  0u, 0u)]
        [DataRow(2u,  1u, 1u)]
        [DataRow(1u,  0u, 451u)]
        [DataRow(7u,  8u, 8u)]
        [DataRow(1u,  1u, 2u)]
        public void VkVersion_DifferentVkVersion_ShouldNotEqualOther_UsingEqualOperator(uint major, uint minor, uint patch)
        {
            VkVersion version1 = new VkVersion(1u,    0u,    0u);
            VkVersion version2 = new VkVersion(major, minor, patch);

            Assert.IsFalse(version1 == version2);
        }

        [DataTestMethod]
        [DataRow(1u,  0u, 0u)]
        [DataRow(78u, 8u, 9u)]
        [DataRow(0u,  0u, 0u)]
        [DataRow(2u,  1u, 1u)]
        [DataRow(1u,  0u, 451u)]
        [DataRow(7u,  8u, 8u)]
        [DataRow(1u,  1u, 2u)]
        public void VkVersion_SameVkVersion_ShouldEqualOther_UsingNotEqualOperator(uint major, uint minor, uint patch)
        {
            VkVersion version1 = new VkVersion(major, minor, patch);
            VkVersion version2 = new VkVersion(major, minor, patch);

            Assert.IsFalse(version1 != version2);
        }

        [DataTestMethod]
        [DataRow(1u,  0u, 9u)]
        [DataRow(78u, 8u, 9u)]
        [DataRow(0u,  0u, 0u)]
        [DataRow(2u,  1u, 1u)]
        [DataRow(1u,  0u, 451u)]
        [DataRow(7u,  8u, 8u)]
        [DataRow(1u,  1u, 2u)]
        public void VkVersion_DifferentVkVersion_ShouldNotEqualOther_UsingNotEqualOperator(uint major, uint minor, uint patch)
        {
            VkVersion version1 = new VkVersion(1u,    0u,    0u);
            VkVersion version2 = new VkVersion(major, minor, patch);

            Assert.IsTrue(version1 != version2);
        }

        [DataTestMethod]
        [DataRow(1u,  0u, 9u)]
        [DataRow(78u, 8u, 9u)]
        [DataRow(2u,  1u, 1u)]
        [DataRow(1u,  0u, 451u)]
        [DataRow(7u,  8u, 8u)]
        [DataRow(1u,  1u, 2u)]
        public void VkVersion_GreaterVkVersion_ShouldReturnTrue_UsingGreaterOperator(uint major, uint minor, uint patch)
        {
            VkVersion version1 = new VkVersion(1u,    0u,    0u);
            VkVersion version2 = new VkVersion(major, minor, patch);

            Assert.IsTrue(version2 > version1);
        }

        [DataTestMethod]
        [DataRow(1u,  0u, 9u)]
        [DataRow(78u, 8u, 9u)]
        [DataRow(2u,  1u, 1u)]
        [DataRow(1u,  0u, 451u)]
        [DataRow(7u,  8u, 8u)]
        [DataRow(1u,  1u, 2u)]
        public void VkVersion_SmallerVkVersion_ShouldReturnFalse_UsingGreaterOperator(uint major, uint minor, uint patch)
        {
            VkVersion version1 = new VkVersion(1u,    0u,    0u);
            VkVersion version2 = new VkVersion(major, minor, patch);

            Assert.IsFalse(version1 > version2);
        }

        [DataTestMethod]
        [DataRow(1u,  0u, 9u)]
        [DataRow(78u, 8u, 9u)]
        [DataRow(2u,  1u, 1u)]
        [DataRow(1u,  0u, 451u)]
        [DataRow(7u,  8u, 8u)]
        [DataRow(1u,  1u, 2u)]
        public void VkVersion_SmallerVkVersion_ShouldReturnTrue_UsingSmallerOperator(uint major, uint minor, uint patch)
        {
            VkVersion version1 = new VkVersion(1u,    0u,    0u);
            VkVersion version2 = new VkVersion(major, minor, patch);

            Assert.IsTrue(version1 < version2);
        }

        [DataTestMethod]
        [DataRow(1u,  0u, 9u)]
        [DataRow(78u, 8u, 9u)]
        [DataRow(2u,  1u, 1u)]
        [DataRow(1u,  0u, 451u)]
        [DataRow(7u,  8u, 8u)]
        [DataRow(1u,  1u, 2u)]
        public void VkVersion_GreaterVkVersion_ShouldReturnFalse_UsingSmallerOperator(uint major, uint minor, uint patch)
        {
            VkVersion version1 = new VkVersion(1u,    0u,    0u);
            VkVersion version2 = new VkVersion(major, minor, patch);

            Assert.IsFalse(version2 < version1);
        }

        [DataTestMethod]
        [DataRow(1u, 0u, 0u)]
        [DataRow(1u, 0u, 1u)]
        public void VkVersion_GreaterOrEqualVkVersion_ShouldReturnTrue_UsingGreaterOrEqualOperator(uint major, uint minor, uint patch)
        {
            VkVersion version1 = new VkVersion(1u,    0u,    0u);
            VkVersion version2 = new VkVersion(major, minor, patch);

            Assert.IsTrue(version2 >= version1);
        }

        [DataTestMethod]
        [DataRow(1u, 0u, 8u)]
        [DataRow(1u, 0u, 1u)]
        public void VkVersion_SmallerVkVersion_ShouldReturnFalse_UsingGreaterOrEqualOperator(uint major, uint minor, uint patch)
        {
            VkVersion version1 = new VkVersion(1u,    0u,    0u);
            VkVersion version2 = new VkVersion(major, minor, patch);

            Assert.IsFalse(version1 >= version2);
        }

        [DataTestMethod]
        [DataRow(1u, 0u, 0u)]
        [DataRow(1u, 0u, 1u)]
        public void VkVersion_SmallerOrEqualVkVersion_ShouldReturnTrue_UsingSmallerOrEqualOperator(uint major, uint minor, uint patch)
        {
            VkVersion version1 = new VkVersion(1u,    0u,    0u);
            VkVersion version2 = new VkVersion(major, minor, patch);

            Assert.IsTrue(version1 <= version2);
        }

        [DataTestMethod]
        [DataRow(1u, 0u, 8u)]
        [DataRow(1u, 0u, 1u)]
        public void VkVersion_GreaterVkVersion_ShouldReturnFalse_UsingSmallerOrEqualOperator(uint major, uint minor, uint patch)
        {
            VkVersion version1 = new VkVersion(1u,    0u,    0u);
            VkVersion version2 = new VkVersion(major, minor, patch);

            Assert.IsFalse(version2 <= version1);
        }
    }
}

#pragma warning restore CS0219 // Variable is assigned but its value is never used
#pragma warning restore 168