
using System;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

using iTin.Logging;

namespace iTin.Core.Helpers
{
    /// <summary> 
    /// Static class than contains methods for cloning objects.
    /// </summary>
    public static class CopierHelper
    {
        /// <summary>
        /// Deeps the copy 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="source">The source.</param>
        /// <returns></returns>
        /// <exception cref="ArgumentException">El tipo de dato debe ser serializable.</exception>
        public static T DeepCopy<T>(T source)
        {
            Logger.Instance.Debug("External Call");
            Logger.Instance.Info("  Deeps the copy");
            Logger.Instance.Info("  > Library: iTin.Core");
            Logger.Instance.Info("  > Class: CommonHelper");
            Logger.Instance.Info("  > Method: DeepCopy<T>(T)");
            Logger.Instance.Info("  > Output: T");

            // Verificamos que sea serializable antes de hacer la copia
            if (!typeof(T).IsSerializable)
            {
                var ex = new ArgumentException(@"El tipo de dato debe ser serializable.", nameof(source));

                Logger.Instance.Error("Tipo no serializable", ex);

                throw new ArgumentException(@"El tipo de dato debe ser serializable.", nameof(source));
            }

            if (source == null)
            {
                return default;
            }

            // Creamos un stream en memoria
            IFormatter formatter = new BinaryFormatter();
            using (var stream = new MemoryStream())
            {
                formatter.Serialize(stream, source);
                stream.Seek(0, SeekOrigin.Begin);

                // Deserializamos la porcón de memoria en el nuevo objeto
                return (T)formatter.Deserialize(stream);
            }
        }
    }
}
