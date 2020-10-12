
namespace iTin.Logging.EventArgs
{
    using System.ComponentModel;

    using ComponentModel;

    /// <summary>
    /// Provides data for the <see cref="ColoredConsoleLog"/>.
    /// </summary>
    /// <seealso cref="HandledEventArgs" />
    public class ColoredConsoleEventArgs : HandledEventArgs
    {
        /// <summary>
        /// Gets or sets the layout to use.
        /// </summary>
        /// <value>
        /// A <see cref="ColoredConsoleLayout"/> that contains layout to use.
        /// </value>
        public ColoredConsoleLayout Layout { get; set; }

        /// <summary>
        /// Gets or sets the message.
        /// </summary>
        /// <value>
        /// A <see cref="T:System.String"/> that contains the message.
        /// </value>
        public string Message { get; set; }
    }
}
