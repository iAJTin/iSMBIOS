
using iTin.Hardware.Specification.Smbios;

namespace iTin.Hardware.Specification.Dmi;

// •—————————————————————————————————————————————————————————————————————————————————————————————————————•
// | Offset   Name                           Length      Value       Description                         |
// •—————————————————————————————————————————————————————————————————————————————————————————————————————•
// | 00h      Log Type                       BYTE        ENUM        Event Log types                     |
// •—————————————————————————————————————————————————————————————————————————————————————————————————————•
// | 01h      Variable Data Format Type      BYTE        ENUM        Event Log Variable Data Format Type |
// •—————————————————————————————————————————————————————————————————————————————————————————————————————•

/// <summary>
/// This class represents an element of the structure.
/// </summary>
public class DmiSupportedEventLogTypeDescriptorElement
{
    #region constructor/s

    /// <summary>
    /// Initialize a new instance of the class <see cref="DmiSupportedEventLogTypeDescriptorElement"/> specifying the structure information.
    /// </summary>
    /// <param name="reference">Untreated information of the current structure.</param>
    internal DmiSupportedEventLogTypeDescriptorElement(SupportedEventLogTypeDescriptorElement reference)
    {
        DescriptorType = reference.DescriptorType;
        DescriptorFormat = reference.DescriptorFormat;
    }

    #endregion

    #region public properties

    /// <summary>
    /// Gets a value that represents the Descriptor Format.
    /// </summary>
    /// <value>
    /// Descriptor Format.
    /// </value>
    public string DescriptorFormat { get; }

    /// <summary>
    /// Gets a value that represents the Descriptor Type.
    /// </summary>
    /// <value>
    /// Descriptor Type.
    /// </value>
    public string DescriptorType { get; }

    #endregion

    #region public override methods

    /// <summary>
    /// Returns a class <see cref="string"/> that represents the current instance.
    /// </summary>
    /// <returns>
    /// Object <see cref="string"/> that represents the current <see cref="AdditionalInformationEntry"/> class.
    /// </returns>
    public override string ToString() => $"Type = \"{DescriptorType}\"";

    #endregion
}
