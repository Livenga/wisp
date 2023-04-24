namespace wisp.Net;

using System;
using System.Collections.Generic;


/// <summary></summary>
public class TextToSpeechLanguage
{
    /// <summary></summary>
    public string Locale { set; get; } = string.Empty;

    /// <summary></summary>
    public string Language { set; get; } = string.Empty;

    /// <summary></summary>
    public IEnumerable<string> Voices { set; get; } = Array.Empty<string>();
}
