
using System;
using System.Threading.Tasks;

namespace iTin.Core.Helpers
{
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
            await Task.Delay(delay);
            action();
        }
    }
}
