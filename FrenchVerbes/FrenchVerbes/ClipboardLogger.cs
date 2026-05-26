using System.Text;

namespace FrenchVerbes;

public static class ClipboardLogger
{
    public static readonly StringBuilder Buffer = new();

    public static void Reset() => Buffer.Clear();

    public static void CopyToClipboard()
    {
        string text = Buffer.ToString();

        using var process = new System.Diagnostics.Process();
        process.StartInfo = new System.Diagnostics.ProcessStartInfo
        {
            FileName = "clip",
            UseShellExecute = false,
            RedirectStandardInput = true,
            CreateNoWindow = true
        };

        process.Start();
        process.StandardInput.Write(text);
        process.StandardInput.Close();
        process.WaitForExit();
    }
}
