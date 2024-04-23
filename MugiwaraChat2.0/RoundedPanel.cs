using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

public class RoundedPanel : Panel
{
    private int _cornerRadius = 100;

    public int CornerRadius
    {
        get { return _cornerRadius; }
        set
        {
            _cornerRadius = value;
            Invalidate(); // Redraw the panel when corner radius changes
        }
    }

    protected override void OnPaint(PaintEventArgs e)
    {
        base.OnPaint(e);
        using (GraphicsPath path = CreateRoundedRectanglePath(ClientRectangle, CornerRadius))
        using (Pen pen = new Pen(BackColor, 1))
        {
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            e.Graphics.DrawPath(pen, path);
        }
    }

    private GraphicsPath CreateRoundedRectanglePath(Rectangle bounds, int cornerRadius)
    {
        int diameter = cornerRadius * 2;
        Size size = new Size(diameter, diameter);
        Rectangle arc = new Rectangle(bounds.Location, size);
        GraphicsPath path = new GraphicsPath();

        path.AddArc(arc, 180, 90); // Top left corner
        arc.X = bounds.Right - diameter;
        path.AddArc(arc, 270, 90); // Top right corner
        arc.Y = bounds.Bottom - diameter;
        path.AddArc(arc, 0, 90);   // Bottom right corner
        arc.X = bounds.Left;
        path.AddArc(arc, 90, 90);  // Bottom left corner

        path.CloseFigure(); // Close the path

        return path;
    }
}
