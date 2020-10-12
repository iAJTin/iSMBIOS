
namespace iTin.Hardware.Specification.Dmi
{
    using Property;

    using Smbios;
    using Smbios.Property;

    /// <inheritdoc/>
    /// <summary>
    /// Specialization of the <see cref="DmiBaseType{T}"/> class that contains the logic to decode the System Reset (Type 23) structure.
    /// For more information, please see <see cref="SmbiosType023"/>.
    /// </summary>
    internal sealed class DmiType023 : DmiBaseType<SmbiosType023>
    {
        #region constructor/s

        #region [public] DmiType023(SmbiosType023, int): Initializes a new instance of the class by specifying the structure information and the SMBIOS version
        /// <inheritdoc/>
        /// <summary>
        /// Initializes a new instance of the <see cref="DmiType023"/> class by specifying the structure information and the <see cref="SMBIOS"/> version.
        /// </summary>
        /// <param name="smbiosStructure">Formatted structure information.</param>
        /// <param name="smbiosVersion">Current <see cref="SMBIOS"/> version.</param>
        public DmiType023(SmbiosType023 smbiosStructure, int smbiosVersion) : base(smbiosStructure, smbiosVersion)
        {
        }
        #endregion

        #endregion

        #region protected override methods

        #region [protected] {override} (void) PopulateProperties(DmiClassPropertiesTable): Populates the property collection for this structure
        /// <inheritdoc/>
        /// <summary>
        /// Populates the property collection for this structure.
        /// </summary>
        /// <param name="properties">Collection of properties of this structure.</param>
        protected override void PopulateProperties(DmiClassPropertiesTable properties)
        {
            if (ImplementedVersion < DmiStructureVersion.Latest)
            {
                return;
            }

            ushort resetCount = SmbiosStructure.GetPropertyValue<ushort>(SmbiosProperty.SystemReset.ResetCount);
            if (resetCount != 0xffff)
            {
                properties.Add(DmiProperty.SystemReset.ResetCount, resetCount);
            }

            ushort resetLimit = SmbiosStructure.GetPropertyValue<ushort>(SmbiosProperty.SystemReset.ResetLimit);
            if (resetLimit != 0xffff)
            {
                properties.Add(DmiProperty.SystemReset.ResetLimit, resetLimit);
            }

            ushort timerInterval = SmbiosStructure.GetPropertyValue<ushort>(SmbiosProperty.SystemReset.TimerInterval);
            if (timerInterval != 0xffff)
            {
                properties.Add(DmiProperty.SystemReset.TimerInterval, timerInterval);
            }

            ushort timeOut = SmbiosStructure.GetPropertyValue<ushort>(SmbiosProperty.SystemReset.Timeout);
            if (timeOut != 0xffff)
            {
                properties.Add(DmiProperty.SystemReset.Timeout, timeOut);
            }

            properties.Add(DmiProperty.SystemReset.Capabilities.Status, SmbiosStructure.GetPropertyValue(SmbiosProperty.SystemReset.Capabilities.Status));
            properties.Add(DmiProperty.SystemReset.Capabilities.BootOption, SmbiosStructure.GetPropertyValue(SmbiosProperty.SystemReset.Capabilities.BootOption));
            properties.Add(DmiProperty.SystemReset.Capabilities.BootOptionOnLimit, SmbiosStructure.GetPropertyValue(SmbiosProperty.SystemReset.Capabilities.BootOptionOnLimit));
            properties.Add(DmiProperty.SystemReset.Capabilities.WatchdogTimer, SmbiosStructure.GetPropertyValue(SmbiosProperty.SystemReset.Capabilities.WatchdogTimer));
        }
        #endregion

        #endregion
    }
}
