// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d12.h in the Windows SDK for Windows 10.0.18362.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public partial struct D3D12_BUFFER_SRV
    {
        [NativeTypeName("UINT64")]
        public ulong FirstElement;

        [NativeTypeName("UINT")]
        public uint NumElements;

        [NativeTypeName("UINT")]
        public uint StructureByteStride;

        public D3D12_BUFFER_SRV_FLAGS Flags;
    }
}