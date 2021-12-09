
namespace iTin.Hardware.Specification.Dmi
{
    using Smbios;

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
            IDmiType result = null;

            switch (smbiosType)
            {
                case SmbiosType000 type000:
                    result = new DmiType000(type000, smbiosVersion);
                    break;

                case SmbiosType001 type001:
                    result = new DmiType001(type001, smbiosVersion);
                    break;

                case SmbiosType002 type002:
                    result = new DmiType002(type002, smbiosVersion);
                    break;

                case SmbiosType003 type003:
                    result = new DmiType003(type003, smbiosVersion);
                    break;

                case SmbiosType004 type004:
                    result = new DmiType004(type004, smbiosVersion);
                    break;

                case SmbiosType005 type005:
                    result = new DmiType005(type005, smbiosVersion);
                    break;

                case SmbiosType006 type006:
                    result = new DmiType006(type006, smbiosVersion);
                    break;

                case SmbiosType007 type007:
                    result = new DmiType007(type007, smbiosVersion);
                    break;

                case SmbiosType008 type008:
                    result = new DmiType008(type008, smbiosVersion);
                    break;

                case SmbiosType009 type009:
                    result = new DmiType009(type009, smbiosVersion);
                    break;

                case SmbiosType010 type010:
                    result = new DmiType010(type010, smbiosVersion);
                    break;

                case SmbiosType011 type011:
                    result = new DmiType011(type011, smbiosVersion);
                    break;

                case SmbiosType012 type012:
                    result = new DmiType012(type012, smbiosVersion);
                    break;

                case SmbiosType013 type013:
                    result = new DmiType013(type013, smbiosVersion);
                    break;

                case SmbiosType014 type014:
                    result = new DmiType014(type014, smbiosVersion);
                    break;

                case SmbiosType015 type015:
                    result = new DmiType015(type015, smbiosVersion);
                    break;

                case SmbiosType016 type016:
                    result = new DmiType016(type016, smbiosVersion);
                    break;

                case SmbiosType017 type017:
                    result = new DmiType017(type017, smbiosVersion);
                    break;

                case SmbiosType018 type018:
                    result = new DmiType018(type018, smbiosVersion);
                    break;

                case SmbiosType019 type019:
                    result = new DmiType019(type019, smbiosVersion);
                    break;

                case SmbiosType020 type020:
                    result = new DmiType020(type020, smbiosVersion);
                    break;

                case SmbiosType021 type021:
                    result = new DmiType021(type021, smbiosVersion);
                    break;

                case SmbiosType022 type022:
                    result = new DmiType022(type022, smbiosVersion);
                    break;

                case SmbiosType023 type023:
                    result = new DmiType023(type023, smbiosVersion);
                    break;

                case SmbiosType024 type024:
                    result = new DmiType024(type024, smbiosVersion);
                    break;

                case SmbiosType025 type025:
                    result = new DmiType025(type025, smbiosVersion);
                    break;

                case SmbiosType026 type026:
                    result = new DmiType026(type026, smbiosVersion);
                    break;

                case SmbiosType027 type027:
                    result = new DmiType027(type027, smbiosVersion);
                    break;

                case SmbiosType028 type028:
                    result = new DmiType028(type028, smbiosVersion);
                    break;

                case SmbiosType029 type029:
                    result = new DmiType029(type029, smbiosVersion);
                    break;

                case SmbiosType030 type030:
                    result = new DmiType030(type030, smbiosVersion);
                    break;

                case SmbiosType031 type031:
                    result = new DmiType031(type031, smbiosVersion);
                    break;

                case SmbiosType032 type032:
                    result = new DmiType032(type032, smbiosVersion);
                    break;

                case SmbiosType033 type033:
                    result = new DmiType033(type033, smbiosVersion);
                    break;

                case SmbiosType034 type034:
                    result = new DmiType034(type034, smbiosVersion);
                    break;

                case SmbiosType035 type035:
                    result = new DmiType035(type035, smbiosVersion);
                    break;

                case SmbiosType036 type036:
                    result = new DmiType036(type036, smbiosVersion);
                    break;

                case SmbiosType037 type037:
                    result = new DmiType037(type037, smbiosVersion);
                    break;

                case SmbiosType038 type038:
                    result = new DmiType038(type038, smbiosVersion);
                    break;

                case SmbiosType039 type039:
                    result = new DmiType039(type039, smbiosVersion);
                    break;

                case SmbiosType040 type040:
                    result = new DmiType040(type040, smbiosVersion);
                    break;

                case SmbiosType041 type041:
                    result = new DmiType041(type041, smbiosVersion);
                    break;

                case SmbiosType042 type042:
                    result = new DmiType042(type042, smbiosVersion);
                    break;

                case SmbiosType043 type043:
                    result = new DmiType043(type043, smbiosVersion);
                    break;

                case SmbiosType044 type044:
                    result = new DmiType044(type044, smbiosVersion);
                    break;

                case SmbiosType045 type045:
                    result = new DmiType045(type045, smbiosVersion);
                    break;

                case SmbiosType046 type046:
                    result = new DmiType046(type046, smbiosVersion);
                    break;

                case SmbiosType126 type126:
                    result = new DmiType126(type126, smbiosVersion);
                    break;

                case SmbiosType127 type127:
                    result = new DmiType127(type127, smbiosVersion);
                    break;
            }

            return result;
        }
    }
}
