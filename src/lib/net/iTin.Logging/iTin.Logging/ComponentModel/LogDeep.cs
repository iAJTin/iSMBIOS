
namespace iTin.Logging.ComponentModel
{
    /// <summary>
    /// Contains values that specify log deep
    /// </summary>
    public enum LogDeep
    {
        /// <summary>
        /// Logger show any call (Application / External).
        /// </summary>
        AnyCall,

        /// <summary>
        /// Logger show only application calls.
        /// </summary>
        OnlyApplicationCalls,

        /// <summary>
        /// Logger show only library external calls.
        /// </summary>
        OnlyExternalCalls,
    }
}
