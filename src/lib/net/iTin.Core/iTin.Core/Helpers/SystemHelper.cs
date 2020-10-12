
namespace iTin.Core.Helpers
{
    using System.Diagnostics;
    using System.Text;
    using System.Threading;
    using System.Threading.Tasks;

    using iTin.Core.ComponentModel;
    using iTin.Core.ComponentModel.Enums;

    using NativeSystem = System;

    /// <summary>
    /// Static class than contains methods for retrieve system information.
    /// </summary>
    public static class SystemHelper
    {
        /// <summary>
        /// Gets a value that determines if the operating system is 32bit.
        /// </summary>
        /// <returns>
        /// <b>true</b> if operating system is 32bit; otherwise <b>false</b>.
        /// </returns>
        public static bool Is32BitOperatingSystem => !Is64BitOperatingSystem;

        /// <summary>
        /// Gets a value that determines if the operating system is 64bit.
        /// </summary>
        /// <returns>
        /// <b>true</b> if operating system is 64bit; otherwise <b>false</b>.
        /// </returns>
        public static bool Is64BitOperatingSystem => NativeSystem.Environment.Is64BitOperatingSystem;



        /// <summary>
        /// Runs specified program with parameters.
        /// </summary>
        /// <param name="program">Program name</param>
        /// <param name="arguments">Program arguments</param>
        /// <returns>
        /// A <see cref="string"/> with output command result.
        /// </returns>
        public static StringBuilder RunCommand(string program, string arguments)
        {
            ProcessStartInfo pi = new ProcessStartInfo(program, arguments)
            {
                CreateNoWindow = true,
                RedirectStandardOutput = true,
                UseShellExecute = false,
                WindowStyle = ProcessWindowStyle.Hidden
            };

            using (var process = Process.Start(pi))
            {
                StringBuilder builder = new StringBuilder();

                if (process == null)
                {
                    return builder;
                }

                while (!process.StandardOutput.EndOfStream)
                {
                    builder.AppendLine(process.StandardOutput.ReadLine());
                }

                return builder;
            }
        }

        /// <summary>
        /// Runs specified program with parameters.
        /// </summary>
        /// <param name="program">Program name</param>
        /// <param name="arguments">Program arguments</param>
        /// <returns>
        /// A <see cref="string"/> with output command result.
        /// </returns>
        public static StringBuilder RunCommand(WinProgram program, string arguments) => RunCommand(program.GetDescription(), arguments);

        /// <summary>
        /// Runs specified program with parameters and options.
        /// </summary>
        /// <param name="program">Program name</param>
        /// <param name="arguments">Program arguments</param>
        /// <param name="options">Run Program options</param>
        public static void RunProgram(string program, string arguments, RunProgramOptions options = null)
        {
            RunProgramOptions safeOptions = options;
            if (options == null)
            {
                safeOptions = RunProgramOptions.Default;
            }

            ProcessStartInfo startInfo = new ProcessStartInfo(program, arguments) { UseShellExecute = safeOptions.UseShellExecute };
            using (Process.Start(startInfo))
            {
            }

            if (safeOptions.SleepTime > 0)
            {
                Thread.Sleep(safeOptions.SleepTime);
            }
        }

        /// <summary>
        /// Runs specified program with parameters and options.
        /// </summary>
        /// <param name="program">Program name</param>
        /// <param name="arguments">Program arguments</param>
        /// <param name="options">Run Program options</param>
        public static void RunProgram(WinProgram program, string arguments, RunProgramOptions options = null) => RunProgram(program.GetDescription(), arguments, options ?? RunProgramOptions.Default);

        /// <summary>
        /// Runs specified program with parameters.
        /// </summary>
        /// <param name="program">Program name</param>
        /// <param name="arguments">Program arguments</param>
        /// <returns>
        /// A <see cref="string"/> with output command result.
        /// </returns>
        public static async Task<StringBuilder> RunCommandAsync(string program, string arguments)
        {
            var tcs = new TaskCompletionSource<int>();
            StringBuilder builder = new StringBuilder();

            ProcessStartInfo pi = new ProcessStartInfo(program, arguments)
            {
                CreateNoWindow = true,
                RedirectStandardOutput = true,
                UseShellExecute = false,
                WindowStyle = ProcessWindowStyle.Hidden
            };

            var process = new Process
            {
                StartInfo = pi,
                EnableRaisingEvents = true
            };

            process.Exited += (sender, args) =>
            {
                tcs.SetResult(process.ExitCode);
                process.Dispose();
            };


            process.Start();
            while (!process.StandardOutput.EndOfStream)
            {
                builder.AppendLine(process.StandardOutput.ReadLine());
            }

            return await Task.FromResult(builder);
        }
    }
}
