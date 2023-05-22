using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

public abstract class Drawer : IDrawer
{
    public abstract void Draw(ICurve iCurve);

    public abstract void SaveSVG();
}