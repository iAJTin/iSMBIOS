
using System;
using System.Collections.Generic;
using System.Linq;

namespace iTin.Core.ComponentModel
{
    /// <summary>
    /// Specialization of the interface <see cref="IResponse{T}"/> that acts as a base class that serves to defines a response.
    /// </summary>
    /// <typeparam name="T">Data type of response </typeparam>
    public class ResponseBase<T> : IResponse<T>
    {
        #region constructor/s

        #region [protected] ResponseBase(): Initializes a new instance of the class
        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseBase{T}"/> class.
        /// </summary>
        protected ResponseBase()
        {
            Success = false;
            Errors = new List<ResponseError>();
        }
        #endregion

        #endregion

        #region public static properties

        #region [public] {static} (IResponse<T>) NullResponse: Returns a new response indicating a null response
        /// <summary>
        /// Returns a new response indicating a null response.
        /// </summary>
        public static IResponse<T> NullResponse => null;
        #endregion

        #region [public] {static} (IResponse<T>) SuccessResponse: Returns a new response indicating that output response has been saved successfully
        /// <summary>
        /// Returns a new response indicating that output response has been saved successfully.
        /// </summary>
        public static IResponse<T> SuccessResponse => new ResponseBase<T> { Success = true };
        #endregion

        #endregion

        #region public readonly properties

        #region [public] (bool) HasWarnings: Gets a value that indicates whether the last operation has warnings
        /// <summary>
        /// Gets a value that indicates whether the last operation has warnings.
        /// </summary>
        /// <value>
        /// <b>true</b> if last operation has warnings; otherwise, <b>false</b>.
        /// </value>
        public bool HasWarnings => Warnings != null && Warnings.Any();

        #endregion

        #endregion

        #region public properties

        #region [public] (IEnumerable<ResponseError>) Errors: Gets or sets a value that contains a error list
        /// <summary>
        /// Gets or sets a value that contains a error list.
        /// </summary>
        /// <value>
        /// Error list.
        /// </value>
        public IEnumerable<IResponseError> Errors { get; set; }
        #endregion

        #region [public] (bool) Success: Gets or sets a value that indicates whether the current operation was executed successfully
        /// <summary>
        /// Gets or sets a value that indicates whether the current operation was executed successfully.
        /// </summary>
        /// <value>
        /// <b>true</b> if current operation was executed successfully; otherwise, <b>false</b>.
        /// </value>
        public bool Success { get; set; }
        #endregion

        #region [public] (T) Value: Gets or sets a value that contains respponse
        /// <summary>
        /// Gets or sets a value that contains response.
        /// </summary>
        /// <value>
        /// A reference that contains respponse
        /// </value>
        public T Value { get; set; }
        #endregion

        #region [public] (IEnumerable<IResponseWarning>) Warnings: Gets or sets a value that contains a warnings messages list
        /// <inheritdoc />
        /// <summary>
        /// Gets or sets a value that contains a warnings messages list.
        /// </summary>
        /// <value>
        /// Warnings list.
        /// </value>
        public IEnumerable<IResponseWarning> Warnings { get; set; }
        #endregion

        #endregion

        #region public static methods

        #region [public] {static} (ResponseBase<T>) CreateErroResponse(string, string): Returns a new response with specified detailed error
        /// <summary>
        /// Returns a new <see cref="ResponseBase{T}"/> with specified detailed error.
        /// </summary>
        /// <param name="message">Error message</param>
        /// <param name="code">Error code</param>
        /// <returns>
        /// A new invalid <see cref="ResponseBase{T}"/> with specified detailed error.
        /// </returns>
        public static ResponseBase<T> CreateErroResponse(string message, string code = "") => CreateErroResponse(new IResponseError[] { new ResponseError { Code = code, Message = message } });
        #endregion

        #region [public] {static} (ResponseBase<T>) CreateErroResponse(T): Returns a new response with specified detailed errors collection
        /// <summary>
        /// Returns a new <see cref="ResponseBase{T}"/> with specified detailed errors collection.
        /// </summary>
        /// <param name="errors">A errors collection</param>
        /// <returns>
        /// A new invalid <see cref="ResponseBase{T}"/> with specified detailed errors collection.
        /// </returns>
        public static ResponseBase<T> CreateErroResponse(IResponseError[] errors) =>
            new ResponseBase<T>
            {
                Value = default,
                Success = false,
                Errors = (IResponseError[])errors.Clone()
            };
        #endregion

        #region [public] {static} (ResponseBase<T>) CreateSuccessResponse(T): Creates a new success response
        /// <summary>
        /// Returns a new success response.
        /// </summary>
        /// <param name="value">Response value</param>
        /// <returns>
        /// A new valid <see cref="ResponseBase{T}"/>.
        /// </returns>
        public static ResponseBase<T> CreateSuccessResponse(T value) =>
            new ResponseBase<T>
            {
                Value = value,
                Success = true,
                Errors = new List<IResponseError>()
            };
        #endregion

        #region [public] {static} (ResponseBase<T>) FromException(Exception): Creates a new instance from known exception
        /// <summary>
        /// Creates a new instance from known exception.
        /// </summary>
        /// <param name="exception">Target exception.</param>
        /// <returns>
        /// A new <see cref="ResponseBase{T}"/> instance for specified exception.
        /// </returns>
        public static ResponseBase<T> FromException(Exception exception)
        {
            return new ResponseBase<T>
            {
                Success = false,
                Errors = new List<ResponseError> { new ResponseExceptionError { Exception = exception } }
            };
        }
        #endregion

        #endregion

        #region public override methods

        #region [public] {override} (string) ToString(): Returns a string than represents the current object.
        /// <summary>
        /// Returns a string that represents the current data type.
        /// </summary>
        /// <returns>
        /// A <see cref="string" /> than represents the current object.
        /// </returns>
        public override string ToString() => $"Success = {Success}";
        #endregion

        #endregion
    }
}
