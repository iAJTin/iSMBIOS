
namespace iTin.Core.Hardware.Specification.Smbios
{
    using Helpers;

    /// <summary>
    /// Represents the <b>Header</b> structure contained in the initial four bytes of each <see cref="SMBIOS"/> structure.
    /// </summary>
    public class SmbiosStructureHeaderInfo
    {
        #region constructor/s

        #region [internal] SmbiosStructureHeaderInfo(byte[]): Initializes a new instance of the class
        /// <summary>
        /// Initializes a new instance of the <see cref="SmbiosStructureHeaderInfo"/> class.
        /// </summary>
        /// <param name="rawData">The raw data.</param>
        internal SmbiosStructureHeaderInfo(byte[] rawData)
        {
            StructureType = (SmbiosStructure)rawData[0x00];
            Length = rawData[0x01];
            Handle = LogicHelper.Word(rawData[0x02], rawData[0x03]);
            RawData = rawData;
        }
        #endregion

        #endregion

        #region public properties

        #region public (int) Length: Gets the length of the formatted area of the current SMBIOS structure
        /// <summary>
        /// Gets the length of the formatted area of the current <see cref="SMBIOS"/> structure.
        /// </summary>
        /// <value>
        /// Length of the current <see cref="SMBIOS"/> structure.
        /// </value>
        /// <remarks>
        /// Specifies the length of the formatted area of the current structure. 
        /// Starting at position 0, the length of the formatted zone of strings is not taken into account.
        /// </remarks>
        public int Length { get; }
        #endregion

        #region public (int) Handle: Gets the handle of the current structure
        /// <summary>
        /// Gets the handle of the current structure.
        /// </summary>
        /// <value>
        /// Handle of the current structure.
        /// </value>
        public int Handle { get; }
        #endregion

        #region public (byte[]) RawData: Gets an array with the raw data
        /// <summary>
        /// Gets an array with the raw data.
        /// </summary>
        /// <value>
        /// Array with raw data.
        /// </value>
        public byte[] RawData { get; }
        #endregion

        #region public (SmbiosStructure) StructureType: Gets the length of the formatted area of the current SMBIOS structure
        /// <summary>
        /// Gets the current <see cref="SMBIOS"/> structure type.
        /// </summary>
        /// <value>
        /// One of the <see cref="SmbiosStructure"/> values representing the current struct
        /// </value>
        public SmbiosStructure StructureType { get; }
        #endregion

        #endregion

        #region public override methods

        #region [public] {override} (string) ToString(): Returns a string that represents this instance
        /// <summary>
        /// Returns a <see cref="string"/> that represents this instance.
        /// </summary>
        /// <returns>A <see cref="string"/> that represents this instance.</returns>
        /// <remarks>
        /// The <see cref="ToString()"/> method returns a string that includes the <see cref="StructureType"/> property, <see cref="Handle"/> y <see cref="Length"/>.
        /// </remarks>
        public override string ToString() => $"Type = {StructureType}, Handle = {Handle:X}, Length = {Length}";
        #endregion

        #endregion
    }
}
