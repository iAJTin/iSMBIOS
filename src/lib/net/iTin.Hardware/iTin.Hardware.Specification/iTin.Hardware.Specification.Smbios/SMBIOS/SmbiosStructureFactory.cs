
namespace iTin.Hardware.Specification.Smbios
{
    using System.Collections.Generic;

    /// <summary>
    /// The static class <see cref="SmbiosStructureFactory"/> creates the <see cref="SMBIOS"/> structures.
    /// </summary>
    internal static class SmbiosStructureFactory
    {
        /// <summary>
        /// Create list of available structures.
        /// </summary>
        /// <param name="structureInfo">Structure information.</param>
        /// <returns>
        /// An enumerator, which supports a simple iteration in the collection of structures.
        /// </returns>
        public static IEnumerable<SmbiosBaseType> Create(SmbiosStructureInfo structureInfo)
        {
            IEnumerable<byte[]> rawTables = structureInfo.Context.GetAllRawTablesFrom(structureInfo.StructureType);
            if (rawTables == null)
            {
                return null;
            }
            
            var parseProperties = new List<SmbiosBaseType>();
            foreach (var rawTable in rawTables)
            {
                var smbiosStructureHeaderInfo = new SmbiosStructureHeaderInfo(rawTable);
                switch (structureInfo.StructureType)
                {
                    case SmbiosStructure.Bios:
                        parseProperties.Add(new SmbiosType000(smbiosStructureHeaderInfo, structureInfo.SmbiosVersion));
                        break;

                    case SmbiosStructure.System:
                        parseProperties.Add(new SmbiosType001(smbiosStructureHeaderInfo, structureInfo.SmbiosVersion));
                        break;

                    case SmbiosStructure.BaseBoard:
                        parseProperties.Add(new SmbiosType002(smbiosStructureHeaderInfo, structureInfo.SmbiosVersion));
                        break;

                    case SmbiosStructure.SystemEnclosure:
                        parseProperties.Add(new SmbiosType003(smbiosStructureHeaderInfo, structureInfo.SmbiosVersion));
                        break;

                    case SmbiosStructure.Processor:
                        parseProperties.Add(new SmbiosType004(smbiosStructureHeaderInfo, structureInfo.SmbiosVersion));
                        break;

                    case SmbiosStructure.MemoryController:
                        parseProperties.Add(new SmbiosType005(smbiosStructureHeaderInfo, structureInfo.SmbiosVersion));
                        break;

                    case SmbiosStructure.MemoryModule:
                        parseProperties.Add(new SmbiosType006(smbiosStructureHeaderInfo, structureInfo.SmbiosVersion));
                        break;

                    case SmbiosStructure.Cache:
                        parseProperties.Add(new SmbiosType007(smbiosStructureHeaderInfo, structureInfo.SmbiosVersion));
                        break;

                    case SmbiosStructure.PortConnector:
                        parseProperties.Add(new SmbiosType008(smbiosStructureHeaderInfo, structureInfo.SmbiosVersion));
                        break;

                    case SmbiosStructure.SystemSlots:
                        parseProperties.Add(new SmbiosType009(smbiosStructureHeaderInfo, structureInfo.SmbiosVersion));
                        break;

                    case SmbiosStructure.OnBoardDevices:
                         parseProperties.Add(new SmbiosType010(smbiosStructureHeaderInfo, structureInfo.SmbiosVersion));
                        break;

                    case SmbiosStructure.OemStrings:
                        parseProperties.Add(new SmbiosType011(smbiosStructureHeaderInfo, structureInfo.SmbiosVersion));
                        break;

                    case SmbiosStructure.SystemConfigurationOptions:
                        parseProperties.Add(new SmbiosType012(smbiosStructureHeaderInfo, structureInfo.SmbiosVersion));
                        break;

                    case SmbiosStructure.BiosLanguage:
                        parseProperties.Add(new SmbiosType013(smbiosStructureHeaderInfo, structureInfo.SmbiosVersion));
                        break;

                    case SmbiosStructure.GroupAssociations:
                        parseProperties.Add(new SmbiosType014(smbiosStructureHeaderInfo, structureInfo.SmbiosVersion));
                        break;

                    case SmbiosStructure.SystemEventLog:
                        parseProperties.Add(new SmbiosType015(smbiosStructureHeaderInfo, structureInfo.SmbiosVersion));
                        break;

                    case SmbiosStructure.PhysicalMemoryArray:
                        parseProperties.Add(new SmbiosType016(smbiosStructureHeaderInfo, structureInfo.SmbiosVersion));
                        break;

                    case SmbiosStructure.MemoryDevice:
                        parseProperties.Add(new SmbiosType017(smbiosStructureHeaderInfo, structureInfo.SmbiosVersion));
                        break;

                    case SmbiosStructure.BitMemoryError32:
                        parseProperties.Add(new SmbiosType018(smbiosStructureHeaderInfo, structureInfo.SmbiosVersion));
                        break;

                    case SmbiosStructure.MemoryArrayMappedAddress:
                        parseProperties.Add(new SmbiosType019(smbiosStructureHeaderInfo, structureInfo.SmbiosVersion));
                        break;

                    case SmbiosStructure.MemoryDeviceMappedAddress:
                        parseProperties.Add(new SmbiosType020(smbiosStructureHeaderInfo, structureInfo.SmbiosVersion));
                        break;

                    case SmbiosStructure.BuiltInPointingDevice:
                        parseProperties.Add(new SmbiosType021(smbiosStructureHeaderInfo, structureInfo.SmbiosVersion));
                        break;

                    case SmbiosStructure.PortableBattery:
                        parseProperties.Add(new SmbiosType022(smbiosStructureHeaderInfo, structureInfo.SmbiosVersion));
                        break;

                    case SmbiosStructure.SystemReset:
                        parseProperties.Add(new SmbiosType023(smbiosStructureHeaderInfo, structureInfo.SmbiosVersion));
                        break;

                    case SmbiosStructure.HardwareSecurity:
                        parseProperties.Add(new SmbiosType024(smbiosStructureHeaderInfo, structureInfo.SmbiosVersion));
                        break;

                    case SmbiosStructure.SystemPowerControls:
                        parseProperties.Add(new SmbiosType025(smbiosStructureHeaderInfo, structureInfo.SmbiosVersion));
                        break;

                    case SmbiosStructure.VoltageProbe:
                        parseProperties.Add(new SmbiosType026(smbiosStructureHeaderInfo, structureInfo.SmbiosVersion));
                        break;

                    case SmbiosStructure.CoolingDevice:
                        parseProperties.Add(new SmbiosType027(smbiosStructureHeaderInfo, structureInfo.SmbiosVersion));
                        break;

                    case SmbiosStructure.TemperatureProbe:
                        parseProperties.Add(new SmbiosType028(smbiosStructureHeaderInfo, structureInfo.SmbiosVersion));
                        break;

                    case SmbiosStructure.ElectricalCurrentProbe:
                        parseProperties.Add(new SmbiosType029(smbiosStructureHeaderInfo, structureInfo.SmbiosVersion));
                        break;

                    case SmbiosStructure.OutOfBandRemote:
                        parseProperties.Add(new SmbiosType030(smbiosStructureHeaderInfo, structureInfo.SmbiosVersion));
                        break;

                    case SmbiosStructure.BootIntegrityServicesEntryPoint:
                        parseProperties.Add(new SmbiosType031(smbiosStructureHeaderInfo, structureInfo.SmbiosVersion));
                        break;

                    case SmbiosStructure.SystemBoot:
                        parseProperties.Add(new SmbiosType032(smbiosStructureHeaderInfo, structureInfo.SmbiosVersion));
                        break;

                    case SmbiosStructure.BitMemoryError64:
                        parseProperties.Add(new SmbiosType033(smbiosStructureHeaderInfo, structureInfo.SmbiosVersion));
                        break;

                    case SmbiosStructure.ManagementDevice:
                        parseProperties.Add(new SmbiosType034(smbiosStructureHeaderInfo, structureInfo.SmbiosVersion));
                        break;

                    case SmbiosStructure.ManagementDeviceComponent:
                        parseProperties.Add(new SmbiosType035(smbiosStructureHeaderInfo, structureInfo.SmbiosVersion));
                        break;

                    case SmbiosStructure.ManagementDeviceThresholdData:
                        parseProperties.Add(new SmbiosType036(smbiosStructureHeaderInfo, structureInfo.SmbiosVersion));
                        break;

                    case SmbiosStructure.MemoryChannel:
                        parseProperties.Add(new SmbiosType037(smbiosStructureHeaderInfo, structureInfo.SmbiosVersion));
                        break;

                    case SmbiosStructure.IpmiDevice:
                        parseProperties.Add(new SmbiosType038(smbiosStructureHeaderInfo, structureInfo.SmbiosVersion));
                        break;

                    case SmbiosStructure.SystemPowerSupply:
                        parseProperties.Add(new SmbiosType039(smbiosStructureHeaderInfo, structureInfo.SmbiosVersion));
                        break;

                    case SmbiosStructure.AdditionalInformation:
                        parseProperties.Add(new SmbiosType040(smbiosStructureHeaderInfo, structureInfo.SmbiosVersion));
                        break;

                    case SmbiosStructure.OnBoardDevicesExtended:
                        parseProperties.Add(new SmbiosType041(smbiosStructureHeaderInfo, structureInfo.SmbiosVersion));
                        break;

                    case SmbiosStructure.ManagementControllerHostInterface:
                        parseProperties.Add(new SmbiosType042(smbiosStructureHeaderInfo, structureInfo.SmbiosVersion));
                        break;

                    case SmbiosStructure.TpmDevice:
                        parseProperties.Add(new SmbiosType043(smbiosStructureHeaderInfo, structureInfo.SmbiosVersion));
                        break;

                    case SmbiosStructure.ProcessorAdditionalInformation:
                        parseProperties.Add(new SmbiosType044(smbiosStructureHeaderInfo, structureInfo.SmbiosVersion));
                        break;

                    case SmbiosStructure.Inactive:
                        parseProperties.Add(new SmbiosType126(smbiosStructureHeaderInfo, structureInfo.SmbiosVersion));
                        break;

                    case SmbiosStructure.EndOfTable:
                        parseProperties.Add(new SmbiosType127(smbiosStructureHeaderInfo, structureInfo.SmbiosVersion));
                        break;
                }
            }

            return parseProperties;
        }
    }
}
