using System;
public class Line : ACurve
{
    IPoint a, b;

    public Line(IPoint a, IPoint b)
    {
        this.a = a;
        this.b = b;
    }

    public override void GetPoint(float t, out IPoint p)
    {
        IPoint pTemp = new Point();
        float aP = (1f - t) * a.GetX() + t * b.GetX();
        float bP = (1f - t) * a.GetY() + t * b.GetY();
        pTemp.SetX(aP);
        pTemp.SetY(bP);
        p = pTemp;
    }
}