
using System;
using System.ComponentModel;

namespace iTin.Core.ComponentModel
{
    /// <summary>
    /// Specifies a description for an enumerated type element.
    /// </summary>
    [AttributeUsage(AttributeTargets.Field)]
    public sealed class EnumDescriptionAttribute : DescriptionAttribute
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EnumDescriptionAttribute"/> class. 
        /// </summary>
        /// <param name="description">Description text.</param>
        public EnumDescriptionAttribute(string description) : base(description)
        {
        }
    }
}
