
namespace iTin.Core.ComponentModel
{
    using System;
    
    /// <summary>    
    /// Especifica una descripción para un elemento de tipo enumerado.       
    /// </summary>
    [AttributeUsage(AttributeTargets.Field)]
    public sealed class TagAttribute : Attribute
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TagAttribute"/> class. 
        /// </summary>
        /// <param name="value">Custom value.</param>
        public TagAttribute(object value)            
        {
            Value = value;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <value>
        /// </value>
        public object Value { get; }
    }
}
