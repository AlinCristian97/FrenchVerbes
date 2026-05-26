using System.Text;

namespace FrenchVerbes;

/// <summary>
/// Writes to both the original console output and the ClipboardLogger buffer simultaneously.
/// </summary>
public sealed class DualWriter : TextWriter
{
    private readonly TextWriter _original;

    public DualWriter(TextWriter original)
    {
        _original = original;
    }

    public override Encoding Encoding => _original.Encoding;

    public override void Write(char value)
    {
        _original.Write(value);
        ClipboardLogger.Buffer.Append(value);
    }

    public override void Write(string? value)
    {
        _original.Write(value);
        ClipboardLogger.Buffer.Append(value);
    }

    public override void WriteLine(string? value)
    {
        _original.WriteLine(value);
        ClipboardLogger.Buffer.AppendLine(value);
    }

    public override void WriteLine()
    {
        _original.WriteLine();
        ClipboardLogger.Buffer.AppendLine();
    }

    protected override void Dispose(bool disposing)
    {
        if (disposing)
            Console.SetOut(_original);
        base.Dispose(disposing);
    }
}
