
using System;

namespace iTin.Core.ComponentModel
{
    /// <summary>    
    /// Specifies an additional custom value for an enumerated type element.
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
        /// Gets or sets the custom tag value.
        /// </summary>
        /// <value>
        /// The custom tag value
        /// </value>
        public object Value { get; }
    }
}
