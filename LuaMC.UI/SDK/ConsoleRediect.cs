namespace LuaMC.UI.SDK;

using System;
using System.IO;
using System.Text;
using System.Windows.Forms;

public class TextBoxWriter : TextWriter
{
    public override Encoding Encoding => Encoding.UTF8;

    private void _Write(string data)
    {
        if (ConsoleRediect.output.InvokeRequired)
            ConsoleRediect.output.Invoke(new Action<string>(Write), data);
        else ConsoleRediect.output.AppendText(data);
    }

    public override void Write(string value) => _Write(value);
    public override void WriteLine() => _Write("\r\n");
    public override void WriteLine(string value) => _Write(value + "\r\n");
}

public class ConsoleRediect
{
    public static TextBox output;
    public static void Init(TextBox _output)
    {
        output = _output;
        Console.SetOut(new TextBoxWriter());
    }
}
