
using System;
using System.Collections.Generic;
using System.Linq;

using iTin.Logging;

namespace iTin.Core;

/// <summary>
/// Static class than contains extension methods for generic objects.
/// </summary> 
public static class GenericExtensions
{
    /// <summary>
    /// Executes a function if a given predicate is <b>true</b>.
    /// </summary>
    /// <typeparam name="T">Parameter type</typeparam>
    /// <param name="val">The value.</param>
    /// <param name="predicate">The predicate.</param>
    /// <param name="func">The function to execute.</param>
    /// <returns>
    /// Result
    /// </returns>
    public static T If<T>(this T val, Func<T, bool> predicate, Func<T, T> func)
    {
        Logger.Instance.Debug("");
        Logger.Instance.Debug($" Assembly: {typeof(GenericExtensions).Assembly.GetName().Name}, v{typeof(GenericExtensions).Assembly.GetName().Version}, Namespace: {typeof(GenericExtensions).Namespace}, Class: {nameof(GenericExtensions)}");
        Logger.Instance.Debug($" Executes a function if a given predicate is true");
        Logger.Instance.Debug($" > Signature: ({typeof(T)}) If<{typeof(T)}>(this {typeof(T)}, {typeof(Func<T, bool>)}, {typeof(Func<T, T>)})");
        Logger.Instance.Debug($"   > val: {val}");
        Logger.Instance.Debug($"   > predicate: {predicate}");
        Logger.Instance.Debug($"   > func: {func}");

        var isTrue = predicate(val);
        if (isTrue)
        {
            T result = func(val);
            Logger.Instance.Debug($"  > Output: {result}");

            return result;
        }

        Logger.Instance.Debug($"  > Output: {val}");
        return val;
    }

    /// <summary>
    /// Determines weather values are into list.
    /// </summary>
    /// <typeparam name="T">Type of list elements</typeparam>
    /// <param name="source">Target array.</param>
    /// <param name="values">Values to check.</param>
    /// <returns>
    /// <b>true</b> if values are into list; Otherwise, <b>false</b>.
    /// </returns>
    public static bool In<T>(this T source, params T[] values)
    {
        Logger.Instance.Debug("");
        Logger.Instance.Debug($" Assembly: {typeof(GenericExtensions).Assembly.GetName().Name}, v{typeof(GenericExtensions).Assembly.GetName().Version}, Namespace: {typeof(GenericExtensions).Namespace}, Class: {nameof(GenericExtensions)}");
        Logger.Instance.Debug($" Determines weather values are into list");
        Logger.Instance.Debug($" > Signature: ({typeof(T)}) In<{typeof(T)}>(this {typeof(T)}, {typeof(Func<T, bool>)}, {typeof(Func<T, T>)})");
        Logger.Instance.Debug($"   > source: {source}");
        Logger.Instance.Debug($"   > values: {values}");

        var result = values.ToList().Contains(source);
        Logger.Instance.Debug($"  > Output: {result}");

        return result;
    }

    /// <summary>
    /// Determines weather values are into list.
    /// </summary>
    /// <typeparam name="T">Type of list elements</typeparam>
    /// <param name="source">Target list.</param>
    /// <param name="values">Values to check.</param>
    /// <returns>
    /// <b>true</b> if values are into list; Otherwise, <b>false</b>.
    /// </returns>
    public static bool In<T>(this T source, IEnumerable<T> values) => 
        source.In(values.ToArray());

    /// <summary>
    /// 
    /// </summary>
    /// <param name="x"></param>
    /// <param name="f"></param>
    /// <typeparam name="T"></typeparam>
    /// <typeparam name="TResult"></typeparam>
    /// <returns></returns>
    public static TResult Pipe<T, TResult>(this T x, in Func<T, TResult> f) => f(x);
}
