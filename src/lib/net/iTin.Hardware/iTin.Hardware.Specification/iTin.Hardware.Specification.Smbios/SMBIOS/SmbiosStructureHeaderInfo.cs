
namespace iTin.Hardware.Specification.Smbios
{
    using iTin.Core.Helpers;

    /// <summary>
    /// Represents the <b>Header</b> structure contained in the initial four bytes of each <see cref="SMBIOS"/> structure.
    /// </summary>
    public class SmbiosStructureHeaderInfo
    {
        #region constructor/s

        #region [internal] SmbiosStructureHeaderInfo(byte[]): Initializes a new instance of the class
        /// <summary>
        /// Initializes a new instance of the <see cref="SmbiosStructureHeaderInfo"/> class.
        /// </summary>
        /// <param name="rawData">The raw data.</param>
        internal SmbiosStructureHeaderInfo(byte[] rawData)
        {
            StructureType = (SmbiosStructure)rawData[0x00];
            Length = rawData[0x01];
            Handle = LogicHelper.Word(rawData[0x02], rawData[0x03]);
            RawData = rawData;
        }
        #endregion

        #endregion

        #region public properties

        #region public (int) Length: Gets the length of the formatted area of the current SMBIOS structure
        /// <summary>
        /// Gets the length of the formatted area of the current <see cref="SMBIOS"/> structure.
        /// </summary>
        /// <value>
        /// Length of the current <see cref="SMBIOS"/> structure.
        /// </value>
        /// <remarks>
        /// Specifies the length of the formatted area of the current structure. 
        /// Starting at position 0, the length of the formatted zone of strings is not taken into account.
        /// </remarks>
        public int Length { get; }
        #endregion

        #region public (int) Handle: Gets the handle of the current structure
        /// <summary>
        /// Gets the handle of the current structure.
        /// </summary>
        /// <value>
        /// Handle of the current structure.
        /// </value>
        public int Handle { get; }
        #endregion

        #region public (byte[]) RawData: Gets an array with the raw data
        /// <summary>
        /// Gets an array with the raw data.
        /// </summary>
        /// <value>
        /// Array with raw data.
        /// </value>
        public byte[] RawData { get; }
        #endregion

        #region public (SmbiosStructure) StructureType: Gets the length of the formatted area of the current SMBIOS structure
        /// <summary>
        /// Gets the current <see cref="SMBIOS"/> structure type.
        /// </summary>
        /// <value>
        /// One of the <see cref="SmbiosStructure"/> values representing the current struct
        /// </value>
        public SmbiosStructure StructureType { get; }
        #endregion

        #region [public] (SmbiosStructureVersion) StructureVersion: Gets the implemented version of this SMBIOS structure
        /// <summary>
        /// Gets the implemented version of this <b>SMBIOS</b> structure.
        /// </summary>
        /// <value>
        /// One of the values of the <see cref="SmbiosStructureVersion"/> enumeration that indicates the implemented version of this <b>SMBIOS</b> structure.
        /// </value>
        public SmbiosStructureVersion StructureVersion
        {
            get
            {
                var result = SmbiosStructureVersion.Unknown;

                switch (StructureType)
                {
                    #region Type000 [BIOS Information]

                    case SmbiosStructure.Bios:
                    {
                        if (Length >= 0x19)
                        {
                            result = SmbiosStructureVersion.v31;
                        }
                        else if (Length >= 0x13 && Length <= 0x18)
                        {
                            result = SmbiosStructureVersion.v24;
                        }
                        else if (Length <= 0x0b)
                        {
                            result = SmbiosStructureVersion.v20;
                        }

                        break;
                    }

                    #endregion

                    #region Type001 [System Information]

                    case SmbiosStructure.System:
                    {
                        if (Length >= 0x1a)
                        {
                            result = SmbiosStructureVersion.v24;
                        }
                        else if (Length >= 0x09 && Length <= 0x19)
                        {
                            result = SmbiosStructureVersion.v24;
                        }
                        else if (Length <= 0x08)
                        {
                            result = SmbiosStructureVersion.v20;
                        }

                        break;
                    }

                    #endregion

                    #region Type002 [Baseboard (or Module) Information]

                    case SmbiosStructure.BaseBoard:
                    {
                        if (Length >= 0x08)
                        {
                            result = SmbiosStructureVersion.Latest;
                        }

                        break;
                    }

                    #endregion

                    #region Type003 [System Enclosure or Chassis]

                    case SmbiosStructure.SystemEnclosure:
                    {
                        var n = 0;
                        var m = 0;
                        
                        if (Length >= 0x14)
                        {
                            n = RawData[0x13];
                        }

                        if (Length >= 0x15)
                        {
                            m = RawData[0x14];
                        }

                        var nm = n * m;
                        if (nm != 0 && Length > 0x18)
                        {
                            result = SmbiosStructureVersion.v27;
                        }
                        else if (Length >= 0x0e && Length <= 0x17)
                        {
                            result = SmbiosStructureVersion.v23;
                        }
                        else if (Length >= 0x0a && Length <= 0x0d)
                        {
                            result = SmbiosStructureVersion.v21;
                        }
                        else if (Length <= 0x09)
                        {
                            result = SmbiosStructureVersion.v20;
                        }

                        break;
                    }

                    #endregion

                    #region Type004 [Processor Information]

                    case SmbiosStructure.Processor:
                    {
                        if (Length >= 0x2b)
                        {
                            result = SmbiosStructureVersion.v30;
                        }
                        else if (Length >= 0x29 && Length <= 0x2b)
                        {
                            result = SmbiosStructureVersion.v26;
                        }
                        else if (Length >= 0x24 && Length <= 0x28)
                        {
                            result = SmbiosStructureVersion.v25;
                        }
                        else if (Length >= 0x22 && Length <= 0x23)
                        {
                            result = SmbiosStructureVersion.v23;
                        }
                        else if (Length >= 0x1b && Length <= 0x21)
                        {
                            result = SmbiosStructureVersion.v21;
                        }
                        else if (Length <= 0x1a)
                        {
                            result = SmbiosStructureVersion.v20;
                        }

                        break;
                    }

                    #endregion

                    #region Type005 [Memory Controller Information (Obsolete)]

                    case SmbiosStructure.MemoryController:
                    {
                        byte x = 0;

                        if (Length >= 0x0f)
                        {
                            x = RawData[0x0e];
                        }

                        if (Length >= 0x10 + 2 * x)
                        {
                            result = SmbiosStructureVersion.v21;
                        }
                        else
                        {
                            result = SmbiosStructureVersion.v20;
                        }

                        break;
                    }

                    #endregion

                    #region Type006 [Memory Module Information (Obsolete)]

                    case SmbiosStructure.MemoryModule:
                    {
                        if (Length <= 0x0c)
                        {
                            result = SmbiosStructureVersion.Latest;
                        }

                        break;
                    }

                    #endregion

                    #region Type007 [Cache Information]

                    case SmbiosStructure.Cache:
                    {
                        if (Length == 0x1b)
                        {
                            result = SmbiosStructureVersion.v31;
                        }
                        else if (Length == 0x13)
                        {
                            result = SmbiosStructureVersion.v21;
                        }
                        else if (Length <= 0x0f)
                        {
                            result = SmbiosStructureVersion.v20;
                        }

                        break;
                    }

                    #endregion

                    #region Type008 [Port Connector Information]

                    case SmbiosStructure.PortConnector:
                    {
                        if (Length == 0x09)
                        {
                            result = SmbiosStructureVersion.Latest;
                        }

                        break;
                    }

                    #endregion

                    #region Type009 [Slot Information]

                    case SmbiosStructure.SystemSlots:
                    {
                        if (Length > 0x12)
                        {
                            result = SmbiosStructureVersion.v32;

                            byte n = RawData[0x12];
                            byte groupsBytes = (byte)(5 * n);
                                
                            if (Length > 0x18 + groupsBytes)
                            {
                                result = SmbiosStructureVersion.v35;
                            }
                            else if (Length > 0x14 + groupsBytes)
                            {
                                result = SmbiosStructureVersion.v34;
                            }
                        }
                        else if (Length == 0x11)
                        {
                            result = SmbiosStructureVersion.v26;
                        }
                        else if (Length == 0x0d)
                        {
                            result = SmbiosStructureVersion.v21;
                        }
                        else if (Length == 0x0c)
                        {
                            result = SmbiosStructureVersion.v20;
                        }

                        break;
                    }

                    #endregion

                    #region Type010 [On Board Devices (Obsolete)]

                    case SmbiosStructure.OnBoardDevices:
                    {
                        if (Length > 0x05)
                        {
                            result = SmbiosStructureVersion.Latest;
                        }

                        break;
                    }

                    #endregion

                    #region Type011 [OEM Strings]

                    case SmbiosStructure.OemStrings:
                    {
                        if (Length == 0x05)
                        {
                            result = SmbiosStructureVersion.Latest;
                        }

                        break;
                    }

                    #endregion

                    #region Type012 [System Configuration Options]

                    case SmbiosStructure.SystemConfigurationOptions:
                    {
                        if (Length == 0x05)
                        {
                            result = SmbiosStructureVersion.Latest;
                        }

                        break;
                    }

                    #endregion

                    #region Type013 [BIOS Language Information]

                    case SmbiosStructure.BiosLanguage:
                    {
                        if (Length == 0x16)
                        {
                            result = SmbiosStructureVersion.v20;
                        }

                        break;
                    }

                    #endregion

                    #region Type014 [Group Associations]

                    case SmbiosStructure.GroupAssociations:
                    {
                        if (Length >= 0x05)
                        {
                            result = SmbiosStructureVersion.Latest;
                        }

                        break;
                    }

                    #endregion

                    #region Type015 [System Event Log]

                    case SmbiosStructure.SystemEventLog:
                    {
                        if (Length > 0x15)
                        {
                            result = SmbiosStructureVersion.v21;
                        }
                        else if (Length == 0x11)
                        {
                            result = SmbiosStructureVersion.v20;
                        }

                        break;
                    }

                    #endregion

                    #region Type016 [Physical Memory Array]

                    case SmbiosStructure.PhysicalMemoryArray:
                    {
                        if (Length == 0x17)
                        {
                            result = SmbiosStructureVersion.v27;
                        }
                        else if (Length == 0x0f)
                        {
                            result = SmbiosStructureVersion.v21;
                        }

                        break;
                    }

                    #endregion

                    #region Type017 [Memory Device]

                    case SmbiosStructure.MemoryDevice:
                    {
                        if (Length > 0x54)
                        {
                            result = SmbiosStructureVersion.v33;
                        }
                        if (Length > 0x28 && Length <= 0x54)
                        {
                            result = SmbiosStructureVersion.v32;
                        }
                        else if (Length > 0x22 && Length <= 0x28)
                        {
                            result = SmbiosStructureVersion.v28;
                        }
                        else if (Length > 0x1c && Length <= 0x22)
                        {
                            result = SmbiosStructureVersion.v27;
                        }
                        else if (Length > 0x1b && Length <= 0x1c)
                        {
                            result = SmbiosStructureVersion.v26;
                        }
                        else if (Length > 0x15 && Length <= 0x1b)
                        {
                            result = SmbiosStructureVersion.v23;
                        }
                        else if (Length <= 0x15)
                        {
                            result = SmbiosStructureVersion.v21;
                        }

                        break;
                    }

                    #endregion

                    #region Type018 [32-Bit Memory Error Information]

                    case SmbiosStructure.BitMemoryError32:
                    {
                        if (Length == 0x17)
                        {
                            result = SmbiosStructureVersion.v21;
                        }

                        break;
                    }

                    #endregion

                    #region Type019 [Memory Array Mapped Address]

                    case SmbiosStructure.MemoryArrayMappedAddress:
                    {
                        if (Length == 0x1f)
                        {
                            result = SmbiosStructureVersion.v27;
                        }
                        else if (Length == 0x0f)
                        {
                            result = SmbiosStructureVersion.v21;
                        }

                        break;
                    }

                    #endregion

                    #region Type020 [Memory Device Mapped Address]

                    case SmbiosStructure.MemoryDeviceMappedAddress:
                    {
                        if (Length == 0x23)
                        {
                            result = SmbiosStructureVersion.v27;
                        }
                        else if (Length == 0x13)
                        {
                            result = SmbiosStructureVersion.v21;
                        }

                        break;
                    }

                    #endregion

                    #region Type021 [Built-in Pointing Device]

                    case SmbiosStructure.BuiltInPointingDevice:
                    {
                        if (Length == 0x07)
                        {
                            result = SmbiosStructureVersion.v21;
                        }

                        break;
                    }

                    #endregion

                    #region Type022 [Portable Battery]

                    case SmbiosStructure.PortableBattery:
                    {
                        if (Length == 0x1a)
                        {
                            result = SmbiosStructureVersion.v22;
                        }
                        else if (Length == 0x11)
                        {
                            result = SmbiosStructureVersion.v21;
                        }

                        break;
                    }

                    #endregion

                    #region Type023 [System Reset]

                    case SmbiosStructure.SystemReset:
                    {
                        if (Length == 0x0d)
                        {
                            result = SmbiosStructureVersion.Latest;
                        }

                        break;
                    }

                    #endregion

                    #region Type024 [Hardware Security]

                    case SmbiosStructure.HardwareSecurity:
                    {
                        if (Length == 0x05)
                        {
                            result = SmbiosStructureVersion.Latest;
                        }

                        break;
                    }

                    #endregion

                    #region Type025 [System Power Controls]

                    case SmbiosStructure.SystemPowerControls:
                    {
                        if (Length == 0x09)
                        {
                            result = SmbiosStructureVersion.Latest;
                        }

                        break;
                    }

                    #endregion

                    #region Type026 [Voltage Probe]

                    case SmbiosStructure.VoltageProbe:
                    {
                        if (Length >= 0x14)
                        {
                            result = SmbiosStructureVersion.Latest;
                        }

                        break;
                    }

                    #endregion

                    #region Type027 [Cooling Device]

                    case SmbiosStructure.CoolingDevice:
                        {
                            if (Length == 0x0f)
                            {
                                result = SmbiosStructureVersion.v27;
                            }
                            else if (Length == 0x0d)
                            {
                                result = SmbiosStructureVersion.v22;
                            }

                            break;
                        }

                    #endregion

                    #region Type028 [Temperature Probe]

                    case SmbiosStructure.TemperatureProbe:
                    {
                        if (Length >= 0x14)
                        {
                            result = SmbiosStructureVersion.Latest;
                        }

                        break;
                    }

                    #endregion

                    #region Type029 [Electrical Current Probe]

                    case SmbiosStructure.ElectricalCurrentProbe:
                    {
                        if (Length >= 0x14)
                        {
                            result = SmbiosStructureVersion.Latest;
                        }

                        break;
                    }

                    #endregion

                    #region Type030 [Out-of-Band Remote Access]

                    case SmbiosStructure.OutOfBandRemote:
                    {
                        if (Length == 0x06)
                        {
                            result = SmbiosStructureVersion.Latest;
                        }

                        break;
                    }

                    #endregion

                    #region Type031 [Boot Integrity Services (BIS) Entry Point]

                    case SmbiosStructure.BootIntegrityServicesEntryPoint:
                    {
                        if (Length == 0x1e)
                        {
                            result = SmbiosStructureVersion.Latest;
                        }

                        break;
                    }

                    #endregion

                    #region Type032 [System Boot Information]

                    case SmbiosStructure.SystemBoot:
                    {
                        if (Length >= 0x0b)
                        {
                            result = SmbiosStructureVersion.Latest;
                        }

                        break;
                    }

                    #endregion

                    #region Type033 [64-Bit Memory Error Information]

                    case SmbiosStructure.BitMemoryError64:
                    {
                        if (Length == 0x1f)
                        {
                            result = SmbiosStructureVersion.Latest;
                        }

                        break;
                    }

                    #endregion

                    #region Type034 [Management Device]

                    case SmbiosStructure.ManagementDevice:
                    {
                        if (Length == 0x0b)
                        {
                            result = SmbiosStructureVersion.Latest;
                        }

                        break;
                    }

                    #endregion

                    #region Type035 [Management Device Component]

                    case SmbiosStructure.ManagementDeviceComponent:
                    {
                        if (Length == 0x0b)
                        {
                            result = SmbiosStructureVersion.Latest;
                        }

                        break;
                    }

                    #endregion

                    #region Type036 [Management Device Threshold Data]

                    case SmbiosStructure.ManagementDeviceThresholdData:
                    {
                        if (Length == 0x10)
                        {
                            result = SmbiosStructureVersion.Latest;
                        }

                        break;
                    }

                    #endregion

                    #region Type037 [Memory Channel]

                    case SmbiosStructure.MemoryChannel:
                    {
                        var n = 0;

                        if (Length >= 0x07)
                        {
                            n = RawData[0x06];
                        }

                        if (Length == 7 + 3 * n)
                        {
                            result = SmbiosStructureVersion.Latest;
                        }

                        break;
                    }

                    #endregion

                    #region Type038 [IPMI Device Information]

                    case SmbiosStructure.IpmiDevice:
                    {
                        if (Length >= 0x10)
                        {
                            result = SmbiosStructureVersion.Latest;
                        }

                        break;
                    }

                    #endregion

                    #region Type039 [System Power Supply]

                    case SmbiosStructure.SystemPowerSupply:
                    {
                        if (Length >= 0x10)
                        {
                            result = SmbiosStructureVersion.Latest;
                        }

                        break;
                    }

                    #endregion

                    #region Type040 [Additional Information]

                    case SmbiosStructure.AdditionalInformation:
                    {
                        if (Length >= 0x0b)
                        {
                            result = SmbiosStructureVersion.Latest;
                        }

                        break;
                    }

                    #endregion

                    #region Type041 [Onboard Devices Extended Information]

                    case SmbiosStructure.OnBoardDevicesExtended:
                    {
                        if (Length == 0x0b)
                        {
                            result = SmbiosStructureVersion.Latest;
                        }

                        break;
                    }

                    #endregion

                    #region Type042 [Management Controller Host Interface]

                    case SmbiosStructure.ManagementControllerHostInterface:
                    {
                        if (Length >= 0x0b)
                        {
                            result = SmbiosStructureVersion.Latest;
                        }

                        break;
                    }

                    #endregion

                    #region Type043 [TPM Device]

                    case SmbiosStructure.TpmDevice:
                    {
                        if (Length >= 0x1f)
                        {
                            result = SmbiosStructureVersion.Latest;
                        }

                        break;
                    }

                    #endregion

                    #region Type044 [Processor Additional Information]

                    case SmbiosStructure.ProcessorAdditionalInformation:
                    {
                        var y = 0;

                        if (Length >= 0x07)
                        {
                            y = RawData[0x06];
                        }

                        if (Length == 6 + y)
                        {
                            result = SmbiosStructureVersion.Latest;
                        }

                        break;
                    }

                    #endregion

                    #region Type045 [Firmware Inventory Information]

                    case SmbiosStructure.FirmwareInventoryInformation:
                    {
                        result = SmbiosStructureVersion.v35;
                        break;
                    }

                    #endregion

                    #region Type046 [String Property]

                    case SmbiosStructure.StringProperty:
                    {
                        if (Length >= 0x09)
                        {
                            result = SmbiosStructureVersion.v35;
                        }

                        break;
                    }

                    #endregion

                    #region Type126 [Inactive]

                    case SmbiosStructure.Inactive:
                    {
                        if (Length == 0x04)
                        {
                            result = SmbiosStructureVersion.Latest;
                        }

                        break;
                    }

                    #endregion

                    #region Type127 [End-Of-Table]

                    case SmbiosStructure.EndOfTable:
                    {
                        if (Length == 0x04)
                        {
                            result = SmbiosStructureVersion.Latest;
                        }

                        break;
                    }

                    #endregion
                }

                return result;
            }
        }
        #endregion

        #endregion

        #region public override methods

        #region [public] {override} (string) ToString(): Returns a string that represents this instance
        /// <summary>
        /// Returns a <see cref="string"/> that represents this instance.
        /// </summary>
        /// <returns>A <see cref="string"/> that represents this instance.</returns>
        /// <remarks>
        /// The <see cref="ToString()"/> method returns a string that includes the <see cref="StructureType"/> property, <see cref="Handle"/> y <see cref="Length"/>.
        /// </remarks>
        public override string ToString() => $"Type = {StructureType}, Handle = {Handle:X2}h, Length = {Length:X2}h, Version = {StructureVersion}";
        #endregion

        #endregion
    }
}
