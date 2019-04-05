<p align="center">
  <img src="https://cdn.rawgit.com/iAJTin/iSMBIOS/master/nuget/iSMBIOS.png"  
       height="32">
</p>
<p align="center">
  <a href="https://github.com/iAJTin/iSMBIOS">
    <img src="https://img.shields.io/badge/iTin-iSMBIOS-green.svg?style=flat"/>
  </a>
</p>

***

# What is iSMBIOS?
iSMBIOS is a lightweight implementation that allows us to obtain the SMBIOS information

This library fully implements DMTF Specification 3.2.0 and olders versions

For more information, please see https://www.dmtf.org/standards/smbios

# Install via NuGet

<table>
  <tr>
    <td>
      <a href="https://github.com/iAJTin/iSMBIOS/tree/master/src/iTin.Core.Hardware">
        <img src="https://img.shields.io/badge/-iSMBIOS-green.svg?style=flat"/>
      </a>
    </td>
    <td>
      <a href="https://www.nuget.org/packages/iSMBIOS/">
        <img alt="NuGet Version" 
             src="https://img.shields.io/nuget/v/iSMBIOS.svg" /> 
      </a>
    </td>  
  </tr>
</table>

# Usage

Call **DMI.Instance.Structures** for getting all SMBIOS structures availables.

## Examples

1. Gets and prints all **SMBIOS** availables structures.


            DmiStructureCollection structures = DMI.Instance.Structures;
            foreach (DmiStructure structure in structures)
            {
                Console.WriteLine($"{(int) structure.Class:D3}-{structure.Class}");
            }

2. Gets a specific **SMBIOS** structure.


            DmiStructureCollection structures = DMI.Instance.Structures;
            DmiStructure bios = structures[SmbiosStructure.Bios];
            if (bios != null)
            {
                /// structure exist!!!
            }

3. Prints all **SMBIOS** structures properties


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
                            Console.WriteLine($@"{id} -> NULL");
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

# How can I send feedback!!!

If you have found **iSMBIOS** useful at work or in a personal project, I would love to hear about it. If you have decided not to use **iSMBIOS**, please send me and email stating why this is so. I will use this feedback to improve **iSMBIOS** in future releases.

My email address is fdo.garcia.vega@gmail.com
