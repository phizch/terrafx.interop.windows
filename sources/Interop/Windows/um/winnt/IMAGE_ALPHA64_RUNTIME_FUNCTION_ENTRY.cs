// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [StructLayout(LayoutKind.Sequential, Pack = 4)]
    public partial struct IMAGE_ALPHA64_RUNTIME_FUNCTION_ENTRY
    {
        [NativeTypeName("ULONGLONG")]
        public ulong BeginAddress;

        [NativeTypeName("ULONGLONG")]
        public ulong EndAddress;

        [NativeTypeName("ULONGLONG")]
        public ulong ExceptionHandler;

        [NativeTypeName("ULONGLONG")]
        public ulong HandlerData;

        [NativeTypeName("ULONGLONG")]
        public ulong PrologEndAddress;
    }
}
