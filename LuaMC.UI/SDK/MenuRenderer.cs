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

    protected override void OnRenderToolStripBackground(ToolStripRenderEventArgs e)
    {
        e.Graphics.FillRectangle(new SolidBrush(Color.FromArgb(46, 50, 58)), 0, 0, e.ToolStrip.Width, e.ToolStrip.Height);
    }

    protected override void OnRenderToolStripBorder(ToolStripRenderEventArgs e) { }
}
