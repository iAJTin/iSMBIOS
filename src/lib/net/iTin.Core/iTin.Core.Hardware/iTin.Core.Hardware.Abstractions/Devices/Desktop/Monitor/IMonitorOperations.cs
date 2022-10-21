
using System.Collections.Generic;

namespace iTin.Core.Hardware.Abstractions.Devices.Desktop.Monitor
{
    /// <summary>
    /// Define a generic <b>Monitor</b> operations.
    /// </summary>
    public interface IMonitorOperations
    {
        /// <summary>
        /// Gets a value containing the raw <b>EDID</b> data.
        /// </summary>
        /// <returns>
        /// The raw <b>EDID</b> data.
        /// </returns>
        IEnumerable<byte[]> GetEdidDataCollection();
    }
}
