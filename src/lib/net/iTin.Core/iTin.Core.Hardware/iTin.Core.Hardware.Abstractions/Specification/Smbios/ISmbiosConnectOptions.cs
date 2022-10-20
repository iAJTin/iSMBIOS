
namespace iTin.Core.Hardware.Abstractions.Specification.Smbios
{
    /// <summary>
    /// Define a 
    /// </summary>
    public interface ISmbiosConnectOptions
    {
        /// <summary>
        /// 
        /// </summary>
        /// <value>
        /// </value>
        string MachineNameOrIpAddress { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <value>
        /// </value>
        string UserName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <value>
        /// </value>
        string Password { get; set; }
    }
}
