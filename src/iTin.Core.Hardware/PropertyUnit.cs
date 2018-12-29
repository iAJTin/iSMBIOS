
namespace iTin.Core.Hardware
{
    using System.Diagnostics.CodeAnalysis;

    /// <summary>
    /// Especifica la unidad de medida de una propiedad.
    /// </summary>
    public enum PropertyUnit
    {
        /// <summary>
        /// Adimensional.
        /// </summary>
        None,
        /// <summary>
        /// Automático.
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
        /// Centimétros.
        /// </summary>
        cm,
        /// <summary>
        /// Grados Centigrados.
        /// </summary>
        DegreeCentigrade,
        /// <summary>
        /// Puntos por pulgada.
        /// </summary>
        dpi,
        /// <summary>
        /// Hercios.
        /// </summary>
        [SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", MessageId = "Hz")]
        Hz,
        /// <summary>
        /// Kilobyte
        /// </summary>
        KB,
        /// <summary>
        /// Kilohercios
        /// </summary>
        [SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", MessageId = "Hz")]
        KHz,
        /// <summary>
        /// Líneas
        /// </summary>
        Lines,
        /// <summary>
        /// Miliamperios.
        /// </summary>
        [SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", MessageId = "m")]
        mA,
        /// <summary>
        /// Milimetros.
        /// </summary>
        [SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", MessageId = "mm")]
        mm,
        /// <summary>
        /// Milivoltios.
        /// </summary>
        [SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", MessageId = "m")]
        mV,
        /// <summary>
        /// Miliwatios/hora
        /// </summary>
        [SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", MessageId = "m")]
        [SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", MessageId = "Wh")]
        mWh,
        /// <summary>
        /// Megabytes
        /// </summary>
        MB,
        /// <summary>
        /// Megahercios
        /// </summary>
        [SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", MessageId = "Hz")]
        MHz,
        /// <summary>
        /// Nanosegundos.
        /// </summary>
        [SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", MessageId = "ns")]
        ns,
        /// <summary>
        /// Pixel.
        /// </summary>
        Pixel,
        /// <summary>
        /// Pixels.
        /// </summary>
        Pixels,
        /// <summary>
        /// Revoluciones por minuto.
        /// </summary>
        [SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", MessageId = "RPM")]
        RPM,
        /// <summary>
        /// Unidad de medida standard para componentes de tipo rack o rack-mountable, 
        /// es igual a 1.75 pulgadas o 4.445 cm
        /// </summary>
        [SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "U")]
        U,
        /// <summary>
        /// Voltios
        /// </summary>
        [SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "V")]
        V,
        /// <summary>
        /// Vatios.
        /// </summary>
        [SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "W")]
        W, 
    }
}