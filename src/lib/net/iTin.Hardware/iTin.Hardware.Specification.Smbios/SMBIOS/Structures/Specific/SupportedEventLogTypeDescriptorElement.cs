
namespace iTin.Hardware.Specification.Smbios
{
    // •—————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | Offset   Name                           Length      Value       Description                         |
    // •—————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 00h      Log Type                       BYTE        ENUM        Event Log types                     |
    // •—————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 01h      Variable Data Format Type      BYTE        ENUM        Event Log Variable Data Format Type |
    // •—————————————————————————————————————————————————————————————————————————————————————————————————————•

    /// <summary>
    /// This class represents an element of the structure <see cref="SmbiosType015"/>.
    /// </summary>
    public class SupportedEventLogTypeDescriptorElement
    {
        #region constructor/s

        #region [internal] SupportedEventLogTypeDescriptorElement(byte[]): Initialize a new instance of the class specifying the structure information
        /// <summary>
        /// Initialize a new instance of the class <see cref="SupportedEventLogTypeDescriptorElement"/> specifying the structure information.
        /// </summary>
        /// <param name="data">Untreated information of the current structure.</param>
        internal SupportedEventLogTypeDescriptorElement(byte[] data)
        {
            DescriptorFormat = GetEventLogDescriptorType(data[0x00]);
            DescriptorType = GetEventLogDescriptorFormat(data[0x01]);
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


        #region BIOS Specification 2.7.1 (26/01/2011)

        private static string GetEventLogDescriptorFormat(byte code)
        {
            string[] formats =
            {
                "None",                            // 0x00
                "Handle",
                "Multiple-event",
                "Multiple-event handle",
                "POST results bitmap",
                "System management",
                "Multiple-event system management" // 0x06
            };

            if (code <= 0x06)
            {
                return formats[code];
            }

            if (code >= 0x80)
            {
                return "OEM-specific";
            }

            return SmbiosHelper.OutOfSpec;
        }

        private static string GetEventLogDescriptorType(byte code)
        {
            string[] descriptorTypes =
            {
                SmbiosHelper.Reserved,                 // 0x00
                "Single-bit ECC memory error",
                "Multi-bit ECC memory error",
                "Parity memory error",
                "Bus timeout",
                "I/O channel block",
                "Software NMI",
                "POST memory resize",
                "POST error",
                "PCI parity error",
                "PCI system error",
                "CPU failure",
                "EISA failsafe timer timeout",
                "Correctable memory log disabled",
                "Logging disabled",
                SmbiosHelper.Reserved,
                "System limit exceeded",
                "Asynchronous hardware timer expired",
                "System configuration information",
                "Hard disk information",
                "System reconfigured",
                "Uncorrectable CPU-complex error",
                "Log area reset/cleared",
                "System boot"                          // 0x17
            };

            if (code <= 0x17)
            {
                return descriptorTypes[code];
            }

            if (code >= 0x80 && code <= 0xfe)
            {
                return "OEM-specific";
            }

            if (code == 0xff)
            {
                return "End of log";
            }

            return SmbiosHelper.OutOfSpec;
        }

        #endregion
    }
}
