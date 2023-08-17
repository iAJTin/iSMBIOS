
using iTin.Hardware.Specification.Smbios;

namespace iTin.Hardware.Specification.Dmi;

/// <summary>
/// The static class <see cref="DmiStructureFactory"/> creates the <see cref="DMI"/> structures.
/// </summary>
internal static class DmiStructureFactory
{
    /// <summary>
    /// Create list of available structures.
    /// </summary>
    /// <param name="smbiosType">Structure information.</param>
    /// <param name="smbiosVersion"><see cref="SMBIOS"/> version.</param>
    /// <returns>
    /// A class whichs implements <see cref="IDmiType"/> interface.
    /// </returns>
    public static IDmiType Create(SmbiosBaseType smbiosType, int smbiosVersion)
    {
        IDmiType result = smbiosType switch
        {
            SmbiosType000 type000 => new DmiType000(type000, smbiosVersion),
            SmbiosType001 type001 => new DmiType001(type001, smbiosVersion),
            SmbiosType002 type002 => new DmiType002(type002, smbiosVersion),
            SmbiosType003 type003 => new DmiType003(type003, smbiosVersion),
            SmbiosType004 type004 => new DmiType004(type004, smbiosVersion),
            SmbiosType005 type005 => new DmiType005(type005, smbiosVersion),
            SmbiosType006 type006 => new DmiType006(type006, smbiosVersion),
            SmbiosType007 type007 => new DmiType007(type007, smbiosVersion),
            SmbiosType008 type008 => new DmiType008(type008, smbiosVersion),
            SmbiosType009 type009 => new DmiType009(type009, smbiosVersion),
            SmbiosType010 type010 => new DmiType010(type010, smbiosVersion),
            SmbiosType011 type011 => new DmiType011(type011, smbiosVersion),
            SmbiosType012 type012 => new DmiType012(type012, smbiosVersion),
            SmbiosType013 type013 => new DmiType013(type013, smbiosVersion),
            SmbiosType014 type014 => new DmiType014(type014, smbiosVersion),
            SmbiosType015 type015 => new DmiType015(type015, smbiosVersion),
            SmbiosType016 type016 => new DmiType016(type016, smbiosVersion),
            SmbiosType017 type017 => new DmiType017(type017, smbiosVersion),
            SmbiosType018 type018 => new DmiType018(type018, smbiosVersion),
            SmbiosType019 type019 => new DmiType019(type019, smbiosVersion),
            SmbiosType020 type020 => new DmiType020(type020, smbiosVersion),
            SmbiosType021 type021 => new DmiType021(type021, smbiosVersion),
            SmbiosType022 type022 => new DmiType022(type022, smbiosVersion),
            SmbiosType023 type023 => new DmiType023(type023, smbiosVersion),
            SmbiosType024 type024 => new DmiType024(type024, smbiosVersion),
            SmbiosType025 type025 => new DmiType025(type025, smbiosVersion),
            SmbiosType026 type026 => new DmiType026(type026, smbiosVersion),
            SmbiosType027 type027 => new DmiType027(type027, smbiosVersion),
            SmbiosType028 type028 => new DmiType028(type028, smbiosVersion),
            SmbiosType029 type029 => new DmiType029(type029, smbiosVersion),
            SmbiosType030 type030 => new DmiType030(type030, smbiosVersion),
            SmbiosType031 type031 => new DmiType031(type031, smbiosVersion),
            SmbiosType032 type032 => new DmiType032(type032, smbiosVersion),
            SmbiosType033 type033 => new DmiType033(type033, smbiosVersion),
            SmbiosType034 type034 => new DmiType034(type034, smbiosVersion),
            SmbiosType035 type035 => new DmiType035(type035, smbiosVersion),
            SmbiosType036 type036 => new DmiType036(type036, smbiosVersion),
            SmbiosType037 type037 => new DmiType037(type037, smbiosVersion),
            SmbiosType038 type038 => new DmiType038(type038, smbiosVersion),
            SmbiosType039 type039 => new DmiType039(type039, smbiosVersion),
            SmbiosType040 type040 => new DmiType040(type040, smbiosVersion),
            SmbiosType041 type041 => new DmiType041(type041, smbiosVersion),
            SmbiosType042 type042 => new DmiType042(type042, smbiosVersion),
            SmbiosType043 type043 => new DmiType043(type043, smbiosVersion),
            SmbiosType044 type044 => new DmiType044(type044, smbiosVersion),
            SmbiosType045 type045 => new DmiType045(type045, smbiosVersion),
            SmbiosType046 type046 => new DmiType046(type046, smbiosVersion),
            SmbiosType126 type126 => new DmiType126(type126, smbiosVersion),
            SmbiosType127 type127 => new DmiType127(type127, smbiosVersion),
            _ => null
        };

        return result;
    }
}
