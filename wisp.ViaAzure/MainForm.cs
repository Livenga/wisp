namespace wisp.ViaAzure;

using Microsoft.CognitiveServices.Speech;
using Microsoft.CognitiveServices.Speech.Audio;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;


/// <summary></summary>
public partial class MainForm : Form
{
    private const string TextToSpeechLanguageSupportPath = "tts_supports.json";
    private wisp.Net.TextToSpeechLanguage[]? _supportedLanguages = null;


    /// <summary></summary>
    public MainForm()
    {
        InitializeComponent();
    }

    #region private Events
    /// <summary></summary>
    private void OnLoad(object source, EventArgs e)
    {
        var versionInfo = FileVersionInfo.GetVersionInfo(Assembly.GetExecutingAssembly().Location);
        Text += $" v{versionInfo.ProductVersion}";

#if DEBUG
        speechText.Text = "こんにちは";
#endif
    }

    /// <summary></summary>
    private async void OnShown(object source, EventArgs e)
    {
        try
        {
            _supportedLanguages = (await wisp.IO.Json.ReadAsync<IEnumerable<wisp.Net.TextToSpeechLanguage>>(
                    TextToSpeechLanguageSupportPath,
                    CancellationToken.None))
                .ToArray();

            languageSelector.Items.AddRange(_supportedLanguages.Select(s => $"{s.Locale} {s.Language}").ToArray());
            languageSelector.SelectedIndex = _supportedLanguages.Select((l, idx) => new { Index = idx, Language = l })
                .FirstOrDefault(o => o.Language.Locale == "ja-JP")?
                .Index ?? 0;
        }
        catch (Exception ex)
        {
            MessageBox.Show(
                    caption: "エラー",
                    text: $"初期設定に必要なファイル \"{TextToSpeechLanguageSupportPath}\"に問題があります.\n{ex.Message}",
                    icon: MessageBoxIcon.Error,
                    buttons: MessageBoxButtons.OK);

#if DEBUG
            Debug.WriteLine($"ERROR | {ex.GetType().FullName} {ex.Message}");
            Debug.WriteLine(ex.StackTrace);
#endif
            Close();
        }

        if (Program.AzureConfig == null)
        {
            MessageBox.Show(
                    caption: "警告",
                    text: "Azure - Speech Service を使用するための設定を行う必要があります.",
                    icon: MessageBoxIcon.Warning,
                    buttons: MessageBoxButtons.OK);

            DoAzureConfig();
        }
        if (Program.AzureConfig == null)
        {
            MessageBox.Show(
                    caption: "警告",
                    text: "適切な Azure 設定が検出できませんでした. 終了します.",
                    icon: MessageBoxIcon.Warning,
                    buttons: MessageBoxButtons.OK);

            Close();
        }
    }

    /// <summary></summary>
    private void OnFileOutputMenuClick(object source, EventArgs e)
    {
        using(var dlg = new Forms.OutputFileListForm())
        {
            dlg.ShowDialog(this);
        }
    }

    /// <summary></summary>
    private void OnFileCloseMenuClick(object source, EventArgs e)
    {
        Close();
    }

    /// <summary></summary>
    private void OnSettingsAzureMenuClick(object source, EventArgs e)
    {
        var azureConfig = DoAzureConfig();
    }

    /// <summary></summary>
    private void OnLanguageSelectorSelectedIndexChanged(object source, EventArgs e)
    {
        var idx = languageSelector.SelectedIndex;
        voiceTypeSelector.Items.Clear();
        voiceTypeSelector.Enabled = false;

        if (_supportedLanguages == null || idx > _supportedLanguages.Length)
        {
            // TODO Message
            return;
        }

        voiceTypeSelector.Items.AddRange(_supportedLanguages[idx].Voices.ToArray());
        voiceTypeSelector.SelectedIndex = 0;
        voiceTypeSelector.Enabled = true;
    }

    /// <summary></summary>
    private void OnSupportLanguageReferenceLinkClick(object source, LinkLabelLinkClickedEventArgs e)
    {
        var result = MessageBox.Show(
                caption: "確認",
                text: "既定のブラウザで使用できる音声タイプの詳細ページを開きます.",
                icon: MessageBoxIcon.Question,
                buttons: MessageBoxButtons.YesNo);

        if (result == DialogResult.Yes)
        {
            supportLanguageReferenceLink.Visible = true;
            using var p = Process.Start(new ProcessStartInfo()
            {
                FileName = "https://learn.microsoft.com/ja-jp/azure/cognitive-services/speech-service/language-support?tabs=stt#prebuilt-neural-voices",
                UseShellExecute = true,
            });
        }
    }

    /// <summary></summary>
    private async void OnExecuteTextToSpeechClick(object source, EventArgs e)
    {
        if(Program.AzureConfig == null)
        {
            return;
        }

        if(speechText.Text.Length == 0)
        {
            return;
        }

        var languageIndex = languageSelector.SelectedIndex;
        var voiceType = voiceTypeSelector.SelectedItem as string;
        var language = languageIndex >= 0 && _supportedLanguages != null && _supportedLanguages.Length > languageIndex
            ? _supportedLanguages[languageIndex].Locale
            : null;

        if(language == null || voiceType == null)
        {
            return;
        }

        var speechConfig = SpeechConfig.FromSubscription(
                Program.AzureConfig.SpeechKey,
                Program.AzureConfig.SpeechRegion);

#if DEBUG
        Debug.WriteLine($"Key        : {Program.AzureConfig.SpeechKey}");
        Debug.WriteLine($"Region     : {Program.AzureConfig.SpeechRegion}");
        Debug.WriteLine($"Language   : {language}");
        Debug.WriteLine($"Voice Type : {voiceType}");
        Debug.WriteLine($"Text       : {speechText.Text}");
#endif

        speechConfig.SpeechSynthesisLanguage = language;
        speechConfig.SpeechSynthesisVoiceName = voiceType;

        var path = Path.Combine(
                Program.AppWavDirectoryPath,
                $"{language}_{DateTime.Now.ToString("yyyyMMdd_HHmmss")}.wav");

        using(var audioConfig = AudioConfig.FromWavFileOutput(fileName: path))
        using(var synthesizer = new SpeechSynthesizer(speechConfig, audioConfig))
        {
            try
            {
                executeTextToSpeechButton.Enabled = false;

                await Task.Delay(10);

                using(var result = await synthesizer.SpeakTextAsync(speechText.Text))
                {
                    switch(result.Reason)
                    {
                        case ResultReason.SynthesizingAudioCompleted:
                            MessageBox.Show(
                                    caption: "成功",
                                    text: $"\"{path}\" へ出力を行いました.",
                                    icon: MessageBoxIcon.Information,
                                    buttons: MessageBoxButtons.OK);
                            break;

                        case ResultReason.Canceled:
                            var cancellation = SpeechSynthesisCancellationDetails.FromResult(result: result);
                            if(cancellation.Reason == CancellationReason.Error)
                            {
                                MessageBox.Show(
                                        caption: "エラー",
                                        text: $"音声ファイルへの変換に失敗.\n{cancellation.ErrorCode} {cancellation.ErrorDetails}",
                                        icon: MessageBoxIcon.Error,
                                        buttons: MessageBoxButtons.OK);
                            }
                            break;
                        default:
                            break;
                    }
                }
            }
            catch(Exception ex)
            {
#if DEBUG
                Debug.WriteLine($"ERROR | {ex.GetType().FullName} {ex.Message}");
                Debug.WriteLine(ex.StackTrace);
#endif
                MessageBox.Show(
                        caption: "エラー",
                        text: $"SpeakTextAsync に失敗.\n{ex.GetType().FullName} {ex.Message}",
                        icon: MessageBoxIcon.Error,
                        buttons: MessageBoxButtons.OK);
            }
            finally
            {
                executeTextToSpeechButton.Enabled = true;
            }
        }
    }
    #endregion

    /// <summary></summary>
    private AzureConfig? DoAzureConfig()
    {
        using var dlg = new Forms.AzureSpeachServiceConfigForm();

        dlg.AzureConfig = Program.AzureConfig;

        if (DialogResult.OK == dlg.ShowDialog(this))
        {
            // OK ボタン押下時に入力の確認を行っているため null にならない可能性が極めて高い
            Program.AzureConfig = dlg.AzureConfig ?? throw new NullReferenceException();
        }
        else
        {
            return null;
        }


        return Program.AzureConfig;
    }
}
