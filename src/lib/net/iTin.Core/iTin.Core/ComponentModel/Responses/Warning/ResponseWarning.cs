﻿
namespace iTin.Core.ComponentModel;

/// <summary>
/// Defines a generic result warning
/// </summary>
public class ResponseWarning : IResponseWarning
{
    /// <summary>
    /// Initializes a new instance of the <see cref="ResponseWarning"/> class.
    /// </summary>
    public ResponseWarning()
    {
        Code = string.Empty;
        Message = string.Empty;
    }
        
    /// <summary>
    /// Gets or sets the code.
    /// </summary>
    /// <value>The code.</value>
    public string Code { get; set; }

    /// <summary>
    /// Gets or sets the message.
    /// </summary>
    /// <value>
    /// The message.
    /// </value>
    public string Message { get; set; }

    /// <summary>
    /// Returns a <see cref="string" /> that represents this instance.
    /// </summary>
    /// <returns>
    /// A <see cref="string" /> that represents this instance.
    /// </returns>
    public override string ToString() => $"Code = \"{Code}\"";
}
