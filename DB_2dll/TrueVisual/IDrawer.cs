using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

public interface IDrawer
{
    void Draw(ICurve iCurve);
    void SaveSVG();
}