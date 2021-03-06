// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="IMAGE_ENCLAVE_IMPORT" /> struct.</summary>
    public static unsafe class IMAGE_ENCLAVE_IMPORTTests
    {
        /// <summary>Validates that the <see cref="IMAGE_ENCLAVE_IMPORT" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<IMAGE_ENCLAVE_IMPORT>(), Is.EqualTo(sizeof(IMAGE_ENCLAVE_IMPORT)));
        }

        /// <summary>Validates that the <see cref="IMAGE_ENCLAVE_IMPORT" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(IMAGE_ENCLAVE_IMPORT).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="IMAGE_ENCLAVE_IMPORT" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            Assert.That(sizeof(IMAGE_ENCLAVE_IMPORT), Is.EqualTo(80));
        }
    }
}
