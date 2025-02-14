using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace LuaMC.UI.SDK;

public class ControlTextBox : TextBox
{
    [DllImport("user32.dll")]
    private static extern int SendMessage(IntPtr hWnd, int msg, IntPtr wp, IntPtr lp);

    private const int WM_VSCROLL = 0x115;
    private const int SB_LINEUP = 0;
    private const int SB_LINEDOWN = 1;

    public ControlTextBox()
    {
        ScrollBars = ScrollBars.None;
        SetStyle(ControlStyles.OptimizedDoubleBuffer | ControlStyles.ResizeRedraw | ControlStyles.Selectable | ControlStyles.AllPaintingInWmPaint, true);
    }

    protected override void OnMouseWheel(MouseEventArgs e)
    {
        if (e.Delta > 0)
            SendMessage(Handle, WM_VSCROLL, (IntPtr)SB_LINEUP, IntPtr.Zero);
        else
            SendMessage(Handle, WM_VSCROLL, (IntPtr)SB_LINEDOWN, IntPtr.Zero);
        base.OnMouseWheel(e);
    }
}
