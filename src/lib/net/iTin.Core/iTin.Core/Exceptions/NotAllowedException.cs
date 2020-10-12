          
namespace iTin.Core.Exceptions
{
    /// <summary>
    /// Class NotAllowedException.
    /// </summary>
    /// <seealso cref="Exception" />
    public class NotAllowedException : Exception
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NotAllowedException"/> class.
        /// </summary>
        /// <param name="resourceKey">The resource key.</param>
        public NotAllowedException(string resourceKey) : base("iTin.Core.Localization.Exceptions.NotAllowedException",
            resourceKey)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NotAllowedException"/> class.
        /// </summary>
        public NotAllowedException() : base("iTin.Core.Localization.Exceptions.NotAllowedException", "NOT_ALLOWED")
        {
        }
    }
}
