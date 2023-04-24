namespace wisp.ViaAzure.Forms;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


/// <summary></summary>
public partial class AzureSpeachServiceConfigForm : Form
{
    /// <summary></summary>
    public AzureConfig? AzureConfig
    {
        set
        {
            _azureConfig = value;

            if (value != null)
            {
                keyText.Text = value.SpeechKey;
                regionText.Text = value.SpeechRegion;
            }
        }
        get => _azureConfig;
    }


    private AzureConfig? _azureConfig = null;


    /// <summary></summary>
    public AzureSpeachServiceConfigForm()
    {
        InitializeComponent();
    }

    #region private Events
    /// <summary></summary>
    private void OnKeyUp(object source, KeyEventArgs e)
    {
        switch(e.KeyCode)
        {
            case Keys.Escape:
                DialogResult = DialogResult.Cancel;
                return;
        }
    }

    /// <summary></summary>
    private async void OnApplyClick(object source, EventArgs e)
    {
        string key = keyText.Text,
               region = regionText.Text;

        if (string.IsNullOrEmpty(key)
                || string.IsNullOrEmpty(region))
        {
            MessageBox.Show(
                    caption: "警告",
                    text: "Key もしくは Region が入力されていません.",
                    icon: MessageBoxIcon.Warning,
                    buttons: MessageBoxButtons.OK);

            return;
        }

        _azureConfig = new AzureConfig()
        {
            SpeechKey = keyText.Text,
            SpeechRegion = regionText.Text
        };

        // 保存
        try
        {
            await wisp.IO.Json.WriteAsync("azure.json", _azureConfig, CancellationToken.None);
        }
        catch (Exception ex)
        {
#if DEBUG
            Debug.WriteLine($"ERROR | {ex.GetType().FullName} {ex.Message}");
            Debug.WriteLine(ex.StackTrace);
#endif
        }

        DialogResult = DialogResult.OK;
    }
    #endregion
}
