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
//     Structs for SlimDX2.Direct2D1 namespace.
//     This code was generated by a tool.
//     Date : 11/15/2010 14:52:48
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using System.Runtime.InteropServices;

namespace SlimDX2.Direct2D1 {

    
    /// <summary>	
    ///  Contains the data format and alpha mode for a bitmap or render target. 	
    /// </summary>	
    /// <remarks>	
    /// For more information about the pixel formats and alpha modes supported by each render target, see {{Supported Pixel Formats and Alpha Modes}}.	
    /// </remarks>	
    /// <unmanaged>D2D1_PIXEL_FORMAT</unmanaged>
    [StructLayout(LayoutKind.Sequential, Pack = 0 )]
    public  partial struct PixelFormat {	
        
        /// <summary>	
        /// A value that specifies the size and arrangement of channels in each pixel.	
        /// </summary>	
        /// <unmanaged>DXGI_FORMAT format</unmanaged>
        public SlimDX2.DXGI.Format Format;
        
        /// <summary>	
        /// A value that specifies whether the alpha channel is using pre-multiplied alpha, straight alpha, whether it should be ignored and considered opaque, or whether it is unkown.  	
        /// </summary>	
        /// <unmanaged>D2D1_ALPHA_MODE alphaMode</unmanaged>
        public SlimDX2.Direct2D1.AlphaMode AlphaMode;
    }
    
    /// <summary>	
    /// Describes the pixel format and dpi  of a bitmap.	
    /// </summary>	
    /// <unmanaged>D2D1_BITMAP_PROPERTIES</unmanaged>
    [StructLayout(LayoutKind.Sequential, Pack = 0 )]
    public  partial struct BitmapProperties {	
        
        /// <summary>	
        /// The bitmap's pixel format and alpha mode.	
        /// </summary>	
        /// <unmanaged>D2D1_PIXEL_FORMAT pixelFormat</unmanaged>
        public SlimDX2.Direct2D1.PixelFormat PixelFormat;
        
        /// <summary>	
        /// The horizontal dpi of the bitmap.	
        /// </summary>	
        /// <unmanaged>float dpiX</unmanaged>
        public float DpiX;
        
        /// <summary>	
        /// The vertical dpi of the bitmap.	
        /// </summary>	
        /// <unmanaged>float dpiY</unmanaged>
        public float DpiY;
    }
    
    /// <summary>	
    ///  Contains the position and color of a gradient stop. 	
    /// </summary>	
    /// <remarks>	
    /// Gradient stops can be specified in any order if they are at different positions. Two stops may share a position. In this case, the first stop specified is treated as the "low" stop (nearer 0.0f) and subsequent stops are treated as "higher" (nearer 1.0f). This behavior is useful if a caller wants an instant transition in the middle of a stop.Typically, there are at least two points in a collection, although creation with only one stop is permitted. For example, one point is at position 0.0f, another point is at position 1.0f, and additional points are distributed in the [0, 1] range. Where the gradient progression is beyond the range of [0, 1], the stops are stored, but may affect the gradient. When drawn, the [0, 1] range of positions is mapped to the brush, in a brush-dependent way. For details, see <see cref="SlimDX2.Direct2D1.LinearGradientBrush"/> and <see cref="SlimDX2.Direct2D1.RadialGradientBrush"/>. Gradient stops with a position outside the [0, 1] range cannot be seen explicitly, but they can still affect the colors produced in the [0, 1] range. For example, a two-stop gradient {{0.0f, Black}, {2.0f, White}} is indistinguishable visually from {{0.0f, Black}, {1.0f, Mid-level gray}}. Also, the colors are clamped before interpolation.	
    /// </remarks>	
    /// <unmanaged>D2D1_GRADIENT_STOP</unmanaged>
    [StructLayout(LayoutKind.Sequential, Pack = 0 )]
    public  partial struct GradientStop {	
        
        /// <summary>	
        /// A value that indicates the relative position of the gradient stop in the brush. This value must be in the [0.0f, 1.0f] range if the gradient stop is to be seen explicitly. 	
        /// </summary>	
        /// <unmanaged>float position</unmanaged>
        public float Position;
        
        /// <summary>	
        /// The color of the gradient stop.	
        /// </summary>	
        /// <unmanaged>D2D1_COLOR_F color</unmanaged>
        public SlimMath.Color4 Color;
    }
    
    /// <summary>	
    ///  Describes the opacity and transformation of a brush.	
    /// </summary>	
    /// <remarks>	
    /// This structure is used when creating a brush. For convenience, Direct2D provides the {{D2D1::BrushProperties}} function for creating D2D1_BRUSH_PROPERTIES structures.After creating a brush, you can change its opacity or transform by calling the {{SetOpacity}} or {{SetTransform}} methods.	
    /// </remarks>	
    /// <unmanaged>D2D1_BRUSH_PROPERTIES</unmanaged>
    [StructLayout(LayoutKind.Sequential, Pack = 0 )]
    public  partial struct BrushProperties {	
        
        /// <summary>	
        /// A value between 0.0f and 1.0f, inclusive, that specifies the degree of opacity of the brush.	
        /// </summary>	
        /// <unmanaged>float opacity</unmanaged>
        public float Opacity;
        
        /// <summary>	
        /// The transformation that is applied to the brush.	
        /// </summary>	
        /// <unmanaged>D2D1_MATRIX_3X2_F transform</unmanaged>
        public SlimDX2.Direct2D1.Matrix3x2 Transform;
    }
    
    /// <summary>	
    ///  Describes the extend modes and the interpolation mode of an <see cref="SlimDX2.Direct2D1.BitmapBrush"/>.	
    /// </summary>	
    /// <unmanaged>D2D1_BITMAP_BRUSH_PROPERTIES</unmanaged>
    [StructLayout(LayoutKind.Sequential, Pack = 0 )]
    public  partial struct BitmapBrushProperties {	
        
        /// <summary>	
        /// A value that describes how the brush horizontally tiles those areas that extend past its bitmap.	
        /// </summary>	
        /// <unmanaged>D2D1_EXTEND_MODE extendModeX</unmanaged>
        public SlimDX2.Direct2D1.ExtendMode ExtendModeX;
        
        /// <summary>	
        /// A value that describes how the brush vertically tiles those areas that extend past its bitmap.	
        /// </summary>	
        /// <unmanaged>D2D1_EXTEND_MODE extendModeY</unmanaged>
        public SlimDX2.Direct2D1.ExtendMode ExtendModeY;
        
        /// <summary>	
        /// A value that specifies how the bitmap is interpolated when it is scaled or rotated.	
        /// </summary>	
        /// <unmanaged>D2D1_BITMAP_INTERPOLATION_MODE interpolationMode</unmanaged>
        public SlimDX2.Direct2D1.BitmapInterpolationMode InterpolationMode;
    }
    
    /// <summary>	
    ///  Contains the starting point and endpoint of the gradient axis for an <see cref="SlimDX2.Direct2D1.LinearGradientBrush"/>. 	
    /// </summary>	
    /// <remarks>	
    /// Use this method when creating new <see cref="SlimDX2.Direct2D1.LinearGradientBrush"/> objects with the {{CreateLinearGradientBrush}} method. For convenience, Direct2D provides the {{D2D1::LinearGradientBrushProperties}} helper function for creating new D2D1_LINEAR_GRADIENT_BRUSH_PROPERTIES structures.The following illustration shows how a linear gradient changes as you change its start and end points.  For the first gradient, the start point is set to (0,0) and the end point to (150, 50); this creates a diagonal gradient that starts at the upper-left corner and extends to the lower-right corner of the area being painted. When you set the start point to (0, 25) and the end point to (150, 25), a horizontal gradient is created. Similarly, setting the start point  to (75, 0) and the end point to (75, 50) creates a vertical gradient. Setting the start point to  (0, 50) and the end point to (150, 0)  creates a diagonal gradient that starts at the lower-left corner and extends to the upper-right corner of the area being painted.?Illustration of four gradients with different axes?	
    /// </remarks>	
    /// <unmanaged>D2D1_LINEAR_GRADIENT_BRUSH_PROPERTIES</unmanaged>
    [StructLayout(LayoutKind.Sequential, Pack = 0 )]
    public  partial struct LinearGradientBrushProperties {	
        
        /// <summary>	
        /// In the brush's coordinate space, the starting point  of the gradient axis. 	
        /// </summary>	
        /// <unmanaged>D2D1_POINT_2F startPoint</unmanaged>
        public System.Drawing.PointF StartPoint;
        
        /// <summary>	
        /// In the brush's coordinate space, the endpoint  of the gradient axis.  	
        /// </summary>	
        /// <unmanaged>D2D1_POINT_2F endPoint</unmanaged>
        public System.Drawing.PointF EndPoint;
    }
    
    /// <summary>	
    ///  Contains the gradient origin offset and the size and position of the gradient ellipse for an <see cref="SlimDX2.Direct2D1.RadialGradientBrush"/>. 	
    /// </summary>	
    /// <remarks>	
    /// Different values for center,  gradientOriginOffset,  radiusX and/or radiusY produce different gradients.   The following illustration shows several radial gradients that have different gradient origin offsets, creating the appearance of the light illuminating the circles from different angles.?Illustration of four circles with radial gradients that have different origin offsets?For convenience, Direct2D provides the {{D2D1::RadialGradientBrushProperties}} function for creating new D2D1_RADIAL_GRADIENT_BRUSH structures.	
    /// </remarks>	
    /// <unmanaged>D2D1_RADIAL_GRADIENT_BRUSH_PROPERTIES</unmanaged>
    [StructLayout(LayoutKind.Sequential, Pack = 0 )]
    public  partial struct RadialGradientBrushProperties {	
        
        /// <summary>	
        /// In the brush's coordinate space, the center of the gradient ellipse.	
        /// </summary>	
        /// <unmanaged>D2D1_POINT_2F center</unmanaged>
        public System.Drawing.PointF Center;
        
        /// <summary>	
        /// In the brush's coordinate space, the offset of the gradient origin relative to the gradient ellipse's center.	
        /// </summary>	
        /// <unmanaged>D2D1_POINT_2F gradientOriginOffset</unmanaged>
        public System.Drawing.PointF GradientOriginOffset;
        
        /// <summary>	
        /// In the brush's coordinate space, the x-radius  of the gradient ellipse.	
        /// </summary>	
        /// <unmanaged>float radiusX</unmanaged>
        public float RadiusX;
        
        /// <summary>	
        /// In the brush's coordinate space, the y-radius  of the gradient ellipse.	
        /// </summary>	
        /// <unmanaged>float radiusY</unmanaged>
        public float RadiusY;
    }
    
    /// <summary>	
    /// Represents a cubic bezier segment drawn  between two points.	
    /// </summary>	
    /// <remarks>	
    ///  A cubic Bezier curve is defined by four points: a start point, an end point (point3), and two control points (point1 and point2). A Bezier segment does not contain a property for the starting point of the curve; it defines only the end point. The beginning point of the curve is the current point of the path to which the Bezier curve is added. The two control points of a cubic Bezier curve behave like magnets, attracting portions of what would otherwise be a straight line toward themselves and producing a curve. The first control point, point1, affects the beginning portion of the curve; the second control point, point2, affects the ending portion of the curve. Note??The curve doesn't necessarily pass through either of the control points; each control point moves its portion of the line toward itself, but not through itself.	
    /// </remarks>	
    /// <unmanaged>D2D1_BEZIER_SEGMENT</unmanaged>
    [StructLayout(LayoutKind.Sequential, Pack = 0 )]
    public  partial struct BezierSegment {	
        
        /// <summary>	
        /// The first control point for the Bezier segment.	
        /// </summary>	
        /// <unmanaged>D2D1_POINT_2F point1</unmanaged>
        public System.Drawing.PointF Point1;
        
        /// <summary>	
        /// The second control point for the Bezier segment.	
        /// </summary>	
        /// <unmanaged>D2D1_POINT_2F point2</unmanaged>
        public System.Drawing.PointF Point2;
        
        /// <summary>	
        /// The end point for the Bezier segment.	
        /// </summary>	
        /// <unmanaged>D2D1_POINT_2F point3</unmanaged>
        public System.Drawing.PointF Point3;
    }
    
    /// <summary>	
    /// Contains the three vertices that describe a triangle.	
    /// </summary>	
    /// <unmanaged>D2D1_TRIANGLE</unmanaged>
    [StructLayout(LayoutKind.Sequential, Pack = 0 )]
    public  partial struct Triangle {	
        
        /// <summary>	
        /// The first vertex of a triangle.	
        /// </summary>	
        /// <unmanaged>D2D1_POINT_2F point1</unmanaged>
        public System.Drawing.PointF Point1;
        
        /// <summary>	
        /// The second vertex of a triangle.	
        /// </summary>	
        /// <unmanaged>D2D1_POINT_2F point2</unmanaged>
        public System.Drawing.PointF Point2;
        
        /// <summary>	
        /// The third vertex of a triangle.	
        /// </summary>	
        /// <unmanaged>D2D1_POINT_2F point3</unmanaged>
        public System.Drawing.PointF Point3;
    }
    
    /// <summary>	
    /// Describes an elliptical arc between two points.	
    /// </summary>	
    /// <unmanaged>D2D1_ARC_SEGMENT</unmanaged>
    [StructLayout(LayoutKind.Sequential, Pack = 0 )]
    public  partial struct ArcSegment {	
        
        /// <summary>	
        /// The end point of the arc.	
        /// </summary>	
        /// <unmanaged>D2D1_POINT_2F point</unmanaged>
        public System.Drawing.PointF Point;
        
        /// <summary>	
        /// The x-radius and y-radius of the arc.	
        /// </summary>	
        /// <unmanaged>D2D1_SIZE_F size</unmanaged>
        public System.Drawing.SizeF Size;
        
        /// <summary>	
        /// A value that specifies how many degrees in the clockwise direction the ellipse is rotated relative to the current coordinate system.	
        /// </summary>	
        /// <unmanaged>float rotationAngle</unmanaged>
        public float RotationAngle;
        
        /// <summary>	
        /// A value that specifies whether the arc sweep is clockwise or counterclockwise.	
        /// </summary>	
        /// <unmanaged>D2D1_SWEEP_DIRECTION sweepDirection</unmanaged>
        public SlimDX2.Direct2D1.SweepDirection SweepDirection;
        
        /// <summary>	
        /// A value that specifies whether the given arc is larger than 180 degrees.	
        /// </summary>	
        /// <unmanaged>D2D1_ARC_SIZE arcSize</unmanaged>
        public SlimDX2.Direct2D1.ArcSize ArcSize;
    }
    
    /// <summary>	
    ///  Contains the control point and end point for a quadratic Bezier segment.	
    /// </summary>	
    /// <unmanaged>D2D1_QUADRATIC_BEZIER_SEGMENT</unmanaged>
    [StructLayout(LayoutKind.Sequential, Pack = 0 )]
    public  partial struct QuadraticBezierSegment {	
        
        /// <summary>	
        /// The control point of the quadratic Bezier segment.	
        /// </summary>	
        /// <unmanaged>D2D1_POINT_2F point1</unmanaged>
        public System.Drawing.PointF Point1;
        
        /// <summary>	
        /// The end point of the quadratic Bezier segment.	
        /// </summary>	
        /// <unmanaged>D2D1_POINT_2F point2</unmanaged>
        public System.Drawing.PointF Point2;
    }
    
    /// <summary>	
    ///  Contains the center point, x-radius, and y-radius of an ellipse.	
    /// </summary>	
    /// <unmanaged>D2D1_ELLIPSE</unmanaged>
    [StructLayout(LayoutKind.Sequential, Pack = 0 )]
    public  partial struct Ellipse {	
        
        /// <summary>	
        /// The center point of the ellipse.	
        /// </summary>	
        /// <unmanaged>D2D1_POINT_2F point</unmanaged>
        public System.Drawing.PointF Point;
        
        /// <summary>	
        /// The X-radius of the ellipse.	
        /// </summary>	
        /// <unmanaged>float radiusX</unmanaged>
        public float RadiusX;
        
        /// <summary>	
        /// The Y-radius of the ellipse.	
        /// </summary>	
        /// <unmanaged>float radiusY</unmanaged>
        public float RadiusY;
    }
    
    /// <summary>	
    ///  Contains the dimensions and corner radii of a rounded rectangle.	
    /// </summary>	
    /// <remarks>	
    /// Each corner of the rectangle specified by the rect is replaced with a quarter ellipse, with a radius in each direction specified by radiusX and radiusY. If the radiusX is greater than or equal to half the width of the rectangle, and the radiusY is greater than or equal to one-half the height, the rounded rectangle is an ellipse with the same width and height of the rect. Even when both radiuX and radiusY are zero, the rounded rectangle is different from a rectangle., When stroked, the corners of the rounded rectangle are roundly joined, not mitered (square). 	
    /// </remarks>	
    /// <unmanaged>D2D1_ROUNDED_RECT</unmanaged>
    [StructLayout(LayoutKind.Sequential, Pack = 0 )]
    public  partial struct RoundedRect {	
        
        /// <summary>	
        /// The coordinates of the rectangle.	
        /// </summary>	
        /// <unmanaged>D2D1_RECT_F rect</unmanaged>
        public SlimDX2.RectangleF Rect;
        
        /// <summary>	
        /// The x-radius for the quarter ellipse that is drawn to replace every corner of the rectangle.	
        /// </summary>	
        /// <unmanaged>float radiusX</unmanaged>
        public float RadiusX;
        
        /// <summary>	
        /// The y-radius for the quarter ellipse that is drawn to replace every corner of the rectangle.	
        /// </summary>	
        /// <unmanaged>float radiusY</unmanaged>
        public float RadiusY;
    }
    
    /// <summary>	
    ///  Describes the stroke that outlines a shape. 	
    /// </summary>	
    /// <remarks>	
    /// The following illustration shows different dashOffset values for the same custom dash style.?Illustration of four dashes with the same style and different dashOffset values?	
    /// </remarks>	
    /// <unmanaged>D2D1_STROKE_STYLE_PROPERTIES</unmanaged>
    [StructLayout(LayoutKind.Sequential, Pack = 0 )]
    public  partial struct StrokeStyleProperties {	
        
        /// <summary>	
        /// The cap applied to the start of all the open figures in a stroked geometry.	
        /// </summary>	
        /// <unmanaged>D2D1_CAP_STYLE startCap</unmanaged>
        public SlimDX2.Direct2D1.CapStyle StartCap;
        
        /// <summary>	
        /// The cap applied to the end of all the open figures in a stroked geometry.	
        /// </summary>	
        /// <unmanaged>D2D1_CAP_STYLE endCap</unmanaged>
        public SlimDX2.Direct2D1.CapStyle EndCap;
        
        /// <summary>	
        /// The shape  at either end of each dash segment.	
        /// </summary>	
        /// <unmanaged>D2D1_CAP_STYLE dashCap</unmanaged>
        public SlimDX2.Direct2D1.CapStyle DashCap;
        
        /// <summary>	
        /// A value that describes how segments are joined. This value is ignored for a vertex if the segment flags specify that the segment should have a smooth join. 	
        /// </summary>	
        /// <unmanaged>D2D1_LINE_JOIN lineJoin</unmanaged>
        public SlimDX2.Direct2D1.LineJoin LineJoin;
        
        /// <summary>	
        /// The limit of the thickness of the join on a mitered corner. This value is always treated as though it is greater than or equal to 1.0f. 	
        /// </summary>	
        /// <unmanaged>float miterLimit</unmanaged>
        public float MiterLimit;
        
        /// <summary>	
        /// A value that specifies whether the stroke has a dash pattern and, if so, the dash style. 	
        /// </summary>	
        /// <unmanaged>D2D1_DASH_STYLE dashStyle</unmanaged>
        public SlimDX2.Direct2D1.DashStyle DashStyle;
        
        /// <summary>	
        /// A value that specifies an offset in the dash sequence.   A positive dash offset value  shifts the dash pattern, in units of  stroke width, toward the start of the stroked geometry.  A negative dash offset value  shifts the dash pattern, in units of  stroke width, toward the end of the stroked geometry.	
        /// </summary>	
        /// <unmanaged>float dashOffset</unmanaged>
        public float DashOffset;
    }
    
    /// <summary>	
    ///  Contains the content bounds, mask information, opacity settings, and other options for a layer resource. 	
    /// </summary>	
    /// <unmanaged>D2D1_LAYER_PARAMETERS</unmanaged>
    [StructLayout(LayoutKind.Sequential, Pack = 0 )]
    public  partial struct LayerParameters {	
        
        /// <summary>	
        /// The content bounds of the layer. Content outside these bounds is not guaranteed to render.	
        /// </summary>	
        /// <unmanaged>D2D1_RECT_F contentBounds</unmanaged>
        public SlimDX2.RectangleF ContentBounds;
        
        /// <summary>	
        /// The geometric mask specifies the area of the layer that is composited into the render target. 	
        /// </summary>	
        /// <unmanaged>ID2D1Geometry* geometricMask</unmanaged>
        public IntPtr GeometricMask;
        
        /// <summary>	
        /// A value that specifies the antialiasing mode for the geometricMask.  	
        /// </summary>	
        /// <unmanaged>D2D1_ANTIALIAS_MODE maskAntialiasMode</unmanaged>
        public SlimDX2.Direct2D1.AntialiasMode MaskAntialiasMode;
        
        /// <summary>	
        ///  A value that specifies the transform that is applied to the geometric mask when composing the layer.	
        /// </summary>	
        /// <unmanaged>D2D1_MATRIX_3X2_F maskTransform</unmanaged>
        public SlimDX2.Direct2D1.Matrix3x2 MaskTransform;
        
        /// <summary>	
        /// An opacity value that is applied uniformly to all resources in the layer when compositing to the target.	
        /// </summary>	
        /// <unmanaged>float opacity</unmanaged>
        public float Opacity;
        
        /// <summary>	
        /// A brush that is used to modify the opacity of the layer. The brush 	
        /// is mapped to the layer, and the alpha channel of each mapped brush pixel is multiplied against the corresponding layer pixel. 	
        /// </summary>	
        /// <unmanaged>ID2D1Brush* opacityBrush</unmanaged>
        public IntPtr OpacityBrush;
        
        /// <summary>	
        ///  A value that specifies whether the layer intends to render text with ClearType antialiasing.	
        /// </summary>	
        /// <unmanaged>D2D1_LAYER_OPTIONS layerOptions</unmanaged>
        public SlimDX2.Direct2D1.LayerOptions LayerOptions;
    }
    
    /// <summary>	
    ///  Contains rendering options (hardware or software), pixel format, DPI information, remoting options, and Direct3D support requirements for a render target. 	
    /// </summary>	
    /// <remarks>	
    /// Use this structure when creating a render target, or use it with the <see cref="SlimDX2.Direct2D1.RenderTarget.IsSupported"/> method to check the properties supported by an existing render target.As a convenience, Direct2D provides the {{D2D1::RenderTargetProperties}} helper function for creating D2D1_RENDER_TARGET_PROPERTIES structures. An easy way to create a D2D1_RENDER_TARGET_PROPERTIES structure that works for most render targets is to call the function without specifying any parameters. Doing so creates a D2D1_RENDER_TARGET_PROPERTIES structure that has its fields set to default values. For more information, see   {{D2D1::RenderTargetProperties}}.Not all render targets support hardware rendering. For a list, see the {{Render Targets Overview}}.Using Default DPI SettingsTo use the default DPI, set dpiX and dpiY to 0. The default DPI varies depending on the render target:For a compatible render target, the default DPI is the DPI of the parent render target.For a <see cref="SlimDX2.Direct2D1.HwndRenderTarget"/>, the default DPI is the system DPI obtained from the render target's <see cref="SlimDX2.Direct2D1.Factory"/>.For other render targets, the default DPI is 96.To use the default DPI setting, both dpiX and dpiY must be set to 0. Setting only one value to 0 causes an  {{E_INVALIDARG}} error when attempting to create a render target.	
    /// </remarks>	
    /// <unmanaged>D2D1_RENDER_TARGET_PROPERTIES</unmanaged>
    [StructLayout(LayoutKind.Sequential, Pack = 0 )]
    public  partial struct RenderTargetProperties {	
        
        /// <summary>	
        /// A value that specifies whether the render target should force hardware or software rendering. A value of <see cref="SlimDX2.Direct2D1.RenderTargetType.Default"/> specifies that the render target should use hardware rendering if it is available; otherwise, it uses software rendering. Note that WIC bitmap render targets do not support hardware rendering.	
        /// </summary>	
        /// <unmanaged>D2D1_RENDER_TARGET_TYPE type</unmanaged>
        public SlimDX2.Direct2D1.RenderTargetType Type;
        
        /// <summary>	
        /// The pixel format and alpha mode of the render target. You can use the {{D2D1::PixelFormat}} function to create a pixel format that specifies that Direct2D should select the pixel format and alpha mode for you. For a list of pixel formats and alpha modes supported by each render target, see {{Supported Pixel Formats and Alpha Modes}}.	
        /// </summary>	
        /// <unmanaged>D2D1_PIXEL_FORMAT pixelFormat</unmanaged>
        public SlimDX2.Direct2D1.PixelFormat PixelFormat;
        
        /// <summary>	
        /// The horizontal DPI of the render target.  To use the default DPI, set dpiX and dpiY to 0. For more information, see the Remarks section. 	
        /// </summary>	
        /// <unmanaged>float dpiX</unmanaged>
        public float DpiX;
        
        /// <summary>	
        /// The vertical DPI of the render target. To use the default DPI, set dpiX and dpiY to 0.  For more information, see the Remarks section. 	
        /// </summary>	
        /// <unmanaged>float dpiY</unmanaged>
        public float DpiY;
        
        /// <summary>	
        /// A value that specifies how the render target is remoted and whether it should be GDI-compatible.  Set to <see cref="SlimDX2.Direct2D1.RenderTargetUsage.None"/> to create a render target that is not compatible with GDI and uses Direct3D command-stream remoting if it  is available. 	
        /// </summary>	
        /// <unmanaged>D2D1_RENDER_TARGET_USAGE usage</unmanaged>
        public SlimDX2.Direct2D1.RenderTargetUsage Usage;
        
        /// <summary>	
        /// A value that specifies the minimum Direct3D feature level required for hardware rendering. If the specified minimum level is not available, the render target uses software rendering if the type  member is set to <see cref="SlimDX2.Direct2D1.RenderTargetType.Default"/>; if  type  is set to to D2D1_RENDER_TARGET_TYPE_HARDWARE, render target creation fails. A value of <see cref="SlimDX2.Direct2D1.FeatureLevel.Level_DEFAULT"/> indicates that Direct2D should determine whether the Direct3D feature level of the device is adequate. This field is used only when creating <see cref="SlimDX2.Direct2D1.HwndRenderTarget"/> and <see cref="SlimDX2.Direct2D1.DCRenderTarget"/> objects.	
        /// </summary>	
        /// <unmanaged>D2D1_FEATURE_LEVEL minLevel</unmanaged>
        public SlimDX2.Direct2D1.FeatureLevel MinLevel;
    }
    
    /// <summary>	
    ///  Contains the HWND, pixel size, and presentation options for an <see cref="SlimDX2.Direct2D1.HwndRenderTarget"/>.	
    /// </summary>	
    /// <remarks>	
    /// Use this structure when you call the {{CreateHwndRenderTarget}} method to create a new <see cref="SlimDX2.Direct2D1.HwndRenderTarget"/>.For convenience, Direct2D provides the {{D2D1::HwndRenderTargetProperties}} function for creating new D2D1_HWND_RENDER_TARGET_PROPERTIES structures.	
    /// </remarks>	
    /// <unmanaged>D2D1_HWND_RENDER_TARGET_PROPERTIES</unmanaged>
    [StructLayout(LayoutKind.Sequential, Pack = 0 )]
    public  partial struct HwndRenderTargetProperties {	
        
        /// <summary>	
        /// The HWND to which the render target issues the output from its drawing commands.	
        /// </summary>	
        /// <unmanaged>void* hwnd</unmanaged>
        public IntPtr Hwnd;
        
        /// <summary>	
        /// The size of the render target, in pixels.	
        /// </summary>	
        /// <unmanaged>D2D1_SIZE_U pixelSize</unmanaged>
        public System.Drawing.Size PixelSize;
        
        /// <summary>	
        /// A value that specifies whether the render target retains the frame after it is presented and whether the render target waits for the device to refresh before presenting.	
        /// </summary>	
        /// <unmanaged>D2D1_PRESENT_OPTIONS presentOptions</unmanaged>
        public SlimDX2.Direct2D1.PresentOptions PresentOptions;
    }
    
    /// <summary>	
    /// Describes the drawing state of a render target.  	
    /// </summary>	
    /// <unmanaged>D2D1_DRAWING_STATE_DESCRIPTION</unmanaged>
    [StructLayout(LayoutKind.Sequential, Pack = 0 )]
    public  partial struct DrawingStateDescription {	
        
        /// <summary>	
        /// The antialiasing mode for subsequent nontext drawing operations. 	
        /// </summary>	
        /// <unmanaged>D2D1_ANTIALIAS_MODE antialiasMode</unmanaged>
        public SlimDX2.Direct2D1.AntialiasMode AntialiasMode;
        
        /// <summary>	
        /// The antialiasing mode for subsequent text and glyph drawing operations.	
        /// </summary>	
        /// <unmanaged>D2D1_TEXT_ANTIALIAS_MODE textAntialiasMode</unmanaged>
        public SlimDX2.Direct2D1.TextAntialiasMode TextAntialiasMode;
        
        /// <summary>	
        /// A label for subsequent drawing operations.	
        /// </summary>	
        /// <unmanaged>D2D1_TAG tag1</unmanaged>
        public long Tag1;
        
        /// <summary>	
        /// A label for subsequent drawing operations.	
        /// </summary>	
        /// <unmanaged>D2D1_TAG tag2</unmanaged>
        public long Tag2;
        
        /// <summary>	
        /// The transformation to apply to subsequent drawing operations.	
        /// </summary>	
        /// <unmanaged>D2D1_MATRIX_3X2_F transform</unmanaged>
        public SlimDX2.Direct2D1.Matrix3x2 Transform;
    }
    
    /// <summary>	
    /// Contains the debugging level of an <see cref="SlimDX2.Direct2D1.Factory"/> object. 	
    /// </summary>	
    /// <remarks>	
    /// To enable debugging, you must install the {{Direct2D Debug Layer}}.	
    /// </remarks>	
    /// <unmanaged>D2D1_FACTORY_OPTIONS</unmanaged>
    [StructLayout(LayoutKind.Sequential, Pack = 0 )]
    public  partial struct FactoryOptions {	
        
        /// <summary>	
        /// The debugging level of the <see cref="SlimDX2.Direct2D1.Factory"/> object.	
        /// </summary>	
        /// <unmanaged>D2D1_DEBUG_LEVEL debugLevel</unmanaged>
        public SlimDX2.Direct2D1.DebugLevel DebugLevel;
    }
}
