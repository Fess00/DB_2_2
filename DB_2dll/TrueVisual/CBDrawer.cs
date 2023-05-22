using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Drawing;
using System.IO;

public class CBDrawer : Drawer
{
    private List<PointF> lp;
    public override void Draw(ICurve iCurve)
    {
        IPoint point = new Point();
        Pen blackPen = new Pen(Color.Black, 3);
        blackPen.DashStyle = System.Drawing.Drawing2D.DashStyle.DashDotDot;
        Bitmap bmp = new Bitmap(1000, 700);
        Graphics g = Graphics.FromImage(bmp);
        g.FillRectangle(new SolidBrush(Color.White), new Rectangle(0, 0, 1000, 700));

        lp = new List<PointF>();

        float segment = 0;

        for (int i = 0; i <= 3; i++)
        {
            iCurve.GetPoint(segment, out point);
            lp.Add(new PointF(point.GetX(), point.GetY()));
            segment += (1f / 3f);
            if (i == 0 || i == 3)
            {
                g.FillRectangle(new SolidBrush(Color.Black), new Rectangle((int)point.GetX(), (int)point.GetY(), 5, 5));
            }
        }
        g.DrawBezier(blackPen, lp[0], lp[1], lp[2], lp[3]);
        bmp.Save(@"C:\Users\User\Documents\Code\C#\UserInterfaceDB_2\UserInterfaceDB_2\UserInterfaceDB_2\SavedFiles\CBD.png", System.Drawing.Imaging.ImageFormat.Png);
        g.Dispose();
    }

    public override void SaveSVG()
    {
        string documentContent = $"<svg width=\"{1000}\" height=\"{700}\" style=\"stroke-dasharray: 10 10\" xmlns=\"http://www.w3.org/2000/svg\"><rect x=\"{(int)lp[0].X}\" y=\"{(int)lp[0].Y}\" width=\"2\" height=\"2\" stroke=\"black\" fill=\"black\" stroke-width=\"5\"/><path d=\"M {(int)lp[0].X} {(int)lp[0].Y} C {(int)lp[1].X} {(int)lp[1].Y}, {(int)lp[2].X} {(int)lp[2].Y}, {(int)lp[3].X} {(int)lp[3].Y}\" stroke=\"black\" fill=\"transparent\"/><rect x=\"{(int)lp[3].X}\" y=\"{(int)lp[3].Y}\" width=\"2\" height=\"2\" stroke=\"black\" fill=\"black\" stroke-width=\"5\"/></svg>";
        File.WriteAllText(@"C:\Users\User\Documents\Code\C#\UserInterfaceDB_2\UserInterfaceDB_2\UserInterfaceDB_2\SavedFiles\CBD.svg", documentContent); 
    }
}