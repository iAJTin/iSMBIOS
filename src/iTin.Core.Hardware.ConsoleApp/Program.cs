using System;
using System.Collections;
using System.Collections.ObjectModel;
using System.Globalization;

using iTin.Core.Hardware.Specification;
using iTin.Core.Hardware.Specification.Dmi;
using iTin.Core.Hardware.Specification.Smbios;

namespace iTin.Core.Hardware.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(@"———————————————————————————————————————————————————————————————————————————————————————————————————————————————");
            Console.WriteLine(string.Format(CultureInfo.InvariantCulture, "Availables structures", SmbiosStructure.Cache));
            Console.WriteLine(@"———————————————————————————————————————————————————————————————————————————————————————————————————————————————");
            DmiStructureCollection structures = DMI.Instance.Structures;
            foreach (DmiStructure structure in structures)
            {
                Console.WriteLine($@"{(int) structure.Class:D3}-{structure.Class}");
            }

            foreach (DmiStructure structure in structures)
            {
                Console.WriteLine();
                Console.WriteLine(@"———————————————————————————————————————————————————————————————————————————————————————————————————————————————");
                Console.WriteLine($@"{(int)structure.Class:D3}-{structure.Class} structure detail:");
                Console.WriteLine(@"———————————————————————————————————————————————————————————————————————————————————————————————————————————————");
                DmiClassCollection elements = structure.Elements;
                foreach (DmiClass element in elements)
                {
                    Hashtable elementProperties = element.Properties;
                    foreach (DictionaryEntry property in elementProperties)
                    {
                        object value = property.Value;

                        if (value == null)
                        {
                            Console.WriteLine($@"{((PropertyKey)property.Key).PropertyId} -> NULL");
                            continue;
                        }

                        if (value is string)
                        {
                            Console.WriteLine($@"{((PropertyKey)property.Key).PropertyId} -> {property.Value}");
                        }
                        else if (value is byte)
                        {
                            Console.WriteLine($@"{((PropertyKey)property.Key).PropertyId} -> {property.Value} [{property.Value:X2}h]");
                        }
                        else if (value is short)
                        {
                            Console.WriteLine($@"{((PropertyKey)property.Key).PropertyId} -> {property.Value} [{property.Value:X4}h]");
                        }
                        else if (value is ushort)
                        {
                            Console.WriteLine($@"{((PropertyKey)property.Key).PropertyId} -> {property.Value} [{property.Value:X4}h]");
                        }
                        else if (value is int)
                        {
                            Console.WriteLine($@"{((PropertyKey)property.Key).PropertyId} -> {property.Value} [{property.Value:X4}h]");
                        }
                        else if (value is uint)
                        {
                            Console.WriteLine($@"{((PropertyKey)property.Key).PropertyId} -> {property.Value} [{property.Value:X4}h]");
                        }
                        else if (value is long)
                        {
                            Console.WriteLine($@"{((PropertyKey)property.Key).PropertyId} -> {property.Value} [{property.Value:X8}h]");
                        }
                        else if (value is ulong)
                        {
                            Console.WriteLine($@"{((PropertyKey)property.Key).PropertyId} -> {property.Value} [{property.Value:X8}h]");
                        }
                        else if (value.GetType() == typeof(ReadOnlyCollection<string>))
                        {
                            Console.WriteLine($@"{((PropertyKey)property.Key).PropertyId}");
                            ReadOnlyCollection<string> collection = (ReadOnlyCollection<string>) value;
                            foreach (string entry in collection)
                            {
                                Console.WriteLine(string.Format(CultureInfo.InvariantCulture, "\t-> {0}", entry));
                            }
                        }
                        else
                        {
                            Console.WriteLine($@"{((PropertyKey)property.Key).PropertyId} -> {property.Value}");
                        }
                    }
                }
            }

            Console.ReadLine();
        }
    }
}
