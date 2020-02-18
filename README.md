<p align="center">
  <img src="https://cdn.rawgit.com/iAJTin/iSMBIOS/master/nuget/iSMBIOS.png"  
       height="32"/>
</p>
<p align="center">
  <a href="https://github.com/iAJTin/iSMBIOS">
    <img src="https://img.shields.io/badge/iTin-iSMBIOS-green.svg?style=flat"/>
  </a>
</p>

***

# What is iSMBIOS?
iSMBIOS is a lightweight implementation that allows us to obtain the SMBIOS information

This library fully implements DMTF Specification 3.4.0a (Preliminary version) and olders versions

For more information, please see [https://www.dmtf.org/standards/smbios](https://www.dmtf.org/standards/smbios)

# Install via NuGet

<table>
  <tr>
    <td>
      <a href="https://github.com/iAJTin/iSMBIOS">
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
           Console.WriteLine($@"{(int) structure.Class:D3}-{structure.Class}");
       }

2. Gets a specific **SMBIOS** structure.


       DmiStructureCollection structures = DMI.Instance.Structures;
       DmiStructure bios = structures[SmbiosStructure.Bios];
       if (bios != null)
       {
           /// structure exist!!!
       }

3. Gets a **single property** directly.


       DmiStructureCollection structures = DMI.Instance.Structures;
       object biosVersion = structures.GetProperty(DmiProperty.Bios.BiosVersion);
       if (biosVersion != null)
       {
           Console.WriteLine($@" BIOS Version > {biosVersion}");
       }

       string biosVendor = structures.GetProperty<string>(DmiProperty.Bios.Vendor);
       Console.WriteLine($@" > BIOS Vendor > {biosVendor}");

       ushort currentSpeed = structures.GetProperty<ushort>(DmiProperty.Processor.CurrentSpeed);
       Console.WriteLine($@" > Current Speed > {currentSpeed:N0} {DmiProperty.Processor.CurrentSpeed.PropertyUnit}");

       string processorManufacturer = structures.GetProperty<string>(DmiProperty.Processor.ProcessorManufacturer);
       Console.WriteLine($@" Processor Manufacturer > {processorManufacturer}");

4. Gets a property in **multiple** elements directly.

       // Requires that the Slot Information structure exists in your system
       DmiStructureCollection structures = DMI.Instance.Structures;
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

5. Prints all **SMBIOS** structures properties

        DmiStructureCollection structures = DMI.Instance.Structures;      
        foreach (DmiStructure structure in structures)
        {
            Console.WriteLine();
            Console.WriteLine(element.ImplementedVersion == DmiStructureVersion.Latest
                ? $@" ———————————————————————————————————————————————————— {element.ImplementedVersion} ——"
                : $@" ——————————————————————————————————————————————————————— {element.ImplementedVersion} ——");
            Console.WriteLine($@" {(int)structure.Class:D3}-{structure.FriendlyClassName} structure detail");
            Console.WriteLine(@" ——————————————————————————————————————————————————————————————");
            
            DmiClassCollection elements = structure.Elements;
            foreach (DmiClass element in elements)
            {
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
                            ? $@" > {friendlyName} > {value} {(int.Parse(DMI.Instance.SmbiosVersion) > 300 ? PropertyUnit.MTs : PropertyUnit.MHz)} [{value:X4}h]"
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
                    else if (value.GetType() == typeof(DmiGroupAssociationElementCollection))
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

        private static string GetFriendlyName(IPropertyKey value)
        {
            string name = value.GetPropertyName();
            return string.IsNullOrEmpty(name)
                ? value.PropertyId.ToString()
                : name;
        }

# How can I send feedback!!!

If you have found **iSMBIOS** useful at work or in a personal project, I would love to hear about it. If you have decided not to use **iSMBIOS**, please send me and email stating why this is so. I will use this feedback to improve **iSMBIOS** in future releases.

My email address is fdo.garcia.vega@gmail.com
