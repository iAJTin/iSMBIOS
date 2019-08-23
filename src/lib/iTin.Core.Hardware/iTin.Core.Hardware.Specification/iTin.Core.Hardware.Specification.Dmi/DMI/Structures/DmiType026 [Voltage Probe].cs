
namespace iTin.Core.Hardware.Specification.Dmi
{
    using Property;

    using Smbios;
    using Smbios.Property;

    /// <inheritdoc />
    /// <summary>
    /// Specialization of the <see cref="T:iTin.Core.Hardware.Specification.Dmi.DmiBaseType{T}" /> class that contains the logic to decode the Voltage Probe (Type 26) structure.
    /// For more information, please see <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosType026" />.
    /// </summary>
    internal sealed class DmiType026 : DmiBaseType<SmbiosType026>
    {
        #region constructor/s

        #region [public] DmiType026(SmbiosType026, int): Initializes a new instance of the class by specifying the structure information and the SMBIOS version
        /// <inheritdoc />
        /// <summary>
        /// Initializes a new instance of the <see cref="T:iTin.Core.Hardware.Specification.Dmi.DmiType026" /> class by specifying the structure information and the <see cref="T:iTin.Core.Hardware.Specification.SMBIOS" /> version.
        /// </summary>
        /// <param name="smbiosStructure">Formatted structure information.</param>
        /// <param name="smbiosVersion">Current <see cref="T:iTin.Core.Hardware.Specification.SMBIOS" /> version.</param>
        public DmiType026(SmbiosType026 smbiosStructure, int smbiosVersion) : base(smbiosStructure, smbiosVersion)
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
            object description = SmbiosStructure.GetPropertyValue(SmbiosProperty.VoltageProbe.Description);
            if (description != null)
            {
                properties.Add(DmiProperty.VoltageProbe.Description, description);
            }

            object status = SmbiosStructure.GetPropertyValue(SmbiosProperty.VoltageProbe.LocationAndStatus.Status);
            if (status != null)
            {
                properties.Add(DmiProperty.VoltageProbe.LocationAndStatus.Status, status);
            }

            object location = SmbiosStructure.GetPropertyValue(SmbiosProperty.VoltageProbe.LocationAndStatus.Location);
            if (location != null)
            {
                properties.Add(DmiProperty.VoltageProbe.LocationAndStatus.Location, location);
            }

            object maximunValueProperty = SmbiosStructure.GetPropertyValue(SmbiosProperty.VoltageProbe.MaximunValue);
            if (maximunValueProperty != null)
            {
                int maximunValue = (int)maximunValueProperty;
                if (maximunValue != 0x8000)
                {
                    properties.Add(DmiProperty.VoltageProbe.MaximunValue, maximunValue);
                }
            }

            object minimunValueProperty = SmbiosStructure.GetPropertyValue(SmbiosProperty.VoltageProbe.MinimunValue);
            if (minimunValueProperty != null)
            {
                int minimunValue = (int)minimunValueProperty;
                if (minimunValue != 0x8000)
                {
                    properties.Add(DmiProperty.VoltageProbe.MinimunValue, minimunValue);
                }
            }

            object resolutionProperty = SmbiosStructure.GetPropertyValue(SmbiosProperty.VoltageProbe.Resolution);
            if (resolutionProperty != null)
            {
                int resolution = (int)resolutionProperty;
                if (resolution != 0x8000)
                {
                    properties.Add(DmiProperty.VoltageProbe.Resolution, resolution);
                }
            }

            object toleranceProperty = SmbiosStructure.GetPropertyValue(SmbiosProperty.VoltageProbe.Tolerance);
            if (toleranceProperty != null)
            {
                int tolerance = (int)toleranceProperty;
                if (tolerance != 0x8000)
                {
                    properties.Add(DmiProperty.VoltageProbe.Tolerance, tolerance);
                }
            }

            object accuracyProperty = SmbiosStructure.GetPropertyValue(SmbiosProperty.VoltageProbe.Accuracy);
            if (accuracyProperty != null)
            {
                int accuracy = (int)accuracyProperty;
                if (accuracy != 0x8000)
                {
                    properties.Add(DmiProperty.VoltageProbe.Accuracy, accuracy);
                }
            }

            object oemDefined = SmbiosStructure.GetPropertyValue(SmbiosProperty.VoltageProbe.OemDefined);
            if (oemDefined != null)
            {
                properties.Add(DmiProperty.VoltageProbe.OemDefined, oemDefined);
            }

            if (SmbiosStructure.StructureInfo.Length >= 0x15)
            {
                object nominalValueProperty = SmbiosStructure.GetPropertyValue(SmbiosProperty.VoltageProbe.NominalValue);
                if (nominalValueProperty != null)
                {
                    int nominalValue = (int)nominalValueProperty;
                    if (nominalValue != 0x8000)
                    {
                        properties.Add(DmiProperty.VoltageProbe.NominalValue, nominalValue);
                    }
                }
            }
        }
        #endregion

        #endregion
    }
}
