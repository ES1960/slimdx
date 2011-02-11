﻿// Copyright (c) 2007-2011 SlimDX Group
// 
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
// 
// The above copyright notice and this permission notice shall be included in
// all copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
// THE SOFTWARE.

using System;
using System.Runtime.InteropServices;
using System.Security;

namespace SlimDX.DXGI
{
	/// <summary>
	/// The access point for the DXGI API.
	/// </summary>
	public static class DXGI
	{
		#region Interface

		public static IDXGIFactory CreateFactory()
		{
			IntPtr nativePointer = IntPtr.Zero;
			CreateDXGIFactory(ref factoryGuid, out nativePointer);
			return new IDXGIFactory(nativePointer);
		}

		#endregion
		#region Implementation

		static Guid factoryGuid = new Guid("7b7166ec-21c7-44ae-b21a-c9ae321ae369");

		[DllImport("dxgi.dll", EntryPoint = "CreateDXGIFactory", CallingConvention = CallingConvention.StdCall, PreserveSig = true), SuppressUnmanagedCodeSecurity]
		private extern static int CreateDXGIFactory(ref Guid interfaceID, out IntPtr result);

		#endregion
	}
}
