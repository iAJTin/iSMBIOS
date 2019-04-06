
namespace iTin.Core.Hardware.ConsoleApp
{
    using System;
    using System.Collections;
    using System.Collections.ObjectModel;

    using Specification;
    using Specification.Dmi;

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
                        var value = property.Value;

                        var key = (PropertyKey)property.Key;
                        var id = key.PropertyId;

                        var valueUnit = key.PropertyUnit;
                        var unit =
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
                        else if (value.GetType() == typeof(ReadOnlyCollection<string>))
                        {
                            Console.WriteLine($@"   > {id}");
                            var collection = (ReadOnlyCollection<string>) value;
                            foreach (var entry in collection)
                            {
                                Console.WriteLine($@"     > {entry}");
                            }
                        }
                        else if (value.GetType() == typeof(ReadOnlyCollection<byte>))
                        {
                            Console.WriteLine($@"   > {id}");
                            var collection = (ReadOnlyCollection<byte>)value;
                            foreach (var entry in collection)
                            {
                                Console.WriteLine($@"     > {entry} [{entry:X2}h]");
                            }
                        }
                        else
                        {
                            Console.WriteLine($@"   > {id} > {value}{unit}");
                        }
                    }
                }
            }

            Console.ReadLine();
        }
    }
}
