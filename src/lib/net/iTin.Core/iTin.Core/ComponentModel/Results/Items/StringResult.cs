﻿
using System;
using System.Collections.Generic;

namespace iTin.Core.ComponentModel.Results
{
    /// <summary>
    /// Specialization of the interface <see cref="ResultBase{T}" /> that contains a <see cref="T:System.String"/> result.
    /// </summary>
    public class StringResult : ResultBase<string>
    {
        /// <summary>
        /// Returns a new <see cref="StringResult"/> with specified detailed error.
        /// </summary>
        /// <param name="message">Error message</param>
        /// <param name="code">Error code</param>
        /// <returns>
        /// A new invalid <see cref="StringResult"/> with specified detailed error.
        /// </returns>
        public new static StringResult CreateErrorResult(string message, string code = "") => 
            CreateErrorResult(new IResultError[] { new ResultError { Code = code, Message = message } });

        /// <summary>
        /// Returns a new <see cref="StringResult"/> with specified detailed error.
        /// </summary>
        /// <param name="message">Error message</param>
        /// <param name="result">Result Result</param>
        /// <param name="code">Error code</param>
        /// <returns>
        /// A new invalid <see cref="StringResult"/> with specified detailed error.
        /// </returns>
        public new static StringResult CreateErrorResult(string message, string result, string code = "") => 
            CreateErrorResult(new IResultError[] { new ResultError { Code = code, Message = message } }, result);

        /// <summary>
        /// Returns a new <see cref="StringResult"/> with specified detailed errors collection.
        /// </summary>
        /// <param name="errors">A errors collection</param>
        /// <returns>
        /// A new invalid <see cref="StringResult"/> with specified detailed errors collection.
        /// </returns>
        public new static StringResult CreateErrorResult(IResultError[] errors) =>
            new()
            {
                Result = default,
                Success = false,
                Errors = (IResultError[])errors.Clone()
            };

        /// <summary>
        /// Returns a new <see cref="StringResult"/> with specified detailed errors collection.
        /// </summary>
        /// <param name="errors">A errors collection</param>
        /// <param name="result">Result Result</param>
        /// <returns>
        /// A new invalid <see cref="StringResult"/> with specified detailed errors collection.
        /// </returns>
        public new static StringResult CreateErrorResult(IResultError[] errors, string result) =>
            new()
            {
                Result = result,
                Success = false,
                Errors = (IResultError[])errors.Clone()
            };

        /// <summary>
        /// Returns a new success result.
        /// </summary>
        /// <param name="result">Result Result</param>
        /// <returns>
        /// A new valid <see cref="StringResult"/>.
        /// </returns>
        public new static StringResult CreateSuccessResult(string result) =>
            new()
            {
                Result = result,
                Success = true,
                Errors = new List<IResultError>()
            };

        /// <summary>
        /// Creates a new <see cref="StringResult"/> instance from known exception.
        /// </summary>
        /// <param name="exception">Target exception.</param>
        /// <returns>
        /// A new <see cref="StringResult"/> instance for specified exception.
        /// </returns>
        public new static StringResult FromException(Exception exception) => 
            FromException(exception, default);

        /// <summary>
        /// Creates a new <see cref="StringResult"/> instance from known exception.
        /// </summary>
        /// <param name="exception">Target exception.</param>
        /// <param name="result">Result Result</param>
        /// <returns>
        /// A new <see cref="StringResult"/> instance for specified exception.
        /// </returns>
        public new static StringResult FromException(Exception exception, string result) =>
            new()
            {
                Result = result,
                Success = false,
                Errors = new List<IResultError> { new ResultExceptionError { Exception = exception } }
            };
    }
}
