namespace wisp.ViaAzure;

/// <summary>Azure 設定</summary>
public sealed class AzureConfig
{
    /// <summary></summary>
    public bool IsEncrypted { set; get; } = false;

    /// <summary></summary>
    public string SpeechKey { set; get; } = string.Empty;

    /// <summary></summary>
    public string SpeechRegion { set; get; } = string.Empty;
}
