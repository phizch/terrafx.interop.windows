// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/combaseapi.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop
{
    [Flags]
    public enum COWAIT_FLAGS
    {
        COWAIT_DEFAULT = 0,
        COWAIT_WAITALL = 1,
        COWAIT_ALERTABLE = 2,
        COWAIT_INPUTAVAILABLE = 4,
        COWAIT_DISPATCH_CALLS = 8,
        COWAIT_DISPATCH_WINDOW_MESSAGES = 0x10,
    }
}
