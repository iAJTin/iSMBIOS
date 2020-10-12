
namespace iTin.Core.ComponentModel.Responses
{
    using System.Collections.Generic;

    /// <summary>
    /// Specialization of the interface <see cref="ResponseBase{T}" /> that contains a nullable boolean response.
    /// </summary>
    public class NullableBooleanResponse : ResponseBase<bool?>
    {
        /// <summary>
        /// Returns a new <see cref="NullableBooleanResponse"/> with specified detailed error.
        /// </summary>
        /// <param name="message">Error message</param>
        /// <param name="code">Error code</param>
        /// <returns>
        /// A new invalid <see cref="NullableBooleanResponse"/> with specified detailed error.
        /// </returns>
        public new static NullableBooleanResponse CreateErroResponse(string message, string code = "") => CreateErroResponse(new IResponseError[] { new ResponseError { Code = code, Message = message } });

        /// <summary>
        /// Returns a new <see cref="NullableBooleanResponse"/> with specified detailed errors collection.
        /// </summary>
        /// <param name="errors">A errors collection</param>
        /// <returns>
        /// A new invalid <see cref="NullableBooleanResponse"/> with specified detailed errors collection.
        /// </returns>
        public new static NullableBooleanResponse CreateErroResponse(IResponseError[] errors) =>
            new NullableBooleanResponse
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
        /// A new valid <see cref="NullableBooleanResponse"/>.
        /// </returns>
        public new static NullableBooleanResponse CreateSuccessResponse(bool? value) =>
            new NullableBooleanResponse
            {
                Value = value,
                Success = true,
                Errors = new List<IResponseError>()
            };

        /// <summary>
        /// Creates a new <see cref="NullableBooleanResponse"/> instance from known exception.
        /// </summary>
        /// <param name="exception">Target exception.</param>
        /// <returns>
        /// A new <see cref="NullableBooleanResponse"/> instance for specified exception.
        /// </returns>
        public new static NullableBooleanResponse FromException(System.Exception exception) =>
            new NullableBooleanResponse
            {
                Success = false,
                Errors = new List<IResponseError> { new ResponseExceptionError { Exception = exception } }
            };
    }
}
