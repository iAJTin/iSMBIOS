
namespace iTin.Core.Hardware.DeviceInfo
{
    using System;
    using System.Drawing;

    /// <summary>
    /// The <see cref="DesktopDeviceInfo"/> data structure contains information on the desktop associated with a certain screen.
    /// </summary>
    public struct DesktopDeviceInfo : IEquatable<DesktopDeviceInfo>
    {
        #region public enumerations

        #region [public] (enum) Technologies: Types of technology of a device
        /// <summary>
        /// Types of technology of a device.
        /// </summary>
        public enum Technologies
        {
            /// <summary>
            /// Plotter.
            /// </summary>
            Plotter,

            /// <summary>
            /// Pantalla.
            /// </summary>
            RasDisplay,

            /// <summary>
            /// Impresora.
            /// </summary>
            RasPrinter,

            /// <summary>
            /// Cámara.
            /// </summary>
            RasCamera,

            /// <summary>
            /// Secuencia de caracteres.
            /// </summary>
            CharStream,

            /// <summary>
            /// Metafile.
            /// </summary>
            Metafile,

            /// <summary>
            /// Display file.
            /// </summary>
            DispFile
        }
        #endregion

        #region [public] (enum) ShadeBlendCaps: Types of shading and transparency of a device
        /// <summary>
        /// Types of shading and transparency of a device.
        /// </summary>
        public enum ShadeBlendCaps
        {
            /// <summary>
            /// Controls the SourceConstantAlpha member of the BLENDFUNCTION structure, which references the blendFunction parameter of the AlphaBlend function.
            /// </summary>
            ConstAlpha,

            /// <summary>
            /// Indicates the ability to draw rectangles with color gradient.
            /// </summary>
            GradRect,

            /// <summary>
            /// Indicates the ability to draw triangles with color gradient.
            /// </summary>
            GradTri,

            /// <summary>
            /// Indicates that the device does not support any of these capabilities.
            /// </summary>
            None,

            /// <summary>
            /// Indicates the ability to handle the alpha channel for each pixel in the AlphaBlend function (function to show transparent or semi-transparent bitmaps).
            /// </summary>
            PixelAlpha,

            /// <summary>
            /// Indicates the ability to handle the premultiplied alpha channel in AlphaBlend (function to show transparent or semi-transparent bitmaps).
            /// </summary>
            PremultAlpha
        }
        #endregion

        #region [public] (enum) RasterCaps: Indicates the frame capabilities of a device
        /// <summary>
        /// Indicates the frame capabilities of a device.
        /// </summary>
        public enum RasterCaps
        {
            /// <summary>
            /// Requires band support.
            /// </summary>
            Banding,

            /// <summary>
            /// Indicates the ability to transfer bitmaps.
            /// </summary>
            BitBlt,

            /// <summary>
            /// Indicates the ability to support bitmaps larger than 64KB.
            /// </summary>
            Bitmap64,

            /// <summary>
            /// Indicates that it is compatible with the SetDIBits and GetDIBits functions.
            /// </summary>
            DiBitmap,

            /// <summary>
            /// Indicates that it is compatible with the SetDIBitsToDevice function.
            /// </summary>
            DibToDev,

            /// <summary>
            /// Indicates that it is capable of filling.
            /// </summary>
            FloodFill,

            /// <summary>
            /// Specify a device based on the palette.
            /// </summary>
            Palette,

            /// <summary>
            /// Indicates the scalability.
            /// </summary>
            Scaling,

            /// <summary>
            /// Indicates that it is capable of performing the StretchBlt function.
            /// </summary>
            StretchBlt,

            /// <summary>
            /// Indicates that it is capable of performing the StretchDIBits function.
            /// </summary>
            StretchDib
        }
        #endregion

        #region [public] (enum) CurveCaps: Indicates the capabilities to draw curves
        /// <summary>
        /// Indicates the capabilities to draw curves.
        /// </summary>
        public enum CurveCaps
        {
            /// <summary>
            /// Indicates that the device does not support curves.
            /// </summary>
            None,

            /// <summary>
            /// Indicates that the device can draw arcs.
            /// </summary>
            Chord,

            /// <summary>
            /// Indicates that the device can draw circles.
            /// </summary>
            Circles,

            /// <summary>
            /// Indicates that the device can draw ellipses.
            /// </summary>
            Ellipses,

            /// <summary>
            /// Indicates that the device can draw interiors.
            /// </summary>
            Interiors,

            /// <summary>
            /// Indicates that the device can draw shapes.
            /// </summary>
            Pie,

            /// <summary>
            /// Indicates that the device can draw rounded rectangles.
            /// </summary>
            RoundRect,

            /// <summary>
            /// Indicates that the device can draw stylish borders.
            /// </summary>
            Styled,

            /// <summary>
            /// Indicates that the device can draw wide edges.
            /// </summary>
            Wide,

            /// <summary>
            /// Indicates that the device can draw wide and stylish edges.
            /// </summary>
            WideStyled,
        }
        #endregion

        #region [public] (enum) LineCaps: Indicates the capabilities to draw lines
        /// <summary>
        /// Indicates the capabilities to draw lines.
        /// </summary>
        public enum LineCaps
        {
            /// <summary>
            /// Indicates that the device does not support lines.
            /// </summary>
            None,

            /// <summary>
            /// Indicates that the device can draw interiors.
            /// </summary>
            Interiors,

            /// <summary>
            /// Indicates that the device can draw a marker.
            /// </summary>
            Marker,

            /// <summary>
            /// Indicates that the device can draw polyline.
            /// </summary>
            PolyLine,

            /// <summary>
            /// Indicates that the device can draw multiple markers.
            /// </summary>
            PolyMarker,

            /// <summary>
            /// Indicates that the device can draw stylish lines.
            /// </summary>
            Styled,

            /// <summary>
            /// Indicates that the device can draw lines with variable width.
            /// </summary>
            Wide,

            /// <summary>
            /// Indicates that the device can draw lines with variable width and with style.
            /// </summary>
            WideStyled
        }
        #endregion

        #region [public] (enum) PolygonalCaps: Indicates the abilities to draw polygons
        /// <summary>
        /// Indicates the abilities to draw polygons.
        /// </summary>
        public enum PolygonalCaps
        {
            /// <summary>
            /// Indicates that the device does not support polygons.
            /// </summary>
            None,

            /// <summary>
            /// Indicates that the device can draw interiors.
            /// </summary>
            Interiors,

            /// <summary>
            /// Indicates that the device can draw filled polygons.
            /// </summary>
            Polygon,

            /// <summary>
            /// Indicates that the device can draw polyline.
            /// </summary>
            Rectangle,

            /// <summary>
            /// Indicates that the device can draw only one line.
            /// </summary>
            ScanLine,

            /// <summary>
            /// Indicates that the device can draw stylish borders.
            /// </summary>
            Styled,

            /// <summary>
            /// Indicates that the device can draw borders with variable width.
            /// </summary>
            Wide,

            /// <summary>
            /// Indicates that the device can draw borders with variable width and with style.
            /// </summary>
            WideStyled,

            /// <summary>
            /// Indicates that the device can draw filled polygon borders.
            /// </summary>
            WindPolygon
        }
        #endregion

        #region [public] (enum) TextCaps: Indicates the capabilities to draw text
        /// <summary>
        /// Indicates the capabilities to draw text.
        /// </summary>
        public enum TextCaps
        {
            /// <summary>
            /// Indicates that the device is capable of displaying character accuracy.
            /// </summary>
            OpCharacter,

            /// <summary>
            /// Indicates that the device is capable of displaying stroke accuracy.
            /// </summary>
            OpStroke,

            /// <summary>
            /// Indicates that the device is capable of displaying a clip with stroke accuracy.
            /// </summary>
            CpStroke,

            /// <summary>
            /// Indicates that the device is capable of rotating a character 90º.
            /// </summary>
            Cr90,

            /// <summary>
            /// Indicates that the device is capable of rotating a character.
            /// </summary>
            CrAny,

            /// <summary>
            /// Indicates that the device is able to scale independently in the x direction or y direction.
            /// </summary>
            SfXyIndep,

            /// <summary>
            /// Indicates that the device is capable of double-scale character.
            /// </summary>
            SaDouble,

            /// <summary>
            /// Indicates that the device uses only integer multiples to scale a character.
            /// </summary>
            SaInteger,

            /// <summary>
            /// Indicates that the device can scale a character to any multiple.
            /// </summary>
            SaContin,

            /// <summary>
            /// Indicates that the device can draw in bold.
            /// </summary>
            EaDouble,

            /// <summary>
            /// Indicates that the device can draw in italics.
            /// </summary>
            IaAbled,

            /// <summary>
            /// Indicates that the device can draw underlines.
            /// </summary>
            UaAble,

            /// <summary>
            /// Indicates that the device can draw strikeouts.
            /// </summary>
            SoAble,

            /// <summary>
            /// Indicates that the device can draw fonts as bitmap.
            /// </summary>
            RaAble,

            /// <summary>
            /// Indicates that the device can draw vector fonts.
            /// </summary>
            VaAble,

            /// <summary>
            /// Reserved, must be 0.
            /// </summary>
            Reserved,

            /// <summary>
            /// Indicates that the device cannot move through a bit block transfer.
            /// Keep in mind that this meaning may be the opposite of expectations.
            /// </summary>
            ScrollBlt
        }
        #endregion

        #region [public] (enum) ColorMgmtCaps: Indicates the color management capabilities of a device
        /// <summary>
        /// Indicates the color management capabilities of a device.
        /// </summary>
        public enum ColorMgmtCaps
        {
            /// <summary>
            /// Indicates that the device can accept the CMYK color space ICC color profile.
            /// </summary>
            CmykColor,

            /// <summary>
            /// Indicates that the device can perform ICM on the device driver or on the device itself.
            /// </summary>
            DeviceIcm,

            /// <summary>
            /// Indicates that the device supports GetDeviceGammaRamp and SetDeviceGammaRamp.
            /// </summary>
            GammaRamp,

            /// <summary>
            /// Indicates that the device does not support ICM.
            /// </summary>
            None
        }
        #endregion

        #endregion

        #region interfaces

        #region [public] (bool) Equals(DesktopDeviceInfo): Indicates whether the current structure is the same as another structure of the same type
        /// <summary>
        /// Indicates whether the current structure is the same as another structure of the same type.
        /// </summary>
        /// <param name="other">Structure to be compared with this structure.</param>
        /// <returns>
        /// Returns <b>true</b> if the structures are the same; otherwise, <b>false</b>.
        /// </returns>
        public bool Equals(DesktopDeviceInfo other) => other.Equals((object)this);
        #endregion

        #endregion

        #region public operatos

        #region [public] {static} (bool) operator ==(DesktopDeviceInfo, DesktopDeviceInfo): Implements the equality operator (==)
        /// <summary>
        /// Implements the equality operator (==).
        /// </summary>
        /// <param name="left">Operand 1.</param>
        /// <param name="right">Operand 2.</param>
        /// <returns>
        /// Returns <b>true</b> if <c>left</c> is equals to <c>right</c>; <b>false</b> otherwise.
        /// </returns>
        public static bool operator ==(DesktopDeviceInfo left, DesktopDeviceInfo right) => left.Equals(right);
        #endregion

        #region [public] {static} (bool) operator !=(DesktopDeviceInfo, DesktopDeviceInfo): Implements the inequality operator (!=)
        /// <summary>
        /// Implements the inequality operator (!=).
        /// </summary>
        /// <param name="left">Operand 1.</param>
        /// <param name="right">Operand 2.</param>
        /// <returns>
        /// Returns <b>true</b> if <c>left</c> is not equal to <c>right</c>; <b>false</b> otherwise.
        /// </returns>
        public static bool operator !=(DesktopDeviceInfo left, DesktopDeviceInfo right) => !left.Equals(right);
        #endregion

        #endregion

        #region public properties

        #region [public] (int) ColorDepth: Gets or sets a value that represents the color depth of this desktop
        /// <summary>
        /// Gets or sets a value that represents the color depth of this desktop.
        /// </summary>
        /// <value>
        /// Color depth.
        /// </value>
        public int ColorDepth { get; set; }
        #endregion

        #region [public] (int) ColorPlanes: Gets or sets a value that represents the number of color planes of this desktop
        /// <summary>
        /// Gets or sets a value that represents the number of color planes of this desktop.
        /// </summary>
        /// <value>
        /// Number of color planes.
        /// </value>
        public int ColorPlanes { get; set; }
        #endregion

        #region [public] (string) DeviceName: Gets or sets a value that represents the device name
        /// <summary>
        /// Gets or sets a value that represents the device name.
        /// </summary>
        /// <value>
        /// Device name.
        /// </value>
        public string DeviceName { get; set; }
        #endregion

        #region [public] (string) DesktopWallpaper: Gets or sets a string that represents the background of this desktop
        /// <summary>
        /// Gets or sets a string that represents the background of this desktop.
        /// </summary>
        /// <value>
        /// Background of this desk.
        /// </value>
        public string DesktopWallpaper { get; set; }
        #endregion

        #region [public] (Size) FontResolution: Gets or sets a value that represents the number of pixels per inch both horizontally and vertically on this desktop
        /// <summary>
        /// Gets or sets a value that represents the number of pixels per inch both horizontally and vertically on this desktop.
        /// </summary>
        /// <value>
        /// Number of pixels per inch both horizontally and vertically on this desk.
        /// </value>
        public Size FontResolution { get; set; }
        #endregion

        #region [public] (int) PixelDiagonal: Gets or sets a value that represents the monitor that contains this desktop.
        /// <summary>
        /// Gets or sets a value that represents the monitor that contains this desktop.
        /// </summary>
        /// <value>
        /// Diagonal size of a pixel.
        /// </value>
        public int PixelDiagonal { get; set; }
        #endregion

        #region [public] (Size) PixelSize: Gets or sets a value that represents the size of a pixel on the desktop
        /// <summary>
        /// Gets or sets a value that represents the size of a pixel on the desktop.
        /// </summary>
        /// <value>
        /// Size of a pixel
        /// </value>
        public Size PixelSize { get; set; }
        #endregion

        #region [public] (Size) Resolution: Gets or sets a value that represents the resolution of this desktop, in pixels
        /// <summary>
        /// Gets or sets a value that represents the resolution of this desktop, in pixels.
        /// </summary>
        /// <value>
        /// Resolution of this desktop, in pixels.
        /// </value>
        public Size Resolution { get; set; }
        #endregion

        #region [public] (Technologies) Technology: Gets or sets a value that represents the type of device technology
        /// <summary>
        /// Gets or sets a value that represents the type of device technology.
        /// </summary>
        /// <value>
        /// Type of device technology.
        /// </value>
        public Technologies Technology { get; set; }
        #endregion

        #region [public] (int) Gets or sets a value that represents the vertical refresh rate of this desktop, in hertz (Hz)
        /// <summary>
        /// Gets or sets a value that represents the vertical refresh rate of this desktop, in hertz (Hz).
        /// </summary>
        /// <value>
        /// Vertical resolution of this desktop, in pixels.
        /// </value>
        public int VerticalRefreshRate { get; set; }
        #endregion

        #endregion

        #region public override methods

        #region [public] {override} (int) GetHashCode(): Returns a value that represents the hash code of this structure
        /// <summary>
        /// Returns a value that represents the hash code of this structure.
        /// </summary>
        /// <returns>
        /// Hash code of this structure.
        /// </returns>
        public override int GetHashCode() => Resolution.Width ^ Resolution.Height ^ ColorDepth ^ VerticalRefreshRate;

        #endregion

        #region [public] {override} (bool) Equals(object obj): Returns a value that indicates whether this structure is the same as another
        /// <summary>
        /// Returns a value that indicates whether this structure is the same as another.
        /// </summary>
        /// <param name="obj">Structure to compare.</param>
        /// <returns>
        /// Result of the equality comparison.
        /// </returns>
        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }

            if (!(obj is DesktopDeviceInfo))
            {
                return false;
            }

            var other = (DesktopDeviceInfo)obj;

            return 
                other.Resolution.Width == Resolution.Width &&
                other.Resolution.Height == Resolution.Height &&
                other.ColorDepth == ColorDepth &&
                other.VerticalRefreshRate == VerticalRefreshRate;
        }
        #endregion

        #region [public] {override} (string) ToString(): Returns a string that represents the current structure
        /// <summary>
        /// Returns a string that represents the current structure.
        /// </summary>
        /// <returns>
        /// String representing the current structure.
        /// </returns>
        public override string ToString() => $"{Resolution.Width} x {Resolution.Height}, {ColorDepth} bits, {VerticalRefreshRate}hz";
        #endregion

        #endregion
    }
}
