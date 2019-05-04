# Changelog
All notable changes to this project will be documented in this file.

## [1.0.6] - 

### Changed
- Type 0 - BIOS Information structure
  - Unify the BIOS Rom Size and Extended BIOS Rom Size properties in the Rom Size BIOS property.
  - Modify the property BIOS Rom Size Unit to display values in order of KB.

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
- Added **iTin.Core.Interop** project for interop calls 
- The **GetProperty** method was added in the class **DmiClass**, to directly recover a property, this allows us to consider a specification as a bag of consultable properties, 
for more information, please see how to use it in the example project. On the other hand later when there are more implemented specifications the use of the **DeviceProperty** type will allow us to and consult properties in different "bags".
- Minor changes.

### Changed
- Solution structure, prepare solution structure to add future new specifications.

      \root
        - lib
          - iTin.Core             
            - iTin.Core                         [common calls] 
            - iTin.Core.Interop                 [interop calls]
          - iTin.Core.Hardware    
            - iTin.Core.Hardware                [hardware interop calls]
            - iTin.Core.Hardware.Specification  [hardware specification(s) implementation(s)] 
        - test
            - iSMBIOS.ConsoleApp                [console test app]

### Removed
- **DeviceProperty** data type. This type of data is not going to be eliminated but its use will change, later it can be used as a receiver of the different types of data returned by the different specifications

## [1.0.3] - 2019-04-11

### Added
- Added support for Type 43 [TPM Device].
- Added native interop functions for handle the firmware tables.
- Now first we try to get the BIOS data through a native call, if this fails, the call will be made through **WMI**.
- Added two new methods to **DmiStructureCollection** class that allow you to consult a property directly. For more information, please see GetProperty and GetProperties.
- Minor changes.

## [1.0.2] - 2019-04-03

### Added
- This CHANGELOG file
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

[1.0.5]: https://github.com/iAJTin/iSMBIOS/releases/tag/v1.0.5
[1.0.3]: https://github.com/iAJTin/iSMBIOS/releases/tag/v1.0.3
[1.0.2]: https://github.com/iAJTin/iSMBIOS/releases/tag/v1.0.2
[1.0.1]: https://github.com/iAJTin/iSMBIOS/releases/tag/v1.0.1
[1.0.0]: https://github.com/iAJTin/iSMBIOS
