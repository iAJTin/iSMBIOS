
namespace iTin.Core.Interop.Windows.Development.DeviceAndDriverInstallation.SetupApi
{
    using System;
    using System.Runtime.InteropServices;

    /// <summary>
    /// Defines a device instance that is a member of a device information set.
    /// </summary>
    /// <remarks>
    /// For more information, please see https://docs.microsoft.com/es-es/windows/win32/api/setupapi/ns-setupapi-sp_devinfo_data
    /// </remarks>
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct SP_DEVINFO_DATA : IEquatable<SP_DEVINFO_DATA>
    {
        #region interface/s

        #region [public] (bool) Equals(SP_DEVINFO_DATA): Indica si el objeto actual es igual a otro objeto del mismo tipo.
        /// <summary>
        /// Indica si el objeto actual es igual a otro objeto del mismo tipo.
        /// </summary>
        /// <param name="other">Objeto que se va a comparar con este objeto.</param>
        /// <returns>
        /// Devuelve <strong>true</strong> si el objeto actual es igual al parámetro <c>other</c>; en caso contrario, <strong>false</strong>.
        /// </returns>
        public bool Equals(SP_DEVINFO_DATA other)
        {
            return other.Equals((object)this);
        }
        #endregion

        #endregion

        #region public static properties
        /// <summary>
        /// Nueva estructura vacía.
        /// </summary>
        public static readonly SP_DEVINFO_DATA Empty = new SP_DEVINFO_DATA { cbSize = (UInt32)Marshal.SizeOf(typeof(SP_DEVINFO_DATA)) };
        #endregion

        #region public members
        ///<summary>
        /// The size, in bytes, of the <see cref="SP_DEVINFO_DATA"/> structure.
        ///</summary>
        public UInt32 cbSize;

        ///<summary>
        /// The GUID of the device's setup class.
        ///</summary>
        public Guid classGuid;

        ///<summary>
        /// An opaque handle to the device instance.
        ///</summary>
        public UInt32 devInst;

        ///<summary>
        /// An opaque handle to the device instance.
        ///</summary>
        public IntPtr reserved;
        #endregion

        #region public operators

        #region [public] {static} (bool) operator ==(SP_DEVINFO_DATA, SP_DEVINFO_DATA): Implementa el operador de igualdad (==).
        /// <summary>
        /// Implementa el operador de igualdad (==).
        /// </summary>
        /// <param name="left">Operando 1.</param>
        /// <param name="right">Operando 2.</param>
        /// <returns>
        /// Devuelve <strong>true</strong> si <c>deviceInfo1</c> es igual a <c>deviceInfo2</c>; <strong>false</strong> en caso contrario.
        /// </returns>
        public static bool operator ==(SP_DEVINFO_DATA left, SP_DEVINFO_DATA right) => left.Equals(right);
        #endregion

        #region [public] {static} (bool) operator !=(SP_DEVINFO_DATA, SP_DEVINFO_DATA): Implementa el operador de desigualdad (!=).
        /// <summary>
        /// Implementa el operador de desigualdad (!=).
        /// </summary>
        /// <param name="left">Operando 1.</param>
        /// <param name="right">Operando 2.</param>
        /// <returns>
        /// Devuelve <strong>true</strong> si <c>deviceInfo1</c> no es igual a <c>deviceInfo2</c>; <strong>false</strong> en caso contrario.
        /// </returns>
        public static bool operator !=(SP_DEVINFO_DATA left, SP_DEVINFO_DATA right) => left.Equals(right);
        #endregion

        #endregion

        #region public override methods

        #region [public] {override} (int) GetHashCode(): Devuelve el código hash del objeto
        /// <summary>
        /// Devuelve el código hash del objeto.
        /// </summary>
        /// <returns>
        /// Código Hash.
        /// </returns>
        public override int GetHashCode() => cbSize.GetHashCode() ^ classGuid.GetHashCode() ^ devInst.GetHashCode() ^ reserved.GetHashCode();        
        #endregion

        #region [public] {override} (bool) Equals(object obj): Devuelve un valor que indica si este objeto es igual a otro
        /// <summary>
        /// Devuelve un valor que indica si este objeto es igual a otro.
        /// </summary>
        /// <param name="obj">Objeto con el que comparar.</param>
        /// <returns>
        /// Resultado de igualdad.
        /// </returns>
        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }

            if (!(obj is SP_DEVINFO_DATA))
            {
                return false;
            }

            SP_DEVINFO_DATA other = (SP_DEVINFO_DATA)obj;
            return
                other.cbSize == cbSize &&
                other.devInst == devInst &&
                other.classGuid == classGuid &&
                other.reserved == reserved;
        }
        #endregion

        #region [public] {override} (string) ToString(): Devuelve una cadena que representa al objeto actual
        /// <summary>
        /// Devuelve una cadena que representa al objeto <see cref="SP_DEVINFO_DATA"/> actual.
        /// </summary>
        /// <returns>
        /// Cadena que representa al objeto <see cref="SP_DEVINFO_DATA"/> actual.
        /// </returns>
        /// <remarks>
        /// El método <see cref="SP_DEVINFO_DATA.ToString()"/> devuelve una cadena que incluye el tipo de estructura.
        /// </remarks>
        public override string ToString() => $"ClassGuid = {classGuid}";        
        #endregion

        #endregion
    }
}
