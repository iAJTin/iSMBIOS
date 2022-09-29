
using System.Collections.Generic;

namespace iTin.Core.ComponentModel
{
    /// <summary>
    /// Static class than contains extension methods for IResponseError references.
    /// </summary> 
    public static class ResponseErrorExtensions
    {
        /// <summary>
        /// Returns the error list as <see cref="Messages"/> object.
        /// </summary>
        /// <param name="errors"></param>
        /// <returns>
        /// A new <see cref="Messages"/> reference thats contains error list.
        /// </returns>
        public static Messages AsMessages(this IEnumerable<IResponseError> errors)
        {
            var msgs = new Messages();

            foreach (var error in errors)
            {
                msgs.Add(error.Message);
            }

            return msgs;
        }
    }
}
