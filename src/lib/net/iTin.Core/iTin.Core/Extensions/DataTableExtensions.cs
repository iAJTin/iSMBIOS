
namespace iTin.Core
{
    using System.Data;
    using System.Text;

    using Helpers;
    using Logging;

    /// <summary>
    /// Static class than contains extension methods for objects of type <see cref="T:System.Data.DataTable" />.
    /// </summary> 
    public static class DataTableExtensions
    {
        /// <summary>
        /// Returns a HTML table.
        /// </summary>
        /// <param name="input">The input.</param>
        /// <returns>
        /// A new <seealso cref="T:System.String"/> that contains HTML table code.
        /// </returns>
        public static string ToHtmlTable(this DataTable input)
        {
            Logger.Instance.Debug("");
            Logger.Instance.Debug(" Assembly: iTin.Core, Namespace: iTin.Core, Class: DataTableExtensions");
            Logger.Instance.Debug(" Returns a HTML table.");
            Logger.Instance.Debug($" > Signature: ({typeof(string)}) ToHtmlTable(this {typeof(DataTable)})");
            Logger.Instance.Debug($"   > input: {input}");

            SentinelHelper.ArgumentNull(input, nameof(input));
            Logger.Instance.Debug($"   > input: {input.Columns.Count} column(s)");

            StringBuilder html = new StringBuilder();
            html.Append("<table>");

            // add header row
            html.Append("<tr>");
            for (int i = 0; i < input.Columns.Count; i++)
            {
                html.AppendFormat("<td>{0}</td>", input.Columns[i].ColumnName);
            }

            html.Append("/<tr>");

            // add rows
            for (int i = 0; i < input.Rows.Count; i++)
            {
                html.Append("<tr>");
                for (var j = 0; j < input.Columns.Count; j++)
                {
                    html.AppendFormat("<td>{0}</td>", input.Rows[i][j]);
                }

                html.Append("/<tr>");
            }

            html.Append("/<table>");

            Logger.Instance.Info("  > Output: The Html table has been created correctly");

            return html.ToString();
        }
    }
}
