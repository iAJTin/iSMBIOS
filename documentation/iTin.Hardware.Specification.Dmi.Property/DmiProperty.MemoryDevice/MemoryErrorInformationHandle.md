# DmiProperty.MemoryDevice.MemoryErrorInformationHandle property

Gets a value representing the key to retrieve the property.

Handle, or instance number, associated with any error that was previously detected for the device. If no error was detected returns -1. If the system does not provide the error information returns -2.

Key Composition

* Structure: MemoryDevice
* Property: MemoryErrorInformationHandle
* Unit: None

Return Value

Type: UInt16

Remarks

2.1+

```csharp
public static IPropertyKey MemoryErrorInformationHandle { get; }
```

## See Also

* class [MemoryDevice](../DmiProperty.MemoryDevice.md)
* namespace [iTin.Hardware.Specification.Dmi.Property](../../iTin.Hardware.Specification.Dmi.md)

<!-- DO NOT EDIT: generated by xmldocmd for iTin.Hardware.Specification.Dmi.dll -->
