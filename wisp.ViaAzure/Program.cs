namespace wisp.ViaAzure;

using System;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Threading;
using System.Threading.Tasks;


/// <summary></summary>
internal static class Program
{
    /// <summary></summary>
    public static AzureConfig? AzureConfig { set; get; } = null;

    /// <summary></summary>
    public static string AppDirectoryPath => _appDirectoryPath ?? throw new NullReferenceException();

    /// <summary></summary>
    public static string AppWavDirectoryPath => _appWavDirectoryPath ?? throw new NullReferenceException();


    private static string? _appDirectoryPath = null;
    private static string? _appWavDirectoryPath = null;


    /// <summary>
    ///  The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main()
    {
        InitAsync(CancellationToken.None).Wait();

        ApplicationConfiguration.Initialize();
        Application.Run(new MainForm());
    }


    /// <summary></summary>
    private static async Task InitAsync(CancellationToken cancellationToken = default(CancellationToken))
    {
        _appDirectoryPath = TryCreateDirectory(
                Path.Combine(
                    Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData),
                    Assembly.GetExecutingAssembly().GetName().Name ?? "wisp.ViaAzure"));

        _appWavDirectoryPath = TryCreateDirectory(Path.Combine(_appDirectoryPath, "wav"));

        try
        {
            AzureConfig = await wisp.IO.Json.ReadAsync<AzureConfig>("azure.json", cancellationToken);
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
    private static string TryCreateDirectory(string path)
    {
        if(Directory.Exists(path))
            return path;

        try
        {
            return Directory.CreateDirectory(path).FullName;
        }
        catch
        {
            return ".";
        }
    }
}
