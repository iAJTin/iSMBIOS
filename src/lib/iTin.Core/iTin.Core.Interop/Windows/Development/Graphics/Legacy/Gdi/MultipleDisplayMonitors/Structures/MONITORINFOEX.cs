using System;
using System.Globalization;
using System.Runtime.InteropServices;

using iTin.Core.Interop.Windows.Development.Graphics.Legacy.Gdi.Rectangles;

namespace iTin.Core.Interop.Windows.Development.Graphics.Legacy.Gdi.MultipleDisplayMonitors
{
    /// <summary>
    /// La estructura <strongs>MONITORINFOEX</strongs> contiene información acerca de un monitor.
    /// La estructura <strongs>MONITORINFOEX</strongs> es un superconjunto de la estructura <see cref="MONITORINFO"/>.
    /// </summary>
    /// <remarks>
    /// Para más información, ver http://msdn.microsoft.com/es-es/library/dd145066.
    /// </remarks>
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Auto)]
    struct MONITORINFOEX : IEquatable<MONITORINFOEX>
    {
        #region Constantes
        public const uint MONITORINFOF_PRIMARY = 0x00000001;
        #endregion
       
        #region Atributos
        /// <summary>
        /// Especifica el tamaño, en bytes, de la estructura <strong>MONITORINFOEX</strong>.
        /// Se debe inicializar antes de llamar a una función <strong>Api</strong>.
        /// </summary>
        public int Size;

        /// <summary>
        /// Una estructura <see cref="RECT"/> que especifica el rectángulo del área total del monitor.
        /// </summary>
        public RECT Monitor;

        /// <summary>
        /// Una estructura <see cref="RECT"/> que especifica el rectángulo del área de trabajo del monitor útil 
        /// que puede ser utilizado por las aplicaciones, expresada en coordenadas de pantalla virtual.
        /// Windows utiliza este rectángulo para maximizar una aplicación en el monitor.
        /// Se excluye barras de herramientas, de estado, etc.
        /// </summary>
        public RECT WorkArea;

        /// <summary>
        /// Atributos del monitor.
        /// </summary>
        public uint Flags;

        /// <summary>
        /// Una cadena que especifica el nombre del monitor.
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = CCHDEVICENAME)]
        public string DeviceName;
        #endregion

        #region Interfaces

            #region [public] (bool) Equals(MONITORINFOEX): Indica si la estructura actual es igual a otra estructura del mismo tipo.
            /// <summary>
            /// Indica si la estructura actual es igual a otra estructura del mismo tipo.
            /// </summary>
            /// <param name="other">Estructura que se va a comparar con esta estructura.</param>
            /// <returns>
            /// Devuelve <strong>true</strong> si la estructura actual es igual al parámetro <c>other</c>; en caso contrario, <strong>false</strong>.
            /// </returns>
            public bool Equals(MONITORINFOEX other)
            {
                return other.Equals((object)this);
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
                return ToString().GetHashCode();
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

                if (!(obj is MONITORINFOEX))
                    return false;

                var other = (MONITORINFOEX)obj;
                return (other.Monitor == Monitor) &&
                       (other.WorkArea == WorkArea) &&
                       (other.Flags == Flags) &&
                       (other.DeviceName == DeviceName);
            }
            #endregion

            #region [public] {override} (string) ToString(): Devuelve una cadena que representa a la estructura actual.
            /// <summary>
            /// Devuelve una cadena que representa la estructura <see cref="MONITORINFOEX"/> actual.
            /// </summary>
            /// <returns>
            /// 	<para>Tipo: <see cref="T:System.String"/></para>
            /// 	<para>Cadena que representa la estructura <see cref="MONITORINFOEX"/> actual.</para>
            /// </returns>
            /// <remarks>
            /// El método <see cref="MONITORINFOEX.ToString()"/> devuelve una cadena que incluye el nombre del monitor.
            /// </remarks>
            public override string ToString()
            {
                return string.Format(CultureInfo.InvariantCulture, "DeviceName = {0}", DeviceName);
            }
            #endregion

        #endregion

        #region Operadores

            #region [public] {static} (bool) operator ==(MONITORINFOEX, MONITORINFOEX): Implementa el operador de igualdad (==).
            /// <summary>
            /// Implementa el operador de igualdad (==).
            /// </summary>
            /// <param name="operator1">Operando 1.</param>
            /// <param name="operator2">Operando 2.</param>
            /// <returns>
            /// Devuelve <strong>true</strong> si <c>operator1</c> es igual a <c>operator2</c>; <strong>false</strong> en caso contrario.
            /// </returns>
            public static bool operator ==(MONITORINFOEX operator1, MONITORINFOEX operator2)
            {
                return operator1.Equals(operator2);
            }
            #endregion

            #region [public] {static} (bool) operator !=(MONITORINFOEX, MONITORINFOEX): Implementa el operador de desigualdad (!=).
            /// <summary>
            /// Implementa el operador de desigualdad (!=).
            /// </summary>
            /// <param name="operator1">Operando 1.</param>
            /// <param name="operator2">Operando 2.</param>
            /// <returns>
            /// Devuelve <strong>true</strong> si <c>operator1</c> no es igual a <c>operator2</c>; <strong>false</strong> en caso contrario.
            /// </returns>
            public static bool operator !=(MONITORINFOEX operator1, MONITORINFOEX operator2)
            {
                return !operator1.Equals(operator2);
            }
            #endregion

        #endregion

        #region Miembros privados

            #region Constantes
            private const int CCHDEVICENAME = 0x20;
            #endregion

        #endregion

        #region Miembros estáticos
        public static readonly MONITORINFOEX Empty = new MONITORINFOEX { Size = Marshal.SizeOf(typeof(MONITORINFOEX)) };
        #endregion
    }
}