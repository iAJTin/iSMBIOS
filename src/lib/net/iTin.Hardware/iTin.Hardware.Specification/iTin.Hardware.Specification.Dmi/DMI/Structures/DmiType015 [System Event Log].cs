
namespace iTin.Hardware.Specification.Dmi
{
    using System.Collections.ObjectModel;

    using Property;

    using Smbios;
    using Smbios.Property;

    /// <inheritdoc/>
    /// <summary>
    /// Specialization of the <see cref="DmiBaseType{T}"/> class that contains the logic to decode the System Event Log (Type 15) structure.
    /// For more information, please see <see cref="SmbiosType015"/>.
    /// </summary>
    internal sealed class DmiType015 : DmiBaseType<SmbiosType015>
    {
        #region constructor/s

        #region [public] DmiType015(SmbiosType015, int): Initializes a new instance of the class by specifying the structure information and the SMBIOS version
        /// <inheritdoc/>
        /// <summary>
        /// Initializes a new instance of the <see cref="DmiType015"/> class by specifying the structure information and the <see cref="SMBIOS"/> version.
        /// </summary>
        /// <param name="smbiosStructure">Formatted structure information.</param>
        /// <param name="smbiosVersion">Current <see cref="SMBIOS"/> version.</param>
        public DmiType015(SmbiosType015 smbiosStructure, int smbiosVersion) : base(smbiosStructure, smbiosVersion)
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
            #region 2.0+
            if (ImplementedVersion >= DmiStructureVersion.v20)
            {
                object logAreaLength = SmbiosStructure.GetPropertyValue(SmbiosProperty.SystemEventLog.LogAreaLength);
                if (logAreaLength != null)
                {
                    properties.Add(DmiProperty.SystemEventLog.LogAreaLength, logAreaLength);
                }

                object logHeaderStartOffset = SmbiosStructure.GetPropertyValue(SmbiosProperty.SystemEventLog.LogHeaderStartOffset);
                if (logHeaderStartOffset != null)
                {
                    properties.Add(DmiProperty.SystemEventLog.LogHeaderStartOffset, logHeaderStartOffset);
                }

                object dataStartOffset = SmbiosStructure.GetPropertyValue(SmbiosProperty.SystemEventLog.DataStartOffset);
                if (dataStartOffset != null)
                {
                    properties.Add(DmiProperty.SystemEventLog.DataStartOffset, dataStartOffset);
                }

                object accessMethod = SmbiosStructure.GetPropertyValue(SmbiosProperty.SystemEventLog.AccessMethod);
                if (accessMethod != null)
                {
                    properties.Add(DmiProperty.SystemEventLog.AccessMethod, accessMethod);
                }

                object logStatus = SmbiosStructure.GetPropertyValue(SmbiosProperty.SystemEventLog.LogStatus);
                if (logStatus != null)
                {
                    properties.Add(DmiProperty.SystemEventLog.LogStatus, logStatus);
                }

                object accessMethodAddress = SmbiosStructure.GetPropertyValue(SmbiosProperty.SystemEventLog.AccessMethodAddress);
                if (accessMethodAddress != null)
                {
                    properties.Add(DmiProperty.SystemEventLog.AccessMethodAddress, accessMethodAddress);
                }

                object logChangeToken = SmbiosStructure.GetPropertyValue(SmbiosProperty.SystemEventLog.LogChangeToken);
                if (logChangeToken != null)
                {
                    properties.Add(DmiProperty.SystemEventLog.LogChangeToken, logChangeToken);
                }
            }
            #endregion

            #region 2.1+
            if (ImplementedVersion >= DmiStructureVersion.v21)
            {
                object logHeaderFormat = SmbiosStructure.GetPropertyValue(SmbiosProperty.SystemEventLog.LogHeaderFormat);
                if (logHeaderFormat != null)
                {
                    properties.Add(DmiProperty.SystemEventLog.LogHeaderFormat, logHeaderFormat);
                }

                object supportedLogTypeDescriptors = SmbiosStructure.GetPropertyValue(SmbiosProperty.SystemEventLog.SupportedLogTypeDescriptors);
                if (supportedLogTypeDescriptors != null)
                {
                    properties.Add(DmiProperty.SystemEventLog.SupportedLogTypeDescriptors, supportedLogTypeDescriptors);
                }

                object listSupportedEventLogTypeDescriptors = SmbiosStructure.GetPropertyValue(SmbiosProperty.SystemEventLog.ListSupportedEventLogTypeDescriptors);
                if (listSupportedEventLogTypeDescriptors != null)
                {
                    var collection = new Collection<DmiSupportedEventLogTypeDescriptorElement>();
                    var items = (SupportedEventLogTypeDescriptorsCollection) listSupportedEventLogTypeDescriptors;
                    foreach (var item in items)
                    {
                        collection.Add(new DmiSupportedEventLogTypeDescriptorElement(item));
                    }
                    
                    properties.Add(DmiProperty.SystemEventLog.ListSupportedEventLogTypeDescriptors, new DmiSupportedEventLogTypeDescriptorsCollection(collection));
                }
            }
            #endregion
        }
        #endregion

        #endregion
    }
}
