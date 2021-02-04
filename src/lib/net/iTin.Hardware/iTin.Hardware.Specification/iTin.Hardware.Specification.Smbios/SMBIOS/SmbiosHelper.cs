
namespace iTin.Hardware.Specification.Smbios
{
    using System;
    using System.Collections.ObjectModel;
    using System.Linq;
    using System.Text;

    /// <summary>
    /// Helper class for <see cref="SMBIOS"/>.
    /// </summary>
    internal static class SmbiosHelper
    {
        public const string Unknown = "Unknown";
        public const string Reserved = "Reserved";
        public const string OutOfSpec = "<OUT OF SPEC>";

        /// <summary>
        /// Returns all stored strings in raw table.
        /// </summary>
        /// <param name="rawDataArray">Raw table</param>
        /// <returns>
        /// Strings stored in raw data.
        /// </returns>
        public static string[] ParseStrings(byte[] rawDataArray)
        {
            bool exit = false;
            int index = rawDataArray[1];
            Collection<string> items = new Collection<string> { string.Empty };

            while (!exit)
            {
                int end = Array.IndexOf(rawDataArray, (byte)0x00, index);
                int count = end - index;
                items.Add(Encoding.ASCII.GetString(rawDataArray, index, count));

                if (rawDataArray[end + 1] == 0x00)
                {
                    exit = true;
                }
                else
                {
                    index = end + 1;
                }
            }

            return items.ToArray();
        }
    }
}
