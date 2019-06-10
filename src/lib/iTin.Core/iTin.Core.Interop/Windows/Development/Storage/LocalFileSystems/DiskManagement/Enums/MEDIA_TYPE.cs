
namespace iTin.Core.Interop.Windows.Development.Storage.LocalFileSystems.DiskManagement
{
    /// <summary>
    /// Representa las diversas formas de los dispositivos.
    /// </summary>
    /// <remarks>
    /// Para más información ver: http://msdn.microsoft.com/en-us/library/aa365231%28v=VS.85%29.aspx
    /// </remarks>
    enum MEDIA_TYPE : uint
    {
        /// <summary>
        /// Formato desconocido.
        /// </summary>
        Unknown,
        /// <summary>
        /// A 5.25" floppy, with 1.2MB and 512 bytes/sector.
        /// </summary>
        F5_1Pt2_512,
        /// <summary>
        /// A 3.5" floppy, with 1.44MB and 512 bytes/sector.
        /// </summary>
        F3_1Pt44_512,
        /// <summary>
        /// A 3.5" floppy, with 2.88MB and 512 bytes/sector.
        /// </summary>
        F3_2Pt88_512,
        /// <summary>
        /// A 3.5" floppy, with 20.8MB and 512 bytes/sector.
        /// </summary>
        F3_20Pt8_512,
        /// <summary>
        /// A 3.5" floppy, with 720KB and 512 bytes/sector.
        /// </summary>
        F3_720_512,
        /// <summary>
        /// A 5.25" floppy, with 360KB and 512 bytes/sector.
        /// </summary>
        F5_360_512,
        /// <summary>
        /// A 5.25" floppy, with 320KB and 512 bytes/sector.
        /// </summary>
        F5_320_512,
        /// <summary>
        /// A 5.25" floppy, with 320KB and 1024 bytes/sector.
        /// </summary>
        F5_320_1024,
        /// <summary>
        /// A 5.25" floppy, with 180KB and 512 bytes/sector.
        /// </summary>
        F5_180_512,
        /// <summary>
        /// A 5.25" floppy, with 160KB and 512 bytes/sector.
        /// </summary>
        F5_160_512,
        /// <summary>
        /// Removable media other than floppy.
        /// </summary>
        RemovableMedia,
        /// <summary>
        /// Fixed hard disk media.
        /// </summary>
        FixedMedia,
        /// <summary>
        /// A 3.5" floppy, with 120MB and 512 bytes/sector.
        /// </summary>
        F3_120M_512,
        /// <summary>
        /// A 3.5" floppy, with 640KB and 512 bytes/sector.
        /// </summary>
        F3_640_512,
        /// <summary>
        /// A 5.25" floppy, with 640KB and 512 bytes/sector.
        /// </summary>
        F5_640_512,
        /// <summary>
        /// A 5.25" floppy, with 720KB and 512 bytes/sector.
        /// </summary>
        F5_720_512,
        /// <summary>
        /// A 3.5" floppy, with 1.2MB and 512 bytes/sector.
        /// </summary>
        F3_1Pt2_512,
        /// <summary>
        /// A 3.5" floppy, with 1.23MB and 1024 bytes/sector.
        /// </summary>
        F3_1Pt23_1024,
        /// <summary>
        /// A 5.25" floppy, with 1.23MB and 1024 bytes/sector.
        /// </summary>
        F5_1Pt23_1024,
        /// <summary>
        /// A 3.5" floppy, with 128MB and 512 bytes/sector.
        /// </summary>
        F3_128Mb_512,
        /// <summary>
        /// A 3.5" floppy, with 230MB and 512 bytes/sector.
        /// </summary>
        F3_230Mb_512,
        /// <summary>
        /// An 8" floppy, with 256KB and 128 bytes/sector.
        /// </summary>
        F8_256_128,
        /// <summary>
        /// A 3.5" floppy, with 200MB and 512 bytes/sector. (HiFD).
        /// </summary>
        F3_200Mb_512,
        /// <summary>
        /// A 3.5" floppy, with 240MB and 512 bytes/sector. (HiFD).
        /// </summary>
        F3_240M_512,
        /// <summary>
        /// A 3.5" floppy, with 32MB and 512 bytes/sector.
        /// </summary>
        F3_32M_512,

        /// <summary>
        /// Tape - DAT DDS1,2,... (all vendors)
        /// </summary>
        DDS_4mm = 0x20,
        /// <summary>
        /// Tape - miniQIC Tape
        /// </summary>
        MiniQic,
        /// <summary>
        /// Tape - Travan TR-1,2,3,...
        /// </summary>
        Travan,
        /// <summary>
        /// Tape - QIC
        /// </summary>
        QIC,
        /// <summary>
        /// Tape - 8mm Exabyte Metal Particle
        /// </summary>
        MP_8mm,
        /// <summary>
        /// Tape - 8mm Exabyte Advanced Metal Evap
        /// </summary>           
        AME_8mm,
        /// <summary>
        /// Tape - 8mm Sony AIT
        /// </summary>
        AIT1_8mm,
        /// <summary>
        /// Tape - DLT Compact IIIxt, IV
        /// </summary>
        DLT,
        /// <summary>
        /// Tape - Philips NCTP
        /// </summary>
        NCTP,
        /// <summary>
        /// Tape - IBM 3480
        /// </summary>
        IBM_3480,
        /// <summary>
        /// Tape - IBM 3490E
        /// </summary>
        IBM_3490E,
        /// <summary>
        /// Tape - IBM Magstar 3590
        /// </summary>
        IBM_Magstar_3590,
        /// <summary>
        /// Tape - IBM Magstar MP
        /// </summary>
        IBM_Magstar_MP,
        /// <summary>
        /// Tape - STK Data D3
        /// </summary>
        STK_DATA_D3,
        /// <summary>
        /// Tape - Sony DTF
        /// </summary>
        SONY_DTF,
        /// <summary>
        /// Tape - 6mm Digital Video
        /// </summary>
        DV_6mm,
        /// <summary>
        /// Tape - Exabyte DMI and compatibles
        /// </summary>
        DMI,
        /// <summary>
        /// Tape - Sony D2S and D2L
        /// </summary>
        SONY_D2,
        /// <summary>
        /// Cleaner - All Drive types that support Drive Cleaners
        /// </summary>
        CLEANER_CARTRIDGE,
        /// <summary>
        /// Opt_Disk - CD
        /// </summary>
        CDRom,
        /// <summary>
        /// Opt_Disk - CD-Recordable (Write Once)
        /// </summary>
        CDRecordable,
        /// <summary>
        /// Opt_Disk - CD-Rewriteable
        /// </summary>
        CDRewritable,
        /// <summary>
        /// Opt_Disk - DVD-ROM
        /// </summary>
        DvdRom,
        /// <summary>
        /// Opt_Disk - DVD-Recordable (Write Once)
        /// </summary>
        DvdRecordable,
        /// <summary>
        /// Opt_Disk - DVD-Rewriteable
        /// </summary>
        DvdRewritable,
        /// <summary>
        /// Opt_Disk - 3.5" Rewriteable MO Disk
        /// </summary>
        MO_3_RW,
        /// <summary>
        /// Opt_Disk - MO 5.25" Write Once
        /// </summary>
        MO_5_WO,
        /// <summary>
        /// Opt_Disk - MO 5.25" Rewriteable (not LIMDOW)
        /// </summary>
        MO_5_RW,
        /// <summary>
        /// Opt_Disk - MO 5.25" Rewriteable (LIMDOW)
        /// </summary>
        MO_5_LIMDOW,
        /// <summary>
        /// Opt_Disk - Phase Change 5.25" Write Once Optical
        /// </summary>
        PC_5_WO,
        /// <summary>
        /// Opt_Disk - Phase Change 5.25" Rewriteable
        /// </summary>
        PC_5_RW,
        /// <summary>
        /// Opt_Disk - PhaseChange Dual Rewriteable
        /// </summary>
        PD_5_RW,
        /// <summary>
        /// Opt_Disk - Ablative 5.25" Write Once Optical
        /// </summary>
        ABL_5_WO,
        /// <summary>
        /// Opt_Disk - Pinnacle Apex 4.6GB Rewriteable Optical
        /// </summary>
        PINNACLE_APEX_5_RW,
        /// <summary>
        /// Opt_Disk - Sony 12" Write Once
        /// </summary>
        SONY_12_WO,
        /// <summary>
        /// Opt_Disk - Philips/LMS 12" Write Once
        /// </summary>
        PHILIPS_12_WO,
        /// <summary>
        /// Opt_Disk - Hitachi 12" Write Once
        /// </summary>
        HITACHI_12_WO,
        /// <summary>
        /// Opt_Disk - Cygnet/ATG 12" Write Once
        /// </summary>
        CYGNET_12_WO,
        /// <summary>
        /// Opt_Disk - Kodak 14" Write Once
        /// </summary>
        KODAK_14_WO,
        /// <summary>
        /// Opt_Disk - Near Field Recording (Terastor)
        /// </summary>
        MO_NFR_525,
        /// <summary>
        /// Opt_Disk - Nikon 12" Rewriteable
        /// </summary>
        NIKON_12_RW,
        /// <summary>
        /// Mag_Disk - Iomega Zip
        /// </summary>
        IOMEGA_ZIP,
        /// <summary>
        /// Mag_Disk - Iomega Jaz
        /// </summary>
        IOMEGA_JAZ,
        /// <summary>
        /// Mag_Disk - Syquest EZ135
        /// </summary>
        SYQUEST_EZ135,
        /// <summary>
        /// Mag_Disk - Syquest EzFlyer
        /// </summary>
        SYQUEST_EZFLYER,
        /// <summary>
        /// Mag_Disk - Syquest SyJet
        /// </summary>
        SYQUEST_SYJET,
        /// <summary>
        /// Mag_Disk - 2.5" Floppy
        /// </summary>
        AVATAR_F2,
        /// <summary>
        /// Tape - 8mm Hitachi
        /// </summary>
        MP2_8mm,
        /// <summary>
        /// Ampex DST Small Tapes
        /// </summary>
        DST_S,
        /// <summary>
        /// Ampex DST Medium Tapes
        /// </summary>
        DST_M,
        /// <summary>
        /// Ampex DST Large Tapes
        /// </summary>
        DST_L,
        /// <summary>
        /// Ecrix 8mm Tape
        /// </summary>
        VXATape_1,
        /// <summary>
        /// Ecrix 8mm Tape
        /// </summary>
        VXATape_2,
        /// <summary>
        /// STK 9840
        /// </summary>
        STK_9840,
        /// <summary>
        /// IBM, HP, Seagate LTO Ultrium
        /// </summary>
        LTO_Ultrium,
        /// <summary>
        /// IBM, HP, Seagate LTO Accelis
        /// </summary>
        LTO_Accelis,
        /// <summary>
        /// Opt_Disk - DVD-RAM
        /// </summary>
        DvdRam,
        /// <summary>
        /// AIT2 or higher
        /// </summary>
        AIT_8mm,
        /// <summary>
        /// OnStream ADR Mediatypes
        /// </summary>
        ADR_1,
        /// <summary>
        /// OnStream ADR Mediatypes
        /// </summary>
        ADR_2,
        /// <summary>
        /// STK 9940
        /// </summary>
        STK_9940,
        /// <summary>
        /// SAIT Tapes
        /// </summary>
        SAIT,
        /// <summary>
        /// VXA (Ecrix 8mm) Tape
        /// </summary>
        VXATape
    }
}