
namespace iTin.Core.Helpers
{
    using System.Diagnostics.CodeAnalysis;
    using System.IO;

    using Logging;

    /// <summary> 
    /// Static class than contains methods for manipulating objects of type <see cref="T:System.IO.Stream" />.
    /// </summary>
    public static class StreamHelper
    {
        /// <summary>
        /// Returns the specified file as a byte array.
        /// </summary>
        /// <param name="fileName">File to convert.</param>
        /// <returns>
        /// Array of byte than represent the file.
        /// </returns>
        public static byte[] AsByteArrayFromFile(string fileName)
        {
            Logger.Instance.Debug("External Call");
            Logger.Instance.Info("  Returns the specified file as a byte array");
            Logger.Instance.Info("  > Library: iTin.Core");
            Logger.Instance.Info("  > Class: StreamHelper");
            Logger.Instance.Info("  > Method: AsByteArrayFromFile(string)");
            Logger.Instance.Info("  > Output: System.Byte[]");

            SentinelHelper.IsTrue(string.IsNullOrEmpty(fileName));

            byte[] buffer;

            using (var stream = new FileStream(fileName, FileMode.Open, FileAccess.Read, FileShare.Read))
            {
                buffer = stream.AsByteArray();
            }

            return buffer;
        }

        /// <summary>
        /// Convert input file to memory stream.
        /// </summary>
        /// <param name="fileName">File to convert.</param>
        /// <returns>
        /// A <see cref="T:System.IO.MemoryStream" /> than represent the input file.
        /// </returns>
        [SuppressMessage("Microsoft.Reliability", "CA2000:Eliminar (Dispose) objetos antes de perder el ámbito")]
        public static MemoryStream AsMemoryStreamFromFile(string fileName)
        {
            Logger.Instance.Debug("External Call");
            Logger.Instance.Info("  Convert input file to memory stream");
            Logger.Instance.Info("  > Library: iTin.Core");
            Logger.Instance.Info("  > Class: StreamHelper");
            Logger.Instance.Info("  > Method: AsMemoryStreamFromFile(string)");
            Logger.Instance.Info("  > Output: System.IO.MemoryStream");

            SentinelHelper.IsTrue(string.IsNullOrEmpty(fileName));

            MemoryStream ms;
            FileStream fs = null;
            MemoryStream mstemp = null;

            try
            {
                fs = new FileStream(fileName, FileMode.Open, FileAccess.Read, FileShare.Read);
                try
                {
                    mstemp = new MemoryStream(fs.AsByteArray());
                    ms = mstemp;
                    mstemp = null;
                }
                finally
                {
                    mstemp?.Dispose();
                }
            }
            finally
            {
                fs?.Dispose();
            }

            return ms;
        }

        /// <summary>
        /// Returns specified text file as <see cref="T:System.Stream"/>.
        /// </summary>
        /// <param name="file">Target file</param>
        /// <returns>
        /// A <see cref="T:System.Stream"/> from specified filename.
        /// </returns>
        public static Stream TextFileToStream(string file)
        {
            Logger.Instance.Debug("External Call");
            Logger.Instance.Info("  Returns specified text file as System.Stream");
            Logger.Instance.Info("  > Library: iTin.Core");
            Logger.Instance.Info("  > Class: StreamHelper");
            Logger.Instance.Info("  > Method: TextFileToStream(string)");
            Logger.Instance.Info("  > Output: System.IO.Stream");

            return new MemoryStream(File.ReadAllBytes(TypeHelper.ToType<string>(file)));
        }
    }
}
