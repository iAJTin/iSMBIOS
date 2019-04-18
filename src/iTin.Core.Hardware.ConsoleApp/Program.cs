
namespace iTin.Core.Hardware.ConsoleApp
{
    using System;
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
                    DmiClassPropertiesTable elementProperties = element.Properties;
                    foreach (KeyValuePair<PropertyKey, object> property in elementProperties)
                    {
                        object value = property.Value;

                        PropertyKey key = property.Key;
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

            IDeviceProperty biosVersion = structures.GetProperty(DmiProperty.Bios.BiosVersion);
            if (biosVersion != null)
            {
                string value = biosVersion.GetValue<string>();
                Console.WriteLine($" BIOS Vendor > {value}");
            }

            DeviceProperty<string> processorFamily = (DeviceProperty<string>)structures.GetProperty(DmiProperty.Processor.Family);
            if (processorFamily != null)
            {
                string value = processorFamily.Value;
                Console.WriteLine($" Processor Family > {value}");
            }

            IDeviceProperty processorManufacturer = structures.GetProperty(DmiProperty.Processor.ProcessorManufacturer);
            if (processorManufacturer != null)
            {
                string value = processorManufacturer.GetValue<string>();
                Console.WriteLine($" Processor Manufacturer > {value}");
            }

            Console.WriteLine();
            Console.WriteLine(@" ——————————————————————————————————————————————————————————————");
            Console.WriteLine($@" Gets a multiple properties directly");
            Console.WriteLine(@" ——————————————————————————————————————————————————————————————");
            IDictionary<int, IDeviceProperty> systemSlots = structures.GetProperties(DmiProperty.SystemSlots.SlotId);
            foreach (KeyValuePair<int, IDeviceProperty> systemSlot in systemSlots)
            {
                int element = systemSlot.Key;
                IDeviceProperty property = systemSlot.Value;
                object propertyValue = property.GetValue<string>();
                Console.WriteLine($" System Slot ({element}) > {propertyValue}");
            }

            Console.ReadLine();
        }
    }
}
