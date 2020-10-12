
namespace iTin.Core.ComponentModel.Responses
{
    using System.Collections.Generic;

    /// <summary>
    /// Specialization of the interface <see cref="ResponseBase{T}" /> that contains a period response.
    /// </summary>
    public class PeriodResponse : ResponseBase<Period>
    {
        /// <summary>
        /// Returns a new <see cref="PeriodResponse"/> with specified detailed error.
        /// </summary>
        /// <param name="message">Error message</param>
        /// <param name="code">Error code</param>
        /// <returns>
        /// A new invalid <see cref="PeriodResponse"/> with specified detailed error.
        /// </returns>
        public new static PeriodResponse CreateErroResponse(string message, string code = "") => CreateErroResponse(new IResponseError[] { new ResponseError { Code = code, Message = message } });

        /// <summary>
        /// Returns a new <see cref="PeriodResponse"/> with specified detailed errors collection.
        /// </summary>
        /// <param name="errors">A errors collection</param>
        /// <returns>
        /// A new invalid <see cref="PeriodResponse"/> with specified detailed errors collection.
        /// </returns>
        public new static PeriodResponse CreateErroResponse(IResponseError[] errors) =>
            new PeriodResponse
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
        /// A new valid <see cref="PeriodResponse"/>.
        /// </returns>
        public new static PeriodResponse CreateSuccessResponse(Period value) =>
            new PeriodResponse
            {
                Value = value,
                Success = true,
                Errors = new List<IResponseError>()
            };

        /// <summary>
        /// Creates a new <see cref="PeriodResponse"/> instance from known exception.
        /// </summary>
        /// <param name="exception">Target exception.</param>
        /// <returns>
        /// A new <see cref="PeriodResponse"/> instance for specified exception.
        /// </returns>
        public new static PeriodResponse FromException(System.Exception exception) =>
            new PeriodResponse
            {
                Success = false,
                Errors = new List<IResponseError> { new ResponseExceptionError { Exception = exception } }
            };
    }
}
