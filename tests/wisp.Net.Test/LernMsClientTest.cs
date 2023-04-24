namespace wisp.Net.Test;

using System;
using System.Threading;
using System.Threading.Tasks;
using wisp.Net;
using Xunit;
using Xunit.Abstractions;


/// <summary></summary>
public class LernMsClientTest : IDisposable
{
    private readonly LernMsClient _client;
    private readonly ITestOutputHelper _outputHelper;

    /// <summary></summary>
    public LernMsClientTest(ITestOutputHelper outputHelper)
    {
        _outputHelper = outputHelper;
        _client = new (new Uri("https://learn.microsoft.com/"));
    }


    /// <summary></summary>
    [Fact]
    public async Task GetTextToSpeechSupportLanguagesAsyncTest()
    {
        var langs = await _client.GetTextToSpeechSupportLanguagesAsync(CancellationToken.None);
        foreach(var tts in langs)
        {
            _outputHelper.WriteLine($"{tts.Locale} {tts.Language}");
            foreach(var voice in tts.Voices)
            {
                _outputHelper.WriteLine($"\t{voice}");
            }
        }

        await wisp.IO.Json.WriteAsync("tts_supports.json", langs, CancellationToken.None);
    }


    /// <summary></summary>
    public void Dispose()
    {
        _client.Dispose();
    }
}
