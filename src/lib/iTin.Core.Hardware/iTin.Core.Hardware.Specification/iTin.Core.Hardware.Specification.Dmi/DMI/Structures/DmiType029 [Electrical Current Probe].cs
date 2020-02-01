
namespace iTin.Core.Hardware.Specification.Dmi
{
    using Property;

    using Smbios;
    using Smbios.Property;

    /// <inheritdoc/>
    /// <summary>
    /// Specialization of the <see cref="DmiBaseType{T}"/> class that contains the logic to decode the Electrical Current Probe (Type 29) structure.
    /// For more information, please see <see cref="SmbiosType029"/>.
    /// </summary>
    internal sealed class DmiType029 : DmiBaseType<SmbiosType029>
    {
        #region constructor/s

        #region [public] DmiType029(SmbiosType029, int): Initializes a new instance of the class by specifying the structure information and the SMBIOS version
        /// <inheritdoc/>
        /// <summary>
        /// Initializes a new instance of the <see cref="DmiType029"/> class by specifying the structure information and the <see cref="SMBIOS"/> version.
        /// </summary>
        /// <param name="smbiosStructure">Formatted structure information.</param>
        /// <param name="smbiosVersion">Current <see cref="SMBIOS"/> version.</param>
        public DmiType029(SmbiosType029 smbiosStructure, int smbiosVersion) : base(smbiosStructure, smbiosVersion)
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
            object description = SmbiosStructure.GetPropertyValue(SmbiosProperty.ElectricalCurrentProbe.Description);
            if (description != null)
            {
                properties.Add(DmiProperty.ElectricalCurrentProbe.Description, description);
            }

            object status = SmbiosStructure.GetPropertyValue(SmbiosProperty.ElectricalCurrentProbe.LocationAndStatus.Status);
            if (status != null)
            {
                properties.Add(DmiProperty.ElectricalCurrentProbe.LocationAndStatus.Status, status);
            }

            object location = SmbiosStructure.GetPropertyValue(SmbiosProperty.ElectricalCurrentProbe.LocationAndStatus.Location);
            if (location != null)
            {
                properties.Add(DmiProperty.ElectricalCurrentProbe.LocationAndStatus.Location, location);
            }

            object maximunValueProperty = SmbiosStructure.GetPropertyValue(SmbiosProperty.ElectricalCurrentProbe.MaximunValue);
            if (maximunValueProperty != null)
            {
                int maximunValue = (int)maximunValueProperty;
                if (maximunValue != 0x8000)
                {
                    properties.Add(DmiProperty.ElectricalCurrentProbe.MaximunValue, maximunValue);
                }
            }

            object minimunValueProperty = SmbiosStructure.GetPropertyValue(SmbiosProperty.ElectricalCurrentProbe.MinimunValue);
            if (minimunValueProperty != null)
            {
                int minimunValue = (int)minimunValueProperty;
                if (minimunValue != 0x8000)
                {
                    properties.Add(DmiProperty.ElectricalCurrentProbe.MinimunValue, minimunValue);
                }
            }

            object resolutionProperty = SmbiosStructure.GetPropertyValue(SmbiosProperty.ElectricalCurrentProbe.Resolution);
            if (resolutionProperty != null)
            {
                int resolution = (int)resolutionProperty;
                if (resolution != 0x8000)
                {
                    properties.Add(DmiProperty.ElectricalCurrentProbe.Resolution, resolution);
                }
            }

            object toleranceProperty = SmbiosStructure.GetPropertyValue(SmbiosProperty.ElectricalCurrentProbe.Tolerance);
            if (toleranceProperty != null)
            {
                int tolerance = (int)toleranceProperty;
                if (tolerance != 0x8000)
                {
                    properties.Add(DmiProperty.ElectricalCurrentProbe.Tolerance, tolerance);
                }
            }

            object accuracyProperty = SmbiosStructure.GetPropertyValue(SmbiosProperty.ElectricalCurrentProbe.Accuracy);
            if (accuracyProperty != null)
            {
                int accuracy = (int)accuracyProperty;
                if (accuracy != 0x8000)
                {
                    properties.Add(DmiProperty.ElectricalCurrentProbe.Accuracy, accuracy);
                }
            }

            object oemDefined = SmbiosStructure.GetPropertyValue(SmbiosProperty.ElectricalCurrentProbe.OemDefined);
            if (oemDefined != null)
            {
                properties.Add(DmiProperty.ElectricalCurrentProbe.OemDefined, oemDefined);
            }

            if (SmbiosStructure.StructureInfo.Length >= 0x15)
            {
                object nominalValueProperty = SmbiosStructure.GetPropertyValue(SmbiosProperty.ElectricalCurrentProbe.NominalValue);
                if (nominalValueProperty != null)
                {
                    int nominalValue = (int)nominalValueProperty;
                    if (nominalValue != 0x8000)
                    {
                        properties.Add(DmiProperty.ElectricalCurrentProbe.NominalValue, nominalValue);
                    }
                }
            }
        }
        #endregion

        #endregion
    }
}
