
namespace iTin.Core.Interop.Windows.Development.Storage.LocalFileSystems.DiskManagement
{
    using System;
    using System.Globalization;
    using System.Runtime.InteropServices;

    /// <summary>
    /// Contains extended information about a drive's partitions.
    /// </summary>
    /// <remarks>
    /// For more information, please see https://docs.microsoft.com/en-us/windows/win32/api/winioctl/ns-winioctl-drive_layout_information_ex.
    /// </remarks>
    [StructLayout(LayoutKind.Explicit)]
    public struct DRIVE_LAYOUT_INFORMATION_EX : IEquatable<DRIVE_LAYOUT_INFORMATION_EX>
    {
        #region Atributos
        /// <summary>
        /// El estilo de las particiones en la unidad enumerados por la enumeración <see cref="PARTITION_STYLE"/>.
        /// </summary>
        [FieldOffset(0)]
        public PARTITION_STYLE PartitionStyle;

        /// <summary>
        /// Número de particiones en la unidad. En discos con el diseño MBR, este valor será siempre un múltiplo de 4.
        /// En las particiones que no se utilizan el miembro <see cref="PARTITION_INFORMATION_MBR.PartitionType"/> 
        /// del miembro <see cref="PARTITION_INFORMATION_EX.Mbr"/> será de tipo <see cref="DiskManagement.PARTITION_TYPE.ENTRY_UNUSED"/>.
        /// </summary>
        [FieldOffset(4)]
        public Int32 PartitionCount;

        /// <summary>
        /// Una estructura <see cref="DRIVE_LAYOUT_INFORMATION_MBR"/> que contiene información sobre la partición de tipo MBR en la unidad.
        /// </summary>
        [FieldOffset(8)]
        public DRIVE_LAYOUT_INFORMATION_MBR Mbr;

        /// <summary>
        /// Una estructura <see cref="DRIVE_LAYOUT_INFORMATION_GPT"/> que contiene información sobre la partición de tipo GPT en la unidad.
        /// </summary>
        [FieldOffset(8)]
        public DRIVE_LAYOUT_INFORMATION_GPT Gpt;

        // ------------------
        // PartitionEntry, Array de estructuras PARTITION_INFORMATION_EX, una estructura para cada partición del disco.
        // Como no sabemos el tamaño del Array a declarar no declaramos este miembro, y después en código lo calcularemos de forma dinámica.
        // ------------------
        #endregion

        #region Interfaces

            #region [public] (bool) Equals(DRIVE_LAYOUT_INFORMATION_EX): Indica si la estructura actual es igual a otra estructura del mismo tipo.
            /// <summary>
            /// Indica si la estructura actual es igual a otra estructura del mismo tipo.
            /// </summary>
            /// <param name="other">Estructura que se va a comparar con esta estructura.</param>
            /// <returns>
            /// Devuelve <strong>true</strong> si la estructura actual es igual al parámetro <c>other</c>; en caso contrario, <strong>false</strong>.
            /// </returns>
            public bool Equals(DRIVE_LAYOUT_INFORMATION_EX other)
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

                if (!(obj is DRIVE_LAYOUT_INFORMATION_EX))
                    return false;

                var other = (DRIVE_LAYOUT_INFORMATION_EX)obj;
                return (other.Gpt == Gpt) &&
                       (other.Mbr == Mbr) &&
                       (other.PartitionCount == PartitionCount) &&
                       (other.PartitionStyle == PartitionStyle);
            }
            #endregion

            #region [public] {override} (string) ToString(): Devuelve una cadena que representa a la estructura actual.
            /// <summary>
            /// Devuelve una cadena que representa la estructura <see cref="DRIVE_LAYOUT_INFORMATION_EX"/> actual.
            /// </summary>
            /// <returns>
            /// 	<para>Tipo: <see cref="T:System.String"/></para>
            /// 	<para>Cadena que representa la estructura <see cref="DRIVE_LAYOUT_INFORMATION_EX"/> actual.</para>
            /// </returns>
            /// <remarks>
            /// El método <see cref="DRIVE_LAYOUT_INFORMATION_EX.ToString()"/> devuelve una cadena que incluye el tamaño.
            /// </remarks>
            public override string ToString()
            {
                return String.Format(CultureInfo.InvariantCulture, "Count {0}", PartitionCount);
            }
            #endregion

        #endregion

        #region Operadores

            #region [public] {static} (bool) operator ==(DRIVE_LAYOUT_INFORMATION_EX, DRIVE_LAYOUT_INFORMATION_EX): Implementa el operador de igualdad (==).
            /// <summary>
            /// Implementa el operador de igualdad (==).
            /// </summary>
            /// <param name="operator1">Operando 1.</param>
            /// <param name="operator2">Operando 2.</param>
            /// <returns>
            /// Devuelve <strong>true</strong> si <c>operator1</c> es igual a <c>operator2</c>; <strong>false</strong> en caso contrario.
            /// </returns>
            public static bool operator ==(DRIVE_LAYOUT_INFORMATION_EX operator1, DRIVE_LAYOUT_INFORMATION_EX operator2)
            {
                return operator1.Equals(operator2);
            }
            #endregion

            #region [public] {static} (bool) operator !=(DRIVE_LAYOUT_INFORMATION_EX, DRIVE_LAYOUT_INFORMATION_EX): Implementa el operador de desigualdad (!=).
            /// <summary>
            /// Implementa el operador de desigualdad (!=).
            /// </summary>
            /// <param name="operator1">Operando 1.</param>
            /// <param name="operator2">Operando 2.</param>
            /// <returns>
            /// Devuelve <strong>true</strong> si <c>operator1</c> no es igual a <c>operator2</c>; <strong>false</strong> en caso contrario.
            /// </returns>
            public static bool operator !=(DRIVE_LAYOUT_INFORMATION_EX operator1, DRIVE_LAYOUT_INFORMATION_EX operator2)
            {
                return !operator1.Equals(operator2);
            }
            #endregion

        #endregion
    }
}