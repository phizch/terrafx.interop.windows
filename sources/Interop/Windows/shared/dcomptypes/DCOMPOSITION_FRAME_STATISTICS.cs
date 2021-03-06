// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/dcomptypes.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public partial struct DCOMPOSITION_FRAME_STATISTICS
    {
        public LARGE_INTEGER lastFrameTime;

        public DXGI_RATIONAL currentCompositionRate;

        public LARGE_INTEGER currentTime;

        public LARGE_INTEGER timeFrequency;

        public LARGE_INTEGER nextEstimatedFrameTime;
    }
}
