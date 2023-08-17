
What is iSMBIOS?
================

iSMBIOS is a lightweight implementation that allows us to obtain the SMBIOS information. Currently only works on Windows.

This library implements DMTF Specification 3.7.0 version and olders versions

For more information, please see https://www.dmtf.org/standards/smbios


Changes in this version (v1.1.8)
================================

· Added
  -----

  - Added support for System Management BIOS (SMBIOS) v3.6.0, includes:

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

· Changed
  -------
 
 - Library versions for this version
  
   •———————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
   | Library                                           Version   Description                                                           |
   •———————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
   | iTin.Core                                         2.0.0.7   Base library containing various extensions, helpers, common constants |
   •———————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
   | iTin.Core.Hardware.Abstractions                   1.0.0.0   Generic Common Hardware Abstractions                                  |
   •———————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
   | iTin.Core.Hardware.Common                         1.0.0.5   Generic Common Hardware Infrastructure                                |
   •———————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
   | iTin.Core.Hardware.Linux.Specification.Smbios     1.0.0.2   Linux Hardware Infrastructure                                         |
   •———————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
   | iTin.Core.Hardware.MacOS.Specification.Smbios     1.0.0.2   MacOS Hardware Infrastructure                                         |
   •———————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
   | iTin.Core.Hardware.Windows.Specification.Smbios   1.0.0.2   Windows Hardware Infrastructure                                       |
   •———————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
   | iTin.Core.Interop.Shared                          1.0.0.4   Generic Shared Interop Definitions, Data Structures, Constants...     |
   •———————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
   | iTin.Core.Interop.Windows.Specification.Smbios    1.0.0.1   Win32 Generic Interop Calls (SMBIOS)                                  |
   •———————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
   | iTin.Hardware.Abstractions.Specification.Smbios   1.0.0.3   Generic Common Hardware Abstractions                                  |
   •———————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
   | iTin.Hardware.Specification.Dmi                   3.3.0.7   DMI Specification Implementation                                      |
   •———————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
   | iTin.Hardware.Specification.Smbios                3.3.0.7   SMBIOS Specification Implementation                                   |
   •———————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
   | iTin.Hardware.Specification.Tpm                   1.0.0.2   TPM Specification Implementation                                      |
   •———————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
   | iTin.Logging                                      1.0.0.3   Logging library                                                       |
   •———————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————•

v1.1.7
======

· Added
  -----

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

  - Added support for netstandard2.1 
 
  - Add SplitEnumerator ref struct.
   
  - ByteReader class rewritten to work with Span in net core projects.

- Added sample project for net60

· Changed
  -------
 
  - Unify calls to obtain change information from a remote or local computer, currently this functionality is only available for Windows systems,
    The logic of each platform is in its own assembly *iTin.Core.Hardware.**Target-System**.Specification.Smbios*.

    Where:

    Target-System, it can be Linux, Windows or MacOS and the platform independent logic is found in the 
    iTin.Hardware.Abstractions.Specification.Smbios assembly, so that from SMBIOS a call is made independent of the target platform and this 
    assembly has the responsibility of managing the final call to the platform destination.

 - Library versions for this version
  
   •———————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
   | Library                                           Version   Description                                                           |
   •———————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
   | iTin.Core                                         2.0.0.4   Base library containing various extensions, helpers, common constants |
   •———————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
   | iTin.Core.Hardware.Common                         1.0.0.3   Generic Common Hardware Infrastructure                                |
   •———————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
   | iTin.Core.Hardware.Linux.Specification.Smbios     1.0.0.1   Linux Hardware Infrastructure                                         |
   •———————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
   | iTin.Core.Hardware.MacOS.Specification.Smbios     1.0.0.1   MacOS Hardware Infrastructure                                         |
   •———————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
   | iTin.Core.Hardware.Windows.Specification.Smbios   1.0.0.1   Windows Hardware Infrastructure                                       |
   •———————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
   | iTin.Core.Interop.Shared                          1.0.0.2   Generic Shared Interop Definitions, Data Structures, Constants...     |
   •———————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
   | iTin.Core.Interop.Windows.Specification.Smbios    1.0.0.0   Win32 Generic Interop Calls (SMBIOS)                                  |
   •———————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
   | iTin.Hardware.Abstractions.Specification.Smbios   1.0.0.2   Generic Common Hardware Abstractions                                  |
   •———————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
   | iTin.Hardware.Specification.Dmi                   3.3.0.6   DMI Specification Implementation                                      |
   •———————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
   | iTin.Hardware.Specification.Smbios                3.3.0.6   SMBIOS Specification Implementation                                   |
   •———————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
   | iTin.Hardware.Specification.Tpm                   1.0.0.1   TPM Specification Implementation                                      |
   •———————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
   | iTin.Logging                                      1.0.0.1   Logging library                                                       |
   •———————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————•

v1.1.6
======

· Added
  -----

    - Added support for System Management BIOS (SMBIOS) v3.5.0.

    - Added support for System Event Log structure.

    - Added support for MacOS (In progress...)
 
      Tested on:
      •——————————————————————————•
      | macOS           Version  |
      •——————————————————————————•
      | macOS Monterey  12.0.1   |
      •——————————————————————————•
      | Big Sur         11.0.1   |
      •——————————————————————————•
      | Catalina        10.15.7  |
      •——————————————————————————•

    - Library documentation.

    - tools folder in solution root. Contains a script for update help md files.

· Changed
  -------

    - Changed IResultGeneric interface. Changed Value property name by Result (for code clarify).

      · This change may have implications in your final code, it is resolved by changing Value to Result

    - Update result classes for support more scenaries.

    - Library versions for this version

      •———————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
      | Library                                           Version   Description                                                           |
      •———————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
      | iTin.Core                                         2.0.0.3   Base library containing various extensions, helpers, common constants |
      •———————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
      | iTin.Core.Hardware.Common                         1.0.0.2   Generic Common Hardware Infrastructure                                |
      •———————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
      | iTin.Core.Hardware.Linux.Specification.Smbios     1.0.0.0   Linux Hardware Infrastructure                                         |
      •———————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
      | iTin.Core.Hardware.MacOS.Specification.Smbios     1.0.0.0   MacOS Hardware Infrastructure                                         |
      •———————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
      | iTin.Core.Hardware.Windows.Specification.Smbios   1.0.0.0   Windows Hardware Infrastructure                                       |
      •———————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
      | iTin.Core.Interop.Shared                          1.0.0.1   Generic Shared Interop Definitions, Data Structures, Constants...     |
      •———————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
      | iTin.Core.Interop.Windows.Specification.Smbios    1.0.0.0   Win32 Generic Interop Calls (SMBIOS)                                  |
      •———————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
      | iTin.Hardware.Abstractions.Specification.Smbios   1.0.0.1   Generic Common Hardware Abstractions                                  |
      •———————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
      | iTin.Hardware.Specification.Dmi                   3.3.0.5   DMI Specification Implementation                                      |
      •———————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
      | iTin.Hardware.Specification.Smbios                3.3.0.5   SMBIOS Specification Implementation                                   |
      •———————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
      | iTin.Hardware.Specification.Tpm                   1.0.0.1   TPM Specification Implementation                                      |
      •———————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
      | iTin.Logging                                      1.0.0.0   Logging library                                                       |
      •———————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————•

v1.1.5
======

· Added
  -----

    - Add new libraries and remove old libraries for compability with another packages (Win32 only and Cross-Platform).   
    - In order to unify the obtaining of one or more properties by directly consulting the structures, two new methods have been added to replace the existing ones.

    Examples:

        * Single property
          ---------------

            > Before
              ------
             
              DmiStructureCollection structures = DMI.CreateInstance().Structures;
              object biosVersion = structures.GetProperty(DmiProperty.Bios.BiosVersion);
              if (biosVersion! = null)
              {
                  Console.WriteLine ($ @ "BIOS Version> {biosVersion}");
              }

            > Current Version
              ---------------
              
              DmiStructureCollection structures = DMI.CreateInstance().Structures;
              QueryPropertyResult biosVersion = structures.GetProperty (DmiProperty.Bios.BiosVersion);
              if (biosVersion.Success)
              {
                  Console.WriteLine ($ @ "> BIOS Version> {biosVersion.Value.Value}");
              }

              Where:
          
                · Success: true if current operation was executed successfully, otherwise false.
                · Value: If is success, contains an instance of PropertyItem containing property value (Value property) and property key (Key property)                
                · Errors: If not success, contains a error collection, containing the query errors.


        * Multiple properties
          -------------------

            > Before
              ------
             
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

            > Current Version
              ---------------
              
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

              Where:
          
                · Success: true if current operation was executed successfully, otherwise false.
                · Value: If is success, contains an instance of IEnumerable<PropertyItem> containing properties list, on each item contains 
                         an instance of PropertyItem containing property value (Value property) and property key (Key property)               
                · Errors: If not success, contains a error collection, containing the query errors.

· Removed
  -------

    - Removed net45 and netcoreapp targets. Current supported targets, net461 and netstandard20

    - Libraries removed in this version

      •—————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
      | Library                                   Version   Description                                                         |
      •—————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
      | iTin.Core.Interop                         1.0.0.0   Interop calls                                                       |
      •—————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
      | iTin.Core.Hardware                        1.0.1.0   Hardware Interop Calls                                              |
      •—————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————•

· Changed
  -------
    - Rename iTin.Core.Harware.xxxxxx namespaces for iTin.Hardware.xxxx namespaces

    - Library versions for current version

      •———————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
      | Library                                  Version    Description                                                           |
      •———————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
      | iTin.Core                                2.0.0.1    Base library containing various extensions, helpers, common constants |
      •———————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
      | iTin.Core.Hardware.Common                1.0.0.1    Generic Common Hardware Infrastructure                                |
      •———————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
      | iTin.Core.Hardware.Windows.Smbios        1.0.0.0    Win32 Generic Hardware Calls (SMBIOS)                                 |
      •———————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
      | iTin.Core.Interop.Shared                 1.0.0.0    Generic Shared Interop Definitions, Data Structures, Constants...     |
      •———————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
      | iTin.Core.Interop.Windows.Smbios         1.0.0.0    Win32 Generic Interop Calls (SMBIOS)                                  |
      •———————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
      | iTin.Hardware.Specification.Dmi          3.3.0.4    DMI Specification Implementation                                      |
      •———————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
      | iTin.Hardware.Specification.Smbios       3.3.0.4    SMBIOS Specification Implementation                                   |
      •———————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
      | iTin.Hardware.Specification.Tpm          1.0.0.1    TPM Specification Implementation                                      |
      •———————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
      | iTin.Logging                             1.0.0.0    Logging library                                                       |
      •———————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————•


v1.1.4
======

Library versions.

    •———————————————————————————————————————————————————————————————————————————————————————•
    | Library                                  Version  Description                         |
    •———————————————————————————————————————————————————————————————————————————————————————•
    |iTin.Core                                 1.0.2.0	Common calls                        |
    •———————————————————————————————————————————————————————————————————————————————————————•
    |iTin.Core.Interop                         1.0.0.0	Interop calls                       |
    •———————————————————————————————————————————————————————————————————————————————————————•
    |iTin.Core.Hardware                        1.0.1.0	Hardware Interop Calls              |
    •———————————————————————————————————————————————————————————————————————————————————————•
    |iTin.Core.Hardware.Specification.Dmi      3.3.0.3	DMI Specification Implementation    |
    •———————————————————————————————————————————————————————————————————————————————————————•
    |iTin.Core.Hardware.Specification.Smbios   3.3.0.3	SMBIOS Specification Implementation |
    •———————————————————————————————————————————————————————————————————————————————————————•
    |iTin.Core.Hardware.Specification.Tpm      1.0.0.0	TPM Specification Implementation    |
    •———————————————————————————————————————————————————————————————————————————————————————•

Install via NuGet
=================

For more information, please see https://www.nuget.org/packages/iSMBIOS/


Usage
=====

 - Before

   Call DMI.Instance.Structures for getting all SMBIOS structures availables.

 - Now 

   The DMI.Instance property now is mark as obsolete use DMI.CreateInstance() method instead
   If you want to connect to a remote machine fill in an instance of the DmiConnectOptions object and use it 
   as the argument of the DMI method.CreateInstance(optionsInstance).
   
For more info, please see CHANGELOG file (https://github.com/iAJTin/iSMBIOS/blob/master/CHANGELOG.md).

Examples
--------

1. Gets and prints SMBIOS version.

        Console.WriteLine($@" SMBIOS Version > {DMI.CreateInstance().SmbiosVersion}");

2. Gets and prints all **SMBIOS** availables structures.

        DmiStructureCollection structures = DMI.CreateInstance().Structures;
        foreach (DmiStructure structure in structures)
        {
            Console.WriteLine($@" {(int)structure.Class:D3}-{structure.FriendlyClassName}");
 
            int totalStructures = structure.Elements.Count;
            if (totalStructures > 1)
            {
                Console.WriteLine($@"     > {totalStructures} structures");
            }
        }

3. Gets and prints the implemented SMBIOS structure version.

        DmiStructureCollection structures = DMI.CreateInstance().Structures;
        foreach (DmiStructure structure in structures)
        {
            Console.WriteLine($@" {(int)structure.Class:D3}-{structure.FriendlyClassName}");

            DmiClassCollection elements = structure.Elements;
            foreach (DmiClass element in elements)
            {
                Console.WriteLine($@"     > Version > {element.ImplementedVersion}");
            }
        }

4. Gets a single property directly.

        DmiStructureCollection structures = DMI.CreateInstance().Structures;
        QueryPropertyResult biosVersion = structures.GetProperty(DmiProperty.Bios.BiosVersion);
        if (biosVersion.Success)
        {
            Console.WriteLine($@" > BIOS Version > {biosVersion.Value.Value}");
        }

        QueryPropertyResult biosVendor = structures.GetProperty(DmiProperty.Bios.Vendor);
        if (biosVendor.Success)
        {
            Console.WriteLine($@" > BIOS Vendor > {biosVendor.Value.Value}");
        }

        QueryPropertyResult currentSpeed = structures.GetProperty(DmiProperty.Processor.CurrentSpeed);
        if (currentSpeed.Success)
        {
            Console.WriteLine($@" > Current Speed > {currentSpeed.Value.Value} {currentSpeed.Value.Key.PropertyUnit}");
        }

        QueryPropertyResult processorManufacturer = structures.GetProperty(DmiProperty.Processor.ProcessorManufacturer);
        if (processorManufacturer.Success)
        {
            Console.WriteLine($@" > Processor Manufacturer > {processorManufacturer.Value.Value}");
        }

5. Gets a property in multiple elements directly (Handle result as collection).

        // Requires that the Slot Information structure exists in your system
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

6. Gets a property in multiple elements directly (Handle result as dictionary).

        // Requires that the Slot Information structure exists in your system
        DmiStructureCollection structures = DMI.CreateInstance().Structures;
        QueryPropertyCollectionResult systemSlotsQueryResult = structures.GetProperties(DmiProperty.SystemSlots.SlotDesignation);
        var systemSlotsQueryDictionayResult = systemSlotsQueryResult.AsDictionaryResult();
        if (!systemSlotsQueryDictionayResult.Success)
        {
            Console.WriteLine($@" > Error(s)");
            Console.WriteLine($@"   {systemSlotsQueryDictionayResult.Errors.AsMessages().ToStringBuilder()}");
        }
        else
        {
            var systemSlotsItems = systemSlotsQueryDictionayResult.Value.ToList();
            bool hasSystemSlotsItems = systemSlotsItems.Any();
            if (!hasSystemSlotsItems)
            {
                Console.WriteLine($@" > Sorry, The '{DmiProperty.SystemSlots.SlotId}' property has not implemented on this system");
            }
            else
            {
                foreach (var systemSlotItemEntry in systemSlotsItems)
                {
                    var itemIndex = systemSlotItemEntry.Key;
                    var itemValue = systemSlotItemEntry.Value;
                    Console.WriteLine($@" >  System Slot ({itemIndex}) > {itemValue.Value}");
                }
            }
        }

7. Prints all SMBIOS structures properties

        DmiStructureCollection structures = DMI.CreateInstance().Structures;     
        foreach (DmiStructure structure in structures)
        {
            DmiClassCollection elements = structure.Elements;
            foreach (DmiClass element in elements)
            {
                Console.WriteLine();
                Console.WriteLine(element.ImplementedVersion == DmiStructureVersion.Latest
                    ? $@" ———————————————————————————————————————————————————— {element.ImplementedVersion} ——"
                    : $@" ——————————————————————————————————————————————————————— {element.ImplementedVersion} ——");
                Console.WriteLine($@" {(int)structure.Class:D3}-{structure.FriendlyClassName} structure detail");
                Console.WriteLine(@" ——————————————————————————————————————————————————————————————");

                IEnumerable<IPropertyKey> properties = element.ImplementedProperties;
                foreach (var property in properties)
                {
                    QueryPropertyResult queryResult = element.GetProperty(property);
                    PropertyItem propertyItem = queryResult.Value;
                    object value = propertyItem.Value;
                    string friendlyName = property.GetPropertyName();
                    PropertyUnit valueUnit = property.PropertyUnit;
                    string unit = valueUnit == PropertyUnit.None ? string.Empty : valueUnit.ToString();
                    if (value == null)
                    {
                        Console.WriteLine($@" > {friendlyName} > NULL");
                        continue;
                    }

                    if (value is string)
                    {
                        Console.WriteLine($@" > {friendlyName} > {value} {unit}");
                    }
                    else if (value is byte)
                    {
                        Console.WriteLine($@" > {friendlyName} > {value} {unit} [{value:X2}h]");
                    }
                    else if (value is short)
                    {
                        Console.WriteLine($@" > {friendlyName} > {value} {unit} [{value:X4}h]");
                    }
                    else if (value is ushort)
                    {
                        Console.WriteLine(property.Equals(DmiProperty.MemoryDevice.ConfiguredMemoryClockSpeed)
                            ? $@" > {friendlyName} > {value} {(int.Parse(dmi.SmbiosVersion) > 300 ? PropertyUnit.MTs : PropertyUnit.MHz)} [{value:X4}h]"
                            : $@" > {friendlyName} > {value} {unit} [{value:X4}h]");
                    }
                    else if (value is int)
                    {
                        Console.WriteLine($@" > {friendlyName} > {value} {unit} [{value:X4}h]");
                    }
                    else if (value is uint)
                    {
                        Console.WriteLine($@" > {friendlyName} > {value} {unit} [{value:X4}h]");
                    }
                    else if (value is long)
                    {
                        Console.WriteLine($@" > {friendlyName} > {value} {unit} [{value:X8}h]");
                    }
                    else if (value is ulong)
                    {
                        Console.WriteLine($@" > {friendlyName} > {value} {unit} [{value:X8}h]");
                    }
                    else if (value.GetType() == typeof(ReadOnlyCollection<byte>))
                    {
                        Console.WriteLine($@" > {friendlyName} > {string.Join(", ", (ReadOnlyCollection<byte>)value)}");
                    }
                    else if (value is DmiGroupAssociationElementCollection)
                    {
                        // prints elements
                    }
                    else if (value.GetType() == typeof(ReadOnlyCollection<string>))
                    {
                        Console.WriteLine($@" > {friendlyName}");
                        var collection = (ReadOnlyCollection<string>)value;
                        foreach (var entry in collection)
                        {
                            Console.WriteLine($@"   > {entry} {unit}");
                        }
                    }
                    else
                    {
                        Console.WriteLine($@" > {friendlyName} > {value} {unit}");
                    }
                }
            }
        }

Documentation
==============

 - For full code documentation, please see next link https://github.com/iAJTin/iSMBIOS/blob/master/documentation/iTin.Hardware.Specification.Dmi.md.
