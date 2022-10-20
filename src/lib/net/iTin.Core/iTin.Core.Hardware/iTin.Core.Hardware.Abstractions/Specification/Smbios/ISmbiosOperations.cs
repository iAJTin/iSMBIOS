
namespace iTin.Core.Hardware.Abstractions.Specification.Smbios
{
    /// <summary>
    /// Define a generic <b>SMBIOS</b> operations.
    /// </summary>
    public interface ISmbiosOperations
    {
        /// <summary>
        /// Gets a value containing the raw <b>SMBIOS</b> data.
        /// </summary>
        /// <param name="options">Connection options for remote use</param>
        /// <returns>
        /// The raw <b>SMBIOS</b> data.
        /// </returns>
        byte[] GetSmbiosDataArray(ISmbiosConnectOptions options);
    }
}
