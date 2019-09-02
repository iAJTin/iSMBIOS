
namespace iTin.Core.Interop.Windows.Development.Storage.LocalFileSystems.DiskManagement
{
    using System;
    using System.Runtime.InteropServices;

    /// <summary>
    /// Contains information about a drive's GUID partition table (GPT) partitions.
    /// </summary>
    /// <remarks>
    /// For more information, please see https://docs.microsoft.com/en-us/windows/win32/api/winioctl/ns-winioctl-drive_layout_information_gpt.
    /// </remarks>
    [StructLayout(LayoutKind.Sequential)]
    public struct DRIVE_LAYOUT_INFORMATION_GPT : IEquatable<DRIVE_LAYOUT_INFORMATION_GPT>
    {
        #region public members
        /// <summary>
        /// Disk <see cref="Guid"/>
        /// </summary>
        public Guid DiskId;

        /// <summary>
        /// Offset of the initial byte of the first usable block.
        /// </summary>
        public Int64 StartingUsableOffset;

        /// <summary>
        /// Size of the usable blocks on the disk, in bytes.
        /// </summary>
        public Int64 UsableLength;

        /// <summary>
        /// Maximum number of partitions that can be defined in the usable block.
        /// </summary>
        public Int32 MaxPartitionCount;
        #endregion

        #region interfaces

        #region [public] (bool) Equals(DRIVE_LAYOUT_INFORMATION_GPT): Indica si la estructura actual es igual a otra estructura del mismo tipo.
        /// <summary>
        /// Indica si la estructura actual es igual a otra estructura del mismo tipo.
        /// </summary>
        /// <param name="other">Estructura que se va a comparar con esta estructura.</param>
        /// <returns>
        /// Devuelve <strong>true</strong> si la estructura actual es igual al parámetro <c>other</c>; en caso contrario, <strong>false</strong>.
        /// </returns>
        public bool Equals(DRIVE_LAYOUT_INFORMATION_GPT other) => other.Equals((object)this);
        #endregion

        #endregion

        #region public operators

        #region [public] {static} (bool) operator ==(DRIVE_LAYOUT_INFORMATION_GPT, DRIVE_LAYOUT_INFORMATION_GPT): Implementa el operador de igualdad (==).
        /// <summary>
        /// Implementa el operador de igualdad (==).
        /// </summary>
        /// <param name="left">Operando 1.</param>
        /// <param name="right">Operando 2.</param>
        /// <returns>
        /// Devuelve <strong>true</strong> si <c>operator1</c> es igual a <c>operator2</c>; <strong>false</strong> en caso contrario.
        /// </returns>
        public static bool operator ==(DRIVE_LAYOUT_INFORMATION_GPT left, DRIVE_LAYOUT_INFORMATION_GPT right) => left.Equals(right);

        #endregion

        #region [public] {static} (bool) operator !=(DRIVE_LAYOUT_INFORMATION_GPT, DRIVE_LAYOUT_INFORMATION_GPT): Implementa el operador de desigualdad (!=).
        /// <summary>
        /// Implementa el operador de desigualdad (!=).
        /// </summary>
        /// <param name="left">Operando 1.</param>
        /// <param name="right">Operando 2.</param>
        /// <returns>
        /// Devuelve <strong>true</strong> si <c>operator1</c> no es igual a <c>operator2</c>; <strong>false</strong> en caso contrario.
        /// </returns>
        public static bool operator !=(DRIVE_LAYOUT_INFORMATION_GPT left, DRIVE_LAYOUT_INFORMATION_GPT right) => !left.Equals(right);

        #endregion

        #endregion

        #region public override methods

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
        /// Cadena que representa la estructura <see cref="DRIVE_LAYOUT_INFORMATION_GPT"/> actual.
        /// </returns>
        public override string ToString() => $"Count {MaxPartitionCount}";
        #endregion

        #endregion

    }
}
