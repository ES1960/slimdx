﻿// Copyright (c) 2007-2010 SlimDX Group
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
namespace SlimDX.Direct3D11
{
    public partial struct Viewport
    {
        /// <summary>
        ///   Initializes a new instance of the <see cref = "T:SlimDX.Direct3D11.Viewport" /> structure.
        /// </summary>
        /// <param name = "x">The X coordinate of the viewport.</param>
        /// <param name = "y">The Y coordinate of the viewport.</param>
        /// <param name = "width">The width of the viewport.</param>
        /// <param name = "height">The height of the viewport.</param>
        /// <param name = "minZ">The minimum Z distance of the viewport.</param>
        /// <param name = "maxZ">The maximum Z distance of the viewport.</param>
        public Viewport(float x, float y, float width, float height, float minZ, float maxZ)
        {
            this.TopLeftX = x;
            this.TopLeftY = y;
            this.Width = width;
            this.Height = height;
            this.MinDepth = minZ;
            this.MaxDepth = maxZ;
        }

        /// <summary>
        ///   Initializes a new instance of the <see cref = "T:SlimDX.Direct3D11.Viewport" /> structure.
        /// </summary>
        /// <param name = "x">The X coordinate of the viewport.</param>
        /// <param name = "y">The Y coordinate of the viewport.</param>
        /// <param name = "width">The width of the viewport.</param>
        /// <param name = "height">The height of the viewport.</param>
        public Viewport(float x, float y, float width, float height)
        {
            this.TopLeftX = x;
            this.TopLeftY = y;
            this.Width = width;
            this.Height = height;
            this.MinDepth = 0f;
            this.MaxDepth = 1f;
        }
    }
}