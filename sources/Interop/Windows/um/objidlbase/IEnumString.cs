// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\objidlbase.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;
using System.Security;

namespace TerraFX.Interop
{
    [Guid("00000101-0000-0000-C000-000000000046")]
    public unsafe struct IEnumString
    {
        public readonly Vtbl* lpVtbl;

        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _QueryInterface(
            [In] IEnumString* This,
            [In, NativeTypeName("REFIID")] Guid* riid,
            [Out] void** ppvObject
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("ULONG")]
        public /* static */ delegate uint _AddRef(
            [In] IEnumString* This
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("ULONG")]
        public /* static */ delegate uint _Release(
            [In] IEnumString* This
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _Next(
            [In] IEnumString* This,
            [In, NativeTypeName("ULONG")] uint celt,
            [Out, NativeTypeName("LPOLESTR")] char** rgelt,
            [Out, NativeTypeName("ULONG")] uint* pceltFetched = null
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _Skip(
            [In] IEnumString* This,
            [In, NativeTypeName("ULONG")] uint celt
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _Reset(
            [In] IEnumString* This
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _Clone(
            [In] IEnumString* This,
            [Out] IEnumString** ppenum = null
        );

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface(
            [In, NativeTypeName("REFIID")] Guid* riid,
            [Out] void** ppvObject
        )
        {
            fixed (IEnumString* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_QueryInterface>(lpVtbl->QueryInterface)(
                    This,
                    riid,
                    ppvObject
                );
            }
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            fixed (IEnumString* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_AddRef>(lpVtbl->AddRef)(
                    This
                );
            }
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            fixed (IEnumString* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_Release>(lpVtbl->Release)(
                    This
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int Next(
            [In, NativeTypeName("ULONG")] uint celt,
            [Out, NativeTypeName("LPOLESTR")] char** rgelt,
            [Out, NativeTypeName("ULONG")] uint* pceltFetched = null
        )
        {
            fixed (IEnumString* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_Next>(lpVtbl->Next)(
                    This,
                    celt,
                    rgelt,
                    pceltFetched
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int Skip(
            [In, NativeTypeName("ULONG")] uint celt
        )
        {
            fixed (IEnumString* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_Skip>(lpVtbl->Skip)(
                    This,
                    celt
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int Reset()
        {
            fixed (IEnumString* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_Reset>(lpVtbl->Reset)(
                    This
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int Clone(
            [Out] IEnumString** ppenum = null
        )
        {
            fixed (IEnumString* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_Clone>(lpVtbl->Clone)(
                    This,
                    ppenum
                );
            }
        }

        public struct Vtbl
        {
            public IntPtr QueryInterface;

            public IntPtr AddRef;

            public IntPtr Release;

            public IntPtr Next;

            public IntPtr Skip;

            public IntPtr Reset;

            public IntPtr Clone;
        }
    }
}
