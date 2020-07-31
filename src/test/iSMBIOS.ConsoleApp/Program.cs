
namespace iSMBIOS.ConsoleApp
{
    using System;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.Linq;

    using iTin.Core.Hardware;
    using iTin.Core.Hardware.Specification;
    using iTin.Core.Hardware.Specification.Dmi;
    using iTin.Core.Hardware.Specification.Dmi.Property;

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

                    DmiClassPropertiesTable elementProperties = element.Properties;
                    foreach (KeyValuePair<IPropertyKey, object> property in elementProperties)
                    {
                        object value = property.Value;

                        IPropertyKey key = property.Key;
                        string friendlyName = GetFriendlyName(key);
                        PropertyUnit valueUnit = key.PropertyUnit;
                        string unit =
                            valueUnit == PropertyUnit.None
                                ? string.Empty
                                : valueUnit.ToString();

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
                            Console.WriteLine(key.Equals(DmiProperty.MemoryDevice.ConfiguredMemoryClockSpeed)
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

            object biosVersion = structures.GetProperty(DmiProperty.Bios.BiosVersion);
            if (biosVersion != null)
            {
                Console.WriteLine($@" > BIOS Version > {biosVersion}");
            }

            string biosVendor = structures.GetProperty<string>(DmiProperty.Bios.Vendor);
            Console.WriteLine($@" > BIOS Vendor > {biosVendor}");

            ushort currentSpeed = structures.GetProperty<ushort>(DmiProperty.Processor.CurrentSpeed);
            Console.WriteLine($@" > Current Speed > {currentSpeed:N0} {DmiProperty.Processor.CurrentSpeed.PropertyUnit}");

            string processorManufacturer = structures.GetProperty<string>(DmiProperty.Processor.ProcessorManufacturer);
            Console.WriteLine($@" > Processor Manufacturer > {processorManufacturer}");

            Console.WriteLine();
            Console.WriteLine(@" ——————————————————————————————————————————————————————————————");
            Console.WriteLine(@" Gets a multiple properties directly");
            Console.WriteLine(@" ——————————————————————————————————————————————————————————————");
            IDictionary<int, object> systemSlots = structures.GetProperties(DmiProperty.SystemSlots.SlotId);
            bool hasSystemSlots = systemSlots.Any();
            if (!hasSystemSlots)
            {
                Console.WriteLine($@" > There is no system slots information structure in this computer");
            }
            else
            {
                foreach (KeyValuePair<int, object> systemSlot in systemSlots)
                {
                    int element = systemSlot.Key;
                    var property = ((IEnumerable<KeyValuePair<IPropertyKey, object>>)systemSlot.Value).FirstOrDefault();
                    Console.WriteLine($@" > System Slot ({element}) > {property.Value}");
                }
            }

            Console.ReadLine();
        }

        private static string GetFriendlyName(IPropertyKey value)
        {
            string name = value.GetPropertyName();

            return string.IsNullOrEmpty(name)
                ? value.PropertyId.ToString()
                : name;
        }
    }
}
