﻿
# What is iSMBIOS?
iSMBIOS is a lightweight implementation that allows us to obtain the SMBIOS information. **Currently only works on Windows**

This library implements DMTF Specification 3.7.0 version and olders versions

For more information, please see [https://www.dmtf.org/standards/smbios](https://www.dmtf.org/standards/smbios)

### Usage

#### Before

   Call **DMI.Instance.Structures** for getting all SMBIOS structures availables.

#### Now

The **DMI.Instance** property now is mark as obsolete use **DMI.CreateInstance()** method instead
If you want to connect to a remote machine fill in an instance of the DmiConnectOptions object and use it 
as the argument of the **DMI method.CreateInstance(optionsInstance)**.
   
For more info, please see [CHANGELOG] file.

### Examples

1. Gets and prints **SMBIOS** version.

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

3. Gets and prints the implemented **SMBIOS** structure version.

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

4. Gets a **single property** directly.

       DmiStructureCollection structures = DMI.CreateInstance().Structures;
       QueryPropertyResult biosVersion = structures.GetProperty(DmiProperty.Bios.BiosVersion);
       if (biosVersion.Success)
       {
           Console.WriteLine($@" > BIOS Version > {biosVersion.Result.Value}");
       }
 
       QueryPropertyResult biosVendor = structures.GetProperty(DmiProperty.Bios.Vendor);
       if (biosVendor.Success)
       {
           Console.WriteLine($@" > BIOS Vendor > {biosVendor.Result.Value}");
       }

       QueryPropertyResult currentSpeed = structures.GetProperty(DmiProperty.Processor.CurrentSpeed);
       if (currentSpeed.Success)
       {
           Console.WriteLine($@" > Current Speed > {currentSpeed.Result.Value} {currentSpeed.Result.Key.PropertyUnit}");
       }

       QueryPropertyResult processorManufacturer = structures.GetProperty(DmiProperty.Processor.ProcessorManufacturer);
       if (processorManufacturer.Success)
       {
           Console.WriteLine($@" > Processor Manufacturer > {processorManufacturer.Result.Value}");
       }

5. Gets a property in **multiple** elements directly (Handle result as collection).

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
           IEnumerable<PropertyItem> systemSlotsItems = systemSlotsQueryResult.Result.ToList();
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

6. Gets a property in **multiple** elements directly (Handle result as dictionary).

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
            var systemSlotsItems = systemSlotsQueryDictionayResult.Result.ToList();
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

7. Prints all **SMBIOS** structures properties

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
                    PropertyItem propertyItem = queryResult.Result;
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

[CHANGELOG]: https://github.com/iAJTin/iSMBIOS/blob/master/CHANGELOG.md

