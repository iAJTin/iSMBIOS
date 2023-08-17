﻿
using System;

namespace iTin.Core.ComponentModel.Enums;

/// <summary>
/// Defines known windows programs
/// </summary>
[Serializable]
public enum WinProgram
{
    /// <summary>
    /// Notepad program
    /// </summary>
    [EnumDescription("Notepad")]
    Notepad,

    /// <summary>
    /// Notepad++ program
    /// </summary>
    [EnumDescription("Notepad++")]
    NotepadPlusPlus,

    /// <summary>
    /// Paint program
    /// </summary>
    [EnumDescription("Paint")]
    Paint
}