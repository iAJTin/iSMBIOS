# Changelog
All notable changes to this project will be documented in this file.

## [1.1.5] - 

### Added




## [1.1.4] - 2020-08-25

### Added

- Adds support for System Management BIOS (SMBIOS) v3.4.0, includes:

      * Processor Information (Type 4):
        - SMBIOSCR00189: update the definition of Type 4 Processor Id for ARM64 CPUs
        - SMBIOSCR00191: add Socket LGA1200

      * System Slots (Type 9):
        - SMBIOSCR00193: add OCP NIC Prior to 3.0
        - SMBIOSCR00196: Slot Type extensions for PCIe Gen6 and beyond
        - SMBIOSCR00197: Add support for CXL 2.0 devices
        - SMBIOSCR00199: Add support for EDSFF slot types

      * Memory Device (Type 17):
        - SMBIOSCR00195: update description for Intel persistent memory device
        - SMBIOSCR00197: Add support for CXL 2.0 devices

- Adds support for retrieving **DMI** information for remote machines using **WMI**
  - **Currently in experimental mode, you can try to use it as it is implemented and comment if you find any problems**
   
- Please review the following document that indicates how to configure a remote computer to accept **WMI** calls
    
  [Connecting to WMI on a Remote Computer]

- Usage examples

        The DMI.Instance property now is mark as obsolete use DMI.CreateInstance() method instead
        If you want to connect to a remote machine fill in an instance of the DmiConnectOptions object and use it 
        as the argument of the DMI method.CreateInstance(optionsInstance).

        Example:

        // Returns same result as DMI.Instance
        DMI dmi = DMI.CreateInstance(); 

        // Connect to remote machine.
        DMI dmi = DMI.CreateInstance(
            new DmiConnectOptions
            {
                UserName = "username to use"  
                Password = "password to use", 
                MachineNameOrIpAddress = "target remote machine name or machine ip address"
            });

### Changed

- Library versions for this version
  
|Library|Version|Description|
|:------|:------|:----------|
|iTin.Core| **1.0.2** | Common calls |
|iTin.Core.Interop| 1.0.0 | Interop calls |
|iTin.Core.Hardware| 1.0.1 | Hardware Interop Calls |
|iTin.Core.Hardware.Specification.Dmi|**3.3.0.3**| DMI Specification Implementation |
|iTin.Core.Hardware.Specification.Smbios|**3.3.0.3**| SMBIOS Specification Implementation |
|iTin.Core.Hardware.Specification.Tpm|1.0.0| TPM Specification Implementation |

## [1.1.3] - 2020-03-06

### Fixed

- Fixed a bug in the DmiType 022 [Portable Battery] structure for versions equal to or greater than 2.1, which prevents the correct assignment of the **DesignVoltage** property due to an error in type conversion

- Fixed a bug in the DmiType 022 [Portable Battery] structure for versions equal to or greater than 2.1, which prevents the correct assignment of the **DesignCapacity** property due to an error in type conversion

- Fixed a bug in the DmiType 022 [Portable Battery] structure for versions equal to or greater than 2.1, which prevents the correct assignment of the **OemSpecific** property due to an error in type conversion

- Fixed a bug in the DmiType 000 [BIOS] structure for versions equal to or greater than 3.1, which prevents the correct assignment of the **BiosRomSize** property due to an error in type conversion

- Fixed a bug where the detection of **StructureVersion** for Type017 [Memory device], when the length of the structure is not a canonical length, such as windows running virtualized in parallels on a mac

### Changed

- Library versions for this version
  
|Library|Version|Description|
|:------|:------|:----------|
|iTin.Core| 1.0.1 | Common calls |
|iTin.Core.Interop| 1.0.0 | Interop calls |
|iTin.Core.Hardware| 1.0.1 | Hardware Interop Calls |
|iTin.Core.Hardware.Specification.Dmi|3.3.0.1| DMI Specification Implementation |
|iTin.Core.Hardware.Specification.Smbios|3.3.0.2| SMBIOS Specification Implementation |
|iTin.Core.Hardware.Specification.Tpm|1.0.0| TPM Specification Implementation |

## [1.1.2] - 2020-02-15

### Added

- Adds support for System Management BIOS (SMBIOS) v3.4.0a (Preliminary version), includes:

      * Processor Information (Type 4)::
        - SMBIOSCR00190: add Socket LGA4189

      * System Slots (Type 9):
        - SMBIOSCR00186: add PCI Express Gen 5 and U.2 values
        - SMBIOSCR00188: add OCP NIC 3.0 values

      * Memory Device (Type 17):
        - SMBIOSCR00187: add new memory device types (DDR5, LPDDR5)

- Adds **SmbiosVersion** property to **DMI** object.

- Adds **ImplementedVersion** property to **DmiClasses**, indicates which structure version the manufacturer has implemented for a version of smbios.

- SMBIOS 3.4.0a (preliminary version) pdf file to Documents folder. 

### Changed

- Typographic errors. Renames properties names. 

- Adds descriptive code help. I Tried to adds a help most descriptive for the properties keys. 
 
  - The image below shows an example.

    ![Help.png][help] 

- Library versions for this version
  
|Library|Version|Description|
|:------|:------|:----------|
|iTin.Core| 1.0.1 | Common calls |
|iTin.Core.Interop| 1.0.0 | Interop calls |
|iTin.Core.Hardware| 1.0.1 | Hardware Interop Calls |
|iTin.Core.Hardware.Specification.Dmi|3.3.0.1| DMI Specification Implementation |
|iTin.Core.Hardware.Specification.Smbios|3.3.0.1| SMBIOS Specification Implementation |
|iTin.Core.Hardware.Specification.Tpm|1.0.0| TPM Specification Implementation |

## [1.1.1] - 2019-10-20

### Added

- Adds support for System Management BIOS (SMBIOS) v3.3.0, includes:

      * System Slots (Type 9):
        - SMBIOSCR00184: add PCI Express Gen 4 values
        - SMBIOSCR00185: clarify bus number usage for PCI Express
      * Memory Device (Type 17):
        - SMBIOSCR00178: add new memory device type value (HBM) and new form factor value (Die)
        - SMBIOSCR00179: update the string for Intel persistent memory
      * Various:
        - SMBIOSCR00181: add support for RISC-V processors, add structure type 44 (processor-additional information)
        - SMBIOSCR00183: add support for CXL Flexbus

### Changed

- Library versions for this version
  
|Library|Version|Description|
|:------|:------|:----------|
|iTin.Core| 1.0.0 | Common calls |
|iTin.Core.Interop| 1.0.0 | Interop calls |
|iTin.Core.Hardware| 1.0.0 | Hardware Interop Calls |
|iTin.Core.Hardware.Specification.Dmi|3.3.0.0| DMI Specification Implementation |
|iTin.Core.Hardware.Specification.Smbios|3.3.0.0| SMBIOS Specification Implementation |
|iTin.Core.Hardware.Specification.Tpm|1.0.0| TPM Specification Implementation |

## [1.1.0] - 2019-09-02

### Added

- **iTin.Core.Interop**: Adds binary compability with iEEDID, iCPUID, iScreen (comming soon)
  - Many structures, enumerations, win32 native methods have been added to project, for video cards, video modes, monitors, storage, etc ...

- Minor changes. 

### Changed

- **iTin.Core.Hardware**: 
  - Due to a problem with duplicate properties of the same type, the data type for storing the properties has been changed.

## [1.0.9] - 2019-08-28

### Added

- Added **iSMBIOS.ConsoleAppCore** netcoreapp console app project. 

      \root
        - lib
          - iTin.Core             
            - iTin.Core                                [Common Calls] 
            - iTin.Core.Interop                        [Interop Calls]
          - iTin.Core.Hardware    
            - iTin.Core.Hardware                       [Hardware Interop Calls]
          - iTin.Core.Hardware.Specification   
            - iTin.Core.Hardware.Specification.Dmi     [DMI Specification Implementation] 
            - iTin.Core.Hardware.Specification.Smbios  [SMBIOS Specification Implementation] 
            - iTin.Core.Hardware.Specification.Tpm     [TPM Specification Implementation] 
        - test
            - iSMBIOS.ConsoleApp                       [Console Test App]
            - iSMBIOS.ConsoleAppCore                   [NetCoreApp Console Test App]

- Minor changes. 

### Changed
- The solution has been migrated to **.NetStandard**.

  - The supported targets are:

        .NetFramework > = 4.5
        .NetStandard > = 2.0
        .NetCoreapp > = 2.0

## [1.0.8] - 2019-08-23

### Added
- Added **iTin.Core.Hardware.Specification.Smbios** project for **SMBIOS** calls. 
 
  - Implements the fully specification(s).
  
  - Now you can directly access the SMBIOS properties, to do this make the following call.

        var smbios = SMBIOS.Instance.ImplementedStructures;

- Added **iTin.Core.Hardware.Specification.Dmi** project for **DMI** calls.

  - Simplify access to properties, that is, it is sometimes possible for the specification to define a property for a specific version, and in another version add a new property that extends the previous one, the **Smbios library**, will return both properties separately     each with its own corresponding key, however the **Dmi library** with a single key will return the value of the property either normal or extended.

        Example:
        SmbiosType000 [BIOS Information], contains BIOS ROM Size and Extended BIOS ROM Size properties if your version allows.

        · Smbios will have both properties available:
          > SmbiosProperty.Bios.BiosRomSize
          > SmbiosProperty.Bios.ExtendedBiosRomSize

        · Dmi will have one property available:
          > DmiProperty.Bios.BiosRomSize
    
- Added **iTin.Core.Hardware.Specification.Tpm** project. 
    - Includes TPM (Trusted Platform Module), used in SmbiosType043 [TPM Device] class.

- Minor changes. 

### Changed
- Solution structure, prepare solution structure to add future new specifications.

      \root
        - lib
          - iTin.Core             
            - iTin.Core                                [Common Calls] 
            - iTin.Core.Interop                        [Interop Calls]
          - iTin.Core.Hardware    
            - iTin.Core.Hardware                       [Hardware Interop Calls]
          - iTin.Core.Hardware.Specification   
            - iTin.Core.Hardware.Specification.Dmi     [DMI Specification Implementation] 
            - iTin.Core.Hardware.Specification.Smbios  [SMBIOS Specification Implementation] 
            - iTin.Core.Hardware.Specification.Tpm     [TPM Specification Implementation] 
        - test
            - iSMBIOS.ConsoleApp                       [Console Test App]

- Assemblies with strong naming.

### Removed
- Unused variables.

## [1.0.7] - 2019-08-13

### Changed
- Changes nuget package for work in release mode.

## [1.0.6] - 2019-04-30 

### Changed
- Type 0 - BIOS Information structure
  - Unified the BIOS Rom Size and Extended BIOS Rom Size properties in the Rom Size BIOS property.
  - Modified the property BIOS Rom Size Unit to display values in order of KB.

- Type 1 - System Information structure
  - Modified the UUID property for start with '\{' and end with '\}'.
    - Example:
    
          Before
           7DFF2AF0-F6B9-4946-9AF6-4E10B59D5106

          After
           {7DFF2AF0-F6B9-4946-9AF6-4E10B59D5106}

- Minor changes.

### Fixed
- Type 4 - Processor structure
  - Fix an error in the Processor structure. Now the Voltage property returns the correct value.

## [1.0.5] - 2019-04-25
- Equals to v1.0.4 but without errors in nuget package.

## 1.0.4 - 2019-04-25

### Added
- Added **iTin.Core.Interop** project for interop calls.
- The **GetProperty** method was added in the class **DmiClass**, to directly recover a property, this allows us to consider a specification as a bag of consultable properties, 
for more information, please see how to use it in the example project. On the other hand later when there are more implemented specifications the use of the **DeviceProperty** type will allow us to and consult properties in different "bags".
- Minor changes.

### Changed
- Solution structure, prepare solution structure to add future new specifications.

      \root
        - lib
          - iTin.Core             
            - iTin.Core                         [Common Calls] 
            - iTin.Core.Interop                 [Interop Calls]
          - iTin.Core.Hardware    
            - iTin.Core.Hardware                [Hardware Interop Calls]
            - iTin.Core.Hardware.Specification  [Hardware Specification(s) Implementation(s)] 
        - test
            - iSMBIOS.ConsoleApp                [Console Test App]

### Removed
- **DeviceProperty** data type. This type of data is not going to be eliminated but its use will change, later it can be used as a receiver of the different types of data returned by the different specifications.

## [1.0.3] - 2019-04-11

### Added
- Added support for Type 43 [TPM Device].
- Added native interop functions for handle the firmware tables.
- Now first we try to get the BIOS data through a native call, if this fails, the call will be made through **WMI**.
- Added two new methods to **DmiStructureCollection** class that allow you to consult a property directly. For more information, please see GetProperty and GetProperties.
- Minor changes.

## [1.0.2] - 2019-04-03

### Added
- This CHANGELOG file.
- Memory Technology field to Structure Type 17 [Memory Device].

### Changed
- Full support for Structure Type 42 [Management Controller Host Interface]. 
- Rewrite KnownDmiProperty files (uses expression-body syntax) implies remove 1000 lines aprox.

### Fixed
- Fixes an error that occurs when trying to retrieve the ExtendedMaximumCapacity field of structure 16 [Physical Memory Array] 
  when running on a virtualized computer with Parallels (MacOS).

## [1.0.1] - 2019-03-29
### Fixed
- Fix crash caused by IntExtension from [@DexterWoo](https://github.com/DexterWoo).

## [1.0.0] - 2018-12-29
### Added
- Create project and first commit

[1.1.5]: https://github.com/iAJTin/iSMBIOS/releases/tag/v1.1.5
[1.1.4]: https://github.com/iAJTin/iSMBIOS/releases/tag/v1.1.4
[1.1.3]: https://github.com/iAJTin/iSMBIOS/releases/tag/v1.1.3
[1.1.2]: https://github.com/iAJTin/iSMBIOS/releases/tag/v1.1.2
[1.1.1]: https://github.com/iAJTin/iSMBIOS/releases/tag/v1.1.1
[1.1.0]: https://github.com/iAJTin/iSMBIOS/releases/tag/v1.1.0
[1.0.9]: https://github.com/iAJTin/iSMBIOS/releases/tag/v1.0.9
[1.0.8]: https://github.com/iAJTin/iSMBIOS/releases/tag/v1.0.8
[1.0.7]: https://github.com/iAJTin/iSMBIOS/releases/tag/v1.0.7
[1.0.6]: https://github.com/iAJTin/iSMBIOS/releases/tag/v1.0.6
[1.0.5]: https://github.com/iAJTin/iSMBIOS/releases/tag/v1.0.5
[1.0.3]: https://github.com/iAJTin/iSMBIOS/releases/tag/v1.0.3
[1.0.2]: https://github.com/iAJTin/iSMBIOS/releases/tag/v1.0.2
[1.0.1]: https://github.com/iAJTin/iSMBIOS/releases/tag/v1.0.1
[1.0.0]: https://github.com/iAJTin/iSMBIOS

[help]: ./assets/help.png "help"
[Connecting to WMI on a Remote Computer]: https://docs.microsoft.com/es-es/windows/win32/wmisdk/connecting-to-wmi-on-a-remote-computer

