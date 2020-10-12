
namespace iTin.Core
{
    using System;
    using System.Runtime.InteropServices;
    using System.Security;

    using Logging;

    /// <summary>
    /// Static class than contains extension methods for objects of type <see cref="T:System.Security.SecureString" />.
    /// </summary>
    public static class SecureStringExtensions
    {
        /// <summary>
        /// Determines whether input secure string is disposed.
        /// </summary>
        /// <param name="target">Input secure string.</param>
        /// <returns>
        /// <b>true</b> if input secure string is disposed; Otherwise <b>false</b>.
        /// </returns>
        public static bool Disposed(this SecureString target)
        {
            Logger.Instance.Debug("");
            Logger.Instance.Debug(" Assembly: iTin.Core, Namespace: iTin.Core, Class: SecureStringExtensions");
            Logger.Instance.Debug(" Determines whether input secure string is disposed");
            Logger.Instance.Debug($" > Signature: ({typeof(bool)}) Disposed(this {typeof(SecureString)})");
            Logger.Instance.Debug($"   > target: {target}");

            bool disposed = false;

            try
            {
                var test = target.Length;
            }
            catch (ObjectDisposedException)
            {
                disposed = true;
            }

            Logger.Instance.Debug($" > Output: {disposed}");

            return disposed;
        }

        /// <summary>
        /// Returns the value stored in the specified secure string
        /// </summary>
        /// <param name="target">Input secure string.</param>
        /// <returns>
        /// A <see cref="T:System.String"/> which contains stored value into secure string.
        /// </returns>
        public static string Value(this SecureString target)
        {
            Logger.Instance.Debug("");
            Logger.Instance.Debug(" Assembly: iTin.Core, Namespace: iTin.Core, Class: SecureStringExtensions");
            Logger.Instance.Debug(" Returns the value stored in the specified secure string");
            Logger.Instance.Debug($" > Signature: ({typeof(string)}) Value(this {typeof(SecureString)})");
            Logger.Instance.Debug($"   > target: {target}");

            bool disposed = target.Disposed();
            if (disposed)
            {
                return null;
            }

            IntPtr pointerToTarget = Marshal.SecureStringToBSTR(target);
            string text = Marshal.PtrToStringBSTR(pointerToTarget);
            Marshal.FreeBSTR(pointerToTarget);

            Logger.Instance.Debug($" > Output: {text}");

            return text;
        }
    }
}
