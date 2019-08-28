
namespace iTin.Core.Interop.Windows.Development.Graphics.Legacy.Gdi.Rectangles
{
    using System.Runtime.InteropServices;

    /// <summary>
    /// Funciones que se pueden utilizar para controlar la configuración de parámetros del sistema y los diversos atributos del sistema, como el tiempo del doble clic,
    /// el tiempo de espera del protector de pantalla, el ancho del borde de las ventanas.
    /// </summary>
    internal static class NativeMethods
    {
        /// <summary>
        /// Determina si el rectángulo especificado está vacío.
        /// Para más información, ver http://msdn.microsoft.com/en-us/library/dd145017%28v=VS.85%29.aspx.
        /// </summary>
        [DllImport(ExternDll.Win.User32, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool IsRectEmpty([In] ref RECT lprc);
    }
}
