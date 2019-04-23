
namespace iTin.Core.Interop.Windows.Development.DocumentAndPrinting.Printing.GdiPrint
{
    using System;
    using System.Diagnostics.CodeAnalysis;
    using System.Runtime.InteropServices;

    using Graphics.Legacy.Gdi.Metafiles;

    /// <summary>
    /// The data structure <strong>DEVMODE</strong> contains information for the initialization of a printer or a display device.
    /// </summary>
    /// <remarks>
    /// For more information, please see http://msdn.microsoft.com/es-es/library/dd183565.aspx.
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
    [SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", MessageId = "DEVMODE")]
    struct DEVMODE : IEquatable<DEVMODE>
    {
        #region public constants
        /// <summary>
        /// Indicates that the current configuration for the display device will be retrieved.
        /// </summary>
        [SuppressMessage("Microsoft.Naming", "CA1707:IdentifiersShouldNotContainUnderscores")]
        [SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", MessageId = "ENUM")] 
        [SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", MessageId = "CURRENT")]
        [SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", MessageId = "SETTINGS")]
        public const int ENUM_CURRENT_SETTINGS = -1;

        /// <summary>
        /// Indicates that the configuration of the display device that is stored in the registry will be recovered.
        /// </summary>
        [SuppressMessage("Microsoft.Naming", "CA1707:IdentifiersShouldNotContainUnderscores")]
        [SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", MessageId = "ENUM")]
        [SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", MessageId = "REGISTRY")]
        [SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", MessageId = "SETTINGS")]
        public const int ENUM_REGISTRY_SETTINGS = -2;
        #endregion

        #region private constants
        private const int CCHFORMNAME = 0x20;
        private const int CCHDEVICENAME = 0x20;
        #endregion

        #region public enumerations

        #region [public] (enum) DM: Enumeration of members of a structure of type DEVMODE
        /// <summary>
        /// Enumeration of members of a structure of type <see cref="DEVMODE"/>.
        /// </summary>
        /// <remarks>
        /// For more information, see <strong>dmFields</strong> section at http://msdn.microsoft.com/en-us/library/dd183565.aspx.
        /// </remarks>
        [Flags]
        public enum DM
        {
            /// <summary>
            /// For more information, please see <see cref="DEVMODE.dmOrientation" /> field.
            /// </summary>
            Orientation = 0x1,

            /// <summary>
            /// For more information, please see <see cref="DEVMODE.dmPaperSize"/> field.
            /// </summary>
            PaperSize = 0x2,

            /// <summary>
            /// For more information, please see <see cref="DEVMODE.dmPaperLength"/> field.
            /// </summary>
            PaperLength = 0x4,

            /// <summary>
            /// For more information, please see <see cref="DEVMODE.dmPaperWidth"/> field.
            /// </summary>
            PaperWidth = 0x8,

            /// <summary>
            /// For more information, please see <see cref="DEVMODE.dmScale"/> field.
            /// </summary>
            Scale = 0x10,

            /// <summary>
            /// For more information, please see <see cref="DEVMODE.dmPosition"/> field.
            /// </summary>
            Position = 0x20,

            /// <summary>
            /// For more information, please see <see cref="DEVMODE.dmNup"/> field.
            /// </summary>
            Nup = 0x40,

            /// <summary>
            /// For more information, please see <see cref="DEVMODE.dmDisplayOrientation"/> field.
            /// </summary>
            DisplayOrientation = 0x80,

            /// <summary>
            /// For more information, please see <see cref="DEVMODE.dmCopies"/> field.
            /// </summary>
            Copies = 0x100,

            /// <summary>
            /// For more information, please see <see cref="DEVMODE.dmDefaultSource"/> field.
            /// </summary>
            DefaultSource = 0x200,

            /// <summary>
            /// For more information, please see <see cref="DEVMODE.dmPrintQuality"/> field.
            /// </summary>
            PrintQuality = 0x400,

            /// <summary>
            /// For more information, please see <see cref="DEVMODE.dmColor"/> field.
            /// </summary>
            Color = 0x800,

            /// <summary>
            /// Para más información ver <see cref="DEVMODE.dmDuplex"/> field.
            /// </summary>
            Duplex = 0x1000,

            /// <summary>
            /// For more information, please see <see cref="DEVMODE.dmYResolution"/> field.
            /// </summary>
            YResolution = 0x2000,

            /// <summary>
            /// For more information, please see <see cref="DEVMODE.dmTTOption"/> field.
            /// </summary>
            TTOption = 0x4000,

            /// <summary>
            /// For more information, please see <see cref="DEVMODE.dmCollate"/> field.
            /// </summary>
            Collate = 0x8000,

            /// <summary>
            /// For more information, please see <see cref="DEVMODE.dmFormName"/> field.
            /// </summary>
            FormName = 0x10000,

            /// <summary>
            /// For more information, please seer <see cref="DEVMODE.dmLogPixels"/> field.
            /// </summary>
            LogPixels = 0x20000,

            /// <summary>
            /// For more information, please see <see cref="DEVMODE.dmBitsPerPel"/> field.
            /// </summary>
            BitsPerPixel = 0x40000,

            /// <summary>
            /// For more information, please see <see cref="DEVMODE.dmPelsWidth"/> field.
            /// </summary>
            PelsWidth = 0x80000,

            /// <summary>
            /// For more information, please see <see cref="DEVMODE.dmPelsHeight"/> field.
            /// </summary>
            PelsHeight = 0x100000,

            /// <summary>
            /// For more information, please see <see cref="DEVMODE.dmDisplayFlags"/> field.
            /// </summary>
            [SuppressMessage("Microsoft.Naming", "CA1726:UsePreferredTerms", MessageId = "Flags")]
            DisplayFlags = 0x200000,

            /// <summary>
            /// For more information, please see <see cref="DEVMODE.dmDisplayFrequency"/> field.
            /// </summary>
            DisplayFrequency = 0x400000,

            /// <summary>
            /// For more information, please see  field.
            /// </summary>
            ///// Para más información ver 
            IcmMethod = 0x800000,

            /// <summary>
            /// For more information, please see  field.
            /// </summary>
            ///// For more information, please see <see cref="DEVMODE.dmIcmIntent"/> field.
            IcmIntent = 0x1000000,

            /// <summary>
            /// 
            /// </summary>
            ///// For more information, please see <see cref="DEVMODE.dmMediaType"/> field.
            MediaType = 0x2000000,

            /// <summary>
            /// 
            /// </summary>
            ///// For more information, please see <see cref="DEVMODE.dmDitherType"/> field.
            DitherType = 0x4000000,

            /// <summary>
            /// 
            /// </summary>
            ///// For more information, please see <see cref="DEVMODE.dmPanningWidth"/> field.
            PanningWidth = 0x8000000,

            /// <summary>
            /// 
            /// </summary>
            ///// For more information, please see <see cref="DEVMODE.dmPanningHeight"/> field.
            PanningHeight = 0x10000000,

            /// <summary>
            /// 
            /// </summary>
            ///// For more information, please see <see cref="DEVMODE.dmDisplayFixedOutput"/> field.
            DisplayFixedOutput = 0x20000000
        }
        #endregion

        #region [public] (enum) DisplayFlags: Enumeración de miembros de una estructura de tipo DEVMODE.
        /// <summary>
        /// Enumeration of state attributes of a structure <see cref="DEVMODE" />.
        /// </summary>
        /// <remarks>
        /// For more information, please see the <strong>StateFlags</strong> section of http://msdn.microsoft.com/en-us/library/dd183569.aspx.
        /// </remarks>
        [Flags]
        [SuppressMessage("Microsoft.Naming", "CA1726:UsePreferredTerms", MessageId = "Flags")]
        public enum DisplayFlags
        {
            /// <summary>
            /// Grayscale.
            /// </summary>
            GrayScale = 0x01,

            /// <summary>
            /// Interlaced.
            /// </summary>
            Interlaced = 0x02
        }
        #endregion

        #endregion

        #region public members
        /// <summary>
        /// A string that specifies the "descriptive" name of the printer or display device; for example, "pcl/HP LaserJet" in the case of PCL/HP LaserJet. This string is unique among device drivers.
        /// </summary>
        [FieldOffset(0)]
        [SuppressMessage("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        [SuppressMessage("Microsoft.Design", "CA1051:DoNotDeclareVisibleInstanceFields")] 
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = CCHDEVICENAME)] 
        public string dmDeviceName;

        /// <summary>
        /// Version number of the initialization data specification on which the structure is based. To ensure that you use the correct version for any operating system, use <c>DM_SPECVERSION</c>.
        /// </summary>
        [FieldOffset(32)]
        [SuppressMessage("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        [SuppressMessage("Microsoft.Design", "CA1051:DoNotDeclareVisibleInstanceFields")] 
        public Int16 dmSpecVersion;

        /// <summary>
        /// Version number of the controller established by the manufacturer of the same.
        /// </summary>
        [FieldOffset(34)]
        [SuppressMessage("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        [SuppressMessage("Microsoft.Design", "CA1051:DoNotDeclareVisibleInstanceFields")]
        public Int16 dmDriverVersion;

        /// <summary>
        /// Specifies the size, in bytes, of the <strong>DEVMODE</strong> structure, excluding the specific data of the private controller that could follow the public members of the structure.
        /// </summary>
        [FieldOffset(36)]
        [SuppressMessage("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        [SuppressMessage("Microsoft.Design", "CA1051:DoNotDeclareVisibleInstanceFields")] 
        public Int16 dmSize;

        /// <summary>
        /// Contains the number of bytes of private controller data that follow this structure. If a device driver does not use device-specific information, this field must be 0.
        /// </summary>
        [FieldOffset(38)]
        [SuppressMessage("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        [SuppressMessage("Microsoft.Design", "CA1051:DoNotDeclareVisibleInstanceFields")]
        public Int16 dmDriverExtra;

        /// <summary>
        /// Specifies whether some members of the <strong>DEVMODE</strong> structure have been initialized.
        /// If a member has been initialized, its corresponding bit is set to '1', otherwise the bit is '0'.
        /// A driver supports only <strong>DEVMODE</strong> members that are suitable for the printer or display device.
        /// For more information, please see <see cref = "DM" />.
        /// </summary>
        [FieldOffset(40)]
        [SuppressMessage("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        [SuppressMessage("Microsoft.Design", "CA1051:DoNotDeclareVisibleInstanceFields")] 
        public DM dmFields;

        /// <summary>
        /// For printing devices, select the orientation of the paper.
        /// This member can be <strong>DMORIENT_PORTRAIT</strong> (1) or <strong>DMORIENT_LANDSCAPE</strong> (2).
        /// </summary>
        [FieldOffset(44)] 
        [SuppressMessage("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")] 
        private Int16 dmOrientation;

        /// <summary>
        /// Only for printing devices.
        /// Select the size of the paper to be printed. This member can be set to 0 if the length and width of the paper are established by members of <strong>dmPaperLength</strong> strong> and <strong>dmPaperWidth</strong>.
        /// Otherwise, the <strong>dmPaperSize</strong> member can be set to a specific value greater than or equal to <strong>DMPAPER_USER</strong> or one of the following predefined values.
        /// </summary>
        [FieldOffset(46)] 
        [SuppressMessage("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")] 
        private Int16 dmPaperSize;

        /// <summary>
        /// For printing devices, replace the length of the document specified by the <strong>dmPaperSize</strong> field, for custom paper sizes or for devices such as dot matrix printers that can print on a page of arbitrary length.
        /// These values, together with the other values of this structure that specify a physical length, are in tenths of a millimeter.
        /// </summary>
        [FieldOffset(48)] 
        [SuppressMessage("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")] 
        private Int16 dmPaperLength;

        /// <summary>
        /// For printing devices only, replace the paper width specified by the <strong>dmPaperSize</strong> field.
        /// </summary>
        [FieldOffset(50)]
        [SuppressMessage("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")] 
        private Int16 dmPaperWidth;

        /// <summary>
        /// Specify the scale factor. The apparent size of the page adjusts the physical page size by a factor of <strong>dmScale</strong> / 100.
        /// For example, a letter-size page with a value of <strong>dmScale</strong> of 50 would contain as much data as a page of 17-22 inches because the text and graphics would be half its height and width.
        /// </summary>
        [FieldOffset(52)]
        [SuppressMessage("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")] 
        private Int16 dmScale;

        /// <summary>
        /// Number of copies, if the device accepts multicopies.
        /// </summary>
        [FieldOffset(54)] 
        [SuppressMessage("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")] 
        private Int16 dmCopies;

        /// <summary>
        /// Specifies the paper source.
        /// To retrieve a list of available paper sources for a printer, use the DeviceCapabilities function with the <strong>DC_BINS</strong> flag.
        /// This member can be one of the following values, or it can be a device-specific value greater than or equal to <strong>DMBIN_USER</strong>.
        /// </summary>
        [FieldOffset(56)] 
        [SuppressMessage("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")] 
        private Int16 dmDefaultSource;

        /// <summary>
        /// Specify the resolution of the printer.
        /// </summary>
        [FieldOffset(58)]
        [SuppressMessage("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        private Int16 dmPrintQuality;

        /// <summary>
        /// For screen devices only, a structure <see cref="POINTL" /> that indicates the positional coordinates of the screen in reference to the desktop area.
        /// The main screen device is always located at the coordinates (0,0).
        /// </summary>
        [FieldOffset(44)] 
        [SuppressMessage("Microsoft.Design", "CA1051:DoNotDeclareVisibleInstanceFields")] 
        public POINTL dmPosition;

        /// <summary>
        /// For screen devices, the orientation to which images are presented.
        /// If DM_DISPLAYORIENTATION is not configured, this member must be zero.
        /// If DM_DISPLAYORIENTATION is configured, this member must be one of the following values:
        /// <strong>DMDO_DEFAULT</strong>, the orientation of the screen is the normal orientation of the device (default option).
        /// <strong>DMDO_90</strong>, the orientation of the screen is rotated 90 degrees. (clockwise) from its natural position.
        /// <strong>DMDO_180</strong>, the orientation of the screen is rotated 180 degrees. (clockwise) from its natural position.
        /// <strong>DMDO_270</strong>, the orientation of the screen is rotated 270 degrees. (clockwise) from its natural position.
        /// </summary>
        [FieldOffset(52)] 
        [SuppressMessage("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        [SuppressMessage("Microsoft.Design", "CA1051:DoNotDeclareVisibleInstanceFields")]
        public Int32 dmDisplayOrientation;

        /// <summary>
        /// For fixed resolution screen devices, how the screen presents a low resolution mode on a high resolution screen.
        /// For example, if the resolution of a display device is set to 1024 x 768 pixels, but its mode is set to 640 x 480 pixels, the device can display a 640 x 480 image somewhere inside the 1024 x 768 screen space or expand the image
        /// of 640 x 480 to fill the largest screen space.
        /// If <strong>DM_DISPLAYFIXEDOUTPUT</strong> is not configured, this member must be zero.
        /// If <strong>DM_DISPLAYFIXEDOUTPUT</strong> is configured, this member must be one of the following values:
        /// <strong>DMDFO_DEFAULT</strong>, default screen settings.
        /// <strong>DMDFO_CENTER</strong>, the low resolution image focuses on the largest screen space.
        /// <strong>DMDFO_STRETCH</strong>, the low resolution image stretches to fill the larger screen space
        /// </summary>
        [FieldOffset(56)] 
        [SuppressMessage("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")] 
        [SuppressMessage("Microsoft.Design", "CA1051:DoNotDeclareVisibleInstanceFields")] 
        public Int32 dmDisplayFixedOutput;

        /// <summary>
        /// Switch between color and monochrome in color printers. The possible values are the following:
        /// <strong>DMCOLOR_COLOR</strong>.
        /// <strong>DMCOLOR_MONOCHROME</strong>.
        /// </summary>
        [FieldOffset(60)] 
        [SuppressMessage("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")] 
        [SuppressMessage("Microsoft.Design", "CA1051:DoNotDeclareVisibleInstanceFields")] 
        public short dmColor;

        /// <summary>
        /// Select duplex or face printing for printers capable of double-sided printing. The following are the possible values.
        /// <strong>DMDUP_SIMPLEX</strong>, Normal printing (noduplex).
        /// <strong>DMDUP_HORIZONTAL</strong>, the long side of the page is horizontal.
        /// <strong>DMDUP_VERTICAL</strong>, the long side of the page is vertical.
        /// </summary>
        [FieldOffset(62)] 
        [SuppressMessage("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")] 
        [SuppressMessage("Microsoft.Design", "CA1051:DoNotDeclareVisibleInstanceFields")] 
        public short dmDuplex;

        /// <summary>
        /// Specifies the resolution, in dots per inch, of the printer.
        /// If the printer initializes this member, the <strong>dmPrintQuality</strong> field specifies the resolution x, in dots per inch, of the printer.
        /// </summary>
        [FieldOffset(64)] 
        [SuppressMessage("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")] 
        [SuppressMessage("Microsoft.Design", "CA1051:DoNotDeclareVisibleInstanceFields")] 
        public short dmYResolution;

        /// <summary>
        /// Specifies how TrueType fonts should be printed. This member can be one of the following values.
        /// <strong>DMTT_BITMAP</strong>, prints the TrueType fonts as graphics. This is the default action for dot matrix printers.
        /// <strong>DMTT_DOWNLOAD</strong>, TrueType fonts as transferable. This is the default action for Hewlett-Packard printers that use the Printer Control (PCL) language.
        /// <strong>DMTT_DOWNLOAD_OUTLINE</strong>, as a transferable scheme.
        /// <strong>DMTT_SUBDEV</strong>, substitute for TrueType fonts. This is the default action for PostScript printers.
        /// </summary>
        [FieldOffset(66)] 
        [SuppressMessage("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")] 
        [SuppressMessage("Microsoft.Design", "CA1051:DoNotDeclareVisibleInstanceFields")] 
        public short dmTTOption;

        /// <summary>
        /// Specifies whether collation should be used when printing multiple copies. (This field is omitted unless the printer driver sets the field <strong>DM_COLLATE</strong>).
        /// This member can be one of the following values.
        /// <strong>DMCOLLATE_TRUE</strong>, collate when printing multiple copies.
        /// <strong>DMCOLLATE_FALSE</strong>. Do not interleave when printing multiple copies.
        /// </summary>
        [FieldOffset(68)] 
        [SuppressMessage("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")] 
        [SuppressMessage("Microsoft.Design", "CA1051:DoNotDeclareVisibleInstanceFields")] 
        public short dmCollate;

        /// <summary>
        /// A string that specifies the name of the form to use; for example, "Letter" or "Legal".
        /// A complete set of names can be obtained through the <strong>EnumForms</strong> function.
        /// </summary>
        [FieldOffset(72)] 
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = CCHFORMNAME)] 
        [SuppressMessage("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        [SuppressMessage("Microsoft.Design", "CA1051:DoNotDeclareVisibleInstanceFields")] 
        public string dmFormName;

        /// <summary>
        /// Number of pixels per inch. Printer drivers should not use this field.
        /// </summary>
        [FieldOffset(102)] 
        [SuppressMessage("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        [SuppressMessage("Microsoft.Design", "CA1051:DoNotDeclareVisibleInstanceFields")] 
        public Int16 dmLogPixels;

        /// <summary>
        /// Specifies the color resolution, in bits per pixel, of the screen (for example: 4 bits of 16 colors, 8 bits of 256 colors or 16 bits for 65,536 colors).
        /// Screen controllers use this field, for example, in the <strong>ChangeDisplaySettings</strong> function.
        /// Printer drivers should not use this field.
        /// </summary>
        [FieldOffset(104)] 
        [SuppressMessage("Microsoft.Design", "CA1051:DoNotDeclareVisibleInstanceFields")]
        public Int32 dmBitsPerPel;

        /// <summary>
        /// Specifies the width, in pixels, of the visible surface of the device.
        /// Screen controllers use this field, for example, in the <strong>ChangeDisplaySettings</strong> function.
        /// Printer drivers should not use this field.
        /// </summary>
        [FieldOffset(108)] 
        [SuppressMessage("Microsoft.Design", "CA1051:DoNotDeclareVisibleInstanceFields")] 
        public Int32 dmPelsWidth;

        /// <summary>
        /// Specifies the height, in pixels, of the visible surface of the device.
        /// Screen controllers use this field, for example, in the <strong>ChangeDisplaySettings</strong> function.
        /// Printer drivers should not use this field.
        /// </summary>
        [FieldOffset(112)]
        [SuppressMessage("Microsoft.Design", "CA1051:DoNotDeclareVisibleInstanceFields")]
        public Int32 dmPelsHeight;

        /// <summary>
        /// Specifies the display mode of the device. This member can be a combination of the following values.
        /// <strong>DM_GRAYSCALE</strong>, specifies that the screen is a monochrome device. If this indicator is not set, it is assumed to be colored.
        /// <strong>DM_INTERLACED</strong>, specifies that the display mode is interlaced. If this indicator is not set, it is assumed that it is not interlaced.
        /// </summary>
        [FieldOffset(116)]
        [SuppressMessage("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")] 
        [SuppressMessage("Microsoft.Design", "CA1051:DoNotDeclareVisibleInstanceFields")] 
        [SuppressMessage("Microsoft.Naming", "CA1726:UsePreferredTerms", MessageId = "Flags")]
        public DisplayFlags dmDisplayFlags;

        /// <summary>
        /// Specifies where the NUP is made. It can be one of the following.
        /// <strong>DMNUP_SYSTEM</strong>, the print queue does NUP.
        /// <strong>DMNUP_ONEUP</strong>, the application does NUP.
        /// </summary>
        [FieldOffset(116)]
        [SuppressMessage("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        [SuppressMessage("Microsoft.Design", "CA1051:DoNotDeclareVisibleInstanceFields")]
        public Int32 dmNup;

        /// <summary>
        /// Specifies the frequency, in hertz (cycles per second), of the screen in a special mode.
        /// This value is known as the vertical refresh rate of the display device.
        /// The screen drivers use this member. For example, it is used in the <strong>ChangeDisplaySettings</strong> function.
        /// Printer drivers should not use this field.
        /// When you call the <strong>EnumDisplaySettings</strong> function, you can return the <strong>dmDisplayFrequency</strong> field with the value 0 or 1, these values represent the frequency of display hardware update by default.
        /// This default rate is set by switches on a computer motherboard or business card, or by a configuration program that does not use display functions such as <strong>ChangeDisplaySettings</strong>.
        /// </summary>
        [FieldOffset(120)] 
        [SuppressMessage("Microsoft.Design", "CA1051:DoNotDeclareVisibleInstanceFields")]
        public Int32 dmDisplayFrequency;
        #endregion

        #region interfaces

        #region [public] (bool) Equals(DEVMODE): Indica si la estructura actual es igual a otra estructura del mismo tipo.
        /// <inheritdoc />
        /// <summary>
        /// Indicates whether the current structure is equal to another structure of the same type.
        /// </summary>
        /// <param name="other">Structure that is going to be compared with this structure.</param>
        /// <returns>
        /// Returns <strong>true</strong> if the current structure is equal to the <c>other</c> parameter; otherwise, <strong>false</strong>.
        /// </returns>
        public bool Equals(DEVMODE other) => other.Equals((object) this);
        #endregion

        #endregion

        #region public static operators

        #region [public] {static} (bool) operator ==(DEVMODE, DEVMODE): Implements the equality operator (==)
        /// <summary>
        /// Implements the equality operator (==).
        /// </summary>
        /// <param name="left">Operand 1.</param>
        /// <param name="right">Operand 2.</param>
        /// <returns>
        /// Returns <b>true</b> if <c>left</c> is equal to <c>right</c>; <b>false</b> otherwise.
        /// </returns>
        public static bool operator ==(DEVMODE left, DEVMODE right) => left.Equals(right);
        #endregion

        #region [public] {static} (bool) operator !=(DEVMODE, DEVMODE): Implement the inequality operator (!=)
        /// <summary>
        /// Implement the inequality operator (!=)
        /// </summary>
        /// <param name="left">Operand 1.</param>
        /// <param name="right">Operand 2.</param>
        /// <returns>
        /// Returns <strong>true</strong> if <c>left</c> is not equal to <c>right</c>; <strong>false</strong> otherwise.
        /// </returns>
        public static bool operator !=(DEVMODE left, DEVMODE right) => !left.Equals(right);
        #endregion

        #endregion

        #region public static members
        public static DEVMODE Empty = new DEVMODE { dmSize = (short)Marshal.SizeOf(typeof(DEVMODE)) };
        #endregion

        #region public override methods

        #region [public] {override} (int) GetHashCode(): Returns a value that represents the hash code of this structure
        /// <summary>
        /// Returns a value that represents the hash code of this structure.
        /// </summary>
        /// <returns>
        /// Hash code of this structure
        /// </returns>
        public override int GetHashCode() => dmPelsWidth ^ dmPelsHeight ^ dmBitsPerPel ^ dmDisplayFrequency;
        #endregion

        #region [public] {override} (bool) Equals(object): Returns a value that indicates if this structure is equal to another
        /// <summary>
        /// Returns a value that indicates if this structure is equal to another.
        /// </summary>
        /// <param name="obj">Structure with which to compare.</param>
        /// <returns>
        /// Result of the comparison of equality.
        /// </returns>
        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }

            if (!(obj is DEVMODE))
            {
                return false;
            }

            DEVMODE other = (DEVMODE) obj;

            return
                other.dmPelsWidth == dmPelsWidth &&
                other.dmPelsHeight == dmPelsHeight &&
                other.dmBitsPerPel == dmBitsPerPel &&
                other.dmDisplayFrequency == dmDisplayFrequency;
        }
        #endregion

        #region [public] {override} (string) ToString(): Returns a string representing the current structure
        /// <summary>
        /// Returns a string representing the current structure <see cref="DEVMODE" />.
        /// </summary>
        /// <returns>
        /// String representing the structure <see cref="DEVMODE" /> current. 
        /// </returns>
        /// <remarks>
        /// The method <see cref="DEVMODE.ToString()" /> returns a string that includes the current resolution, color depth, and refresh rate.
        /// </remarks>
        public override string ToString() => $"{dmPelsWidth} x {dmPelsHeight}, {dmBitsPerPel} bits, {dmDisplayFrequency}hz";
        #endregion

        #endregion
    }
}
