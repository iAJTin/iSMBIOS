
namespace iTin.Core.ComponentModel.Patterns
{
    using System.Diagnostics;

    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class AndSpecification<T> : CompositeSpecification<T>
    {
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private readonly ISpecification<T> _left;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private readonly ISpecification<T> _right;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="left"></param>
        /// <param name="right"></param>
        public AndSpecification(ISpecification<T> left, ISpecification<T> right)
        {
            _left = left;
            _right = right;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="candidate"></param>
        /// <returns></returns>
        public override bool IsSatisfiedBy(T candidate) => _left.IsSatisfiedBy(candidate) && _right.IsSatisfiedBy(candidate);
    }
}
