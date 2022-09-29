
using System.Collections.Generic;
using System.Text;

namespace iTin.Core.ComponentModel
{
    /// <summary>
    /// Class Messages.
    /// </summary>
    public class Messages
    {
        #region private readonly members
        private readonly List<string> _msgs;
        #endregion

        #region constructor/s
        /// <summary>
        /// Initializes a new instance of the <see cref="Messages"/> class.
        /// </summary>
        public Messages() => _msgs = new List<string>();
        #endregion

        #region public methods
        /// <summary>
        /// Adds the specified message.
        /// </summary>
        /// <param name="message">The message.</param>
        public void Add(string message) => _msgs.Add(message);

        /// <summary>
        /// Adds the specified messages.
        /// </summary>
        /// <param name="messages">The messages.</param>
        public void Add(Messages messages) => _msgs.AddRange(messages.GetMessages());

        /// <summary>
        /// Counts this instance.
        /// </summary>
        /// <returns>System.Int32.</returns>
        public int Count() => _msgs.Count;

        /// <summary>
        /// Gets the messages.
        /// </summary>
        /// <returns>IEnumerable&lt;System.String&gt;.</returns>
        public IEnumerable<string> GetMessages() => _msgs;

        /// <summary>
        /// To the HTML.
        /// </summary>
        /// <returns>System.String.</returns>
        public string ToHtml()
        {
            var sb = new StringBuilder();
            sb.AppendLine("<ul class=\"messages\">");
            _msgs.ForEach(it => sb.Append("<li>").Append(it).Append("</li>"));
            sb.AppendLine("</ul>");
            return sb.ToString();
        }

        /// <summary>
        /// To the HTML.
        /// </summary>
        /// <param name="ccsClass">The class.</param>
        /// <returns>System.String.</returns>
        public string ToHtml(string ccsClass)
        {
            var sb = new StringBuilder();
            sb.AppendLine("<ul class=\"" + ccsClass + "\">");
            _msgs.ForEach(it => sb.Append("<li>").Append(it).Append("</li>"));
            sb.AppendLine("</ul>");

            return sb.ToString();
        }

        /// <summary>
        /// Returns a new <see cref="StringBuilder"/> with the messages text
        /// </summary>
        /// <param name="asAppendLine">Indicates whether a carriage return must be added between the messages in the collection.</param>
        /// <returns>
        /// A <see cref="StringBuilder"/> reference with messages text.
        /// </returns>
        public StringBuilder ToStringBuilder(bool asAppendLine = true)
        {
            var builder = new StringBuilder();
            foreach (var msg in _msgs)
            {
                if (asAppendLine)
                {
                    builder.AppendLine(msg);
                }
                else
                {
                    builder.Append(msg);
                }
            }

            return builder;
        }

        #endregion
    }
}
