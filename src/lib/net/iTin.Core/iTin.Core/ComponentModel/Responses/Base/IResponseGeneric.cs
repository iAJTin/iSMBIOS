
namespace iTin.Core.ComponentModel
{
    /// <summary>
    /// Defines a generic response.
    /// </summary>
    /// <typeparam name="T">Data type of response </typeparam>
    public interface IResponse<T> : IResponse
    {
        /// <summary>
        /// Gets a value that contains response.
        /// </summary>
        /// <value>
        /// A reference that contains response.
        /// </value>
        T Value { get; set; }
    }
}
