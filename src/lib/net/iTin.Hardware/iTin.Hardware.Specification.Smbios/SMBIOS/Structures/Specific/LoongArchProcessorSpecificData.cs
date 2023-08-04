
using System;
using System.Diagnostics;

using iTin.Core;
using iTin.Core.Helpers.Enumerations;

namespace iTin.Hardware.Specification.Smbios;

// Type 044: Processor Specific Block > LoongArch Processor-specific Block Structure.
// For more information, please see: https://loongson.github.io/loongarch-smbios/LoongArch-Processor-SMBIOS-Spec-EN.html.
// •—————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
// |            Spec.                                                                                                |
// | Offset     Version     Name                    Length      Value       Description                              |
// •—————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
// | 00h        0100h       Revision of RISC-V      WORD        0100h       Bit 15:08   Major revision               |
// |            (v1.0)      Processor Specific                  (v1.00)     Bit 07:00   Minor revision               |
// |                        Block Specific                                  Revision of LoongArch Processor-specific |
// |                                                                        Block Structure.                         |
// •—————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
// | 02h        0100h       Block                   BYTE        28h         Length of Processor-specific Data.       |
// |            (v1.0)      Length                              (40d)                                                |
// •—————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
// | 03h        0100h       Reserved                BYTE        00h         Reserved.                                |
// |            (v1.0)                                                                                               |
// •—————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
// | 04h        0100h       Machine Vendor ID       DQWORD      Varies      The manufacturer vendor ID of the        |
// |            (v1.0)                                                      processor. It is semantically equivalent |
// |                                                                        to the value at the offset 0x10 of the   |
// |                                                                        IOCSR space on a Loongson CPU.           |
// •—————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
// | 14h        0100h       CPU ID                 DQWORD      Varies       The CPU ID used for this LoongArch       |
// |            (v1.0)                                                      processor manufacturer to mark different |
// |                                                                        CPU types or CPU instances.              |
// |                                                                        It is semantically equivalent to the     |
// |                                                                        value at the offset 0x20 of the IOCSR    |
// |                                                                        space on a Loongson CPU.                 |
// •—————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
// | 24h        0100h       ISA extensions         DQWORD      Bit-field    The bit field [3:0] indicates support    |
// |            (v1.0)      support                                         for the existing LoongArch standard ISA  |
// |                                                                        extensions. It is modeled after the      |
// |                                                                        LoongArch EUEN register (CSR 0x2), and   |
// |                                                                        meaning of each bit is the same as       |
// |                                                                        defined for the EUEN (Extended Component |
// |                                                                        Unit Enable) register.                   |
// |                                                                        Setting a bit in this field indicates    |
// |                                                                        that this system supports the .          |
// |                                                                        corresponding ISA extension.             |
// | Please see:                                                                                                     |
// | https://loongson.github.io/LoongArch-Documentation/LoongArch-Vol1-EN.html#extended-component-unit-enable        |
// |                                                                                                                 |
// | Bits    Name    Description                                                                                     |
// | -----   ----    -----------                                                                                     |
// |    00   FPE     The base floating-point instruction enable bit.                                                 |
// |                 When this bit is 0, execution of the base floating-point instruction as described in            |
// |                 Overview of Floating-Point Instructions will trigger a floating-point instruction disable       |
// |                 exception (FPD).                                                                                |
// |                                                                                                                 |  
// |    01   SXE     The 128-bit vector expansion instruction enable bit. When this bit is 0, execution of the 128-  |
// |                 bit vector expansion instruction as described in Volume 2 will trigger the 128-bit vector       |
// |                 expansion instruction disable exception (SXD).                                                  |
// |                                                                                                                 |  
// |    02   ASXE    The 256-bit vector expansion instruction enables the control bit. When this bit is 0, execution |
// |                 of the 256-bit vector expansion instruction as described in Volume 2 will trigger the 256-bit   |
// |                 vector expansion instruction disable exception (ASXD).                                          |
// |                                                                                                                 |  
// |    03   BTE     Binary translation expansion instruction enable bit.                                            |
// |                 When this bit is 0, execution of the binary translation expansion instruction described in      |
// |                 Volume 2 will trigger the binary translation expansion instruction disable exception (BTD).     |
// |                                                                                                                 |  
// | 31:04   0       Reserved field. Return 0 if read this field, and software is not allowed to change its value.   |
// •—————————————————————————————————————————————————————————————————————————————————————————————————————————————————•

/// <summary>
/// This class represents a processor specific block of the structure <see cref="SmbiosType044"/>.
/// </summary>
public class LoongArchProcessorSpecificData : IProcessorSpecificData
{
    #region private readonly memebrs

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private readonly byte[] _data;

    #endregion

    #region constructor/s

    /// <summary>
    /// Initializes a new instance of the <see cref="RiskVProcessorSpecificData"/> class specifying the structure information.
    /// </summary>
    /// <param name="processorSpecificInformationBlockData">Untreated information of the current structure.</param>
    internal LoongArchProcessorSpecificData(byte[] processorSpecificInformationBlockData)
    {
        _data = processorSpecificInformationBlockData;
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="RiskVProcessorSpecificData"/> class.
    /// </summary>
    private LoongArchProcessorSpecificData()
    {
        _data = Array.Empty<byte>();
    }

    #endregion

    #region public static readonly properties

    /// <summary>
    /// Returns a new <see cref="LoongArchProcessorSpecificData"/> instance that indicates that it has not been implemented.
    /// </summary>
    /// <value>
    /// A new <see cref="LoongArchProcessorSpecificData"/> instance.
    /// </value>
    public static LoongArchProcessorSpecificData NotImplemented => new();

    #endregion

    #region private properties

    /// <summary>
    ///  Gets a value that represents the '<b>Revision</b>' field.
    /// </summary>
    /// <value>
    /// Value of the property.
    /// </value>
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private int? Revision => _data.IsNullOrEmpty() 
        ? null 
        : _data.GetWord(0x00);

    /// <summary>
    /// Gets a value that represents the '<b>Block Length</b>' field.
    /// </summary>
    /// <value>
    /// Value of the property.
    /// </value>
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private byte? BlockLength => _data.IsNullOrEmpty()
        ? null
        : _data[0x02];

    /// <summary>
    ///  Gets a value that represents the '<b>Reserved</b>' field.
    /// </summary>
    /// <value>
    /// Value of the property.
    /// </value>
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private byte? Reserved => _data.IsNullOrEmpty()
        ? null
        : _data[0x03];

    /// <summary>
    ///  Gets a value that represents the '<b>Machine Vendor Id</b>' field.
    /// </summary>
    /// <value>
    /// Value of the property.
    /// </value>
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private long? MachineVendorId => _data.IsNullOrEmpty()
        ? null
        : _data.GetQuadrupleWord(0x04);
        
    /// <summary>
    ///  Gets a value that represents the '<b>CPU ID</b>' field.
    /// </summary>
    /// <value>
    /// Value of the property.
    /// </value>
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private long? Cpuid => _data.IsNullOrEmpty()
        ? null
        : _data.GetQuadrupleWord(0x14);

    /// <summary>
    ///  Gets a value that represents the '<b>ISA Extensions Support</b>' field.
    /// </summary>
    /// <value>
    /// Value of the property.
    /// </value>
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private int? IsaExtensionsSupport => _data.IsNullOrEmpty()
        ? null
        : _data.GetDoubleWord(0x24);

    #endregion

    #region public properties

    /// <summary>
    ///  Gets a value that represents the '<b>Major Revision</b>' field.
    /// </summary>
    /// <value>
    /// Value of the property.
    /// </value>
    public byte? MajorRevision => Revision == null 
        ? null 
        : (byte?)((Revision & 0xf0) >> 7);

    /// <summary>
    ///  Gets a value that represents the '<b>Minor Revision</b>' field.
    /// </summary>
    /// <value>
    /// Value of the property.
    /// </value>
    public byte? MinorRevision => Revision == null 
        ? null 
        : (byte?)(Revision & 0x0f);

    /// <summary>
    ///  Gets a value that represents the '<b>FPE</b>' field.
    /// </summary>
    /// <value>
    /// Value of the property.
    /// </value>
    public bool? FPE => IsaExtensionsSupport?.CheckBit(Bits.Bit00);

    /// <summary>
    ///  Gets a value that represents the '<b>SXE</b>' field.
    /// </summary>
    /// <value>
    /// Value of the property.
    /// </value>
    public bool? SXE => IsaExtensionsSupport?.CheckBit(Bits.Bit01);

    /// <summary>
    ///  Gets a value that represents the '<b>ASXE</b>' field.
    /// </summary>
    /// <value>
    /// Value of the property.
    /// </value>
    public bool? ASXE => IsaExtensionsSupport?.CheckBit(Bits.Bit02);

    /// <summary>
    ///  Gets a value that represents the '<b>BTE</b>' field.
    /// </summary>
    /// <value>
    /// Value of the property.
    /// </value>
    public bool? BTE => IsaExtensionsSupport?.CheckBit(Bits.Bit03);

    #endregion

    #region public override methods

    /// <summary>
    /// Returns a class <see cref="string"/> that represents the current object.
    /// </summary>
    /// <returns>
    /// Object <see cref="string"/> that represents the current <see cref="RiskVProcessorSpecificData"/> class.
    /// </returns>
    public override string ToString() => $"Revision = {MajorRevision}{MinorRevision}";

    #endregion
}
