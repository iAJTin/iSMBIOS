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

Call **DMI.Instance.Structures** for gets all SMBIOS structures availables.

### Examples

1. Gets and print all **SMBIOS** availables structures.


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

3. Print all **SMBIOS** structures properties


            DmiStructureCollection structures = DMI.Instance.Structures;
            foreach (DmiStructure structure in structures)
            {
                Console.WriteLine($"{(int)structure.Class:D3}-{structure.Class} structure detail:");
                Console.WriteLine("———————————————————————————————————————————————————————————————————————————————————————————————————————————————");
                DmiClassCollection elements = structure.Elements;
                foreach (DmiClass element in elements)
                {
                    var elementProperties = element.Properties;
                    foreach (DictionaryEntry property in elementProperties)
                    {
                        var value = property.Value;
                        if (value == null)
                        {
                            Console.WriteLine($"{((PropertyKey)property.Key).PropertyId} -> NULL");
                            continue;
                        }

                        if (value is string)
                        {
                            Console.WriteLine($"{((PropertyKey)property.Key).PropertyId} -> {property.Value}");
                        }
                        else if (value is byte)
                        {
                            Console.WriteLine($"{((PropertyKey)property.Key).PropertyId} -> {property.Value} [{property.Value:X2}h]");
                        }
                        else if (value is short)
                        {
                            Console.WriteLine($"{((PropertyKey)property.Key).PropertyId} -> {property.Value} [{property.Value:X4}h]");
                        }
                        else if (value is ushort)
                        {
                            Console.WriteLine($"{((PropertyKey)property.Key).PropertyId} -> {property.Value} [{property.Value:X4}h]");
                        }
                        else if (value is int)
                        {
                            Console.WriteLine($"{((PropertyKey)property.Key).PropertyId} -> {property.Value} [{property.Value:X4}h]");
                        }
                        else if (value is uint)
                        {
                            Console.WriteLine($"{((PropertyKey)property.Key).PropertyId} -> {property.Value} [{property.Value:X4}h]");
                        }
                        else if (value is long)
                        {
                            Console.WriteLine($"{((PropertyKey)property.Key).PropertyId} -> {property.Value} [{property.Value:X8}h]");
                        }
                        else if (value is ulong)
                        {
                            Console.WriteLine($"{((PropertyKey)property.Key).PropertyId} -> {property.Value} [{property.Value:X8}h]");
                        }
                        else if (value.GetType() == typeof(ReadOnlyCollection<string>))
                        {
                            Console.WriteLine($"{((PropertyKey)property.Key).PropertyId}");
                            ReadOnlyCollection<string> collection = (ReadOnlyCollection<string>)value;
                            foreach (string entry in collection)
                            {
                                Console.WriteLine(string.Format(CultureInfo.InvariantCulture, "\t-> {0}", entry));
                            }
                        }
                        else
                        {
                            Console.WriteLine($"{((PropertyKey)property.Key).PropertyId} -> {property.Value}");
                        }
                    }
                }
            }

# How can I send feedback!!!

If you have found **iSMBIOS** useful at work or in a personal project, I would love to hear about it. If you have decided not to use **iSMBIOS**, please send me and email stating why this is so. I will use this feedback to improve **iSMBIOS** in future releases.

My email address is fdo.garcia.vega@gmail.com
