
using iTin.Hardware.Specification.Dmi.Property;

using iTin.Hardware.Specification.Smbios;
using iTin.Hardware.Specification.Smbios.Property;

namespace iTin.Hardware.Specification.Dmi;

/// <summary>
/// This class represents an element of the structure <see cref="DmiType042"/>.
/// </summary>
public class DmiManagementControllerHostInterfaceProtocolRecord 
{
    #region private members
    private readonly SmbiosPropertiesTable _reference;
    #endregion

    #region constructor/s

    /// <summary>
    /// Initialize a new instance of the class <see cref="DmiManagementControllerHostInterfaceProtocolRecord"/>.
    /// </summary>
    /// <param name="reference"><b>SMBIOS</b> properties.</param>
    internal DmiManagementControllerHostInterfaceProtocolRecord(SmbiosPropertiesTable reference)
    {
        _reference = reference;
    }

    #endregion

    #region public properties

    /// <summary>
    /// Gets the properties available for this structure.
    /// </summary>
    /// <value>
    /// Availables properties.
    /// </value>
    public DmiClassPropertiesTable Properties =>
        new()
        {
            {DmiProperty.ManagementControllerHostInterface.Protocol.ProtocolType, _reference[SmbiosProperty.ManagementControllerHostInterface.Protocol.ProtocolType]},
            {DmiProperty.ManagementControllerHostInterface.Protocol.ProtocolTypeSpecificData, _reference[SmbiosProperty.ManagementControllerHostInterface.Protocol.ProtocolTypeSpecificData]}
        };

    #endregion
}
