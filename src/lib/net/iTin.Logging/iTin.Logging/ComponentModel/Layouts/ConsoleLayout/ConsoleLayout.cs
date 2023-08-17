
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace iTin.Logging.ComponentModel;

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
    private List<ConsoleMapping> _mappings = new();

    #endregion

    #region constructor/s

    /// <summary>
    /// Initializes a new instance of the <see cref="ConsoleLayout" /> class.
    /// </summary>
    public ConsoleLayout()
    {
        _mappings.AddRange(Default);
    }

    #endregion

    #region public properties

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

    #region public methods

    /// <summary>
    /// Returns the mappings for specified log level
    /// </summary>
    /// <param name="level">The log level.</param>
    /// <returns>
    /// A <see cref="ConsoleMapping"/> for specified log level.
    /// </returns>
    public ConsoleMapping GetMapping(LogLevel level)
    {
        var target = _mappings.FirstOrDefault(mapping => mapping.Level == level);

        return target ?? ConsoleMapping.NotFoundMapping;
    }

    #endregion

    #region protected override methods

    /// <summary>
    /// Returns a <see cref="System.String" /> that represents this instance.
    /// </summary>
    /// <returns>A <see cref="System.String" /> that represents this instance.</returns>
    public override string ToString() => $"Mappings={Mappings.Count()}";

    #endregion
}
