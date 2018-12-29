
namespace iTin.Core
{
    /// <summary>
    /// Static class than contains extension methods for objects of type <see cref="T:System.String" />.
    /// </summary> 
    public static class StringExtensions
    {
		/// <summary>
		/// Devuelve una cadena que contiene un número especificado de caracteres a partir del lado izquierdo de una cadena.
		/// </summary>
		/// <param name="str">Expresión de tipo <see cref="T:System.String"/> de la que se devuelven los caracteres que están más a la izquierda.</param>
		/// <param name="length">Expresión númerica de tipo <see cref="T:System.Int32"/> que indica cuántos caracteres se van a devolver.</param>
		/// <returns>
		/// 	<para>Tipo: <see cref="T:System.String"/></para>
		/// 	<para><see cref="T:System.String"/> con el resultado.</para>
		/// </returns>
		public static string Left(this string str, int length)
		{
			return string.IsNullOrEmpty(str) ? str : str.Substring(0, length);
		}

		/// <summary>
		/// Devuelve una cadena que contiene un número especificado de caracteres a partir del lado derecho de una cadena.
		/// </summary>
		/// <param name="str">Expresión de tipo <see cref="T:System.String"/> de la que se devuelven los caracteres que están más a la derecha.</param>
		/// <param name="length">Expresión númerica de tipo <see cref="T:System.Int32"/> que indica cuántos caracteres se van a devolver.</param>
		/// <returns>
		/// 	<para>Tipo: <see cref="T:System.String"/></para>
		/// 	<para><see cref="T:System.String"/> con el resultado.</para>
		/// </returns>
		public static string Right(this string str, int length)
		{
			return string.IsNullOrEmpty(str) ? str : str.Substring(str.Length - length, length);
		}

		/// <summary>
		/// Devuelve una cadena que contiene un número especificado de caracteres a partir de la posición especificada.
		/// </summary>
		/// <param name="str">Nombre de la variable <see cref="T:System.String"/> que se va a modificar.</param>
		/// <param name="start">Posición del carácter donde se inicia la extracción.</param>
		/// <param name="length">Número de caracteres que se van a extraer.</param>
		/// <returns>
		/// 	<para>Tipo: <see cref="T:System.String"/></para>
		/// 	<para><see cref="T:System.String"/> con el resultado.</para>
		/// </returns>
		public static string Mid(this string str, int start, int length)
		{
			return string.IsNullOrEmpty(str) ? str : str.Substring(start, length);
		}
	}
}
