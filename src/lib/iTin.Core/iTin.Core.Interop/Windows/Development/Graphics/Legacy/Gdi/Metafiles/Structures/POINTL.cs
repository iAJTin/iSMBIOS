using System;
using System.Diagnostics.CodeAnalysis;
using System.Drawing;
using System.Globalization;
using System.Runtime.InteropServices;

namespace iTin.Core.Interop.Windows.Development.Graphics.Legacy.Gdi.Metafiles
{
    /// <summary>
    /// La estructura <strong>POINTL</strong> contiene las coordenadas de un punto.
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    [SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", MessageId = "POINTL")]
    public struct POINTL : IEquatable<POINTL>
    {
        #region Atributos
        /// <summary>
        /// Coordenada X del punto.
        /// </summary>
        [SuppressMessage("Microsoft.Design", "CA1051:DoNotDeclareVisibleInstanceFields")]
        [SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "X")]
        public int X;

        /// <summary>
        /// Coordenada Y del punto.
        /// </summary>
        [SuppressMessage("Microsoft.Design", "CA1051:DoNotDeclareVisibleInstanceFields")]
        [SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Y")]
        public int Y;
        #endregion

        #region Constructor/es

            #region [public] POINTL(int, int): Inicializa una nueva instancia de la estructura.
            /// <summary>
            /// Inicializa una nueva instancia de la estructura <see cref="POINTL"/>.
            /// </summary>
            /// <param name="x">Coordenada X del punto.</param>
            /// <param name="y">Coordenada Y del punto.</param>
            [SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "x")]
            [SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "y")]
            public POINTL(int x, int y)
            {
                X = x;
                Y = y;
            }
            #endregion

        #endregion

        #region Interfaces

            #region [public] (bool) Equals(POINTL): Indica si el objeto actual es igual a otro objeto del mismo tipo.
            /// <summary>
            /// Indica si el objeto actual es igual a otro objeto del mismo tipo.
            /// </summary>
            /// <param name="other">Objeto que se va a comparar con este objeto.</param>
            /// <returns>Devuelve <b>true</b> si el objeto actual es igual al parámetro <c>other</c>; en caso contrario, <b>false</b>.</returns>
            public bool Equals(POINTL other)
            {
                return other.Equals((object)this);
            }
            #endregion

        #endregion

        #region Overrides

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
                return X ^ Y;
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

                if (!(obj is POINTL))
                    return false;

                POINTL other = (POINTL)obj;
                return (other.X == X) && (other.Y == Y);
            }
            #endregion

            #region [public] {override} (string) ToString(): Devuelve una cadena que representa al objeto actual.
            /// <summary>
            /// Devuelve una cadena que representa al objeto <see cref="POINTL"/> actual.
            /// </summary>
            /// <returns>
            ///   <para>Tipo: <see cref="T:System.String"/></para>
            ///   <para>Cadena que representa al objeto <see cref="POINTL"/> actual.</para>
            /// </returns>
            /// <remarks>
            /// El método <see cref="POINTL.ToString()"/> devuelve una cadena que incluye el tipo de estructura.
            /// </remarks>        
            public override string ToString()
            {
                return string.Format(CultureInfo.InvariantCulture, "X = {0}, Y = {1}", X, Y);
            }
            #endregion

        #endregion

        #region Operadores

            #region Implicit

                #region [public] {static} (implicit operator) Point(POINTL): Realiza una conversión implícita del tipo POINTL al tipo Point.
                /// <summary>
                /// Realiza una conversión implícita del tipo <see cref="POINTL"/> al tipo <see cref="System.Drawing.Point"/>.
                /// </summary>
                /// <param name="point">Estructura a convertir.</param>
                /// <returns>Estructura convertida.</returns>
                public static implicit operator Point(POINTL point)
                {
                    return new Point(point.X, point.Y);
                }
                #endregion

                #region [public] {static} (implicit operator) POINTL(Point): Realiza una conversión implícita del tipo Point al tipo POINTL.
                /// <summary>
                /// Realiza una conversión implícita del tipo <see cref="System.Drawing.Point"/> al tipo <see cref="POINTL"/>.
                /// </summary>
                /// <param name="point">Estructura a convertir.</param>
                /// <returns>Estructura convertida.</returns>
                public static implicit operator POINTL(Point point)
                {
                    return new POINTL(point.X, point.Y);
                }
                #endregion

            #endregion

            #region Comparación

                #region [public] {static} (bool) operator ==(POINTL, POINTL): Implementa el operador de igualdad (==).
                /// <summary>
                /// Implementa el operador de igualdad (==).
                /// </summary>
                /// <param name="deviceInfo1">Operando 1.</param>
                /// <param name="deviceInfo2">Operando 2.</param>
                /// <returns>Devuelve <b>true</b> si <c>deviceInfo1</c> es igual a <c>deviceInfo2</c>; <b>false</b> en caso contrario.</returns>
                public static bool operator ==(POINTL deviceInfo1, POINTL deviceInfo2)
                {
                    return deviceInfo1.Equals(deviceInfo2);
                }
                #endregion

                #region [public] {static} (bool) operator !=(POINTL, POINTL): Implementa el operador de desigualdad (!=).
                /// <summary>
                /// Implementa el operador de desigualdad (!=).
                /// </summary>
                /// <param name="deviceInfo1">Operando 1.</param>
                /// <param name="deviceInfo2">Operando 2.</param>
                /// <returns>Devuelve <b>true</b> si <c>deviceInfo1</c> no es igual a <c>deviceInfo2</c>; <b>false</b> en caso contrario.</returns>
                public static bool operator !=(POINTL deviceInfo1, POINTL deviceInfo2)
                {
                    return !deviceInfo1.Equals(deviceInfo2);
                }
                #endregion

            #endregion

        #endregion
    }
}