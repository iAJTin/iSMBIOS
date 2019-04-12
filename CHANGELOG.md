# Changelog
All notable changes to this project will be documented in this file.

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

[1.0.3]: https://github.com/iAJTin/iSMBIOS/releases/tag/v1.0.3
[1.0.2]: https://github.com/iAJTin/iSMBIOS/releases/tag/v1.0.2
[1.0.1]: https://github.com/iAJTin/iSMBIOS/releases/tag/v1.0.1
[1.0.0]: https://github.com/iAJTin/iSMBIOS