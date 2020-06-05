// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="IMAGE_SYMBOL" /> struct.</summary>
    public static unsafe class IMAGE_SYMBOLTests
    {
        /// <summary>Validates that the <see cref="IMAGE_SYMBOL" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<IMAGE_SYMBOL>(), Is.EqualTo(sizeof(IMAGE_SYMBOL)));
        }

        /// <summary>Validates that the <see cref="IMAGE_SYMBOL" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(IMAGE_SYMBOL).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="IMAGE_SYMBOL" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            Assert.That(sizeof(IMAGE_SYMBOL), Is.EqualTo(18));
        }
    }
}