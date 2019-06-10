using System;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Runtime.InteropServices;

namespace iTin.Core.Interop.Windows.Development.Storage.LocalFileSystems.DiskManagement
{
    /// <summary>
    /// Proporciona información acerca de las particiones de la unidad master boot record (MBR).
    /// </summary>
    /// <remarks>
    /// Para más información ver: http://msdn.microsoft.com/en-us/library/aa365450%28v=VS.85%29.aspx
    /// </remarks>
    [StructLayout(LayoutKind.Sequential)]
    [SuppressMessage("Microsoft.Naming", "CA1707:IdentifiersShouldNotContainUnderscores")]
    [SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", MessageId = "MBR")]
    [SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", MessageId = "INFORMATION")]
    [SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", MessageId = "PARTITION")]
    struct PARTITION_INFORMATION_MBR : IEquatable<PARTITION_INFORMATION_MBR>
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

        #region Interfaces

            #region [public] (bool) Equals(PARTITION_INFORMATION_MBR): Indica si la estructura actual es igual a otra estructura del mismo tipo.
            /// <summary>
            /// Indica si la estructura actual es igual a otra estructura del mismo tipo.
            /// </summary>
            /// <param name="other">Estructura que se va a comparar con esta estructura.</param>
            /// <returns>
            /// Devuelve <strong>true</strong> si la estructura actual es igual al parámetro <c>other</c>; en caso contrario, <strong>false</strong>.
            /// </returns>
            public bool Equals(PARTITION_INFORMATION_MBR other)
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

                if (!(obj is PARTITION_INFORMATION_MBR))
                    return false;

                var other = (PARTITION_INFORMATION_MBR)obj;
                return (other.BootIndicator == BootIndicator) &&
                       (other.HiddenSectors == HiddenSectors) &&
                       (other.PartitionType == PartitionType) &&
                       (other.RecognizedPartition == RecognizedPartition);
            }
            #endregion

            #region [public] {override} (string) ToString(): Devuelve una cadena que representa a la estructura actual.
            /// <summary>
            /// Devuelve una cadena que representa la estructura <see cref="PARTITION_INFORMATION_MBR"/> actual.
            /// </summary>
            /// <returns>
            /// 	<para>Tipo: <see cref="T:System.String"/></para>
            /// 	<para>Cadena que representa la estructura <see cref="PARTITION_INFORMATION_MBR"/> actual.</para>
            /// </returns>
            /// <remarks>
            /// El método <see cref="PARTITION_INFORMATION_MBR.ToString()"/> devuelve una cadena que incluye el tipo de la partición.
            /// </remarks>
            public override string ToString()
            {
                return string.Format(CultureInfo.InvariantCulture, "Type = {0}", PartitionType);
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
            public static bool operator ==(PARTITION_INFORMATION_MBR operator1, PARTITION_INFORMATION_MBR operator2)
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
            public static bool operator !=(PARTITION_INFORMATION_MBR operator1, PARTITION_INFORMATION_MBR operator2)
            {
                return !operator1.Equals(operator2);
            }
            #endregion

        #endregion

        // helper method - is the hi bit valid - if so IsNTFT has meaning.
        public bool IsValidNTFT()
        {
            return (PartitionType == (PARTITION_TYPE)0xc0);//.NTFT);// == 0xc0;
        }

        // is this NTFT - i.e. an NTFT raid or mirror.
        public bool IsNTFT()
        {
            return (PartitionType == PARTITION_TYPE.NTFT);// & 0x80) == 0x80;
        }

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

