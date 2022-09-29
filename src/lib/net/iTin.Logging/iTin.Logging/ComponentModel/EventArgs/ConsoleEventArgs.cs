
using System.ComponentModel;

using iTin.Logging.ComponentModel;

namespace iTin.Logging.EventArgs
{
    /// <summary>
    /// Provides data for the <see cref="ConsoleLog"/>.
    /// </summary>
    /// <seealso cref="System.ComponentModel.HandledEventArgs" />
    public class ConsoleEventArgs : HandledEventArgs
    {
        /// <summary>
        /// Gets or sets the layout to use.
        /// </summary>
        /// <value>
        /// A <see cref="ConsoleLayout"/> that contains layout to use.
        /// </value>
        public ConsoleLayout Layout { get; set; }

        /// <summary>
        /// Gets or sets the message.
        /// </summary>
        /// <value>
        /// A <see cref="T:System.String"/> that contains the message.
        /// </value>
        public string Message { get; set; }
    }
}
