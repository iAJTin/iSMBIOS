
namespace iTin.Core.ComponentModel
{
    using System.Collections.Generic;

    /// <summary>
    /// Static class than contains extension methods for IResultError references.
    /// </summary> 
    public static class ResultErrorExtensions
    {
        /// <summary>
        /// Returns the error list as <see cref="Messages"/> object.
        /// </summary>
        /// <param name="errors"></param>
        /// <returns>
        /// A new <see cref="Messages"/> reference thats contains error list.
        /// </returns>
        public static Messages AsMessages(this IEnumerable<IResultError> errors)
        {
            var msgs = new Messages();

            foreach (var error in errors)
            {
                if (error is ResultExceptionError ex)
                {
                    msgs.Add(ex.Exception.Message);
                }
                else
                {
                    msgs.Add(error.Message);
                }
            }

            return msgs;
        }
    }
}
