
namespace iTin.Core.Hardware.Device.DeviceProperty
{
    using System;
    using System.Linq;
    using System.Linq.Expressions;
    using System.Reflection;

    /// <summary>
    /// Factory for the creation of strongly typed objects of type <strong>DeviceProperty</strong>.
    /// </summary>
    internal static class DevicePropertyFactory
    {
        #region [public] {static} (IDeviceProperty) CreateTypedDeviceProperty(PropertyKey, object): Gets a reference to an object that implements the IDeviceProperty interface, represents the strongly typed value of the property
        /// <summary>
        /// Gets a reference to an object that implements the <see cref="IDeviceProperty"/> interface, represents the strongly typed value of the property.
        /// </summary>
        /// <param name="key">Property key</param>
        /// <param name="value">Property value</param>
        /// <returns>
        /// Reference to the object that represents the strongly typed value of the property.
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

        #region [private] {static} (Func<PropertyKey, DevicePropertyDescription, object, IDeviceProperty>) ExpressConstructor(Type, Type[]): Create an expression for the specific constructor of the given type
        /// <summary>
        /// Create an expression for the specific constructor of the given type.
        /// </summary>
        /// <param name="type">Type that represents the class from which the expression is created</param>
        /// <param name="argTypes">Array of types that represent the types expected by the constructor</param>
        /// <returns>
        /// An expression that represents the constructor.
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
