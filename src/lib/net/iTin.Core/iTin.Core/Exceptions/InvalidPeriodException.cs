
namespace iTin.Core.Exceptions
{
    /// <summary>
    /// Exception for a invalid period.
    /// </summary>
    public class InvalidPeriodException : Exception
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InvalidPeriodException"/> class.
        /// </summary>
        /// <param name="resourceKey">The resource key.</param>
        public InvalidPeriodException(string resourceKey) : base("iTin.Core.Localization.Exceptions.InvalidPeriodException",
            resourceKey)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InvalidPeriodException"/> class.
        /// </summary>
        public InvalidPeriodException() : base("iTin.Core.Localization.Exceptions.InvalidPeriodException", "ENDDATE_MUSTBE_GREATHER_STARTDATE")
        {
        }
    }
}
