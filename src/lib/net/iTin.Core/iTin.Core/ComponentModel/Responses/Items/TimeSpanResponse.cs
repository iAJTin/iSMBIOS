
namespace iTin.Core.ComponentModel.Responses
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Specialization of the interface <see cref="ResponseBase{T}" /> that contains a timespan response.
    /// </summary>
    public class TimeSpanResponse : ResponseBase<TimeSpan>
    {
        /// <summary>
        /// Returns a new <see cref="TimeSpanResponse"/> with specified detailed error.
        /// </summary>
        /// <param name="message">Error message</param>
        /// <param name="code">Error code</param>
        /// <returns>
        /// A new invalid <see cref="TimeSpanResponse"/> with specified detailed error.
        /// </returns>
        public new static TimeSpanResponse CreateErroResponse(string message, string code = "") => CreateErroResponse(new IResponseError[] { new ResponseError { Code = code, Message = message } });

        /// <summary>
        /// Returns a new <see cref="TimeSpanResponse"/> with specified detailed errors collection.
        /// </summary>
        /// <param name="errors">A errors collection</param>
        /// <returns>
        /// A new invalid <see cref="TimeSpanResponse"/> with specified detailed errors collection.
        /// </returns>
        public new static TimeSpanResponse CreateErroResponse(IResponseError[] errors) =>
            new TimeSpanResponse
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
        /// A new valid <see cref="TimeSpanResponse"/>.
        /// </returns>
        public new static TimeSpanResponse CreateSuccessResponse(TimeSpan value) =>
            new TimeSpanResponse
            {
                Value = value,
                Success = true,
                Errors = new List<IResponseError>()
            };

        /// <summary>
        /// Creates a new <see cref="TimeSpanResponse"/> instance from known exception.
        /// </summary>
        /// <param name="exception">Target exception.</param>
        /// <returns>
        /// A new <see cref="TimeSpanResponse"/> instance for specified exception.
        /// </returns>
        public new static TimeSpanResponse FromException(System.Exception exception) =>
            new TimeSpanResponse
            {
                Success = false,
                Errors = new List<IResponseError> { new ResponseExceptionError { Exception = exception } }
            };
    }
}
