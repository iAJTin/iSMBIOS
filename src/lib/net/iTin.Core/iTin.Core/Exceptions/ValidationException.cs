
namespace iTin.Core.Exceptions
{
    using System.Collections.Generic;
    using System.Text;

    using ComponentModel;

    /// <summary>
    /// Class ValidationException.
    /// </summary>
    /// <seealso cref="Exception" />
    public class ValidationException : Exception
    {
        /// <summary>
        /// Error list
        /// </summary>
        public List<Error> Errors = new List<Error>();

        #region constructor/s
        /// <summary>
        /// Initializes a new instance of the <see cref="ValidationException"/> class.
        /// </summary>
        public ValidationException()
        { }

        /// <summary>
        /// Initializes a new instance of the <see cref="ValidationException"/> class.
        /// </summary>
        /// <param name="resourceFile">The resource file.</param>
        public ValidationException(string resourceFile)
        {
            ResourceFile = resourceFile;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ValidationException"/> class.
        /// </summary>
        /// <param name="resourceFile">The resource file.</param>
        /// <param name="resourceKey">The resource key.</param>
        public ValidationException(string resourceFile, string resourceKey) : base(resourceFile, resourceKey)
        {
            Errors.Add(new Error(ResourceFile, resourceKey));
        }
        #endregion

        #region public override properties
        /// <summary>
        /// Returns the list of Errors as an string with line breaks
        /// </summary>
        public override string Message
        {
            get
            {
                if (Errors.Count == 0)
                {
                    return string.Empty;
                }

                StringBuilder sb = new StringBuilder();
                Errors.ForEach(it => sb.AppendLine(it.Message));
                return sb.ToString();
            }
        }
        #endregion

        #region public properties
        /// <summary>
        /// Returns the list of Errors as an HTML to display on a website
        /// </summary>
        public string HTML
        {
            get
            {
                return ToMessages().ToHtml();
            }
        }
        #endregion

        #region public methods

        /// <summary>
        /// Adds the error.
        /// </summary>
        /// <param name="resourceKey">The resource key.</param>
        /// <returns>ValidationException.</returns>
        public ValidationException AddError(string resourceKey)
        {
            Errors.Add(new Error(ResourceFile, resourceKey));

            return this;
        }

        /// <summary>
        /// Adds the error.
        /// </summary>
        /// <param name="resourceFile">The resource file.</param>
        /// <param name="resourceKey">The resource key.</param>
        /// <returns>ValidationException.</returns>
        public ValidationException AddError(string resourceFile, string resourceKey)
        {
            Errors.Add(new Error(resourceFile, resourceKey));

            return this;
        }

        /// <summary>
        /// Adds the error formatted.
        /// </summary>
        /// <param name="resourceKey">The resource key.</param>
        /// <param name="args">The arguments.</param>
        /// <returns>ValidationException.</returns>
        public ValidationException AddFormattedError(string resourceKey, params object[] args)
        {
            Errors.Add(new Error(ResourceFile, resourceKey, args));

            return this;
        }

        /// <summary>
        /// Adds the message.
        /// </summary>
        /// <param name="message">The message.</param>
        /// <returns>ValidationException.</returns>
        public ValidationException AddMessage(string message)
        {
            Errors.Add(new Error(message));

            return this;
        }

        /// <summary>
        /// Clears this instance.
        /// </summary>
        /// <returns>ValidationException.</returns>
        public ValidationException Clear()
        {
            Errors.Clear();

            return this;
        }

        /// <summary>
        /// Returns the list of Errors as an Messages object
        /// </summary>
        public Messages ToMessages()
        {
            Messages result = new Messages();

            Errors.ForEach(it => result.Add(it.Message));

            return result;
        }
        #endregion
    }
}
