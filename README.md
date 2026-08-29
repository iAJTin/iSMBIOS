# iSMBIOS 🖥️

[![NuGet version](https://shields.io)](https://nuget.org)
[![NuGet downloads](https://shields.io)](https://nuget.org)
[![Platform](https://shields.io)](https://microsoft.com)
[![License](https://shields.io)](LICENSE)

A lightweight, high-performance, and safe .NET library to natively read **SMBIOS (System Management BIOS)** and **DMI tables** on Windows environments without external runtime overhead.

### 🚀 Why choose iSMBIOS over WMI?
* **Zero WMI Dependencies:** Avoids slow, heavy, or enterprise-blocked Windows Management Instrumentation (WMI) queries.
* **Direct Low-Level Access:** Safely invokes native Win32 APIs (`GetSystemFirmwareTable`) underneath.
* **Enterprise Asset Auditing:** Ideal for hardware fingerprinting, hardware binding, anti-piracy, and asset tracking.
* **DMTF Compliant:** Full compliance with the Distributed Management Task Force (DMTF) standards (up to SMBIOS v3.7.0).

---

## 📦 Installation

Install via NuGet Package Manager Console:
```bash
Install-Package iSMBIOS
```
Or via .NET CLI:
```bash
dotnet add package iSMBIOS
```

---

## 💻 Quick Start (Real-World Use Cases)

Here is how to solve the most common hardware identification tasks instantly.

### 1. Get Motherboard Serial Number & Model (Type 2)
```csharp
using iSMBIOS;
using System;
using System.Linq;

class Program
{
    static void Main()
    {
        var dmi = DMI.CreateInstance();
        var baseBoard = dmi.BaseBoard.FirstOrDefault();

        if (baseBoard != null)
        {
            Console.WriteLine($"Manufacturer: {baseBoard.Manufacturer}");
            Console.WriteLine($"Product/Model: {baseBoard.Product}");
Console.WriteLine($"Serial Number: {baseBoard.SerialNumber}");
Console.WriteLine($"Version: {baseBoard.Version}");
        }
    }
}
```

### 2. Get Unique System UUID & BIOS Info (Type 1 & Type 0)
```csharp
using iSMBIOS;
using System;
using System.Linq;

class Program
{
    static void Main()
    {
        var dmi = DMI.CreateInstance();
        
        // Extract Unique System UUID
        var systemInfo = dmi.System.FirstOrDefault();
        if (systemInfo != null)
        {
            Console.WriteLine($"System UUID: {systemInfo.Uuid}");
            Console.WriteLine($"SKU Number: {systemInfo.SkuNumber}");
        }

        // Extract BIOS Firmware details
        var biosInfo = dmi.Bios.FirstOrDefault();
        if (biosInfo != null)
        {
            Console.WriteLine($"BIOS Vendor: {biosInfo.Vendor}");
            Console.WriteLine($"BIOS Version: {biosInfo.BiosVersion}");
            Console.WriteLine($"Release Date: {biosInfo.BiosReleaseDate}");
        }
    }
}
```

---

## 📘 Advanced Technical Documentation

For complex architectures requiring granular metadata extraction, `iSMBIOS` exposes a powerful underlying query engine to safely read typed collections, raw structural data, or custom tables.

### Comprehensive Schema Detection
You can quickly identify the exact operational firmware specification implemented on the host machine:

```csharp
using iSMBIOS;
using System;

class Program
{
    static void Main()
    {
        // Gets and prints the global SMBIOS specification version
        Console.WriteLine($"SMBIOS Version > {DMI.CreateInstance().SmbiosVersion}");

        // Gets and prints the specific implemented structure version
        Console.WriteLine($"Implemented Version > {DMI.CreateInstance().ImplementedVersion}");
    }
}
```

### Querying Single Extracted Properties Directly
To fetch individual data keys programmatically without iterating collections manually:

```csharp
using iSMBIOS;
using System;

class Program
{
    static void Main()
    {
        var dmi = DMI.CreateInstance();
        
        // Fetch a single property via strong-typed key definitions
        var result = dmi.GetProperty(SmbiosStructure.Bios, BiosProperty.BiosVersion);
        Console.WriteLine($"Property Description: {result.Property.Description}");
        Console.WriteLine($"Raw Value: {result.Value}");
    }
}
```

### Dynamic Collection & Data Dictionary Handling
When dealing with complex multiple-element arrays (like multi-channel RAM layouts or multi-socket CPUs):

```csharp
using iSMBIOS;
using System;

class Program
{
    static void Main()
    {
        var dmi = DMI.CreateInstance();

        // Approach A: Handle results as an enumerable collection
        var collectionResult = dmi.GetCollectionProperties(SmbiosStructure.BaseBoard);
        
        // Approach B: Handle results mapped cleanly into a queryable data dictionary
        var dictionaryResult = dmi.GetDictionaryProperties(SmbiosStructure.Processor);
    }
}
```

### Inspecting All Available Raw DMIs
For deeply customized firmware definitions or low-level diagnostic logs:

```csharp
using iSMBIOS;
using System;

class Program
{
    static void Main()
    {
        var dmi = DMI.CreateInstance();

        // Print raw structure types, handles, and binary lengths available in memory
        foreach (var structure in dmi.Structures)
        {
            Console.WriteLine($"Type: {structure.Header.Type} | Handle: {structure.Header.Handle} | Length: {structure.Header.Length}");
        }
    }
}
```

---

## 🛠️ DevOps & PowerShell Automation

Looking for a scriptable, infrastructure-wide deployment? We also maintain **`iPowerShellSmbios`**, which wraps this entire engine into native Cmdlets. It allows System Administrators and DevOps engineers to seamlessly run hardware inventories across data centers or target clusters in active server management.

👉 Explore the PowerShell module repository here: **[iPowerShellSmbios](https://github.com)**

---

## 🔧 Target Framework Support
* **.NET Standard 2.0+** (Fully compatible with modern .NET Core, .NET 5, 6, 7, 8, 9)
* **.NET Framework 4.6.1+** (Full support for legacy enterprise software)
* *Execution Note: This library targets native Windows APIs and requires execution on a Windows host.*

---

## 🎯 Keywords & Search Tags
`smbios` `dmi-tables` `hardware-information` `motherboard-serial` `system-uuid` `bios-version` `cpu-z` `hardware-fingerprint` `native-hardware` `without-wmi` `getsystemfirmwaretable` `hardware-binding` `sysadmin-tools`

---

## 📄 License
This project is licensed under the MIT License - see the [LICENSE](LICENSE) file for details.
