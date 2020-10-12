
namespace iTin.Hardware.Specification.Dmi
{
    using Property;

    using Smbios;
    using Smbios.Property;

    /// <inheritdoc/>
    /// <summary>
    /// Specialization of the <see cref="DmiBaseType{T}"/> class that contains the logic to decode the Baseboard (or Module) Information (Type 2) structure.
    /// For more information, please see <see cref="SmbiosType002"/>.
    /// </summary>
    internal sealed class DmiType002 : DmiBaseType<SmbiosType002>
    {
        #region constructor/s

        #region [public] DmiType002(SmbiosType002, int): Initializes a new instance of the class by specifying the structure information and the SMBIOS version
        /// <inheritdoc/>
        /// <summary>
        /// Initializes a new instance of the <see cref="DmiType002"/> class by specifying the structure information and the <see cref="SMBIOS"/> version.
        /// </summary>
        /// <param name="smbiosStructure">Formatted structure information.</param>
        /// <param name="smbiosVersion">Current <see cref="SMBIOS"/> version.</param>
        public DmiType002(SmbiosType002 smbiosStructure, int smbiosVersion) : base(smbiosStructure, smbiosVersion)
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
            object manufacturer = SmbiosStructure.GetPropertyValue(SmbiosProperty.BaseBoard.Manufacturer);
            if (manufacturer != null)
            {
                properties.Add(DmiProperty.BaseBoard.Manufacturer, manufacturer);
            }

            object product = SmbiosStructure.GetPropertyValue(SmbiosProperty.BaseBoard.Product);
            if (product != null)
            {
                properties.Add(DmiProperty.BaseBoard.Product, product);
            }

            object version = SmbiosStructure.GetPropertyValue(SmbiosProperty.BaseBoard.Version);
            if (version != null)
            {
                properties.Add(DmiProperty.BaseBoard.Version, version);
            }

            object serialNumber = SmbiosStructure.GetPropertyValue(SmbiosProperty.BaseBoard.SerialNumber);
            if (serialNumber != null)
            {
                properties.Add(DmiProperty.BaseBoard.SerialNumber, serialNumber);
            }

            if (SmbiosStructure.StructureInfo.Length >= 0x09)
            {
                object assetTag = SmbiosStructure.GetPropertyValue(SmbiosProperty.BaseBoard.AssetTag);
                if (assetTag != null)
                {
                    properties.Add(DmiProperty.BaseBoard.AssetTag, assetTag);
                }
            }

            if (SmbiosStructure.StructureInfo.Length >= 0x0a)
            {
                object isHotSwappable = SmbiosStructure.GetPropertyValue(SmbiosProperty.BaseBoard.Features.IsHotSwappable);
                if (isHotSwappable != null)
                {
                    properties.Add(DmiProperty.BaseBoard.Features.IsHotSwappable, isHotSwappable);
                }

                object isReplaceable = SmbiosStructure.GetPropertyValue(SmbiosProperty.BaseBoard.Features.IsReplaceable);
                if (isReplaceable != null)
                {
                    properties.Add(DmiProperty.BaseBoard.Features.IsReplaceable, isReplaceable);
                }

                object isRemovable = SmbiosStructure.GetPropertyValue(SmbiosProperty.BaseBoard.Features.IsRemovable);
                if (isRemovable != null)
                {
                    properties.Add(DmiProperty.BaseBoard.Features.IsRemovable, isRemovable);
                }

                object requiredDaughterBoard = SmbiosStructure.GetPropertyValue(SmbiosProperty.BaseBoard.Features.RequiredDaughterBoard);
                if (requiredDaughterBoard != null)
                {
                    properties.Add(DmiProperty.BaseBoard.Features.RequiredDaughterBoard, requiredDaughterBoard);
                }

                object isHostingBoard = SmbiosStructure.GetPropertyValue(SmbiosProperty.BaseBoard.Features.IsHostingBoard);
                if (isHostingBoard != null)
                {
                    properties.Add(DmiProperty.BaseBoard.Features.IsHostingBoard, isHostingBoard);
                }
            }

            if (SmbiosStructure.StructureInfo.Length >= 0x0b)
            {
                object locationInChassis = SmbiosStructure.GetPropertyValue(SmbiosProperty.BaseBoard.LocationInChassis);
                if (locationInChassis != null)
                {
                    properties.Add(DmiProperty.BaseBoard.LocationInChassis, locationInChassis);
                }
            }

            if (SmbiosStructure.StructureInfo.Length >= 0x0c)
            {
                object chassisHandle = SmbiosStructure.GetPropertyValue(SmbiosProperty.BaseBoard.ChassisHandle);
                if (chassisHandle != null)
                {
                    properties.Add(DmiProperty.BaseBoard.ChassisHandle, chassisHandle);
                }
            }

            if (SmbiosStructure.StructureInfo.Length >= 0x0d)
            {
                object boardType = SmbiosStructure.GetPropertyValue(SmbiosProperty.BaseBoard.BoardType);
                if (boardType != null)
                {
                    properties.Add(DmiProperty.BaseBoard.BoardType, boardType);
                }
            }

            if (SmbiosStructure.StructureInfo.Length >= 0x0e)
            {
                object numberOfContainedObjectHandles = SmbiosStructure.GetPropertyValue(SmbiosProperty.BaseBoard.NumberOfContainedObjectHandles);
                if (numberOfContainedObjectHandles != null)
                {
                    properties.Add(DmiProperty.BaseBoard.NumberOfContainedObjectHandles, numberOfContainedObjectHandles);
                }

                object containedElements = SmbiosStructure.GetPropertyValue(SmbiosProperty.BaseBoard.ContainedElements);
                if (containedElements != null)
                {
                    properties.Add(DmiProperty.BaseBoard.ContainedElements, containedElements);
                }
            }
        }
        #endregion

        #endregion
    }
}
