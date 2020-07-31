
namespace iTin.Core.Hardware.Specification.Smbios
{
    /// <summary>
    /// Defines remote user parameters
    /// </summary>
    public class SmbiosConnectOptions
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
