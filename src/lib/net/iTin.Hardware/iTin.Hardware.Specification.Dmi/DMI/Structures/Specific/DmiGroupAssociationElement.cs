
using iTin.Hardware.Specification.Dmi.Property;

using iTin.Hardware.Specification.Smbios;
using iTin.Hardware.Specification.Smbios.Property;

namespace iTin.Hardware.Specification.Dmi;

/// <summary>
/// This class represents an element of the structure <see cref="DmiType014"/>.
/// </summary>
public class DmiGroupAssociationElement
{
    #region private members
    private readonly SmbiosPropertiesTable _reference;
    #endregion

    #region constructor/s

    /// <summary>
    /// Initialize a new instance of the class <see cref="DmiGroupAssociationElement"/> specifying the information of the structure.
    /// </summary>
    /// <param name="reference"><b>SMBIOS</b> properties.</param>
    internal DmiGroupAssociationElement(SmbiosPropertiesTable reference)
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
            {DmiProperty.GroupAssociations.Items.Structure, _reference[SmbiosProperty.GroupAssociations.Items.Structure]},
            {DmiProperty.GroupAssociations.Items.Handle, _reference[SmbiosProperty.GroupAssociations.Items.Handle]}
        };

    #endregion
}
