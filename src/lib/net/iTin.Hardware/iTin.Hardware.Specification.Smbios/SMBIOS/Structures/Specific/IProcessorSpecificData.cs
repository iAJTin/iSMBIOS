
namespace iTin.Hardware.Specification.Smbios;

/// <summary>
/// </summary>
public interface IProcessorSpecificData
{
    /// <summary>
    ///  Gets a value that represents the '<b>Major Revision</b>' field.
    /// </summary>
    /// <value>
    /// Value of the property.
    /// </value>
    byte? MajorRevision { get; }

    /// <summary>
    ///  Gets a value that represents the '<b>Minor Revision</b>' field.
    /// </summary>
    /// <value>
    /// Value of the property.
    /// </value>
    byte? MinorRevision { get; }
}
