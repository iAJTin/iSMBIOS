
namespace iTin.Core.Hardware.Specification.Dmi
{
    using Property;

    using Smbios;
    using Smbios.Property;

    /// <inheritdoc />
    /// <summary>
    /// Specialization of the <see cref="T:iTin.Core.Hardware.Specification.Dmi.DmiBaseType{T}" /> class that contains the logic to decode the IPMI Device Information (Type 38) structure.
    /// For more information, please see <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosType038" />.
    /// </summary>
    internal sealed class DmiType038 : DmiBaseType<SmbiosType038>
    {
        #region constructor/s

        #region [public] DmiType038(SmbiosType038, int): Initializes a new instance of the class by specifying the structure information and the SMBIOS version
        /// <inheritdoc />
        /// <summary>
        /// Initializes a new instance of the <see cref="T:iTin.Core.Hardware.Specification.Dmi.DmiType038" /> class by specifying the structure information and the <see cref="T:iTin.Core.Hardware.Specification.SMBIOS" /> version.
        /// </summary>
        /// <param name="smbiosStructure">Formatted structure information.</param>
        /// <param name="smbiosVersion">Current <see cref="T:iTin.Core.Hardware.Specification.SMBIOS" /> version.</param>
        public DmiType038(SmbiosType038 smbiosStructure, int smbiosVersion) : base(smbiosStructure, smbiosVersion)
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
            object interfaceType = SmbiosStructure.GetPropertyValue(SmbiosProperty.IpmiDevice.InterfaceType);
            if (interfaceType != null)
            {
                properties.Add(DmiProperty.IpmiDevice.InterfaceType, interfaceType);
            }

            object specificationRevision = SmbiosStructure.GetPropertyValue(SmbiosProperty.IpmiDevice.SpecificationRevision);
            if (specificationRevision != null)
            {
                properties.Add(DmiProperty.IpmiDevice.SpecificationRevision, specificationRevision);
            }

            object i2CSlaveAddress = SmbiosStructure.GetPropertyValue(SmbiosProperty.IpmiDevice.I2CSlaveAddress);
            if (i2CSlaveAddress != null)
            {
                properties.Add(DmiProperty.IpmiDevice.I2CSlaveAddress, i2CSlaveAddress);
            }

            object nvStorageDeviceAddressProperty = SmbiosStructure.GetPropertyValue(SmbiosProperty.IpmiDevice.NVStorageDeviceAddress);
            if (nvStorageDeviceAddressProperty != null)
            {
                byte nvStorageDeviceAddress = (byte) nvStorageDeviceAddressProperty;
                if (nvStorageDeviceAddress != 0x00)
                {
                    properties.Add(DmiProperty.IpmiDevice.NVStorageDeviceAddress, nvStorageDeviceAddress);
                }
            }

            object baseAdress = SmbiosStructure.GetPropertyValue(SmbiosProperty.IpmiDevice.BaseAdress);
            if (baseAdress != null)
            {
                properties.Add(DmiProperty.IpmiDevice.BaseAdress, baseAdress);
            }

            if (SmbiosStructure.StructureInfo.Length >= 0x11)
            {
                object registerSpacing = SmbiosStructure.GetPropertyValue(SmbiosProperty.IpmiDevice.BaseAdressModifier.RegisterSpacing);
                if (registerSpacing != null)
                {
                    properties.Add(DmiProperty.IpmiDevice.BaseAdressModifier.RegisterSpacing, registerSpacing);
                }

                object lsBit = SmbiosStructure.GetPropertyValue(SmbiosProperty.IpmiDevice.BaseAdressModifier.LsBit);
                if (lsBit != null)
                {
                    properties.Add(DmiProperty.IpmiDevice.BaseAdressModifier.LsBit, lsBit);
                }

                object specifiedInfo = SmbiosStructure.GetPropertyValue(SmbiosProperty.IpmiDevice.Interrupt.SpecifiedInfo);
                if (specifiedInfo != null)
                {
                    properties.Add(DmiProperty.IpmiDevice.Interrupt.SpecifiedInfo, specifiedInfo);
                }

                object polarity = SmbiosStructure.GetPropertyValue(SmbiosProperty.IpmiDevice.Interrupt.Polarity);
                if (polarity != null)
                {
                    properties.Add(DmiProperty.IpmiDevice.Interrupt.Polarity, polarity);
                }

                object triggerMode = SmbiosStructure.GetPropertyValue(SmbiosProperty.IpmiDevice.Interrupt.TriggerMode);
                if (triggerMode != null)
                {
                    properties.Add(DmiProperty.IpmiDevice.Interrupt.TriggerMode, triggerMode);
                }
            }

            if (SmbiosStructure.StructureInfo.Length >= 0x12)
            {
                object interruptNumberProperty = SmbiosStructure.GetPropertyValue(SmbiosProperty.IpmiDevice.InterruptNumber);
                if (interruptNumberProperty != null)
                {
                    byte interruptNumber = (byte) interruptNumberProperty;
                    if (interruptNumber != 0x00)
                    {
                        properties.Add(DmiProperty.IpmiDevice.InterruptNumber, interruptNumber);
                    }
                }
            }
        }
        #endregion

        #endregion
    }
}
