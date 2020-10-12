
namespace iTin.Core.Hardware.Common
{
    using System.Diagnostics.CodeAnalysis;

    /// <summary>
    /// Define the unit of measure of a property.
    /// </summary>
    public enum PropertyUnit
    {
        /// <summary>
        /// Adimensional
        /// </summary>
        None,

        /// <summary>
        /// Adimensional
        /// </summary>
        xcent,

        /// <summary>
        /// Auto
        /// </summary>
        Auto,

        /// <summary>
        /// Bits.
        /// </summary>
        Bits,

        /// <summary>
        /// Bytes.
        /// </summary>
        Bytes,

        /// <summary>
        /// Centimeters.
        /// </summary>
        cm,

        /// <summary>
        /// Degrees Celsius
        /// </summary>
        DegreeCentigrade,

        /// <summary>
        ///  Dots per inch
        /// </summary>
        dpi,

        /// <summary>
        /// Hertzs
        /// </summary>
        [SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", MessageId = "Hz")]
        Hz,

        /// <summary>
        /// Kilobyte
        /// </summary>
        KB,

        /// <summary>
        /// Kilohertz
        /// </summary>
        [SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", MessageId = "Hz")]
        KHz,

        /// <summary>
        /// Líneas
        /// </summary>
        Lines,

        /// <summary>
        /// Milliamps
        /// </summary>
        [SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", MessageId = "m")]
        mA,

        /// <summary>
        /// Millimiters.
        /// </summary>
        [SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", MessageId = "mm")]
        mm,

        /// <summary>
        /// 1/100 millimiters.
        /// </summary>
        [SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", MessageId = "d_mm")]
        d_mm,

        /// <summary>
        /// millivolts
        /// </summary>
        [SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", MessageId = "m")]
        mV,

        /// <summary>
        /// Tenths of millivolts
        /// </summary>
        [SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", MessageId = "m")]
        d_mV,

        /// <summary>
        /// 1/100th of a percent
        /// </summary>
        Percent_1_100th,

        /// <summary>
        /// Miliwatts/hour
        /// </summary>
        [SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", MessageId = "m")]
        [SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", MessageId = "Wh")]
        mWh,

        /// <summary>
        /// Megabytes
        /// </summary>
        MB,

        /// <summary>
        /// Megahertz
        /// </summary>
        [SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", MessageId = "Hz")]
        MHz,

        /// <summary>
        /// Megatransfers per second
        /// </summary>
        [SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", MessageId = "Hz")]
        MTs,

        /// <summary>
        /// Nanoseconds
        /// </summary>
        [SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", MessageId = "ns")]
        ns,

        /// <summary>
        /// Pixel
        /// </summary>
        Pixel,

        /// <summary>
        /// Pixels
        /// </summary>
        Pixels,

        /// <summary>
        /// minute
        /// </summary>
        [SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", MessageId = "RPM")]
        RPM,

        /// <summary>
        /// Standard unit of measure for rack-type or rack-mountable components, equals 1.75 inches or 4.445 cm
        /// </summary>
        [SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "U")]
        U,

        /// <summary>
        /// Volts
        /// </summary>
        [SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "V")]
        V,

        /// <summary>
        /// Watts.
        /// </summary>
        [SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "W")]
        W,

        /// <summary>
        /// Variable unit, will depend on the version of the implemented structure, please see the documentation of the property to know the correct unit.
        /// </summary>
        Variable
    }
}
