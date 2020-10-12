
namespace iTin.Core.ComponentModel.Responses
{
    using System.Collections.Generic;

    /// <summary>
    /// Specialization of the interface <see cref="ResponseBase{T}" /> that contains a nullable float response.
    /// </summary>
    public class NullableFloatResponse : ResponseBase<float?>
    {
        /// <summary>
        /// Returns a new <see cref="NullableFloatResponse"/> with specified detailed error.
        /// </summary>
        /// <param name="message">Error message</param>
        /// <param name="code">Error code</param>
        /// <returns>
        /// A new invalid <see cref="NullableFloatResponse"/> with specified detailed error.
        /// </returns>
        public new static NullableFloatResponse CreateErroResponse(string message, string code = "") => CreateErroResponse(new IResponseError[] { new ResponseError { Code = code, Message = message } });

        /// <summary>
        /// Returns a new <see cref="NullableFloatResponse"/> with specified detailed errors collection.
        /// </summary>
        /// <param name="errors">A errors collection</param>
        /// <returns>
        /// A new invalid <see cref="NullableFloatResponse"/> with specified detailed errors collection.
        /// </returns>
        public new static NullableFloatResponse CreateErroResponse(IResponseError[] errors) =>
            new NullableFloatResponse
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
        /// A new valid <see cref="NullableFloatResponse"/>.
        /// </returns>
        public new static NullableFloatResponse CreateSuccessResponse(float? value) =>
            new NullableFloatResponse
            {
                Value = value,
                Success = true,
                Errors = new List<IResponseError>()
            };

        /// <summary>
        /// Creates a new <see cref="NullableFloatResponse"/> instance from known exception.
        /// </summary>
        /// <param name="exception">Target exception.</param>
        /// <returns>
        /// A new <see cref="NullableFloatResponse"/> instance for specified exception.
        /// </returns>
        public new static NullableFloatResponse FromException(System.Exception exception) =>
            new NullableFloatResponse
            {
                Success = false,
                Errors = new List<IResponseError> { new ResponseExceptionError { Exception = exception } }
            };
    }
}
