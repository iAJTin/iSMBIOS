
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace iTin.Logging.ComponentModel;

/// <summary>
/// Defines a layout for <see cref="FileLog"/> logger.
/// </summary>
public class FileLogLayout : ILayout
{
    #region private static readonly members

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IEnumerable<FileMapping> Default = new[] { FileMapping.DefaultFatalMapping, FileMapping.DefaultErrorMapping, FileMapping.DefaultInfoMapping, FileMapping.DefaultDebugMapping, FileMapping.DefaultWarnMapping };

    #endregion

    #region private members

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private List<FileMapping> _mappings = new();

    #endregion

    #region constructor/s

    /// <summary>
    /// Initializes a new instance of the <see cref="FileLogLayout" /> class.
    /// </summary>
    public FileLogLayout()
    {
        _mappings.AddRange(Default);
    }

    #endregion

    #region public properties

    /// <summary>
    /// Defined mappings collection for this instance.
    /// </summary>
    /// <value>
    /// A <see cref="IEnumerable{FileMapping}"/> for this instance.
    /// </value>
    public IEnumerable<FileMapping> Mappings
    {
        get => _mappings;
        set => _mappings = (List<FileMapping>)value;
    }

    #endregion

    #region public methods

    /// <summary>
    /// Returns the mappings for specified log level
    /// </summary>
    /// <param name="level">The log level.</param>
    /// <returns>
    /// A <see cref="FileMapping"/> for specified log level.
    /// </returns>
    public FileMapping GetMapping(LogLevel level)
    {
        var target = _mappings.FirstOrDefault(mapping => mapping.Level == level);

        return target ?? FileMapping.NotFoundMapping;
    }

    #endregion

    #region protected override methods

    /// <summary>
    /// Returns a <see cref="T:System.String" /> that represents this instance.
    /// </summary>
    /// <returns>A <see cref="T:System.String" /> that represents this instance.</returns>
    public override string ToString() => $"Mappings={Mappings.Count()}";

    #endregion
}
