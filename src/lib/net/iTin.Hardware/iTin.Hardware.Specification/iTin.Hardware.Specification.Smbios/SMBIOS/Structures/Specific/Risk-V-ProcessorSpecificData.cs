
namespace iTin.Hardware.Specification.Smbios
{
    using System.Collections.Generic;
    using System.Diagnostics;

    using iTin.Core;

    // Type 044: Processor Specific Block > RISC-V Processor-specific Data. For more information, please see: https://github.com/riscv/riscv-smbios/blob/master/RISCV-SMBIOS.md#risc-v_processor-specific_data.
    // •—————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // |            Spec.                                                                                                |
    // | Offset     Version     Name                    Length      Value       Description                              |
    // •—————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 00h        0100h       Revision of RISC-V      WORD        0100h       Bit 15:08   Major revision               |
    // |            (v1.0)      Processor Specific                              Bit 07:00   Minor revision               |
    // |                        Block Specific                                  The newer revision of RISC-V Processor-  |
    // |                                                                        specific Block Structure is backward     |
    // |                                                                        compatible with older version of this    |
    // |                                                                        structure.                               |
    // •—————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 02h        0100h       Structure               BYTE        110         Length of Processor-specific Data.       |
    // |            (v1.0)      Length                                                                                   |
    // •—————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 03h        0100h       Hart ID                 DQWORD      Varies      The ID of this RISC-V Hart.              |
    // |            (v1.0)                                                                                               |
    // •—————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 13h        0100h       Boot Hart               BYTE        Boolean      1: This is boot hart to boot system     |
    // |            (v1.0)                                                       0: This is not the boot hart            |
    // •—————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 14h        0100h       Machine                 DQWORD      Varies       The vendor ID of this RISC-V Hart       |
    // |            (v1.0)      Vendor ID                                                                                |
    // •—————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 24h        0100h       Machine                 DQWORD      Varies       Base microarchitecture of the hart.     |
    // |            (v1.0)      Architecture ID                                  Value of 0 is possible to indicate the  |
    // |                                                                         ﬁeld is not implemented                 |
    // |                                                                         The combination of Machine Architecture |
    // |                                                                         ID and Machine Vendor ID should         |
    // |                                                                         uniquely identify the type of hart      |
    // •—————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 34h        0100h       Machine                 DQWORD      Varies       Unique encoding of the version of the   |
    // |            (v1.0)      Implementation ID                                processor implementation.               |
    // |                                                                         Value of 0 possible to indicate the     |
    // |                                                                         ﬁeld is not implemented.                |
    // |                                                                         The Implementation value should reﬂect  |
    // |                                                                         the design of the RISC-V Hart.          |
    // •—————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 44h        0100h       Instruction set         DWORD       Bit Field    Bit 25:00   encodes the presence of     |
    // |            (v1.0)      supported                                                    RISK-V standard extensions, |
    // |                                                                                     which is equivalent to      |
    // |                                                                                     bits [25:0] in RISC-V       |
    // |                                                                                     Machine ISA Register        |
    // |                                                                                     (misa CSR).                 |
    // |                                                                                     Bits set to one mean the    |
    // |                                                                                     certain extensions of       |
    // |                                                                                     instruction set are         |
    // |                                                                                     supported on this hart.     |
    // •—————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 48h        0100h       Privilege Level         BYTE        Varies       The privilege levels supported by this  |
    // |            (v1.0)      Supported                                        RISC-V Hart.                            |
    // |                                                                         Bit 00:    Machine Mode                 |
    // |                                                                         Bit 01:    Reserved                     |
    // |                                                                         Bit 02:    Supervisor Mode              |
    // |                                                                         Bit 03:    User Mode                    |
    // |                                                                         Bit 04:06  Reserved                     |
    // |                                                                         Bit 07     Debug Mode                   |
    // •—————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 49h        0100h       Machine                 DQWORD      Varies       Bit set to one means the corresponding  |
    // |            (v1.0)      Exception Trap                                   exception is delegated to supervisor    |
    // |                        Delegation                                       execution environment.                  |
    // |                        Information                                      Otherwise, supervisor execution         |
    // |                                                                         environment must register the event     |
    // |                                                                         handler in Machine-Mode for the certain |
    // |                                                                         exceptions through environment call.    |
    // •—————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 59h        0100h       Machine                 DQWORD      Varies       Bit set to one means the corresponding  |
    // |            (v1.0)      Interrupt Trap                                   Interrupt is delegated to supervisor    |
    // |                        Delegation                                       execution environment.                  |
    // |                        Information                                      Otherwise, supervisor execution         |
    // |                                                                         environment must register the event     |
    // |                                                                         handler in Machine-Mode for the certain |
    // |                                                                         Interrupts through environment call.    |
    // •—————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 69h        0100h       The register            BYTE        ENUM         The width of register supported by this |
    // |            (v1.0)      width (XLEN)                                     RISC-V Hart.                            |
    // •—————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 6Ah        0100h       The register            BYTE        ENUM         The width (See below) of Machine Mode   |
    // |                        width (XLEN)                                     native base integer ISA supported by    |
    // |                                                                         this RISC-V Hart.                       |
    // •—————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 6Bh        0100h       Reserved                BYTE        ENUM         Placeholder for Hypervisor Mode         |
    // •—————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 6Ch        0100h       Supervisor              BYTE        ENUM         The width of Supervisor Mode native     |
    // |            (v1.0)      Mode native                                      base integer ISA supported by this      |
    // |                        base integer                                     RISC-V Hart.                            |
    // |                        ISA width                                                                                |
    // |                        (S-XLEN)                                                                                 |
    // •—————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 6Dh        0100h       User Mode               BYTE        ENUM         The width of the User Mode native base  |
    // |            (v1.0)      native base                                      integer ISA supported by this RISC-V    |
    // |                        integer ISA                                      Hart.                                   |
    // |                        width (S-XLEN)                                                                           |
    // •—————————————————————————————————————————————————————————————————————————————————————————————————————————————————•

    /// <summary>
    /// This class represents a processor specific block of the structure <see cref="SmbiosType044"/>.
    /// </summary>
    public class RiskVProcessorSpecificData
    {
        #region private readonly memebrs
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private readonly byte[] _data;
        #endregion

        #region constructor/s

        #region [internal] RiskVProcessorSpecificData(byte[]): Initialize a new instance of the class specifying the structure information
        /// <summary>
        /// Initializes a new instance of the <see cref="RiskVProcessorSpecificData"/> class specifying the structure information.
        /// </summary>
        /// <param name="processorSpecificInformationBlockData">Untreated information of the current structure.</param>
        internal RiskVProcessorSpecificData(byte[] processorSpecificInformationBlockData)
        {
            _data = processorSpecificInformationBlockData;
        }
        #endregion

        #region [private] RiskVProcessorSpecificData(): Initialize a new instance of the class
        /// <summary>
        /// Initializes a new instance of the <see cref="RiskVProcessorSpecificData"/> class.
        /// </summary>
        private RiskVProcessorSpecificData()
        {
            _data = new List<byte>().ToArray();
        }
        #endregion

        #endregion

        #region public static properties

        #region [public] {static} (RiskVProcessorSpecificData) NotImplemented: Returns a new RiskVProcessorSpecificData instance that indicates that it has not been implemented.
        /// <summary>
        /// Returns a new <see cref="RiskVProcessorSpecificData"/> instance that indicates that it has not been implemented.
        /// </summary>
        /// <value>
        /// A new <see cref="RiskVProcessorSpecificData"/> instance.
        /// </value>
        public static RiskVProcessorSpecificData NotImplemented => new RiskVProcessorSpecificData();
        #endregion

        #endregion

        #region public properties

        #region [public] (byte?) MajorRevision: Gets a value that represents the 'Major Revision' field
        /// <summary>
        ///  Gets a value that represents the '<b>Major Revision</b>' field.
        /// </summary>
        /// <value>
        /// Value of the property.
        /// </value>
        public byte? MajorRevision => _data == null ? null : (byte?)((Revision & 0xf0) >> 7);
        #endregion

        #region [public] (byte?) MinorRevision: Gets a value that represents the 'Minor Revision' field
        /// <summary>
        ///  Gets a value that represents the '<b>Minor Revision</b>' field.
        /// </summary>
        /// <value>
        /// Value of the property.
        /// </value>
        public byte? MinorRevision => _data == null ? null : (byte?)(Revision & 0x0f);
        #endregion

        #region [public] (byte?) RegisterWidth: Gets a value that represents the 'Register Width (XLEN)' field
        /// <summary>
        ///  Gets a value that represents the '<b>Register Width (XLEN)</b>' field.
        /// </summary>
        /// <value>
        /// Value of the property.
        /// </value>
        public byte? RegisterWidth => _data?[0x69];
        #endregion

        #region [public] (string) MachineMode: Gets a value that represents the 'Machine Mode' field
        /// <summary>
        ///  Gets a value that represents the '<b>Machine Mode</b>' field.
        /// </summary>
        /// <value>
        /// Value of the property.
        /// </value>
        public string MachineMode => _data == null ? string.Empty : GetRiscNativeBaseIntegerISAWidth(_data[0x6a]);
        #endregion

        #region [public] (string) SupervisorMode: Gets a value that represents the 'Supervisor Mode' field
        /// <summary>
        ///  Gets a value that represents the '<b>Supervisor Mode</b>' field.
        /// </summary>
        /// <value>
        /// Value of the property.
        /// </value>
        public string SupervisorMode => _data == null ? string.Empty : GetRiscNativeBaseIntegerISAWidth(_data[0x6c]);
        #endregion

        #region [public] (string) UserMode: Gets a value that represents the 'User Mode' field
        /// <summary>
        ///  Gets a value that represents the '<b>User Mode</b>' field.
        /// </summary>
        /// <value>
        /// Value of the property.
        /// </value>
        public string UserMode => _data == null ? string.Empty : GetRiscNativeBaseIntegerISAWidth(_data[0x6d]);
        #endregion

        #endregion

        #region private properties

        #region [private] (int) Revision: Gets a value that represents the 'Revision' field
        /// <summary>
        ///  Gets a value that represents the '<b>Revision</b>' field.
        /// </summary>
        /// <value>
        /// Value of the property.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private int Revision => _data.GetWord(0x00);
        #endregion

        #region [private] (bool) BootHart: Gets a value that represents the 'Boot Hart' field
        /// <summary>
        ///  Gets a value that represents the '<b>Boot Hart</b>' field.
        /// </summary>
        /// <value>
        /// Value of the property.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private bool BootHart => _data[0x13] == 1;
        #endregion

        #endregion

        #region public override methods

        #region [public] {override} (string) ToString(): Devuelve una clase string que representa al objeto actual.
        /// <summary>
        /// Returns a class <see cref="string"/> that represents the current object.
        /// </summary>
        /// <returns>
        /// Object <see cref="string"/> that represents the current <see cref="RiskVProcessorSpecificData"/> class.
        /// </returns>
        public override string ToString() => $"Revision = {MajorRevision}{MinorRevision}";
        #endregion

        #endregion

        #region private static methods
        
        private static string GetRiscNativeBaseIntegerISAWidth(byte code)
        {
            string[] value =
            {
                "Unsupported", // 0x00
                "32-bit",
                "64-bit",
                "128-bit"      // 0x03
            };

            if (code <= 0x03)
            {
                return value[code];
            }

            return SmbiosHelper.OutOfSpec;
        }

        #endregion
    }
}
