
using System;
using System.ComponentModel;

namespace iTin.Core.ComponentModel
{
    /// <summary>
    /// Specifies a description for an dictionary key.
    /// </summary>
    [AttributeUsage(AttributeTargets.Class)]
    public sealed class KeyDescriptionAttribute : DescriptionAttribute
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="KeyDescriptionAttribute"/> class. 
        /// </summary>
        /// <param name="description">Key description text.</param>
        public KeyDescriptionAttribute(string description) : base(description)
        {
        }
    }
}
