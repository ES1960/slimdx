// Copyright (c) 2007-2010 SlimDX Group
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

//------------------------------------------------------------------------------
// <auto-generated>
//     Interfaces for SlimDX2.Direct3D namespace.
//     This code was generated by a tool.
//     Date : 11/08/2010 15:18:19
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using System.Runtime.InteropServices;

namespace SlimDX2.Direct3D {

    
    /// <summary>	
    /// This interface is used to return arbitrary length data.	
    /// </summary>	
    /// <unmanaged>ID3D10Blob</unmanaged>
    [Guid("8BA5FB08-5195-40e2-AC58-0D989C3A0102")]
    public partial class Blob : SlimDX2.ComObject {
        public Blob(IntPtr basePtr) : base(basePtr) {
        }
        
        
        /// <summary>	
        /// Get a pointer to the data.	
        /// </summary>	
        /// <unmanaged>void* GetBufferPointer()</unmanaged>
        public IntPtr BufferPointer {
                get { return GetBufferPointer(); }
        }
        
        /// <summary>	
        /// Get the size.	
        /// </summary>	
        /// <unmanaged>SIZE_T GetBufferSize()</unmanaged>
        public SlimDX2.Size BufferSize {
                get { return GetBufferSize(); }
        }
        
        /// <summary>	
        /// Get a pointer to the data.	
        /// </summary>	
        /// <returns>Returns a pointer.</returns>
        /// <unmanaged>void* GetBufferPointer()</unmanaged>
        internal IntPtr GetBufferPointer() {
            unsafe {
                IntPtr __result__;
                __result__= (IntPtr)SlimDX2.LocalInterop.CallivoidPtr(_nativePointer, 3 * 4);
                return __result__;
            }
        }
        
        /// <summary>	
        /// Get the size.	
        /// </summary>	
        /// <returns>The size of the data, in bytes.</returns>
        /// <unmanaged>SIZE_T GetBufferSize()</unmanaged>
        internal SlimDX2.Size GetBufferSize() {
            unsafe {
                SlimDX2.Size __result__;
                __result__= (SlimDX2.Size)SlimDX2.LocalInterop.CallivoidPtr(_nativePointer, 4 * 4);
                return __result__;
            }
        }
    }
}
