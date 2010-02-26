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

struct IDWriteTextLayoutMock : IDWriteTextLayout
{
	MOCK_IUNKNOWN;

	// IDWriteTextFormat
	STDMETHODIMP SetTextAlignment(DWRITE_TEXT_ALIGNMENT) { return E_NOTIMPL; };
	STDMETHODIMP SetParagraphAlignment(DWRITE_PARAGRAPH_ALIGNMENT) { return E_NOTIMPL; };
	STDMETHODIMP SetWordWrapping(DWRITE_WORD_WRAPPING) { return E_NOTIMPL; };
	STDMETHODIMP SetReadingDirection(DWRITE_READING_DIRECTION) { return E_NOTIMPL; };
	STDMETHODIMP SetFlowDirection(DWRITE_FLOW_DIRECTION) { return E_NOTIMPL; };
	STDMETHODIMP SetIncrementalTabStop(FLOAT) { return E_NOTIMPL; };
	STDMETHODIMP SetTrimming(DWRITE_TRIMMING const*, IDWriteInlineObject*) { return E_NOTIMPL; }
	STDMETHODIMP SetLineSpacing(DWRITE_LINE_SPACING_METHOD, FLOAT, FLOAT) { return E_NOTIMPL; }
	STDMETHODIMP_(DWRITE_TEXT_ALIGNMENT) GetTextAlignment() { return DWRITE_TEXT_ALIGNMENT(0); }
	STDMETHODIMP_(DWRITE_PARAGRAPH_ALIGNMENT) GetParagraphAlignment() { return DWRITE_PARAGRAPH_ALIGNMENT(0); }
	STDMETHODIMP_(DWRITE_WORD_WRAPPING) GetWordWrapping() { return DWRITE_WORD_WRAPPING(0); }
	STDMETHODIMP_(DWRITE_READING_DIRECTION) GetReadingDirection() { return DWRITE_READING_DIRECTION(0); }
	STDMETHODIMP_(DWRITE_FLOW_DIRECTION) GetFlowDirection() { return DWRITE_FLOW_DIRECTION(0); }
	STDMETHODIMP_(FLOAT) GetIncrementalTabStop() { return FLOAT(0); }
	STDMETHODIMP GetTrimming(DWRITE_TRIMMING*, IDWriteInlineObject**) { return E_NOTIMPL; }
	STDMETHODIMP GetLineSpacing(DWRITE_LINE_SPACING_METHOD*, FLOAT*, FLOAT*) { return E_NOTIMPL; }
	STDMETHODIMP GetFontCollection(IDWriteFontCollection**) { return E_NOTIMPL; };
	STDMETHODIMP_(UINT32) GetFontFamilyNameLength() { return UINT32(0); }
	STDMETHODIMP GetFontFamilyName(WCHAR*, UINT32) { return E_NOTIMPL; }
	STDMETHODIMP_(DWRITE_FONT_WEIGHT) GetFontWeight() { return DWRITE_FONT_WEIGHT(0); }
	STDMETHODIMP_(DWRITE_FONT_STYLE) GetFontStyle() { return DWRITE_FONT_STYLE(0); }
	STDMETHODIMP_(DWRITE_FONT_STRETCH) GetFontStretch() { return DWRITE_FONT_STRETCH(0); }
	STDMETHODIMP_(FLOAT) GetFontSize() { return FLOAT(0); }
	STDMETHODIMP_(UINT32) GetLocaleNameLength() { return UINT32(0); }
	STDMETHODIMP GetLocaleName(WCHAR*, UINT32) { return E_NOTIMPL; }

	// IDWriteTextLayout
	STDMETHODIMP SetMaxWidth(FLOAT) { return E_NOTIMPL; }
	STDMETHODIMP SetMaxHeight(FLOAT) { return E_NOTIMPL; }
	STDMETHODIMP SetFontCollection(IDWriteFontCollection*, DWRITE_TEXT_RANGE) { return E_NOTIMPL; }
	STDMETHODIMP SetFontFamilyName(WCHAR const *, DWRITE_TEXT_RANGE) { return E_NOTIMPL; }
	STDMETHODIMP SetFontWeight(DWRITE_FONT_WEIGHT, DWRITE_TEXT_RANGE) { return E_NOTIMPL; }
	STDMETHODIMP SetFontStyle(DWRITE_FONT_STYLE, DWRITE_TEXT_RANGE) { return E_NOTIMPL; }
	STDMETHODIMP SetFontStretch(DWRITE_FONT_STRETCH, DWRITE_TEXT_RANGE) { return E_NOTIMPL; }
	STDMETHODIMP SetFontSize(FLOAT, DWRITE_TEXT_RANGE) { return E_NOTIMPL; }
	STDMETHODIMP SetUnderline(BOOL, DWRITE_TEXT_RANGE) { return E_NOTIMPL; }
	STDMETHODIMP SetStrikethrough(BOOL, DWRITE_TEXT_RANGE) { return E_NOTIMPL; }
	STDMETHODIMP SetDrawingEffect(IUnknown*, DWRITE_TEXT_RANGE) { return E_NOTIMPL; }
	STDMETHODIMP SetInlineObject(IDWriteInlineObject*, DWRITE_TEXT_RANGE) { return E_NOTIMPL; }
	STDMETHODIMP SetTypography(IDWriteTypography*, DWRITE_TEXT_RANGE) { return E_NOTIMPL; }
	STDMETHODIMP SetLocaleName(WCHAR const *, DWRITE_TEXT_RANGE) { return E_NOTIMPL; }
	STDMETHODIMP_(FLOAT) GetMaxWidth() { return FLOAT(0); }
	STDMETHODIMP_(FLOAT) GetMaxHeight() { return FLOAT(0); }
	STDMETHODIMP GetFontCollection( UINT32, IDWriteFontCollection**, DWRITE_TEXT_RANGE* ) { return E_NOTIMPL; }
	STDMETHODIMP GetFontFamilyNameLength( UINT32, UINT32*, DWRITE_TEXT_RANGE* ) { return E_NOTIMPL; }
	STDMETHODIMP GetFontFamilyName( UINT32, WCHAR*, UINT32, DWRITE_TEXT_RANGE* ) { return E_NOTIMPL; }
	STDMETHODIMP GetFontWeight( UINT32, DWRITE_FONT_WEIGHT*, DWRITE_TEXT_RANGE* ) { return E_NOTIMPL; }
	STDMETHODIMP GetFontStyle( UINT32, DWRITE_FONT_STYLE*, DWRITE_TEXT_RANGE* ) { return E_NOTIMPL; }
	STDMETHODIMP GetFontStretch( UINT32, DWRITE_FONT_STRETCH*, DWRITE_TEXT_RANGE* ) { return E_NOTIMPL; }
	STDMETHODIMP GetFontSize( UINT32, FLOAT*, DWRITE_TEXT_RANGE* ) { return E_NOTIMPL; }
	STDMETHODIMP GetUnderline( UINT32, BOOL*, DWRITE_TEXT_RANGE* ) { return E_NOTIMPL; }
	STDMETHODIMP GetStrikethrough( UINT32, BOOL*, DWRITE_TEXT_RANGE* ) { return E_NOTIMPL; }
	STDMETHODIMP GetDrawingEffect( UINT32, IUnknown**, DWRITE_TEXT_RANGE* ) { return E_NOTIMPL; }
	STDMETHODIMP GetInlineObject( UINT32, IDWriteInlineObject**, DWRITE_TEXT_RANGE* ) { return E_NOTIMPL; }
	STDMETHODIMP GetTypography( UINT32, IDWriteTypography**, DWRITE_TEXT_RANGE* ) { return E_NOTIMPL; }
	STDMETHODIMP GetLocaleNameLength( UINT32, UINT32*, DWRITE_TEXT_RANGE* ) { return E_NOTIMPL; }
	STDMETHODIMP GetLocaleName( UINT32, WCHAR*, UINT32, DWRITE_TEXT_RANGE* ) { return E_NOTIMPL; }
	STDMETHODIMP Draw( void *, IDWriteTextRenderer*, FLOAT, FLOAT ) { return E_NOTIMPL; }
	STDMETHODIMP GetLineMetrics( DWRITE_LINE_METRICS*, UINT32, UINT32* ) { return E_NOTIMPL; }
	STDMETHODIMP GetMetrics(DWRITE_TEXT_METRICS*) { return E_NOTIMPL; }
	STDMETHODIMP GetOverhangMetrics(DWRITE_OVERHANG_METRICS*) { return E_NOTIMPL; }
	MOCK_METHOD3_WITH_CALLTYPE( STDMETHODCALLTYPE, GetClusterMetrics, HRESULT( DWRITE_CLUSTER_METRICS*, UINT32, UINT32* ) );
	STDMETHODIMP DetermineMinWidth(FLOAT*) { return E_NOTIMPL; }
	STDMETHODIMP HitTestPoint( FLOAT, FLOAT, BOOL*, BOOL*, DWRITE_HIT_TEST_METRICS* ) { return E_NOTIMPL; }
	STDMETHODIMP HitTestTextPosition( UINT32, BOOL, FLOAT*, FLOAT*, DWRITE_HIT_TEST_METRICS* ) { return E_NOTIMPL; }
	STDMETHODIMP HitTestTextRange( UINT32, UINT32, FLOAT, FLOAT, DWRITE_HIT_TEST_METRICS*, UINT32, UINT32* ) { return E_NOTIMPL; }
};
