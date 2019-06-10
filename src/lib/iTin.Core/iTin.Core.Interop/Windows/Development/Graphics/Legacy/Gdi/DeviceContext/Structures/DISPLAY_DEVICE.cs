using System;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Runtime.InteropServices;

namespace iTin.Core.Interop.Windows.Development.Graphics.Legacy.Gdi.DeviceContext
{
    /// <summary>
    /// La estructura <strong>DISPLAY_DEVICE</strong> recibe la información del dispositivo de pantalla especificado por el
    /// parámetro <c>iDevNum</c> de la función <see cref="NativeMethods.EnumDisplayDevices"/>.
    /// </summary>
    /// <remarks>
    /// Para más información, ver http://msdn.microsoft.com/es-es/library/dd183569.aspx.
    /// </remarks>
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [SuppressMessage("Microsoft.Naming", "CA1707:IdentifiersShouldNotContainUnderscores")]
    [SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", MessageId = "DISPLAY")]
    [SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", MessageId = "DEVICE")]
    public struct DISPLAY_DEVICE : IEquatable<DISPLAY_DEVICE>
    {
        #region Constantes
        /// <summary>
        /// Indica que el campo DeviceId va a contener la clave del registro de este monitor.
        /// </summary>
        [SuppressMessage("Microsoft.Naming", "CA1707:IdentifiersShouldNotContainUnderscores")]
        [SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", MessageId = "EDD")]
        [SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", MessageId = "GET")]
        [SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", MessageId = "DEVICE")]
        [SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", MessageId = "INTERFACE")]
        [SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", MessageId = "NAME")]
        public const uint EDD_GET_DEVICE_INTERFACE_NAME = 0x01;
        #endregion

        #region Enums

            #region [public] (enum) KnownDisplayDeviceStates: Enumeración de atributos de estado de una estructura DISPLAY_DEVICE.
            /// <summary>
            /// Enumeración de atributos de estado de una estructura <see cref="DISPLAY_DEVICE"/>.
            /// </summary>
            /// <remarks>
            /// Para más información, ver sección <strong>StateFlags</strong> de http://msdn.microsoft.com/es-es/library/dd183569.aspx
            /// </remarks>
            [Flags]
            public enum KnownDisplayDeviceStates
            {
                /// <summary>
                /// Indica que el dispositivo muestra el escritorio.
                /// </summary>
                AttachedToDesktop = 0x00000001,

                /// <summary>
                /// 
                /// </summary>
                MultiDriver = 0x00000002,

                /// <summary>
                /// Indica que és el escritorio principal.
                /// Para un sistema con un adaptador de video, siempre se establece. 
                /// Para un sistema con varias tarjetas de vídeo, solo una puede tener este flag activo.
                /// </summary>
                PrimaryDevice = 0x00000004, 

                /// <summary>
                /// Representa un pseudo dispositivo para reflejar la aplicación de dibujo para la interacción remota o con otros fines.
                /// Un pseudo monitor invisible está asociado con este dispositivo. Por ejemplo, NetMeeting lo utiliza. 
                /// </summary>
                MirroringDriver = 0x00000008,

                /// <summary>
                /// El dispositivo es compatible con VGA.
                /// </summary>
                VgaCompatible = 0x00000010,

                /// <summary>
                /// El dispositivo es extraíble; no puede ser la pantalla principal.
                /// </summary>
                Removable = 0x00000020,

                /// <summary>
                /// 
                /// </summary>
                [SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", MessageId = "Un")]
                UnSafeModesOn = 0x00080000,

                /// <summary>
                /// 
                /// </summary>
                [SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", MessageId = "Ts")]
                TsCompatible = 0x00200000,

                /// <summary>
                /// 
                /// </summary>
                Disconnect = 0x02000000,

                /// <summary>
                /// 
                /// </summary>
                Remote = 0x04000000,

                /// <summary>
                /// El dispositivo tiene más modos de vídeo.
                /// </summary>
                ModesPruned = 0x08000000,
            }
            #endregion

        #endregion

        #region Atributos
        ///<summary>
        /// Especifica el tamaño, en bytes, de la estructura <strong>DISPLAY_DEVICE</strong>.
        /// Se debe inicializar antes de llamar a una función <strong>Api</strong>.
        ///</summary>
        [MarshalAs(UnmanagedType.U4)]
        [SuppressMessage("Microsoft.Design", "CA1051:DoNotDeclareVisibleInstanceFields")]
        public int cb;

        ///<summary>
        /// Una cadena que identifica el nombre de dispositivo. 
        /// Este es el dispositivo del adaptador o el dispositivo de monitor.
        ///</summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
        [SuppressMessage("Microsoft.Design", "CA1051:DoNotDeclareVisibleInstanceFields")]
        public string DeviceName;

        ///<summary>
        /// Una cadena que contiene el contexto de dispositivo.
        /// Esto es tanto una descripción del adaptador de vídeo o del monitor de pantalla.
        ///</summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 128)]
        [SuppressMessage("Microsoft.Design", "CA1051:DoNotDeclareVisibleInstanceFields")]
        public string DeviceString;

        ///<summary>
        /// Indicadores de estado.
        ///</summary>
        [MarshalAs(UnmanagedType.U4)]
        [SuppressMessage("Microsoft.Design", "CA1051:DoNotDeclareVisibleInstanceFields")]
        public KnownDisplayDeviceStates State;

        ///<summary>
        /// Identificador del dispositivo.
        ///</summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 128)]
        [SuppressMessage("Microsoft.Design", "CA1051:DoNotDeclareVisibleInstanceFields")]
        public string DeviceID;

        ///<summary>
        /// Una cadena que contiene la ruta del registro de windows a la información del dispositivo.
        ///</summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 128)]
        [SuppressMessage("Microsoft.Design", "CA1051:DoNotDeclareVisibleInstanceFields")]
        public string DeviceKey;
        #endregion

        #region Interfaces

            #region [public] (bool) Equals(DISPLAY_DEVICE): Indica si el objeto actual es igual a otro objeto del mismo tipo.
            /// <summary>
            /// Indica si el objeto actual es igual a otro objeto del mismo tipo.
            /// </summary>
            /// <param name="other">Objeto que se va a comparar con este objeto.</param>
            /// <returns>
            /// Devuelve <strong>true</strong> si el objeto actual es igual al parámetro <c>other</c>; en caso contrario, <strong>false</strong>.
            /// </returns>
            public bool Equals(DISPLAY_DEVICE other)
            {
                return other.Equals((object)this);
            }
            #endregion

        #endregion

        #region Overrides

            #region [public] {override} (int) GetHashCode(): Devuelve el código hash del objeto.
            /// <summary>
            /// Devuelve el código hash del objeto.
            /// </summary>
            /// <returns>
            /// 	<para>Tipo: <see cref="T:System.Int32"/></para>
            /// 	<para>Código Hash.</para>
            /// </returns>
            public override int GetHashCode()
            {
                return DeviceName.GetHashCode() ^ (int)State;
            }
            #endregion

            #region [public] {override} (bool) Equals(object obj): Devuelve un valor que indica si este objeto es igual a otro.
            /// <summary>
            /// Devuelve un valor que indica si este objeto es igual a otro.
            /// </summary>
            /// <param name="obj">Objeto con el que comparar.</param>
            /// <returns>Resultado de igualdad.</returns>
            public override bool Equals(object obj)
            {
                if (obj == null)
                    return false;

                if (!(obj is DISPLAY_DEVICE))
                    return false;

                DISPLAY_DEVICE other = (DISPLAY_DEVICE)obj;
                return (other.DeviceName == DeviceName) && (other.State == State);
            }
            #endregion

            #region [public] {override} (string) ToString(): Devuelve una cadena que representa al objeto actual.
            /// <summary>
            /// Devuelve una cadena que representa al objeto <see cref="DISPLAY_DEVICE"/> actual.
            /// </summary>
            /// <returns>
            /// 	<para>Tipo: <see cref="T:System.String"/></para>
            /// 	<para>Cadena que representa al objeto <see cref="DISPLAY_DEVICE"/> actual.</para>
            /// </returns>
            /// <remarks>
            /// El método <see cref="DISPLAY_DEVICE.ToString()"/> devuelve una cadena que incluye el tipo de estructura.
            /// </remarks>
            public override string ToString()
            {
                return string.Format(CultureInfo.InvariantCulture, "DeviceName = {0}", DeviceName);
            }
            #endregion

        #endregion

        #region Operadores

            #region [public] {static} (bool) operator ==(DISPLAY_DEVICE, DISPLAY_DEVICE): Implementa el operador de igualdad (==).
            /// <summary>
            /// Implementa el operador de igualdad (==).
            /// </summary>
            /// <param name="deviceInfo1">Operando 1.</param>
            /// <param name="deviceInfo2">Operando 2.</param>
            /// <returns>
            /// Devuelve <strong>true</strong> si <c>deviceInfo1</c> es igual a <c>deviceInfo2</c>; <strong>false</strong> en caso contrario.
            /// </returns>
            public static bool operator ==(DISPLAY_DEVICE deviceInfo1, DISPLAY_DEVICE deviceInfo2)
            {
                return deviceInfo1.Equals(deviceInfo2);
            }
            #endregion

            #region [public] {static} (bool) operator !=(DISPLAY_DEVICE, DISPLAY_DEVICE): Implementa el operador de desigualdad (!=).
            /// <summary>
            /// Implementa el operador de desigualdad (!=).
            /// </summary>
            /// <param name="deviceInfo1">Operando 1.</param>
            /// <param name="deviceInfo2">Operando 2.</param>
            /// <returns>
            /// Devuelve <strong>true</strong> si <c>deviceInfo1</c> no es igual a <c>deviceInfo2</c>; <strong>false</strong> en caso contrario.
            /// </returns>
            public static bool operator !=(DISPLAY_DEVICE deviceInfo1, DISPLAY_DEVICE deviceInfo2)
            {
                return !deviceInfo1.Equals(deviceInfo2);
            }
            #endregion

        #endregion

        #region Miembros estáticos
        /// <summary>
        /// Nueva estructura vacía.
        /// </summary>
        public static readonly DISPLAY_DEVICE Empty = new DISPLAY_DEVICE { cb = Marshal.SizeOf(typeof(DISPLAY_DEVICE)) };
        #endregion
    }
}