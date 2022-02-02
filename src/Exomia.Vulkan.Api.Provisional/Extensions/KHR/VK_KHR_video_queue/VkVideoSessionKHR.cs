// ReSharper disable UnusedMember.Global
// ReSharper disable once CheckNamespace
namespace Exomia.Vulkan.Api.Provisional;

/// <summary> VkVideoSessionKHR - Opaque handle to a video session object - <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkVideoSessionKHR.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkVideoSessionKHR.html</a> </summary>
public readonly unsafe struct VkVideoSessionKHR
{
    /// <summary> The null value. </summary>
    public static readonly VkVideoSessionKHR Null = (VkVideoSessionKHR)null;
#pragma warning disable 649
    private readonly void* _ptr;
#pragma warning restore 649

    /// <summary> Explicit cast that converts the given void* to a VkVideoSessionKHR. </summary>
    /// <param name="ptr"> [in,out] If non-null, the pointer. </param>
    /// <returns> The result of the operation. </returns>
    public static explicit operator VkVideoSessionKHR(void* ptr)
    {
        VkVideoSessionKHR value;
        *(void**)&value = ptr;
        return value;
    }

    /// <summary> Equality operator. </summary>
    /// <param name="left">  The left. </param>
    /// <param name="right"> The right. </param>
    /// <returns> The result of the operation. </returns>
    public static bool operator ==(VkVideoSessionKHR left, VkVideoSessionKHR right)
    {
        return left._ptr == right._ptr;
    }

    /// <summary> Inequality operator. </summary>
    /// <param name="left">  The left. </param>
    /// <param name="right"> The right. </param>
    /// <returns> The result of the operation. </returns>
    public static bool operator !=(VkVideoSessionKHR left, VkVideoSessionKHR right)
    {
        return left._ptr != right._ptr;
    }

    /// <summary> Tests if this in VkVideoSessionKHR is considered equal to this instance. </summary>
    /// <param name="obj"> The in VkVideoSessionKHR to compare to this instance. </param>
    /// <returns> True if the objects are considered equal, false if they are not. </returns>
    public bool Equals(in VkVideoSessionKHR obj)
    {
        return obj._ptr == _ptr;
    }

    /// <summary> Tests if the object is considered equal to this instance. </summary>
    /// <param name="obj"> The object to compare to this instance. </param>
    /// <returns> True if the objects are considered equal, false if they are not. </returns>
    public override bool Equals(object? obj)
    {
        return obj is VkVideoSessionKHR vkVideoSessionKHR && Equals(in vkVideoSessionKHR);
    }

    /// <summary> Returns a hash code for this object. </summary>
    /// <returns> A hash code for this object. </returns>
    public override int GetHashCode()
    {
        return ((IntPtr)_ptr).GetHashCode();
    }

    /// <summary> Explicit cast that converts the given VkVideoSessionKHR to a void*. </summary>
    /// <param name="value"> The value. </param>
    /// <returns> The result of the operation. </returns>
    public static explicit operator void*(VkVideoSessionKHR value)
    {
        return value._ptr;
    }
}