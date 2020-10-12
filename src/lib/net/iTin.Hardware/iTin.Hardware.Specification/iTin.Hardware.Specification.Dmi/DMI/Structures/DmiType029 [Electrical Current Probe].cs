
namespace iTin.Hardware.Specification.Dmi
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
            if (ImplementedVersion >= DmiStructureVersion.Latest)
            {
                properties.Add(DmiProperty.ElectricalCurrentProbe.Description, SmbiosStructure.GetPropertyValue(SmbiosProperty.ElectricalCurrentProbe.Description));
                properties.Add(DmiProperty.ElectricalCurrentProbe.LocationAndStatus.Status, SmbiosStructure.GetPropertyValue(SmbiosProperty.ElectricalCurrentProbe.LocationAndStatus.Status));
                properties.Add(DmiProperty.ElectricalCurrentProbe.LocationAndStatus.Location, SmbiosStructure.GetPropertyValue(SmbiosProperty.ElectricalCurrentProbe.LocationAndStatus.Location));

                ushort maximumValue = SmbiosStructure.GetPropertyValue<ushort>(SmbiosProperty.ElectricalCurrentProbe.MaximumValue);
                if (maximumValue != 0x8000)
                {
                    properties.Add(DmiProperty.ElectricalCurrentProbe.MaximumValue, maximumValue);
                }

                ushort minimumValue = SmbiosStructure.GetPropertyValue<ushort>(SmbiosProperty.ElectricalCurrentProbe.MinimumValue);
                if (minimumValue != 0x8000)
                {
                    properties.Add(DmiProperty.ElectricalCurrentProbe.MinimumValue, minimumValue);
                }

                ushort resolution = SmbiosStructure.GetPropertyValue<ushort>(SmbiosProperty.ElectricalCurrentProbe.Resolution);
                if (resolution != 0x8000)
                {
                    properties.Add(DmiProperty.ElectricalCurrentProbe.Resolution, resolution);
                }

                ushort tolerance = SmbiosStructure.GetPropertyValue<ushort>(SmbiosProperty.ElectricalCurrentProbe.Tolerance);
                if (tolerance != 0x8000)
                {
                    properties.Add(DmiProperty.ElectricalCurrentProbe.Tolerance, tolerance);
                }

                ushort accuracy = SmbiosStructure.GetPropertyValue<ushort>(SmbiosProperty.ElectricalCurrentProbe.Accuracy);
                if (accuracy != 0x8000)
                {
                    properties.Add(DmiProperty.ElectricalCurrentProbe.Accuracy, accuracy);
                }

                properties.Add(DmiProperty.ElectricalCurrentProbe.OemDefined, SmbiosStructure.GetPropertyValue(SmbiosProperty.ElectricalCurrentProbe.OemDefined));
            }

            if (SmbiosStructure.StructureInfo.Length < 0x15)
            {
                return;
            }

            ushort nominalValue = SmbiosStructure.GetPropertyValue<ushort>(SmbiosProperty.ElectricalCurrentProbe.NominalValue);
            if (nominalValue != 0x8000)
            {
                properties.Add(DmiProperty.ElectricalCurrentProbe.NominalValue, nominalValue);
            }
        }
        #endregion

        #endregion
    }
}
