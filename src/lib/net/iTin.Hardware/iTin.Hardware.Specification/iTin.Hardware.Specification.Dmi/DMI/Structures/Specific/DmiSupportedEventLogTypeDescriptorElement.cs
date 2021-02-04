
namespace iTin.Hardware.Specification.Dmi
{
    using Smbios;

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

        #region [internal] DmiSupportedEventLogTypeDescriptorElement(byte[]): Initialize a new instance of the class specifying the structure information
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

        #endregion

        #region public properties

        #region [public] (string) DescriptorFormat: Gets a value that represents the Descriptor Format
        /// <summary>
        /// Gets a value that represents the Descriptor Format.
        /// </summary>
        /// <value>
        /// Descriptor Format.
        /// </value>
        public string DescriptorFormat { get; }
        #endregion

        #region [public] (string) DescriptorType: Gets a value that represents the Descriptor Type
        /// <summary>
        /// Gets a value that represents the Descriptor Type.
        /// </summary>
        /// <value>
        /// Descriptor Type.
        /// </value>
        public string DescriptorType { get; }
        #endregion

        #endregion

        #region public override methods

        #region [public] {override} (string) ToString(): Returns a string that represents the current instance
        /// <summary>
        /// Returns a class <see cref="string"/> that represents the current instance.
        /// </summary>
        /// <returns>
        /// Object <see cref="string"/> that represents the current <see cref="AdditionalInformationEntry"/> class.
        /// </returns>
        public override string ToString() => $"Type = \"{DescriptorType}\"";
        #endregion

        #endregion
    }
}
