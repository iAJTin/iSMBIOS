
namespace iTin.Core.Interop.Windows.Development.Storage.LocalFileSystems.DiskManagement
{
    using System;
    using System.Runtime.InteropServices;

    /// <summary>
    /// Contains partition information for standard AT-style master boot record (MBR) and Extensible Firmware Interface (EFI) disks.
    /// </summary>
    /// <remarks>
    /// For more information, please see https://docs.microsoft.com/en-us/windows/win32/api/winioctl/ns-winioctl-partition_information_ex.
    /// </remarks>
    [StructLayout(LayoutKind.Explicit)]
    public struct PARTITION_INFORMATION_EX : IEquatable<PARTITION_INFORMATION_EX>
    {
        #region public members
        /// <summary>
        /// Uno de los valores de la enumeración <see cref="PARTITION_STYLE"/> que representa el formato de la partición.
        /// </summary>
        [FieldOffset(0)]
        public PARTITION_STYLE PartitionStyle;

        /// <summary>
        /// Offset inicial de la partición en bytes.
        /// </summary>
        [FieldOffset(8)]
        public Int64 StartingOffset;

        /// <summary>
        /// Tamaño de la partición, en bytes.
        /// </summary>
        [FieldOffset(16)]
        public Int64 PartitionLength;

        /// <summary>
        /// Número de partición, (empieza en 1).
        /// </summary>
        [FieldOffset(24)]
        public Int32 PartitionNumber;

        /// <summary>
        /// <strong>true</strong> si la partición es regrabable. El valor de este parámetro debería ser <strong>true</strong>.
        /// </summary>
        [FieldOffset(28)]
        [MarshalAs(UnmanagedType.U1)]
        public Boolean RewritePartition;

        /// <summary>
        /// Una estructura <see cref="PARTITION_INFORMATION_MBR"/> que especifica la información de partición específica para discos Master Boot Record (MBR).
        /// El formato de partición MBR es el formato estándar.
        /// </summary>
        [FieldOffset(32)]
        public PARTITION_INFORMATION_MBR Mbr;

        /// <summary>
        /// Una estructura <see cref="PARTITION_INFORMATION_GPT"/> que especifica la información de partición específica para discos GUID partition table (GPT).
        /// El formato GPT se corresponde con el formato de la partición EFI.
        /// </summary>
        [FieldOffset(32)]
        public PARTITION_INFORMATION_GPT Gpt;
        #endregion

        #region interfaces

        #region [public] (bool) Equals(PARTITION_INFORMATION_EX): Indica si la estructura actual es igual a otra estructura del mismo tipo.
        /// <summary>
        /// Indica si la estructura actual es igual a otra estructura del mismo tipo.
        /// </summary>
        /// <param name="other">Estructura que se va a comparar con esta estructura.</param>
        /// <returns>
        /// Devuelve <strong>true</strong> si la estructura actual es igual al parámetro <c>other</c>; en caso contrario, <strong>false</strong>.
        /// </returns>
        public bool Equals(PARTITION_INFORMATION_EX other) => other.Equals((object)this);
        #endregion

        #endregion

        #region public operators

        #region [public] {static} (bool) operator ==(PARTITION_INFORMATION_EX, PARTITION_INFORMATION_EX): Implementa el operador de igualdad (==).
        /// <summary>
        /// Implementa el operador de igualdad (==).
        /// </summary>
        /// <param name="left">Operando 1.</param>
        /// <param name="rihgt">Operando 2.</param>
        /// <returns>
        /// Devuelve <strong>true</strong> si <c>operator1</c> es igual a <c>operator2</c>; <strong>false</strong> en caso contrario.
        /// </returns>
        public static bool operator ==(PARTITION_INFORMATION_EX left, PARTITION_INFORMATION_EX rihgt) => left.Equals(rihgt);
        #endregion

        #region [public] {static} (bool) operator !=(PARTITION_INFORMATION_EX, PARTITION_INFORMATION_EX): Implementa el operador de desigualdad (!=).
        /// <summary>
        /// Implementa el operador de desigualdad (!=).
        /// </summary>
        /// <param name="left">Operando 1.</param>
        /// <param name="rihgt">Operando 2.</param>
        /// <returns>
        /// Devuelve <strong>true</strong> si <c>operator1</c> no es igual a <c>operator2</c>; <strong>false</strong> en caso contrario.
        /// </returns>
        public static bool operator !=(PARTITION_INFORMATION_EX left, PARTITION_INFORMATION_EX rihgt) => !left.Equals(rihgt);
        #endregion

        #endregion

        #region public override methods

        #region [public] {override} (int) GetHashCode(): Devuelve un valor que repesenta al código hash de esta estructura.
        /// <summary>
        /// Devuelve un valor que repesenta al código hash de esta estructura.
        /// </summary>
        /// <returns>
        /// Código Hash de esta estructura.
        /// </returns>
        public override int GetHashCode() => ToString().GetHashCode();
        #endregion

        #region [public] {override} (bool) Equals(object): Devuelve un valor que indica si esta estructutra es igual a otra.
        /// <summary>
        /// Devuelve un valor que indica si esta estructutra es igual a otra.
        /// </summary>
        /// <param name="obj">Estructura con la que comparar.</param>
        /// <returns>
        /// Resultado de la comparación de igualdad.
        /// </returns>
        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }

            if (!(obj is PARTITION_INFORMATION_EX))
            {
                return false;
            }

            var other = (PARTITION_INFORMATION_EX)obj;

            return 
                other.Gpt == Gpt &&
                other.Mbr == Mbr &&
                other.PartitionLength == PartitionLength &&
                other.PartitionNumber == PartitionNumber &&
                other.PartitionStyle == PartitionStyle &&
                other.RewritePartition == RewritePartition &&
                other.StartingOffset == StartingOffset;
        }
        #endregion

        #region [public] {override} (string) ToString(): Devuelve una cadena que representa a la estructura actual.
        /// <summary>
        /// Devuelve una cadena que representa la estructura <see cref="PARTITION_INFORMATION_EX"/> actual.
        /// </summary>
        /// <returns>
        /// Cadena que representa la estructura <see cref="PARTITION_INFORMATION_EX"/> actual.
        /// </returns>
        /// <remarks>
        /// El método <see cref="PARTITION_INFORMATION_EX.ToString()"/> devuelve una cadena que incluye el número de partición y su tipo.
        /// </remarks>
        public override string ToString() => $"Number: {PartitionNumber}; Style {PartitionStyle}";
        #endregion

        #endregion
    }
}
