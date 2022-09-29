
using System.Diagnostics;

namespace iTin.Core.ComponentModel.Patterns
{
    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class NotSpecification<T> : CompositeSpecification<T>
    {
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private readonly ISpecification<T> _other;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="other"></param>
        public NotSpecification(ISpecification<T> other) => _other = other;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="candidate"></param>
        /// <returns></returns>
        public override bool IsSatisfiedBy(T candidate) => !_other.IsSatisfiedBy(candidate);
    }
}
