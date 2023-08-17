
using System.Collections.Generic;
using System.Linq;

namespace iTin.Core.ComponentModel;

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

    /// <summary>
    /// Returns the error list as <see cref="Messages"/> object.
    /// </summary>
    /// <param name="errors"></param>
    /// <returns>
    /// A new <see cref="Messages"/> reference thats contains error list.
    /// </returns>
    public static IEnumerable<IResultWarning> AsWarnings(this IEnumerable<IResultError> errors) =>
        errors.Select(AsWarning);

    /// <summary>
    /// Returns the error as <see cref="IResultWarning"/> object.
    /// </summary>
    /// <param name="error"></param>
    /// <returns>
    /// A new <see cref="IResultWarning"/> reference thats contains error as warning.
    /// </returns>
    public static IResultWarning AsWarning(this IResultError error) =>
        new ResultWarning
        {
            Code = error.Code, Message = error.Message
        };
}
