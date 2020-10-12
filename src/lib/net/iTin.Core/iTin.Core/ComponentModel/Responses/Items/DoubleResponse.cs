
namespace iTin.Core.ComponentModel.Responses
{
    using System.Collections.Generic;

    /// <summary>
    /// Specialization of the interface <see cref="ResponseBase{T}" /> that contains a double response.
    /// </summary>
    public class DoubleResponse : ResponseBase<double>
    {
        /// <summary>
        /// Returns a new <see cref="DoubleResponse"/> with specified detailed error.
        /// </summary>
        /// <param name="message">Error message</param>
        /// <param name="code">Error code</param>
        /// <returns>
        /// A new invalid <see cref="DoubleResponse"/> with specified detailed error.
        /// </returns>
        public new static DoubleResponse CreateErroResponse(string message, string code = "") => CreateErroResponse(new IResponseError[] { new ResponseError { Code = code, Message = message } });

        /// <summary>
        /// Returns a new <see cref="DoubleResponse"/> with specified detailed errors collection.
        /// </summary>
        /// <param name="errors">A errors collection</param>
        /// <returns>
        /// A new invalid <see cref="DoubleResponse"/> with specified detailed errors collection.
        /// </returns>
        public new static DoubleResponse CreateErroResponse(IResponseError[] errors) =>
            new DoubleResponse
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
        /// A new valid <see cref="DoubleResponse"/>.
        /// </returns>
        public new static DoubleResponse CreateSuccessResponse(double value) =>
            new DoubleResponse
            {
                Value = value,
                Success = true,
                Errors = new List<IResponseError>()
            };

        /// <summary>
        /// Creates a new <see cref="DoubleResponse"/> instance from known exception.
        /// </summary>
        /// <param name="exception">Target exception.</param>
        /// <returns>
        /// A new <see cref="DoubleResponse"/> instance for specified exception.
        /// </returns>
        public new static DoubleResponse FromException(System.Exception exception) =>
            new DoubleResponse
            {
                Success = false,
                Errors = new List<IResponseError> { new ResponseExceptionError { Exception = exception } }
            };
    }
}
