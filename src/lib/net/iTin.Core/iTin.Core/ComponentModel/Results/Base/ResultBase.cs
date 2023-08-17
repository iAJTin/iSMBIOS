
using System;
using System.Collections.Generic;
using System.Linq;

namespace iTin.Core.ComponentModel;

/// <summary>
/// Specialization of the interface <see cref="IResult{T}"/><br/>
/// Base class that serves to defines a result.
/// </summary>
/// <typeparam name="T">Data type of result</typeparam>
public class ResultBase<T> : IResult<T>
{
    #region constructor/s

    /// <summary>
    /// Initializes a new instance of the <see cref="ResultBase{T}" /> class.
    /// </summary>
    protected ResultBase()
    {
        Success = false;
        Errors = Enumerable.Empty<IResultError>();
        Warnings = Enumerable.Empty<IResultWarning>();
    }

    #endregion

    #region public static properties

    /// <summary>
    /// Returns a new result indicating that output result has not been successfully.
    /// </summary>
    public static IResult<T> ErrorResult => new ResultBase<T> { Success = false };

    /// <summary>
    /// Returns a new result indicating a null result.
    /// </summary>
    public static IResult<T> NullResult => null;

    /// <summary>
    /// Returns a new result indicating that output result has been successfully.
    /// </summary>
    public static IResult<T> SuccessResult => new ResultBase<T> { Success = true };

    #endregion

    #region public readonly properties

    /// <summary>
    /// Gets a value that indicates whether the last operation has warnings.
    /// </summary>
    /// <value>
    /// <b>true</b> if last operation has warnings; otherwise, <b>false</b>.
    /// </value>
    public bool HasWarnings => !Warnings.IsNullOrEmpty();

    #endregion

    #region public properties

    /// <inheritdoc />
    /// <summary>
    /// Gets or sets a value that contains an error list.
    /// </summary>
    /// <value>
    /// Error list.
    /// </value>
    public IEnumerable<IResultError> Errors { get; set; }

    /// <inheritdoc />
    /// <summary>
    /// Gets or sets a value that indicates whether the current operation was executed successfully.
    /// </summary>
    /// <value>
    /// <b>true</b> if current operation was executed successfully; otherwise, <b>false</b>.
    /// </value>
    public bool Success { get; set; }

    /// <inheritdoc />
    /// <summary>
    /// Gets or sets a value that contains the result value information.
    /// </summary>
    /// <value>
    /// The result information.
    /// </value>
    public T Result { get; set; }

    /// <inheritdoc />
    /// <summary>
    /// Gets or sets a value that contains a warnings messages list.
    /// </summary>
    /// <value>
    /// Warnings list.
    /// </value>
    public IEnumerable<IResultWarning> Warnings { get; set; }

    #endregion

    #region public static methods

    /// <summary>
    /// Returns a new <see cref="ResultBase{T}"/> with specified detailed error.
    /// </summary>
    /// <param name="message">Error message</param>
    /// <param name="code">Error code</param>
    /// <returns>
    /// A new invalid <see cref="ResultBase{T}"/> with specified detailed error.
    /// </returns>
    public static ResultBase<T> CreateErrorResult(string message, string code = "") => 
        CreateErrorResult(new IResultError[] { new ResultError { Code = code, Message = message } });

    /// <summary>
    /// Returns a new <see cref="ResultBase{T}"/> with specified detailed errors collection.
    /// </summary>
    /// <param name="errors">A errors collection</param>
    /// <returns>
    /// A new invalid <see cref="ResultBase{T}"/> with specified detailed errors collection.
    /// </returns>
    public static ResultBase<T> CreateErrorResult(IResultError[] errors) =>
        new()
        {
            Result = default,
            Success = false,
            Errors = (IResultError[])errors.Clone()
        };

    /// <summary>
    /// Returns a new result with specified detailed error.
    /// </summary>
    /// <param name="message">Error message</param>
    /// <param name="value">Response value</param>
    /// <param name="code">Error code</param>
    /// <returns>
    /// A new valid <see cref="ResultBase{T}"/>.
    /// </returns>
    public static ResultBase<T> CreateErrorResult(string message, T value, string code = "") => 
        CreateErrorResult(new IResultError[] { new ResultError { Code = code, Message = message } }, value);

    /// <summary>
    /// Returns a new <see cref="ResultBase{T}"/> with specified detailed errors collection.
    /// </summary>
    /// <param name="errors">A errors collection</param>
    /// <param name="value">Response value</param>
    /// <returns>
    /// A new invalid <see cref="ResultBase{T}"/> with specified detailed errors collection.
    /// </returns>
    public static ResultBase<T> CreateErrorResult(IResultError[] errors, T value) =>
        new()
        {
            Result = value,
            Success = false,
            Errors = (IResultError[])errors.Clone()
        };

    /// <summary>
    /// Returns a new success result.
    /// </summary>
    /// <param name="value">Response value</param>
    /// <returns>
    /// A new valid <see cref="ResultBase{T}"/>.
    /// </returns>
    public static ResultBase<T> CreateSuccessResult(T value) =>
        new()
        {
            Result = value,
            Success = true,
            Errors = new List<IResultError>()
        };

    /// <summary>
    /// Creates a new <see cref="ResultBase{T}"/> instance from known exception.
    /// </summary>
    /// <param name="exception">Target exception.</param>
    /// <returns>
    /// A new <see cref="ResultBase{T}"/> instance for specified exception.
    /// </returns>
    public static ResultBase<T> FromException(Exception exception) => 
        FromException(exception, default);

    /// <summary>
    /// Creates a new <see cref="ResultBase{T}"/> instance from known exception.
    /// </summary>
    /// <param name="exception">Target exception.</param>
    /// <param name="value">Response value</param>
    /// <returns>
    /// A new <see cref="ResultBase{T}"/> instance for specified exception.
    /// </returns>
    public static ResultBase<T> FromException(Exception exception, T value) =>
        new()
        {
            Result = value,
            Success = false,
            Errors = new List<IResultError> { new ResultExceptionError { Exception = exception } }
        };

    #endregion

    #region public override methods

    /// <summary>
    /// Returns a string that represents the current data type.
    /// </summary>
    /// <returns>
    /// A <see cref="string"/> than represents the current object.
    /// </returns>
    public override string ToString() => $"Success = {Success}, HasWarnings = {HasWarnings}";

    #endregion
}
