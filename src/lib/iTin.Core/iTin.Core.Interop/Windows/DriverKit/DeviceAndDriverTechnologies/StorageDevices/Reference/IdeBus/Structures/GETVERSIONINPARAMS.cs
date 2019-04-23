using System;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Runtime.InteropServices;

using iTin.Core.Helpers;
using iTin.Core.Helpers.Enumerations;

using UCHAR = System.Byte;
using ULONG = System.UInt32;

namespace iTin.Core.Interop.Windows.DriverKit.DeviceAndDriverTechnologies.StorageDevices.Reference.IdeBus
{
    /// <summary>
    /// La estructura <strong>GETVERSIONINPARAMS</strong> se utiliza junto con la solicitud SMART_GET_VERSION para recuperar información de la versión,
    /// una máscara de capacidades, y una máscara de bits para el dispositivo indicado.
    /// </summary>
    /// <remarks>
    /// Para más información, ver http://msdn.microsoft.com/en-us/library/ff554977%28v=VS.85%29.aspx
    /// </remarks>
    [StructLayout(LayoutKind.Sequential)]
    [SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", MessageId = "GETVERSIONINPARAMS")]
    struct GETVERSIONINPARAMS : IEquatable<GETVERSIONINPARAMS>
    {
        #region Enums

            #region [public] (enum) Capabilities: Contains the bitmask of driver capabilities.
            /// <summary>
            /// Contains the bitmask of driver capabilities.
            /// </summary>
            [Flags]
            public enum Capabilities : uint
            {
                /// <summary>
                /// ATA ID command supported
                /// </summary>
                CAP_ATA_ID_CMD = 1,
                /// <summary>
                /// ATAPI ID command supported
                /// </summary>
                CAP_ATAPI_ID_CMD = 2,
                /// <summary>
                /// SMART commannds supported
                /// </summary>
                CAP_SMART_CMD = 4,
            }
            #endregion

            #region [public] (enum) IdeDeviceLocation: Contains the bitmask of driver capabilities.
            /// <summary>
            /// Contains the bitmask of driver capabilities.
            /// </summary>
            [Flags]
            public enum IdeDeviceLocation
            {
                Unknown = -1,
                IdeMasterPrimaryChannel,
                IdeSlavePrimaryChannel,
                IdeMasterSecondaryChannel,
                IdeSlaveSecondaryChannel,
                AtapiMasterPrimaryChannel,
                AtapiSlavePrimaryChannel,
                AtapiMasterSecondaryChannel,
                AtapiSlaveSecondaryChannel,
            }
            #endregion

        #endregion

        #region Atributos
        /// <summary>
        /// Número de versión del controlador binario.
        /// </summary>
        public UCHAR Version;

        /// <summary>
        /// Número de revisión del controlador binario.
        /// </summary>
        public UCHAR Revision;

        /// <summary>
        /// Reservado.
        /// </summary>
        public UCHAR Reserved;

        /// <summary>
        /// Mapeado de dispositivos.
        /// </summary>
        public UCHAR IdeDeviceMap;

        /// <summary>
        /// Máscara de bits con las capacidades del driver.
        /// </summary>
        [CLSCompliantAttribute(false)]
        public Capabilities fCapabilities;

        /// <summary>
        /// Reservado.
        /// </summary>
        [CLSCompliantAttribute(false)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
        public ULONG[] wReserved;
        #endregion

        #region Propiedades

            #region [public] (bool) IsIdeMasterPrimaryChannel: 
            /// <summary>
            /// Obtiene un valor que representa el tamaño del disco, se mide en bytes.
            /// </summary>
            /// <value>
            ///   <para>Tipo: <see cref="T:System.Int64"/></para>
            ///   <para>Tamaño del disco en bytes.</para>
            /// </value>
            public IdeDeviceLocation DeviceLocation
            {
                get
                {
                    var location = IdeDeviceLocation.Unknown;
                    for (int i = 0; i <= 7; i++)
                    {
                        var found = LogicHelper.CheckBit(IdeDeviceMap, (Bits)i);
                        if (found)
                        {
                            location = (IdeDeviceLocation) i;
                            break;
                        }
                    }
                    return location;
                }
            }
            #endregion

        #endregion        

        #region Interfaces

            #region [public] (bool) Equals(GETVERSIONINPARAMS): Indica si la estructura actual es igual a otra estructura del mismo tipo.
            /// <summary>
            /// Indica si la estructura actual es igual a otra estructura del mismo tipo.
            /// </summary>
            /// <param name="other">Estructura que se va a comparar con esta estructura.</param>
            /// <returns>
            /// Devuelve <strong>true</strong> si la estructura actual es igual al parámetro <c>other</c>; en caso contrario, <strong>false</strong>.
            /// </returns>
            public bool Equals(GETVERSIONINPARAMS other)
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

                if (!(obj is GETVERSIONINPARAMS))
                    return false;

                var other = (GETVERSIONINPARAMS)obj;
                return (other.Version == Version) &&
                       (other.Revision == Revision) &&
                       (other.fCapabilities == fCapabilities) &&
                       (other.IdeDeviceMap == IdeDeviceMap);
            }
            #endregion

            #region [public] {override} (string) ToString(): Devuelve una cadena que representa a la estructura actual.
            /// <summary>
            /// Devuelve una cadena que representa la estructura <see cref="GETVERSIONINPARAMS"/> actual.
            /// </summary>
            /// <returns>
            /// 	<para>Tipo: <see cref="T:System.String"/></para>
            /// 	<para>Cadena que representa la estructura <see cref="GETVERSIONINPARAMS"/> actual.</para>
            /// </returns>
            /// <remarks>
            /// El método <see cref="GETVERSIONINPARAMS.ToString()"/> devuelve una cadena que incluye la versión y revisión.
            /// </remarks>
            public override string ToString()
            {
                return string.Format(CultureInfo.InvariantCulture, "Version = {0}; Revision = {1}; Location = {2}", Version, Revision, DeviceLocation);
            }
            #endregion

        #endregion

        #region Operadores

            #region [public] {static} (bool) operator ==(GETVERSIONINPARAMS, GETVERSIONINPARAMS): Implementa el operador de igualdad (==).
            /// <summary>
            /// Implementa el operador de igualdad (==).
            /// </summary>
            /// <param name="operator1">Operando 1.</param>
            /// <param name="operator2">Operando 2.</param>
            /// <returns>
            /// Devuelve <strong>true</strong> si <c>operator1</c> es igual a <c>operator2</c>; <strong>false</strong> en caso contrario.
            /// </returns>
            public static bool operator ==(GETVERSIONINPARAMS operator1, GETVERSIONINPARAMS operator2)
            {
                return operator1.Equals(operator2);
            }
            #endregion

            #region [public] {static} (bool) operator !=(GETVERSIONINPARAMS, GETVERSIONINPARAMS): Implementa el operador de desigualdad (!=).
            /// <summary>
            /// Implementa el operador de desigualdad (!=).
            /// </summary>
            /// <param name="operator1">Operando 1.</param>
            /// <param name="operator2">Operando 2.</param>
            /// <returns>
            /// Devuelve <strong>true</strong> si <c>operator1</c> no es igual a <c>operator2</c>; <strong>false</strong> en caso contrario.
            /// </returns>
            public static bool operator !=(GETVERSIONINPARAMS operator1, GETVERSIONINPARAMS operator2)
            {
                return !operator1.Equals(operator2);
            }
            #endregion

        #endregion

        #region Miembros estáticos
        /// <summary>
        /// 
        /// </summary>
        public static readonly GETVERSIONINPARAMS Empty;
        #endregion
    }
}