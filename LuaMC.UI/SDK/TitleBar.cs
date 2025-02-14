using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LuaMC.UI.SDK;

public class TitleBar
{
    public static void SetMovable(ControlForm form, MenuStrip control)
    {
        bool dragging = false;
        Point offset = new Point();

        control.MouseDown += (sender, e) =>
        {
            dragging = true;
            offset = e.Location;
        };

        control.MouseMove += (sender, e) =>
        {
            if (dragging)
            {
                Point currentScreenPos = form.PointToScreen(e.Location);
                form.Location = new Point(currentScreenPos.X - offset.X, currentScreenPos.Y - offset.Y);
            }
        };

        control.MouseUp += (sender, e) =>
        {
            dragging = false;
        };
    }
}
