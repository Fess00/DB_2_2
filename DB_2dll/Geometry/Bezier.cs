using System;

public class Bezier : ACurve
{
    private IPoint c, d;

    public Bezier(IPoint a, IPoint b, IPoint c, IPoint d) : base(a, b)
    {
        this.a = a;
        this.b = b;
        this.c = c;
        this.d = d;
    }

    public override void GetPoint(float t, out IPoint p)
    {
        IPoint pTemp = new Point();
        float aP = ((float)Math.Pow((1 - t), 3)) * a.GetX() + 3 * t * ((float)Math.Pow((1 - t), 2)) *
         c.GetX() + 3 * ((float)Math.Pow(t, 2)) * (1 - t) * d.GetX() + ((float)Math.Pow(t, 3)) * b.GetX();
        float bP = ((float)Math.Pow((1 - t), 3)) * a.GetY() + 3 * t * ((float)Math.Pow((1f - t), 2)) *
         c.GetY() + 3 * ((float)Math.Pow(t, 2)) * (1f - t) * d.GetY() + ((float)Math.Pow(t, 3)) * b.GetY();
        pTemp.SetX(aP);
        pTemp.SetY(bP);
        p = pTemp;
    }
}