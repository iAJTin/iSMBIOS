
namespace iTin.Hardware.Specification.Dmi
{
    using Property;

    using Smbios;
    using Smbios.Property;

    /// <inheritdoc/>
    /// <summary>
    /// Specialization of the <see cref="DmiBaseType{T}"/> class that contains the logic to decode the Group Associations (Type 14) structure.
    /// For more information, please see <see cref="SmbiosType014"/>.
    /// </summary>
    internal sealed class DmiType014 : DmiBaseType<SmbiosType014>
    {
        #region constructor/s

        #region [public] DmiType014(SmbiosType014, int): Initializes a new instance of the class by specifying the structure information and the SMBIOS version
        /// <inheritdoc/>
        /// <summary>
        /// Initializes a new instance of the <see cref="DmiType014"/> class by specifying the structure information and the <see cref="SMBIOS"/> version.
        /// </summary>
        /// <param name="smbiosStructure">Formatted structure information.</param>
        /// <param name="smbiosVersion">Current <see cref="SMBIOS"/> version.</param>
        public DmiType014(SmbiosType014 smbiosStructure, int smbiosVersion) : base(smbiosStructure, smbiosVersion)
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
            properties.Add(DmiProperty.GroupAssociations.GroupName, SmbiosStructure.GetPropertyValue(SmbiosProperty.GroupAssociations.GroupName));

            object containedElements = SmbiosStructure.GetPropertyValue(SmbiosProperty.GroupAssociations.ContainedElements);
            properties.Add(DmiProperty.GroupAssociations.ContainedElements, new DmiGroupAssociationElementCollection((GroupAssociationElementCollection)containedElements));
        }
        #endregion

        #endregion
    }
}
