public class Point : IPoint
{
    private float x, y;

    public Point()
    {
        this.x = 0;
        this.y = 0;
    }

    public float GetX()
    {
        return this.x;
    }

    public float GetY()
    {
        return this.y;
    }

    public void SetX(float x)
    {
        this.x = x;
    }
    public void SetY(float y)
    {
        this.y = y;
    }
}