
namespace iTin.Core.Hardware.Device.DeviceProperty
{
    using System;
    using System.Linq;
    using System.Linq.Expressions;
    using System.Reflection;

    /// <summary>
    /// Factoria para la creación de objetos fuertemente tipados de tipo <strong>DeviceProperty</strong>.
    /// </summary>
    internal static class DevicePropertyFactory
    {
        #region [public] {static} (IDeviceProperty) CreateTypedDeviceProperty(PropertyKey, object): Obtiene una referencia a un objeto que implementa la interfaz IDeviceProperty, representa el valor fuertemente tipado de la propiedad.
        /// <summary>
        /// Obtiene una referencia a un objeto que implementa la interfaz IDeviceProperty, representa el valor fuertemente tipado de la propiedad.
        /// </summary>
        /// <param name="key">Clave de la propiedad.</param>
        /// <param name="value">Valor de la propiedad.</param>
        /// <returns>
        /// Referencia al objeto que representa el valor fuertemente tipado de la propiedad.
        /// </returns>
        public static IDeviceProperty CreateTypedDeviceProperty(PropertyKey key, object value)
        {
            DevicePropertyDescription description = DevicePropertyDescriptionsCache.Cache.GetPropertyDescription(key);
            Type propertyTypeValue = description.ValueType;
            Type type = typeof(DeviceProperty<>).MakeGenericType(propertyTypeValue);

            Type[] argTypes = { typeof(PropertyKey), typeof(DevicePropertyDescription), propertyTypeValue };
            Func<PropertyKey, DevicePropertyDescription, object, IDeviceProperty> ctor = ExpressConstructor(type, argTypes);

            return ctor(key, description, value);
        }
        #endregion

        #region [private] {static} (Func<PropertyKey, DevicePropertyDescription, object, IDeviceProperty>) ExpressConstructor(Type, Type[]): Crea una expresión para el constructor específico del tipo dado.
        /// <summary>
        /// Crea una expresión para el constructor específico del tipo dado.
        /// </summary>
        /// <param name="type">Tipo que representa la clase de la que se crea la expresión.</param>
        /// <param name="argTypes">Array de tipos que representan los tipos esperados por el constructor.</param>
        /// <returns>
        /// Una expresión que representa al constructor.
        /// </returns>
        private static Func<PropertyKey, DevicePropertyDescription, object, IDeviceProperty> ExpressConstructor(Type type, Type[] argTypes)
        {
            ConstructorInfo ctorInfo = type.GetConstructors(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic).First();

            ParameterExpression key = Expression.Parameter(argTypes[0], "propertykey");
            ParameterExpression desc = Expression.Parameter(argTypes[1], "description");
            ParameterExpression value = Expression.Parameter(typeof(object), "value");
            NewExpression create = Expression.New(ctorInfo, key, desc, value);

            return Expression.Lambda<Func<PropertyKey, DevicePropertyDescription, object, IDeviceProperty>>(create, key, desc, value).Compile();
        }
        #endregion
    }
}
