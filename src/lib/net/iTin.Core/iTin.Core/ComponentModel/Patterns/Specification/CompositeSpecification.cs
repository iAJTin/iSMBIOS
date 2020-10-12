
namespace iTin.Core.ComponentModel.Patterns
{
    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public abstract class CompositeSpecification<T> : ISpecification<T>
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="candidate"></param>
        /// <returns></returns>
        public abstract bool IsSatisfiedBy(T candidate);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="other"></param>
        /// <returns></returns>
        public ISpecification<T> And(ISpecification<T> other) => new AndSpecification<T>(this, other);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="other"></param>
        /// <returns></returns>
        public ISpecification<T> AndNot(ISpecification<T> other) => new AndNotSpecification<T>(this, other);

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public ISpecification<T> Not() => new NotSpecification<T>(this);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="other"></param>
        /// <returns></returns>
        public ISpecification<T> Or(ISpecification<T> other) => new OrSpecification<T>(this, other);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="other"></param>
        /// <returns></returns>
        public ISpecification<T> OrNot(ISpecification<T> other) => new OrNotSpecification<T>(this, other);
    }
}
