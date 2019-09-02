
namespace iTin.Core.Interop.Windows.Development.Storage.LocalFileSystems.FileManagement
{
    using System;
    using System.IO;
    using System.Runtime.InteropServices;

    using Microsoft.Win32.SafeHandles;

    /// <summary>    
    /// Funciones para la gestión del sistema de archivos.
    /// Un archivo es la representación de un recurso (ya sea un dispositivo físico o un recurso ubicado en un dispositivo físico) que pueden ser manejados por el sistema de E/S.
    /// </summary>
    public static class NativeMethods
    {
        #region Enums
        [StructLayout(LayoutKind.Sequential)]
        public struct OVERLAPPED
        {
            public int Internal;
            public int InternalHigh;
            public int Offset;
            public int OffsetHigh;
            public int hEvent;
        }
        #endregion

        #region P/Invoke

        #region [public] {static} (extern IntPtr) CreateFile(string, uint, uint, IntPtr, uint, uint, IntPtr): La función CreateFile crea o abre un archivo.
        /// <summary>
        /// La función CreateFile crea o abre un archivo, secuencia de archivo, directorio, disco físico, volumen, búfer de consola, unidad de cinta,
        /// recursos de comunicaciones, correo o canalización con nombre. La función devuelve un identificador que permite acceder a un objeto.
        /// Para más información, ver http://msdn.microsoft.com/es-bo/library/aa363858%28v=VS.85%29.aspx.
        /// </summary>
        [DllImport(ExternDll.Win.Kernel32, CharSet = CharSet.Ansi, SetLastError = true)]
        public static extern IntPtr CreateFile(string fileName
                                                , uint desiredAccess
                                                , uint shareMode
                                                , IntPtr securityAttributes
                                                , uint creationDisposition
                                                , uint flagsAndAttributes
                                                , IntPtr templateFile);
        #endregion

        //#region [public] {static} (extern IntPtr) CreateFile(string, FileAccess, FileShare, IntPtr, FileMode, uint, IntPtr): La función CreateFile crea o abre un archivo.
        ///// <summary>
        ///// La función CreateFile crea o abre un archivo, secuencia de archivo, directorio, disco físico, volumen, búfer de consola, unidad de cinta,
        ///// recursos de comunicaciones, correo o canalización con nombre. La función devuelve un identificador que permite acceder a un objeto.
        ///// Para más información, ver http://msdn.microsoft.com/es-bo/library/aa363858%28v=VS.85%29.aspx.
        ///// </summary>
        //[DllImport(ExternDll.Kernel32, CharSet = CharSet.Ansi, SetLastError = true)]
        //public static extern IntPtr CreateFile(string fileName
        //                                       , [MarshalAs(UnmanagedType.U4)] FileAccess desiredAccess
        //                                       , [MarshalAs(UnmanagedType.U4)] FileShare shareMode
        //                                       , IntPtr securityAttributes
        //                                       , [MarshalAs(UnmanagedType.U4)] FileMode creationDisposition
        //                                       , [MarshalAs(UnmanagedType.U4)] uint flagsAndAttributes
        //                                       , IntPtr templateFile);

        //#endregion

        #region [public] {static} (extern IntPtr) CreateFile(string, FileAccess, FileShare, IntPtr, FileMode, uint, IntPtr): La función CreateFile crea o abre un archivo.
        /// <summary>
        /// La función CreateFile crea o abre un archivo, secuencia de archivo, directorio, disco físico, volumen, búfer de consola, unidad de cinta,
        /// recursos de comunicaciones, correo o canalización con nombre. La función devuelve un identificador que permite acceder a un objeto.
        /// Para más información, ver http://msdn.microsoft.com/es-bo/library/aa363858%28v=VS.85%29.aspx.
        /// </summary>
        [DllImport(ExternDll.Win.Kernel32, SetLastError = true, CharSet = CharSet.Unicode, EntryPoint = "CreateFileW", ExactSpelling = true)]
        public static extern SafeFileHandle CreateFile(string fileName,
                                                        [MarshalAs(UnmanagedType.U4)] FileAccess desiredAccess,
                                                        [MarshalAs(UnmanagedType.U4)] FileShare shareMode,
                                                        IntPtr securityAttributes,
                                                        [MarshalAs(UnmanagedType.U4)] FileMode creationDisposition,
                                                        [MarshalAs(UnmanagedType.U4)] FileOptions flagsAndAttributes,
                                                        IntPtr templateFile);
        #endregion

        #endregion
    }
}
