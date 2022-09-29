
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

using iTin.Core.ComponentModel;
using iTin.Core.Hardware.Common;

using iTin.Hardware.Specification;
using iTin.Hardware.Specification.Dmi;
using iTin.Hardware.Specification.Dmi.Property;

namespace iSMBIOS.ConsoleAppCore
{
    class Program
    {
        static void Main(string[] args)
        {
            DMI dmi = DMI.CreateInstance();
            Console.WriteLine(@" ——————————————————————————————————————————————————————————————");
            Console.WriteLine(@" SMBIOS");
            Console.WriteLine(@" ——————————————————————————————————————————————————————————————");
            Console.WriteLine($@" Version > {dmi.SmbiosVersion}");

            Console.WriteLine();
            Console.WriteLine(@" ——————————————————————————————————————————————————————————————");
            Console.WriteLine(@" Availables structures");
            Console.WriteLine(@" ——————————————————————————————————————————————————————————————");
            DmiStructureCollection structures = dmi.Structures;
            foreach (DmiStructure structure in structures)
            {
                Console.WriteLine($@" {(int)structure.Class:D3}-{structure.FriendlyClassName}");

                int totalStructures = structure.Elements.Count;
                if (totalStructures > 1)
                {
                    Console.WriteLine($@"     > {totalStructures} structures");
                }
            }

            Console.WriteLine();
            Console.WriteLine(@" ——————————————————————————————————————————————————————————————");
            Console.WriteLine(@" Implemented SMBIOS Structure Version");
            Console.WriteLine(@" ——————————————————————————————————————————————————————————————");
            foreach (DmiStructure structure in structures)
            {
                Console.WriteLine($@" {(int)structure.Class:D3}-{structure.FriendlyClassName}");

                DmiClassCollection elements = structure.Elements;
                foreach (DmiClass element in elements)
                {
                    Console.WriteLine($@"     > {element.ImplementedVersion}");
                }
            }

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

            Console.WriteLine();
            Console.WriteLine(@" ——————————————————————————————————————————————————————————————");
            Console.WriteLine(@" Gets a single property directly");
            Console.WriteLine(@" ——————————————————————————————————————————————————————————————");

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

            Console.WriteLine();
            Console.WriteLine(@" ———————————————————————————————————————————————— Collection ——");
            Console.WriteLine(@" Gets a multiple properties directly");
            Console.WriteLine(@"   Handle result as collection");
            Console.WriteLine(@" ——————————————————————————————————————————————————————————————");
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

            Console.WriteLine();
            Console.WriteLine(@" ———————————————————————————————————————————————— Dictionary ——");
            Console.WriteLine(@" Gets a multiple properties directly");
            Console.WriteLine(@"   Handle result as dictionary");
            Console.WriteLine(@" ——————————————————————————————————————————————————————————————");
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

            Console.ReadLine();
        }
    }
}
