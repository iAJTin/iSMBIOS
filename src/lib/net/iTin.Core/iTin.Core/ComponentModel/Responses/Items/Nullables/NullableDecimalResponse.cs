
using System.Collections.Generic;

namespace iTin.Core.ComponentModel.Responses
{
    /// <summary>
    /// Specialization of the interface <see cref="ResponseBase{T}" /> that contains a nullable decimal response.
    /// </summary>
    public class NullableDecimalResponse : ResponseBase<decimal?>
    {
        /// <summary>
        /// Returns a new <see cref="NullableDecimalResponse"/> with specified detailed error.
        /// </summary>
        /// <param name="message">Error message</param>
        /// <param name="code">Error code</param>
        /// <returns>
        /// A new invalid <see cref="NullableDecimalResponse"/> with specified detailed error.
        /// </returns>
        public new static NullableDecimalResponse CreateErroResponse(string message, string code = "") => CreateErroResponse(new IResponseError[] { new ResponseError { Code = code, Message = message } });

        /// <summary>
        /// Returns a new <see cref="NullableDecimalResponse"/> with specified detailed errors collection.
        /// </summary>
        /// <param name="errors">A errors collection</param>
        /// <returns>
        /// A new invalid <see cref="NullableDecimalResponse"/> with specified detailed errors collection.
        /// </returns>
        public new static NullableDecimalResponse CreateErroResponse(IResponseError[] errors) =>
            new()
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
        /// A new valid <see cref="NullableDecimalResponse"/>.
        /// </returns>
        public new static NullableDecimalResponse CreateSuccessResponse(decimal? value) =>
            new()
            {
                Value = value,
                Success = true,
                Errors = new List<IResponseError>()
            };

        /// <summary>
        /// Creates a new <see cref="NullableDecimalResponse"/> instance from known exception.
        /// </summary>
        /// <param name="exception">Target exception.</param>
        /// <returns>
        /// A new <see cref="NullableDecimalResponse"/> instance for specified exception.
        /// </returns>
        public new static NullableDecimalResponse FromException(System.Exception exception) =>
            new()
            {
                Success = false,
                Errors = new List<IResponseError> { new ResponseExceptionError { Exception = exception } }
            };
    }
}
