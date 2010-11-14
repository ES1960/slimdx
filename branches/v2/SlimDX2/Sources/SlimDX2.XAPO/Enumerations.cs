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
//     Enums for SlimDX2.XAPO namespace.
//     This code was generated by a tool.
//     Date : 11/14/2010 00:36:11
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System;

namespace SlimDX2.XAPO {

    
    /// <summary>	
    /// No documentation.	
    /// </summary>	
    /// <unmanaged>XAPO_BUFFER_FLAGS</unmanaged>
    [Flags]
    public enum BufferFlags : int {	
        
        /// <summary>	
        /// No documentation.	
        /// </summary>	
        /// <unmanaged>XAPO_BUFFER_SILENT</unmanaged>
        Silent,
        
        /// <summary>	
        /// No documentation.	
        /// </summary>	
        /// <unmanaged>XAPO_BUFFER_VALID</unmanaged>
        Valid,
        
        /// <summary>	
        /// None.	
        /// </summary>	
        /// <unmanaged>None</unmanaged>
        None = unchecked((int)0),			
    }
    
    /// <summary>	
    /// No documentation.	
    /// </summary>	
    /// <unmanaged>XAPO_PROPERTY_TYPE</unmanaged>
    [Flags]
    public enum PropertyFlags : int {	
        
        /// <summary>	
        /// No documentation.	
        /// </summary>	
        /// <unmanaged>XAPO_PROPERTY_CHANNELS_MUST_MATCH</unmanaged>
        ChannelsMustMatch = unchecked((int)0x00000001),			
        
        /// <summary>	
        /// No documentation.	
        /// </summary>	
        /// <unmanaged>XAPO_PROPERTY_FRAMERATE_MUST_MATCH</unmanaged>
        FramerateMustMatch = unchecked((int)0x00000002),			
        
        /// <summary>	
        /// No documentation.	
        /// </summary>	
        /// <unmanaged>XAPO_PROPERTY_BITSPERSAMPLE_MUST_MATCH</unmanaged>
        BitspersampleMustMatch = unchecked((int)0x00000004),			
        
        /// <summary>	
        /// No documentation.	
        /// </summary>	
        /// <unmanaged>XAPO_PROPERTY_BUFFERCOUNT_MUST_MATCH</unmanaged>
        BuffercountMustMatch = unchecked((int)0x00000008),			
        
        /// <summary>	
        /// No documentation.	
        /// </summary>	
        /// <unmanaged>XAPO_PROPERTY_INPLACE_REQUIRED</unmanaged>
        InplaceRequired = unchecked((int)0x00000020),			
        
        /// <summary>	
        /// No documentation.	
        /// </summary>	
        /// <unmanaged>XAPO_PROPERTY_INPLACE_SUPPORTED</unmanaged>
        InplaceSupported = unchecked((int)0x00000010),			
        
        /// <summary>	
        /// No documentation.	
        /// </summary>	
        /// <unmanaged>Default</unmanaged>
        Default = unchecked((int)ChannelsMustMatch|FramerateMustMatch|BitspersampleMustMatch|BuffercountMustMatch|InplaceSupported),			
    }
}
