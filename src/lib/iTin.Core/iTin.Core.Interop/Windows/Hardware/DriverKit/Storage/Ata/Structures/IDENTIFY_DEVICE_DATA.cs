
namespace iTin.Core.Interop.Windows.Hardware.DriverKit.Storage.Ata
{
    using System.Collections.Specialized;
    using System.Runtime.InteropServices;

    using Helpers;
    using Helpers.Enumerations;

    using UCHAR = System.Byte;
    using USHORT = System.UInt16;

    /// <summary>
    /// The <strong>IDENTIFY_DEVICE_DATA</strong> structure contains the identification data of an ATA device by the command (0xEC).
    /// </summary>
    /// <remarks>
    /// For more information, please see https://docs.microsoft.com/en-us/windows-hardware/drivers/ddi/content/ata/ns-ata-_identify_device_data
    /// </remarks>
    //[StructLayout(LayoutKind.Sequential)]
    //[StructLayout(LayoutKind.Explicit, Size = 512, Pack = sizeof(ushort))]
    public struct IDENTIFY_DEVICE_DATA
    {
        #region public enumerations

        public enum StateFeature
        {
            Bit48Lba                     = 0x00000001,

            AdvancedPowerManagement      = 0x00000002,

            AutomaticAcousticManagement  = 0x00000004,

            DeviceConfigurationOverlay   = 0x00000008,

            DmaSetupAutoActivate         = 0x00000010,

            GeneralPurposeLogging        = 0x00000020,

            HostProtectedArea            = 0x00000040,

            InOrderDataDelivery          = 0x00000080,

            NativeCommandQueuing         = 0x00000100,

            PhyEventCounters             = 0x00000200,

            PowerManagement              = 0x00000400,

            PowerUpInStandby             = 0x00000800,

            ReadLookAhead                = 0x00001000,

            ReleaseInterrupt             = 0x00002000,

            SecurityMode                 = 0x00004000,

            Smart                        = 0x00008000,

            SmartErrorLogging            = 0x00010000,

            SmartSelfTest                = 0x00020000,

            SoftwareSettingsPreservation = 0x00040000,

            Streaming                    = 0x00080000,

            TaggedCommandQueuing         = 0x00100000,

            WriteCache                   = 0x00200000,
        }

        #endregion

        #region public members

        public USHORT word000;
        public USHORT word001;
        public USHORT word002;

        /// <summary>
        /// word003: Number of heads in default translate mode
        /// </summary>
        public USHORT word003;

        /// <summary>
        /// Word 004-005: Reserved for the CompactFlash Association
        /// </summary>
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
        public USHORT[] Retired1;

        /// <summary>
        /// word006: Number of sectors per track in default translate mode
        /// </summary>
        public USHORT word006;

        /// <summary>
        /// Word 007-008: Reserved for the CompactFlash Association
        /// </summary>
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
        public USHORT[] CompactFlashAssociation;

        /// <summary>
        /// word 009: Reserved
        /// </summary>
        public USHORT word009;

        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 20)]
        public UCHAR[] SerialNumber;

        public USHORT word020;
        public USHORT word021;
        public USHORT word022;

        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
        public UCHAR[] FirmwareRevision;

        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 40)]
        public UCHAR[] ModelNumber;

        public USHORT word047;
        public USHORT word048;
        public USHORT word049;
        public USHORT word050;
        public USHORT word051;
        public USHORT word052;
        public USHORT word053;
        public USHORT word054;
        public USHORT word055;
        public USHORT word056;
        public USHORT word057;
        public USHORT word058;
        public USHORT word059;
        public USHORT word060;
        public USHORT word061;
        public USHORT word062;
        public USHORT word063;
        public USHORT word064;
        public USHORT word065;
        public USHORT word066;
        public USHORT word067;
        public USHORT word068;
        public USHORT word069;
        public USHORT word070;
        public USHORT word071;
        public USHORT word072;
        public USHORT word073;
        public USHORT word074;
        public USHORT word075;

        /// <summary>
        /// Word076 : Serial ATA Capabilities
        /// </summary>
        public USHORT word076;
        
        /// <summary>
        /// Word 77: Reserved for Serial ATA
        /// </summary>
        public USHORT word077;

        /// <summary>
        /// Word078: Serial ATA features supported
        /// </summary>
        public USHORT word078;

        /// <summary>
        /// Word079: Serial ATA features enabled
        /// <list type="bullet"> //| "number" | "table"
        /// <listheader>
        ///     <term>Bits</term>
        ///     <description>Description</description>
        /// </listheader>
        /// <item>
        ///     <term>15:07</term>
        ///     <description>Reserved for Serial ATA</description>
        /// </item>
        /// <item>
        ///     <term>06</term>
        ///     <description>Software Settings Preservation enabled</description>
        /// </item>
        /// </list>
        /// </summary>
        public USHORT word079;

        /// <summary>
        /// Word080: Major version number
        /// </summary>
        public USHORT word080;

        public USHORT word081;
        public USHORT word082;
        public USHORT word083;
        public USHORT word084;
        public USHORT word085;
        public USHORT word086;
        public USHORT word087;
        public USHORT word088;
        public USHORT word089;
        public USHORT word090;
        public USHORT word091;
        public USHORT word092;
        public USHORT word093;
        public USHORT word094;
        public USHORT word095;
        public USHORT word096;
        public USHORT word097;
        public USHORT word098;
        public USHORT word099;
        public USHORT word100;
        public USHORT word101;
        public USHORT word102;
        public USHORT word103;
        public USHORT word104;
        public USHORT word105;
        public USHORT word106;
        public USHORT word107;
        public USHORT word108;
        public USHORT word109;
        public USHORT word110;
        public USHORT word111;
        public USHORT word112;
        public USHORT word113;
        public USHORT word114;
        public USHORT word115;
        public USHORT word116;
        public USHORT word117;
        public USHORT word118;
        public USHORT word119;
        public USHORT word120;
        public USHORT word121;
        public USHORT word122;
        public USHORT word123;
        public USHORT word124;
        public USHORT word125;
        public USHORT word126;
        public USHORT word127;
        public USHORT word128;
        public USHORT word129;
        public USHORT word130;
        public USHORT word131;
        public USHORT word132;
        public USHORT word133;
        public USHORT word134;
        public USHORT word135;
        public USHORT word136;
        public USHORT word137;
        public USHORT word138;
        public USHORT word139;
        public USHORT word140;
        public USHORT word141;
        public USHORT word142;
        public USHORT word143;
        public USHORT word144;
        public USHORT word145;
        public USHORT word146;
        public USHORT word147;
        public USHORT word148;
        public USHORT word149;
        public USHORT word150;
        public USHORT word151;
        public USHORT word152;
        public USHORT word153;
        public USHORT word154;
        public USHORT word155;
        public USHORT word156;
        public USHORT word157;
        public USHORT word158;
        public USHORT word159;
        public USHORT word160;
        public USHORT word161;
        public USHORT word162;
        public USHORT word163;
        public USHORT word164;
        public USHORT word165;
        public USHORT word166;
        public USHORT word167;
        public USHORT word168;
        public USHORT word169;

        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
        public UCHAR[] AdditionalProductIdentifier;

        public USHORT word174;
        public USHORT word175;

        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 60)]
        public UCHAR[] CurrentMediaSerialNumber;

        public USHORT word206;
        public USHORT word207;
        public USHORT word208;
        public USHORT word209;
        public USHORT word210;
        public USHORT word211;
        public USHORT word212;
        public USHORT word213;
        public USHORT word214;
        public USHORT word215;
        public USHORT word216;
        public USHORT NominalMediaRotationRate;
        public USHORT word218;
        public USHORT word219;
        public USHORT word220;
        public USHORT word221;
        public USHORT word222;
        public USHORT word223;
        public USHORT word224;
        public USHORT word225;
        public USHORT word226;
        public USHORT word227;
        public USHORT word228;
        public USHORT word229;
        public USHORT word230;
        public USHORT word231;
        public USHORT word232;
        public USHORT word233;
        public USHORT word234;
        public USHORT word235;
        public USHORT word236;
        public USHORT word237;
        public USHORT word238;
        public USHORT word239;
        public USHORT word240;
        public USHORT word241;
        public USHORT word242;
        public USHORT word243;
        public USHORT word244;
        public USHORT word245;
        public USHORT word246;
        public USHORT word247;
        public USHORT word248;
        public USHORT word249;
        public USHORT word250;
        public USHORT word251;
        public USHORT word252;
        public USHORT word253;
        public USHORT word254;
        public USHORT word255;

        #endregion

        #region private members
        private BitVector32 _StateFeatures;// = new BitVector32(-1);
        private BitVector32 _SupportedFeatures;// = new BitVector32(-1);
        #endregion

        #region public methods

        #region [public] (bool) GetSupportedFeature(StateFeature): 
        /// <summary>
        /// Gets the supported feature.
        /// </summary>
        /// <param name="feature">The feature.</param>
        /// <returns></returns>
        public bool GetSupportedFeature(StateFeature feature)
        {
            if (_SupportedFeatures.Data == 0x0000)
            {
                FillSupportedFeatures();
            }

            return _SupportedFeatures[(int)feature];            
        }
        #endregion

        #endregion

        #region private methods

        private void FillSupportedFeatures()
        {
            _SupportedFeatures[(int)StateFeature.NativeCommandQueuing]         = LogicHelper.CheckBit(word076, Bits.Bit08);
            _SupportedFeatures[(int)StateFeature.PhyEventCounters]             = LogicHelper.CheckBit(word076, Bits.Bit10);

            _SupportedFeatures[(int)StateFeature.DmaSetupAutoActivate]         = LogicHelper.CheckBit(word078, Bits.Bit02);
            _SupportedFeatures[(int)StateFeature.InOrderDataDelivery]          = LogicHelper.CheckBit(word078, Bits.Bit04);
            _SupportedFeatures[(int)StateFeature.SoftwareSettingsPreservation] = LogicHelper.CheckBit(word078, Bits.Bit06);

            _SupportedFeatures[(int)StateFeature.Smart]                        = LogicHelper.CheckBit(word082, Bits.Bit00);
            _SupportedFeatures[(int)StateFeature.SecurityMode]                 = LogicHelper.CheckBit(word082, Bits.Bit01); 
            _SupportedFeatures[(int)StateFeature.WriteCache]                   = LogicHelper.CheckBit(word082, Bits.Bit05);
            _SupportedFeatures[(int)StateFeature.ReadLookAhead]                = LogicHelper.CheckBit(word082, Bits.Bit06);
            _SupportedFeatures[(int)StateFeature.ReleaseInterrupt]             = LogicHelper.CheckBit(word082, Bits.Bit07);

            _SupportedFeatures[(int)StateFeature.AdvancedPowerManagement]      = LogicHelper.CheckBit(word083, Bits.Bit03);
            _SupportedFeatures[(int)StateFeature.PowerUpInStandby]             = LogicHelper.CheckBit(word083, Bits.Bit05);
            _SupportedFeatures[(int)StateFeature.AutomaticAcousticManagement]  = LogicHelper.CheckBit(word083, Bits.Bit09);
            _SupportedFeatures[(int)StateFeature.Bit48Lba]                     = LogicHelper.CheckBit(word083, Bits.Bit10);
            _SupportedFeatures[(int)StateFeature.DeviceConfigurationOverlay]   = LogicHelper.CheckBit(word083, Bits.Bit11);
            
            _SupportedFeatures[(int)StateFeature.SmartErrorLogging]            = LogicHelper.CheckBit(word084, Bits.Bit00);
            _SupportedFeatures[(int)StateFeature.SmartSelfTest]                = LogicHelper.CheckBit(word084, Bits.Bit01);
            _SupportedFeatures[(int)StateFeature.Streaming]                    = LogicHelper.CheckBit(word084, Bits.Bit04);

            _SupportedFeatures[(int)StateFeature.PowerManagement]              = LogicHelper.CheckBit(word085, Bits.Bit03);
            _SupportedFeatures[(int)StateFeature.HostProtectedArea]            = LogicHelper.CheckBit(word085, Bits.Bit10);

            _SupportedFeatures[(int)StateFeature.GeneralPurposeLogging]        = LogicHelper.CheckBit(word087, Bits.Bit05);

            _SupportedFeatures[(int)StateFeature.TaggedCommandQueuing]         = false;
        }

        #endregion
    }
}

//#region public properties

//public string ModelNumber
//{
//    get
//    {
//        byte[] mnArray = new byte[modelNumber.Length];

//        Array.Copy(modelNumber, 0, mnArray, 0, modelNumber.Length - 1);
//        mnArray.SwapBytes();
//        var model = new StringBuilder();
//        model.Append(Encoding.ASCII.GetString(mnArray, 0, mnArray.Length));

//        return model.ToString().Trim();
//    }
//}

//#endregion
