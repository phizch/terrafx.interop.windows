// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfmediaengine.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop
{
    public static partial class Windows
    {
        [NativeTypeName("const IID")]
        public static readonly Guid MF_MSE_CALLBACK = new Guid(0x9063a7c0, 0x42c5, 0x4ffd, 0xa8, 0xa8, 0x6f, 0xcf, 0x9e, 0xa3, 0xd0, 0x0c);

        [NativeTypeName("const IID")]
        public static readonly Guid MF_MSE_ACTIVELIST_CALLBACK = new Guid(0x949bda0f, 0x4549, 0x46d5, 0xad, 0x7f, 0xb8, 0x46, 0xe1, 0xab, 0x16, 0x52);

        [NativeTypeName("const IID")]
        public static readonly Guid MF_MSE_BUFFERLIST_CALLBACK = new Guid(0x42e669b0, 0xd60e, 0x4afb, 0xa8, 0x5b, 0xd8, 0xe5, 0xfe, 0x6b, 0xda, 0xb5);

        [NativeTypeName("const IID")]
        public static readonly Guid MF_MSE_VP9_SUPPORT = new Guid(0x92d78429, 0xd88b, 0x4ff0, 0x83, 0x22, 0x80, 0x3e, 0xfa, 0x6e, 0x96, 0x26);

        [NativeTypeName("const IID")]
        public static readonly Guid MF_MSE_OPUS_SUPPORT = new Guid(0x4d224cc1, 0x8cc4, 0x48a3, 0xa7, 0xa7, 0xe4, 0xc1, 0x6c, 0xe6, 0x38, 0x8a);

        [NativeTypeName("const IID")]
        public static readonly Guid MF_MEDIA_ENGINE_NEEDKEY_CALLBACK = new Guid(0x7ea80843, 0xb6e4, 0x432c, 0x8e, 0xa4, 0x78, 0x48, 0xff, 0xe4, 0x22, 0x0e);

        [NativeTypeName("const IID")]
        public static readonly Guid MF_MEDIA_ENGINE_CALLBACK = new Guid(0xc60381b8, 0x83a4, 0x41f8, 0xa3, 0xd0, 0xde, 0x05, 0x07, 0x68, 0x49, 0xa9);

        [NativeTypeName("const IID")]
        public static readonly Guid MF_MEDIA_ENGINE_DXGI_MANAGER = new Guid(0x065702da, 0x1094, 0x486d, 0x86, 0x17, 0xee, 0x7c, 0xc4, 0xee, 0x46, 0x48);

        [NativeTypeName("const IID")]
        public static readonly Guid MF_MEDIA_ENGINE_EXTENSION = new Guid(0x3109fd46, 0x060d, 0x4b62, 0x8d, 0xcf, 0xfa, 0xff, 0x81, 0x13, 0x18, 0xd2);

        [NativeTypeName("const IID")]
        public static readonly Guid MF_MEDIA_ENGINE_PLAYBACK_HWND = new Guid(0xd988879b, 0x67c9, 0x4d92, 0xba, 0xa7, 0x6e, 0xad, 0xd4, 0x46, 0x03, 0x9d);

        [NativeTypeName("const IID")]
        public static readonly Guid MF_MEDIA_ENGINE_OPM_HWND = new Guid(0xa0be8ee7, 0x0572, 0x4f2c, 0xa8, 0x01, 0x2a, 0x15, 0x1b, 0xd3, 0xe7, 0x26);

        [NativeTypeName("const IID")]
        public static readonly Guid MF_MEDIA_ENGINE_PLAYBACK_VISUAL = new Guid(0x6debd26f, 0x6ab9, 0x4d7e, 0xb0, 0xee, 0xc6, 0x1a, 0x73, 0xff, 0xad, 0x15);

        [NativeTypeName("const IID")]
        public static readonly Guid MF_MEDIA_ENGINE_COREWINDOW = new Guid(0xfccae4dc, 0x0b7f, 0x41c2, 0x9f, 0x96, 0x46, 0x59, 0x94, 0x8a, 0xcd, 0xdc);

        [NativeTypeName("const IID")]
        public static readonly Guid MF_MEDIA_ENGINE_VIDEO_OUTPUT_FORMAT = new Guid(0x5066893c, 0x8cf9, 0x42bc, 0x8b, 0x8a, 0x47, 0x22, 0x12, 0xe5, 0x27, 0x26);

        [NativeTypeName("const IID")]
        public static readonly Guid MF_MEDIA_ENGINE_CONTENT_PROTECTION_FLAGS = new Guid(0xe0350223, 0x5aaf, 0x4d76, 0xa7, 0xc3, 0x06, 0xde, 0x70, 0x89, 0x4d, 0xb4);

        [NativeTypeName("const IID")]
        public static readonly Guid MF_MEDIA_ENGINE_CONTENT_PROTECTION_MANAGER = new Guid(0xfdd6dfaa, 0xbd85, 0x4af3, 0x9e, 0x0f, 0xa0, 0x1d, 0x53, 0x9d, 0x87, 0x6a);

        [NativeTypeName("const IID")]
        public static readonly Guid MF_MEDIA_ENGINE_AUDIO_ENDPOINT_ROLE = new Guid(0xd2cb93d1, 0x116a, 0x44f2, 0x93, 0x85, 0xf7, 0xd0, 0xfd, 0xa2, 0xfb, 0x46);

        [NativeTypeName("const IID")]
        public static readonly Guid MF_MEDIA_ENGINE_AUDIO_CATEGORY = new Guid(0xc8d4c51d, 0x350e, 0x41f2, 0xba, 0x46, 0xfa, 0xeb, 0xbb, 0x08, 0x57, 0xf6);

        [NativeTypeName("const IID")]
        public static readonly Guid MF_MEDIA_ENGINE_STREAM_CONTAINS_ALPHA_CHANNEL = new Guid(0x5cbfaf44, 0xd2b2, 0x4cfb, 0x80, 0xa7, 0xd4, 0x29, 0xc7, 0x4c, 0x78, 0x9d);

        [NativeTypeName("const IID")]
        public static readonly Guid MF_MEDIA_ENGINE_BROWSER_COMPATIBILITY_MODE = new Guid(0x4e0212e2, 0xe18f, 0x41e1, 0x95, 0xe5, 0xc0, 0xe7, 0xe9, 0x23, 0x5b, 0xc3);

        [NativeTypeName("const IID")]
        public static readonly Guid MF_MEDIA_ENGINE_BROWSER_COMPATIBILITY_MODE_IE9 = new Guid(0x052c2d39, 0x40c0, 0x4188, 0xab, 0x86, 0xf8, 0x28, 0x27, 0x3b, 0x75, 0x22);

        [NativeTypeName("const IID")]
        public static readonly Guid MF_MEDIA_ENGINE_BROWSER_COMPATIBILITY_MODE_IE10 = new Guid(0x11a47afd, 0x6589, 0x4124, 0xb3, 0x12, 0x61, 0x58, 0xec, 0x51, 0x7f, 0xc3);

        [NativeTypeName("const IID")]
        public static readonly Guid MF_MEDIA_ENGINE_BROWSER_COMPATIBILITY_MODE_IE11 = new Guid(0x1cf1315f, 0xce3f, 0x4035, 0x93, 0x91, 0x16, 0x14, 0x2f, 0x77, 0x51, 0x89);

        [NativeTypeName("const IID")]
        public static readonly Guid MF_MEDIA_ENGINE_BROWSER_COMPATIBILITY_MODE_IE_EDGE = new Guid(0xa6f3e465, 0x3aca, 0x442c, 0xa3, 0xf0, 0xad, 0x6d, 0xda, 0xd8, 0x39, 0xae);

        [NativeTypeName("const IID")]
        public static readonly Guid MF_MEDIA_ENGINE_COMPATIBILITY_MODE = new Guid(0x3ef26ad4, 0xdc54, 0x45de, 0xb9, 0xaf, 0x76, 0xc8, 0xc6, 0x6b, 0xfa, 0x8e);

        [NativeTypeName("const IID")]
        public static readonly Guid MF_MEDIA_ENGINE_COMPATIBILITY_MODE_WWA_EDGE = new Guid(0x15b29098, 0x9f01, 0x4e4d, 0xb6, 0x5a, 0xc0, 0x6c, 0x6c, 0x89, 0xda, 0x2a);

        [NativeTypeName("const IID")]
        public static readonly Guid MF_MEDIA_ENGINE_COMPATIBILITY_MODE_WIN10 = new Guid(0x5b25e089, 0x6ca7, 0x4139, 0xa2, 0xcb, 0xfc, 0xaa, 0xb3, 0x95, 0x52, 0xa3);

        [NativeTypeName("const IID")]
        public static readonly Guid MF_MEDIA_ENGINE_SOURCE_RESOLVER_CONFIG_STORE = new Guid(0x0ac0c497, 0xb3c4, 0x48c9, 0x9c, 0xde, 0xbb, 0x8c, 0xa2, 0x44, 0x2c, 0xa3);

        [NativeTypeName("const IID")]
        public static readonly Guid MF_MEDIA_ENGINE_TRACK_ID = new Guid(0x65bea312, 0x4043, 0x4815, 0x8e, 0xab, 0x44, 0xdc, 0xe2, 0xef, 0x8f, 0x2a);

        [NativeTypeName("const IID")]
        public static readonly Guid MF_MEDIA_ENGINE_TELEMETRY_APPLICATION_ID = new Guid(0x1e7b273b, 0xa7e4, 0x402a, 0x8f, 0x51, 0xc4, 0x8e, 0x88, 0xa2, 0xca, 0xbc);

        [NativeTypeName("const IID")]
        public static readonly Guid MF_MEDIA_ENGINE_SYNCHRONOUS_CLOSE = new Guid(0xc3c2e12f, 0x7e0e, 0x4e43, 0xb9, 0x1c, 0xdc, 0x99, 0x2c, 0xcd, 0xfa, 0x5e);

        [NativeTypeName("const IID")]
        public static readonly Guid MF_MEDIA_ENGINE_MEDIA_PLAYER_MODE = new Guid(0x3ddd8d45, 0x5aa1, 0x4112, 0x82, 0xe5, 0x36, 0xf6, 0xa2, 0x19, 0x7e, 0x6e);

        [NativeTypeName("const IID")]
        public static readonly Guid CLSID_MFMediaEngineClassFactory = new Guid(0xb44392da, 0x499b, 0x446b, 0xa4, 0xcb, 0x0, 0x5f, 0xea, 0xd0, 0xe6, 0xd5);

        [NativeTypeName("const IID")]
        public static readonly Guid MF_MEDIA_ENGINE_TIMEDTEXT = new Guid(0x805ea411, 0x92e0, 0x4e59, 0x9b, 0x6e, 0x5c, 0x7d, 0x79, 0x15, 0xe6, 0x4f);

        [NativeTypeName("const IID")]
        public static readonly Guid MF_MEDIA_ENGINE_CONTINUE_ON_CODEC_ERROR = new Guid(0xdbcdb7f9, 0x48e4, 0x4295, 0xb7, 0x0d, 0xd5, 0x18, 0x23, 0x4e, 0xeb, 0x38);

        [NativeTypeName("const IID")]
        public static readonly Guid MF_MEDIA_ENGINE_EME_CALLBACK = new Guid(0x494553a7, 0xa481, 0x4cb7, 0xbe, 0xc5, 0x38, 0x09, 0x03, 0x51, 0x37, 0x31);

        [NativeTypeName("const PROPERTYKEY")]
        public static readonly PROPERTYKEY MF_EME_INITDATATYPES = new PROPERTYKEY
        {
            fmtid = new Guid(0x497d231b, 0x4eb9, 0x4df0, 0xb4, 0x74, 0xb9, 0xaf, 0xeb, 0x0a, 0xdf, 0x38),
            pid = (0x2) + 0x00000001,
        };

        [NativeTypeName("const PROPERTYKEY")]
        public static readonly PROPERTYKEY MF_EME_DISTINCTIVEID = new PROPERTYKEY
        {
            fmtid = new Guid(0x7dc9c4a5, 0x12be, 0x497e, 0x8b, 0xff, 0x9b, 0x60, 0xb2, 0xdc, 0x58, 0x45),
            pid = (0x2) + 0x00000002,
        };

        [NativeTypeName("const PROPERTYKEY")]
        public static readonly PROPERTYKEY MF_EME_PERSISTEDSTATE = new PROPERTYKEY
        {
            fmtid = new Guid(0x5d4df6ae, 0x9af1, 0x4e3d, 0x95, 0x5b, 0x0e, 0x4b, 0xd2, 0x2f, 0xed, 0xf0),
            pid = (0x2) + 0x00000003,
        };

        [NativeTypeName("const PROPERTYKEY")]
        public static readonly PROPERTYKEY MF_EME_AUDIOCAPABILITIES = new PROPERTYKEY
        {
            fmtid = new Guid(0x980fbb84, 0x297d, 0x4ea7, 0x89, 0x5f, 0xbc, 0xf2, 0x8a, 0x46, 0x28, 0x81),
            pid = (0x2) + 0x00000004,
        };

        [NativeTypeName("const PROPERTYKEY")]
        public static readonly PROPERTYKEY MF_EME_VIDEOCAPABILITIES = new PROPERTYKEY
        {
            fmtid = new Guid(0xb172f83d, 0x30dd, 0x4c10, 0x80, 0x06, 0xed, 0x53, 0xda, 0x4d, 0x3b, 0xdb),
            pid = (0x2) + 0x00000005,
        };

        [NativeTypeName("const PROPERTYKEY")]
        public static readonly PROPERTYKEY MF_EME_LABEL = new PROPERTYKEY
        {
            fmtid = new Guid(0x9eae270e, 0xb2d7, 0x4817, 0xb8, 0x8f, 0x54, 0x00, 0x99, 0xf2, 0xef, 0x4e),
            pid = (0x2) + 0x00000006,
        };

        [NativeTypeName("const PROPERTYKEY")]
        public static readonly PROPERTYKEY MF_EME_SESSIONTYPES = new PROPERTYKEY
        {
            fmtid = new Guid(0x7623384f, 0x00f5, 0x4376, 0x86, 0x98, 0x34, 0x58, 0xdb, 0x03, 0x0e, 0xd5),
            pid = (0x2) + 0x00000007,
        };

        [NativeTypeName("const PROPERTYKEY")]
        public static readonly PROPERTYKEY MF_EME_ROBUSTNESS = new PROPERTYKEY
        {
            fmtid = new Guid(0x9d3d2b9e, 0x7023, 0x4944, 0xa8, 0xf5, 0xec, 0xca, 0x52, 0xa4, 0x69, 0x90),
            pid = (0x2) + 0x00000001,
        };

        [NativeTypeName("const PROPERTYKEY")]
        public static readonly PROPERTYKEY MF_EME_CONTENTTYPE = new PROPERTYKEY
        {
            fmtid = new Guid(0x289fb1fc, 0xd9c4, 0x4cc7, 0xb2, 0xbe, 0x97, 0x2b, 0x0e, 0x9b, 0x28, 0x3a),
            pid = (0x2) + 0x00000002,
        };

        [NativeTypeName("const PROPERTYKEY")]
        public static readonly PROPERTYKEY MF_EME_CDM_INPRIVATESTOREPATH = new PROPERTYKEY
        {
            fmtid = new Guid(0xec305fd9, 0x039f, 0x4ac8, 0x98, 0xda, 0xe7, 0x92, 0x1e, 0x00, 0x6a, 0x90),
            pid = (0x2) + 0x00000001,
        };

        [NativeTypeName("const PROPERTYKEY")]
        public static readonly PROPERTYKEY MF_EME_CDM_STOREPATH = new PROPERTYKEY
        {
            fmtid = new Guid(0xf795841e, 0x99f9, 0x44d7, 0xaf, 0xc0, 0xd3, 0x09, 0xc0, 0x4c, 0x94, 0xab),
            pid = (0x2) + 0x00000002,
        };

        [NativeTypeName("#define MF_INVALID_PRESENTATION_TIME 0x8000000000000000")]
        public const ulong MF_INVALID_PRESENTATION_TIME = 0x8000000000000000;

        public static readonly Guid IID_IMFMediaError = new Guid(0xFC0E10D2, 0xAB2A, 0x4501, 0xA9, 0x51, 0x06, 0xBB, 0x10, 0x75, 0x18, 0x4C);

        public static readonly Guid IID_IMFMediaTimeRange = new Guid(0xDB71A2FC, 0x078A, 0x414E, 0x9D, 0xF9, 0x8C, 0x25, 0x31, 0xB0, 0xAA, 0x6C);

        public static readonly Guid IID_IMFMediaEngineNotify = new Guid(0xFEE7C112, 0xE776, 0x42B5, 0x9B, 0xBF, 0x00, 0x48, 0x52, 0x4E, 0x2B, 0xD5);

        public static readonly Guid IID_IMFMediaEngineSrcElements = new Guid(0x7A5E5354, 0xB114, 0x4C72, 0xB9, 0x91, 0x31, 0x31, 0xD7, 0x50, 0x32, 0xEA);

        public static readonly Guid IID_IMFMediaEngine = new Guid(0x98A1B0BB, 0x03EB, 0x4935, 0xAE, 0x7C, 0x93, 0xC1, 0xFA, 0x0E, 0x1C, 0x93);

        public static readonly Guid IID_IMFMediaEngineEx = new Guid(0x83015EAD, 0xB1E6, 0x40D0, 0xA9, 0x8A, 0x37, 0x14, 0x5F, 0xFE, 0x1A, 0xD1);

        public static readonly Guid IID_IMFMediaEngineAudioEndpointId = new Guid(0x7A3BAC98, 0x0E76, 0x49FB, 0x8C, 0x20, 0x8A, 0x86, 0xFD, 0x98, 0xEA, 0xF2);

        public static readonly Guid IID_IMFMediaEngineExtension = new Guid(0x2F69D622, 0x20B5, 0x41E9, 0xAF, 0xDF, 0x89, 0xCE, 0xD1, 0xDD, 0xA0, 0x4E);

        public static readonly Guid IID_IMFMediaEngineProtectedContent = new Guid(0x9F8021E8, 0x9C8C, 0x487E, 0xBB, 0x5C, 0x79, 0xAA, 0x47, 0x79, 0x93, 0x8C);

        public static readonly Guid IID_IAudioSourceProvider = new Guid(0xEBBAF249, 0xAFC2, 0x4582, 0x91, 0xC6, 0xB6, 0x0D, 0xF2, 0xE8, 0x49, 0x54);

        public static readonly Guid IID_IMFMediaEngineWebSupport = new Guid(0xBA2743A1, 0x07E0, 0x48EF, 0x84, 0xB6, 0x9A, 0x2E, 0xD0, 0x23, 0xCA, 0x6C);

        public static readonly Guid IID_IMFMediaSourceExtensionNotify = new Guid(0xA7901327, 0x05DD, 0x4469, 0xA7, 0xB7, 0x0E, 0x01, 0x97, 0x9E, 0x36, 0x1D);

        public static readonly Guid IID_IMFBufferListNotify = new Guid(0x24CD47F7, 0x81D8, 0x4785, 0xAD, 0xB2, 0xAF, 0x69, 0x7A, 0x96, 0x3C, 0xD2);

        public static readonly Guid IID_IMFSourceBufferNotify = new Guid(0x87E47623, 0x2CEB, 0x45D6, 0x9B, 0x88, 0xD8, 0x52, 0x0C, 0x4D, 0xCB, 0xBC);

        public static readonly Guid IID_IMFSourceBuffer = new Guid(0xE2CD3A4B, 0xAF25, 0x4D3D, 0x91, 0x10, 0xDA, 0x0E, 0x6F, 0x8E, 0xE8, 0x77);

        public static readonly Guid IID_IMFSourceBufferAppendMode = new Guid(0x19666FB4, 0xBABE, 0x4C55, 0xBC, 0x03, 0x0A, 0x07, 0x4D, 0xA3, 0x7E, 0x2A);

        public static readonly Guid IID_IMFSourceBufferList = new Guid(0x249981F8, 0x8325, 0x41F3, 0xB8, 0x0C, 0x3B, 0x9E, 0x3A, 0xAD, 0x0C, 0xBE);

        public static readonly Guid IID_IMFMediaSourceExtension = new Guid(0xE467B94E, 0xA713, 0x4562, 0xA8, 0x02, 0x81, 0x6A, 0x42, 0xE9, 0x00, 0x8A);

        public static readonly Guid IID_IMFMediaSourceExtensionLiveSeekableRange = new Guid(0x5D1ABFD6, 0x450A, 0x4D92, 0x9E, 0xFC, 0xD6, 0xB6, 0xCB, 0xC1, 0xF4, 0xDA);

        public static readonly Guid IID_IMFMediaEngineEME = new Guid(0x50DC93E4, 0xBA4F, 0x4275, 0xAE, 0x66, 0x83, 0xE8, 0x36, 0xE5, 0x74, 0x69);

        public static readonly Guid IID_IMFMediaEngineSrcElementsEx = new Guid(0x654A6BB3, 0xE1A3, 0x424A, 0x99, 0x08, 0x53, 0xA4, 0x3A, 0x0D, 0xFD, 0xA0);

        public static readonly Guid IID_IMFMediaEngineNeedKeyNotify = new Guid(0x46A30204, 0xA696, 0x4B18, 0x88, 0x04, 0x24, 0x6B, 0x8F, 0x03, 0x1B, 0xB1);

        public static readonly Guid IID_IMFMediaKeys = new Guid(0x5CB31C05, 0x61FF, 0x418F, 0xAF, 0xDA, 0xCA, 0xAF, 0x41, 0x42, 0x1A, 0x38);

        public static readonly Guid IID_IMFMediaKeySession = new Guid(0x24FA67D5, 0xD1D0, 0x4DC5, 0x99, 0x5C, 0xC0, 0xEF, 0xDC, 0x19, 0x1F, 0xB5);

        public static readonly Guid IID_IMFMediaKeySessionNotify = new Guid(0x6A0083F9, 0x8947, 0x4C1D, 0x9C, 0xE0, 0xCD, 0xEE, 0x22, 0xB2, 0x31, 0x35);

        public static readonly Guid IID_IMFCdmSuspendNotify = new Guid(0x7A5645D2, 0x43BD, 0x47FD, 0x87, 0xB7, 0xDC, 0xD2, 0x4C, 0xC7, 0xD6, 0x92);

        public static readonly Guid IID_IMFHDCPStatus = new Guid(0xDE400F54, 0x5BF1, 0x40CF, 0x89, 0x64, 0x0B, 0xEA, 0x13, 0x6B, 0x1E, 0x3D);

        public static readonly Guid IID_IMFMediaEngineOPMInfo = new Guid(0x765763E6, 0x6C01, 0x4B01, 0xBB, 0x0F, 0xB8, 0x29, 0xF6, 0x0E, 0xD2, 0x8C);

        public static readonly Guid IID_IMFMediaEngineClassFactory = new Guid(0x4D645ACE, 0x26AA, 0x4688, 0x9B, 0xE1, 0xDF, 0x35, 0x16, 0x99, 0x0B, 0x93);

        public static readonly Guid IID_IMFMediaEngineClassFactoryEx = new Guid(0xC56156C6, 0xEA5B, 0x48A5, 0x9D, 0xF8, 0xFB, 0xE0, 0x35, 0xD0, 0x92, 0x9E);

        public static readonly Guid IID_IMFMediaEngineClassFactory2 = new Guid(0x09083CEF, 0x867F, 0x4BF6, 0x87, 0x76, 0xDE, 0xE3, 0xA7, 0xB4, 0x2F, 0xCA);

        public static readonly Guid IID_IMFExtendedDRMTypeSupport = new Guid(0x332EC562, 0x3758, 0x468D, 0xA7, 0x84, 0xE3, 0x8F, 0x23, 0x55, 0x21, 0x28);

        public static readonly Guid IID_IMFMediaEngineSupportsSourceTransfer = new Guid(0xA724B056, 0x1B2E, 0x4642, 0xA6, 0xF3, 0xDB, 0x94, 0x20, 0xC5, 0x29, 0x08);

        public static readonly Guid IID_IMFMediaEngineTransferSource = new Guid(0x24230452, 0xFE54, 0x40CC, 0x94, 0xF3, 0xFC, 0xC3, 0x94, 0xC3, 0x40, 0xD6);

        public static readonly Guid IID_IMFTimedText = new Guid(0x1F2A94C9, 0xA3DF, 0x430D, 0x9D, 0x0F, 0xAC, 0xD8, 0x5D, 0xDC, 0x29, 0xAF);

        public static readonly Guid IID_IMFTimedTextNotify = new Guid(0xDF6B87B6, 0xCE12, 0x45DB, 0xAB, 0xA7, 0x43, 0x2F, 0xE0, 0x54, 0xE5, 0x7D);

        public static readonly Guid IID_IMFTimedTextTrack = new Guid(0x8822C32D, 0x654E, 0x4233, 0xBF, 0x21, 0xD7, 0xF2, 0xE6, 0x7D, 0x30, 0xD4);

        public static readonly Guid IID_IMFTimedTextTrackList = new Guid(0x23FF334C, 0x442C, 0x445F, 0xBC, 0xCC, 0xED, 0xC4, 0x38, 0xAA, 0x11, 0xE2);

        public static readonly Guid IID_IMFTimedTextCue = new Guid(0x1E560447, 0x9A2B, 0x43E1, 0xA9, 0x4C, 0xB0, 0xAA, 0xAB, 0xFB, 0xFB, 0xC9);

        public static readonly Guid IID_IMFTimedTextFormattedText = new Guid(0xE13AF3C1, 0x4D47, 0x4354, 0xB1, 0xF5, 0xE8, 0x3A, 0xE0, 0xEC, 0xAE, 0x60);

        public static readonly Guid IID_IMFTimedTextStyle = new Guid(0x09B2455D, 0xB834, 0x4F01, 0xA3, 0x47, 0x90, 0x52, 0xE2, 0x1C, 0x45, 0x0E);

        public static readonly Guid IID_IMFTimedTextRegion = new Guid(0xC8D22AFC, 0xBC47, 0x4BDF, 0x9B, 0x04, 0x78, 0x7E, 0x49, 0xCE, 0x3F, 0x58);

        public static readonly Guid IID_IMFTimedTextBinary = new Guid(0x4AE3A412, 0x0545, 0x43C4, 0xBF, 0x6F, 0x6B, 0x97, 0xA5, 0xC6, 0xC4, 0x32);

        public static readonly Guid IID_IMFTimedTextCueList = new Guid(0xAD128745, 0x211B, 0x40A0, 0x99, 0x81, 0xFE, 0x65, 0xF1, 0x66, 0xD0, 0xFD);

        public static readonly Guid IID_IMFMediaEngineEMENotify = new Guid(0x9E184D15, 0xCDB7, 0x4F86, 0xB4, 0x9E, 0x56, 0x66, 0x89, 0xF4, 0xA6, 0x01);

        public static readonly Guid IID_IMFMediaKeySessionNotify2 = new Guid(0xC3A9E92A, 0xDA88, 0x46B0, 0xA1, 0x10, 0x6C, 0xF9, 0x53, 0x02, 0x6C, 0xB9);

        public static readonly Guid IID_IMFMediaKeySystemAccess = new Guid(0xAEC63FDA, 0x7A97, 0x4944, 0xB3, 0x5C, 0x6C, 0x6D, 0xF8, 0x08, 0x5C, 0xC3);

        public static readonly Guid IID_IMFMediaEngineClassFactory3 = new Guid(0x3787614F, 0x65F7, 0x4003, 0xB6, 0x73, 0xEA, 0xD8, 0x29, 0x3A, 0x0E, 0x60);

        public static readonly Guid IID_IMFMediaKeys2 = new Guid(0x45892507, 0xAD66, 0x4DE2, 0x83, 0xA2, 0xAC, 0xBB, 0x13, 0xCD, 0x8D, 0x43);

        public static readonly Guid IID_IMFMediaKeySession2 = new Guid(0xE9707E05, 0x6D55, 0x4636, 0xB1, 0x85, 0x3D, 0xE2, 0x12, 0x10, 0xBD, 0x75);

        public static readonly Guid IID_IMFMediaEngineClassFactory4 = new Guid(0xFBE256C1, 0x43CF, 0x4A9B, 0x8C, 0xB8, 0xCE, 0x86, 0x32, 0xA3, 0x41, 0x86);
    }
}