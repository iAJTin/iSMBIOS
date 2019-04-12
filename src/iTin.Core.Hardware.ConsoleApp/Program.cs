
namespace iTin.Core.Hardware.ConsoleApp
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;

    using Device.DeviceProperty;

    using Specification;
    using Specification.Dmi;
    using Specification.Dmi.Property;

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(@" ——————————————————————————————————————————————————————————————");
            Console.WriteLine(" Availables structures");
            Console.WriteLine(@" ——————————————————————————————————————————————————————————————");

            DmiStructureCollection structures = DMI.Instance.Structures;
            foreach (DmiStructure structure in structures)
            {
                Console.WriteLine($@" {(int) structure.Class:D3}-{structure.Class}");
            }

            foreach (DmiStructure structure in structures)
            {
                Console.WriteLine();
                Console.WriteLine(@" ——————————————————————————————————————————————————————————————");
                Console.WriteLine($@" {(int)structure.Class:D3}-{structure.Class} structure detail");
                Console.WriteLine(@" ——————————————————————————————————————————————————————————————");
                DmiClassCollection elements = structure.Elements;
                foreach (DmiClass element in elements)
                {
                    Hashtable elementProperties = element.Properties;
                    foreach (DictionaryEntry property in elementProperties)
                    {
                        object value = property.Value;

                        PropertyKey key = (PropertyKey)property.Key;
                        Enum id = key.PropertyId;

                        PropertyUnit valueUnit = key.PropertyUnit;
                        string unit =
                            valueUnit == PropertyUnit.None
                                ? string.Empty
                                : valueUnit.ToString();

                        if (value == null)
                        {
                            Console.WriteLine($@"   > {id} > NULL");
                            continue;
                        }

                        if (value is string)
                        {
                            Console.WriteLine($@"   > {id} > {value}{unit}");
                        }
                        else if (value is byte)
                        {
                            Console.WriteLine($@"   > {id} > {value}{unit} [{value:X2}h]");
                        }
                        else if (value is short)
                        {
                            Console.WriteLine($@"   > {id} > {value}{unit} [{value:X4}h]");
                        }
                        else if (value is ushort)
                        {
                            Console.WriteLine($@"   > {id} > {value}{unit} [{value:X4}h]");
                        }
                        else if (value is int)
                        {
                            Console.WriteLine($@"   > {id} > {value}{unit} [{value:X4}h]");
                        }
                        else if (value is uint)
                        {
                            Console.WriteLine($@"   > {id} > {value}{unit} [{value:X4}h]");
                        }
                        else if (value is long)
                        {
                            Console.WriteLine($@"   > {id} > {value}{unit} [{value:X8}h]");
                        }
                        else if (value is ulong)
                        {
                            Console.WriteLine($@"   > {id} > {value}{unit} [{value:X8}h]");
                        }
                        else if (value.GetType() == typeof(ReadOnlyCollection<byte>))
                        {
                            Console.WriteLine($@"   > {id} > {string.Join(", ", (ReadOnlyCollection<byte>)value)}");
                        }
                        else if (value.GetType() == typeof(ReadOnlyCollection<string>))
                        {
                            Console.WriteLine($@"   > {id}");
                            var collection = (ReadOnlyCollection<string>) value;
                            foreach (var entry in collection)
                            {
                                Console.WriteLine($@"     > {entry}");
                            }
                        }
                        else
                        {
                            Console.WriteLine($@"   > {id} > {value}{unit}");
                        }
                    }
                }
            }

            Console.WriteLine();
            Console.WriteLine(@" ——————————————————————————————————————————————————————————————");
            Console.WriteLine($@" Gets a single property directly");
            Console.WriteLine(@" ——————————————————————————————————————————————————————————————");

            IDeviceProperty ss = structures.GetProperty(KnownDmiProperty.Bios.BiosVersion);
            DeviceProperty<string> biosVersion = (DeviceProperty<string>)structures.GetProperty(KnownDmiProperty.Bios.BiosVersion);
            if (biosVersion != null)
            {
                Console.WriteLine($" BIOS Version > {biosVersion.Value}");
            }

            DeviceProperty<string> processorFamily = (DeviceProperty<string>)structures.GetProperty(KnownDmiProperty.Processor.Family);
            if (processorFamily != null)
            {
                Console.WriteLine($" CPU Family > {processorFamily.Value}");
            }

            DeviceProperty<string> processorManufacturer = (DeviceProperty<string>)structures.GetProperty(KnownDmiProperty.Processor.ProcessorManufacturer);
            if (processorManufacturer != null)
            {
                Console.WriteLine($" CPU Manufacturer > {processorManufacturer.Value}");
            }

            Console.WriteLine();
            Console.WriteLine(@" ——————————————————————————————————————————————————————————————");
            Console.WriteLine($@" Gets a multiple properties directly");
            Console.WriteLine(@" ——————————————————————————————————————————————————————————————");
            IDictionary<int, IDeviceProperty> systemSlots = structures.GetProperties(KnownDmiProperty.SystemSlots.SlotId);
            foreach (KeyValuePair<int, IDeviceProperty> systemSlot in systemSlots)
            {
                int element = systemSlot.Key;
                DeviceProperty<string> property = (DeviceProperty<string>) systemSlot.Value;
                Console.WriteLine($" System Slot Id ({element}) > {property.Value}");
            }

            Console.ReadLine();
        }
    }
}
