
using System.Diagnostics;
using System.Linq;

using iTin.Core;

namespace iTin.Hardware.Specification.Smbios;

// Type 044: Processor Specific Block.
// •————————————————————————————————————————————————————————————————————————————————————————————————————————————•
// | Offset       Name            Length      Value       Description                                           |
// •————————————————————————————————————————————————————————————————————————————————————————————————————————————•
// | 00h          Block           BYTE        Varies      Length of Processor-specific Data                     |
// |              Length                      (N)                                                               |
// •————————————————————————————————————————————————————————————————————————————————————————————————————————————•
// | 01h          Processor       BYTE        Varies      The processor architecture delineated by this         |
// |              Type                                    Processor-specific Block.                             |
// •————————————————————————————————————————————————————————————————————————————————————————————————————————————•
// | 02h          Processor       N           Varies      Processor-specific data.                              |
// |              Specific        BYTEs                                                                         |
// |              Data                                                                                          |
// •————————————————————————————————————————————————————————————————————————————————————————————————————————————•

/// <summary>
/// This class represents a processor specific block of the structure <see cref="SmbiosType044"/>.
/// </summary>
public class ProcessorSpecificInformationBlock
{
    #region private readonly memebrs

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private readonly byte[] _data;

    #endregion

    #region constructor/s

    /// <summary>
    /// Initializes a new instance of the <see cref="ProcessorSpecificInformationBlock"/> class specifying the structure information.
    /// </summary>
    /// <param name="processorSpecificInformationBlockData">Untreated information of the current structure.</param>
    internal ProcessorSpecificInformationBlock(byte[] processorSpecificInformationBlockData)
    {
        _data = processorSpecificInformationBlockData;
    }

    #endregion

    #region private properties

    /// <summary>
    ///  Gets a value that represents the '<b>Block Lenght</b>' field.
    /// </summary>
    /// <value>
    /// Value of the property.
    /// </value>
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private byte BlockLenght => _data[0x00];

    /// <summary>
    ///  Gets a value that represents the '<b>Processor Type</b>' field.
    /// </summary>
    /// <value>
    /// Value of the property.
    /// </value>
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private byte ProcessorTypeValue => _data[0x01];

    #endregion

    #region public properties

    /// <summary>
    ///  Gets a value that represents the '<b>Processor Specific Data</b>' field. If not implemented this field return a <see cref="RiskVProcessorSpecificData.NotImplemented"/> instance.
    /// </summary>
    /// <value>
    /// Value of the property.
    /// </value>
    public IProcessorSpecificData ProcessorSpecificData => ProcessorTypeValue switch
    {
        0x00 => RiskVProcessorSpecificData.NotImplemented,
        0x01 => RiskVProcessorSpecificData.NotImplemented,
        0x02 => RiskVProcessorSpecificData.NotImplemented,
        0x03 => RiskVProcessorSpecificData.NotImplemented,
        0x04 => RiskVProcessorSpecificData.NotImplemented,
        0x05 => RiskVProcessorSpecificData.NotImplemented,
        0x06 => new RiskVProcessorSpecificData(_data.Extract((byte)0x02, BlockLenght).ToArray()),
        0x07 => new RiskVProcessorSpecificData(_data.Extract((byte)0x02, BlockLenght).ToArray()),
        0x08 => new RiskVProcessorSpecificData(_data.Extract((byte)0x02, BlockLenght).ToArray()),
        _ => new LoongArchProcessorSpecificData(_data.Extract((byte)0x02, BlockLenght).ToArray())
    };

    /// <summary>
    ///  Gets a value that represents the '<b>Processor Type</b>' field.
    /// </summary>
    /// <value>
    /// Value of the property.
    /// </value>
    public string ProcessorType => GetProcessorType(_data[0x01]);

    #endregion

    #region public override methods

    /// <summary>
    /// Returns a class <see cref="string"/> that represents the current object.
    /// </summary>
    /// <returns>
    /// Object <see cref="string"/> that represents the current <see cref="ProcessorSpecificInformationBlock"/> class.
    /// </returns>
    public override string ToString() => $"ProcessorType = {ProcessorType}";

    #endregion

    #region private static methods

    /// <summary>
    /// Gets a string that identifies the processor type.
    /// </summary>
    /// <param name="code">Value to analyze.</param>
    /// <returns>
    /// Processor type.
    /// </returns>
    private static string GetProcessorType(byte code)
    {
        string[] value =
        {
            "Reserved",                            // 0x00
            "IA32 (x86)",
            "x64 (x86-64, Intel64, AMD64, EM64T)",
            "Intel® Itanium® architecture",
            "32-bit ARM (Aarch32)",
            "64-bit ARM (Aarch64)",   
            "32-bit RISC-V (RV32)",
            "64-bit RISC-V (RV64)",
            "128-bit RISC-V (RV128)",
            "32-bit LoongArch (LoongArch32)",
            "64-bit LoongArch (LoongArch64)"       // 0x0a
        };

        if (code <= 0x0a)
        {
            return value[code];
        }

        return SmbiosHelper.OutOfSpec;
    }

    #endregion
}
