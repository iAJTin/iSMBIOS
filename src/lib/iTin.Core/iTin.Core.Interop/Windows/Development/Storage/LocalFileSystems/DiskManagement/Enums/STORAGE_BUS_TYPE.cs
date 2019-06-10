using System.Diagnostics.CodeAnalysis;

namespace iTin.Core.Interop.Windows.Development.Storage.LocalFileSystems.DiskManagement
{
    /// <summary>
    /// Representa los tipos de bus.
    /// </summary>
    /// <remarks>
    /// Para más información ver: http://msdn.microsoft.com/en-us/library/ff800833%28v=VS.85%29.aspx.
    /// </remarks>
    [SuppressMessage("Microsoft.Naming", "CA1707:IdentifiersShouldNotContainUnderscores")]
    [SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", MessageId = "STORAGE")]
    [SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", MessageId = "BUS")]
    [SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", MessageId = "TYPE")]
    enum STORAGE_BUS_TYPE
    {
        /// <summary>
        /// Tipo de bus desconocido.
        /// </summary>
        BusTypeUnknown = 0x00,

        /// <summary>
        /// Indica que el bus es de tipo SCSI.
        /// </summary>
        BusTypeScsi = 0x1,

        /// <summary>
        /// Indica que el bus es de tipo ATAPI.
        /// </summary>
        BusTypeAtapi = 0x2,

        /// <summary>
        /// Indica que el bus es de tipo ATA.
        /// </summary>
        BusTypeAta = 0x3,

        /// <summary>
        /// Indica que el bus es de tipo IEEE 1394.
        /// </summary>
        BusType1394 = 0x4,

        /// <summary>
        /// Indica que el bus es de tipo SSA.
        /// </summary>
        BusTypeSsa = 0x5,

        /// <summary>
        /// Indica que el bus es un canal de fibra óptica.
        /// </summary>
        BusTypeFibre = 0x6,

        /// <summary>
        /// Indica que el bus es de tipo USB.
        /// </summary>
        BusTypeUsb = 0x7,

        /// <summary>
        /// Indica que el bus es de tipo RAID.
        /// </summary>
        BusTypeRaid = 0x8,

        /// <summary>
        /// Indica que el bus es de tipo iSCSI.
        /// </summary>
        BusTypeiScsi = 0x9,

        /// <summary>
        /// Indica que el bus es de tipo Serial-Attached SCSI (SAS).
        /// </summary>
        BusTypeSas = 0xA,

        /// <summary>
        /// Indica que el bus es de tipo SATA.
        /// </summary>
        BusTypeSata = 0xB,

        /// <summary>
        /// Indica que el bus es de tipo secure digital (SD).
        /// </summary>
        [SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", MessageId = "Sd")]
        BusTypeSd = 0xC,

        /// <summary>
        /// Indica que el bus es de tipo multimedia card (MMC).
        /// </summary>
        BusTypeMmc = 0xD,

        /// <summary>
        /// Indica que el bus es de tipo Virtual.
        /// </summary>
        BusTypeVirtual = 0xE,

        /// <summary>
        /// Indica que el bus es de tipo file-backed virtual.
        /// </summary>
        BusTypeFileBackedVirtual = 0xF,

        /// <summary>
        /// Indica el valor máximo para este valor
        /// </summary>
        BusTypeMax = 0x10,

        /// <summary>
        /// El valor máximo de la gama de almacenamiento de tipo de bus.
        /// </summary>
        BusTypeMaxReserved = 0x7F
    }
}