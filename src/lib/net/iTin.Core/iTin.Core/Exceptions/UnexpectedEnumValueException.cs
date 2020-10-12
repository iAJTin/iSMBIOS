          
namespace iTin.Core.Exceptions
{
    /// <summary>
    /// Class UnexpectedEnumValueException.
    /// </summary>
    /// <seealso cref="Exception" />
    public class UnexpectedEnumValueException<T> : Exception
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UnexpectedEnumValueException&lt;T&gt;"/> class.
        /// </summary>
        /// <param name="resourceKey">The resource key.</param>
        public UnexpectedEnumValueException(string resourceKey) : base("iTin.Core.Localization.Exceptions.UnexpectedEnumValueException", resourceKey)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UnexpectedEnumValueException&lt;T&gt;"/> class.
        /// </summary>
        public UnexpectedEnumValueException() : base("iTin.Core.Localization.Exceptions.UnexpectedEnumValueException", "UNEXPECTED_ENUM_VALUE")
        {
        }

        /// <inheritdoc />
        /// <summary>
        /// Initializes a new instance of the <see cref="UnexpectedEnumValueException&lt;T&gt;"/> class.
        /// </summary>
        /// <param name="value">Unexpected value.</param>
        public UnexpectedEnumValueException(T value) : base("iTin.Core.Localization.Exceptions.UnexpectedEnumValueException", "UNEXPECTED_ENUM_VALUE")
        {
        }
    }
}
