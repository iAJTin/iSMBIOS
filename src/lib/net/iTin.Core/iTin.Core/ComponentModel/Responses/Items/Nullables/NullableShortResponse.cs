
namespace iTin.Core.ComponentModel.Responses
{
    using System.Collections.Generic;

    /// <summary>
    /// Specialization of the interface <see cref="ResponseBase{T}" /> that contains a nullable short response.
    /// </summary>
    public class NullableShortResponse : ResponseBase<short?>
    {
        /// <summary>
        /// Returns a new <see cref="NullableShortResponse"/> with specified detailed error.
        /// </summary>
        /// <param name="message">Error message</param>
        /// <param name="code">Error code</param>
        /// <returns>
        /// A new invalid <see cref="NullableShortResponse"/> with specified detailed error.
        /// </returns>
        public new static NullableShortResponse CreateErroResponse(string message, string code = "") => CreateErroResponse(new IResponseError[] { new ResponseError { Code = code, Message = message } });

        /// <summary>
        /// Returns a new <see cref="NullableShortResponse"/> with specified detailed errors collection.
        /// </summary>
        /// <param name="errors">A errors collection</param>
        /// <returns>
        /// A new invalid <see cref="NullableShortResponse"/> with specified detailed errors collection.
        /// </returns>
        public new static NullableShortResponse CreateErroResponse(IResponseError[] errors) =>
            new NullableShortResponse
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
        /// A new valid <see cref="NullableShortResponse"/>.
        /// </returns>
        public new static NullableShortResponse CreateSuccessResponse(short? value) =>
            new NullableShortResponse
            {
                Value = value,
                Success = true,
                Errors = new List<IResponseError>()
            };

        /// <summary>
        /// Creates a new <see cref="NullableShortResponse"/> instance from known exception.
        /// </summary>
        /// <param name="exception">Target exception.</param>
        /// <returns>
        /// A new <see cref="NullableShortResponse"/> instance for specified exception.
        /// </returns>
        public new static NullableShortResponse FromException(System.Exception exception) =>
            new NullableShortResponse
            {
                Success = false,
                Errors = new List<IResponseError> { new ResponseExceptionError { Exception = exception } }
            };
    }
}
