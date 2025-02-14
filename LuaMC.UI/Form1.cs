namespace LuaMC.UI;

using System;
using System.Drawing;
using System.IO;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using System.Windows.Forms;

using LuaMC.UI.SDK;

using Microsoft.Web.WebView2.Core;

public partial class Form1 : ControlForm
{
    public Form1()
    {
        InitializeComponent();

        Size = new Size(768, 569);

        ConsoleRediect.Init(output); // for the C# side
        _LuaMC.SetLogCallback(Console.WriteLine); // for the C++ side

        TitleBar.SetMovable(this, menuStrip1);

        // some moree titlebar setup..
        Titlebar_MinBtn.Text = "\ue921";
        Titlebar_MinMaxBtn.Text = "\ue737"; // e73f/backtowindow
        Titlebar_XBtn.Text = "\ue8bb";

        Titlebar_MinBtn.Click += (s, e) => WindowState = FormWindowState.Minimized;
        Titlebar_MinMaxBtn.Click += (s, e) => WindowState = WindowState == FormWindowState.Maximized ? FormWindowState.Normal : FormWindowState.Maximized;
        Titlebar_XBtn.Click += (s, e) => Application.Exit();

        // some animations for the titlebar btns
        Titlebar_MinBtn.MouseEnter += TitlebarBtn_MouseEnter;
        Titlebar_MinBtn.MouseLeave += TitlebarBtn_MouseLeave;
        Titlebar_MinMaxBtn.MouseEnter += TitlebarBtn_MouseEnter;
        Titlebar_MinMaxBtn.MouseLeave += TitlebarBtn_MouseLeave;
        Titlebar_XBtn.MouseEnter += TitlebarBtn_MouseEnter;
        Titlebar_XBtn.MouseLeave += TitlebarBtn_MouseLeave;
    }

    // hover
    public void TitlebarBtn_MouseEnter(object sender, EventArgs e)
    {
        var btn = (Label)sender;
        btn.ForeColor = Color.FromArgb(255, 255, 255);
        btn.BackColor = Color.FromArgb(53+15, 57 + 15, 65 + 15);
    }

    // leave
    public void TitlebarBtn_MouseLeave(object sender, EventArgs e)
    {
        var btn = (Label)sender;
        btn.ForeColor = Color.Gray;
        btn.BackColor = Color.FromArgb(46, 50, 58);
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
        // temp shit
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
    
    private void outputConsoleToolStripMenuItem_Click(object sender, EventArgs e) => OutputConsole.Visible = !OutputConsole.Visible;
    private void exitToolStripMenuItem_Click_1(object sender, EventArgs e) => Application.Exit();

    private async void buildToolStripMenuItem_Click_1(object sender, EventArgs e)
    {
        label2.Text = "Building..";
        output.Clear();
        Console.WriteLine("[LuaMC.UI] Build started..");
        _LuaMC.Build(await GetText(), "./Build/");
        Console.WriteLine("[LuaMC.UI] Build completed..");
        label2.Text = "Build Successful";
    }
}
