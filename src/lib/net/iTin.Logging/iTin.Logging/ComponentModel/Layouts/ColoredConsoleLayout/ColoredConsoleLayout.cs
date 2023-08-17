
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace iTin.Logging.ComponentModel;

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
    private List<ColoredConsoleMapping> _mappings = new();

    #endregion

    #region constructor/s

    /// <summary>
    /// Initializes a new instance of the <see cref="ColoredConsoleLayout" /> class.
    /// </summary>
    public ColoredConsoleLayout()
    {
        _mappings.AddRange(Default);
    }

    #endregion

    #region public properties

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

    #region public methods

    /// <summary>
    /// Returns the mappings for specified log level
    /// </summary>
    /// <param name="level">The log level.</param>
    /// <returns>
    /// A <see cref="ColoredConsoleMapping"/> for specified log level.
    /// </returns>
    public ColoredConsoleMapping GetMapping(LogLevel level)
    {
        var target = _mappings.FirstOrDefault(mapping => mapping.Level == level);

        return target ?? ColoredConsoleMapping.NotFoundMapping;
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
