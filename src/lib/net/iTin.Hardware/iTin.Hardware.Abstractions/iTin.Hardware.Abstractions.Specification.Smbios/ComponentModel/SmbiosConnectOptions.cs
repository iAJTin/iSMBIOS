
namespace iTin.Hardware.Abstractions.Specification.Smbios.ComponentModel
{
    using iTin.Core.Hardware.Common.Specification.Smbios;

    /// <summary>
    /// Defines remote user parameters
    /// </summary>
    public class SmbiosConnectOptions : ISmbiosConnectOptions
    {
        /// <summary>
        /// 
        /// </summary>
        /// <value>
        /// </value>
        public string MachineNameOrIpAddress { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <value>
        /// </value>
        public string UserName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <value>
        /// </value>
        public string Password { get; set; }
    }
}
