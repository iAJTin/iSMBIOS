# DmiProperty.MemoryDevice.PMIC0RevisionNumber property

Gets a value representing the key to retrieve the property.

The PMIC0 Revision Number indicates the revision of the PMIC0 on memory device. This field shall be set to the value of the SPD PMIC 0 Revision Number. A value of FF00h indicates the PMIC0 Revision Number is unknown.

Key Composition

* Structure: MemoryDevice
* Property: PMIC0RevisionNumber
* Unit: None

Return Value

Type: UInt16

Remarks

3.7+

```csharp
public static IPropertyKey PMIC0RevisionNumber { get; }
```

## See Also

* class [MemoryDevice](../DmiProperty.MemoryDevice.md)
* namespace [iTin.Hardware.Specification.Dmi.Property](../../iTin.Hardware.Specification.Dmi.md)

<!-- DO NOT EDIT: generated by xmldocmd for iTin.Hardware.Specification.Dmi.dll -->
