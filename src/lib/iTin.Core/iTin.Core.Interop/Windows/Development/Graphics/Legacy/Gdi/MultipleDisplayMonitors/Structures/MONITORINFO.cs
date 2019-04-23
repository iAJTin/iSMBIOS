using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.InteropServices;

using iTin.Core.Interop.Windows.Development.Graphics.Legacy.Gdi.Rectangles;

namespace iTin.Core.Interop.Windows.Development.Graphics.Legacy.Gdi.MultipleDisplayMonitors
{
    /// <summary>
    /// La estructura <strongs>MONITORINFO</strongs> contiene información acerca de un monitor.
    /// La estructura <strongs>MONITORINFO</strongs> es un subconjunto de la estructura <see cref="MONITORINFOEX"/>. La estructura <see cref="MONITORINFOEX"/> agrega un miembro que contiene el nombre para el monitor.
    /// Para más información, ver http://msdn.microsoft.com/es-es/library/dd145065.
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    internal struct MONITORINFO : IEquatable<MONITORINFO>
    {
        #region Atributos.
        /// <summary>
        /// Especifica el tamaño, en bytes, de la estructura <strong>MONITORINFO</strong>.
        /// Se debe inicializar antes de llamar a una función <strong>Api</strong>.
        /// </summary>
        public int Size;

        /// <summary>
        /// Una estructura <see cref="RECT"/> que especifica el rectángulo del área total del monitor.
        /// </summary>
        public RECT Monitor;

        /// <summary>
        /// Una estructura <see cref="RECT"/> que especifica el rectángulo del área de trabajo del monitor útil 
        /// que puede ser utilizado por las aplicaciones, expresada en coordenadas de pantalla virtual.
        /// Windows utiliza este rectángulo para maximizar una aplicación en el monitor.
        /// Se excluye barras de herramientas, de estado, etc.
        /// </summary>
        public RECT WorkArea;

        /// <summary>
        /// Atributos del monitor.
        /// </summary>
        public uint Flags;
        #endregion

        #region Interfaces.

            #region [public] (bool) Equals(MONITORINFO): Indica si el objeto actual es igual a otro objeto del mismo tipo.
            /// <summary>
            /// Indica si el objeto actual es igual a otro objeto del mismo tipo.
            /// </summary>
            /// <param name="other">Objeto que se va a comparar con este objeto.</param>
            /// <returns>Devuelve <b>true</b> si el objeto actual es igual al parámetro <c>other</c>; en caso contrario, <b>false</b>.</returns>
            public bool Equals(MONITORINFO other)
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
                return WorkArea.GetHashCode() ^ (int)Flags;
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

                if (!(obj is MONITORINFO))
                    return false;

                MONITORINFO other = (MONITORINFO)obj;
                return (other.WorkArea == WorkArea) && (other.Monitor == Monitor) && (other.Flags == Flags);
            }
            #endregion

            #region [public] {override} (string) ToString(): Devuelve una cadena que representa al objeto actual.
            /// <summary>
            /// Devuelve una cadena que representa al objeto <see cref="MONITORINFO"/> actual.
            /// </summary>
            /// <returns>
            ///   <para>Tipo: <see cref="T:System.String"/></para>
            ///   <para>Cadena que representa al objeto <see cref="MONITORINFO"/> actual.</para>
            /// </returns>
            /// <remarks>
            /// El método <see cref="MONITORINFO.ToString()"/> devuelve una cadena que incluye el tipo de estructura.
            /// </remarks>        
            public override string ToString()
            {
                return WorkArea.ToString();
            }
            #endregion

        #endregion

        #region Operadores.

            #region [public] {static} (bool) operator ==(MONITORINFO, MONITORINFO): Implementa el operador de igualdad (==).
            /// <summary>
            /// Implementa el operador de igualdad (==).
            /// </summary>
            /// <param name="deviceInfo1">Operando 1.</param>
            /// <param name="deviceInfo2">Operando 2.</param>
            /// <returns>Devuelve <b>true</b> si <c>deviceInfo1</c> es igual a <c>deviceInfo2</c>; <b>false</b> en caso contrario.</returns>
            public static bool operator ==(MONITORINFO deviceInfo1, MONITORINFO deviceInfo2)
            {
                return deviceInfo1.Equals(deviceInfo2);
            }
            #endregion

            #region [public] {static} (bool) operator !=(MONITORINFO, MONITORINFO): Implementa el operador de desigualdad (!=).
            /// <summary>
            /// Implementa el operador de desigualdad (!=).
            /// </summary>
            /// <param name="deviceInfo1">Operando 1.</param>
            /// <param name="deviceInfo2">Operando 2.</param>
            /// <returns>Devuelve <b>true</b> si <c>deviceInfo1</c> no es igual a <c>deviceInfo2</c>; <b>false</b> en caso contrario.</returns>
            public static bool operator !=(MONITORINFO deviceInfo1, MONITORINFO deviceInfo2)
            {
                return !deviceInfo1.Equals(deviceInfo2);
            }
            #endregion

        #endregion

        #region Miembros privados.

            #region Métodos.

                #region [private] (void) Init(): Inicializar internamente la estructura, llamar siempre antes de usar en una llamada API.
                /// <summary>
                /// Inicializar internamente la estructura, llamar <strong>siempre</strong> antes de usar en una llamada API.
                /// </summary>
                [SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
                private void Init()
                {
                    Size = Marshal.SizeOf(this);
                }
                #endregion

            #endregion

        #endregion    

        #region Miembros estáticos

            #region [public] {static} (MONITORINFO) Create: Crea una instancia nueva de esta estructura.
            /// <summary>
            /// Crea una instancia nueva de esta estructura.
            /// </summary>
            /// <value>Nueva instancia de la estructura.</value>
            [SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
            public static MONITORINFO Create
            {
                get
                {
                    MONITORINFO instance = new MONITORINFO();
                    instance.Init();

                    return instance;
                }
            }
            #endregion

        #endregion
    }
}