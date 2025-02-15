namespace LuaMC.UI.SDK;

using System.Drawing;
using System.Windows.Forms;

public class MenuRenderer : ToolStripProfessionalRenderer
{
    protected override void OnRenderMenuItemBackground(ToolStripItemRenderEventArgs e)
    {
        if (e.Item.Selected)
            e.Graphics.FillRectangle(new SolidBrush(Color.FromArgb(64, 72, 86)), 0, 0, e.Item.Width, e.Item.Height);
        else e.Graphics.FillRectangle(new SolidBrush(Color.FromArgb(46, 50, 58)), 0, 0, e.Item.Width, e.Item.Height);
    }

    protected override void OnRenderImageMargin(ToolStripRenderEventArgs e)
    {
        e.Graphics.Clear(Color.FromArgb(46, 50, 58));
    }

    protected override void OnRenderToolStripBackground(ToolStripRenderEventArgs e)
    {
        e.Graphics.FillRectangle(new SolidBrush(Color.FromArgb(46, 50, 58)), 0, 0, e.ToolStrip.Width, e.ToolStrip.Height);
    }

    protected override void OnRenderSeparator(ToolStripSeparatorRenderEventArgs e)
    {
        e.Graphics.FillRectangle(new SolidBrush(Color.FromArgb(46, 50, 58)), 0, 0, e.ToolStrip.Width, e.ToolStrip.Height);
        e.Graphics.FillRectangle(new SolidBrush(Color.FromArgb(41, 45, 50)), 30, 0, e.ToolStrip.Width, 2);
    }

    protected override void OnRenderToolStripBorder(ToolStripRenderEventArgs e)
    {
        if (e.ToolStrip is ToolStripDropDown)
            e.Graphics.DrawRectangle(new Pen(Color.FromArgb(41, 45, 50)), 0, 0, e.ToolStrip.Width - 1, e.ToolStrip.Height - 1);
    }
}
