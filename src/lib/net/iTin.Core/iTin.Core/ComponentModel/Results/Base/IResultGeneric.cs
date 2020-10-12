
namespace iTin.Core.ComponentModel
{
    /// <summary>
    /// Defines a generic result.
    /// </summary>
    /// <typeparam name="T">Data type of result </typeparam>
    public interface IResult<T> : IResult
    {
        /// <summary>
        /// Gets a value that contains result.
        /// </summary>
        /// <value>
        /// A reference that contains result.
        /// </value>
        T Value { get; set; }
    }
}
