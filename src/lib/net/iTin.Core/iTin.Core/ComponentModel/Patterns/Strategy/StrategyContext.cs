
using System.Diagnostics;

namespace iTin.Core.ComponentModel.Patterns
{
    /// <summary>
    /// 
    /// </summary>
    public abstract class StrategyContext
    {
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private readonly IStrategy _strategy;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="strategy"></param>
        protected StrategyContext(IStrategy strategy) => _strategy = strategy;

        /// <summary>
        /// 
        /// </summary>
        public void Execute() => _strategy.Execute();
    }
}
