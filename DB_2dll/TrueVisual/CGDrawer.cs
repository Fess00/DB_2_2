using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;

public class CGDrawer : Drawer
{
    private List<PointF> lp;
    public override void Draw(ICurve iCurve)
    {
        IPoint point = new Point();
        Pen greenPen = new Pen(Color.Green, 3);
        greenPen.CustomEndCap = new AdjustableArrowCap(5, 5);
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
            if (i == 0)
            {
                g.FillEllipse(new SolidBrush(Color.Green), (int)point.GetX(), (int)point.GetY(), 7, 7);
            }
        }
        g.DrawBezier(greenPen, lp[0], lp[1], lp[2], lp[3]);
        bmp.Save(@"C:\Users\User\Documents\Code\C#\UserInterfaceDB_2\DB_2_2\UserInterfaceDB_2\SavedFiles\CGD.png", System.Drawing.Imaging.ImageFormat.Png);
        g.Dispose();
    }

    public override void SaveSVG()
    {
        string documentContent = $"<svg width=\"{1000}\" height=\"{700}\" xmlns=\"http://www.w3.org/2000/svg\"><circle cx=\"{(int)lp[0].X}\" cy=\"{(int)lp[0].Y}\" r=\"2\" fill=\"green\"/><path d=\"M {(int)lp[0].X} {(int)lp[0].Y} C {(int)lp[1].X} {(int)lp[1].Y}, {(int)lp[2].X} {(int)lp[2].Y}, {(int)lp[3].X} {(int)lp[3].Y}\" stroke=\"green\" fill=\"transparent\"/></svg>";
        File.WriteAllText(@"C:\Users\User\Documents\Code\C#\UserInterfaceDB_2\DB_2_2\UserInterfaceDB_2\SavedFiles\CGD.svg", documentContent);  
    }
}