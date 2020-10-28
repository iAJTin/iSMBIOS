
namespace iTin.Hardware.Abstractions.Specification.Smbios
{
    using System;
    using System.Linq;
    using System.Management;
    using System.Runtime.InteropServices;

    using MacOS = iTin.Core.Hardware.MacOS.Specification.Smbios;
    using WinOperations = iTin.Core.Hardware.Windows.Specification.Smbios;

    /// <summary>
    /// Define 
    /// </summary>
    public static class Operations
    {
        /// <summary>
        /// 
        /// </summary>
        public static byte[] GetSmbiosDataArray()
        {
            var result = Array.Empty<byte>();
                
            if (RuntimeInformation.IsOSPlatform(OSPlatform.Linux))
            {
                result = Array.Empty<byte>();
            }

            if (RuntimeInformation.IsOSPlatform(OSPlatform.OSX))
            {
                result = MacOS.Operations.GetSmbiosDataArray();
            }
                    
            if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
            {
                string[] tableNames = WinOperations.Firmware.EnumerateTables(WinOperations.FirmwareProvider.RSMB);
                if (tableNames.Any())
                {
                    result = WinOperations.Firmware.GetTable(WinOperations.FirmwareProvider.RSMB, tableNames[0]);                       
                }
                else
                {
                    using (var wmi = new ManagementObjectSearcher("root\\WMI", "SELECT * FROM MSSmBios_RawSMBiosTables"))
                    {
                        foreach (var o in wmi.Get())
                        {
                            var queryObj = (ManagementObject)o;
                            result = (byte[])queryObj["SMBiosData"];
                        }
                    }
                }
            }

            return result;
        }
    }
}
