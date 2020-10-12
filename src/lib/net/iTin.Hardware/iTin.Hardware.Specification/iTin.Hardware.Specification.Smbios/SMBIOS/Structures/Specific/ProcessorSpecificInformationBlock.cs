
namespace iTin.Hardware.Specification.Smbios
{
    using System.Diagnostics;
    using System.Linq;

    using iTin.Core;

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

        #region [internal] ProcessorSpecificInformationBlock(byte[]): Initialize a new instance of the class specifying the structure information
        /// <summary>
        /// Initializes a new instance of the <see cref="ProcessorSpecificInformationBlock"/> class specifying the structure information.
        /// </summary>
        /// <param name="processorSpecificInformationBlockData">Untreated information of the current structure.</param>
        internal ProcessorSpecificInformationBlock(byte[] processorSpecificInformationBlockData)
        {
            _data = processorSpecificInformationBlockData;
        }
        #endregion

        #endregion

        #region public properties

        #region [public] (RiskVProcessorSpecificData) ProcessorSpecificData: Gets a value that represents the 'Processor Specific Data' field
        /// <summary>
        ///  Gets a value that represents the '<b>Processor Specific Data</b>' field. If not implemented this field return a <see cref="RiskVProcessorSpecificData.NotImplemented"/> instance.
        /// </summary>
        /// <value>
        /// Value of the property.
        /// </value>
        public RiskVProcessorSpecificData ProcessorSpecificData => ProcessorTypeValue < 0x06 ? RiskVProcessorSpecificData.NotImplemented : new RiskVProcessorSpecificData(_data.Extract((byte)0x02, BlockLenght).ToArray());
        #endregion

        #region [public] (string) ProcessorType: Gets a value that represents the 'Processor Type' field
        /// <summary>
        ///  Gets a value that represents the '<b>Processor Type</b>' field.
        /// </summary>
        /// <value>
        /// Value of the property.
        /// </value>
        public string ProcessorType => GetProcessorType(_data[0x01]);
        #endregion

        #endregion

        #region private properties

        #region [private] (byte) BlockLenght: Gets a value that represents the 'Block Length' field
        /// <summary>
        ///  Gets a value that represents the '<b>Block Lenght</b>' field.
        /// </summary>
        /// <value>
        /// Value of the property.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private byte BlockLenght => _data[0x00];
        #endregion

        #region [private] (byte) ProcessorTypeValue: Gets a value that represents the 'Processor Type' field
        /// <summary>
        ///  Gets a value that represents the '<b>Processor Type</b>' field.
        /// </summary>
        /// <value>
        /// Value of the property.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private byte ProcessorTypeValue => _data[0x01];
        #endregion

        #endregion

        #region public override methods

        #region [public] {override} (string) ToString(): Devuelve una clase string que representa al objeto actual.
        /// <summary>
        /// Returns a class <see cref="string"/> that represents the current object.
        /// </summary>
        /// <returns>
        /// Object <see cref="string"/> that represents the current <see cref="ProcessorSpecificInformationBlock"/> class.
        /// </returns>
        public override string ToString() => $"ProcessorType = {ProcessorType}";
        #endregion

        #endregion

        #region private static methods

        #region [private] {static} (string) GetProcessorType(byte): Gets a string that identifies the processor type
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
                "128-bit RISC-V (RV128)"               // 0x08
            };

            if (code <= 0x08)
            {
                return value[code];
            }

            return SmbiosHelper.OutOfSpec;
        }
        #endregion

        #endregion
    }
}
