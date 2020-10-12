
namespace iTin.Core.ComponentModel
{
    /// <summary>
    /// Defines a generic result exception error
    /// </summary>
    public class ResultExceptionError : ResultError
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ResultExceptionError"/> class.
        /// </summary>
        public ResultExceptionError()
        {
            Exception = null;
            Code = string.Empty;
            Message = string.Empty;
        }

        /// <summary>
        /// Gets or sets exception.
        /// </summary>
        /// <value>The exception.</value>
        public System.Exception Exception { get; set; }
    }
}
