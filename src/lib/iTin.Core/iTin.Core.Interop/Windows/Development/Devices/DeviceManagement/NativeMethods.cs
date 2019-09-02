
namespace iTin.Core.Interop.Windows.Development.Devices.DeviceManagement
{
    using System;
    using System.Runtime.InteropServices;

    using Microsoft.Win32.SafeHandles;

    using iTin.Core.Interop.Windows.Hardware.DriverKit.Storage;

    using Storage.LocalFileSystems.DiskManagement;

    /// <summary>
    /// Functions for device management, provides a uniform way to report changes that occur with system devices.
    /// </summary>
    public static class NativeMethods
    {
        [DllImport(ExternDll.Win.Kernel32, CharSet = CharSet.Unicode, SetLastError = true, ExactSpelling = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool DeviceIoControl(  SafeFileHandle driveHandle
                                                  , DeviceControlCode ioControlCode
                                                  , IntPtr lpInBuffer
                                                  , uint inBufferSize
                                                  , IntPtr lpOutBuffer
                                                  , uint outBufferSize
                                                  , ref uint lpBytesReturned
                                                  , IntPtr lpOverlapped);

        [DllImport(ExternDll.Win.Kernel32, CharSet = CharSet.Unicode, SetLastError = true, ExactSpelling = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool DeviceIoControl(SafeFileHandle driveHandle
                                                  , IoctlDiskControlCode ioControlCode
                                                  , IntPtr lpInBuffer
                                                  , uint inBufferSize
                                                  , IntPtr lpOutBuffer
                                                  , uint outBufferSize
                                                  , ref uint lpBytesReturned
                                                  , IntPtr lpOverlapped);

        [DllImport(ExternDll.Win.Kernel32, CharSet = CharSet.Unicode, SetLastError = true, ExactSpelling = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool DeviceIoControl(SafeFileHandle driveHandle
                                                  , DiskIoControlCode ioControlCode
                                                  , IntPtr lpInBuffer
                                                  , uint inBufferSize
                                                  , IntPtr lpOutBuffer
                                                  , uint outBufferSize
                                                  , ref uint lpBytesReturned
                                                  , IntPtr lpOverlapped);

        [DllImport(ExternDll.Win.Kernel32, CharSet = CharSet.Unicode, SetLastError = true, ExactSpelling = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool DeviceIoControl(SafeFileHandle driveHandle
                                                  , IdeIoControlCode ioControlCode
                                                  , IntPtr lpInBuffer
                                                  , uint inBufferSize
                                                  , IntPtr lpOutBuffer
                                                  , uint outBufferSize
                                                  , ref uint lpBytesReturned
                                                  , IntPtr lpOverlapped);

        [DllImport(ExternDll.Win.Kernel32, CharSet = CharSet.Unicode, SetLastError = true, ExactSpelling = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool DeviceIoControl(  SafeFileHandle driveHandle
                                                  , DeviceControlCode ioControlCode
                                                  , IntPtr lpInBuffer
                                                  , uint inBufferSize
                                                  , SafeHandle lpOutBuffer
                                                  , uint outBufferSize
                                                  , ref uint lpBytesReturned
                                                  , IntPtr lpOverlapped);


        [DllImport(ExternDll.Win.Kernel32, CharSet = CharSet.Auto, ExactSpelling = true, SetLastError = true)]
        public static extern bool DeviceIoControl(  IntPtr hDevice
                                                  , uint dwIoControlCode
                                                  , IntPtr lpInBuffer
                                                  , uint nInBufferSize
                                                  , IntPtr lpOutBuffer
                                                  , uint nOutBufferSize
                                                  , out uint lpBytesReturned
                                                  , IntPtr lpOverlapped);
    }
}
