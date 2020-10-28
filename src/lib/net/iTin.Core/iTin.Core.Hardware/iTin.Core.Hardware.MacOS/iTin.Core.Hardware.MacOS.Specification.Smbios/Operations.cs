
namespace iTin.Core.Hardware.MacOS.Specification.Smbios
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;

    using iTin.Core.ComponentModel.Enums;

    /// <summary>
    /// Defines 
    /// </summary>
    public static class Operations
    {
        /// <summary>
        /// 
        /// </summary>
        /// <returns>
        /// </returns>
        public static byte[] GetSmbiosDataArray()
        {
            var startInfo = new ProcessStartInfo()
            {
                FileName = MacProgram.IoReg.ToString(),
                Arguments = "-lw0 -n \"AppleSMBIOS\" -r | grep \"SMBIOS\"",

                /*Arguments = "-w0 -c \"AppleSMBIOS\" -r",*/
                UseShellExecute = false,
                CreateNoWindow = false,
                RedirectStandardOutput = true,
                RedirectStandardError = true
            };

            var process = new Process()
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
