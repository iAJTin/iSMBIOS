
namespace iTin.Core.Helpers
{
    using System.Data;
    using System.Xml;

    /// <summary>
    /// Static class than contains methods for manipulating xml documents.
    /// </summary>
    public static class XmlHelper
    {
        /// <summary>
        /// Returns a DataSet which represents target xml document.
        /// </summary>
        /// <param name="xml">The value.</param>
        /// <returns>
        /// A <see cref="DataSet"/>.
        /// </returns>
        public static DataSet ToDataSet(string xml)
        {
            var result = new DataSet();

            try
            {
                var document = new XmlDocument();
                document.LoadXml(xml);
                result.ReadXml(new XmlNodeReader(document));

                return result;
            }
            catch
            {
                throw;
            }
        }
    }
}
