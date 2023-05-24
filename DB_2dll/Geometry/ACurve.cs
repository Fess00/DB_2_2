public abstract class ACurve : ICurve
{
    private IDrawer drawer;

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