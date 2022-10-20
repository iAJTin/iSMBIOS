
using System;
using System.Collections.Generic;
using System.Diagnostics;

using iTin.Core.Hardware.Abstractions.Specification.Smbios;
using iTin.Core.Interop.Shared.MacOS;

namespace iTin.Core.Hardware.MacOS.Specification.Smbios
{
    /// <summary>
    /// Specialization of the <see cref="ISmbiosOperations"/> interface that contains the <b>SMBIOS</b> operations for <b>OSX</b> system.
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
            var startInfo = new ProcessStartInfo
            {
                FileName = Command.IoReg.ToString(),
                Arguments = "-lw0 -n \"AppleSMBIOS\" -r | grep \"SMBIOS\"",

                /*Arguments = "-w0 -c \"AppleSMBIOS\" -r",*/
                UseShellExecute = false,
                CreateNoWindow = false,
                RedirectStandardOutput = true,
                RedirectStandardError = true
            };

            var process = new Process
            {
                StartInfo = startInfo
            };

            string ioAppleSmbios = string.Empty;
            process.OutputDataReceived += (sender, data) =>
            {
                if (data != null)
                {
                    if (data.Data != null)
                    {
                        if (data.Data.Contains("\"SMBIOS\" = <"))
                        {
                            string[] splitted = data.Data.Split(new[] { "\"SMBIOS\" = " }, StringSplitOptions.RemoveEmptyEntries);
                            string rawSmbios = splitted[1].Replace("<", string.Empty).Replace(">", string.Empty);
                            ioAppleSmbios = rawSmbios;
                        }
                    }
                }
            };

            process.ErrorDataReceived += (sender, data) =>
            {
            };

            try
            {
                process.Start();
                process.BeginOutputReadLine();
                process.BeginErrorReadLine();
                process.WaitForExit();
            }
            catch
            {
            }

            var item = new List<byte>();
            for (int i = 0; i <= ioAppleSmbios.Length - 1; i += 2)
            {
                item.Add(Convert.ToByte(ioAppleSmbios.Substring(i, 2), 16));
            }

            return (byte[])item.ToArray().Clone();
        }
    }
}
