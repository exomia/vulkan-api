#region License

// Copyright (c) 2018-2023, exomia
// All rights reserved.
// 
// This source code is licensed under the BSD-style license found in the
// LICENSE file in the root directory of this source tree.

#endregion

// ReSharper disable UnusedMember.Global
// ReSharper disable once CheckNamespace
namespace Exomia.Vulkan.Api.Core;

/// <summary>
///     A vk version.
/// </summary>
public readonly struct VkVersion
{
    /// <summary>
    ///     The version 1.0.
    /// </summary>
    public static readonly VkVersion VulkanApiVersion10 = new VkVersion(0, 1, 0, 0);

    /// <summary>
    ///     The version 1.1
    /// </summary>
    public static readonly VkVersion VulkanApiVersion11 = new VkVersion(0, 1, 1, 0);

    /// <summary>
    ///     The version 1.2
    /// </summary>
    public static readonly VkVersion VulkanApiVersion12 = new VkVersion(0, 1, 2, 0);

    /// <summary>
    ///     The version 1.3
    /// </summary>
    public static readonly VkVersion VulkanApiVersion13 = new VkVersion(0, 1, 3, 0);

    private readonly uint _version;

    /// <summary>
    ///     Gets the major.
    /// </summary>
    /// <value>
    ///     The major.
    /// </value>
    public uint Variant
    {
        get { return _version >> 29; }
    }

    /// <summary>
    ///     Gets the major.
    /// </summary>
    /// <value>
    ///     The major.
    /// </value>
    public uint Major
    {
        get { return (_version >> 22) & 0x7FU; }
    }

    /// <summary>
    ///     Gets the minor.
    /// </summary>
    /// <value>
    ///     The minor.
    /// </value>
    public uint Minor
    {
        get { return (_version >> 12) & 0x3FF; }
    }

    /// <summary>
    ///     Gets the patch.
    /// </summary>
    /// <value>
    ///     The patch.
    /// </value>
    public uint Patch
    {
        get { return _version & 0xFFF; }
    }

    /// <summary>
    ///     Initializes a new instance of the <see cref="VkVersion" /> struct.
    /// </summary>
    /// <param name="variant"> The variant. </param>
    /// <param name="major"> The major. </param>
    /// <param name="minor"> The minor. </param>
    /// <param name="patch"> The patch. </param>
    public VkVersion(uint variant, uint major, uint minor, uint patch)
        : this((variant << 29) | ((major & 0x7FU) << 22) | ((minor & 0x3FFU) << 12) | (patch & 0xFFFU)) { }

    internal VkVersion(uint version)
    {
        _version = version;
    }

    /// <inheritdoc />
    public override int GetHashCode()
    {
        return (int)_version;
    }

    /// <summary>
    ///     Tests if this VkVersion is considered equal to another.
    /// </summary>
    /// <param name="other"> The vk version to compare to this object. </param>
    /// <returns>
    ///     True if the objects are considered equal, false if they are not.
    /// </returns>
    public bool Equals(VkVersion other)
    {
        return _version == other._version;
    }

    /// <inheritdoc />
    public override bool Equals(object? obj)
    {
        return obj is VkVersion other && Equals(other);
    }

    /// <inheritdoc />
    public override string ToString()
    {
        return $"{Major.ToString()}.{Minor.ToString()}.{Patch.ToString()}";
    }

    /// <summary>
    ///     Equality operator.
    /// </summary>
    /// <param name="a"> The first instance to compare. </param>
    /// <param name="b"> The second instance to compare. </param>
    /// <returns>
    ///     The result of the operation.
    /// </returns>
    public static bool operator ==(VkVersion a, VkVersion b)
    {
        return a._version == b._version;
    }

    /// <summary>
    ///     Inequality operator.
    /// </summary>
    /// <param name="a"> The first instance to compare. </param>
    /// <param name="b"> The second instance to compare. </param>
    /// <returns>
    ///     The result of the operation.
    /// </returns>
    public static bool operator !=(VkVersion a, VkVersion b)
    {
        return a._version != b._version;
    }

    /// <summary>
    ///     Less-than comparison operator.
    /// </summary>
    /// <param name="a"> The first instance to compare. </param>
    /// <param name="b"> The second instance to compare. </param>
    /// <returns>
    ///     The result of the operation.
    /// </returns>
    public static bool operator <(VkVersion a, VkVersion b)
    {
        return a._version < b._version;
    }

    /// <summary>
    ///     Greater-than comparison operator.
    /// </summary>
    /// <param name="a"> The first instance to compare. </param>
    /// <param name="b"> The second instance to compare. </param>
    /// <returns>
    ///     The result of the operation.
    /// </returns>
    public static bool operator >(VkVersion a, VkVersion b)
    {
        return a._version > b._version;
    }

    /// <summary>
    ///     Less-than-or-equal comparison operator.
    /// </summary>
    /// <param name="a"> The first instance to compare. </param>
    /// <param name="b"> The second instance to compare. </param>
    /// <returns>
    ///     The result of the operation.
    /// </returns>
    public static bool operator <=(VkVersion a, VkVersion b)
    {
        return a._version <= b._version;
    }

    /// <summary>
    ///     Greater-than-or-equal comparison operator.
    /// </summary>
    /// <param name="a"> The first instance to compare. </param>
    /// <param name="b"> The second instance to compare. </param>
    /// <returns>
    ///     The result of the operation.
    /// </returns>
    public static bool operator >=(VkVersion a, VkVersion b)
    {
        return a._version >= b._version;
    }

    /// <summary>
    ///     Equality operator.
    /// </summary>
    /// <param name="a"> The first instance to compare. </param>
    /// <param name="b"> The second instance to compare. </param>
    /// <returns>
    ///     The result of the operation.
    /// </returns>
    public static bool operator ==(VkVersion a, uint b)
    {
        return a._version == b;
    }

    /// <summary>
    ///     Inequality operator.
    /// </summary>
    /// <param name="a"> The first instance to compare. </param>
    /// <param name="b"> The second instance to compare. </param>
    /// <returns>
    ///     The result of the operation.
    /// </returns>
    public static bool operator !=(VkVersion a, uint b)
    {
        return a._version != b;
    }

    /// <summary>
    ///     Less-than comparison operator.
    /// </summary>
    /// <param name="a"> The first instance to compare. </param>
    /// <param name="b"> The second instance to compare. </param>
    /// <returns>
    ///     The result of the operation.
    /// </returns>
    public static bool operator <(VkVersion a, uint b)
    {
        return a._version < b;
    }

    /// <summary>
    ///     Greater-than comparison operator.
    /// </summary>
    /// <param name="a"> The first instance to compare. </param>
    /// <param name="b"> The second instance to compare. </param>
    /// <returns>
    ///     The result of the operation.
    /// </returns>
    public static bool operator >(VkVersion a, uint b)
    {
        return a._version > b;
    }

    /// <summary>
    ///     Less-than-or-equal comparison operator.
    /// </summary>
    /// <param name="a"> The first instance to compare. </param>
    /// <param name="b"> The second instance to compare. </param>
    /// <returns>
    ///     The result of the operation.
    /// </returns>
    public static bool operator <=(VkVersion a, uint b)
    {
        return a._version <= b;
    }

    /// <summary>
    ///     Greater-than-or-equal comparison operator.
    /// </summary>
    /// <param name="a"> The first instance to compare. </param>
    /// <param name="b"> The second instance to compare. </param>
    /// <returns>
    ///     The result of the operation.
    /// </returns>
    public static bool operator >=(VkVersion a, uint b)
    {
        return a._version >= b;
    }

    /// <summary> Implicit cast that converts the given uint to a VkVersion. </summary>
    /// <param name="version"> The version. </param>
    /// <returns> The result of the operation. </returns>
    public static implicit operator VkVersion(uint version)
    {
        return new VkVersion(version);
    }

    /// <summary> Implicit cast that converts the given VkVersion to a uint. </summary>
    /// <param name="version"> The version. </param>
    /// <returns> The result of the operation. </returns>
    public static implicit operator uint(VkVersion version)
    {
        return version._version;
    }
}