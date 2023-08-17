
using iTin.Hardware.Specification.Dmi.Property;

using iTin.Hardware.Specification.Smbios;
using iTin.Hardware.Specification.Smbios.Property;

namespace iTin.Hardware.Specification.Dmi;

/// <summary>
/// This class represents an element of the structure <see cref="DmiType003"/>.
/// </summary>
public class DmiChassisContainedElement
{
    #region private members
    private readonly SmbiosPropertiesTable _reference;
    #endregion

    #region constructor/s

    /// <summary>
    /// Initialize a new instance of the class <see cref="DmiChassisContainedElement"/>.
    /// </summary>
    /// <param name="reference"><b>SMBIOS</b> properties.</param>
    internal DmiChassisContainedElement(SmbiosPropertiesTable reference)
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
            {DmiProperty.Chassis.Elements.Min, _reference[SmbiosProperty.Chassis.Elements.Min]},
            {DmiProperty.Chassis.Elements.Max, _reference[SmbiosProperty.Chassis.Elements.Max]},
            {DmiProperty.Chassis.Elements.TypeSelect, _reference[SmbiosProperty.Chassis.Elements.TypeSelect]},
            {DmiProperty.Chassis.Elements.ItemType, _reference[SmbiosProperty.Chassis.Elements.ItemType]}
        };

    #endregion
}
