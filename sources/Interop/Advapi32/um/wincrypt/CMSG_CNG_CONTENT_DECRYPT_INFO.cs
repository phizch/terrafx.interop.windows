// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wincrypt.h in the Windows SDK for Windows 10.0.18362.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct CMSG_CNG_CONTENT_DECRYPT_INFO
    {
        [NativeTypeName("DWORD")]
        public uint cbSize;

        public CRYPT_ALGORITHM_IDENTIFIER ContentEncryptionAlgorithm;

        [NativeTypeName("PFN_CMSG_ALLOC")]
        public IntPtr* pfnAlloc;

        [NativeTypeName("PFN_CMSG_FREE")]
        public IntPtr* pfnFree;

        [NativeTypeName("NCRYPT_KEY_HANDLE")]
        public UIntPtr hNCryptKey;

        [NativeTypeName("BYTE *")]
        public byte* pbContentEncryptKey;

        [NativeTypeName("DWORD")]
        public uint cbContentEncryptKey;

        [NativeTypeName("BCRYPT_KEY_HANDLE")]
        public void* hCNGContentEncryptKey;

        [NativeTypeName("BYTE *")]
        public byte* pbCNGContentEncryptKeyObject;
    }
}