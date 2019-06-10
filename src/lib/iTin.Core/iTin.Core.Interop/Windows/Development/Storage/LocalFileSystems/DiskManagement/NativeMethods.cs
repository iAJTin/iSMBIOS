using System.Runtime.InteropServices;

namespace iTin.Core.Interop.Windows.Development.Storage.LocalFileSystems.DiskManagement
{
    /// <summary>    
    /// Funciones para la gestión del espacio de un disco duro.
    /// Un disco duro es un disco rígido que almacena y proporciona acceso relativamente rápido a grandes cantidades de datos.
    /// Es el tipo de almacenamiento más utilizados en Windows.
    /// </summary>
    internal static class NativeMethods
    {
        #region P/Invoke

            #region [public] {static} {extern} (bool) GetDiskFreeSpace(string, out uint, out uint, out uint, out uint): Recupera información sobre el disco especificado, incluyendo la cantidad de espacio libre en el disco.
            /// <summary>
            /// Recupera información sobre el disco especificado, incluyendo la cantidad de espacio libre en el disco.
            /// Para más información, ver http://msdn.microsoft.com/en-us/library/aa364935%28v=VS.85%29.aspx.
            /// </summary>
            [DllImport(ExternDll.Kernel32, CharSet = CharSet.Auto, SetLastError = true)]
            [return: MarshalAs(UnmanagedType.Bool)]
            public static extern bool GetDiskFreeSpace(string lpRootPathName
                                                       , out uint lpSectorsPerCluster
                                                       , out uint lpBytesPerSector
                                                       , out uint lpNumberOfFreeClusters
                                                       , out uint lpTotalNumberOfClusters); 
            #endregion

            #region [public] {static} {extern} (bool) GetDiskFreeSpaceEx(string, out ulong, out ulong, out ulong): Recupera información sobre la cantidad de espacio que está disponible en un volumen de disco, la cantidad total de espacio, la cantidad total de espacio libre, y la cantidad total de espacio libre disponible para el usuario que está asociado con el subproceso de llamada.
            /// <summary>
            /// Recupera información sobre la cantidad de espacio que está disponible en un volumen de disco, la cantidad total de espacio, la cantidad total de espacio libre, y la cantidad total de espacio libre disponible para el usuario que está asociado con el subproceso de llamada.
            /// Para más información, ver http://msdn.microsoft.com/en-us/library/aa364937%28v=VS.85%29.aspx.
            /// </summary>
            [DllImport(ExternDll.Kernel32, CharSet = CharSet.Auto, SetLastError = true)]
            [return: MarshalAs(UnmanagedType.Bool)]
            public static extern bool GetDiskFreeSpaceEx(  string lpDirectoryName
                                                         , out ulong lpFreeBytesAvailable
                                                         , out ulong lpTotalNumberOfBytes
                                                         , out ulong lpTotalNumberOfFreeBytes);
            #endregion

        #endregion
    }
}