public abstract class ACurve : ICurve
{
    protected IPoint a, b;

    protected IDrawer drawer;

    public ACurve(IPoint a, IPoint b)
    {
        this.a = a;
        this.b = b;
    }

    public void SetDrawer(IDrawer drawer)
    {
        this.drawer = drawer;
    }

    public void Draw()
    {
        drawer.Draw(this);
    }

    public void SaveSVG()
    {
        drawer.SaveSVG();
    }

    public abstract void GetPoint(float t, out IPoint p);
}