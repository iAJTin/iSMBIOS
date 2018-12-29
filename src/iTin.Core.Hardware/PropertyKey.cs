
namespace iTin.Core.Hardware
{
    using System;
    using System.Diagnostics;
    using System.Globalization;

    /// <summary>
    /// Defines a value that contains the detailed information of a writer.
    /// </summary>
    public struct PropertyKey : IEquatable<PropertyKey>
    {
        #region private readonly members
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private readonly Enum propertyId;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private readonly PropertyUnit propertyUnit;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private readonly Enum structureId;
        #endregion

        #region constructor/s

            #region [public] PropertyKey(Enum, Enum): Inicializa una nueva instancia de la estructura especificando la estructura y propiedad.
            /// <summary>
            /// Inicializa una nueva instancia de la estructura <see cref="PropertyKey"/> especificando la estructura y propiedad.
            /// </summary>
            /// <param name="structureId">Identificador de estructura.</param>
            /// <param name="propertyId">Identificador de propiedad.</param>
            public PropertyKey(Enum structureId, Enum propertyId) : this(structureId, propertyId, PropertyUnit.None)
            {
            }
            #endregion

            #region [public] PropertyKey(Enum, Enum, PropertyUnit): Inicializa una nueva instancia de la estructura especificando la estructura, propiedad y unidad de medida de la misma.
            /// <summary>
            /// Inicializa una nueva instancia de la estructura <see cref="PropertyKey"/> especificando la estructura, propiedad y unidad de medida de la misma.
            /// </summary>
            /// <param name="structureId">Identificador de estructura.</param>
            /// <param name="propertyId">Identificador de propiedad.</param>
            /// <param name="propertyUnit">Identificador de unidad.</param>
            public PropertyKey(Enum structureId, Enum propertyId, PropertyUnit propertyUnit)
            {
                this.propertyId = propertyId;
                this.structureId = structureId;
                this.propertyUnit = propertyUnit;
            }
            #endregion

        #endregion

        #region public properties

            #region [public] (Enum) PropertyId: Obtiene un valor que representa un campo de StructureId de la que se va a recuperar el valor.
            /// <summary>
            /// Obtiene un valor que representa un campo de <see cref="StructureId"/> de la que se va a recuperar el valor.
            /// </summary>
            /// <value>
            /// Campo de <see cref="StructureId"/> de la que se va a recuperar el valor.
            /// </value>
            /// <remarks>
            /// El valor del atributo representa el tipo del valor ligado a esta propiedad.
            /// </remarks>
            public Enum PropertyId
            {
                get { return propertyId; }
            }
            #endregion

            #region [public] (PropertyUnit) PropertyUnit: Obtiene un valor que representa la unidad en que se mide la propiedad.
            /// <summary>
            /// Obtiene un valor que representa la unidad en que se mide la propiedad.
            /// </summary>
            /// <value>
            ///   <para>Tipo: <see cref="PropertyUnit"/></para>
            ///   <para>Unidad en que se mide la propiedad.</para>
            /// </value>
            public PropertyUnit PropertyUnit
            {
                get { return propertyUnit; }
            }
            #endregion

            #region [public] (Enum) StructureId: Obtiene un valor que representa la estructura de la que se va a recuperar el valor.
            /// <summary>
            /// Obtiene un valor que representa la estructura de la que se va a recuperar el valor.
            /// </summary>
            /// <value>Estructura de la que se va a recuperar el valor.</value>
            public Enum StructureId
            {
                get { return structureId; }
            }
            #endregion

       #endregion

        #region interfaces

            #region [public] (bool) Equals(PropertyKey): Indica si el objeto actual es igual a otro objeto del mismo tipo.
            /// <summary>
            /// Indica si la estructura actual es igual a otra estructura del mismo tipo.
            /// </summary>
            /// <param name="other">Estructura que se va a comparar con esta estructura.</param>
            /// <returns>
            /// Devuelve <strong>true</strong> si la estructura actual es igual al parámetro <c>other</c>; en caso contrario, <strong>false</strong>.
            /// </returns>
            public bool Equals(PropertyKey other)
            {
                return other.Equals((object)this);
            }
            #endregion

        #endregion

        #region public override methods

            #region [public] {override} (int) GetHashCode(): Devuelve un valor que repesenta al código hash de esta estructura.
            /// <summary>
            /// Devuelve un valor que repesenta al código hash de esta estructura.
            /// </summary>
            /// <returns>
            /// 	<para>Tipo: <see cref="T:System.Int32"/></para>
            /// 	<para>Código Hash de esta estructura.</para>
            /// </returns>
            public override int GetHashCode()
            {
                return ToString().GetHashCode();
            }
            #endregion

            #region [public] {override} (bool) Equals(object obj): Devuelve un valor que indica si esta estructutra es igual a otra.
            /// <summary>
            /// Devuelve un valor que indica si esta estructutra es igual a otra.
            /// </summary>
            /// <param name="obj">Estructura con la que comparar.</param>
            /// <returns>Resultado de la comparación de igualdad.</returns>
            public override bool Equals(object obj)
            {
                if (obj == null)
                {
                    return false;
                }

                if (!(obj is PropertyKey))
                {
                    return false;
                }

                var other = (PropertyKey)obj;
                return other.GetHashCode() == GetHashCode();
            }
            #endregion

            #region [public] {override} (string) ToString(): Devuelve una cadena que representa a la estructura actual.
            /// <summary>
            /// Devuelve una cadena que representa la estructura <see cref="PropertyKey"/> actual.
            /// </summary>
            /// <returns>
            /// 	<para>Tipo: <see cref="T:System.String"/></para>
            /// 	<para>Cadena que representa la estructura <see cref="PropertyKey"/> actual.</para>
            /// </returns>
            /// <remarks>
            /// El método <see cref="PropertyKey.ToString()"/> devuelve una cadena que incluye el nombre del monitor.
            /// </remarks>
            public override string ToString()
            {
                return 
                    string.Format(
                        CultureInfo.InvariantCulture, 
                        "Structure = {0}, Property = {1}, Unit = {2}",
                        StructureId, 
                        PropertyId, 
                        PropertyUnit);
            }

        #endregion

        #endregion

        #region opertors

            #region [public] {static} (bool) operator ==(PropertyKey, PropertyKey): Implementa el operador de igualdad (==).
            /// <summary>
            /// Implementa el operador de igualdad (==).
            /// </summary>
            /// <param name="propertyKey1">Operando 1.</param>
            /// <param name="propertyKey2">Operando 2.</param>
            /// <returns>
            /// Devuelve <strong>true</strong> si <c>propertyKey1</c> es igual a <c>propertyKey2</c>; <strong>false</strong> en caso contrario.
            /// </returns>
            public static bool operator ==(PropertyKey propertyKey1, PropertyKey propertyKey2)
            {
                return propertyKey1.Equals(propertyKey2);
            }
            #endregion

            #region [public] {static} (bool) operator !=(PropertyKey, PropertyKey): Implementa el operador de desigualdad (!=).
            /// <summary>
            /// Implementa el operador de desigualdad (!=).
            /// </summary>
            /// <param name="propertyKey1">Operando 1.</param>
            /// <param name="propertyKey2">Operando 2.</param>
            /// <returns>
            /// Devuelve <strong>true</strong> si <c>propertyKey1</c> no es igual a <c>propertyKey2</c>; <strong>false</strong> en caso contrario.
            /// </returns>
            public static bool operator !=(PropertyKey propertyKey1, PropertyKey propertyKey2)
            {
                return !propertyKey1.Equals(propertyKey2);
            }
            #endregion

        #endregion
    }
}
