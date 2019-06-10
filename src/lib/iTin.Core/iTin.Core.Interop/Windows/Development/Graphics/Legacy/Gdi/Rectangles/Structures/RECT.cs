using System;
using System.Diagnostics.CodeAnalysis;
using System.Drawing;
using System.Globalization;
using System.Runtime.InteropServices;

namespace iTin.Core.Interop.Windows.Development.Graphics.Legacy.Gdi.Rectangles
{
    /// <summary>
    /// La estructura <Strong>RECT</Strong> define las coordenadas de las esquinas superior izquierda e inferior derecha de un rectángulo.
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    [SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", MessageId = "RECT")]
    internal struct RECT : IEquatable<RECT>
    {
        #region Atributos.
        /// <summary>
        /// Coordenada X de la esquina superior izquierda del rectángulo.
        /// </summary>
        [SuppressMessage("Microsoft.Design", "CA1051:DoNotDeclareVisibleInstanceFields")]
        public int Left;

        /// <summary>
        /// Coordenada Y de la esquina superior izquierda del rectángulo.
        /// </summary>
        [SuppressMessage("Microsoft.Design", "CA1051:DoNotDeclareVisibleInstanceFields")]
        public int Top;

        /// <summary>
        /// Coordenada X de la esquina inferior derecha del rectángulo.
        /// </summary>
        [SuppressMessage("Microsoft.Design", "CA1051:DoNotDeclareVisibleInstanceFields")]
        public int Right;

        /// <summary>
        /// Coordenada Y de la esquina inferior derecha del rectángulo.
        /// </summary>
        [SuppressMessage("Microsoft.Design", "CA1051:DoNotDeclareVisibleInstanceFields")]
        public int Bottom;
        #endregion

        #region Constructor/es.

            #region [public] REC(int, int, int, int): Inicializa una nueva instancia de la estructura.
            /// <summary>
            /// Inicializa una nueva instancia de la estructura <see cref="RECT"/>.
            /// </summary>
            /// <param name="left">Coordenada X de la esquina superior izquierda del rectángulo.</param>
            /// <param name="top">Coordenada Y de la esquina superior izquierda del rectángulo.</param>
            /// <param name="right">Coordenada X de la esquina inferior derecha del rectángulo.</param>
            /// <param name="bottom">Coordenada Y de la esquina inferior derecha del rectángulo.</param>
            public RECT(int left, int top, int right, int bottom)
            {
                Left = left;
                Top = top;
                Right = right;
                Bottom = bottom;
            }
            #endregion

        #endregion

        #region Interfaces.

            #region [public] (bool) Equals(RECT): Indica si el objeto actual es igual a otro objeto del mismo tipo.
            /// <summary>
            /// Indica si el objeto actual es igual a otro objeto del mismo tipo.
            /// </summary>
            /// <param name="other">Objeto que se va a comparar con este objeto.</param>
            /// <returns>Devuelve <b>true</b> si el objeto actual es igual al parámetro <c>other</c>; en caso contrario, <b>false</b>.</returns>
            public bool Equals(RECT other)
            {
                return other.Equals((object)this);
            }
            #endregion

        #endregion

        #region Overrides.

            #region [public] {override} (int) GetHashCode(): Devuelve el código hash del objeto.
            /// <summary>
            /// Devuelve el código hash del objeto.
            /// </summary>
            /// <returns>
            /// 	<para>Tipo: <see cref="T:System.Int32"/></para>
            /// 	<para>Código Hash.</para>
            /// </returns>
            public override int GetHashCode()
            {
                return Left ^ Top ^ Right ^ Bottom;
            }
            #endregion

            #region [public] {override} (bool) Equals(object obj): Devuelve un valor que indica si este objeto es igual a otro.
            /// <summary>
            /// Devuelve un valor que indica si este objeto es igual a otro.
            /// </summary>
            /// <param name="obj">Objeto con el que comparar.</param>
            /// <returns>Resultado de igualdad.</returns>
            public override bool Equals(object obj)
            {
                if (obj == null)
                    return false;

                if (!(obj is RECT))
                    return false;

                RECT other = (RECT)obj;
                return (other.Left == Left) && (other.Top == Top) && (other.Right == Right) && (other.Bottom == Bottom);
            }
            #endregion

            #region [public] {override} (string) ToString(): Devuelve una cadena que representa al objeto actual.
            /// <summary>
            /// Devuelve una cadena que representa al objeto <see cref="RECT"/> actual.
            /// </summary>
            /// <returns>
            ///   <para>Tipo: <see cref="T:System.String"/></para>
            ///   <para>Cadena que representa al objeto <see cref="RECT"/> actual.</para>
            /// </returns>
            /// <remarks>
            /// El método <see cref="RECT.ToString()"/> devuelve una cadena que incluye el tipo de estructura.
            /// </remarks>        
            public override string ToString()
            {
                return string.Format(CultureInfo.InvariantCulture, "Left = {0}, Top = {1}, Right = {2}, Bottom = {3}", Left, Top, Right, Bottom);
            }
            #endregion

        #endregion

        #region Operadores.

            #region Implicit

                #region [public] {static} (implicit operator) Rectangle(RECT): Realiza una conversión implícita del tipo RECT al tipo Rectangle.
                /// <summary>
                /// Realiza una conversión implícita del tipo <see cref="RECT"/> al tipo <see cref="System.Drawing.Rectangle"/>.
                /// </summary>
                /// <param name="rect">Estructura a convertir.</param>
                /// <returns>Estructura convertida.</returns>
                public static implicit operator Rectangle(RECT rect)
                {
                    return new Rectangle(rect.Left, rect.Top, rect.Right - rect.Left, rect.Bottom - rect.Top);
                }    
                #endregion

                #region [public] {static} (implicit operator) RECT(Rectangle): Realiza una conversión implícita del tipo Rectangle al tipo RECT.
                /// <summary>
                /// Realiza una conversión implícita del tipo <see cref="System.Drawing.Rectangle"/> al tipo <see cref="RECT"/>.
                /// </summary>
                /// <param name="rect">Estructura a convertir.</param>
                /// <returns>Estructura convertida.</returns>
                public static implicit operator RECT(Rectangle rect)
                {
                    return new RECT(rect.X, rect.Y, rect.Right - rect.Left, rect.Bottom - rect.Top);
                }
                #endregion

            #endregion

            #region Comparación.

                #region [public] {static} (bool) operator ==(RECT, RECT): Implementa el operador de igualdad (==).
                /// <summary>
                /// Implementa el operador de igualdad (==).
                /// </summary>
                /// <param name="deviceInfo1">Operando 1.</param>
                /// <param name="deviceInfo2">Operando 2.</param>
                /// <returns>Devuelve <b>true</b> si <c>deviceInfo1</c> es igual a <c>deviceInfo2</c>; <b>false</b> en caso contrario.</returns>
                public static bool operator ==(RECT deviceInfo1, RECT deviceInfo2)
                {
                    return deviceInfo1.Equals(deviceInfo2);
                }
                #endregion

                #region [public] {static} (bool) operator !=(RECT, RECT): Implementa el operador de desigualdad (!=).
                /// <summary>
                /// Implementa el operador de desigualdad (!=).
                /// </summary>
                /// <param name="deviceInfo1">Operando 1.</param>
                /// <param name="deviceInfo2">Operando 2.</param>
                /// <returns>Devuelve <b>true</b> si <c>deviceInfo1</c> no es igual a <c>deviceInfo2</c>; <b>false</b> en caso contrario.</returns>
                public static bool operator !=(RECT deviceInfo1, RECT deviceInfo2)
                {
                    return !deviceInfo1.Equals(deviceInfo2);
                }
                #endregion

            #endregion

        #endregion
    }
}