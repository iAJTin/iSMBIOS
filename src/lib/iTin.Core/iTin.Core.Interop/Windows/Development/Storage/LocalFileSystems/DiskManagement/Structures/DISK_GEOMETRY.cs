using System;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Runtime.InteropServices;

namespace iTin.Core.Interop.Windows.Development.Storage.LocalFileSystems.DiskManagement
{
    /// <summary>
    /// La estructura de datos <strong>DISK_GEOMETRY</strong> contiene información del escritorio asociado a un determinado monitor.    
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    [SuppressMessage("Microsoft.Naming", "CA1707:IdentifiersShouldNotContainUnderscores")]
    [SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", MessageId = "DISK")]
    [SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", MessageId = "GEOMETRY")]
    struct DISK_GEOMETRY : IEquatable<DISK_GEOMETRY>
    {
        #region Atributos
        /// <summary>
        /// Número de cilindros.
        /// </summary>
        public long Cylinders;
        /// <summary>
        /// Tipo de media. Más información ver <see cref="MEDIA_TYPE"/>.
        /// </summary>
        public MEDIA_TYPE MediaType;
        /// <summary>
        /// Número de pistas por cilindro.
        /// </summary>
        public int TracksPerCylinder;
        /// <summary>
        /// Número de sectores por pista.
        /// </summary>
        public int SectorsPerTrack;
        /// <summary>
        /// Número de bytes por sector.
        /// </summary>
        public int BytesPerSector;
        #endregion

        #region Propiedades

            #region [public] (long) DiskSize: Obtiene un valor que representa el tamaño del disco, se mide en bytes.
            /// <summary>
            /// Obtiene un valor que representa el tamaño del disco, se mide en bytes.
            /// </summary>
            /// <value>
            ///   <para>Tipo: <see cref="T:System.Int64"/></para>
            ///   <para>Tamaño del disco en bytes.</para>
            /// </value>
            public long DiskSize
            {
                get { return Cylinders * TracksPerCylinder * SectorsPerTrack * BytesPerSector; }
            }
            #endregion

        #endregion        

        #region Interfaces

            #region [public] (bool) Equals(DISK_GEOMETRY): Indica si la estructura actual es igual a otra estructura del mismo tipo.
            /// <summary>
            /// Indica si la estructura actual es igual a otra estructura del mismo tipo.
            /// </summary>
            /// <param name="other">Estructura que se va a comparar con esta estructura.</param>
            /// <returns>
            /// Devuelve <strong>true</strong> si la estructura actual es igual al parámetro <c>other</c>; en caso contrario, <strong>false</strong>.
            /// </returns>
            public bool Equals(DISK_GEOMETRY other)
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

                if (!(obj is DISK_GEOMETRY))
                    return false;

                var other = (DISK_GEOMETRY)obj;
                return (other.Cylinders == Cylinders) &&
                       (other.MediaType == MediaType) &&
                       (other.TracksPerCylinder == TracksPerCylinder) &&
                       (other.SectorsPerTrack == SectorsPerTrack) &&
                       (other.BytesPerSector == BytesPerSector);
            }
            #endregion

            #region [public] {override} (string) ToString(): Devuelve una cadena que representa a la estructura actual.
            /// <summary>
            /// Devuelve una cadena que representa la estructura <see cref="DISK_GEOMETRY"/> actual.
            /// </summary>
            /// <returns>
            /// 	<para>Tipo: <see cref="T:System.String"/></para>
            /// 	<para>Cadena que representa la estructura <see cref="DISK_GEOMETRY"/> actual.</para>
            /// </returns>
            /// <remarks>
            /// El método <see cref="DISK_GEOMETRY.ToString()"/> devuelve una cadena que incluye el tamaño.
            /// </remarks>
            public override string ToString()
            {
                return String.Format(CultureInfo.InvariantCulture, "{0}", DiskSize);
            }
            #endregion

        #endregion

        #region Operadores

            #region [public] {static} (bool) operator ==(DISK_GEOMETRY, DISK_GEOMETRY): Implementa el operador de igualdad (==).
            /// <summary>
            /// Implementa el operador de igualdad (==).
            /// </summary>
            /// <param name="operator1">Operando 1.</param>
            /// <param name="operator2">Operando 2.</param>
            /// <returns>
            /// Devuelve <strong>true</strong> si <c>operator1</c> es igual a <c>operator2</c>; <strong>false</strong> en caso contrario.
            /// </returns>
            public static bool operator ==(DISK_GEOMETRY operator1, DISK_GEOMETRY operator2)
            {
                return operator1.Equals(operator2);
            }
            #endregion

            #region [public] {static} (bool) operator !=(DISK_GEOMETRY, DISK_GEOMETRY): Implementa el operador de desigualdad (!=).
            /// <summary>
            /// Implementa el operador de desigualdad (!=).
            /// </summary>
            /// <param name="operator1">Operando 1.</param>
            /// <param name="operator2">Operando 2.</param>
            /// <returns>
            /// Devuelve <strong>true</strong> si <c>operator1</c> no es igual a <c>operator2</c>; <strong>false</strong> en caso contrario.
            /// </returns>
            public static bool operator !=(DISK_GEOMETRY operator1, DISK_GEOMETRY operator2)
            {
                return !operator1.Equals(operator2);
            }
            #endregion

        #endregion

        #region Miembros estáticos
        /// <summary>
        /// Estructura vacía.
        /// </summary>
        public static readonly DISK_GEOMETRY Empty;
        #endregion
    }
}