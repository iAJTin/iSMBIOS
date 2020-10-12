
namespace iTin.Core.ComponentModel
{
    using Exceptions;

    /// <summary>
    /// Class Error.
    /// </summary>
    public class Error
    {
        #region constructor/s
        /// <summary>
        /// Initializes a new instance of the <see cref="Error" /> class.
        /// </summary>
        /// <param name="type">The type.</param>
        /// <param name="code">The code.</param>
        public Error(string type, string code)
        {
            Type = type;
            Code = code;
            Message = Exception.GetMessage(type, code);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Error"/> class.
        /// </summary>
        /// <param name="type">The type.</param>
        /// <param name="code">The code.</param>
        /// <param name="args">The arguments.</param>
        public Error(string type, string code, params object[] args)
        {
            Type = type;
            Code = code;
            Message = Exception.GetMessage(type, code);

            if (args != null && args.Length != 0)
            {
                Message = string.Format(Message, args);
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Error"/> class.
        /// </summary>
        /// <param name="message">The message.</param>
        public Error(string message)
        {
            Message = message;
        }
        #endregion

        #region public properties
        /// <summary>
        /// Gets or sets the type.
        /// </summary>
        /// <value>
        /// The type.
        /// </value>
        public string Type { get; set; }

        /// <summary>
        /// Gets or sets the code.
        /// </summary>
        /// <value>
        /// The error code.
        /// </value>
        public string Code { get; set; }

        /// <summary>
        /// Gets or sets the message.
        /// </summary>
        /// <value>
        /// The message.
        /// </value>
        public string Message { get; set; }
        #endregion
    }
}
