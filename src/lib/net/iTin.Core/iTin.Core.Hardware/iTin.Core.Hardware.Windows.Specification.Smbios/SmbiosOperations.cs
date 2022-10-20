
using System;
using System.Linq;
using System.Management;

using iTin.Core.Hardware.Abstractions.Specification.Smbios;

namespace iTin.Core.Hardware.Windows.Specification.Smbios
{
    /// <summary>
    /// Specialization of the <see cref="ISmbiosOperations"/> interface that contains the <b>SMBIOS</b> operations for <b>Windows</b> system.
    /// </summary>
    public class SmbiosOperations : ISmbiosOperations
    {
        /// <summary>
        /// Gets a value containing the raw <b>SMBIOS</b> data.
        /// </summary>
        /// <param name="options">Connection options for remote use</param>
        /// <returns>
        /// The raw <b>SMBIOS</b> data.
        /// </returns>
        public byte[] GetSmbiosDataArray(ISmbiosConnectOptions options = null)
        {
            ManagementScope scope;

            if (options != null)
            {
                var connectionOptions = new ConnectionOptions
                {
                    Username = options.UserName,
                    Authentication = AuthenticationLevel.Packet,
                    Impersonation = ImpersonationLevel.Impersonate,
                    SecurePassword = options.Password.ToSecureString()
                };

                scope = new ManagementScope($"\\\\{options.MachineNameOrIpAddress}\\root\\cimv2", connectionOptions);

                try
                {
                    scope.Connect();
                }
                catch
                {
                    return Array.Empty<byte>();
                }
            }
            else
            {
                string[] tableNames = Firmware.EnumerateTables(FirmwareProvider.RSMB);
                if (tableNames.Any())
                {
                    return Firmware.GetTable(FirmwareProvider.RSMB, tableNames[0]);
                }

                scope = new ManagementScope("root\\WMI");
            }

            var result = Array.Empty<byte>();
            var query = new ObjectQuery("SELECT * FROM MSSmBios_RawSMBiosTables");
            using (var wmi = new ManagementObjectSearcher(scope, query))
            {
                foreach (var mos in wmi.Get())
                {
                    var queryObj = (ManagementObject)mos;
                    result = (byte[])queryObj["SMBiosData"];
                }
            }

            return result;
        }
    }
}
