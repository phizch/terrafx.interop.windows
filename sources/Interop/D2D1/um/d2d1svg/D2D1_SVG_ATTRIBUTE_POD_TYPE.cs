// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d2d1svg.h in the Windows SDK for Windows 10.0.18362.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    [NativeTypeName("int")]
    public enum D2D1_SVG_ATTRIBUTE_POD_TYPE : uint
    {
        D2D1_SVG_ATTRIBUTE_POD_TYPE_FLOAT = 0,
        D2D1_SVG_ATTRIBUTE_POD_TYPE_COLOR = 1,
        D2D1_SVG_ATTRIBUTE_POD_TYPE_FILL_MODE = 2,
        D2D1_SVG_ATTRIBUTE_POD_TYPE_DISPLAY = 3,
        D2D1_SVG_ATTRIBUTE_POD_TYPE_OVERFLOW = 4,
        D2D1_SVG_ATTRIBUTE_POD_TYPE_LINE_CAP = 5,
        D2D1_SVG_ATTRIBUTE_POD_TYPE_LINE_JOIN = 6,
        D2D1_SVG_ATTRIBUTE_POD_TYPE_VISIBILITY = 7,
        D2D1_SVG_ATTRIBUTE_POD_TYPE_MATRIX = 8,
        D2D1_SVG_ATTRIBUTE_POD_TYPE_UNIT_TYPE = 9,
        D2D1_SVG_ATTRIBUTE_POD_TYPE_EXTEND_MODE = 10,
        D2D1_SVG_ATTRIBUTE_POD_TYPE_PRESERVE_ASPECT_RATIO = 11,
        D2D1_SVG_ATTRIBUTE_POD_TYPE_VIEWBOX = 12,
        D2D1_SVG_ATTRIBUTE_POD_TYPE_LENGTH = 13,
        D2D1_SVG_ATTRIBUTE_POD_TYPE_FORCE_DWORD = 0xffffffff,
    }
}