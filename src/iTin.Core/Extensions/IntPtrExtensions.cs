
namespace iTin.Core
{
    using System;
    using System.Runtime.InteropServices;

    /// <summary>
    /// Static class than contains extension methods for <see cref="T:System.IntPtr" /> type.
    /// </summary> 
    public static class IntPtrExtensions
    {
        public static byte[] ToByteArray(this IntPtr source, int startIndex, int length)
        {
            var byteArray = new Byte[length];
            Marshal.Copy(source, byteArray, startIndex, length);
            Marshal.FreeHGlobal(source);

            return byteArray;
        }
    }
}
