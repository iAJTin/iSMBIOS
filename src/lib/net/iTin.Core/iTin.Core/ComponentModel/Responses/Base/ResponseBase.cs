
using System;
using System.Collections.Generic;
using System.Linq;

namespace iTin.Core.ComponentModel;

/// <summary>
/// Specialization of the interface <see cref="IResponse{T}"/> that acts as a base class that serves to defines a response.
/// </summary>
/// <typeparam name="T">Data type of response </typeparam>
public class ResponseBase<T> : IResponse<T>
{
    #region constructor/s

    /// <summary>
    /// Initializes a new instance of the <see cref="ResponseBase{T}"/> class.
    /// </summary>
    protected ResponseBase()
    {
        Success = false;
        Errors = new List<ResponseError>();
    }

    #endregion

    #region public static properties

    /// <summary>
    /// Returns a new response indicating a null response.
    /// </summary>
    public static IResponse<T> NullResponse => null;

    /// <summary>
    /// Returns a new response indicating that output response has been saved successfully.
    /// </summary>
    public static IResponse<T> SuccessResponse => new ResponseBase<T> { Success = true };

    #endregion

    #region public readonly properties

    /// <summary>
    /// Gets a value that indicates whether the last operation has warnings.
    /// </summary>
    /// <value>
    /// <b>true</b> if last operation has warnings; otherwise, <b>false</b>.
    /// </value>
    public bool HasWarnings => Warnings != null && Warnings.Any();

    #endregion

    #region public properties

    /// <summary>
    /// Gets or sets a value that contains a error list.
    /// </summary>
    /// <value>
    /// Error list.
    /// </value>
    public IEnumerable<IResponseError> Errors { get; set; }

    /// <summary>
    /// Gets or sets a value that indicates whether the current operation was executed successfully.
    /// </summary>
    /// <value>
    /// <b>true</b> if current operation was executed successfully; otherwise, <b>false</b>.
    /// </value>
    public bool Success { get; set; }

    /// <summary>
    /// Gets or sets a value that contains response.
    /// </summary>
    /// <value>
    /// A reference that contains respponse
    /// </value>
    public T Value { get; set; }

    /// <inheritdoc />
    /// <summary>
    /// Gets or sets a value that contains a warnings messages list.
    /// </summary>
    /// <value>
    /// Warnings list.
    /// </value>
    public IEnumerable<IResponseWarning> Warnings { get; set; }

    #endregion

    #region public static methods

    /// <summary>
    /// Returns a new <see cref="ResponseBase{T}"/> with specified detailed error.
    /// </summary>
    /// <param name="message">Error message</param>
    /// <param name="code">Error code</param>
    /// <returns>
    /// A new invalid <see cref="ResponseBase{T}"/> with specified detailed error.
    /// </returns>
    public static ResponseBase<T> CreateErroResponse(string message, string code = "") => CreateErroResponse(new IResponseError[] { new ResponseError { Code = code, Message = message } });

    /// <summary>
    /// Returns a new <see cref="ResponseBase{T}"/> with specified detailed errors collection.
    /// </summary>
    /// <param name="errors">A errors collection</param>
    /// <returns>
    /// A new invalid <see cref="ResponseBase{T}"/> with specified detailed errors collection.
    /// </returns>
    public static ResponseBase<T> CreateErroResponse(IResponseError[] errors) =>
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
    /// A new valid <see cref="ResponseBase{T}"/>.
    /// </returns>
    public static ResponseBase<T> CreateSuccessResponse(T value) =>
        new()
        {
            Value = value,
            Success = true,
            Errors = new List<IResponseError>()
        };

    /// <summary>
    /// Creates a new instance from known exception.
    /// </summary>
    /// <param name="exception">Target exception.</param>
    /// <returns>
    /// A new <see cref="ResponseBase{T}"/> instance for specified exception.
    /// </returns>
    public static ResponseBase<T> FromException(Exception exception) =>
        new()
        {
            Success = false,
            Errors = new List<ResponseError> { new ResponseExceptionError { Exception = exception } }
        };

    #endregion

    #region public override methods

    /// <summary>
    /// Returns a string that represents the current data type.
    /// </summary>
    /// <returns>
    /// A <see cref="string" /> than represents the current object.
    /// </returns>
    public override string ToString() => $"Success = {Success}";

    #endregion
}
