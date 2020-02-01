
namespace iTin.Core.Hardware.Specification.Dmi
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
            object resetCountProperty = SmbiosStructure.GetPropertyValue(SmbiosProperty.SystemReset.ResetCount);
            if (resetCountProperty != null)
            {
                int resetCount = (int)resetCountProperty;
                if (resetCount != 0xffff)
                {
                    properties.Add(DmiProperty.SystemReset.ResetCount, resetCount);
                }
            }

            object resetLimitProperty = SmbiosStructure.GetPropertyValue(SmbiosProperty.SystemReset.ResetLimit);
            if (resetLimitProperty != null)
            {
                int resetLimit = (int)resetLimitProperty;
                if (resetLimit != 0xffff)
                {
                    properties.Add(DmiProperty.SystemReset.ResetLimit, resetLimit);
                }
            }

            object timerIntervalProperty = SmbiosStructure.GetPropertyValue(SmbiosProperty.SystemReset.TimerInterval);
            if (timerIntervalProperty != null)
            {
                int timerInterval = (int)timerIntervalProperty;
                if (timerInterval != 0xffff)
                {
                    properties.Add(DmiProperty.SystemReset.TimerInterval, timerInterval);
                }
            }

            object timeOutProperty = SmbiosStructure.GetPropertyValue(SmbiosProperty.SystemReset.Timeout);
            if (timeOutProperty != null)
            {
                int timeOut = (int)timeOutProperty;
                if (timeOut != 0xffff)
                {
                    properties.Add(DmiProperty.SystemReset.Timeout, timeOut);
                }
            }

            object status = SmbiosStructure.GetPropertyValue(SmbiosProperty.SystemReset.Capabilities.Status);
            if (status != null)
            {
                properties.Add(DmiProperty.SystemReset.Capabilities.Status, status);
            }

            object bootOption = SmbiosStructure.GetPropertyValue(SmbiosProperty.SystemReset.Capabilities.BootOption);
            if (bootOption != null)
            {
                properties.Add(DmiProperty.SystemReset.Capabilities.BootOption, bootOption);
            }

            object bootOptionOnLimit = SmbiosStructure.GetPropertyValue(SmbiosProperty.SystemReset.Capabilities.BootOptionOnLimit);
            if (bootOptionOnLimit != null)
            {
                properties.Add(DmiProperty.SystemReset.Capabilities.BootOptionOnLimit, bootOptionOnLimit);
            }

            object watchdogTimer = SmbiosStructure.GetPropertyValue(SmbiosProperty.SystemReset.Capabilities.WatchdogTimer);
            if (watchdogTimer != null)
            {
                properties.Add(DmiProperty.SystemReset.Capabilities.WatchdogTimer, watchdogTimer);
            }
        }
        #endregion

        #endregion
    }
}
