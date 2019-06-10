using System;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Runtime.InteropServices;

namespace iTin.Core.Interop.Windows.Development.Storage.LocalFileSystems.DiskManagement
{
    /// <summary>
    /// Proporciona información acerca de las particiones GPT.
    /// </summary>
    /// <remarks>
    /// Para más información ver: http://msdn.microsoft.com/en-us/library/aa364003%28v=VS.85%29.aspx
    /// </remarks>
    [StructLayout(LayoutKind.Sequential)]
    [SuppressMessage("Microsoft.Naming", "CA1707:IdentifiersShouldNotContainUnderscores")]
    [SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", MessageId = "LAYOUT")]
    [SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", MessageId = "DRIVE")]
    [SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", MessageId = "GPT")]
    [SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", MessageId = "INFORMATION")]
    struct DRIVE_LAYOUT_INFORMATION_GPT : IEquatable<DRIVE_LAYOUT_INFORMATION_GPT>
    {
        #region Atributos
        /// <summary>
        /// <see cref="Guid"/> del disco,
        /// </summary>
        public Guid DiskId;

        /// <summary>
        ///	Offset del byte inicial del primer bloque utilizable.
        /// </summary>
        public Int64 StartingUsableOffset;

        /// <summary>
        /// Tamaño de los bloques utilizables en el disco, en bytes.
        /// </summary>
        public Int64 UsableLength;

        /// <summary>
        /// Número máximo de particiones que pueden definirse en el bloque utilizable.
        /// </summary>
        public Int32 MaxPartitionCount;
        #endregion

        #region Interfaces

            #region [public] (bool) Equals(DRIVE_LAYOUT_INFORMATION_GPT): Indica si la estructura actual es igual a otra estructura del mismo tipo.
            /// <summary>
            /// Indica si la estructura actual es igual a otra estructura del mismo tipo.
            /// </summary>
            /// <param name="other">Estructura que se va a comparar con esta estructura.</param>
            /// <returns>
            /// Devuelve <strong>true</strong> si la estructura actual es igual al parámetro <c>other</c>; en caso contrario, <strong>false</strong>.
            /// </returns>
            public bool Equals(DRIVE_LAYOUT_INFORMATION_GPT other)
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

                if (!(obj is DRIVE_LAYOUT_INFORMATION_GPT))
                    return false;

                var other = (DRIVE_LAYOUT_INFORMATION_GPT)obj;
                return (other.DiskId == DiskId) &&
                       (other.MaxPartitionCount == MaxPartitionCount) &&
                       (other.StartingUsableOffset == StartingUsableOffset) &&
                       (other.UsableLength == UsableLength);
            }
            #endregion

            #region [public] {override} (string) ToString(): Devuelve una cadena que representa a la estructura actual.
            /// <summary>
            /// Devuelve una cadena que representa la estructura <see cref="DRIVE_LAYOUT_INFORMATION_GPT"/> actual.
            /// </summary>
            /// <returns>
            /// 	<para>Tipo: <see cref="T:System.String"/></para>
            /// 	<para>Cadena que representa la estructura <see cref="DRIVE_LAYOUT_INFORMATION_GPT"/> actual.</para>
            /// </returns>
            /// <remarks>
            /// El método <see cref="DRIVE_LAYOUT_INFORMATION_GPT.ToString()"/> devuelve una cadena que incluye el tamaño.
            /// </remarks>
            public override string ToString()
            {
                return String.Format(CultureInfo.InvariantCulture, "Count {0}", MaxPartitionCount);
            }
            #endregion

        #endregion

        #region Operadores

            #region [public] {static} (bool) operator ==(DRIVE_LAYOUT_INFORMATION_GPT, DRIVE_LAYOUT_INFORMATION_GPT): Implementa el operador de igualdad (==).
            /// <summary>
            /// Implementa el operador de igualdad (==).
            /// </summary>
            /// <param name="operator1">Operando 1.</param>
            /// <param name="operator2">Operando 2.</param>
            /// <returns>
            /// Devuelve <strong>true</strong> si <c>operator1</c> es igual a <c>operator2</c>; <strong>false</strong> en caso contrario.
            /// </returns>
            public static bool operator ==(DRIVE_LAYOUT_INFORMATION_GPT operator1, DRIVE_LAYOUT_INFORMATION_GPT operator2)
            {
                return operator1.Equals(operator2);
            }
            #endregion

            #region [public] {static} (bool) operator !=(DRIVE_LAYOUT_INFORMATION_GPT, DRIVE_LAYOUT_INFORMATION_GPT): Implementa el operador de desigualdad (!=).
            /// <summary>
            /// Implementa el operador de desigualdad (!=).
            /// </summary>
            /// <param name="operator1">Operando 1.</param>
            /// <param name="operator2">Operando 2.</param>
            /// <returns>
            /// Devuelve <strong>true</strong> si <c>operator1</c> no es igual a <c>operator2</c>; <strong>false</strong> en caso contrario.
            /// </returns>
            public static bool operator !=(DRIVE_LAYOUT_INFORMATION_GPT operator1, DRIVE_LAYOUT_INFORMATION_GPT operator2)
            {
                return !operator1.Equals(operator2);
            }
            #endregion

        #endregion
    }
}