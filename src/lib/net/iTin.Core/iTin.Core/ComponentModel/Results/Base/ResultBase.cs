
namespace iTin.Core.ComponentModel
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Specialization of the interface <see cref="IResult{T}"/><br/>
    /// Base class that serves to defines a result.
    /// </summary>
    /// <typeparam name="T">Data type of result</typeparam>
    public class ResultBase<T> : IResult<T>
    {
        #region constructor/s

        #region [protected] ResultBase(): Initializes a new instance of the class
        /// <summary>
        /// Initializes a new instance of the <see cref="ResultBase{T}" /> class.
        /// </summary>
        protected ResultBase()
        {
            Success = false;
            Errors = new List<ResultError>();
        }
        #endregion

        #endregion

        #region public static properties

        #region [public] {static} (IResult<T>) ErrorResult: Returns a new result indicating that output result has not been successfully
        /// <summary>
        /// Returns a new result indicating that output result has not been successfully.
        /// </summary>
        public static IResult<T> ErrorResult => new ResultBase<T> { Success = false };
        #endregion

        #region [public] {static} (IResult<T>) NullResult: Returns a new result indicating a null result
        /// <summary>
        /// Returns a new result indicating a null result.
        /// </summary>
        public static IResult<T> NullResult => null;
        #endregion

        #region [public] {static} (IResult<T>) SuccessResult: Returns a new result indicating that output result has been successfully
        /// <summary>
        /// Returns a new result indicating that output result has been successfully.
        /// </summary>
        public static IResult<T> SuccessResult => new ResultBase<T> { Success = true };
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

        #region [public] (IEnumerable<IResultError>) Errors: Gets or sets a value that contains an error list
        /// <inheritdoc />
        /// <summary>
        /// Gets or sets a value that contains an error list.
        /// </summary>
        /// <value>
        /// Error list.
        /// </value>
        public IEnumerable<IResultError> Errors { get; set; }
        #endregion

        #region [public] (bool) Success: Gets or sets a value that indicates whether the current operation was executed successfully
        /// <inheritdoc />
        /// <summary>
        /// Gets or sets a value that indicates whether the current operation was executed successfully.
        /// </summary>
        /// <value>
        /// <b>true</b> if current operation was executed successfully; otherwise, <b>false</b>.
        /// </value>
        public bool Success { get; set; }
        #endregion

        #region [public] (T) Result: Gets or sets a value that contains the result value information
        /// <inheritdoc />
        /// <summary>
        /// Gets or sets a value that contains the result value information.
        /// </summary>
        /// <value>
        /// The result information.
        /// </value>
        public T Result { get; set; }
        #endregion

        #region [public] (IEnumerable<IResultWarning>) Warnings: Gets or sets a value that contains a warnings messages list
        /// <inheritdoc />
        /// <summary>
        /// Gets or sets a value that contains a warnings messages list.
        /// </summary>
        /// <value>
        /// Warnings list.
        /// </value>
        public IEnumerable<IResultWarning> Warnings { get; set; }
        #endregion

        #endregion

        #region public static methods

        #region [public] {static} (ResultBase<T>) CreateErroResult(string, string = null): Returns a new result with specified detailed error
        /// <summary>
        /// Returns a new <see cref="ResultBase{T}"/> with specified detailed error.
        /// </summary>
        /// <param name="message">Error message</param>
        /// <param name="code">Error code</param>
        /// <returns>
        /// A new invalid <see cref="ResultBase{T}"/> with specified detailed error.
        /// </returns>
        public static ResultBase<T> CreateErroResult(string message, string code = "") => CreateErroResult(new IResultError[] { new ResultError { Code = code, Message = message } });
        #endregion

        #region [public] {static} (ResultBase<T>) CreateErroResult(IResultError[]): Returns a new result with specified detailed errors collection
        /// <summary>
        /// Returns a new <see cref="ResultBase{T}"/> with specified detailed errors collection.
        /// </summary>
        /// <param name="errors">A errors collection</param>
        /// <returns>
        /// A new invalid <see cref="ResultBase{T}"/> with specified detailed errors collection.
        /// </returns>
        public static ResultBase<T> CreateErroResult(IResultError[] errors) =>
            new ResultBase<T>
            {
                Result = default,
                Success = false,
                Errors = (IResultError[])errors.Clone()
            };
        #endregion

        #region [public] {static} (ResultBase<T>) CreateErroResult(string, T, string = null): Returns a new result with specified detailed error
        /// <summary>
        /// Returns a new result with specified detailed error.
        /// </summary>
        /// <param name="message">Error message</param>
        /// <param name="value">Response value</param>
        /// <param name="code">Error code</param>
        /// <returns>
        /// A new valid <see cref="ResultBase{T}"/>.
        /// </returns>
        public static ResultBase<T> CreateErroResult(string message, T value, string code = "") => CreateErroResult(new IResultError[] { new ResultError { Code = code, Message = message } }, value);
        #endregion

        #region [public] {static} (ResultBase<T>) CreateErroResult(IResultError[], T): Returns a new result with specified detailed errors collection
        /// <summary>
        /// Returns a new <see cref="ResultBase{T}"/> with specified detailed errors collection.
        /// </summary>
        /// <param name="errors">A errors collection</param>
        /// <param name="value">Response value</param>
        /// <returns>
        /// A new invalid <see cref="ResultBase{T}"/> with specified detailed errors collection.
        /// </returns>
        public static ResultBase<T> CreateErroResult(IResultError[] errors, T value) =>
            new ResultBase<T>
            {
                Result = value,
                Success = false,
                Errors = (IResultError[])errors.Clone()
            };
        #endregion

        #region [public] {static} (ResultBase<T>) CreateSuccessResult(T): Creates a new success result
        /// <summary>
        /// Returns a new success result.
        /// </summary>
        /// <param name="value">Response value</param>
        /// <returns>
        /// A new valid <see cref="ResultBase{T}"/>.
        /// </returns>
        public static ResultBase<T> CreateSuccessResult(T value) =>
            new ResultBase<T>
            {
                Result = value,
                Success = true,
                Errors = new List<IResultError>()
            };
        #endregion

        #region [public] {static} (ResultBase<T>) FromException(Exception): Creates a new instance from known exception
        /// <summary>
        /// Creates a new <see cref="ResultBase{T}"/> instance from known exception.
        /// </summary>
        /// <param name="exception">Target exception.</param>
        /// <returns>
        /// A new <see cref="ResultBase{T}"/> instance for specified exception.
        /// </returns>
        public static ResultBase<T> FromException(Exception exception) => FromException(exception, default(T));
        #endregion

        #region [public] {static} (ResultBase<T>) FromException(Exception, T): Creates a new instance from known exception
        /// <summary>
        /// Creates a new <see cref="ResultBase{T}"/> instance from known exception.
        /// </summary>
        /// <param name="exception">Target exception.</param>
        /// <param name="value">Response value</param>
        /// <returns>
        /// A new <see cref="ResultBase{T}"/> instance for specified exception.
        /// </returns>
        public static ResultBase<T> FromException(Exception exception, T value) =>
            new ResultBase<T>
            {
                Result = value,
                Success = false,
                Errors = new List<IResultError> { new ResultExceptionError { Exception = exception } }
            };

        #endregion

        #endregion

        #region public override methods

        #region [public] {override} (string) ToString(): Returns a string than represents the current object.
        /// <summary>
        /// Returns a string that represents the current data type.
        /// </summary>
        /// <returns>
        /// A <see cref="string"/> than represents the current object.
        /// </returns>
        public override string ToString() => $"Success = {Success}, HasWarnings = {HasWarnings}";
        #endregion

        #endregion
    }
}
