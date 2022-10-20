
namespace iTin.Core.Hardware.Abstractions.Devices.Graphics
{
    /// <summary>
    /// Define a generic <strong>Font</strong> operations.
    /// </summary>
    public interface IFontOperations
    {
        /// <summary>
        /// Try to register a <strong>Font</strong> from file.
        /// </summary>
        /// <param name="fullPath">Full path to font file</param>
        /// <returns>
        /// A 
        /// </returns>
        int AddFontResource(string fullPath);
    }
}
