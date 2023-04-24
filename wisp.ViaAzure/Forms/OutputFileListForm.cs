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
public partial class OutputFileListForm : Form
{
    /// <summary></summary>
    private ListViewItem[]? _wavFileListItems = null;

    /// <summary></summary>
    public OutputFileListForm()
    {
        InitializeComponent();
    }


    /// <summary></summary>
    private void OnShown(object source, EventArgs e)
    {
        directoryPathText.Text = Program.AppWavDirectoryPath;

        _wavFileListItems = Directory.GetFiles(path: Program.AppWavDirectoryPath)
            .Where(path => Path.GetExtension(path).ToLower() == ".wav")
            .Select(path => new ListViewItem(new string[] { Path.GetFileName(path), path }))
            .ToArray();

        outputFileList.VirtualListSize = _wavFileListItems.Length;
        outputFileList.Refresh();
    }

    /// <summary></summary>
    private void OnOpenClick(object source, EventArgs e)
    {
        try
        {
            using var p = Process.Start(new ProcessStartInfo(
                        fileName: "explorer.exe",
                        arguments: directoryPathText.Text)
                    {
                        UseShellExecute = false
                    });
        }
        catch(Exception ex)
        {
#if DEBUG
            Debug.WriteLine($"ERROR | {ex.GetType().FullName} {ex.Message}");
            Debug.WriteLine(ex.StackTrace);
#endif
        }
    }

    /// <summary></summary>
    private void OnOutputFileRetrieveVirtualItem(object source, RetrieveVirtualItemEventArgs e)
    {
        if(_wavFileListItems != null
                && _wavFileListItems.Length > e.ItemIndex)
        {
            e.Item = _wavFileListItems[e.ItemIndex];
        }
    }
}
