
namespace iTin.Core.Interop.Windows.Development.Storage.LocalFileSystems.DiskManagement
{
    using System;
    using System.Runtime.InteropServices;

    /// <summary>
    /// Contains partition information specific to master boot record (MBR) disks.
    /// </summary>
    /// <remarks>
    /// For more information, please see https://docs.microsoft.com/en-us/windows/win32/api/winioctl/ns-winioctl-partition_information_mbr.
    /// </remarks>
    [StructLayout(LayoutKind.Sequential)]
    public struct PARTITION_INFORMATION_MBR : IEquatable<PARTITION_INFORMATION_MBR>
    {
        #region Atributos
        /// <summary>
        /// Uno de los valores de la enumeración <see cref="PARTITION_TYPE"/> que representa el tipo de partición de este disco.
        /// </summary>
        public PARTITION_TYPE PartitionType;

        /// <summary>
        /// <strong>true</strong> si es una partición de arranque.
        /// </summary>
        /// <remarks>
        /// Cuando esta estructura se utiliza con el código de control IOCTL_DISK_SET_PARTITION_INFO_EX, el valor de este parámetro se omite.
        /// </remarks>
        [MarshalAs(UnmanagedType.U1)]
        public Boolean BootIndicator;

        /// <summary>
        /// <strong>true</strong> si la partición es de un tipo reconocido.
        /// </summary>
        /// <remarks>
        /// Cuando esta estructura se utiliza con el código de control IOCTL_DISK_SET_PARTITION_INFO_EX, el valor de este parámetro se omite.
        /// </remarks>
        [MarshalAs(UnmanagedType.U1)]
        public Boolean RecognizedPartition;

        /// <summary>
        /// Número de sectores ocultos que se asignan al crear la tabla de particiones.
        /// </summary>
        public UInt32 HiddenSectors;
        #endregion

        #region interfaces

        #region [public] (bool) Equals(PARTITION_INFORMATION_MBR): Indica si la estructura actual es igual a otra estructura del mismo tipo.
        /// <summary>
        /// Indica si la estructura actual es igual a otra estructura del mismo tipo.
        /// </summary>
        /// <param name="other">Estructura que se va a comparar con esta estructura.</param>
        /// <returns>
        /// Devuelve <strong>true</strong> si la estructura actual es igual al parámetro <c>other</c>; en caso contrario, <strong>false</strong>.
        /// </returns>
        public bool Equals(PARTITION_INFORMATION_MBR other) => other.Equals((object)this);
        #endregion

        #endregion

        #region public operators

        #region [public] {static} (bool) operator ==(PARTITION_INFORMATION_GPT, PARTITION_INFORMATION_GPT): Implementa el operador de igualdad (==).
        /// <summary>
        /// Implementa el operador de igualdad (==).
        /// </summary>
        /// <param name="operator1">Operando 1.</param>
        /// <param name="operator2">Operando 2.</param>
        /// <returns>
        /// Devuelve <strong>true</strong> si <c>operator1</c> es igual a <c>operator2</c>; <strong>false</strong> en caso contrario.
        /// </returns>
        public static bool operator ==(PARTITION_INFORMATION_MBR operator1, PARTITION_INFORMATION_MBR operator2) => operator1.Equals(operator2);
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
        public static bool operator !=(PARTITION_INFORMATION_MBR operator1, PARTITION_INFORMATION_MBR operator2) => !operator1.Equals(operator2);
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

            if (!(obj is PARTITION_INFORMATION_MBR))
            {
                return false;
            }

            var other = (PARTITION_INFORMATION_MBR)obj;

            return
                other.BootIndicator == BootIndicator &&
                other.HiddenSectors == HiddenSectors &&
                other.PartitionType == PartitionType &&
                other.RecognizedPartition == RecognizedPartition;
        }
        #endregion

        #region [public] {override} (string) ToString(): Devuelve una cadena que representa a la estructura actual.
        /// <summary>
        /// Devuelve una cadena que representa la estructura <see cref="PARTITION_INFORMATION_MBR"/> actual.
        /// </summary>
        /// <returns>
        /// Cadena que representa la estructura <see cref="PARTITION_INFORMATION_MBR"/> actual.
        /// </returns>
        /// <remarks>
        /// El método <see cref="PARTITION_INFORMATION_MBR.ToString()"/> devuelve una cadena que incluye el tipo de la partición.
        /// </remarks>
        public override string ToString() => $"Type = {PartitionType}";
        #endregion

        #endregion

        // helper method - is the hi bit valid - if so IsNTFT has meaning.
        public bool IsValidNTFT() => PartitionType == (PARTITION_TYPE)0xc0;

        // is this NTFT - i.e. an NTFT raid or mirror.
        public bool IsNTFT() => PartitionType == PARTITION_TYPE.NTFT;

        // the actual partition type.
        /// <summary>
        /// Gets the partition.
        /// </summary>
        /// <returns></returns>
        public PARTITION_TYPE GetPartition
        {
            get
            {
                const byte mask = 0x3F;
                return (PARTITION_TYPE) ((int) PartitionType & mask);
            }
        }
    }
}

