// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [StructLayout(LayoutKind.Explicit)]
    public unsafe partial struct FILE_SEGMENT_ELEMENT
    {
        [FieldOffset(0)]
        [NativeTypeName("PVOID64")]
        public void* Buffer;

        [FieldOffset(0)]
        [NativeTypeName("ULONGLONG")]
        public ulong Alignment;
    }
}
