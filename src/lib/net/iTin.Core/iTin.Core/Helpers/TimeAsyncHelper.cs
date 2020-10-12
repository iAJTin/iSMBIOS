
namespace iTin.Core.Helpers
{
    using System;
    using System.Threading.Tasks;

    using Logging;

    /// <summary>
    /// Static class than contains methods for manipulating asynchronously generic time values.
    /// </summary>
    public static class TimeAsyncHelper
    {
        /// <summary>
        /// Make a wait asynchronously and then execute the specified action.
        /// </summary>
        /// <param name="delay">Wait time</param>
        /// <param name="action">Action to execute</param>
        /// <returns>
        /// A new <see cref="T:System.Threading.Tasks.Task"/> when the action ends.
        /// </returns>
        public static async Task DelayActionAsync(int delay, Action action)
        {
            Logger.Instance.Debug("");
            Logger.Instance.Debug(" Assembly: iTin.Core, Namespace: iTin.Core, Class: TimeAsyncHelper");
            Logger.Instance.Debug($" Make a wait asynchronously and then execute the specified action");
            Logger.Instance.Debug($" > Signature: ({typeof(Task)}) DelayActionAsync({typeof(int)}, {typeof(Action)})");
            Logger.Instance.Debug($"   > delay: {delay}");

            Logger.Instance.Debug($"  > Output:");
            Logger.Instance.Debug($"    > Intit Delay...");
            await Task.Delay(delay);
            Logger.Instance.Debug($"    > End Delay");

            Logger.Instance.Debug($"    > Intit Action...");
            action();
            Logger.Instance.Debug($"    > End Action");
        }
    }
}
