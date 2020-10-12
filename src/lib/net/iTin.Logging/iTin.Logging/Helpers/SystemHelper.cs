
namespace iTin.Logging
{
    using System.Diagnostics;
    using System.Threading;

    /// <summary>
    /// Static class than contains methods for retrieve system information.
    /// </summary>
    public static class SystemHelper
    {
        /// <summary>
        /// Runs specified program with parameters and options.
        /// </summary>
        /// <param name="program">Program name</param>
        /// <param name="arguments">Program arguments</param>
        public static void RunProgram(string program, string arguments)
        {
            ProcessStartInfo startInfo = new ProcessStartInfo(program, arguments) { UseShellExecute = true };
            using (Process.Start(startInfo))
            {
            }

            Thread.Sleep(1000);
        }
    }
}
