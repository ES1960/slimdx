/*
* Copyright (c) 2007-2010 SlimDX Group
* 
* Permission is hereby granted, free of charge, to any person obtaining a copy
* of this software and associated documentation files (the "Software"), to deal
* in the Software without restriction, including without limitation the rights
* to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
* copies of the Software, and to permit persons to whom the Software is
* furnished to do so, subject to the following conditions:
* 
* The above copyright notice and this permission notice shall be included in
* all copies or substantial portions of the Software.
* 
* THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
* IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
* FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
* AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
* LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
* OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
* THE SOFTWARE.
*/
#pragma once

#include "CommonMocks.h"
#include <dwrite.h>

class IDWriteGdiInteropMock : public IDWriteGdiInterop
{
public:
	MOCK_IUNKNOWN;

	STDMETHOD(CreateFontFromLOGFONT)(LOGFONTW const* logFont, IDWriteFont** font) { return E_NOTIMPL; }
	STDMETHOD(ConvertFontToLOGFONT)(IDWriteFont* font, LOGFONTW* logFont, BOOL* isSystemFont) { return E_NOTIMPL; }
    STDMETHOD(ConvertFontFaceToLOGFONT)(IDWriteFontFace* font, LOGFONTW* logFont) { return E_NOTIMPL; }
    STDMETHOD(CreateFontFaceFromHdc)(HDC hdc, IDWriteFontFace** fontFace) { return E_NOTIMPL; }
    MOCK_METHOD4_WITH_CALLTYPE( STDMETHODCALLTYPE, CreateBitmapRenderTarget, HRESULT(HDC hdc, UINT32 width, UINT32 height, IDWriteBitmapRenderTarget** renderTarget));
};
