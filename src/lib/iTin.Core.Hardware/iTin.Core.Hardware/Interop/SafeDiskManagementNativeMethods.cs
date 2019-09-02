
namespace iTin.Core.Hardware.Interop
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.IO;
    using System.Runtime.InteropServices;
    using System.Text;

    using iTin.Core.Interop.Windows;
    using iTin.Core.Interop.Windows.Development.Storage.LocalFileSystems.DiskManagement;
    using iTin.Core.Interop.Windows.Hardware.DriverKit.Storage;
    using iTin.Core.Interop.Windows.Hardware.DriverKit.Storage.Ata;
    using iTin.Core.Interop.Windows.Hardware.DriverKit.Storage.Ide;

    using Microsoft.Win32.SafeHandles;

    using DeviceManagement = Core.Interop.Windows.Development.Devices.DeviceManagement;
    using FileManagement = Core.Interop.Windows.Development.Storage.LocalFileSystems.FileManagement;
    using VolumeManagement = Core.Interop.Windows.Development.Storage.LocalFileSystems.VolumeManagement;

    /// <summary>
    /// Defines a set of Safe monitor native methods.
    /// </summary>
    public static class SafeDiskManagementNativeMethods
    {
        #region public static methods

        #region [public] {static} (DISK_GEOMETRY) GetDiskGeometry(string): Retrieves information about the geometry of the physical disk: type, number of cylinders, tracks per cylinder, sectors per track and bytes per sector
        /// <summary>
        /// Retrieves information about the geometry of the physical disk: type, number of cylinders, tracks per cylinder, sectors per track and bytes per sector.
        /// </summary>
        /// <param name="phisycalDrive">Physical unit to check.</param>
        /// <returns>
        /// Structure <see cref="DISK_GEOMETRY"/> with the physical geometry information of the specified unit.
        /// </returns>
        public static DISK_GEOMETRY GetDiskGeometry(string phisycalDrive)
        {
            using (var hDevice = FileManagement.NativeMethods.CreateFile(phisycalDrive, 0, FileShare.ReadWrite, IntPtr.Zero, FileMode.Open, FileOptions.None, IntPtr.Zero))
            {
                if (hDevice.IsInvalid)
                {
                    return DISK_GEOMETRY.Empty;
                }

                // Reservar memoria para la estructura.
                var diskGeometryStructurePointer = Marshal.AllocHGlobal(Marshal.SizeOf(typeof(DISK_GEOMETRY)));

                // Obtener información.
                uint bytesReturned = 0;
                var ok = DeviceManagement.NativeMethods.DeviceIoControl(
                    hDevice,
                    DeviceControlCode.IOCTL_DISK_GET_DRIVE_GEOMETRY, IntPtr.Zero, 0,
                    diskGeometryStructurePointer, (uint) Marshal.SizeOf(typeof(DISK_GEOMETRY)), ref bytesReturned,
                    IntPtr.Zero);

                if (!ok)
                {
                    return DISK_GEOMETRY.Empty;
                }

                // Asignar valor a la estructura.                                  
                var diskGeometryStrucutreValue = (DISK_GEOMETRY)Marshal.PtrToStructure(diskGeometryStructurePointer, typeof(DISK_GEOMETRY));

                return diskGeometryStrucutreValue;
            }
        }
        #endregion

        #region [public] {static} (IEnumerable<PARTITION_INFORMATION_EX>) GetDiskPartitions(string): Retrieve the information for each entry in the partition tables of a disk
        /// <summary>
        /// Retrieve the information for each entry in the partition tables of a disk.
        /// </summary>
        /// <param name="phisycalDrive">Physical unit to check.</param>
        /// <returns>
        /// Array of structures <see cref="PARTITION_INFORMATION_EX"/> with the partition information of the specified drive.
        /// </returns>
        public static PARTITION_INFORMATION_EX[] GetDiskPartitions(string phisycalDrive)
        {
            var partitions = new List<PARTITION_INFORMATION_EX>();

            using (var hDevice = FileManagement.NativeMethods.CreateFile(phisycalDrive, 0x00, FileShare.ReadWrite, IntPtr.Zero, FileMode.Open, FileOptions.None, IntPtr.Zero))
            {
                if (hDevice.IsInvalid)
                {
                    throw new Win32Exception("Must run as administrator, otherwise we get ACCESS DENIED");
                }

                var done = false;
                var numPartitions = 1;
                while (!done)
                {
                    // Creación dinámica del buffer de salida. (Array de estructuras PARTITION_INFORMATION_EX).
                    // Tamaño de la estructura DRIVE_LAYOUT_INFORMATION_EX (0x30), en el byte 0x31 comienza el Array de estructuras PARTITION_INFORMATION_EX(0x90).
                    // Por tanto vamos aumentando el buffer de salida (que contiene el array de estructuras PARTITION_INFORMATION_EX) en uno hasta que la función DeviceIoControl 
                    // devuelva como resultado true(indica que ha recuperado correctamente el array de estructuras).
                    var outBufferSize = 0x30 + (numPartitions * 0x90);

                    // Reservar memoria para la estructura.
                    var driveLayoutInformationStructurePointer = Marshal.AllocHGlobal(outBufferSize);

                    // Obtener información.
                    uint bytesReturned = 0;
                    var result = DeviceManagement.NativeMethods.DeviceIoControl(
                        hDevice,
                        IoctlDiskControlCode.IOCTL_DISK_GET_DRIVE_LAYOUT_EX,
                        IntPtr.Zero,
                        0x00,
                        driveLayoutInformationStructurePointer,
                        (uint) outBufferSize,
                        ref bytesReturned,
                        IntPtr.Zero);

                    // Si es falso aumentamos el buffer en 1 estructura PARTITION_INFORMATION_EX.
                    if (result == false)
                    {
                        // If the buffer wasn't too small, then something else went wrong.
                        if (Marshal.GetLastWin32Error() != Win32ErrorCode.ERROR_INSUFFICIENT_BUFFER)
                        {
                            throw new Win32Exception();
                        }

                        numPartitions++;
                    }
                    else
                    {
                        // Ok, salimos del while.
                        done = true;

                        // Asignar valor a la estructura contenedora.                                  
                        var driveLayoutInformationStructureValue = (DRIVE_LAYOUT_INFORMATION_EX)Marshal.PtrToStructure(driveLayoutInformationStructurePointer, typeof(DRIVE_LAYOUT_INFORMATION_EX));

                        // Obtenemos las estructuras PARTITION_INFORMATION_EX contenidas en la estructura DRIVE_LAYOUT_INFORMATION_EX.
                        for (var i = 0; i < driveLayoutInformationStructureValue.PartitionCount - 1; i++)
                        {
                            // Calcular el inicio de cada estructura PARTITION_INFORMATION_EX.
                            var offset = new IntPtr(driveLayoutInformationStructurePointer.ToInt64() + 48 + (i * 144));

                            // Asignar valor a la estructura.                                  
                            var partitionInformationStructureValue = (PARTITION_INFORMATION_EX)Marshal.PtrToStructure(offset, typeof(PARTITION_INFORMATION_EX));

                            // Añadir a la lista de estructuras.
                            partitions.Add(partitionInformationStructureValue);
                        }
                    }
                }
            }

            return (PARTITION_INFORMATION_EX[])partitions.ToArray().Clone();
        }
        #endregion

        #region [public] {static} (GETVERSIONINPARAMS) IsSmartSupported(string): Recupera información acerca de la geometría del disco físico: tipo, número de cilindros, pistas por cilindro, sectores por pista y bytes por sector.
        /// <summary>
        /// Recupera información acerca de la geometría del disco físico: tipo, número de cilindros, pistas por cilindro, sectores por pista y bytes por sector.
        /// </summary>
        /// <param name="phisycalDrive">Unidad física a comprobar.</param>
        /// <returns>
        /// Estructura <see cref="DISK_GEOMETRY"/> con la información de geometría física de la unidad especificada.
        /// </returns>
        public static GETVERSIONINPARAMS IsSmartSupported(string phisycalDrive)
        {
            using (var hDevice = FileManagement.NativeMethods.CreateFile(phisycalDrive, FileAccess.ReadWrite, FileShare.ReadWrite | FileShare.Delete, IntPtr.Zero, FileMode.Open, FileOptions.None, IntPtr.Zero))
            {
                if (hDevice.IsInvalid)
                {
                    return GETVERSIONINPARAMS.Empty;
                }

                // Reservar memoria para la estructura.
                var diskGeometryStructurePointer = Marshal.AllocHGlobal(Marshal.SizeOf(typeof(GETVERSIONINPARAMS)));

                // Obtener información.
                uint bytesReturned = 0;
                var ok = DeviceManagement.NativeMethods.DeviceIoControl(hDevice, DeviceControlCode.SMART_GET_VERSION, IntPtr.Zero, 0, diskGeometryStructurePointer, (uint)Marshal.SizeOf(typeof(GETVERSIONINPARAMS)), ref bytesReturned, IntPtr.Zero);

                if (!ok)
                {
                    return GETVERSIONINPARAMS.Empty;
                }

                // Asignar valor a la estructura.                                  
                var diskGeometryStrucutreValue = (GETVERSIONINPARAMS)Marshal.PtrToStructure(diskGeometryStructurePointer, typeof(GETVERSIONINPARAMS));

                return diskGeometryStrucutreValue;
            }
        }
        #endregion

        public static string GetDriveName(string drive)
        {
            // receives volume name of drive
            StringBuilder volname = new StringBuilder(Constants.MAX_PATH + 1);
            StringBuilder sysname = new StringBuilder(Constants.MAX_PATH + 1);

            uint sn;
            uint maxcomplen;
            VolumeManagement.NativeMethods.FileSystemFlags sysflags;
            var retval = VolumeManagement.NativeMethods.GetVolumeInformation(drive, volname, 256, out sn, out maxcomplen, out sysflags, sysname, 261);

            return retval ? volname.ToString() : string.Empty;
        }

        public static string[] GetPhysicalDrives()
        {
            var drives = new List<string>();
            for (int i = 0; ; i++)
            {
                // Attempt to obtain a handle to the device that is to perform the operation, in this 
                // case physical drive n.The first drive is 0, second drive is 1 etc.
                // hDevice will return INVALID_HANDLE_VALUE when no more physical drives are located.
                using (SafeFileHandle h = FileManagement.NativeMethods.CreateFile(string.Concat("\\\\.\\PHYSICALDRIVE", i), 0x00, FileShare.ReadWrite, IntPtr.Zero, FileMode.Open, FileOptions.None, IntPtr.Zero))
                {
                    // If a valid handle, pass that to o btain the physical disk geometry                             
                    if (h.IsInvalid)
                    {
                        break;
                    }

                    drives.Add(string.Concat("\\\\.\\PHYSICALDRIVE", i));
                }
            }

            return (string[])drives.ToArray().Clone();
        }

        public static bool ReadPhysicalDriveInNtUsingSmart()
        {
            bool done = false;

            for (int drive = 0; drive < 16; drive++)
            {
                //  Try to get a handle to PhysicalDrive IOCTL, report failure
                //  and exit if can't.
                string driveName = String.Concat("\\\\.\\PhysicalDrive", drive);

                //  Windows NT, Windows 2000, Windows Server 2003, Vista
                var hPhysicalDriveIoctl = OpenDisk(drive);

                //FileManagementNativeMethods.CreateFile(driveName,
                //                                                             FileAccess.ReadWrite,
                //                                                             FileShare.Delete | FileShare.ReadWrite,
                //                                                             IntPtr.Zero,
                //                                                             FileMode.Open,
                //                                                             FileOptions.None,
                //                                                             IntPtr.Zero);
                if (!hPhysicalDriveIoctl.IsInvalid)
                {
                    // Reservar memoria para la estructura.
                    var getVersionParamsStructurePointer = Marshal.AllocHGlobal(Marshal.SizeOf(typeof(GETVERSIONINPARAMS)));
                    uint cbBytesReturned = 0;
                    var fgfg = DeviceManagement.NativeMethods.DeviceIoControl(hPhysicalDriveIoctl,
                        DiskIoControlCode.SMART_GET_VERSION, 
                        IntPtr.Zero,
                        0, 
                        getVersionParamsStructurePointer,
                        (uint) Marshal.SizeOf(typeof(GETVERSIONINPARAMS)), 
                        ref cbBytesReturned,
                        IntPtr.Zero);

                    if (fgfg)
                    {
                        // Asignar valor a la estructura.                                  
                        var getVersionParamsStructureValue = (GETVERSIONINPARAMS)Marshal.PtrToStructure(getVersionParamsStructurePointer, typeof(GETVERSIONINPARAMS));
                        var deviceLocation = getVersionParamsStructureValue.DeviceLocation;


                        const byte ID_CMD = 0xEC; // Returns ID sector for ATA
                        const Int32 IDENTIFY_BUFFER_SIZE = 512;
                        uint iBytesReturned = 0;
                        var sci = new SENDCMDINPARAMS
                        {
                            irDriveRegs = { bCommandReg = ID_CMD },
                            bDriveNumber = (byte)0,
                            cBufferSize = IDENTIFY_BUFFER_SIZE
                        };

                        var hhhhhh = (uint)Marshal.SizeOf(typeof(IDENTIFY_DEVICE_DATA));
                        var sciPointer = Marshal.AllocHGlobal(Marshal.SizeOf(typeof(SENDCMDINPARAMS)));
                        var scoPointer = Marshal.AllocHGlobal(Marshal.SizeOf(typeof(SENDCMDOUTPARAMS)));
                        Marshal.StructureToPtr(sci, sciPointer, true);

                        var hhhh = DeviceManagement.NativeMethods.DeviceIoControl(
                            hPhysicalDriveIoctl,
                            DiskIoControlCode.SMART_RCV_DRIVE_DATA,
                            sciPointer,
                            (uint) Marshal.SizeOf(typeof(SENDCMDINPARAMS)),
                            scoPointer,
                            (uint) Marshal.SizeOf(typeof(SENDCMDOUTPARAMS)), 
                            ref iBytesReturned, 
                            IntPtr.Zero);
                        var scoPointerValue = (SENDCMDOUTPARAMS)Marshal.PtrToStructure(scoPointer, typeof(SENDCMDOUTPARAMS));

                        var bdb = Marshal.SizeOf(typeof(IDENTIFY_DEVICE_DATA));

                        var IdentifyDeviceDataPointer = Marshal.AllocHGlobal(Marshal.SizeOf(typeof(IDENTIFY_DEVICE_DATA)));
                        Marshal.Copy(scoPointerValue.bBuffer, 0, IdentifyDeviceDataPointer, 512);
                        var identifyDeviceDataValue = (IDENTIFY_DEVICE_DATA)Marshal.PtrToStructure(IdentifyDeviceDataPointer, typeof(IDENTIFY_DEVICE_DATA));

                        var fff = identifyDeviceDataValue.GetSupportedFeature(IDENTIFY_DEVICE_DATA.StateFeature.Bit48Lba);

                        //var modelNumber = identifyDeviceDataValue.ModelNumber;

                        //byte[] mnArray = new byte[identifyDeviceDataValue.ModelNumber.Length];
                        //Array.Copy(.ModelNumber, 0, mnArray, 0, identifyDeviceDataValue.ModelNumber.Length - 1);
                        //mnArray.SwapBytes();
                        //var modelNumber = new StringBuilder();
                        //modelNumber.Append(Encoding.ASCII.GetString(mnArray, 0, mnArray.Length));

                        //byte[] snArray1 = new byte[identifyDeviceDataValue.ModelNumber.Length];
                        //Array.Copy(identifyDeviceDataValue.ModelNumber, 0, snArray1, 0, identifyDeviceDataValue.ModelNumber.Length - 1);
                        //snArray1.SwapBytes();
                        //var snResult1 = new StringBuilder();
                        //snResult1.Append(Encoding.ASCII.GetString(snArray1, 0, snArray1.Length));

                        //byte[] snArray = new byte[identifyDeviceDataValue.FirmwareRevision.Length];
                        //Array.Copy(identifyDeviceDataValue.FirmwareRevision, 0, snArray, 0, identifyDeviceDataValue.FirmwareRevision.Length - 1);
                        //snArray.SwapBytes();
                        //var snResult = new StringBuilder();
                        //snResult.Append(Encoding.ASCII.GetString(snArray, 0, snArray.Length));

                        int aaa = 0;
                        aaa++;
                    }
                }
            }

            return done;
        }

        #endregion

        #region private static methods

        private static Win32Exception CreateWin32Exception(int errorCode, string context)
        {
            var win32Exception = new Win32Exception(errorCode);
            win32Exception.Data["Context"] = context;
            return win32Exception;
        }

        public static SafeFileHandle OpenDisk(int diskNumber)
        {
            SafeFileHandle hDevice = FileManagement.NativeMethods.CreateFile(string.Format(@"\\.\PhysicalDrive{0}", diskNumber), FileAccess.ReadWrite, FileShare.ReadWrite, IntPtr.Zero, FileMode.Open, FileOptions.None, IntPtr.Zero);
            if (!hDevice.IsInvalid)
            {
                return hDevice;
            }

            throw CreateWin32Exception(Marshal.GetLastWin32Error(), "CreateFile");
        }

        public static bool ReadPhysicalDriveInNtUsingSmart2(int drive)
        {
            using (var hDisk = OpenDisk(drive))
            {
                ATA_PASS_THROUGH_EX apex = new ATA_PASS_THROUGH_EX();
                apex.Length = (ushort)Marshal.SizeOf(apex);
                apex.AtaFlags = AtaFlags.ReceiveData;                               // 2 ATA_FLAGS_DATA_IN
                apex.DataTransferLength = 512;                                      // The command returns a 512 byte package of info.
                apex.TimeOutValue = 10;                                             // 10 second timeout.

                apex.DataBufferOffset = Marshal.OffsetOf(typeof(ATA_PASS_THROUGH_EX_WITH_BUFFER), "Data");
                apex.CurrentTaskFile = new ATA_TASK_FILE();                          // This contains the command we are requesting.
                apex.CurrentTaskFile = new ATA_TASK_FILE(AtaCommand.IdentifyDevice); // &HEC <-- the command "IDENTIFY DEVICE"                    
                                                                                     //uint inBufferSize = (uint)Marshal.SizeOf(typeof(ATA_PASS_THROUGH_EX)) + apex.DataTransferLength;

                var apexb = new ATA_PASS_THROUGH_EX_WITH_BUFFER { Apt = apex };
                uint inBufferSize = (uint)Marshal.SizeOf(typeof(ATA_PASS_THROUGH_EX_WITH_BUFFER));

                //var sciPointer = Marshal.AllocHGlobal(Marshal.SizeOf(typeof(SENDCMDINPARAMS)));

                var apexHandle = Marshal.AllocHGlobal((int)inBufferSize);
                Marshal.StructureToPtr(apexb, apexHandle, true);

                uint bytesReturned = 0;
                var result = DeviceManagement.NativeMethods.DeviceIoControl(hDisk, IdeIoControlCode.IOCTL_ATA_PASS_THROUGH, apexHandle, inBufferSize, apexHandle, inBufferSize, ref bytesReturned, IntPtr.Zero);
                var apexValue = (ATA_PASS_THROUGH_EX_WITH_BUFFER)Marshal.PtrToStructure(apexHandle, typeof(ATA_PASS_THROUGH_EX_WITH_BUFFER));
                var sddd = result;
                var i = 0;
                i++;


                IDENTIFY_DEVICE_DATA idd = new IDENTIFY_DEVICE_DATA();
                var iddHandle = Marshal.AllocHGlobal(Marshal.SizeOf(typeof(IDENTIFY_DEVICE_DATA)));
                //Marshal.StructureToPtr(idd, iddHandle, true);

                ATA_PASS_THROUGH_DIRECT aptd = new ATA_PASS_THROUGH_DIRECT();
                aptd.Length = (ushort)Marshal.SizeOf(typeof(ATA_PASS_THROUGH_DIRECT)); //(ushort)Marshal.SizeOf(aptd);
                aptd.AtaFlags = AtaFlags.ReceiveData;                               // 2 ATA_FLAGS_DATA_IN
                aptd.DataTransferLength = 512;                                      // The command returns a 512 byte package of info.
                aptd.TimeOutValue = 10;                                             // 10 second timeout.
                aptd.CurrentTaskFile = new ATA_TASK_FILE();                           // This contains the command we are requesting.
                aptd.CurrentTaskFile = new ATA_TASK_FILE(AtaCommand.IdentifyDevice); // &HEC <-- the command "IDENTIFY DEVICE"                    
                aptd.DataBuffer = iddHandle;


                var apedHandle = Marshal.AllocHGlobal(Marshal.SizeOf(typeof(ATA_PASS_THROUGH_DIRECT)));
                Marshal.StructureToPtr(aptd, apedHandle, true);

                uint bytesReturned2 = 0;
                var result2 = DeviceManagement.NativeMethods.DeviceIoControl(hDisk, IdeIoControlCode.IOCTL_ATA_PASS_THROUGH_DIRECT, apedHandle, aptd.Length, apedHandle, aptd.Length, ref bytesReturned2, IntPtr.Zero);

                var jkjk = aptd.DataBuffer;
                var apedValue = (IDENTIFY_DEVICE_DATA)Marshal.PtrToStructure(jkjk, typeof(IDENTIFY_DEVICE_DATA));
                var ddd = apedValue.ModelNumber;

                var jhh = new byte[512];
                Marshal.Copy(aptd.DataBuffer, jhh, 0, 511);
                //var apedValue = (IDENTIFY_DEVICE_DATA)Marshal..PtrToStructure(aptd.DataBuffer, typeof(IDENTIFY_DEVICE_DATA));
                var jj = result2;
                i++;
            }

            return true;
        }

        #endregion
    }
}
