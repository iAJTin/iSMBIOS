
namespace iTin.Core
{
    using System;
    using System.Runtime.InteropServices;

    /// <summary>
    /// Static class than contains extension methods for <see cref="T:System.IntPtr" /> type.
    /// </summary> 
    public static class IntPtrExtensions
    {
        /// <summary>
        /// Converts specified <see cref="IntPtr"/> to byte array reference.
        /// </summary>
        /// <param name="source">Target pointer</param>
        /// <param name="startIndex">Index</param>
        /// <param name="length">Lenght</param>
        /// <returns>
        /// A byte array reference.
        /// </returns>
        public static byte[] ToByteArray(this IntPtr source, int startIndex, int length)
        {
            var byteArray = new byte[length];
            Marshal.Copy(source, byteArray, startIndex, length);
            Marshal.FreeHGlobal(source);

            return byteArray;
        }
    }
}
