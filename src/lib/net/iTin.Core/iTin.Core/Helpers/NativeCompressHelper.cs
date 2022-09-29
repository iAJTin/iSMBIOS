
using System;
using System.IO;
using System.IO.Compression;
using System.Text;

using iTin.Logging;

namespace iTin.Core.Helpers
{
    /// <summary>
    /// Static class which contains methods for works with compress/decompress.
    /// </summary>
    public static class NativeCompressHelper
    {
        /// <summary>
        /// Compress the specified text.
        /// </summary>
        /// <param name="text">Target text.</param>
        /// <returns>
        /// A <see cref="T:System.String" /> taht contains compress information. 
        /// </returns>
        public static string Compress(string text)
        {
            Logger.Instance.Debug("External Call");
            Logger.Instance.Info("  Compress the specified text");
            Logger.Instance.Info("  > Library: iTin.Core");
            Logger.Instance.Info("  > Class: NativeCompressHelper");
            Logger.Instance.Info("  > Method: Compress(string)");
            Logger.Instance.Info("  > Output: System.String");

            if (text == string.Empty)
            {
                return text;
            }

            var buffer = Encoding.UTF8.GetBytes(text);
            var ms = new MemoryStream();
            using (var zip = new GZipStream(ms, CompressionMode.Compress, true))
            {
                zip.Write(buffer, 0, buffer.Length);
            }

            ms.Position = 0; 

            var compressed = new byte[ms.Length];
            ms.Read(compressed, 0, compressed.Length);

            var gzBuffer = new byte[compressed.Length + 4];
            Buffer.BlockCopy(compressed, 0, gzBuffer, 4, compressed.Length);
            Buffer.BlockCopy(BitConverter.GetBytes(buffer.Length), 0, gzBuffer, 0, 4);
            return Convert.ToBase64String(gzBuffer);
        }

        /// <summary>
        /// Decompress the specified compressed text.
        /// </summary>
        /// <param name="compressedText">The compress text.</param>
        /// <returns>
        /// A <see cref="T:System.String" /> taht contains decompress information. 
        /// </returns>
        public static string Decompress(string compressedText)
        {
            Logger.Instance.Debug("External Call");
            Logger.Instance.Info("  Decompress the specified compressed text");
            Logger.Instance.Info("  > Library: iTin.Core");
            Logger.Instance.Info("  > Class: NativeCompressHelper");
            Logger.Instance.Info("  > Method: Decompress(string)");
            Logger.Instance.Info("  > Output: System.String");

            if (compressedText == string.Empty)
            {
                return compressedText;
            }

            MemoryStream ms = null;

            try
            {
                byte[] gzBuffer = Convert.FromBase64String(compressedText);
                int msgLength = BitConverter.ToInt32(gzBuffer, 0);
                byte[] buffer = new byte[msgLength];

                ms = new MemoryStream();
                ms.Write(gzBuffer, 4, gzBuffer.Length - 4);
                ms.Position = 0;

                using (GZipStream zip = new GZipStream(ms, CompressionMode.Decompress))
                {
                    ms = null;

                    zip.Read(buffer, 0, buffer.Length);
                }

                return Encoding.UTF8.GetString(buffer);
            }
            finally
            {
                if (ms != null)
                {
                    ms.Dispose();
                }
            }
        }
    }
}
