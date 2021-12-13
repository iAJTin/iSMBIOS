
namespace iTin.Hardware.Abstractions.Specification.Smbios
{
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.Runtime.InteropServices;

    using iTin.Core.Hardware.Common.Specification.Smbios;

    using Linux = iTin.Core.Hardware.Linux.Specification.Smbios;
    using MacOS = iTin.Core.Hardware.MacOS.Specification.Smbios;
    using Windows = iTin.Core.Hardware.Windows.Specification.Smbios;

    /// <summary>
    /// Define 
    /// </summary>
    public class SmbiosOperations
    {
        #region private static readonly members
        // Static members are 'eagerly initialized', that is, immediately when class is loaded for the first time.
        // .NET guarantees thread safety for static initialization
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static readonly SmbiosOperations instance = new SmbiosOperations();
        #endregion

        #region private readonly members
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private readonly ISmbiosOperations _operations;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private readonly Dictionary<OSPlatform, ISmbiosOperations> _operationsTable;
        #endregion

        #region constructor/s

        #region [private] SmbiosOperations(): Prevents a default instance of this class
        /// <summary>
        /// Prevents a default instance of the <see cref="SmbiosOperations"/> class from being created.
        /// </summary>
        private SmbiosOperations()
        {
            _operationsTable = new Dictionary<OSPlatform, ISmbiosOperations>()
            {
                { OSPlatform.Windows, new Windows.SmbiosOperations()},
                { OSPlatform.Linux, new Linux.SmbiosOperations()},
                { OSPlatform.OSX, new MacOS.SmbiosOperations()},
            };

            if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
            {
                _operations = _operationsTable[OSPlatform.Windows];
            }
            else
            {
                _operations = RuntimeInformation.IsOSPlatform(OSPlatform.OSX) 
                    ? _operationsTable[OSPlatform.OSX] 
                    : _operationsTable[OSPlatform.Linux];
            }
        }
        #endregion

        #endregion

        #region public static readonly properties

        #region [public] {static} (SmbiosOperations) Instance: Gets an unique instance of this class
        /// <summary>
        /// Gets an unique instance of this class.
        /// </summary>
        /// <value>
        /// A <see cref="SmbiosOperations"/> reference that contains <b>SMBIOS</b> operations.
        /// </value>
        public static SmbiosOperations Instance => instance;
        #endregion

        #endregion

        #region public methods

        #region [public] (byte[]) GetSmbiosDataArray(ISmbiosConnectOptions = null): Returns a raw SMBIOS data
        /// <summary>
        /// Gets a value containing the raw <b>SMBIOS</b> data.
        /// </summary>
        /// <param name="options">Connection options for remote use</param>
        /// <returns>
        /// The raw <b>SMBIOS</b> data.
        /// </returns>
        public byte[] GetSmbiosDataArray(ISmbiosConnectOptions options = null) => _operations.GetSmbiosDataArray(options);
        #endregion

        #endregion
    }
}
