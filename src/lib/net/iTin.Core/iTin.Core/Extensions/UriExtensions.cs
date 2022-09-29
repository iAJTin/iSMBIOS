
using System;
using System.Net;
using System.Threading.Tasks;

namespace iTin.Core
{
    /// <summary>
    /// Static class than contains extension methods for a <see cref="Uri"/> references.
    /// </summary> 
    public static class UriExtensions
    {
        /// <summary>
        /// Gets or sets a value indicating whether the specified <see cref="Uri"/> is accessible synchronously.
        /// </summary>
        /// <param name="uri">Target <see cref="Uri"/> to check</param>
        /// <returns>
        /// <b>true</b> if specified <see cref="Uri"/> is accessible; otherwise <b>false</b>.
        /// </returns>
        public static bool IsAccessible(this Uri uri)
        {
            if (uri == null)
            {
                return false;
            }

            try
            {
                var request = WebRequest.Create(uri);
                var response = request.GetResponse();

                return true;
            }
            catch
            {
                return false;
            }
        }


        /// <summary>
        /// Gets or sets a value indicating whether the specified <see cref="Uri"/> is accessible asynchronously.
        /// </summary>
        /// <param name="uri">Target <see cref="Uri"/> to check</param>
        /// <returns>
        /// <b>true</b> if specified <see cref="Uri"/> is accessible; otherwise <b>false</b>.
        /// </returns>
        public static async Task<bool> IsAccessibleAsync(this Uri uri)
        {
            if (uri == null)
            {
                return false;
            }

            try
            {
                var request = WebRequest.Create(uri);
                var response = await request.GetResponseAsync();

                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
