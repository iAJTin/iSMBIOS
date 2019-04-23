
namespace iTin.Core.Interop.Windows.DriverKit.DeviceAndDriverTechnologies.StorageDevices
{
    using System;
    using System.Runtime.InteropServices;
    using System.Text;

    /// <summary>
    /// Funciones para la gestión entre la asociación de dispositivos Plug and Play (PnP) y sus controladores.
    /// </summary>
    internal static class NativeMethods
    {
        #region Constantes
        /// <summary>
        /// Longitud máxima del nombre de una clase.
        /// </summary>
        public const uint MAX_CLASS_NAME_LEN = 32;
        /// <summary>
        /// Devolver sólo el dispositivo que está asociada con la interfaz de dispositivos del sistema por defecto, si se ha establecido, para las clases de interfaz de dispositivo especificado.
        /// </summary>
        public const int DIGCF_DEFAULT = 0x00000001;
        /// <summary>
        /// Devuleve sólo los dispositivos que están presentes en el sistema.
        /// </summary>
        public const int DIGCF_PRESENT = 0x00000002;
        /// <summary>
        /// Devuelve los dispositivos instalados para todas las clases de dispositivo ó todas las interfaz de dispositivo.
        /// </summary>
        public const int DIGCF_ALLCLASSES = 0x00000004;
        /// <summary>
        /// Devuelve sólo los dispositivos que forman parte del perfil de hardware actual.
        /// </summary>
        public const int DIGCF_PROFILE = 0x00000008;
        /// <summary>
        /// Dispositivos de retorno que soportan interfaces de dispositivo para las clases de interfaz de dispositivo especificado.
        /// Este indicador se debe establecer en el parámetro flags si el parámetro enumerador especifica un ID de instancia de dispositivo.
        /// </summary>
        public const int DIGCF_DEVICEINTERFACE = 0x00000010;

        /// <summary>
        /// DeviceDesc (R/W)
        /// </summary>
        public const uint SPDRP_DEVICEDESC = 0x00000000;

        /// <summary>
        /// 
        /// </summary>
        public const uint MAX_SIZE_DEVICE_DESCRIPTION = 1000;


        public const int DIOCR_INSTALLER = (0x00000001);
        // MaximumAllowed access type to Reg.
        public const int MAXIMUM_ALLOWED = (0x02000000);

        #endregion

        #region P/Invoke

            #region [public] {static extern} (bool) SetupDiClassNameFromGuid(ref Guid, StringBuilder, UInt32, ref UInt32): Recupera el identificador GUID de cada clase instalada en este sistema. Se ha de llamar repetidamente a la función hasta que se devuelva el valor CR_NO_SUCH_VALUE.
            /// <summary>
            /// Recupera el identificador GUID de cada clase instalada en este sistema. Se ha de llamar repetidamente a la función hasta que se devuelva el valor CR_NO_SUCH_VALUE.
            /// Para más información, ver http://msdn.microsoft.com/en-us/library/ff538021%28v=VS.85%29.aspx.
            /// </summary>
            [DllImport(ExternDll.SetupApi, SetLastError = true)]
            [return: MarshalAs(UnmanagedType.Bool)]
            public static extern bool SetupDiClassNameFromGuid(ref Guid classGuid, StringBuilder className, UInt32 classNameSize, ref UInt32 requiredSize);
            #endregion


            #region [public] {static extern} (IntPtr) SetupDiGetClassDevs(ref Guid, UInt32, IntPtr, UInt32): Devuelve un identificador para un conjunto de información de dispositivo que contiene los elementos solicitados la información del dispositivo para un equipo local.
            /// <summary>
            /// Devuelve un identificador para un conjunto de información de dispositivo que contiene los elementos solicitados la información del dispositivo para un equipo local.
            /// Para más información, ver http://msdn.microsoft.com/en-us/library/ff551069%28VS.85%29.aspx.
            /// </summary>
            [DllImport(ExternDll.SetupApi, SetLastError = true)]
            public static extern IntPtr SetupDiGetClassDevs(ref Guid classGuid
                                                            , UInt32 enumerator
                                                            , IntPtr hwndParent
                                                            , UInt32 flags);
            #endregion


            #region [public] {static extern} (bool) SetupDiEnumDeviceInfo(IntPtr, UInt32, SP_DEVINFO_DATA): Devuelve una estructura SP_DEVINFO_DATA que especifica un elemento de información del dispositivo en un conjunto de información del dispositivo.
            /// <summary>
            /// Devuelve una estructura <see cref="SP_DEVINFO_DATA"/> que especifica un elemento de información del dispositivo en un conjunto de información del dispositivo.
            /// Para más información, ver http://msdn.microsoft.com/en-us/library/ff551010%28v=VS.85%29.aspx.
            /// </summary>
            [DllImport(ExternDll.SetupApi, SetLastError = true)]
            [return: MarshalAs(UnmanagedType.Bool)]
            public static extern bool SetupDiEnumDeviceInfo(IntPtr deviceInfoSet, UInt32 memberIndex, SP_DEVINFO_DATA deviceInfoData);
            #endregion

            #region [public] {static extern} (bool) SetupDiDestroyDeviceInfoList(IntPtr): Elimina un conjunto de información del dispositivo y libera toda la memoria asociada.
            /// <summary>
            /// Elimina un conjunto de información del dispositivo y libera toda la memoria asociada.
            /// Para más información, ver http://msdn.microsoft.com/en-us/library/ff550996%28v=VS.85%29.aspx.
            /// </summary>
            [DllImport(ExternDll.SetupApi, SetLastError = true)]
            [return: MarshalAs(UnmanagedType.Bool)]
            public static extern bool SetupDiDestroyDeviceInfoList(IntPtr deviceInfoSet);
            #endregion

            #region [public] {static extern} (bool) SetupDiGetDeviceRegistryProperty(IntPtr): Elimina un conjunto de información del dispositivo y libera toda la memoria asociada.
            /// <summary>
            /// Elimina un conjunto de información del dispositivo y libera toda la memoria asociada.
            /// Para más información, ver http://msdn.microsoft.com/en-us/library/ff550996%28v=VS.85%29.aspx.
            /// </summary>
            [DllImport(ExternDll.SetupApi, SetLastError = true)]
            public static extern bool SetupDiGetDeviceRegistryProperty(IntPtr lpInfoSet
                                                                       , SP_DEVINFO_DATA deviceInfoData
                                                                       , UInt32 property
                                                                       , UInt32 propertyRegDataType
                                                                       , StringBuilder propertyBuffer
                                                                       , UInt32 propertyBufferSize
                                                                       , IntPtr requiredSize);
            #endregion

            #region [public] {static extern} (bool) SetupDiGetDeviceRegistryProperty(IntPtr): Elimina un conjunto de información del dispositivo y libera toda la memoria asociada.
            /// <summary>
            /// Elimina un conjunto de información del dispositivo y libera toda la memoria asociada.
            /// Para más información, ver http://msdn.microsoft.com/en-us/library/ff550996%28v=VS.85%29.aspx.
            /// </summary>
            [DllImport(ExternDll.SetupApi, SetLastError = true)]
            [return: MarshalAs(UnmanagedType.Bool)]
            public static extern bool SetupDiGetDeviceRegistryProperty(IntPtr lpInfoSet
                                                                       , SP_DEVINFO_DATA deviceInfoData
                                                                       , UInt32 property
                                                                       , UInt32 propertyRegDataType
                                                                       , StringBuilder propertyBuffer
                                                                       , UInt32 propertyBufferSize
                                                                       , ref UInt32 requiredSize);
            #endregion

            #region [public] {static extern} (IntPtr) SetupDiOpenClassRegKeyEx(ref Guid, UInt32, UInt32, IntPtr, IntPtr): Abre la configuración del dispositivo desde el registro, la interfaz de dispositivo o subclave una clase específica.
            /// <summary>
            /// Abre la configuración del dispositivo desde el registro, la interfaz de dispositivo o subclave una clase específica.
            /// Esta función abre la clave especificada en el equipo local o en un equipo remoto.
            /// Para más información, ver http://msdn.microsoft.com/en-us/library/ff552067%28VS.85%29.aspx.
            /// </summary>
            [DllImport(ExternDll.SetupApi, SetLastError = true)]
            [return: MarshalAs(UnmanagedType.Bool)]
            public static extern IntPtr SetupDiOpenClassRegKeyEx(ref Guid guid
                                                                 , UInt32 samDesired
                                                                 , UInt32 flags
                                                                 , IntPtr machineName
                                                                 , IntPtr reserved);
            #endregion

            #region [public] {static extern} (IntPtr) SetupDiOpenClassRegKeyEx(ref Guid, UInt32, UInt32, IntPtr, UInt32): Abre la configuración del dispositivo desde el registro, la interfaz de dispositivo o subclave una clase específica.
            /// <summary>
            /// Abre la configuración del dispositivo desde el registro, la interfaz de dispositivo o subclave una clase específica.
            /// Esta función abre la clave especificada en el equipo local o en un equipo remoto.
            /// Para más información, ver http://msdn.microsoft.com/en-us/library/ff552067%28VS.85%29.aspx.
            /// </summary>
            [DllImport(ExternDll.SetupApi, SetLastError = true)]
            public static extern IntPtr SetupDiOpenClassRegKeyEx(ref Guid guid
                                                                 , UInt32 samDesired
                                                                 , UInt32 flags
                                                                 , IntPtr machineName
                                                                 , UInt32 reserved);
            #endregion

            #region [public] {static extern} (IntPtr) SetupDiOpenClassRegKeyEx(ref Guid, UInt32, UInt32, StringBuilder, IntPtr): Abre la configuración del dispositivo desde el registro, la interfaz de dispositivo o subclave una clase específica.
            /// <summary>
            /// Abre la configuración del dispositivo desde el registro, la interfaz de dispositivo o subclave una clase específica.
            /// Esta función abre la clave especificada en el equipo local o en un equipo remoto.
            /// Para más información, ver http://msdn.microsoft.com/en-us/library/ff552067%28VS.85%29.aspx.
            /// </summary>
            [DllImport(ExternDll.SetupApi, SetLastError = true)]
            public static extern IntPtr SetupDiOpenClassRegKeyEx(ref Guid guid
                                                                 , UInt32 samDesired
                                                                 , UInt32 flags
                                                                 , StringBuilder machineName
                                                                 , IntPtr reserved);
            #endregion

            #region [public] {static extern} (IntPtr) SetupDiOpenClassRegKeyEx(ref Guid, UInt32, UInt32, StringBuilder, UInt32): Abre la configuración del dispositivo desde el registro, la interfaz de dispositivo o subclave una clase específica.
            /// <summary>
            /// Abre la configuración del dispositivo desde el registro, la interfaz de dispositivo o subclave una clase específica.
            /// Esta función abre la clave especificada en el equipo local o en un equipo remoto.
            /// Para más información, ver http://msdn.microsoft.com/en-us/library/ff552067%28VS.85%29.aspx.
            /// </summary>
            [DllImport(ExternDll.SetupApi, SetLastError = true)]
            public static extern IntPtr SetupDiOpenClassRegKeyEx(ref Guid guid
                                                                 , UInt32 samDesired
                                                                 , UInt32 flags
                                                                 , StringBuilder machineName
                                                                 , UInt32 reserved);
            #endregion

            #region [public] {static extern} (IntPtr) SetupDiOpenClassRegKeyEx(ref Guid, UInt32, UInt32, StringBuilder, UInt32): Abre la configuración del dispositivo desde el registro, la interfaz de dispositivo o subclave una clase específica.
            /// <summary>
            /// Abre la configuración del dispositivo desde el registro, la interfaz de dispositivo o subclave una clase específica.
            /// Esta función abre la clave especificada en el equipo local o en un equipo remoto.
            /// Para más información, ver http://msdn.microsoft.com/en-us/library/ff552067%28VS.85%29.aspx.
            /// </summary>
            /// <summary>
            /// Regs the query value.
            /// </summary>
            /// <param name="keyClass">The key class.</param>
            /// <param name="subKey">The sub key.</param>
            /// <param name="classDescription">The class description.</param>
            /// <param name="sizeB">The size B.</param>
            /// <returns></returns>
            [DllImport(ExternDll.Advapi32, SetLastError = true)]
            public static extern UInt32 RegQueryValue(IntPtr keyClass, IntPtr subKey, StringBuilder classDescription, ref UInt32 sizeB);
            #endregion

        #endregion

        #region Clases anidadas

            #region [public] {class} SP_DEVINFO_DATA: La estructura SP_DEVINFO_DATA define una instancia del dispositivo que sea miembro de un conjunto de información de dispositivos.
            /// <summary>
            /// La estructura <strong>SP_DEVINFO_DATA</strong> define una instancia del dispositivo que sea miembro de un conjunto de información de dispositivos.
            /// </summary>
            [StructLayout(LayoutKind.Sequential)]
            public class SP_DEVINFO_DATA
            {
                #region Propiedades
                /// <summary>
                /// 
                /// </summary>
                public int size;
                /// <summary>
                /// 
                /// </summary>
                public Guid classGuid;
                /// <summary>
                /// 
                /// </summary>
                public int devInst;
                /// <summary>
                /// 
                /// </summary>
                public ulong reserved;
                #endregion
            }
            #endregion

        #endregion
    }
}