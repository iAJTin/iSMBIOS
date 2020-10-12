
namespace iTin.Hardware.Specification.Smbios
{
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.Diagnostics;

    using iTin.Core;
    using iTin.Core.Helpers.Enumerations;

    using Property;

    // Type 013: BIOS Language Information.
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // |          Spec.                                                                                             |
    // | Offset   Version     Name                Length      Value       Description                               |
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 00h      2.0+        Type                BYTE        13          Language Information Indicator            |
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 01h      2.0+        Length              BYTE        16h                                                   |
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 02h      2.0+        Handle              WORD        Varies                                                |
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 04h      2.0+        Installable         BYTE        Varies      Número de lenguajes disponibles.          |
    // |                      Languages                                   Note: Ver GetValues(int)                  |
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 05h      2.1+        Flags               BYTE        Bit Field   Bits 07:01 - Reservado                    |
    // |                                                                  Bit     00 - Formato                      |
    // |                                                                               0b - Lenguaje actual usa el  |
    // |                                                                                    formato largo.          |
    // |                                                                               1b - Lenguaje actual usa el  |
    // |                                                                                    formato abreviado.      |
    // |                                                                  Note: See IsCurrentAbbreviated            |
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 06h      2.0+        Reserved            15 BYTEs    00h                                                   |
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 015h     2.0+        Current             BYTE        STRING      Número de cadena (basado índice 0) del    |
    // |                      Language                                    lenguaje por defecto.                     |
    // |                                                                  Note: See Default                         |
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————————•

    /// <inheritdoc/>
    /// <summary>
    /// Specialization of the <see cref="SmbiosBaseType"/> class that contains the logic to decode the BIOS Language Information (Type 13) structure.
    /// </summary>
    internal sealed class SmbiosType013 : SmbiosBaseType
    {
        #region constructor/s

        #region [public] SmbiosType013(SmbiosStructureHeaderInfo, int): Initializes a new instance of the class by specifying the structure information and the SMBIOS version
        /// <inheritdoc/>
        /// <summary>
        /// Initializes a new instance of the <see cref="SmbiosType013"/> class by specifying the structure information and the <see cref="SMBIOS"/> version.
        /// </summary>
        /// <param name="smbiosStructureHeaderInfo">Raw information of the current structure.</param>
        /// <param name="smbiosVersion">Current <see cref="SMBIOS"/> version.</param>
        public SmbiosType013(SmbiosStructureHeaderInfo smbiosStructureHeaderInfo, int smbiosVersion) : base(smbiosStructureHeaderInfo, smbiosVersion)
        {
        }
        #endregion

        #endregion

        #region private properties

        #region Version 2.0+ fields

        #region [private] (int) Count: Gets a value representing the 'Count' field
        /// <summary>
        /// Gets a value representing the <b>Count</b> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private int Count => Reader.GetByte(0x04);
        #endregion

        #region [private] (string) Current: Gets a value representing the 'Current' field
        /// <summary>
        /// Gets a value representing the <b>Current</b> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string Current => GetString(0x015);
        #endregion

        #endregion

        #region Version 2.1+ fields

        #region [private] (bool) IsCurrentAbbreviated: Gets a value representing the 'Is Current Abbreviated' field
        /// <summary>
        /// Gets a value representing the <b>Is Current Abbreviated</b> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private bool IsCurrentAbbreviated => Reader.GetByte(0x05).CheckBit(Bits.Bit00);
        #endregion

        #endregion

        #endregion

        #region protected override methods

        #region [protected] {override} (void) PopulateProperties(SmbiosPropertiesTable): Populates the property collection for this structure
        /// <inheritdoc/>
        /// <summary>
        /// Populates the property collection for this structure.
        /// </summary>
        /// <param name="properties">Collection of properties of this structure.</param>
        protected override void PopulateProperties(SmbiosPropertiesTable properties)
        {
            if (StructureInfo.StructureVersion < SmbiosStructureVersion.v20)
            {
                return;
            }

            properties.Add(SmbiosProperty.BiosLanguage.InstallableLanguages, GetValues(Count));
            properties.Add(SmbiosProperty.BiosLanguage.IsCurrentAbbreviated, IsCurrentAbbreviated);
            properties.Add(SmbiosProperty.BiosLanguage.Current, Current);
        }
        #endregion

        #endregion


        #region BIOS Specification 2.7.1 (26/01/2011)

        #region [private] (ReadOnlyCollection<string>) GetValues(int): Gets a collection with system information
        /// <summary>
        /// Gets a collection with system information.
        /// </summary>
        /// <param name="count">Counter.</param>
        /// <returns>
        /// Colección con la información del sistema.
        /// </returns>
        private ReadOnlyCollection<string> GetValues(int count)
        {
            List<string> items = new List<string>();

            for (int i = 1; i <= count; i++)
            {
                items.Add(Strings[i]);
            }

            return items.AsReadOnly();
        }
        #endregion

        #endregion
    }
}
