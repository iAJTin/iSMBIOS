
using System.ComponentModel;
using System.IO;

using iTin.Logging.ComponentModel;

namespace iTin.Logging.EventArgs
{
    /// <summary>
    /// Provides data for the <see cref="FileLog"/>.
    /// </summary>
    /// <seealso cref="System.ComponentModel.HandledEventArgs" />
    public class FileLogEventArgs : HandledEventArgs
    {
        /// <summary>
        /// Gets or sets the layout to use.
        /// </summary>
        /// <value>
        /// A <see cref="FileLogLayout"/> that contains layout to use.
        /// </value>
        public FileLogLayout Layout { get; set; }

        /// <summary>
        /// Gets or sets the message.
        /// </summary>
        /// <value>
        /// A <see cref="T:System.String"/> that contains the message.
        /// </value>
        public string Message { get; set; }

        /// <summary>
        /// Gets or sets the writer to use.
        /// </summary>
        /// <value>
        /// A <see cref="T:System.IO.StreamWriter"/> that contains the writer to use.
        /// </value>
        public StreamWriter Writer { get; set; }
    }
}
