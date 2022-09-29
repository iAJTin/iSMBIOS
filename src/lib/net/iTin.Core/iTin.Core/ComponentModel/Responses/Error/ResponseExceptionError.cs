
namespace iTin.Core.ComponentModel
{
    /// <summary>
    /// Defines a generic response exception error
    /// </summary>
    public class ResponseExceptionError : ResponseError
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseExceptionError"/> class.
        /// </summary>
        public ResponseExceptionError()
        {
            Exception = null;
            Code = string.Empty;
            Message = string.Empty;
        }

        /// <summary>
        /// Gets or sets exception.
        /// </summary>
        /// <value>
        /// The exception.
        /// </value>
        public System.Exception Exception { get; set; }
    }
}
