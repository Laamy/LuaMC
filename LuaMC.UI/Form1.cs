namespace LuaMC.UI;

using System;
using System.Drawing;
using System.IO;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using System.Windows.Forms;
using LuaMC.UI.SDK;
using Microsoft.Web.WebView2.Core;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();

        ConsoleRediect.Init(output); // for the C# side
        _LuaMC.SetLogCallback(Console.WriteLine); // for the C++ side
    }

    public async Task<string> GetText()
    {
        var script = new JavaScriptSerializer().Deserialize<string>(
            await webView21.ExecuteScriptAsync("GetText()")
        );

        if (script.Length > 0)
            return script;

        return string.Empty;
    }

    public void SetText(string input)
        => webView21.ExecuteScriptAsync($"SetText({new JavaScriptSerializer().Serialize(input)})");

    private async void Form1_Load(object sender, EventArgs e)
    {
        this.DoubleBuffered = true;

        menuStrip1.Renderer = new MenuRenderer();
        menuStrip1.ForeColor = Color.FromArgb(200, 200, 200);

        await webView21.EnsureCoreWebView2Async();
        var filePath = Path.Combine(Application.StartupPath, "LuaMC.UI_Data", "Editor.html");
        webView21.Source = new Uri($"file:///{filePath}");
        webView21.NavigationCompleted += OnIDE_Load;
        webView21.CoreWebView2.ContextMenuRequested += (s, e) => e.Handled = true;
        webView21.CoreWebView2.Settings.AreDevToolsEnabled = false;
    }

    private void OnIDE_Load(object sender, CoreWebView2NavigationCompletedEventArgs e)
    {
        SetText(@"#author(""opentk"")
#name(""test_datapack"")
#desc(""test datapack description"")

# this executes on load.json & test_datapack:load
say(""Loaded datapack"")

# functon test_datapack:sex
function sex()
	say(""SEX"")
end

#GameEvent(OnTick)
function tick()

end

# functon test_datapack:test
function test()	
	if cache.test >= 2 then
		if cache.test <= 5 then
			say(""cache is within 2-5"")
			gamemode(Survival)
		end
	end
end
");
    }

    private async void buildToolStripMenuItem_Click(object sender, EventArgs e)
    {
        label2.Text = "Building..";
        output.Clear();
        Console.WriteLine("[LuaMC.UI] Build started..");
        _LuaMC.Build(await GetText(), "./Build/");
        Console.WriteLine("[LuaMC.UI] Build completed..");
        label2.Text = "Build Successful";
    }

    private void outputConsoleToolStripMenuItem_Click(object sender, EventArgs e) => OutputConsole.Visible = !OutputConsole.Visible;
    private void exitToolStripMenuItem_Click(object sender, EventArgs e) => Application.Exit();
}
