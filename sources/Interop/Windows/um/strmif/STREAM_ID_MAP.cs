// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/strmif.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public partial struct STREAM_ID_MAP
    {
        [NativeTypeName("ULONG")]
        public uint stream_id;

        [NativeTypeName("DWORD")]
        public uint dwMediaSampleContent;

        [NativeTypeName("ULONG")]
        public uint ulSubstreamFilterValue;

        public int iDataOffset;
    }
}
