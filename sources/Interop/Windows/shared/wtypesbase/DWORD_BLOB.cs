// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/wtypesbase.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public unsafe partial struct DWORD_BLOB
    {
        [NativeTypeName("ULONG")]
        public uint clSize;

        [NativeTypeName("ULONG [1]")]
        public fixed uint alData[1];
    }
}
