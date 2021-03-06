// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d12video.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="D3D12_FEATURE_DATA_VIDEO_DECODE_FORMATS" /> struct.</summary>
    public static unsafe class D3D12_FEATURE_DATA_VIDEO_DECODE_FORMATSTests
    {
        /// <summary>Validates that the <see cref="D3D12_FEATURE_DATA_VIDEO_DECODE_FORMATS" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<D3D12_FEATURE_DATA_VIDEO_DECODE_FORMATS>(), Is.EqualTo(sizeof(D3D12_FEATURE_DATA_VIDEO_DECODE_FORMATS)));
        }

        /// <summary>Validates that the <see cref="D3D12_FEATURE_DATA_VIDEO_DECODE_FORMATS" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(D3D12_FEATURE_DATA_VIDEO_DECODE_FORMATS).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="D3D12_FEATURE_DATA_VIDEO_DECODE_FORMATS" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            if (Environment.Is64BitProcess)
            {
                Assert.That(sizeof(D3D12_FEATURE_DATA_VIDEO_DECODE_FORMATS), Is.EqualTo(40));
            }
            else
            {
                Assert.That(sizeof(D3D12_FEATURE_DATA_VIDEO_DECODE_FORMATS), Is.EqualTo(36));
            }
        }
    }
}
