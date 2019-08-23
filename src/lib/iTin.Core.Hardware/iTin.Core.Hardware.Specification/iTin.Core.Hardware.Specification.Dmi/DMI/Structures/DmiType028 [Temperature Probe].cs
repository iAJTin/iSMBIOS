
namespace iTin.Core.Hardware.Specification.Dmi
{
    using Property;

    using Smbios;
    using Smbios.Property;

    /// <inheritdoc />
    /// <summary>
    /// Specialization of the <see cref="T:iTin.Core.Hardware.Specification.Dmi.DmiBaseType{T}" /> class that contains the logic to decode the Temperature Probe (Type 28) structure.
    /// For more information, please see <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosType028" />.
    /// </summary>
    internal sealed class DmiType028 : DmiBaseType<SmbiosType028>
    {
        #region constructor/s

        #region [public] DmiType028(SmbiosType028, int): Initializes a new instance of the class by specifying the structure information and the SMBIOS version
        /// <inheritdoc />
        /// <summary>
        /// Initializes a new instance of the <see cref="T:iTin.Core.Hardware.Specification.Dmi.DmiType028" /> class by specifying the structure information and the <see cref="T:iTin.Core.Hardware.Specification.SMBIOS" /> version.
        /// </summary>
        /// <param name="smbiosStructure">Formatted structure information.</param>
        /// <param name="smbiosVersion">Current <see cref="T:iTin.Core.Hardware.Specification.SMBIOS" /> version.</param>
        public DmiType028(SmbiosType028 smbiosStructure, int smbiosVersion) : base(smbiosStructure, smbiosVersion)
        {
        }
        #endregion

        #endregion

        #region protected override methods

        #region [protected] {override} (void) PopulateProperties(DmiClassPropertiesTable): Populates the property collection for this structure
        /// <inheritdoc />
        /// <summary>
        /// Populates the property collection for this structure.
        /// </summary>
        /// <param name="properties">Collection of properties of this structure.</param>
        protected override void PopulateProperties(DmiClassPropertiesTable properties)
        {
            object description = SmbiosStructure.GetPropertyValue(SmbiosProperty.TemperatureProbe.Description);
            if (description != null)
            {
                properties.Add(DmiProperty.TemperatureProbe.Description, description);
            }

            object status = SmbiosStructure.GetPropertyValue(SmbiosProperty.TemperatureProbe.LocationAndStatus.Status);
            if (status != null)
            {
                properties.Add(DmiProperty.TemperatureProbe.LocationAndStatus.Status, status);
            }

            object location = SmbiosStructure.GetPropertyValue(SmbiosProperty.TemperatureProbe.LocationAndStatus.Location);
            if (location != null)
            {
                properties.Add(DmiProperty.TemperatureProbe.LocationAndStatus.Location, location);
            }

            int maximunValue = SmbiosStructure.GetPropertyValue<int>(SmbiosProperty.TemperatureProbe.MaximunValue);
            if (maximunValue != 0x8000)
            {
                properties.Add(DmiProperty.TemperatureProbe.MaximunValue, maximunValue);
            }

            int minimunValue = SmbiosStructure.GetPropertyValue<int>(SmbiosProperty.TemperatureProbe.MinimunValue);
            if (minimunValue != 0x8000)
            {
                properties.Add(DmiProperty.TemperatureProbe.MinimunValue, minimunValue);
            }

            int resolution = SmbiosStructure.GetPropertyValue<int>(SmbiosProperty.TemperatureProbe.Resolution);
            if (resolution != 0x8000)
            {
                properties.Add(DmiProperty.TemperatureProbe.Resolution, resolution);
            }

            int tolerance = SmbiosStructure.GetPropertyValue<int>(SmbiosProperty.TemperatureProbe.Tolerance);
            if (tolerance != 0x8000)
            {
                properties.Add(DmiProperty.TemperatureProbe.Tolerance, tolerance);
            }

            int accuracy = SmbiosStructure.GetPropertyValue<int>(SmbiosProperty.TemperatureProbe.Accuracy);
            if (accuracy != 0x8000)
            {
                properties.Add(DmiProperty.TemperatureProbe.Accuracy, accuracy);
            }

            object oemDefined = SmbiosStructure.GetPropertyValue(SmbiosProperty.TemperatureProbe.OemDefined);
            if (oemDefined != null)
            {
                properties.Add(DmiProperty.TemperatureProbe.OemDefined, oemDefined);
            }

            if (SmbiosStructure.StructureInfo.Length >= 0x15)
            {
                object nominalValueProperty = SmbiosStructure.GetPropertyValue(SmbiosProperty.TemperatureProbe.NominalValue);
                if (nominalValueProperty != null)
                {
                    int nominalValue = (int)nominalValueProperty;
                    if (nominalValue != 0x8000)
                    {
                        properties.Add(DmiProperty.TemperatureProbe.NominalValue, nominalValue);
                    }
                }
            }
        }
        #endregion

        #endregion
    }
}
