
using iTin.Core.ComponentModel;

namespace iTin.Core.Interop.Shared.MacOS
{
    /// <summary>
    /// Defines library names
    /// </summary>
    public enum Command
    {
        /// <summary>
        /// IoReg program
        /// </summary>
        [EnumDescription("IoReg")]
        IoReg,

        /// <summary>
        /// sw_vers program
        /// </summary>
        [EnumDescription("sw_vers")]
        SwVers,

        /// <summary>
        /// pmset program
        /// </summary>
        [EnumDescription("pmset")]
        Pmset,

        /// <summary>
        /// sysctl program
        /// </summary>
        [EnumDescription("sysctl")]
        Sysctl
    }
}
