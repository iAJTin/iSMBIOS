
namespace iTin.Core.ComponentModel.Patterns
{
    using System;
    using System.Diagnostics;

    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class ExpressionSpecification<T> : CompositeSpecification<T>
    {
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private readonly Func<T, bool> _expression;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="expression"></param>
        public ExpressionSpecification(Func<T, bool> expression) => _expression = expression ?? throw new ArgumentNullException();

        /// <summary>
        /// 
        /// </summary>
        /// <param name="candidate"></param>
        /// <returns></returns>
        public override bool IsSatisfiedBy(T candidate) => _expression(candidate);
    }
}
