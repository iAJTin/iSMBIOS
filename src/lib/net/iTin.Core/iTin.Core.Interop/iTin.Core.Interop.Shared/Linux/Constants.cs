
namespace iTin.Core.Interop.Shared.Linux
{
    /// <summary>
    /// Defines known constants
    /// </summary>
    public static class Constants
    {
        /// <summary>
        /// DEV
        /// </summary>
        public static class DEV
        {
            /// <summary>
            /// /dev/mem 
            /// </summary>
            public const string MEM = "/DEV/MEM";
        }

        /// <summary>
        /// ETC
        /// </summary>
        public static class ETC
        {
            /// <summary>
            /// /etc/os-release
            /// </summary>
            public const string OS_RELEASE = "/etc/os-release";
        }

        /// <summary>
        /// PROC
        /// </summary>
        public static class PROC
        {
            /// <summary>
            /// /proc/net
            /// </summary>
            public static class NET
            {
                /// <summary>
                /// /proc/net/dev
                /// </summary>
                public const string DEV = "/proc/net/dev";
            }


            /// <summary>
            /// /proc/meminfo
            /// </summary>
            public const string MEMINFO = "/proc/meminfo";

            /// <summary>
            /// /proc/cpuinfo 
            /// </summary>
            public const string CPUINFO = "/proc/cpuinfo";

            /// <summary>
            /// /proc/stat
            /// </summary>
            public const string STAT = "/proc/stat";
        }

        /// <summary>
        /// SYS
        /// </summary>
        public static class SYS
        {
            /// <summary>
            /// /sys/class
            /// </summary>
            public static class CLASS
            {
                /// <summary>
                /// /sys/class/power_supply
                /// </summary>
                public static class POWER_SUPPLY
                {
                    /// <summary>
                    /// /sys/class/power_supply/bat0
                    /// </summary>
                    public const string BAT0 = "/sys/class/power_supply/bat0";
                }


                /// <summary>
                /// /sys/class/dmi
                /// </summary>
                public const string DMI = "/sys/class/dmi";
            }
        }
    }
}
