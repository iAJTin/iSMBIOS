
namespace iTin.Core.ComponentModel.Responses
{
    using System.Collections.Generic;

    /// <summary>
    /// Specialization of the interface <see cref="ResponseBase{T}" /> that contains a integer response.
    /// </summary>
    public class DecimalResponse : ResponseBase<decimal>
    {
        /// <summary>
        /// Returns a new <see cref="DecimalResponse"/> with specified detailed error.
        /// </summary>
        /// <param name="message">Error message</param>
        /// <param name="code">Error code</param>
        /// <returns>
        /// A new invalid <see cref="DecimalResponse"/> with specified detailed error.
        /// </returns>
        public new static DecimalResponse CreateErroResponse(string message, string code = "") => CreateErroResponse(new IResponseError[] { new ResponseError { Code = code, Message = message } });

        /// <summary>
        /// Returns a new <see cref="DecimalResponse"/> with specified detailed errors collection.
        /// </summary>
        /// <param name="errors">A errors collection</param>
        /// <returns>
        /// A new invalid <see cref="DecimalResponse"/> with specified detailed errors collection.
        /// </returns>
        public new static DecimalResponse CreateErroResponse(IResponseError[] errors) =>
            new DecimalResponse
            {
                Value = default,
                Success = false,
                Errors = (IResponseError[])errors.Clone()
            };

        /// <summary>
        /// Returns a new success response.
        /// </summary>
        /// <param name="value">Response value</param>
        /// <returns>
        /// A new valid <see cref="DecimalResponse"/>.
        /// </returns>
        public new static DecimalResponse CreateSuccessResponse(decimal value) =>
            new DecimalResponse
            {
                Value = value,
                Success = true,
                Errors = new List<IResponseError>()
            };

        /// <summary>
        /// Creates a new <see cref="DecimalResponse"/> instance from known exception.
        /// </summary>
        /// <param name="exception">Target exception.</param>
        /// <returns>
        /// A new <see cref="DecimalResponse"/> instance for specified exception.
        /// </returns>
        public new static DecimalResponse FromException(System.Exception exception) =>
            new DecimalResponse
            {
                Success = false,
                Errors = new List<IResponseError> { new ResponseExceptionError { Exception = exception } }
            };
    }
}
