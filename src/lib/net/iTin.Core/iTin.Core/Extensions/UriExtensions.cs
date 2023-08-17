
using System;
using System.Net;
using System.Threading.Tasks;

using iTin.Core.ComponentModel;
using iTin.Core.ComponentModel.Results;

namespace iTin.Core;

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
    public static IResult IsAccessible(this Uri uri)
    {
        if (uri == null)
        {
            return BooleanResult.CreateErrorResult("url can not be null");
        }

        try
        {
            var request = WebRequest.Create(uri);
            _ = request.GetResponse();

            return BooleanResult.SuccessResult;
        }
        catch (Exception e)
        {
            return BooleanResult.FromException(e);
        }
    }


    /// <summary>
    /// Gets or sets a value indicating whether the specified <see cref="Uri"/> is accessible asynchronously.
    /// </summary>
    /// <param name="uri">Target <see cref="Uri"/> to check</param>
    /// <returns>
    /// <b>true</b> if specified <see cref="Uri"/> is accessible; otherwise <b>false</b>.
    /// </returns>
    public static async Task<IResult> IsAccessibleAsync(this Uri uri)
    {
        if (uri == null)
        {
            return BooleanResult.CreateErrorResult("url can not be null");
        }

        try
        {
            var request = WebRequest.Create(uri);
            _ = await request.GetResponseAsync();

            return BooleanResult.SuccessResult;
        }
        catch (Exception e)
        {
            return BooleanResult.FromException(e);
        }
    }
}
