// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wingdi.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public unsafe partial struct AXISINFOW
    {
        [NativeTypeName("LONG")]
        public int axMinValue;

        [NativeTypeName("LONG")]
        public int axMaxValue;

        [NativeTypeName("WCHAR [16]")]
        public fixed ushort axAxisName[16];
    }
}
