
namespace iTin.Core.Hardware.Specification.Dmi
{
    /// <summary>
    /// Defines the <c>DMI</c> structures associated with the chassis.
    /// </summary>
    public enum ChassisContainedElementType
    {
        /// <summary>
        /// SystemEnclosure structure
        /// </summary>
        BaseBoardEnumeration = 0x00,

        /// <summary>
        /// <c>SMBIOS</c> structure
        /// </summary>
        SmbiosStructure = 0x01
    }
}
