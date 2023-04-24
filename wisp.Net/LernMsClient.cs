namespace wisp.Net;

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;


/// <summary></summary>
public class LernMsClient : IDisposable
{
    private readonly Uri _entryPoint;
    private readonly HttpClient _client;
    private readonly AngleSharp.Html.Parser.IHtmlParser _htmlParser;

    /// <summary></summary>
    public LernMsClient(Uri entryPoint)
    {
        _entryPoint = entryPoint;
        _htmlParser = new AngleSharp.Html.Parser.HtmlParser();

        var handler = new HttpClientHandler()
        {
            AllowAutoRedirect = true,
            UseCookies = true,
        };

        _client = new HttpClient(handler);
    }

    /// <summary></summary>
    public async Task<IEnumerable<TextToSpeechLanguage>> GetTextToSpeechSupportLanguagesAsync(CancellationToken cancellationToken = default(CancellationToken))
    {
        AngleSharp.Html.Dom.IHtmlDocument doc;
        using(var stream = await GetAsync<Stream>(
                    new Uri(_entryPoint, "/ja-jp/azure/cognitive-services/speech-service/language-support?tabs=tts#prebuilt-neural-voices"),
                    null,
                    cancellationToken))
        {
            doc = await _htmlParser.ParseDocumentAsync(stream, cancellationToken);
        }

        // Javascript の制御によりブラウザで閲覧する状態とここで参照する生データの状態に相違があります.
        var rows = doc.QuerySelector(@"div#tabgroup_1 > section#tabpanel_1_tts > table")?
            .QuerySelectorAll("tbody > tr")
            .Cast<AngleSharp.Html.Dom.IHtmlTableRowElement>();

        if(rows != null)
        {
            return rows.Select(row => ParseToTextToSpeechLanguage(row));
        }
        else
        {
#if DEBUG
            Debug.WriteLine($"WARN | Rows not found");
#endif
            throw new NullReferenceException();
        }
    }

    /// <summary></summary>
    private TextToSpeechLanguage ParseToTextToSpeechLanguage(AngleSharp.Dom.IElement e)
    {
        var tds = e.QuerySelectorAll("td")
            .Cast<AngleSharp.Html.Dom.IHtmlTableCellElement>()
            .ToArray();

        var voices = tds[2].QuerySelectorAll("code")
            .Select(code => code.TextContent.Trim())
            .ToArray();

        return new TextToSpeechLanguage()
        {
            Locale   = tds[0].TextContent.Trim(),
            Language = tds[1].TextContent.Trim(),
            Voices   = voices
        };
    }

    /// <summary></summary>
    private async Task<T> GetAsync<T>(
            Uri url,
            HttpContent? content = null,
            CancellationToken cancellationToken = default(CancellationToken)) where T : Stream
    {
        using var req = new HttpRequestMessage()
        {
            Content = content,
            Method = HttpMethod.Get,
            RequestUri = url,
        };

#if DEBUG
        Debug.WriteLine($"DEBUG | Get {url}");
#endif
        using var resp = await _client.SendAsync(req, cancellationToken);
#if DEBUG
        Debug.WriteLine($"\t{resp.StatusCode}({(short)resp.StatusCode}) {url}");
#endif
        if(! resp.IsSuccessStatusCode)
        {
            throw new Exception();
        }

        var stream = await ResponseToStreamAsync(resp, cancellationToken);

        return (stream is Stream _stream)
            ? (T)_stream
            : throw new NotSupportedException();
    }

    /// <summary></summary>
    private async Task<Stream> ResponseToStreamAsync(
            HttpResponseMessage message,
            CancellationToken cancellationToken = default(CancellationToken))
    {
        using var src = await message.Content.ReadAsStreamAsync();
        var m = new MemoryStream();

        await src.CopyToAsync(m, 81920, cancellationToken);
        await m.FlushAsync(cancellationToken);

        m.Position = 0;

        return m;
    }

    /// <summary></summary>
    public void Dispose()
    {
        _client.Dispose();
    }
}
