
namespace iTin.Logging.ComponentModel
{
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.Linq;

    /// <summary>
    /// Defines a layout for <see cref="ConsoleLog"/> logger.
    /// </summary>
    public class ConsoleLayout : ILayout
    {
        #region private static readonly members
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static readonly IEnumerable<ConsoleMapping> Default = new[] { ConsoleMapping.DefaultFatalMapping, ConsoleMapping.DefaultErrorMapping, ConsoleMapping.DefaultInfoMapping, ConsoleMapping.DefaultDebugMapping, ConsoleMapping.DefaultWarnMapping };
        #endregion

        #region private members
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private List<ConsoleMapping> _mappings = new List<ConsoleMapping>();
        #endregion

        #region constructor/s

        #region [public] ConsoleLayout(): Initializes a new instance of the class
        /// <summary>
        /// Initializes a new instance of the <see cref="ConsoleLayout" /> class.
        /// </summary>
        public ConsoleLayout()
        {
            _mappings.AddRange(Default);
        }
        #endregion

        #endregion

        #region public properties

        #region [public] (IEnumerable<ConsoleMapping>) Mappings: Defined mappings collection for this instance
        /// <summary>
        /// Defined mappings collection for this instance.
        /// </summary>
        /// <value>
        /// A <see cref="IEnumerable{ConsoleMapping}"/> for this instance.
        /// </value>
        public IEnumerable<ConsoleMapping> Mappings
        {
            get => _mappings;
            set => _mappings = (List<ConsoleMapping>) value;
        }
        #endregion

        #endregion

        #region public methods

        #region [public] (ConsoleMapping) GetMapping(LogLevel): Returns the mappings for specified log level
        /// <summary>
        /// Returns the mappings for specified log level
        /// </summary>
        /// <param name="level">The log level.</param>
        /// <returns>
        /// A <see cref="ConsoleMapping"/> for specified log level.
        /// </returns>
        public ConsoleMapping GetMapping(LogLevel level)
        {
            ConsoleMapping target = _mappings.FirstOrDefault(mapping => mapping.Level == level);

            return target ?? ConsoleMapping.NotFoundMapping;
        }
        #endregion

        #endregion

        #region protected methods

        #region [public] (string) {override} ToString(): Returns a string that represents this instance
        /// <summary>
        /// Returns a <see cref="System.String" /> that represents this instance.
        /// </summary>
        /// <returns>A <see cref="System.String" /> that represents this instance.</returns>
        public override string ToString()
        {
            return $"Mappings={Mappings.Count()}";
        }
        #endregion

        #endregion
    }
}
