
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace iTin.Logging.ComponentModel
{
    /// <summary>
    /// Defines a layout for <see cref="ColoredConsoleLog"/> logger.
    /// </summary>
    public class ColoredConsoleLayout : ILayout
    {
        #region private static readonly members
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static readonly IEnumerable<ColoredConsoleMapping> Default = new[] { ColoredConsoleMapping.DefaultFatalMapping, ColoredConsoleMapping.DefaultErrorMapping, ColoredConsoleMapping.DefaultInfoMapping, ColoredConsoleMapping.DefaultDebugMapping, ColoredConsoleMapping.DefaultWarnMapping };
        #endregion

        #region private members
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private List<ColoredConsoleMapping> _mappings = new List<ColoredConsoleMapping>();
        #endregion

        #region constructor/s

        #region [public] ColoredConsoleLayout(): Initializes a new instance of the class
        /// <summary>
        /// Initializes a new instance of the <see cref="ColoredConsoleLayout" /> class.
        /// </summary>
        public ColoredConsoleLayout()
        {
            _mappings.AddRange(Default);
        }
        #endregion

        #endregion

        #region public properties

        #region [public] (IEnumerable<ColoredConsoleMapping>) Mappings: Defined mappings collection for this instance
        /// <summary>
        /// Defined mappings collection for this instance.
        /// </summary>
        /// <value>
        /// A <see cref="IEnumerable{ColoredMapping}"/> for this instance.
        /// </value>
        public IEnumerable<ColoredConsoleMapping> Mappings
        {
            get => _mappings;
            set => _mappings = (List<ColoredConsoleMapping>) value;
        }
        #endregion

        #endregion

        #region public methods

        #region [public] (ColoredConsoleMapping) GetMapping(LogLevel): Returns the mappings for specified log level
        /// <summary>
        /// Returns the mappings for specified log level
        /// </summary>
        /// <param name="level">The log level.</param>
        /// <returns>
        /// A <see cref="ColoredConsoleMapping"/> for specified log level.
        /// </returns>
        public ColoredConsoleMapping GetMapping(LogLevel level)
        {
            ColoredConsoleMapping target = _mappings.FirstOrDefault(mapping => mapping.Level == level);

            return target ?? ColoredConsoleMapping.NotFoundMapping;
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
