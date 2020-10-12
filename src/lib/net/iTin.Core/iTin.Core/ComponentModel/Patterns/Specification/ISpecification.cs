
namespace iTin.Core.ComponentModel.Patterns
{
    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface ISpecification<T>
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="candidate"></param>
        /// <returns></returns>
        bool IsSatisfiedBy(T candidate);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="other"></param>
        /// <returns></returns>
        ISpecification<T> And(ISpecification<T> other);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="other"></param>
        /// <returns></returns>
        ISpecification<T> AndNot(ISpecification<T> other);

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        ISpecification<T> Not();

        /// <summary>
        /// 
        /// </summary>
        /// <param name="other"></param>
        /// <returns></returns>
        ISpecification<T> Or(ISpecification<T> other);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="other"></param>
        /// <returns></returns>
        ISpecification<T> OrNot(ISpecification<T> other);
    }
}
