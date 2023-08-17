
using System;

using iTin.Core.Hardware.Abstractions.Specification.Smbios;

namespace iTin.Core.Hardware.Linux.Specification.Smbios;

/// <summary>
/// Specialization of the <see cref="ISmbiosOperations"/> interface that contains the <b>SMBIOS</b> operations for <b>Linux</b> system.
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
    public byte[] GetSmbiosDataArray(ISmbiosConnectOptions options = null) => Array.Empty<byte>();
}
