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
//     SlimDX2 Dynamic Interop registration.
//     This code was generated by a tool.
//     Date : 10/23/2010 10:28:26
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System;

namespace SlimDX2
{
    public partial class CppObject
    {
        private static DynamicInterop.CalliSignature[] _interopCalliSignatures = new DynamicInterop.CalliSignature[]
                                                                                     {
            new DynamicInterop.CalliSignature("CalliInt", typeof(int), new Type[3] { typeof(void*),typeof(int),typeof(void*), } ),
            new DynamicInterop.CalliSignature("CalliInt", typeof(int), new Type[2] { typeof(void*),typeof(void*), } ),
            new DynamicInterop.CalliSignature("CalliInt", typeof(int), new Type[3] { typeof(void*),typeof(void*),typeof(void*), } ),
            new DynamicInterop.CalliSignature("CalliInt", typeof(int), new Type[1] { typeof(void*), } ),
            new DynamicInterop.CalliSignature("CalliInt", typeof(int), new Type[1] { typeof(int), } ),
            new DynamicInterop.CalliSignature("CalliInt", typeof(int), new Type[2] { typeof(long),typeof(int), } ),
            new DynamicInterop.CalliSignature("CalliInt", typeof(int), new Type[1] { typeof(long), } ),
            new DynamicInterop.CalliSignature("CalliInt", typeof(int), new Type[2] { typeof(void*),typeof(int), } ),
            new DynamicInterop.CalliSignature("CalliInt", typeof(int), new Type[0]),
            new DynamicInterop.CalliSignature("CalliInt", typeof(int), new Type[2] { typeof(int),typeof(void*), } ),
            new DynamicInterop.CalliSignature("CalliInt", typeof(int), new Type[4] { typeof(int),typeof(int),typeof(void*),typeof(void*), } ),
            new DynamicInterop.CalliSignature("CalliVoid", typeof(void), new Type[0]),
            new DynamicInterop.CalliSignature("CalliInt", typeof(int), new Type[2] { typeof(int),typeof(int), } ),
            new DynamicInterop.CalliSignature("CalliInt", typeof(int), new Type[3] { typeof(int),typeof(void*),typeof(void*), } ),
            new DynamicInterop.CalliSignature("CalliInt", typeof(int), new Type[5] { typeof(int),typeof(int),typeof(int),typeof(int),typeof(int), } ),
            new DynamicInterop.CalliSignature("CalliInt", typeof(int), new Type[5] { typeof(void*),typeof(int),typeof(int),typeof(void*),typeof(void*), } ),
            new DynamicInterop.CalliSignature("CalliInt", typeof(int), new Type[3] { typeof(void*),typeof(void*),typeof(int), } ),
            new DynamicInterop.CalliSignature("CalliPtr", typeof(void*), new Type[0]),
            new DynamicInterop.CalliSignature("CalliInt", typeof(int), new Type[5] { typeof(int),typeof(void*),typeof(void*),typeof(void*),typeof(void*), } ),
            new DynamicInterop.CalliSignature("CalliVoid", typeof(void), new Type[1] { typeof(void*), } ),
            new DynamicInterop.CalliSignature("CalliVoid", typeof(void), new Type[1] { typeof(int), } ),
            new DynamicInterop.CalliSignature("CalliVoid", typeof(void), new Type[2] { typeof(void*),typeof(void*), } ),
            new DynamicInterop.CalliSignature("CalliInt", typeof(int), new Type[6] { typeof(void*),typeof(int),typeof(int),typeof(int),typeof(int),typeof(void*), } ),
            new DynamicInterop.CalliSignature("CalliVoid", typeof(void), new Type[3] { typeof(int),typeof(int),typeof(void*), } ),
            new DynamicInterop.CalliSignature("CalliVoid", typeof(void), new Type[3] { typeof(void*),typeof(void*),typeof(int), } ),
            new DynamicInterop.CalliSignature("CalliVoid", typeof(void), new Type[3] { typeof(int),typeof(int),typeof(int), } ),
            new DynamicInterop.CalliSignature("CalliVoid", typeof(void), new Type[2] { typeof(int),typeof(int), } ),
            new DynamicInterop.CalliSignature("CalliInt", typeof(int), new Type[5] { typeof(void*),typeof(int),typeof(int),typeof(int),typeof(void*), } ),
            new DynamicInterop.CalliSignature("CalliVoid", typeof(void), new Type[2] { typeof(void*),typeof(int), } ),
            new DynamicInterop.CalliSignature("CalliVoid", typeof(void), new Type[5] { typeof(int),typeof(int),typeof(void*),typeof(void*),typeof(void*), } ),
            new DynamicInterop.CalliSignature("CalliVoid", typeof(void), new Type[3] { typeof(void*),typeof(int),typeof(int), } ),
            new DynamicInterop.CalliSignature("CalliVoid", typeof(void), new Type[5] { typeof(int),typeof(int),typeof(int),typeof(int),typeof(int), } ),
            new DynamicInterop.CalliSignature("CalliVoid", typeof(void), new Type[4] { typeof(int),typeof(int),typeof(int),typeof(int), } ),
            new DynamicInterop.CalliSignature("CalliInt", typeof(int), new Type[4] { typeof(void*),typeof(void*),typeof(int),typeof(int), } ),
            new DynamicInterop.CalliSignature("CalliVoid", typeof(void), new Type[3] { typeof(int),typeof(void*),typeof(void*), } ),
            new DynamicInterop.CalliSignature("CalliVoid", typeof(void), new Type[7] { typeof(int),typeof(void*),typeof(void*),typeof(int),typeof(int),typeof(void*),typeof(void*), } ),
            new DynamicInterop.CalliSignature("CalliVoid", typeof(void), new Type[2] { typeof(int),typeof(void*), } ),
            new DynamicInterop.CalliSignature("CalliVoid", typeof(void), new Type[8] { typeof(void*),typeof(int),typeof(int),typeof(int),typeof(int),typeof(void*),typeof(int),typeof(void*), } ),
            new DynamicInterop.CalliSignature("CalliVoid", typeof(void), new Type[6] { typeof(void*),typeof(int),typeof(void*),typeof(void*),typeof(int),typeof(int), } ),
            new DynamicInterop.CalliSignature("CalliVoid", typeof(void), new Type[3] { typeof(void*),typeof(int),typeof(void*), } ),
            new DynamicInterop.CalliSignature("CalliVoid", typeof(void), new Type[4] { typeof(void*),typeof(int),typeof(float),typeof(int), } ),
            new DynamicInterop.CalliSignature("CalliVoid", typeof(void), new Type[2] { typeof(void*),typeof(float), } ),
            new DynamicInterop.CalliSignature("CalliFloat", typeof(float), new Type[1] { typeof(void*), } ),
            new DynamicInterop.CalliSignature("CalliVoid", typeof(void), new Type[5] { typeof(void*),typeof(int),typeof(void*),typeof(int),typeof(int), } ),
            new DynamicInterop.CalliSignature("CalliVoid", typeof(void), new Type[4] { typeof(int),typeof(int),typeof(void*),typeof(void*), } ),
            new DynamicInterop.CalliSignature("CalliVoid", typeof(void), new Type[3] { typeof(void*),typeof(void*),typeof(void*), } ),
            new DynamicInterop.CalliSignature("CalliVoid", typeof(void), new Type[6] { typeof(int),typeof(void*),typeof(void*),typeof(int),typeof(int),typeof(void*), } ),
            new DynamicInterop.CalliSignature("CalliInt", typeof(int), new Type[5] { typeof(void*),typeof(int),typeof(void*),typeof(void*),typeof(void*), } ),
            new DynamicInterop.CalliSignature("CalliInt", typeof(int), new Type[4] { typeof(void*),typeof(void*),typeof(void*),typeof(void*), } ),
            new DynamicInterop.CalliSignature("CalliInt", typeof(int), new Type[9] { typeof(void*),typeof(void*),typeof(void*),typeof(int),typeof(void*),typeof(int),typeof(int),typeof(void*),typeof(void*), } ),
            new DynamicInterop.CalliSignature("CalliInt", typeof(int), new Type[3] { typeof(int),typeof(int),typeof(void*), } ),
            new DynamicInterop.CalliSignature("CalliInt", typeof(int), new Type[9] { typeof(void*),typeof(void*),typeof(void*),typeof(void*),typeof(void*),typeof(void*),typeof(void*),typeof(void*),typeof(void*), } ),
            new DynamicInterop.CalliSignature("CalliInt", typeof(int), new Type[3] { typeof(int),typeof(void*),typeof(int), } ),
            new DynamicInterop.CalliSignature("CalliPtr", typeof(void*), new Type[1] { typeof(int), } ),
            new DynamicInterop.CalliSignature("CalliPtr", typeof(void*), new Type[1] { typeof(void*), } ),
        };
    }
}

