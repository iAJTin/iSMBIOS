# Changelog
All notable changes to this project will be documented in this file.

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

[1.0.9]: https://github.com/iAJTin/iSMBIOS/releases/tag/v1.0.9
[1.0.8]: https://github.com/iAJTin/iSMBIOS/releases/tag/v1.0.8
[1.0.7]: https://github.com/iAJTin/iSMBIOS/releases/tag/v1.0.7
[1.0.6]: https://github.com/iAJTin/iSMBIOS/releases/tag/v1.0.6
[1.0.5]: https://github.com/iAJTin/iSMBIOS/releases/tag/v1.0.5
[1.0.3]: https://github.com/iAJTin/iSMBIOS/releases/tag/v1.0.3
[1.0.2]: https://github.com/iAJTin/iSMBIOS/releases/tag/v1.0.2
[1.0.1]: https://github.com/iAJTin/iSMBIOS/releases/tag/v1.0.1
[1.0.0]: https://github.com/iAJTin/iSMBIOS
