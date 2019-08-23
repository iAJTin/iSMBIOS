
namespace iTin.Core.Hardware.Specification.Tpm
{
    /// <summary>
    /// Represents <c>TPM Capabilities Vendor ID (CAP_VID)</c>.
    /// </summary>
    public class TpmCapabilityVendorId
    {
        #region public static readonly properties
        public static TpmCapabilityVendorId AMD => new TpmCapabilityVendorId {ASCII = "AMD", Description = "AMD", Hex = new byte[] {0x41, 0x4d, 0x44, 0x00}};

        public static TpmCapabilityVendorId Atmel => new TpmCapabilityVendorId {ASCII = "ATML", Description = "Atmel", Hex = new byte[] {0x41, 0x54, 0x4d, 0x4c}};

        public static TpmCapabilityVendorId Broadcom => new TpmCapabilityVendorId {ASCII = "BRCM", Description = "Broadcom", Hex = new byte[] {0x42, 0x52, 0x43, 0x4d}};

        public static TpmCapabilityVendorId HPE => new TpmCapabilityVendorId {ASCII = "HPE", Description = "HPE", Hex = new byte[] {0x48, 0x50, 0x45, 0x00}};

        public static TpmCapabilityVendorId IBM => new TpmCapabilityVendorId {ASCII = "IBM ", Description = "IBM", Hex = new byte[] {0x49, 0x42, 0x4d, 0x00}};

        public static TpmCapabilityVendorId Infineon => new TpmCapabilityVendorId {ASCII = "IFX ", Description = "Infineon", Hex = new byte[] {0x49, 0x46, 0x58, 0x00}};

        public static TpmCapabilityVendorId Intel => new TpmCapabilityVendorId {ASCII = "INTC ", Description = "Intel", Hex = new byte[] {0x49, 0x4e, 0x54, 0x43}};

        public static TpmCapabilityVendorId Lenovo => new TpmCapabilityVendorId {ASCII = "LEN ", Description = "Lenovo", Hex = new byte[] {0x4c, 0x45, 0x4e, 0x00}};

        public static TpmCapabilityVendorId Microsoft => new TpmCapabilityVendorId {ASCII = "MSFT", Description = "Microsoft", Hex = new byte[] {0x4d, 0x53, 0x46, 0x54}};

        public static TpmCapabilityVendorId NationalSemiconductor => new TpmCapabilityVendorId {ASCII = "NSM ", Description = "National Semiconductor", Hex = new byte[] {0x4e, 0x53, 0x4d, 0x20}};

        public static TpmCapabilityVendorId Nationz => new TpmCapabilityVendorId {ASCII = "NTZ ", Description = "Nationz", Hex = new byte[] {0x4e, 0x54, 0x5a, 0x00}};

        public static TpmCapabilityVendorId NuvotonTechnology => new TpmCapabilityVendorId {ASCII = "NTC ", Description = "Nuvoton Technology", Hex = new byte[] { 0x4e, 0x54, 0x43, 0x00}};

        public static TpmCapabilityVendorId Qualcomm => new TpmCapabilityVendorId {ASCII = "QCOM ", Description = "Qualcomm", Hex = new byte[] {0x51, 0x43, 0x4f, 0x4d}};

        public static TpmCapabilityVendorId SMSC => new TpmCapabilityVendorId {ASCII = "SMSC", Description = "SMSC", Hex = new byte[] {0x53, 0x4d, 0x53, 0x43}};

        public static TpmCapabilityVendorId STMicroelectronics => new TpmCapabilityVendorId {ASCII = "STM", Description = "ST Microelectronics", Hex = new byte[] {0x53, 0x54, 0x4d, 0x20}};

        public static TpmCapabilityVendorId Samsung => new TpmCapabilityVendorId {ASCII = "SMSN", Description = "Samsung", Hex = new byte[] {0x53, 0x4d, 0x53, 0x4e}};

        public static TpmCapabilityVendorId Sinosun => new TpmCapabilityVendorId {ASCII = "SNS", Description = "Sinosun", Hex = new byte[] {0x53, 0x4e, 0x53, 0x00}};

        public static TpmCapabilityVendorId TexasInstruments => new TpmCapabilityVendorId {ASCII = "TXN", Description = "Texas Instruments", Hex = new byte[] {0x54, 0x58, 0x4e, 0x00}};

        public static TpmCapabilityVendorId Winbond => new TpmCapabilityVendorId {ASCII = "WEC", Description = "Winbond", Hex = new byte[] {0x57, 0x45, 0x43, 0x00}};

        public static TpmCapabilityVendorId FuzhouRockchip => new TpmCapabilityVendorId {ASCII = "ROCC", Description = "Fuzhou Rockchip", Hex = new byte[] {0x52, 0x4f, 0x43, 0x43}};

        public static TpmCapabilityVendorId Google => new TpmCapabilityVendorId {ASCII = "GOOG", Description = "Google", Hex = new byte[] {0x47, 0x4f, 0x4f, 0x47}};
        #endregion

        #region public properties

        #region [private] (string) ASCII: Gets or sets a value representing the informative representation of the normative hexadecimal value
        /// <summary>
        /// Gets or sets a value representing the informative representation of the normative hexadecimal value
        /// </summary>
        /// <value>
        /// Informative representation of the normative hexadecimal value.
        /// </value>
        public string ASCII { get; set; }
        #endregion

        #region [private] (string) Description: Gets or sets a value representing Vendor Id description
        /// <summary>
        /// Gets or sets a value representing Vendor Id description.
        /// </summary>
        /// <value>
        /// Vendor Id as hexadecimal.
        /// </value>
        public string Description { get; set; }
        #endregion

        #region [private] (byte[]) Hex: Gets or sets a value representing Vendor Id as Hexadecimal
        /// <summary>
        /// Gets or sets a value representing Vendor Id as hexadecimal.
        /// </summary>
        /// <value>
        /// Vendor Id as hexadecimal.
        /// </value>
        public byte[] Hex { get; set; }
        #endregion

        #endregion
    }
}
