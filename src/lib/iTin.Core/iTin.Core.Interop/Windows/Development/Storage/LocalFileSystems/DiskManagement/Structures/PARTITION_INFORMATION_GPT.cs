using System;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Runtime.InteropServices;

namespace iTin.Core.Interop.Windows.Development.Storage.LocalFileSystems.DiskManagement
{
    /// <summary>
    /// Contiene la tabla de particiones GUID (GPT).
    /// </summary>
    /// <remarks>
    /// Para más información ver: http://msdn.microsoft.com/en-us/library/aa365449%28v=VS.85%29.aspx
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, CharSet = CharSet.Unicode)]
    [SuppressMessage("Microsoft.Naming", "CA1707:IdentifiersShouldNotContainUnderscores")]
    [SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", MessageId = "INFORMATION")]
    [SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", MessageId = "GPT")]
    [SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", MessageId = "PARTITION")]
    struct PARTITION_INFORMATION_GPT : IEquatable<PARTITION_INFORMATION_GPT>
    {
        #region Atributos
        /// <summary>
        /// <see cref="Guid"/> que identifica el tipo de partición.
        /// </summary>
        [FieldOffset(0)]
        public Guid PartitionType;

        /// <summary>
        /// <see cref="Guid"/> de la partición.
        /// </summary>
        [FieldOffset(16)]
        public Guid PartitionId;

        /// <summary>
        /// Atributos de la partición Extensible Firmware Interface (EFI).
        /// </summary>
        [FieldOffset(32)]
        public UInt64 Attributes;

        /// <summary>
        /// Cadena de caracteres que describe la partición.
        /// </summary>
        [FieldOffset(40)]
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 36)]
        public string Name;
        #endregion

        #region Interfaces

            #region [public] (bool) Equals(PARTITION_INFORMATION_GPT): Indica si la estructura actual es igual a otra estructura del mismo tipo.
            /// <summary>
            /// Indica si la estructura actual es igual a otra estructura del mismo tipo.
            /// </summary>
            /// <param name="other">Estructura que se va a comparar con esta estructura.</param>
            /// <returns>
            /// Devuelve <strong>true</strong> si la estructura actual es igual al parámetro <c>other</c>; en caso contrario, <strong>false</strong>.
            /// </returns>
            public bool Equals(PARTITION_INFORMATION_GPT other)
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

                if (!(obj is PARTITION_INFORMATION_GPT))
                    return false;

                var other = (PARTITION_INFORMATION_GPT)obj;
                return (other.Attributes == Attributes) &&
                       (other.Name == Name) &&
                       (other.PartitionId == PartitionId) &&
                       (other.PartitionType == PartitionType);
            }
            #endregion

            #region [public] {override} (string) ToString(): Devuelve una cadena que representa a la estructura actual.
            /// <summary>
            /// Devuelve una cadena que representa la estructura <see cref="PARTITION_INFORMATION_GPT"/> actual.
            /// </summary>
            /// <returns>
            /// 	<para>Tipo: <see cref="T:System.String"/></para>
            /// 	<para>Cadena que representa la estructura <see cref="PARTITION_INFORMATION_GPT"/> actual.</para>
            /// </returns>
            /// <remarks>
            /// El método <see cref="PARTITION_INFORMATION_GPT.ToString()"/> devuelve una cadena que incluye el nombre de la partición.
            /// </remarks>
            public override string ToString()
            {
                return string.Format(CultureInfo.InvariantCulture, "Name = {0}", Name);
            }
            #endregion

        #endregion

        #region Operadores

            #region [public] {static} (bool) operator ==(PARTITION_INFORMATION_GPT, PARTITION_INFORMATION_GPT): Implementa el operador de igualdad (==).
            /// <summary>
            /// Implementa el operador de igualdad (==).
            /// </summary>
            /// <param name="operator1">Operando 1.</param>
            /// <param name="operator2">Operando 2.</param>
            /// <returns>
            /// Devuelve <strong>true</strong> si <c>operator1</c> es igual a <c>operator2</c>; <strong>false</strong> en caso contrario.
            /// </returns>
            public static bool operator ==(PARTITION_INFORMATION_GPT operator1, PARTITION_INFORMATION_GPT operator2)
            {
                return operator1.Equals(operator2);
            }
            #endregion

            #region [public] {static} (bool) operator !=(PARTITION_INFORMATION_GPT, PARTITION_INFORMATION_GPT): Implementa el operador de desigualdad (!=).
            /// <summary>
            /// Implementa el operador de desigualdad (!=).
            /// </summary>
            /// <param name="operator1">Operando 1.</param>
            /// <param name="operator2">Operando 2.</param>
            /// <returns>
            /// Devuelve <strong>true</strong> si <c>operator1</c> no es igual a <c>operator2</c>; <strong>false</strong> en caso contrario.
            /// </returns>
            public static bool operator !=(PARTITION_INFORMATION_GPT operator1, PARTITION_INFORMATION_GPT operator2)
            {
                return !operator1.Equals(operator2);
            }
            #endregion

        #endregion
    }
}