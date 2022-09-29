
using System.Collections.Generic;

namespace iTin.Core.ComponentModel.Responses
{
    /// <summary>
    /// Specialization of the interface <see cref="ResponseBase{T}" /> that contains a nullable double response.
    /// </summary>
    public class NullableDoubleResponse : ResponseBase<double?>
    {
        /// <summary>
        /// Returns a new <see cref="NullableDoubleResponse"/> with specified detailed error.
        /// </summary>
        /// <param name="message">Error message</param>
        /// <param name="code">Error code</param>
        /// <returns>
        /// A new invalid <see cref="NullableDoubleResponse"/> with specified detailed error.
        /// </returns>
        public new static NullableDoubleResponse CreateErroResponse(string message, string code = "") => CreateErroResponse(new IResponseError[] { new ResponseError { Code = code, Message = message } });

        /// <summary>
        /// Returns a new <see cref="NullableDoubleResponse"/> with specified detailed errors collection.
        /// </summary>
        /// <param name="errors">A errors collection</param>
        /// <returns>
        /// A new invalid <see cref="NullableDoubleResponse"/> with specified detailed errors collection.
        /// </returns>
        public new static NullableDoubleResponse CreateErroResponse(IResponseError[] errors) =>
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
        /// A new valid <see cref="NullableDoubleResponse"/>.
        /// </returns>
        public new static NullableDoubleResponse CreateSuccessResponse(double? value) =>
            new()
            {
                Value = value,
                Success = true,
                Errors = new List<IResponseError>()
            };

        /// <summary>
        /// Creates a new <see cref="NullableDoubleResponse"/> instance from known exception.
        /// </summary>
        /// <param name="exception">Target exception.</param>
        /// <returns>
        /// A new <see cref="NullableDoubleResponse"/> instance for specified exception.
        /// </returns>
        public new static NullableDoubleResponse FromException(System.Exception exception) =>
            new()
            {
                Success = false,
                Errors = new List<IResponseError> { new ResponseExceptionError { Exception = exception } }
            };
    }
}
