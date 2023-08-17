# Changelog
All notable changes to this project will be documented in this file.

## 1.1.9 

### Added

### Changed


## [1.1.8] - 2023-08-17

### Added
 
- Added support for System Management BIOS (SMBIOS) v3.7.0, includes:

      * Processor Information (Type 4):
        - SMBIOSCR00222: Added new processor sockets
        - SMBIOSCR00224: Added new processor family
        – SMBIOSCR00225: Added new processor socket
        – SMBIOSCR00226: Added new processor sockets and updated link for LoongArch processor-specific data
        – SMBIOSCR00228: Added new processor sockets

      * Memory Device (Type 9):
        - SMBIOSCR00221: Modified CXL description and added CXL 3.0 support

      * Memory Device (Type 17):
        - SMBIOSCR00227: Added PMIC/RCD Manufacturer ID and Revision information

### Changed
 
 - Library versions for this version
  
    | Library | Version | Description |
    |:------|:------|:----------|
    | iTin.Core| **2.0.0.7** | Base library containing various extensions, helpers, common constants |
    | **iTin.Core.Hardware.Abstractions** | **1.0.0.0** | **Generic Common Hardware Abstractions** |
    | iTin.Core.Hardware.Common | **1.0.0.5** | Common Hardware Infrastructure |
    | iTin.Core.Hardware.Linux.Specification.Smbios | **1.0.0.2** | Linux Hardware Infrastructure |
    | iTin.Core.Hardware.MacOS.Specification.Smbios | **1.0.0.2** | MacOS Hardware Infrastructure |
    | iTin.Core.Hardware.Windows.Specification.Smbios | **1.0.0.2** | Windows Hardware Infrastructure |
    | iTin.Core.Interop.Shared | **1.0.0.4** | Generic Shared Interop Definitions |
    | iTin.Core.Interop.Windows.Specification.Smbios | **1.0.0.1** | Win32 Generic Interop Calls (SMBIOS) |
    | iTin.Hardware.Abstractions.Specification.Smbios | **1.0.0.3** | Generic Common Hardware Abstractions |
    | iTin.Hardware.Specification.Dmi | **3.3.0.7** | DMI Specification Implementation |
    | iTin.Hardware.Specification.Smbios | **3.3.0.7** | SMBIOS Specification Implementation |
    | iTin.Hardware.Specification.Tpm | **1.0.0.2** | TPM Specification Implementation |
    | iTin.Logging | **1.0.0.3** | Logging library |

## [1.1.7] - 2022-10-11

### Added
 
- Added support for System Management BIOS (SMBIOS) v3.6.0, includes:

      * Processor Information (Type 4):
        - SMBIOSCR00214: Added new processor sockets
        - SMBIOSCR00215: Added processor family ID for ARMv9
        – SMBIOSCR00218: Added new processor socket types
        – SMBIOSCR00219: Added "thread enabled" field

      * Memory Device (Type 17):
        - SMBIOSCR00220: Added HBM3

      * Various:
        - SMBIOSCR00217: Added LoongArch processor architecture

- Added support for **netstandard2.1** 
 
   - Add **SplitEnumerator** ref struct.
   
   - **ByteReader** class rewritten to work with **Span** in net core projects.

- Added sample project for **net60**

### Changed
 
- Unify calls to obtain change information from a remote or local computer, currently this functionality is only available for Windows systems,
  The logic of each platform is in its own assembly *iTin.Core.Hardware.**Target-System**.Specification.Smbios*.

  *Where:*

  **Target-System**, it can be *Linux*, *Windows* or *MacOS* and the platform independent logic is found in the 
  **iTin.Hardware.Abstractions.Specification.Smbios** assembly, so that from *SMBIOS* a call is made independent of the target platform and this 
  assembly has the responsibility of managing the final call to the platform destination.

 - Library versions for this version
  
    | Library | Version | Description |
    |:------|:------|:----------|
    | iTin.Core| **2.0.0.4** | Base library containing various extensions, helpers, common constants |
    | iTin.Core.Hardware.Common | **1.0.0.3** | Common Hardware Infrastructure |
    | iTin.Core.Hardware.Linux.Specification.Smbios | **1.0.0.1** | Linux Hardware Infrastructure |
    | iTin.Core.Hardware.MacOS.Specification.Smbios | **1.0.0.1** | MacOS Hardware Infrastructure |
    | iTin.Core.Hardware.Windows.Specification.Smbios | **1.0.0.1** | Windows Hardware Infrastructure |
    | iTin.Core.Interop.Shared | **1.0.0.2** | Generic Shared Interop Definitions |
    | iTin.Core.Interop.Windows.Specification.Smbios | **1.0.0.0** | Win32 Generic Interop Calls (SMBIOS) |
    | iTin.Hardware.Abstractions.Specification.Smbios | **1.0.0.2** | Generic Common Hardware Abstractions |
    | iTin.Hardware.Specification.Dmi| **3.3.0.6** | DMI Specification Implementation |
    | iTin.Hardware.Specification.Smbios| **3.3.0.6** | SMBIOS Specification Implementation |
    | iTin.Hardware.Specification.Tpm| 1.0.0.1 | TPM Specification Implementation |
    | iTin.Logging| **1.0.0.1** | Logging library |

## [1.1.6] - 2021-12-09

### Fixed

 - Fixes an issue that generates an exception when a property that returns an object of type QueryPropertyDictionaryResult not available.

### Added

- Added support for System Event Log structure.
 
- Added support for System Management BIOS (SMBIOS) v3.5.0, includes:

      * BIOS Information (Type 0):
        - SMBIOSCR00209: Added support for manufacturing mode
        - SMBIOSCR00210: Updated the definition of BIOS Starting Address Segment for UEFI systems

      * Processor Information (Type 4):
        - SMBIOSCR00205: Added processor socket (LGA4677)

      * System Slots (Type 9):
        - SMBIOSCR00202: Added support for slot height
        – SMBIOSCR00203: Errata: correct offsets

      * Built-in Pointing Device (Type 21):
        - SMBIOSCR00200: Added support for new Pointing Device interfaces

      * Built-in Pointing Device (Type 41):
        - SMBIOSCR00201: Added support for new Onboard Device Types
        – SMBIOSCR00204: Added note on how to describe multi-function devices

      * Firmware Inventory Information (Type 45, new):
        – SMBIOSCR00208: Added structure type for Firmware Inventory Information

      * String Property  (Type 46, new):
        – SMBIOSCR00211: Added structure for string properties

 - Library documentation
 
 - ```tools``` folder in solution root. Contains a script for update help md files.
 
 - Added support for **MacOS** (In progress...)
 
    Tested on:

    | macOS | Version |
    |:------|:------|
    | macOS Monterey | 12.0.1 |
    | Big Sur | 11.0.1 |
    | Catalina | 10.15.7 |
 
### Changed

 - Changed **```IResultGeneric```** interface. Changed **```Value```** property name by **```Result```** (for code clarify).
 
       This change may have implications in your final code, it is resolved by changing Value to Result

 - Updated result classes for support more scenaries.
 
 - Library versions for this version
  
    | Library | Version | Description |
    |:------|:------|:----------|
    | iTin.Core| **2.0.0.3** | Base library containing various extensions, helpers, common constants |
    | iTin.Core.Hardware.Common | **1.0.0.2** | Common Hardware Infrastructure |
    | iTin.Core.Hardware.Linux.Specification.Smbios | **1.0.0.0** | Linux Hardware Infrastructure |
    | iTin.Core.Hardware.MacOS.Specification.Smbios | **1.0.0.0** | MacOS Hardware Infrastructure |
    | iTin.Core.Hardware.Windows.Specification.Smbios | **1.0.0.0** | Windows Hardware Infrastructure |
    | iTin.Core.Interop.Shared | **1.0.0.1** | Generic Shared Interop Definitions |
    | iTin.Core.Interop.Windows.Specification.Smbios | **1.0.0.0** | Win32 Generic Interop Calls (SMBIOS) |
    | iTin.Hardware.Abstractions.Specification.Smbios | **1.0.0.1** | Generic Common Hardware Abstractions |
    | iTin.Hardware.Specification.Dmi| **3.3.0.5** | DMI Specification Implementation |
    | iTin.Hardware.Specification.Smbios| **3.3.0.5** | SMBIOS Specification Implementation |
    | iTin.Hardware.Specification.Tpm| 1.0.0.1 | TPM Specification Implementation |
    | iTin.Logging| 1.0.0.0 | Logging library |

## [1.1.5] - 2020-10-11

### Added

- Add new libraries and remove old libraries for compability with another packages (Win32 only and Cross-Platform)

- In order to unify the obtaining of one or more properties by directly consulting the structures, two new methods have been added to replace the existing ones.

    #### Examples:

    ##### Single property          

    ###### Before
                           
        DmiStructureCollection structures = DMI.CreateInstance().Structures;
        object biosVersion = structures.GetProperty(DmiProperty.Bios.BiosVersion);
        if (biosVersion! = null)
        {
            Console.WriteLine ($ @ "BIOS Version> {biosVersion}");
        }

    ###### Current Version
              
        DmiStructureCollection structures = DMI.CreateInstance().Structures;
        QueryPropertyResult biosVersion = structures.GetProperty (DmiProperty.Bios.BiosVersion);
        if (biosVersion.Success)
        {
            Console.WriteLine ($ @ "> BIOS Version> {biosVersion.Value.Value}");
        }

    ###### Where
          
        > Success
            true if current operation was executed successfully, otherwise false.
        
        > Value 
            If is success, contains an instance of PropertyItem containing property value (Value property) and property key (Key property)                
        
        > Errors
            If not success, contains a error collection, containing the query errors.


    ##### Multiple properties

    ###### Before
             
        DmiStructureCollection structures = DMI.CreateInstance().Structures;
        IDictionary<int, object> systemSlots = structures.GetProperties(DmiProperty.SystemSlots.SlotId);
        bool hasSystemSlots = systemSlots.Any();
        if (!hasSystemSlots)
        {
            Console.WriteLine($" > There is no system slots information structure in this computer");
        }
        else
        {
            foreach (KeyValuePair<int, object> systemSlot in systemSlots)
            {
                int element = systemSlot.Key;
                var property = ((IEnumerable<KeyValuePair<IPropertyKey, object>>) systemSlot.Value).FirstOrDefault();
                Console.WriteLine($@" System Slot ({element}) > {property.Value}");
            }
        }

    ###### Current Version
              
        DmiStructureCollection structures = DMI.CreateInstance().Structures;
        QueryPropertyCollectionResult systemSlotsQueryResult = structures.GetProperties(DmiProperty.SystemSlots.SlotDesignation);
        if (!systemSlotsQueryResult.Success)
        {
            Console.WriteLine($@" > Error(s)");
            Console.WriteLine($@"   {systemSlotsQueryResult.Errors.AsMessages().ToStringBuilder()}");
        }
        else
        {
            IEnumerable<PropertyItem> systemSlotsItems = systemSlotsQueryResult.Value.ToList();
            bool hasSystemSlotsItems = systemSlotsItems.Any();
            if (!hasSystemSlotsItems)
            {
                Console.WriteLine($@" > Sorry, The '{DmiProperty.SystemSlots.SlotId}' property has not implemented on this system");
            }
            else
            {
                int index = 0;
                foreach (var systemSlotItem in systemSlotsItems)
                {
                    Console.WriteLine($@" >  System Slot ({index}) > {systemSlotItem.Value}");
                    index++;
                }
            }
        }

    ###### Where
          
        > Success
            true if current operation was executed successfully, otherwise false.

        > Value 
            If is success, contains an instance of IEnumerable<PropertyItem> containing properties list, 
            on each item contains an instance of PropertyItem containing property value (Value property) 
            and property key (Key property)               

        > Errors
            If not success, contains a error collection, containing the query errors.

### Removed

- Removed **net45** and **netcoreapp** targets. Current supported targets, **net461** and **netstandard20**
   
- Libraries removed in this version

    |Library|Version|Description|
    |:------|:------|:----------|
    |iTin.Core.Interop| 1.0.0 | Interop calls |
    |iTin.Core.Hardware| 1.0.1 | Hardware Interop Calls |

### Changed

- Rename **iTin.Core.Harware.XXX** namespaces for **iTin.Harware.XXX** namespaces

- Library versions for this version

    |Library|Version|Description|
    |:------|:------|:----------|
    |iTin.Core| **2.0.0.1** | Base library containing various extensions, helpers, common constants |
    |iTin.Core.Hardware.Common| **1.0.0.1** | Generic Common Hardware Infrastructure |
    |iTin.Core.Hardware.Windows.Smbios| 1.0.0.0 | Win32 Generic Hardware Calls (SMBIOS) |
    |iTin.Core.Interop.Shared| 1.0.0.0 | Generic Shared Interop Definitions, Data Structures, Constants... |
    |iTin.Core.Interop.Windows.Smbios| 1.0.0.0 | Win32 Generic Interop Calls (SMBIOS)  |
    |iTin.Hardware.Specification.Dmi|**3.3.0.4**| DMI Specification Implementation |
    |iTin.Hardware.Specification.Smbios|**3.3.0.4**| SMBIOS Specification Implementation |
    |iTin.Hardware.Specification.Tpm|**1.0.0.1**| TPM Specification Implementation |
    |iTin.Logging|1.0.0.0| Logging library  |


## [1.1.4] - 2020-08-02

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

[1.1.9]: https://github.com/iAJTin/iSMBIOS/releases/tag/v1.1.9
[1.1.8]: https://github.com/iAJTin/iSMBIOS/releases/tag/v1.1.8
[1.1.7]: https://github.com/iAJTin/iSMBIOS/releases/tag/v1.1.7
[1.1.6]: https://github.com/iAJTin/iSMBIOS/releases/tag/v1.1.6
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
