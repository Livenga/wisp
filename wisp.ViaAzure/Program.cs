namespace wisp.ViaAzure;

using System;
using System.Threading;
using System.Threading.Tasks;


/// <summary></summary>
internal static class Program
{
    /// <summary></summary>
    public static AzureConfig? AzureConfig { set; get; } = null;


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
        try
        {
            AzureConfig = await wisp.IO.Json.ReadAsync<AzureConfig>("azure.json", cancellationToken);
        }
        catch { }
    }
}
