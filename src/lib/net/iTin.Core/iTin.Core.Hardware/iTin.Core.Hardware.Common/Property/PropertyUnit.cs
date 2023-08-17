
namespace iTin.Core.Hardware.Common;

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
    Hz,

    /// <summary>
    /// Kilobyte
    /// </summary>
    KB,

    /// <summary>
    /// Kilohertz
    /// </summary>
    KHz,

    /// <summary>
    /// Líneas
    /// </summary>
    Lines,

    /// <summary>
    /// Milliamps
    /// </summary>
    mA,

    /// <summary>
    /// Millimiters.
    /// </summary>
    mm,

    /// <summary>
    /// 1/100 millimiters.
    /// </summary>
    d_mm,

    /// <summary>
    /// millivolts
    /// </summary>
    mV,

    /// <summary>
    /// Tenths of millivolts
    /// </summary>
    d_mV,

    /// <summary>
    /// 1/100th of a percent
    /// </summary>
    Percent_1_100th,

    /// <summary>
    /// Miliwatts/hour
    /// </summary>
    mWh,

    /// <summary>
    /// Megabytes
    /// </summary>
    MB,

    /// <summary>
    /// Megahertz
    /// </summary>
    MHz,

    /// <summary>
    /// Megatransfers per second
    /// </summary>
    MTs,

    /// <summary>
    /// Nanoseconds
    /// </summary>
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
    RPM,

    /// <summary>
    /// Standard unit of measure for rack-type or rack-mountable components, equals 1.75 inches or 4.445 cm
    /// </summary>
    U,

    /// <summary>
    /// Volts
    /// </summary>
    V,

    /// <summary>
    /// Watts.
    /// </summary>
    W,

    /// <summary>
    /// Variable unit, will depend on the version of the implemented structure, please see the documentation of the property to know the correct unit.
    /// </summary>
    Variable
}
