
namespace iTin.Core.ComponentModel.Responses
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Specialization of the interface <see cref="ResponseBase{T}" /> that contains a nullable timespan response.
    /// </summary>
    public class NullableTimeSpanResponse : ResponseBase<TimeSpan?>
    {
        /// <summary>
        /// Returns a new <see cref="NullableTimeSpanResponse"/> with specified detailed error.
        /// </summary>
        /// <param name="message">Error message</param>
        /// <param name="code">Error code</param>
        /// <returns>
        /// A new invalid <see cref="NullableTimeSpanResponse"/> with specified detailed error.
        /// </returns>
        public new static NullableTimeSpanResponse CreateErroResponse(string message, string code = "") => CreateErroResponse(new IResponseError[] { new ResponseError { Code = code, Message = message } });

        /// <summary>
        /// Returns a new <see cref="NullableTimeSpanResponse"/> with specified detailed errors collection.
        /// </summary>
        /// <param name="errors">A errors collection</param>
        /// <returns>
        /// A new invalid <see cref="NullableTimeSpanResponse"/> with specified detailed errors collection.
        /// </returns>
        public new static NullableTimeSpanResponse CreateErroResponse(IResponseError[] errors) =>
            new NullableTimeSpanResponse
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
        /// A new valid <see cref="NullableTimeSpanResponse"/>.
        /// </returns>
        public new static NullableTimeSpanResponse CreateSuccessResponse(TimeSpan? value) =>
            new NullableTimeSpanResponse
            {
                Value = value,
                Success = true,
                Errors = new List<IResponseError>()
            };

        /// <summary>
        /// Creates a new <see cref="NullableTimeSpanResponse"/> instance from known exception.
        /// </summary>
        /// <param name="exception">Target exception.</param>
        /// <returns>
        /// A new <see cref="NullableTimeSpanResponse"/> instance for specified exception.
        /// </returns>
        public new static NullableTimeSpanResponse FromException(System.Exception exception) =>
            new NullableTimeSpanResponse
            {
                Success = false,
                Errors = new List<IResponseError> { new ResponseExceptionError { Exception = exception } }
            };
    }
}
