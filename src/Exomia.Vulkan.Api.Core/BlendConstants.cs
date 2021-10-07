#region License

// Copyright (c) 2018-2021, exomia
// All rights reserved.
// 
// This source code is licensed under the BSD-style license found in the
// LICENSE file in the root directory of this source tree.

#endregion

using System.Runtime.InteropServices;

namespace Exomia.Vulkan.Api.Core
{
    /// <summary>
    ///     Used instead of public fixed float blendConstants[4].
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct BlendConstants
    {
        /// <summary>
        ///     The R value
        /// </summary>
        public float R;

        /// <summary>
        ///     The G value
        /// </summary>
        public float G;

        /// <summary>
        ///     The B value
        /// </summary>
        public float B;

        /// <summary>
        ///     The A value
        /// </summary>
        public float A;
    }
}