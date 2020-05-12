// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/securitybaseapi.h in the Windows SDK for Windows 10.0.18362.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public static unsafe partial class Advapi32
    {
        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "AdjustTokenPrivileges", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int AdjustTokenPrivileges([NativeTypeName("HANDLE")] IntPtr TokenHandle, [NativeTypeName("BOOL")] int DisableAllPrivileges, [NativeTypeName("PTOKEN_PRIVILEGES")] TOKEN_PRIVILEGES* NewState, [NativeTypeName("DWORD")] uint BufferLength, [NativeTypeName("PTOKEN_PRIVILEGES")] TOKEN_PRIVILEGES* PreviousState, [NativeTypeName("PDWORD")] uint* ReturnLength);
    }
}
