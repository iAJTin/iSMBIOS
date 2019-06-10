using System;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Runtime.InteropServices;

using iTin.Core.Interop.Windows.Development.Graphics.Legacy.Gdi.Metafiles;

namespace iTin.Core.Interop.Windows.Development.DocumentAndPrinting.Printing.GdiPrint
{
    /// <summary>
    /// La estructura de datos <strong>DEVMODE</strong> contiene información para la inicialización de una impresora o un dispositivo de visualización.
    /// </summary>
    /// <remarks>
    /// Para más información, ver http://msdn.microsoft.com/es-es/library/dd183565.aspx.
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
    [SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", MessageId = "DEVMODE")]
    struct DEVMODE : IEquatable<DEVMODE>
    {
        #region Constantes
        /// <summary>
        /// Indica que se va a recuperar la configuración actual para el dispositivo de pantalla.
        /// </summary>
        [SuppressMessage("Microsoft.Naming", "CA1707:IdentifiersShouldNotContainUnderscores")]
        [SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", MessageId = "ENUM")] 
        [SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", MessageId = "CURRENT")]
        [SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", MessageId = "SETTINGS")]
        public const int ENUM_CURRENT_SETTINGS = -1;

        /// <summary>
        /// Indica que se va a recuperar la configuración del dispositivo de visualización que está almacenada en el registro.
        /// </summary>
        [SuppressMessage("Microsoft.Naming", "CA1707:IdentifiersShouldNotContainUnderscores")]
        [SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", MessageId = "ENUM")]
        [SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", MessageId = "REGISTRY")]
        [SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", MessageId = "SETTINGS")]
        public const int ENUM_REGISTRY_SETTINGS = -2;
        #endregion

        #region Enumeraciones

            #region [public] (enum) DM: Enumeración de miembros de una estructura de tipo DEVMODE.
            /// <summary>
            /// Enumeración de miembros de una estructura de tipo <see cref="DEVMODE"/>.
            /// </summary>
            /// <remarks>
            /// Para más información, ver sección <strong>dmFields</strong> de http://msdn.microsoft.com/es-es/library/dd183565.aspx.
            /// </remarks>
            [Flags]
            public enum DM
            {
                /// <summary>
                /// Para más información ver <see cref="DEVMODE.dmOrientation"/>.
                /// </summary>
                Orientation = 0x1,

                /// <summary>
                /// Para más información ver <see cref="DEVMODE.dmPaperSize"/>.
                /// </summary>
                PaperSize = 0x2,

                /// <summary>
                /// Para más información ver <see cref="DEVMODE.dmPaperLength"/>.
                /// </summary>
                PaperLength = 0x4,

                /// <summary>
                /// Para más información ver <see cref="DEVMODE.dmPaperWidth"/>.
                /// </summary>
                PaperWidth = 0x8,

                /// <summary>
                /// Para más información ver <see cref="DEVMODE.dmScale"/>.
                /// </summary>
                Scale = 0x10,

                /// <summary>
                /// Para más información ver <see cref="DEVMODE.dmPosition"/>.
                /// </summary>
                Position = 0x20,

                /// <summary>
                /// Para más información ver <see cref="DEVMODE.dmNup"/>.
                /// </summary>
                Nup = 0x40,

                /// <summary>
                /// Para más información ver <see cref="DEVMODE.dmDisplayOrientation"/>.
                /// </summary>
                DisplayOrientation = 0x80,

                /// <summary>
                /// Para más información ver <see cref="DEVMODE.dmCopies"/>.
                /// </summary>
                Copies = 0x100,

                /// <summary>
                /// Para más información ver <see cref="DEVMODE.dmDefaultSource"/>.
                /// </summary>
                DefaultSource = 0x200,

                /// <summary>
                /// Para más información ver <see cref="DEVMODE.dmPrintQuality"/>.
                /// </summary>
                PrintQuality = 0x400,

                /// <summary>
                /// Para más información ver <see cref="DEVMODE.dmColor"/>.
                /// </summary>
                Color = 0x800,

                /// <summary>
                /// Para más información ver <see cref="DEVMODE.dmDuplex"/>.
                /// </summary>
                Duplex = 0x1000,

                /// <summary>
                /// Para más información ver <see cref="DEVMODE.dmYResolution"/>.
                /// </summary>
                YResolution = 0x2000,

                /// <summary>
                /// Para más información ver <see cref="DEVMODE.dmTTOption"/>.
                /// </summary>
                TTOption = 0x4000,

                /// <summary>
                /// Para más información ver <see cref="DEVMODE.dmCollate"/>.
                /// </summary>
                Collate = 0x8000,

                /// <summary>
                /// Para más información ver <see cref="DEVMODE.dmFormName"/>.
                /// </summary>
                FormName = 0x10000,

                /// <summary>
                /// Para más información ver <see cref="DEVMODE.dmLogPixels"/>.
                /// </summary>
                LogPixels = 0x20000,

                /// <summary>
                /// Para más información ver <see cref="DEVMODE.dmBitsPerPel"/>.
                /// </summary>
                BitsPerPixel = 0x40000,

                /// <summary>
                /// Para más información ver <see cref="DEVMODE.dmPelsWidth"/>.
                /// </summary>
                PelsWidth = 0x80000,

                /// <summary>
                /// Para más información ver <see cref="DEVMODE.dmPelsHeight"/>.
                /// </summary>
                PelsHeight = 0x100000,

                /// <summary>
                /// Para más información ver <see cref="DEVMODE.dmDisplayFlags"/>.
                /// </summary>
                [SuppressMessage("Microsoft.Naming", "CA1726:UsePreferredTerms", MessageId = "Flags")] DisplayFlags =
                    0x200000,

                /// <summary>
                /// Para más información ver <see cref="DEVMODE.dmDisplayFrequency"/>.
                /// </summary>
                DisplayFrequency = 0x400000,

                /// <summary>
                /// 
                /// </summary>
                ///// Para más información ver <see cref="DEVMODE.dmIcmMethod"/>.
                IcmMethod = 0x800000,

                /// <summary>
                /// 
                /// </summary>
                ///// Para más información ver <see cref="DEVMODE.dmIcmIntent"/>.
                IcmIntent = 0x1000000,

                /// <summary>
                /// 
                /// </summary>
                ///// Para más información ver <see cref="DEVMODE.dmMediaType"/>.
                MediaType = 0x2000000,

                /// <summary>
                /// 
                /// </summary>
                ///// Para más información ver <see cref="DEVMODE.dmDitherType"/>.
                DitherType = 0x4000000,

                /// <summary>
                /// 
                /// </summary>
                ///// Para más información ver <see cref="DEVMODE.dmPanningWidth"/>.
                PanningWidth = 0x8000000,

                /// <summary>
                /// 
                /// </summary>
                ///// Para más información ver <see cref="DEVMODE.dmPanningHeight"/>.
                PanningHeight = 0x10000000,

                /// <summary>
                /// 
                /// </summary>
                ///// Para más información ver <see cref="DEVMODE.dmDisplayFixedOutput"/>.
                DisplayFixedOutput = 0x20000000
            }
            #endregion

            #region [public] (enum) DisplayFlags: Enumeración de miembros de una estructura de tipo DEVMODE.
            /// <summary>
            /// Enumeración de atributos de estado de una estructura <see cref="DEVMODE"/>.
            /// </summary>
            /// <remarks>
            /// Para más información, ver sección <strong>StateFlags</strong> de http://msdn.microsoft.com/es-es/library/dd183569.aspx.
            /// </remarks>
            [Flags]
            [SuppressMessage("Microsoft.Naming", "CA1726:UsePreferredTerms", MessageId = "Flags")]
            public enum DisplayFlags
            {
                /// <summary>
                /// Escala de grises.
                /// </summary>
                GrayScale = 0x01,

                /// <summary>
                /// Entrelazado.
                /// </summary>
                Interlaced = 0x02
            }
            #endregion

        #endregion

        #region Atributos
        /// <summary>
        /// Una cadena que especifica el nombre "descriptivo" de la impresora o dispositivo de visualización;
        /// por ejemplo, "pcl/HP LaserJet" en el caso de PCL/HP LaserJet. Esta cadena es única entre los controladores de dispositivos.
        /// </summary>
        [FieldOffset(0)]
        [SuppressMessage("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        [SuppressMessage("Microsoft.Design", "CA1051:DoNotDeclareVisibleInstanceFields")] 
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = CCHDEVICENAME)] 
        public string dmDeviceName;

        /// <summary>
        /// Número de versión de la especificación de datos de inicialización en que se basa la estructura.
        /// Para asegurarse de que utiliza la versión correcta para cualquier sistema operativo, utilice DM_SPECVERSION.
        /// </summary>
        [FieldOffset(32)]
        [SuppressMessage("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        [SuppressMessage("Microsoft.Design", "CA1051:DoNotDeclareVisibleInstanceFields")] 
        public Int16 dmSpecVersion;

        /// <summary>
        /// Número de versión del controlador establecido por el fabricante del mismo.
        /// </summary>
        [FieldOffset(34)]
        [SuppressMessage("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        [SuppressMessage("Microsoft.Design", "CA1051:DoNotDeclareVisibleInstanceFields")]
        public Int16 dmDriverVersion;

        /// <summary>
        /// Especifica el tamaño, en bytes, de la estructura <strong>DEVMODE</strong>, sin incluir los datos específicos 
        /// del controlador privados que podrían seguir a los miembros públicos de la estructura. 
        /// </summary>
        [FieldOffset(36)]
        [SuppressMessage("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        [SuppressMessage("Microsoft.Design", "CA1051:DoNotDeclareVisibleInstanceFields")] 
        public Int16 dmSize;

        /// <summary>
        /// Contiene el número de bytes de datos de controlador privados que siguen esta estructura.
        /// Si un controlador de dispositivo no utiliza información específica del dispositivo, este campo ha de ser 0.
        /// </summary>
        [FieldOffset(38)]
        [SuppressMessage("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        [SuppressMessage("Microsoft.Design", "CA1051:DoNotDeclareVisibleInstanceFields")]
        public Int16 dmDriverExtra;

        /// <summary>
        /// Especifica si algunos miembros de la estructura <strong>DEVMODE</strong> se ha inicializado.
        /// Si un miembro se ha inicializado, su correspondiente bit está establecido a '1', de lo contrario el bit es '0'.
        /// Un controlador admite sólo a los miembros <strong>DEVMODE</strong> que son adecuados para la impresora o dispositivo de visualización.
        /// Para más información ver <see cref="DM"/>.
        /// </summary>
        [FieldOffset(40)]
        [SuppressMessage("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        [SuppressMessage("Microsoft.Design", "CA1051:DoNotDeclareVisibleInstanceFields")] 
        public DM dmFields;

        /// <summary>
        /// Para dispositivos de impresión, selecciona la orientación del papel.
        /// Este miembro puede ser <strong>DMORIENT_PORTRAIT</strong> (1) o <strong>DMORIENT_LANDSCAPE</strong> (2).
        /// </summary>
        [FieldOffset(44)] 
        [SuppressMessage("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")] 
        private Int16 dmOrientation;

        /// <summary>
        /// Solor para dispositivos de impresión.
        /// Selecciona el tamaño del papel para imprimir. Este miembro puede establecerse a 0 si la longitud y anchura del papel 
        /// están establecidos por los miembros de <strong>dmPaperLength</strong>strong> y <strong>dmPaperWidth</strong>.
        /// De lo contrario, el miembro <strong>dmPaperSize</strong> se puede establecer con un valor específico mayor o igual a
        /// <strong>DMPAPER_USER</strong> o a uno de los siguientes valores predefinidos.
        /// </summary>
        [FieldOffset(46)] 
        [SuppressMessage("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")] 
        private Int16 dmPaperSize;

        /// <summary>
        /// Para dispositivos de impresión, reemplaza la longitud del documento especificado por el campo <strong>dmPaperSize</strong>, 
        /// para tamaños de papel personalizados o para dispositivos como impresoras de matriz de puntos que pueden imprimir en una página
        /// de longitud arbitraria.
        /// Estos valores, junto con los demás valores de esta estructura que especifican una longitud física, son en décimas de milímetro
        /// </summary>
        [FieldOffset(48)] 
        [SuppressMessage("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")] 
        private Int16 dmPaperLength;

        /// <summary>
        /// Sólo para dispositivos de impresión, reemplaza el ancho del papel especificado por el campo <strong>dmPaperSize</strong>
        /// </summary>
        [FieldOffset(50)]
        [SuppressMessage("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")] 
        private Int16 dmPaperWidth;

        /// <summary>
        /// Especifica el factor de escala. El tamaño aparente de la página se ajusta el tamaño de página física por un factor de <strong>dmScale</strong> /100.
        /// Por ejemplo, una página de tamaño carta con un valor de <strong>dmScale</strong> de 50 contendría tantos datos como una página de 17-22 pulgadas porque
        /// el texto y los gráficos sería la mitad de su altura y ancho.
        /// </summary>
        [FieldOffset(52)]
        [SuppressMessage("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")] 
        private Int16 dmScale;

        /// <summary>
        /// Número de copias, si el dispositivo acepta multicopias.
        /// </summary>
        [FieldOffset(54)] 
        [SuppressMessage("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")] 
        private Int16 dmCopies;

        /// <summary>
        /// Especifica el origen del papel. 
        /// Para recuperar una lista de las fuentes de papel disponibles para una impresora, utilice la función DeviceCapabilities con el flag <strong>DC_BINS</strong>. 
        /// Este miembro puede ser uno de los siguientes valores, o puede ser un valor específico del dispositivo mayor o igual a <strong>DMBIN_USER</strong>.
        /// </summary>
        [FieldOffset(56)] 
        [SuppressMessage("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")] 
        private Int16 dmDefaultSource;

        /// <summary>
        /// Especifica la resolución de la impresora.
        /// </summary>
        [FieldOffset(58)]
        [SuppressMessage("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        private Int16 dmPrintQuality;

        /// <summary>
        /// Para dispositivos de pantalla sólo, una estructura <see cref="POINTL"/> que indica las coordenadas posicionales de la pantalla en referencia
        /// a la zona de escritorio. El dispositivo de pantalla principal siempre está situado en las coordenadas (0,0).
        /// </summary>
        [FieldOffset(44)] 
        [SuppressMessage("Microsoft.Design", "CA1051:DoNotDeclareVisibleInstanceFields")] 
        public POINTL dmPosition;

        /// <summary>
        /// Para dispositivos de pantalla, la orientación a que se presenten imágenes.
        /// Si DM_DISPLAYORIENTATION no está configurado, este miembro debe ser cero.
        /// Si DM_DISPLAYORIENTATION está configurado, este miembro debe ser uno de los siguientes valores:
        /// <strong>DMDO_DEFAULT</strong>, la orientación de la pantalla es la orientación normal del dispositivo (opción por defecto).
        /// <strong>DMDO_90</strong>, la orientación de la pantalla se rota 90 grados. (en sentido de las agujas del reloj) desde su posición natural.
        /// <strong>DMDO_180</strong>, la orientación de la pantalla se rota 180 grados. (en sentido de las agujas del reloj) desde su posición natural.
        /// <strong>DMDO_270</strong>, la orientación de la pantalla se rota 270 grados. (en sentido de las agujas del reloj) desde su posición natural.
        /// </summary>
        [FieldOffset(52)] 
        [SuppressMessage("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        [SuppressMessage("Microsoft.Design", "CA1051:DoNotDeclareVisibleInstanceFields")]
        public Int32 dmDisplayOrientation;

        /// <summary>
        /// Para dispositivos de pantalla de resolución fija, cómo la pantalla presenta un modo de baja resolución en una pantalla de alta resolución.
        /// Por ejemplo, si la resolución de un dispositivo de visualización se fija en 1024 x 768 píxeles, pero su modo está establecido en 640 x 480 píxeles,
        /// el dispositivo puede mostrar una imagen de 640 x 480 en algún lugar en el interior del espacio de pantalla de 1024 x 768 o expandir la imagen
        /// de 640 x 480 para rellenar el espacio de pantalla más grande.
        /// Si <strong>DM_DISPLAYFIXEDOUTPUT</strong> no está configurado, este miembro debe ser cero.
        /// Si <strong>DM_DISPLAYFIXEDOUTPUT</strong> está configurado, este miembro debe ser uno de los siguientes valores:
        /// <strong>DMDFO_DEFAULT</strong>, configuración predeterminada de la pantalla.
        /// <strong>DMDFO_CENTER</strong>, la imagen de baja resolución se centra en el mayor espacio en la pantalla.
        /// <strong>DMDFO_STRETCH</strong>, la imagen de baja resolución se estira para rellenar el espacio de pantalla más grande
        /// </summary>
        [FieldOffset(56)] 
        [SuppressMessage("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")] 
        [SuppressMessage("Microsoft.Design", "CA1051:DoNotDeclareVisibleInstanceFields")] 
        public Int32 dmDisplayFixedOutput;

        /// <summary>
        /// Cambia entre color y monocromo en impresoras de color. Los valores posibles son las siguientes:
        /// <strong>DMCOLOR_COLOR </strong>.
        /// <strong>DMCOLOR_MONOCHROME </strong>.
        /// </summary>
        [FieldOffset(60)] 
        [SuppressMessage("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")] 
        [SuppressMessage("Microsoft.Design", "CA1051:DoNotDeclareVisibleInstanceFields")] 
        public short dmColor;

        /// <summary>
        /// Selecciona la impresión dúplex o caras para impresoras capaces de impresión a doble cara. Los siguientes son los valores posibles
        /// <strong>DMDUP_SIMPLEX</strong>, Impresión normal (noduplex).
        /// <strong>DMDUP_HORIZONTAL</strong>, el lado largo de la página es horizontal.
        /// <strong>DMDUP_VERTICAL</strong>, el lado largo de la página es vertical.
        /// </summary>
        [FieldOffset(62)] 
        [SuppressMessage("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")] 
        [SuppressMessage("Microsoft.Design", "CA1051:DoNotDeclareVisibleInstanceFields")] 
        public short dmDuplex;

        /// <summary>
        /// Especifica la resolución, en puntos por pulgada, de la impresora.
        /// Si la impresora inicializa este miembro, el campo <strong>dmPrintQuality</strong> especifica la resolución x, en puntos por pulgada, de la impresora.
        /// </summary>
        [FieldOffset(64)] 
        [SuppressMessage("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")] 
        [SuppressMessage("Microsoft.Design", "CA1051:DoNotDeclareVisibleInstanceFields")] 
        public short dmYResolution;

        /// <summary>
        /// Especifica cómo se deben imprimir fuentes TrueType. Este miembro puede ser uno de los siguientes valores.
        /// <strong>DMTT_BITMAP</strong>, imprime las fuentes TrueType como gráficos. Se trata de la acción predeterminada para impresoras matriciales.
        /// <strong>DMTT_DOWNLOAD</strong>, fuentes TrueType como transferibles. Se trata de la acción predeterminada para las impresoras Hewlett-Packard que utilizan
        /// el lenguaje de Control de impresoras (PCL).
        /// <strong>DMTT_DOWNLOAD_OUTLINE</strong>, como esquema transferible.
        /// <strong>DMTT_SUBDEV</strong>, sustituto para fuentes TrueType. Se trata de la acción predeterminada para las impresoras PostScript.
        /// </summary>
        [FieldOffset(66)] 
        [SuppressMessage("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")] 
        [SuppressMessage("Microsoft.Design", "CA1051:DoNotDeclareVisibleInstanceFields")] 
        public short dmTTOption;

        /// <summary>
        /// Especifica si se debe utilizar intercalación al imprimir varias copias. (Este campo se omite a menos que el controlador de impresora establezca el campo <strong>DM_COLLATE</strong>).
        /// Este miembro puede ser uno de los siguientes valores.
        /// <strong>DMCOLLATE_TRUE</strong>, intercalar al imprimir varias copias.
        /// <strong>DMCOLLATE_FALSE</strong>. no intercalar al imprimir varias copias.
        /// </summary>
        [FieldOffset(68)] 
        [SuppressMessage("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")] 
        [SuppressMessage("Microsoft.Design", "CA1051:DoNotDeclareVisibleInstanceFields")] 
        public short dmCollate;

        /// <summary>
        /// Una cadena que especifica el nombre del formulario para utilizar; por ejemplo, "Carta" o "Legal".
        /// Un conjunto completo de nombres se puede obtener mediante la función <strong>EnumForms</strong>.
        /// </summary>
        [FieldOffset(72)] 
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = CCHFORMNAME)] 
        [SuppressMessage("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        [SuppressMessage("Microsoft.Design", "CA1051:DoNotDeclareVisibleInstanceFields")] 
        public string dmFormName;

        /// <summary>
        /// Número de píxeles por pulgada. Los controladores de impresora no deben utilizar este campo.
        /// </summary>
        [FieldOffset(102)] 
        [SuppressMessage("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        [SuppressMessage("Microsoft.Design", "CA1051:DoNotDeclareVisibleInstanceFields")] 
        public Int16 dmLogPixels;

        /// <summary>
        /// Especifica la resolución de color, en bits por píxel, de la pantalla (por ejemplo: 4 bits de 16 colores, 8 bits de 256 colores o 16 bits para 65.536 colores).
        /// Los controladores de pantalla utilizan este campo, por ejemplo, en la función <strong>ChangeDisplaySettings</strong>. 
        /// Los controladores de impresora no deben utilizar este campo.
        /// </summary>
        [FieldOffset(104)] 
        [SuppressMessage("Microsoft.Design", "CA1051:DoNotDeclareVisibleInstanceFields")]
        public Int32 dmBitsPerPel;

        /// <summary>
        /// Especifica la anchura, en píxeles, de la superficie visible del dispositivo.
        /// Los controladores de pantalla utilizan este campo, por ejemplo, en la función <strong>ChangeDisplaySettings</strong>.
        /// Los controladores de impresora no deben utilizar este campo.
        /// </summary>
        [FieldOffset(108)] 
        [SuppressMessage("Microsoft.Design", "CA1051:DoNotDeclareVisibleInstanceFields")] 
        public Int32 dmPelsWidth;

        /// <summary>
        /// Especifica el alto, en píxeles, de la superficie visible del dispositivo.
        /// Los controladores de pantalla utilizan este campo, por ejemplo, en la función <strong>ChangeDisplaySettings</strong>.
        /// Los controladores de impresora no deben utilizar este campo.
        /// </summary>
        [FieldOffset(112)]
        [SuppressMessage("Microsoft.Design", "CA1051:DoNotDeclareVisibleInstanceFields")]
        public Int32 dmPelsHeight;

        /// <summary>
        /// Especifica el modo de visualización del dispositivo. Este miembro puede ser una combinación de los siguientes valores.
        /// <strong>DM_GRAYSCALE</strong>, especifica que la pantalla es un dispositivo monocromo. Si no se establece este indicador, se asume que es de color.
        /// <strong>DM_INTERLACED</strong>, especifica que el modo de visualización es entrelazado. Si no se establece este indicador, se asume que es no entrelazado.
        /// </summary>
        [FieldOffset(116)]
        [SuppressMessage("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")] 
        [SuppressMessage("Microsoft.Design", "CA1051:DoNotDeclareVisibleInstanceFields")] 
        [SuppressMessage("Microsoft.Naming", "CA1726:UsePreferredTerms", MessageId = "Flags")]
        public DisplayFlags dmDisplayFlags;

        /// <summary>
        /// Especifica dónde se realiza el NUP. Puede ser uno de los siguientes.
        /// <strong>DMNUP_SYSTEM</strong>, la cola de impresión hace NUP.
        /// <strong>DMNUP_ONEUP</strong>, la aplicación hace NUP.
        /// </summary>
        [FieldOffset(116)]
        [SuppressMessage("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        [SuppressMessage("Microsoft.Design", "CA1051:DoNotDeclareVisibleInstanceFields")]
        public Int32 dmNup;

        /// <summary>
        /// Especifica la frecuencia, en hertz (ciclos por segundo), de la pantalla en un modo especial.
        /// Este valor se conoce como tasa de refresco vertical del dispositivo de pantalla.
        /// Los controladores de pantalla utilizan a este miembro. Por ejemplo, se utiliza en la función <strong>ChangeDisplaySettings</strong>.
        /// Los controladores de impresora no deben utilizar este campo.
        /// Cuando se llama a la función <strong>EnumDisplaySettings</strong>, puede devolver el campo <strong>dmDisplayFrequency</strong> con el valor 0 ó 1,
        /// estos valores representan la frecuencia de actualización del hardware de visualización por defecto.
        /// Esta tasa predeterminada se establece mediante conmutadores en una motherboard de equipo o la tarjeta de presentación,
        /// o por un programa de configuración que no utilizan funciones de visualización como <strong>ChangeDisplaySettings</strong>.
        /// </summary>
        [FieldOffset(120)] 
        [SuppressMessage("Microsoft.Design", "CA1051:DoNotDeclareVisibleInstanceFields")]
        public Int32 dmDisplayFrequency;
        #endregion

        #region Interfaces

            #region [public] (bool) Equals(DEVMODE): Indica si la estructura actual es igual a otra estructura del mismo tipo.
            /// <summary>
            /// Indica si la estructura actual es igual a otra estructura del mismo tipo.
            /// </summary>
            /// <param name="other">Estructura que se va a comparar con esta estructura.</param>
            /// <returns>
            /// Devuelve <strong>true</strong> si la estructura actual es igual al parámetro <c>other</c>; en caso contrario, <strong>false</strong>.
            /// </returns>
            public bool Equals(DEVMODE other)
            {
                return other.Equals((object) this);
            }
            #endregion

        #endregion

        #region Overrides

            #region [public] {override} (int) GetHashCode(): Devuelve un valor que repesenta al código hash de esta estructura.
            /// <summary>
            /// Devuelve un valor que repesenta al código hash de esta estructura.
            /// </summary>
            /// <returns>
            /// 	<para>Tipo: <see cref="T:System.Int32"/></para>
            /// 	<para>Código Hash de esta estructura.</para>
            /// </returns>
            public override int GetHashCode()
            {
                return dmPelsWidth ^ dmPelsHeight ^ dmBitsPerPel ^ dmDisplayFrequency;
            }
            #endregion

            #region [public] {override} (bool) Equals(object): Devuelve un valor que indica si esta estructutra es igual a otra.
            /// <summary>
            /// Devuelve un valor que indica si esta estructutra es igual a otra.
            /// </summary>
            /// <param name="obj">Estructura con la que comparar.</param>
            /// <returns>Resultado de la comparación de igualdad.</returns>
            public override bool Equals(object obj)
            {
                if (obj == null)
                    return false;

                if (!(obj is DEVMODE))
                    return false;

                DEVMODE other = (DEVMODE) obj;
                return (other.dmPelsWidth == dmPelsWidth) && (other.dmPelsHeight == dmPelsHeight) &&
                        (other.dmBitsPerPel == dmBitsPerPel) && (other.dmDisplayFrequency == dmDisplayFrequency);
            }
            #endregion

            #region [public] {override} (string) ToString(): Devuelve una cadena que representa a la estructura actual.
            /// <summary>
            /// Devuelve una cadena que representa la estructura <see cref="DEVMODE"/> actual.
            /// </summary>
            /// <returns>
            /// 	<para>Tipo: <see cref="T:System.String"/></para>
            /// 	<para>Cadena que representa la estructura <see cref="DEVMODE"/> actual.</para>
            /// </returns>
            /// <remarks>
            /// El método <see cref="DEVMODE.ToString()"/> devuelve una cadena que incluye la resolución, profundidad de color y velocidad de refresco actual.
            /// </remarks>
            public override string ToString()
            {
                return String.Format(CultureInfo.InvariantCulture, "{0} x {1}, {2} bits, {3}hz", dmPelsWidth, dmPelsHeight, dmBitsPerPel, dmDisplayFrequency);
            }
            #endregion

        #endregion

        #region Operadores

            #region [public] {static} (bool) operator ==(DEVMODE, DEVMODE): Implementa el operador de igualdad (==).
            /// <summary>
            /// Implementa el operador de igualdad (==).
            /// </summary>
            /// <param name="deviceInfo1">Operando 1.</param>
            /// <param name="deviceInfo2">Operando 2.</param>
            /// <returns>
            /// Devuelve <b>true</b> si <c>deviceInfo1</c> es igual a <c>deviceInfo2</c>; <b>false</b> en caso contrario.
            /// </returns>
            public static bool operator ==(DEVMODE deviceInfo1, DEVMODE deviceInfo2)
            {
                return deviceInfo1.Equals(deviceInfo2);
            }
            #endregion

            #region [public] {static} (bool) operator !=(DEVMODE, DEVMODE): Implementa el operador de desigualdad (!=).
            /// <summary>
            /// Implementa el operador de desigualdad (!=).
            /// </summary>
            /// <param name="deviceInfo1">Operando 1.</param>
            /// <param name="deviceInfo2">Operando 2.</param>
            /// <returns>
            /// Devuelve <strong>true</strong> si <c>deviceInfo1</c> no es igual a <c>deviceInfo2</c>; <strong>false</strong> en caso contrario.
            /// </returns>
            public static bool operator !=(DEVMODE deviceInfo1, DEVMODE deviceInfo2)
            {
                return !deviceInfo1.Equals(deviceInfo2);
            }
            #endregion

        #endregion

        #region Miembros privados

            #region Constantes
            private const int CCHFORMNAME = 0x20;
            private const int CCHDEVICENAME = 0x20;
            #endregion

        #endregion

        #region Miembros estáticos
        public static DEVMODE Empty = new DEVMODE { dmSize = (short)Marshal.SizeOf(typeof(DEVMODE)) };
        #endregion
    }
}